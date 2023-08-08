using System.Text;

namespace CodeGen;

public class GenCartesian : Base
{
    public override async Task Gen()
    {
        foreach (var type in TypeMeta.types.Keys)
        {
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
                
                var cartesian = new StringBuilder();
                var xyzw1 = ParallelEnumerable.Range(0, n * n).AsOrdered().Select(i => GetXyzwCartesian2(n, i));
                var rgba1 = ParallelEnumerable.Range(0, n * n).AsOrdered().Select(i => GetRgbaCartesian2(n, i));
                cartesian.Append(string.Join("",
                    xyzw1.Concat(rgba1).Select(ab =>
                        $@"    public {type}{2} {ab.a}{ab.b}
    {{
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new {type}{2}(this.{ab.a}, this.{ab.b});{(ab.u ? $@"
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set {{ this.{ab.a} = value.x; this.{ab.b} = value.y; }}" : "")}
    }}
").ToArray()));
                var xyzw2 = ParallelEnumerable.Range(0, n * n * n).AsParallel().AsOrdered()
                    .Select(i => GetXyzwCartesian3(n, i));
                var rgba2 = ParallelEnumerable.Range(0, n * n * n).AsParallel().AsOrdered()
                    .Select(i => GetRgbaCartesian3(n, i));
                cartesian.Append(string.Join("",
                    xyzw2.Concat(rgba2)
                        .Select(abc =>
                            $@"    public {type}{3}{align_name} {abc.a}{abc.b}{abc.c}
    {{
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new {type}{3}{align_name}(this.{abc.a}, this.{abc.b}, this.{abc.c});{(abc.u ? $@"
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set {{ this.{abc.a} = value.x; this.{abc.b} = value.y; this.{abc.c} = value.z; }}" : "")}
    }}
").ToArray()));
                var xyzw3 = ParallelEnumerable.Range(0, n * n * n * n).AsParallel().AsOrdered()
                    .Select(i => GetXyzwCartesian4(n, i));
                var rgba3 = ParallelEnumerable.Range(0, n * n * n * n).AsParallel().AsOrdered()
                    .Select(i => GetRgbaCartesian4(n, i));
                cartesian.Append(string.Join("",
                    xyzw3.Concat(rgba3)
                        .Select(abcd =>
                            $@"    public {type}{4} {abcd.a}{abcd.b}{abcd.c}{abcd.d}
    {{
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new {type}{4}(this.{abcd.a}, this.{abcd.b}, this.{abcd.c}, this.{abcd.d});{(abcd.u ? $@"
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set {{ this.{abcd.a} = value.x; this.{abcd.b} = value.y; this.{abcd.c} = value.z; this.{abcd.d} = value.w; }}" : "")}
    }}
").ToArray()));

                var source = $@"using System;
using System.Numerics;
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
