using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CCluster.Mathematics.Gen.Gen;

[Generator]
public class GenCartesian : ISourceGenerator
{
    public static readonly char[] xyzw = { 'x', 'y', 'z', 'w' };

    private static (char a, char b, bool u)[] CalcXyzwCartesian2(int n)
    {
        var size = n * n;
        var r = new (char a, char b, bool u)[size];
        ParallelEnumerable.Range(0, size).ForAll(i =>
        {
            var y = i % n;
            var x = i / n;
            r[i] = (xyzw[x], xyzw[y], x != y);
        });
        return r;
    }

    private static (char a, char b, char c, bool u)[] CalcXyzwCartesian3(int n)
    {
        var size = n * n * n;
        var r = new (char a, char b, char c, bool u)[size];
        ParallelEnumerable.Range(0, size).ForAll(i =>
        {
            var z = i % n;
            var xy = i / n;
            var y = xy % n;
            var x = xy / n;
            r[i] = (xyzw[x], xyzw[y], xyzw[z], x != y && x != z && y != z);
        });
        return r;
    }

    private static (char a, char b, char c, char d, bool u)[] CalcXyzwCartesian4(int n)
    {
        var size = n * n * n * n;
        var r = new (char a, char b, char c, char d, bool u)[size];
        ParallelEnumerable.Range(0, size).ForAll(i =>
        {
            var w = i % n;
            var xyz = i / n;
            var z = xyz % n;
            var xy = xyz / n;
            var y = xy % n;
            var x = xy / n;
            r[i] = (xyzw[x], xyzw[y], xyzw[z], xyzw[w], x != y && x != z && x != w && y != z && y != w && z != w);
        });
        return r;
    }

    private Dictionary<int, (char a, char b, bool u)[]> xyzw_cartesian2 = new()
    {
        { 2, CalcXyzwCartesian2(2) },
        { 3, CalcXyzwCartesian2(3) },
        { 4, CalcXyzwCartesian2(4) },
    };

    private Dictionary<int, (char a, char b, char c, bool u)[]> xyzw_cartesian3 = new()
    {
        { 2, CalcXyzwCartesian3(2) },
        { 3, CalcXyzwCartesian3(3) },
        { 4, CalcXyzwCartesian3(4) },
    };

    private Dictionary<int, (char a, char b, char c, char d, bool u)[]> xyzw_cartesian4 = new()
    {
        { 2, CalcXyzwCartesian4(2) },
        { 3, CalcXyzwCartesian4(3) },
        { 4, CalcXyzwCartesian4(4) },
    };

    public void Initialize(GeneratorInitializationContext context) { }

    public string Char(bool b) => b ? "'\x1'" : "'\x0'";

    public void Execute(GeneratorExecutionContext context)
    {
        var char_def_3 = string.Join(", ", ParallelEnumerable.Range(0, 3).Select(_ => "'\0'"));
        var char_def_4 = string.Join(", ", ParallelEnumerable.Range(0, 4).Select(_ => "'\0'"));
        var char_def_5 = string.Join(", ", ParallelEnumerable.Range(0, 5).Select(_ => "'\0'"));

        var ca2 = string.Join(", ", ParallelEnumerable.Range(0, 5).AsOrdered().Select(x =>
        {
            if (!xyzw_cartesian2.TryGetValue(x, out var v))
                return $"{{ {string.Join(", ", ParallelEnumerable.Range(0, 4 * 4).AsOrdered().Select(_ => $"{{ {char_def_3} }}"))} }}";
            else
                return $"{{ {string.Join(", ", ParallelEnumerable.Range(0, 4 * 4).AsOrdered().Select(y => y >= v.Length ? $"{{ {char_def_3} }}" : $"{{ '{v[y].a}', '{v[y].b}', {Char(v[y].u)} }}"))} }}";
        }));

        var ca3 = string.Join(", ", ParallelEnumerable.Range(0, 5).AsOrdered().Select(x =>
        {
            if (!xyzw_cartesian3.TryGetValue(x, out var v))
                return $"{{ {string.Join(", ", ParallelEnumerable.Range(0, 4 * 4 * 4).AsOrdered().Select(_ => $"{{ {char_def_4} }}"))} }}";
            else
                return $"{{ {string.Join(", ", ParallelEnumerable.Range(0, 4 * 4 * 4).AsOrdered().Select(y => y >= v.Length ? $"{{ {char_def_4} }}" : $"{{ '{v[y].a}', '{v[y].b}', '{v[y].c}', {Char(v[y].u)} }}"))} }}";
        }));

        var ca4 = string.Join(", ", ParallelEnumerable.Range(0, 5).AsOrdered().Select(x =>
        {
            if (!xyzw_cartesian4.TryGetValue(x, out var v))
                return $"{{ {string.Join(", ", ParallelEnumerable.Range(0, 4 * 4 * 4 * 4).AsOrdered().Select(_ => $"{{ {char_def_5} }}"))} }}";
            else
                return $"{{ {string.Join(", ", ParallelEnumerable.Range(0, 4 * 4 * 4 * 4).AsOrdered().Select(y => y >= v.Length ? $"{{ {char_def_5} }}" : $"{{ '{v[y].a}', '{v[y].b}', '{v[y].c}', '{v[y].d}', {Char(v[y].u)} }}"))} }}";
        }));

        var source = SourceText.From($@"using System.Collections.Generic;
using System.Linq;

namespace CCluster.Mathematics.Gen;

public abstract partial class Base
{{
    public static readonly char[] xyzw = {{ 'x', 'y', 'z', 'w' }};

    public static readonly char[,,] xyzw_cartesian2 = {{ {ca2} }};

    public static readonly char[,,] xyzw_cartesian3 = {{ {ca3} }};

    public static readonly char[,,] xyzw_cartesian4 = {{ {ca4} }};
}}
", Encoding.UTF8);
        context.AddSource("cartesian.gen.cs", source);
    }
}
