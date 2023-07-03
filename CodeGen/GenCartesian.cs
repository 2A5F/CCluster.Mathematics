using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGen;

public class GenCartesian : Base
{
    private static readonly string[] types =
        { "bool", "Half", "float", "double", "decimal", "int", "uint", "long", "ulong" };

    public override async Task Gen()
    {
        foreach (var type in types)
        {
            foreach (var n in Enumerable.Range(2, 3))
            {
                var cartesian = new StringBuilder();
                cartesian.Append(string.Join("",
                    ParallelEnumerable.Range(0, n * n).AsOrdered().Select(i => GetXyzwCartesian2(n, i)).Select(ab =>
                        $@"    public {type}{2} {ab.a}{ab.b}
    {{
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new {type}{2}(this.{ab.a}, this.{ab.b});{(ab.u ? $@"
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set {{ this.{ab.a} = value.x; this.{ab.b} = value.y; }}" : "")}
    }}
").ToArray()));
                cartesian.Append(string.Join("",
                    ParallelEnumerable.Range(0, n * n * n).AsParallel().AsOrdered().Select(i => GetXyzwCartesian3(n, i))
                        .Select(abc =>
                            $@"    public {type}{3} {abc.a}{abc.b}{abc.c}
    {{
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new {type}{3}(this.{abc.a}, this.{abc.b}, this.{abc.c});{(abc.u ? $@"
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set {{ this.{abc.a} = value.x; this.{abc.b} = value.y; this.{abc.c} = value.z; }}" : "")}
    }}
").ToArray()));
                cartesian.Append(string.Join("",
                    ParallelEnumerable.Range(0, n * n * n * n).AsParallel().AsOrdered()
                        .Select(i => GetXyzwCartesian4(n, i)).Select(abcd =>
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

public partial struct {type}{n} 
{{

{cartesian}

}}
";
                await SaveCode($"{type}{n}.cartesian.gen.cs", source);
            }
        }
    }
}
