using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Text;
using System.Linq;
using System.Text;
using CCluster.Mathematics.Gen;

namespace CCluster.Mathematics.GenCart;

[Generator]
public class GenCartesian : Base, ISourceGenerator
{
    private static (char a, char b, bool u) GetXyzwCartesian2(int n, int i)
        => (xyzw_cartesian2[n, i, 0], xyzw_cartesian2[n, i, 1], xyzw_cartesian2[n, i, 2] != '\x0');

    private static (char a, char b, char c, bool u) GetXyzwCartesian3(int n, int i)
        => (xyzw_cartesian3[n, i, 0], xyzw_cartesian3[n, i, 1], xyzw_cartesian3[n, i, 2], xyzw_cartesian3[n, i, 3] != '\x0');

    private static (char a, char b, char c, char d, bool u) GetXyzwCartesian4(int n, int i)
        => (xyzw_cartesian4[n, i, 0], xyzw_cartesian4[n, i, 1], xyzw_cartesian4[n, i, 2], xyzw_cartesian4[n, i, 3], xyzw_cartesian4[n, i, 4] != '\x0');

    private static readonly string[] types = { "bool", "Half", "float", "double", "decimal", "int", "uint", "long", "ulong" };

    public void Initialize(GeneratorInitializationContext context) { }

    public void Execute(GeneratorExecutionContext context)
    {
        foreach (var type in types)
        {
            foreach (var n in Enumerable.Range(2, 3))
            {
                var cartesian = new StringBuilder();
                cartesian.Append(string.Join("", ParallelEnumerable.Range(0, n * n).AsOrdered().Select(i => GetXyzwCartesian2(n, i)).Select(ab =>
                    $@"    public {type}{2} {ab.a}{ab.b}
    {{
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new {type}{2}(this.{ab.a}, this.{ab.b});{(ab.u ? $@"
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set {{ this.{ab.a} = value.x; this.{ab.b} = value.y; }}" : "")}
    }}
").ToArray()));
                cartesian.Append(string.Join("", ParallelEnumerable.Range(0, n * n * n).AsParallel().AsOrdered().Select(i => GetXyzwCartesian3(n, i)).Select(abc =>
                    $@"    public {type}{3} {abc.a}{abc.b}{abc.c}
    {{
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new {type}{3}(this.{abc.a}, this.{abc.b}, this.{abc.c});{(abc.u ? $@"
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set {{ this.{abc.a} = value.x; this.{abc.b} = value.y; this.{abc.c} = value.z; }}" : "")}
    }}
").ToArray()));
                cartesian.Append(string.Join("", ParallelEnumerable.Range(0, n * n * n * n).AsParallel().AsOrdered().Select(i => GetXyzwCartesian4(n, i)).Select(abcd =>
                    $@"    public {type}{4} {abcd.a}{abcd.b}{abcd.c}{abcd.d}
    {{
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new {type}{4}(this.{abcd.a}, this.{abcd.b}, this.{abcd.c}, this.{abcd.d});{(abcd.u ? $@"
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set {{ this.{abcd.a} = value.x; this.{abcd.b} = value.y; this.{abcd.c} = value.z; this.{abcd.d} = value.w; }}" : "")}
    }}
").ToArray()));

                var source = SourceText.From($@"using System;
using System.Numerics;
using System.Runtime.CompilerServices;

#nullable enable
#pragma warning disable CS8981

namespace CCluster.Mathematics;

public partial struct {type}{n} 
{{

{cartesian}

}}
", Encoding.UTF8);
                context.AddSource($"{type}{n}.cartesian.gen.cs", source);
            }
        }
    }
}
