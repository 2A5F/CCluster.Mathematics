using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGen;

public class GenVectors : Base
{
    private record TypeMeta(int Size, string Zero, string One)
    {
        public bool Number { get; set; }
        public bool Float { get; set; }
        public bool Decimal { get; set; }
        public bool Bool { get; set; }
        public bool Unsigned { get; set; }
        public bool Simd { get; set; }
    }

    private static Dictionary<string, TypeMeta> types = new()
    {
        { "bool", new(sizeof(bool), "false", "true") { Bool = true, Unsigned = true, } },
        { "Half", new(sizeof(short), "Half.Zero", "Half.One") { Number = true, Float = true, } },
        { "float", new(sizeof(float), "0f", "1f") { Number = true, Float = true, Simd = true, } },
        { "double", new(sizeof(double), "0d", "1d") { Number = true, Float = true, Simd = true, } },
        { "decimal", new(sizeof(decimal), "0m", "1m") { Number = true, Decimal = true, } },
        { "int", new(sizeof(int), "0", "1") { Number = true, Simd = true, } },
        { "uint", new(sizeof(uint), "0u", "1u") { Number = true, Unsigned = true, Simd = true, } },
        { "long", new(sizeof(long), "0L", "1L") { Number = true, Simd = true, } },
        { "ulong", new(sizeof(ulong), "0UL", "1UL") { Number = true, Unsigned = true, Simd = true, } },
    };

    public override async Task Gen()
    {
        foreach (var tm in types)
        {
            var type = tm.Key;
            var meta = tm.Value;
            foreach (var n in Enumerable.Range(2, 3))
            {
                var byteSize = meta.Size * (n == 3 ? 4 : n);
                var bitSize = byteSize * 8;
                var simd = meta.Simd && bitSize is 64 or 128 or 256;

                var refGetter = new StringBuilder();

                var fields = new StringBuilder();
                if (simd)
                {
                    fields.Append($@"
    public Vector{bitSize}<{type}> vector;

");
                    foreach (var i in Enumerable.Range(0, n))
                    {
                        fields.Append($@"
    public {type} {xyzw[i]}
    {{
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        readonly get => RefRo{char.ToUpper(xyzw[i])};
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set => Ref{char.ToUpper(xyzw[i])} = value;
    }}

    public ref {type} Ref{char.ToUpper(xyzw[i])} 
    {{
        get => ref Unsafe.Add(ref Unsafe.As<Vector{bitSize}<{type}>, {type}>(ref Unsafe.AsRef(in vector)), {i});
    }}

    public readonly ref readonly {type} RefRo{char.ToUpper(xyzw[i])} 
    {{
        get => ref Unsafe.Add(ref Unsafe.As<Vector{bitSize}<{type}>, {type}>(ref Unsafe.AsRef(in vector)), {i});
    }}
");
                        refGetter.Append($@"
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static ref {type} Ref{char.ToUpper(xyzw[i])}({type}{n}* self) => ref Unsafe.Add(ref Unsafe.As<Vector{bitSize}<{type}>, {type}>(ref Unsafe.AsRef(in self->vector)), {i});
");
                    }
                }
                else
                {
                    foreach (var i in Enumerable.Range(0, n))
                    {
                        fields.Append($@"
    public {type} {xyzw[i]};

    public ref {type} Ref{char.ToUpper(xyzw[i])} 
    {{
        get => ref Unsafe.AsRef(in {xyzw[i]});
    }}

    public readonly ref readonly {type} RefRo{char.ToUpper(xyzw[i])} 
    {{
        get => ref Unsafe.AsRef(in {xyzw[i]});
    }}
");
                        refGetter.Append($@"
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static ref {type} Ref{char.ToUpper(xyzw[i])}({type}{n}* self) => ref Unsafe.AsRef(in self->{xyzw[i]});
");
                    }
                }

                var value_n_value = string.Join(", ", Enumerable.Range(0, n).Select(_ => "value"));
                var xyzw_arg = string.Join(", ", Enumerable.Range(0, n).Select(i => $"{type} {xyzw[i]}"));
                var xyzw_value = string.Join(", ", Enumerable.Range(0, n).Select(i => $"{xyzw[i]}"));
                var xyzw_this_value = string.Join(", ", Enumerable.Range(0, n).Select(i => $"this.{xyzw[i]}"));
                var ctor = new StringBuilder();
                if (simd)
                {
                    if (n == 3)
                    {
                        ctor.Append($@"
        this.vector = Vector{bitSize}.Create({xyzw_value}, {meta.Zero});
");
                    }
                    else
                    {
                        ctor.Append($@"
        this.vector = Vector{bitSize}.Create({xyzw_value});
");
                    }
                }
                else
                {
                    foreach (var i in Enumerable.Range(0, n))
                    {
                        ctor.Append(@$"
        this.{xyzw[i]} = {xyzw[i]};
");
                    }
                }

                var hash_value = string.Join(", ", Enumerable.Range(0, n).Select(i => $"this.{xyzw[i]}.GetHashCode()"));
                var this_eq_and = string.Join(" && ",
                    Enumerable.Range(0, n).Select(i => $"this.{xyzw[i]} == other.{xyzw[i]}"));
                var eq_and = string.Join(" && ",
                    Enumerable.Range(0, n).Select(i => $"left.{xyzw[i]} == right.{xyzw[i]}"));
                var ne_or = string.Join(" || ",
                    Enumerable.Range(0, n).Select(i => $"left.{xyzw[i]} != right.{xyzw[i]}"));

                string this_oper_value(string op) => string.Join(", ",
                    Enumerable.Range(0, n).Select(i => $"this.{xyzw[i]} {op} other.{xyzw[i]}"));

                string oper_value(string op) => string.Join(", ",
                    Enumerable.Range(0, n).Select(i => $"left.{xyzw[i]} {op} right.{xyzw[i]}"));

                string unary_oper_value(string op) => string.Join(", ",
                    Enumerable.Range(0, n).Select(i => $"{op}self.{xyzw[i]}"));

                string oper_scalar_right_value(string op) => string.Join(", ",
                    Enumerable.Range(0, n).Select(i => $"left.{xyzw[i]} {op} right"));

                string oper_scalar_left_value(string op) => string.Join(", ",
                    Enumerable.Range(0, n).Select(i => $"left {op} right.{xyzw[i]}"));

                string fn_value_xy(string f) => string.Join(", ",
                    Enumerable.Range(0, n).Select(i => $"{f}(x.{xyzw[i]}, y.{xyzw[i]})"));

                string fn_value_yx(string f) => string.Join(", ",
                    Enumerable.Range(0, n).Select(i => $"{f}(y.{xyzw[i]}, x.{xyzw[i]})"));

                string fn_value_x(string f) => string.Join(", ",
                    Enumerable.Range(0, n).Select(i => $"{f}(x.{xyzw[i]})"));

                var dot = string.Join(" + ", Enumerable.Range(0, n).Select(i => $"x.{xyzw[i]} * y.{xyzw[i]}"));

                var sin_cos = string.Join(" ",
                    Enumerable.Range(0, n).Select(i => $@"sincos(x.{xyzw[i]}, out sin.Ref{char.ToUpper(xyzw[i])}, out cos.Ref{char.ToUpper(xyzw[i])});"));

                var sin_cos_part1 = string.Join(" ",
                    Enumerable.Range(0, n).Select(i => $"var (s{i}, c{i}) = sincos(x.{xyzw[i]});"));
                var sin_cos_part2_sin = string.Join(", ", Enumerable.Range(0, n).Select(i => $"s{i}"));
                var sin_cos_part2_cos = string.Join(", ", Enumerable.Range(0, n).Select(i => $"c{i}"));

                var source = $@"using System;
using System.Numerics;
using System.Runtime.Intrinsics;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

#nullable enable
#pragma warning disable CS8981

namespace CCluster.Mathematics;

[Serializable]
[StructLayout(LayoutKind.Sequential, Size = {byteSize})]
public unsafe partial struct {type}{n} : 
    IEquatable<{type}{n}>, IEqualityOperators<{type}{n}, {type}{n}, bool>, IEqualityOperators<{type}{n}, {type}{n}, bool{n}>,
{(meta.Number ? $@"
    IAdditionOperators<{type}{n}, {type}{n}, {type}{n}>, IAdditiveIdentity<{type}{n}, {type}{n}>, IUnaryPlusOperators<{type}{n}, {type}{n}>,
    ISubtractionOperators<{type}{n}, {type}{n}, {type}{n}>, {(meta.Unsigned ? "" : $@"IUnaryNegationOperators<{type}{n}, {type}{n}>,")}
    IMultiplyOperators<{type}{n}, {type}{n}, {type}{n}>, IMultiplicativeIdentity<{type}{n}, {type}{n}>,
    IDivisionOperators<{type}{n}, {type}{n}, {type}{n}>,
    IModulusOperators<{type}{n}, {type}{n}, {type}{n}>,
" : "")}
    IVector, IVector{n}, IVector<{type}>, IVector{n}<{type}>
{{
{fields}

    public static int ByteSize 
    {{
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => {byteSize};
    }}

    public static int BitSize 
    {{
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => {bitSize};
    }}

    public static {type}{n} Zero
    {{
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new {type}{n}({meta.Zero});
    }}

    public static {type}{n} One
    {{
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new {type}{n}({meta.One});
    }}

{(simd ? $@"
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public {type}{n}(Vector{bitSize}<{type}> vector)
    {{
        this.vector = vector;
    }}

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public {type}{n}({type} value)
    {{
        this.vector = Vector{bitSize}.Create(value);
    }}
" : $@"
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public {type}{n}({type} value) : this({value_n_value}) {{ }}
")}

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public {type}{n}({xyzw_arg})
    {{
{ctor}
    }}

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator {type}{n}({type} value) => new {type}{n}(value);

{(simd ? $@"
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool Equals({type}{n} other)
    {{
        return this.vector.Equals(other.vector);
    }}
" : $@"
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool Equals({type}{n} other) => {this_eq_and};
")}

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override bool Equals(object? o) => o is {type}{n} other && Equals(other);

{(simd ? $@"

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator ==({type}{n} left, {type}{n} right)
    {{
        return left.vector.Equals(right.vector);
    }}

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator !=({type}{n} left, {type}{n} right)
    {{
        return !left.vector.Equals(right.vector);
    }}

" : $@"

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator ==({type}{n} left, {type}{n} right) => {eq_and};

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator !=({type}{n} left, {type}{n} right) => {ne_or};

")}

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override int GetHashCode() => HashCode.Combine({xyzw_this_value});

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public int{n} Hash() => new int{n}({hash_value});

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    static bool{n} IEqualityOperators<{type}{n}, {type}{n}, bool{n}>.operator ==({type}{n} left, {type}{n} right) => new bool{n}({oper_value("==")});

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    static bool{n} IEqualityOperators<{type}{n}, {type}{n}, bool{n}>.operator !=({type}{n} left, {type}{n} right) => new bool{n}({oper_value("!=")});

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool{n} VEq({type}{n} other) => new bool{n}({this_oper_value("==")});

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool{n} VNe({type}{n} other) => new bool{n}({this_oper_value("!=")});

{(meta.Number ? $@"
    public static {type}{n} AdditiveIdentity 
    {{
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new {type}{n}({meta.Zero});
    }}

    public static {type}{n} MultiplicativeIdentity 
    {{
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new {type}{n}({meta.One});
    }}

{(simd ? $@"

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type}{n} operator +({type}{n} left, {type}{n} right)
    {{
        return new {type}{n}(left.vector + right.vector);
    }}

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type}{n} operator -({type}{n} left, {type}{n} right)
    {{
        return new {type}{n}(left.vector - right.vector);
    }}

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type}{n} operator *({type}{n} left, {type}{n} right) => new {type}{n}({oper_value("*")});

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type}{n} operator /({type}{n} left, {type}{n} right) => new {type}{n}({oper_value("/")});

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type}{n} operator %({type}{n} left, {type}{n} right) => new {type}{n}({oper_value("%")});


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type}{n} operator +({type}{n} left, {type} right) => new {type}{n}({oper_scalar_right_value("+")});

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type}{n} operator -({type}{n} left, {type} right) => new {type}{n}({oper_scalar_right_value("-")});

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type}{n} operator *({type}{n} left, {type} right) => new {type}{n}({oper_scalar_right_value("*")});

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type}{n} operator /({type}{n} left, {type} right) => new {type}{n}({oper_scalar_right_value("/")});

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type}{n} operator %({type}{n} left, {type} right) => new {type}{n}({oper_scalar_right_value("%")});


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type}{n} operator +({type} left, {type}{n} right) => new {type}{n}({oper_scalar_left_value("+")});

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type}{n} operator -({type} left, {type}{n} right) => new {type}{n}({oper_scalar_left_value("-")});

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type}{n} operator *({type} left, {type}{n} right) => new {type}{n}({oper_scalar_left_value("*")});

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type}{n} operator /({type} left, {type}{n} right) => new {type}{n}({oper_scalar_left_value("/")});

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type}{n} operator %({type} left, {type}{n} right) => new {type}{n}({oper_scalar_left_value("%")});


{(meta.Unsigned ? "" : $@"    
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type}{n} operator -({type}{n} self) => new {type}{n}({unary_oper_value("-")});
")}

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type}{n} operator +({type}{n} self) => new {type}{n}({unary_oper_value("+")});

" : $@"

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type}{n} operator +({type}{n} left, {type}{n} right) => new {type}{n}({oper_value("+")});

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type}{n} operator -({type}{n} left, {type}{n} right) => new {type}{n}({oper_value("-")});

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type}{n} operator *({type}{n} left, {type}{n} right) => new {type}{n}({oper_value("*")});

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type}{n} operator /({type}{n} left, {type}{n} right) => new {type}{n}({oper_value("/")});

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type}{n} operator %({type}{n} left, {type}{n} right) => new {type}{n}({oper_value("%")});


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type}{n} operator +({type}{n} left, {type} right) => new {type}{n}({oper_scalar_right_value("+")});

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type}{n} operator -({type}{n} left, {type} right) => new {type}{n}({oper_scalar_right_value("-")});

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type}{n} operator *({type}{n} left, {type} right) => new {type}{n}({oper_scalar_right_value("*")});

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type}{n} operator /({type}{n} left, {type} right) => new {type}{n}({oper_scalar_right_value("/")});

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type}{n} operator %({type}{n} left, {type} right) => new {type}{n}({oper_scalar_right_value("%")});


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type}{n} operator +({type} left, {type}{n} right) => new {type}{n}({oper_scalar_left_value("+")});

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type}{n} operator -({type} left, {type}{n} right) => new {type}{n}({oper_scalar_left_value("-")});

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type}{n} operator *({type} left, {type}{n} right) => new {type}{n}({oper_scalar_left_value("*")});

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type}{n} operator /({type} left, {type}{n} right) => new {type}{n}({oper_scalar_left_value("/")});

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type}{n} operator %({type} left, {type}{n} right) => new {type}{n}({oper_scalar_left_value("%")});


{(meta.Unsigned ? "" : $@"    
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type}{n} operator -({type}{n} self) => new {type}{n}({unary_oper_value("-")});
")}

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type}{n} operator +({type}{n} self) => new {type}{n}({unary_oper_value("+")});

")}

" : "")}

}}

public static unsafe partial class math
{{

{refGetter}

{(meta.Number ? $@"

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type}{n} min({type}{n} x, {type}{n} y) => new {type}{n}({fn_value_xy("min")});

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type}{n} max({type}{n} x, {type}{n} y) => new {type}{n}({fn_value_xy("max")});

{(meta.Float || meta.Decimal ? $@"

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type}{n} lerp({type}{n} s, {type}{n} x, {type}{n} y) => x + s * (y - x);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type}{n} unlerp({type}{n} x, {type}{n} a, {type}{n} b) => (x - a) / (b - a);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type}{n} remap({type}{n} x, {type}{n} a, {type}{n} b, {type}{n} c, {type}{n} d) => lerp(c, d, unlerp(a, b, x));

" : "")}

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type}{n} mad({type}{n} a, {type}{n} b, {type}{n} c) => a * b + c;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type}{n} clamp({type}{n} x, {type}{n} a, {type}{n} b) => max(a, min(b, x));

{(meta.Float || meta.Decimal ? $@"

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type}{n} saturate({type}{n} x) => clamp(x, {type}{n}.Zero, {type}{n}.One);

" : "")}

{(meta.Unsigned ? "" : $@"

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type}{n} abs({type}{n} x) => new {type}{n}({fn_value_x("abs")});

")}

{(n == 3 ? $@"
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type}{n} cross({type}{n} x, {type}{n} y) => (x * y.yzx - x.yzx * y).yzx;
" : "")}

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type} dot({type}{n} x, {type}{n} y) => {dot};

" : "")}

{(meta.Float ? $@"

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type}{n} tan({type}{n} x) => new {type}{n}({fn_value_x("tan")});

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type}{n} tanh({type}{n} x) => new {type}{n}({fn_value_x("tanh")});

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type}{n} atan({type}{n} x) => new {type}{n}({fn_value_x("atan")});

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type}{n} atanh({type}{n} x) => new {type}{n}({fn_value_x("tanh")});

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type}{n} atan2({type}{n} y, {type}{n} x) => new {type}{n}({fn_value_yx("atan2")});

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type}{n} tanPi({type}{n} x) => new {type}{n}({fn_value_x("tanPi")});

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type}{n} atanPi({type}{n} x) => new {type}{n}({fn_value_x("atanPi")});

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type}{n} atan2Pi({type}{n} y, {type}{n} x) => new {type}{n}({fn_value_yx("atan2Pi")});


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type}{n} cos({type}{n} x) => new {type}{n}({fn_value_x("cos")});

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type}{n} cosh({type}{n} x) => new {type}{n}({fn_value_x("cosh")});

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type}{n} acos({type}{n} x) => new {type}{n}({fn_value_x("acos")});

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type}{n} acosh({type}{n} x) => new {type}{n}({fn_value_x("acosh")});

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type}{n} cosPi({type}{n} x) => new {type}{n}({fn_value_x("cosPi")});

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type}{n} acosPi({type}{n} x) => new {type}{n}({fn_value_x("acosPi")});


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type}{n} sin({type}{n} x) => new {type}{n}({fn_value_x("sin")});

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type}{n} sinh({type}{n} x) => new {type}{n}({fn_value_x("sinh")});

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type}{n} asin({type}{n} x) => new {type}{n}({fn_value_x("asin")});

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type}{n} asinh({type}{n} x) => new {type}{n}({fn_value_x("asinh")});

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type}{n} sinPi({type}{n} x) => new {type}{n}({fn_value_x("sinPi")});

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type}{n} asinPi({type}{n} x) => new {type}{n}({fn_value_x("asinPi")});

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void sincos({type}{n} x, out {type}{n} sin, out {type}{n} cos)
    {{
        Unsafe.SkipInit(out sin);
        Unsafe.SkipInit(out cos);
        {sin_cos}
    }}

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static ({type}{n} sin, {type}{n} cos) sincos({type}{n} x)
    {{
        {sin_cos_part1}
        return (new {type}{n}({sin_cos_part2_sin}), new {type}{n}({sin_cos_part2_cos}));
    }}
" : "")}

{(meta.Float || meta.Decimal ? $@"

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type}{n} floor({type}{n} x) => new {type}{n}({fn_value_x("floor")});

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type}{n} ceil({type}{n} x) => new {type}{n}({fn_value_x("ceil")});

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type}{n} round({type}{n} x) => new {type}{n}({fn_value_x("round")});

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type}{n} trunc({type}{n} x) => new {type}{n}({fn_value_x("trunc")});

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type}{n} frac({type}{n} x) => x - floor(x);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type}{n} rcp({type}{n} x) => {meta.One} / x;

" : "")}

{(meta.Unsigned ? "" : $@"

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type}{n} sign({type}{n} x) => new {type}{n}({fn_value_x("sign")});

")}

{(meta.Float ? $@"

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type}{n} pow({type}{n} x, {type}{n} y) => new {type}{n}({fn_value_xy("pow")});


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type}{n} exp({type}{n} x) => new {type}{n}({fn_value_x("exp")});

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type}{n} exp2({type}{n} x) => new {type}{n}({fn_value_x("exp2")});

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type}{n} exp10({type}{n} x) => new {type}{n}({fn_value_x("exp10")});

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type}{n} expM1({type}{n} x) => new {type}{n}({fn_value_x("expM1")});

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type}{n} exp2M1({type}{n} x) => new {type}{n}({fn_value_x("exp2M1")});

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type}{n} exp10M1({type}{n} x) => new {type}{n}({fn_value_x("exp10M1")});


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type}{n} log({type}{n} x) => new {type}{n}({fn_value_x("log")});

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type}{n} log2({type}{n} x) => new {type}{n}({fn_value_x("log2")});

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type}{n} log10({type}{n} x) => new {type}{n}({fn_value_x("log10")});

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type}{n} logP1({type}{n} x) => new {type}{n}({fn_value_x("logP1")});

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type}{n} log2P1({type}{n} x) => new {type}{n}({fn_value_x("log2P1")});

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type}{n} log10P1({type}{n} x) => new {type}{n}({fn_value_x("log10P1")});


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type}{n} modf({type}{n} x, out {type}{n} i) 
    {{ 
        i = trunc(x);
        return x - i;
    }}

" : "")}

}}
";
                await SaveCode($"{type}{n}.gen.cs", source);
            }
        }

    }
}
