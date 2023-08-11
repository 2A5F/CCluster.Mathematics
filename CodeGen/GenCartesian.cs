using System.Text;

namespace CodeGen;

public class GenCartesian : Base
{
    public static Dictionary<char, int> CompIndex = new()
    {
        { 'x', 0 }, { 'y', 1 }, { 'z', 2 }, { 'w', 3 },
        { 'r', 0 }, { 'g', 1 }, { 'b', 2 }, { 'a', 3 },
    };

    public static string VectorShuffleMask(char x, char y, char z, char w, string unit)
    {
        var a = CompIndex[x];
        var b = CompIndex[y];
        var c = CompIndex[z];
        var d = CompIndex[w];
        return $"{a}{unit}, {b}{unit}, {c}{unit}, {d}{unit}";
    }
    
    public static string VectorShuffle2Mask(char x, char y, string unit)
    {
        var a = CompIndex[x];
        var b = CompIndex[y];
        return $"{a}{unit}, {b}{unit}";
    }

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
                var v3_iz2 = $" & math.v3_iz_{type}{bitSize * 2}";

                var unit = type switch
                {
                    "uint" => "u",
                    "long" or "double" => "L",
                    "ulong" => "UL",
                    _ => "",
                };

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
{(n is 2 ? $@"
            return new(Vector{bitSize}.Shuffle(this.vector, Vector{bitSize}.Create({VectorShuffle2Mask(ab.a, ab.b, unit)})));
" : $@"
            return new(this.{ab.a}, this.{ab.b});
")}
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
{(n is 3 or 4 ? $@"
            return new(Vector{bitSize}.Shuffle(this.vector, Vector{bitSize}.Create({VectorShuffleMask(abc.a, abc.b, abc.c, 'x', unit)})){v3_iz});
" : n is 2 ? $@"
            var a = Vector{bitSize}.Shuffle(this.vector, Vector{bitSize}.Create({VectorShuffle2Mask(abc.a, abc.b, unit)}));
            var b = Vector{bitSize}.Shuffle(this.vector, Vector{bitSize}.Create({VectorShuffle2Mask(abc.c, 'x', unit)}));
            return new(Vector{bitSize * 2}.Create(a, b){v3_iz2});
" : $@"
            return new(this.{abc.a}, this.{abc.b}, this.{abc.c});
")}
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
{(n is 3 or 4 ? $@"
            return new(Vector{bitSize}.Shuffle(this.vector, Vector{bitSize}.Create({VectorShuffleMask(abcd.a, abcd.b, abcd.c, abcd.d, unit)})));
" : n is 2 ? $@"
            var a = Vector{bitSize}.Shuffle(this.vector, Vector{bitSize}.Create({VectorShuffle2Mask(abcd.a, abcd.b, unit)}));
            var b = Vector{bitSize}.Shuffle(this.vector, Vector{bitSize}.Create({VectorShuffle2Mask(abcd.c, abcd.d, unit)}));
            return new(Vector{bitSize * 2}.Create(a, b));
" : $@"
            return new(this.{abcd.a}, this.{abcd.b}, this.{abcd.c}, this.{abcd.d});
")}
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
