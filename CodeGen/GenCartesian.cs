using System.Text;

namespace CodeGen;

public class GenCartesian : Base
{
    public static Dictionary<char, int> CompIndex = new()
    {
        { 'x', 0 }, { 'y', 1 }, { 'z', 2 }, { 'w', 3 },
        { 'r', 0 }, { 'g', 1 }, { 'b', 2 }, { 'a', 3 },
    };

    public static string SseShuffleMask(char x, char y, char z, char w)
    {
        var a = CompIndex[x] & 0b11;
        var b = CompIndex[y] & 0b11;
        var c = CompIndex[z] & 0b11;
        var d = CompIndex[w] & 0b11;
        var mask = a | (b << 2) | (c << 4) | (d << 6);
        return $"{mask}";
    }

    public static string SseShuffle2Mask(char x, char y)
    {
        var a = CompIndex[x] & 0b11;
        var b = CompIndex[y] & 0b11;
        var mask = a | (b << 1);
        return $"{mask}";
    }

    public override async Task Gen()
    {
        foreach (var tm in TypeMeta.types)
        {
            var type = tm.Key;
            var meta = tm.Value;
            foreach (var _n in Enumerable.Range(2, 4))
            {
                var n = _n;
                var no_align = false;
                if (n == 5)
                {
                    n = 3;
                    no_align = true;
                }
                var align_name = no_align ? "a" : string.Empty;
                var vname = $"{type}{n}{align_name}";

                var byteSize = meta.Size * (n == 3 && !no_align ? 4 : n);
                var bitSize = byteSize * 8;
                var simd = !no_align && meta.Simd && bitSize is 64 or 128 or 256;

                var v3_iz = $" & math.v3_iz_{type}{bitSize}";

                var cartesian = new StringBuilder();
                var xyzw1 = ParallelEnumerable.Range(0, n * n).AsOrdered().Select(i => GetXyzwCartesian2(n, i));
                var rgba1 = ParallelEnumerable.Range(0, n * n).AsOrdered().Select(i => GetRgbaCartesian2(n, i));
                if (simd)
                {
                    cartesian.Append(string.Join("",
                        xyzw1.Concat(rgba1).Select(ab =>
                            $@"    public {type}{2} {ab.a}{ab.b}
    {{
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {{
            {(type is "double" && bitSize is 128 ? $"if (Sse2.IsSupported) return new(Sse2.Shuffle(this.vector, this.vector, {SseShuffle2Mask(ab.a, ab.b)}));" : "")}
            return new(this.{ab.a}, this.{ab.b});
        }}{(ab.u ? $@"
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        {{ 
            this.{ab.a} = value.x; this.{ab.b} = value.y; 
        }}" : "")}
    }}
").ToArray()));
                }
                else
                {
                    cartesian.Append(string.Join("",
                        xyzw1.Concat(rgba1).Select(ab =>
                            $@"    public {type}{2} {ab.a}{ab.b}
    {{
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.{ab.a}, this.{ab.b});{(ab.u ? $@"
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set {{ this.{ab.a} = value.x; this.{ab.b} = value.y; }}" : "")}
    }}
").ToArray()));
                }
                var xyzw2 = ParallelEnumerable.Range(0, n * n * n).AsParallel().AsOrdered()
                    .Select(i => GetXyzwCartesian3(n, i));
                var rgba2 = ParallelEnumerable.Range(0, n * n * n).AsParallel().AsOrdered()
                    .Select(i => GetRgbaCartesian3(n, i));
                if (simd)
                {
                    cartesian.Append(string.Join("",
                        xyzw2.Concat(rgba2)
                            .Select(abc =>
                                $@"    public {type}{3}{align_name} {abc.a}{abc.b}{abc.c}
    {{
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {{
            {(type is "float" && bitSize is 128 ? $"if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, {SseShuffleMask(abc.a, abc.b, abc.c, 'x')}){v3_iz});" : "")}
            {(type is "int" or "uint" && bitSize is 128 ? $"if (Sse2.IsSupported) return new(Sse2.Shuffle(this.vector, {SseShuffleMask(abc.a, abc.b, abc.c, 'x')}){v3_iz});" : "")}
            {(type is "double" or "long" or "ulong" && bitSize is 256 ? $"if (Avx2.IsSupported) return new(Avx2.Permute4x64(this.vector, {SseShuffleMask(abc.a, abc.b, abc.c, 'x')}){v3_iz});" : "")}
            return new(this.{abc.a}, this.{abc.b}, this.{abc.c});
        }}{(abc.u ? $@"
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        {{ 
            this.{abc.a} = value.x; this.{abc.b} = value.y; this.{abc.c} = value.z; 
        }}" : "")}
    }}
").ToArray()));
                }
                else
                {
                    cartesian.Append(string.Join("",
                        xyzw2.Concat(rgba2)
                            .Select(abc =>
                                $@"    public {type}{3}{align_name} {abc.a}{abc.b}{abc.c}
    {{
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.{abc.a}, this.{abc.b}, this.{abc.c});{(abc.u ? $@"
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set {{ this.{abc.a} = value.x; this.{abc.b} = value.y; this.{abc.c} = value.z; }}" : "")}
    }}
").ToArray()));
                }
                var xyzw3 = ParallelEnumerable.Range(0, n * n * n * n).AsParallel().AsOrdered()
                    .Select(i => GetXyzwCartesian4(n, i));
                var rgba3 = ParallelEnumerable.Range(0, n * n * n * n).AsParallel().AsOrdered()
                    .Select(i => GetRgbaCartesian4(n, i));
                if (simd)
                {
                    cartesian.Append(string.Join("",
                        xyzw3.Concat(rgba3)
                            .Select(abcd =>
                                $@"    public {type}{4} {abcd.a}{abcd.b}{abcd.c}{abcd.d}
    {{
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {{
            {(type is "float" && bitSize is 128 ? $"if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, {SseShuffleMask(abcd.a, abcd.b, abcd.c, abcd.d)}));" : "")}
            {(type is "int" or "uint" && bitSize is 128 ? $"if (Sse2.IsSupported) return new(Sse2.Shuffle(this.vector, {SseShuffleMask(abcd.a, abcd.b, abcd.c, abcd.d)}));" : "")}
            {(type is "double" or "long" or "ulong" && bitSize is 256 ? $"if (Avx2.IsSupported) return new(Avx2.Permute4x64(this.vector, {SseShuffleMask(abcd.a, abcd.b, abcd.c, abcd.d)}));" : "")}
            return new(this.{abcd.a}, this.{abcd.b}, this.{abcd.c}, this.{abcd.d});
        }}{(abcd.u ? $@"
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        {{
            this.{abcd.a} = value.x; this.{abcd.b} = value.y; this.{abcd.c} = value.z; this.{abcd.d} = value.w; 
        }}" : "")}
    }}
").ToArray()));
                }
                else
                {
                    cartesian.Append(string.Join("",
                        xyzw3.Concat(rgba3)
                            .Select(abcd =>
                                $@"    public {type}{4} {abcd.a}{abcd.b}{abcd.c}{abcd.d}
    {{
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.{abcd.a}, this.{abcd.b}, this.{abcd.c}, this.{abcd.d});{(abcd.u ? $@"
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set {{ this.{abcd.a} = value.x; this.{abcd.b} = value.y; this.{abcd.c} = value.z; this.{abcd.d} = value.w; }}" : "")}
    }}
").ToArray()));
                }

                var source = $@"using System;
using System.Numerics;
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.X86;
using System.Runtime.Intrinsics.Arm;
using System.Runtime.CompilerServices;

#nullable enable
#pragma warning disable CS8981

namespace CCluster.Mathematics;

public partial struct {vname} 
{{

{cartesian}

}}
";
                await SaveCode($"{vname}.cartesian.gen.cs", source);
            }
        }
    }
}
