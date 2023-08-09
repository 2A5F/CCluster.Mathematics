using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics;
using System.Text;
using System.Threading.Tasks;

namespace CodeGen;

public class GenVectors : Base
{
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
                var na = $"{n}{align_name}";
                var vname = $"{type}{na}";

                var json_name = $"{type[0].ToString().ToUpper()}{type[1..]}{n}{align_name.ToUpper()}";

                var byteSize = meta.Size * (n == 3 && !no_align ? 4 : n);
                var bitSize = byteSize * 8;
                var simd = !no_align && meta.Simd && bitSize is 64 or 128 or 256;

                #region fields

                var fields = new StringBuilder();
                if (simd)
                {
                    fields.Append($@"
    /// <summary>Raw simd vector</summary>
    [FieldOffset(0)]
    public Vector{bitSize}<{type}> vector;

");
                }

                foreach (var (v, i) in Enumerable.Range(0, n).Select(i => (xyzw[i], i)))
                {
                    fields.Append($@"
    /// <summary>{v.ToString().ToUpper()} component of the vector</summary>
    [FieldOffset({i * meta.Size})]
    public {type} {v};
");
                }

                fields.Append($"\n");

                foreach (var (c, i) in Enumerable.Range(0, n).Select(i => (rgba[i], i)))
                {
                    fields.Append($@"
    /// <summary>{c.ToString().ToUpper()} component of the vector</summary>
    [FieldOffset({i * meta.Size})]
    public {type} {c};
");
                }

                #endregion

                var value_n_value = string.Join(", ", Enumerable.Range(0, n).Select(_ => "value"));
                var xyzw_arg = string.Join(", ", Enumerable.Range(0, n).Select(i => $"{type} {xyzw[i]}"));
                var xyzw_value = string.Join(", ", Enumerable.Range(0, n).Select(i => $"{xyzw[i]}"));
                var xyzw_this_value = string.Join(", ", Enumerable.Range(0, n).Select(i => $"this.{xyzw[i]}"));
                var xyzw_value_value = string.Join(", ", Enumerable.Range(0, n).Select(i => $"value.{xyzw[i]}"));
                var xyzw_this_value_to_str =
                    string.Join(", ", Enumerable.Range(0, n).Select(i => $"{{this.{xyzw[i]}}}"));

                #region ctors

                var ctors = new StringBuilder();

                #region ctor1

                {
                    if (simd)
                    {
                        ctors.Append($@"
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public {vname}(Vector{bitSize}<{type}> vector)
    {{
        this.vector = vector;
    }}

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public {vname}({type} value)
    {{
        this.vector = Vector{bitSize}.Create(value);
    }}
");
                    }
                    else
                    {
                        ctors.Append($@"
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public {vname}({type} value) : this({value_n_value}) {{ }}
");
                    }
                }

                #endregion

                #region ctor2

                {
                    ctors.Append($@"
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public {vname}({xyzw_arg})
    {{");
                    if (simd)
                    {
                        if (n == 3)
                        {
                            ctors.Append($@"
        this.vector = Vector{bitSize}.Create({xyzw_value}, {meta.Zero});
");
                        }
                        else
                        {
                            ctors.Append($@"
        this.vector = Vector{bitSize}.Create({xyzw_value});
");
                        }
                    }
                    else
                    {
                        foreach (var i in Enumerable.Range(0, n))
                        {
                            ctors.Append(@$"
        this.{xyzw[i]} = {xyzw[i]};
");
                        }
                    }
                    ctors.Append($@"    }}
");
                }

                #endregion

                #region ctor3

                if (n == 3)
                {
                    ctors.Append($@"
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public {vname}({type}{2} xy, {type} z) : this(xy.x, xy.y, z) {{ }}

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public {vname}({type} x, {type}{2} yz) : this(x, yz.x, yz.y) {{ }}
");
                }
                else if (n == 4)
                {
                    ctors.Append($@"
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public {vname}({type}{2} xy, {type}{2} zw) : this(xy.x, xy.y, zw.x, zw.y) {{ }}

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public {vname}({type}{2} xy, {type} z, {type} w) : this(xy.x, xy.y, z, w) {{ }}

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public {vname}({type} x, {type}{2} yz, {type} w) : this(x, yz.x, yz.y, w) {{ }}

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public {vname}({type} x, {type} y, {type}{2} zw) : this(x, y, zw.x, zw.y) {{ }}

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public {vname}({type}{3}{align_name} xyz, {type} w) : this(xyz.x, xyz.y, xyz.z, w) {{ }}

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public {vname}({type} x, {type}{3}{align_name} yzw) : this(x, yzw.x, yzw.y, yzw.z) {{ }}
");
                }

                #endregion

                #endregion

                #region aligned convert

                var aligned_convert = new StringBuilder();

                if (no_align)
                {
                    aligned_convert.Append($@"
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator {type}{n}{align_name}({type}{n} value) => new({xyzw_value_value});

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator {type}{n}({type}{n}{align_name} value) => new({xyzw_value_value});
");
                }

                #endregion

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
                    Enumerable.Range(0, n).Select(i =>
                        $@"sincos(x.{xyzw[i]}, out sin.{xyzw[i]}, out cos.{xyzw[i]});"));

                var sin_cos_part1 = string.Join(" ",
                    Enumerable.Range(0, n).Select(i => $"var (s{i}, c{i}) = sincos(x.{xyzw[i]});"));
                var sin_cos_part2_sin = string.Join(", ", Enumerable.Range(0, n).Select(i => $"s{i}"));
                var sin_cos_part2_cos = string.Join(", ", Enumerable.Range(0, n).Select(i => $"c{i}"));

                var select = string.Join(", ",
                    Enumerable.Range(0, n).Select(i => $"c.{xyzw[i]} ? b.{xyzw[i]} : a.{xyzw[i]}"));

                var json_read = new StringBuilder();
                var json_write = new StringBuilder();
                foreach (var v in Enumerable.Range(0, n).Select(i => xyzw[i]))
                {
                    json_read.Append($@"
        reader.Read();
        result.{v} = {meta.JsonRead};");
                    json_write.Append($@"
        {meta.JsonWrite($"value.{v}")};");
                }

                var source = $@"using System;
using System.Numerics;
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.X86;
using System.Runtime.Intrinsics.Arm;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Serialization;

#nullable enable
#pragma warning disable CS8981

namespace CCluster.Mathematics;

/// <summary>A {n} component vector of {type}{(no_align ? $", with no aligned" : string.Empty)}</summary>
[Serializable]
[JsonConverter(typeof({json_name}JsonConverter))]
[StructLayout(LayoutKind.Explicit, Size = {byteSize}, Pack = {meta.Size})]
public unsafe partial struct {vname} : 
    IEquatable<{vname}>, IEqualityOperators<{vname}, {vname}, bool>, IEqualityOperators<{vname}, {vname}, bool{na}>,
{(meta.Number ? $@"
    IAdditionOperators<{vname}, {vname}, {vname}>, IAdditiveIdentity<{vname}, {vname}>, IUnaryPlusOperators<{vname}, {vname}>,
    ISubtractionOperators<{vname}, {vname}, {vname}>, {(meta.Unsigned ? "" : $@"IUnaryNegationOperators<{vname}, {vname}>,")}
    IMultiplyOperators<{vname}, {vname}, {vname}>, IMultiplicativeIdentity<{vname}, {vname}>,
    IDivisionOperators<{vname}, {vname}, {vname}>,
    IModulusOperators<{vname}, {vname}, {vname}>,
" : "" /* meta.Number */)}
    IVector{n}<{type}>, IVectorSelf<{vname}>
{{    
    //////////////////////////////////////////////////////////////////////////////////////////////////// Fields

    #region Fields
{fields}
    #endregion

    //////////////////////////////////////////////////////////////////////////////////////////////////// Constants

    #region Constants

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

    public static readonly {vname} zero = new({meta.Zero});

    public static readonly {vname} one = new({meta.One});

    static {vname} IVectorSelf<{vname}>.Zero 
    {{
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => zero;
    }}

    static {vname} IVectorSelf<{vname}>.One 
    {{
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => one;
    }}

    #endregion

    //////////////////////////////////////////////////////////////////////////////////////////////////// Ctor

    #region Ctor
{ctors}
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator {vname}({type} value) => new(value);
{aligned_convert}
    #endregion

    //////////////////////////////////////////////////////////////////////////////////////////////////// Equals

    #region Equals

{(simd ? $@"
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool Equals({vname} other)
    {{
        return this.vector.Equals(other.vector);
    }}
" : $@"
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool Equals({vname} other) => {this_eq_and};
" /* simd */)}

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override bool Equals(object? o) => o is {vname} other && Equals(other);

{(simd ? $@"

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator ==({vname} left, {vname} right)
    {{
        return left.vector.Equals(right.vector);
    }}

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator !=({vname} left, {vname} right)
    {{
        return !left.vector.Equals(right.vector);
    }}

" : $@"

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator ==({vname} left, {vname} right) => {eq_and};

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator !=({vname} left, {vname} right) => {ne_or};

" /* simd */)}

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override int GetHashCode() => HashCode.Combine({xyzw_this_value});

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public int{na} Hash() => new({hash_value});

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    static bool{na} IEqualityOperators<{vname}, {vname}, bool{na}>.operator ==({vname} left, {vname} right) => new({oper_value("==")});

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    static bool{na} IEqualityOperators<{vname}, {vname}, bool{na}>.operator !=({vname} left, {vname} right) => new({oper_value("!=")});

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool{na} VEq({vname} other) => new({this_oper_value("==")});

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool{na} VNe({vname} other) => new({this_oper_value("!=")});

    #endregion

{(meta.Number ? $@"

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool{na} operator >({vname} left, {vname} right) => new({oper_value(">")});

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool{na} operator <({vname} left, {vname} right) => new({oper_value("<")});

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool{na} operator >=({vname} left, {vname} right) => new({oper_value(">=")});

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool{na} operator <=({vname} left, {vname} right) => new({oper_value("<=")});

" : "" /* meta.Number */)}

{(meta.Number ? $@"
    //////////////////////////////////////////////////////////////////////////////////////////////////// Arithmetic

    #region Arithmetic

    public static {vname} AdditiveIdentity 
    {{
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new({meta.Zero});
    }}

    public static {vname} MultiplicativeIdentity 
    {{
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new({meta.One});
    }}

{(simd ? $@"

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} operator +({vname} left, {vname} right)
    {{
        return new(left.vector + right.vector);
    }}

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} operator -({vname} left, {vname} right)
    {{
        return new(left.vector - right.vector);
    }}

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} operator *({vname} left, {vname} right)
    {{
        return new(left.vector * right.vector);
    }}

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} operator /({vname} left, {vname} right)
    {{
        return new(left.vector / right.vector);
    }}

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} operator %({vname} left, {vname} right) => new({oper_value("%")});


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} operator +({vname} left, {type} right) => left + new {vname}(right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} operator -({vname} left, {type} right) => left - new {vname}(right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} operator *({vname} left, {type} right) => left * new {vname}(right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} operator /({vname} left, {type} right) => left / new {vname}(right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} operator %({vname} left, {type} right) => left % new {vname}(right);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} operator +({type} left, {vname} right) => new {vname}(left) + right;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} operator -({type} left, {vname} right) => new {vname}(left) - right;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} operator *({type} left, {vname} right) => new {vname}(left) * right;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} operator /({type} left, {vname} right) => new {vname}(left) / right;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} operator %({type} left, {vname} right) => new {vname}(left) % right;


{(meta.Unsigned ? "" : $@"    
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} operator -({vname} self) => new({unary_oper_value("-")});
" /* meta.Unsigned */)}

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} operator +({vname} self) => new({unary_oper_value("+")});

" /* simd */ : /* !simd */ $@"

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} operator +({vname} left, {vname} right) => new({oper_value("+")});

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} operator -({vname} left, {vname} right) => new({oper_value("-")});

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} operator *({vname} left, {vname} right) => new({oper_value("*")});

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} operator /({vname} left, {vname} right) => new({oper_value("/")});

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} operator %({vname} left, {vname} right) => new({oper_value("%")});


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} operator +({vname} left, {type} right) => new({oper_scalar_right_value("+")});

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} operator -({vname} left, {type} right) => new({oper_scalar_right_value("-")});

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} operator *({vname} left, {type} right) => new({oper_scalar_right_value("*")});

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} operator /({vname} left, {type} right) => new({oper_scalar_right_value("/")});

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} operator %({vname} left, {type} right) => new({oper_scalar_right_value("%")});


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} operator +({type} left, {vname} right) => new({oper_scalar_left_value("+")});

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} operator -({type} left, {vname} right) => new({oper_scalar_left_value("-")});

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} operator *({type} left, {vname} right) => new({oper_scalar_left_value("*")});

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} operator /({type} left, {vname} right) => new({oper_scalar_left_value("/")});

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} operator %({type} left, {vname} right) => new({oper_scalar_left_value("%")});


{(meta.Unsigned ? "" : $@"    
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} operator -({vname} self) => new({unary_oper_value("-")});
" /* meta.Unsigned */)}

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} operator +({vname} self) => new({unary_oper_value("+")});

" /* simd */)}

    #endregion

" : "" /* meta.Number */)}
    //////////////////////////////////////////////////////////////////////////////////////////////////// ToString

    #region ToString

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override string ToString() => $""{vname}({xyzw_this_value_to_str})"";

    #endregion
}}

public static unsafe partial class math
{{

{(meta.Number ? $@"

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} min({vname} x, {vname} y) => new({fn_value_xy("min")});

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} max({vname} x, {vname} y) => new({fn_value_xy("max")});

{(meta.Float || meta.Decimal ? $@"

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} lerp({vname} s, {vname} x, {vname} y) => x + s * (y - x);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} unlerp({vname} x, {vname} a, {vname} b) => (x - a) / (b - a);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} remap({vname} x, {vname} a, {vname} b, {vname} c, {vname} d) => lerp(c, d, unlerp(a, b, x));

" : "")}

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} mad({vname} a, {vname} b, {vname} c) => a * b + c;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} clamp({vname} x, {vname} a, {vname} b) => max(a, min(b, x));

{(meta.Float || meta.Decimal ? $@"

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} saturate({vname} x) => clamp(x, {vname}.zero, {vname}.one);

" : "")}

{(meta.Unsigned ? $@"

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} abs({vname} x) => x;

" : $@"

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} abs({vname} x) => new({fn_value_x("abs")});

")}

{(n == 3 ? $@"
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} cross({vname} x, {vname} y) => (x * y.yzx - x.yzx * y).yzx;
" : "")}


{(simd ? $@"
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type} dot({vname} x, {vname} y) => Vector{bitSize}.Dot(x.vector, y.vector);
" : $@"
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type} dot({vname} x, {vname} y) => {dot};
")}

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type} mul({vname} a, {vname} b) => dot(a, b);

" : "")}

{(meta.Float ? $@"

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} tan({vname} x) => new({fn_value_x("tan")});

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} tanh({vname} x) => new({fn_value_x("tanh")});

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} atan({vname} x) => new({fn_value_x("atan")});

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} atanh({vname} x) => new({fn_value_x("tanh")});

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} atan2({vname} y, {vname} x) => new({fn_value_yx("atan2")});

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} tanPi({vname} x) => new({fn_value_x("tanPi")});

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} atanPi({vname} x) => new({fn_value_x("atanPi")});

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} atan2Pi({vname} y, {vname} x) => new({fn_value_yx("atan2Pi")});


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} cos({vname} x) => new({fn_value_x("cos")});

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} cosh({vname} x) => new({fn_value_x("cosh")});

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} acos({vname} x) => new({fn_value_x("acos")});

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} acosh({vname} x) => new({fn_value_x("acosh")});

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} cosPi({vname} x) => new({fn_value_x("cosPi")});

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} acosPi({vname} x) => new({fn_value_x("acosPi")});


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} sin({vname} x) => new({fn_value_x("sin")});

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} sinh({vname} x) => new({fn_value_x("sinh")});

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} asin({vname} x) => new({fn_value_x("asin")});

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} asinh({vname} x) => new({fn_value_x("asinh")});

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} sinPi({vname} x) => new({fn_value_x("sinPi")});

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} asinPi({vname} x) => new({fn_value_x("asinPi")});

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void sincos({vname} x, out {vname} sin, out {vname} cos)
    {{
        Unsafe.SkipInit(out sin);
        Unsafe.SkipInit(out cos);
        {sin_cos}
    }}

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static ({vname} sin, {vname} cos) sincos({vname} x)
    {{
        {sin_cos_part1}
        return (new({sin_cos_part2_sin}), new({sin_cos_part2_cos}));
    }}
" : "")}

{(meta.Float || meta.Decimal ? $@"

{(simd ? $@"

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} floor({vname} x) => new(Vector{bitSize}.Floor(x.vector));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} ceil({vname} x) => new(Vector{bitSize}.Ceiling(x.vector));

" : $@"

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} floor({vname} x) => new({fn_value_x("floor")});

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} ceil({vname} x) => new({fn_value_x("ceil")});

")}

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} round({vname} x) => new({fn_value_x("round")});

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} trunc({vname} x) => new({fn_value_x("trunc")});

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} frac({vname} x) => x - floor(x);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} rcp({vname} x) => {meta.One} / x;

" : "")}

{(meta.Unsigned ? "" : $@"

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} sign({vname} x) => new({fn_value_x("sign")});

")}

{(meta.Float ? $@"

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} pow({vname} x, {vname} y) => new({fn_value_xy("pow")});


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} exp({vname} x) => new({fn_value_x("exp")});

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} exp2({vname} x) => new({fn_value_x("exp2")});

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} exp10({vname} x) => new({fn_value_x("exp10")});

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} expM1({vname} x) => new({fn_value_x("expM1")});

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} exp2M1({vname} x) => new({fn_value_x("exp2M1")});

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} exp10M1({vname} x) => new({fn_value_x("exp10M1")});


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} log({vname} x) => new({fn_value_x("log")});

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} log2({vname} x) => new({fn_value_x("log2")});

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} log10({vname} x) => new({fn_value_x("log10")});

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} logP1({vname} x) => new({fn_value_x("logP1")});

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} log2P1({vname} x) => new({fn_value_x("log2P1")});

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} log10P1({vname} x) => new({fn_value_x("log10P1")});


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} modf({vname} x, out {vname} i) 
    {{ 
        i = trunc(x);
        return x - i;
    }}


{(simd ? $@"
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} sqrt({vname} x) => new(Vector{bitSize}.Sqrt(x.vector));
" : $@"
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} sqrt({vname} x) => new({fn_value_x("sqrt")});
")}

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} rsqrt({vname} x) => {meta.One} / sqrt(x);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} normalize({vname} x) => rsqrt(dot(x, x)) * x;

    // todo normalizesafe

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} length({vname} x) => sqrt(dot(x, x));


" : "")}

{(meta.Number ? $@"

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} lengthsq({vname} x) => dot(x, x);

" : "")}

{(meta.Float ? $@"

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} distance({vname} x, {vname} y) => length(y - x);

" : "")}

{(meta.Number ? $@"

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} distancesq({vname} x, {vname} y) => lengthsq(y - x);

    
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} select({vname} a, {vname} b, bool c) => c ? b : a;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} select({vname} a, {vname} b, bool{na} c) => new({select});

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} step({vname} y, {vname} x) => select(new {vname}({meta.Zero}), new {vname}({meta.One}), x >= y);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} reflect({vname} i, {vname} n) => i - {meta.Two} * n * dot(i, n);

{(meta.Float ? $@"

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} reflect({vname} i, {vname} n, {type} eta)
    {{
        var ni = dot(n, i);
        var k = {meta.One} - eta * eta * ({meta.One} - ni * ni);
        return select({meta.Zero}, eta * i - (eta * ni + sqrt(k)) * n, k >= {meta.Zero});
    }}

" : "")}


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} project({vname} a, {vname} b) => (dot(a, b) / dot(b, b)) * b;

    // todo projectsafe


{(meta.Unsigned ? "" : $@"

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} faceforward({vname} n, {vname} i, {vname} ng) => select(n, -n, dot(ng, i) >= {meta.Zero});

")}

{(meta.Float || meta.Decimal ? $@"
    
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} radians({vname} x) => x * {(meta.Half ? "(Half)" : "")}0.0174532925199432957692369076848861271344287188854172545609719144{meta.suffix};

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} degrees({vname} x) => x * {(meta.Half ? "(Half)" : "")}57.295779513082320876798154814105170332405472466564321549160243861{meta.suffix};


" : "")}

" : "")}

}}

public class {json_name}JsonConverter : JsonConverter<{vname}>
{{
    public override {vname} Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {{
        Unsafe.SkipInit(out {vname} result);
        if (reader.TokenType is not JsonTokenType.StartArray) throw new JsonException();{json_read}
        reader.Read();
        if (reader.TokenType is not JsonTokenType.EndArray) throw new JsonException();
        return result;
    }}

    public override void Write(Utf8JsonWriter writer, {vname} value, JsonSerializerOptions options)
    {{
        writer.WriteStartArray();{json_write}
        writer.WriteEndArray();
    }}
}}
";
                await SaveCode($"{vname}.gen.cs", source);
            }
        }
    }
}
