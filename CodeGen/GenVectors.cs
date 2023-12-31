﻿using System;
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
                    string.Join(", ", Enumerable.Range(0, n).Select(i => $"{{this.{xyzw[i]}}}{(type is "float" ? "f" : "")}"));

                var v3_iz = n == 3 ? $" & math.v3_iz_{type}{bitSize}" : "";
                var vint = bitSize == 256 ? "long" : "int";

                #region ctors

                var ctors = new StringBuilder();
                var fa_ctors = new StringBuilder();

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
                        fa_ctors.Append($@"
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} {vname}(Vector{bitSize}<{type}> vector) => new(vector);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} {vname}({type} value) => new(value);
");
                    }
                    else
                    {
                        ctors.Append($@"
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public {vname}({type} value) : this({value_n_value}) {{ }}
");
                        fa_ctors.Append($@"
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} {vname}({type} value) => new(value);
");
                    }
                }

                #endregion

                #region ctor2

                {
                    fa_ctors.Append($@"
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} {vname}({xyzw_arg}) => new({xyzw_value});
");
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
                    fa_ctors.Append($@"
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} {vname}({type}{2} xy, {type} z) => new(xy, z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} {vname}({type} x, {type}{2} yz) => new(x, yz);
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
                    fa_ctors.Append($@"
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} {vname}({type}{2} xy, {type}{2} zw) => new(xy, zw);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} {vname}({type}{2} xy, {type} z, {type} w) => new(xy, z, w);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} {vname}({type} x, {type}{2} yz, {type} w) => new(x, yz, w);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} {vname}({type} x, {type} y, {type}{2} zw) => new(x, y, zw);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} {vname}({type}{3}{align_name} xyz, {type} w) => new(xyz, w);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} {vname}({type} x, {type}{3}{align_name} yzw) => new(x, yzw);
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

                var take_self_value = string.Join(", ",
                    Enumerable.Range(0, n).Select(i => $"self.{xyzw[i]}"));

                string cast_self_value(string t) => string.Join(", ",
                    Enumerable.Range(0, n).Select(i => $"({t})self.{xyzw[i]}"));

                #region converts

                var converts = new StringBuilder();

                if (TypeMeta.typeImplicitConvert.TryGetValue(type, out var implicit_targets))
                {
                    foreach (var it in implicit_targets)
                    {
                        converts.Append($@"
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator {it}{n}({vname} self) => new({take_self_value});
");
                        if (n == 3)
                        {
                            converts.Append($@"
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator {it}{n}a({vname} self) => new({take_self_value});
");
                        }
                    }
                }
                if (TypeMeta.typeExplicitConvert.TryGetValue(type, out var explicit_targets))
                {
                    foreach (var et in explicit_targets)
                    {
                        converts.Append($@"
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static explicit operator {et}{n}({vname} self) => new({cast_self_value(et)});
");
                        if (n == 3)
                        {
                            converts.Append($@"
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static explicit operator {et}{n}a({vname} self) => new({cast_self_value(et)});
");
                        }
                    }
                }

                #endregion

                #region transmutes

                var transmutes = new StringBuilder();

                foreach (var ttm in TypeMeta.types)
                {
                    var t_type = ttm.Key;
                    var t_meta = ttm.Value;

                    if (t_meta.Size != meta.Size) continue;
                    if (t_type == type) continue;

                    if (simd)
                    {
                        transmutes.Append($@"
    /// <summary>transmute {type}{na} memory to {t_type}{na} memory</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {t_type}{na} as_{t_type}(this {type}{na} val) => new(val.vector.As<{type}, {t_type}>());
");
                    }
                    else
                    {
                        transmutes.Append($@"
    /// <summary>transmute {type}{na} memory to {t_type}{na} memory</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {t_type}{na} as_{t_type}(this {type}{na} val) => val.Transmute<{type}{na}, {t_type}{na}>();
");
                    }
                    transmutes.Append($@"
    /// <summary>transmute {type}{na} memory to {t_type}{na} memory</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {t_type}{na} as{t_type}({type}{na} val) => as_{t_type}(val);
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

                var value_x_add = string.Join(" + ",
                    Enumerable.Range(0, n).Select(i => $"x.{xyzw[i]}"));

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
using CCluster.Mathematics.Json;

#nullable enable
#pragma warning disable CS8981

namespace CCluster.Mathematics
{{

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

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static explicit operator {type}({vname} value) => value.x;
{aligned_convert}{converts}
{(simd ? $@"
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator {vname}(Vector{bitSize}<{type}> vector) => new(vector);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator Vector{bitSize}<{type}>({vname} self) => self.vector;
" : "")}
    #endregion

    //////////////////////////////////////////////////////////////////////////////////////////////////// Equals

    #region Equals

{(simd ? $@"
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool Equals({vname} other)
    {{
        return (this.vector{v3_iz}).Equals((other.vector{v3_iz}));
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
        return (left.vector{v3_iz}).Equals((right.vector{v3_iz}));
    }}

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator !=({vname} left, {vname} right)
    {{
        return !(left.vector{v3_iz}).Equals((right.vector{v3_iz}));
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
    public static {vname} operator +({vname} left, {vname} right) => new(left.vector + right.vector);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} operator -({vname} left, {vname} right) => new(left.vector - right.vector);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} operator *({vname} left, {vname} right) => new(left.vector * right.vector);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} operator /({vname} left, {vname} right) => new(left.vector / right.vector);

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
    //////////////////////////////////////////////////////////////////////////////////////////////////// BitOpers

    #region BitOpers
{(simd ? $@"

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} operator &({vname} left, {vname} right) => new(left.vector & right.vector);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} operator |({vname} left, {vname} right) => new(left.vector | right.vector);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} operator ^({vname} left, {vname} right) => new(left.vector ^ right.vector);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} operator ~({vname} self) => new(~self.vector);

" : meta.Number ? "" : $@"

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} operator &({vname} left, {vname} right) => new({oper_value("&")});

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} operator |({vname} left, {vname} right) => new({oper_value("|")});

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} operator ^({vname} left, {vname} right) => new({oper_value("^")});

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} operator ~({vname} self) => new({unary_oper_value(type is "bool" ? "!" : "~")});

")}

{(type is "bool" ? $@"
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} operator !({vname} self) => new({unary_oper_value("!")});
" : "")}
    #endregion

    //////////////////////////////////////////////////////////////////////////////////////////////////// ToString

    #region ToString

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override string ToString() => $""{vname}({xyzw_this_value_to_str})"";

    #endregion
}}

public static unsafe partial class vectors
{{

{fa_ctors}

{transmutes}

}} // vectors

public static unsafe partial class math
{{

{(meta.Number ? $@"

{(simd ? $@"
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} min({vname} x, {vname} y) => new(Vector{bitSize}.Min(x.vector, y.vector));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} max({vname} x, {vname} y) => new(Vector{bitSize}.Max(x.vector, y.vector));
" : $@"
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} min({vname} x, {vname} y) => new({fn_value_xy("min")});

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} max({vname} x, {vname} y) => new({fn_value_xy("max")});
" /* simd */)}

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} min({vname} x, {vname} y, {vname} z) => min(min(x, y), z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} max({vname} x, {vname} y, {vname} z) => max(max(x, y), z);

{(meta.Float || meta.Decimal ? $@"

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} lerp({vname} s, {vname} x, {vname} y) => x + s * (y - x);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} unlerp({vname} x, {vname} a, {vname} b) => (x - a) / (b - a);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} remap({vname} x, {vname} a, {vname} b, {vname} c, {vname} d) => lerp(c, d, unlerp(a, b, x));

" : "" /* meta.Float || meta.Decimal */)}

{(simd ? $@"
    
{(n == 3 ? $@"
    internal static readonly Vector{bitSize}<{type}> v3_iz_{type}{bitSize} = Vector{bitSize}.Create(-1, -1, -1, 0).As<{vint}, {type}>();
" : "" /* n == 3 */)}

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} mad({vname} a, {vname} b, {vname} c)
    {{
        {(meta.Float && bitSize is 128 or 256 ? $"if (Fma.IsSupported) return new(Fma.MultiplyAdd(a.vector, b.vector, c.vector));" : "")}
        {(type == "double" && bitSize is 128 ? $"if (AdvSimd.Arm64.IsSupported) return new(AdvSimd.Arm64.FusedMultiplyAdd(c.vector, a.vector, b.vector));" : "")}
        {(type == "float" && bitSize is 64 or 128 ? $"if (AdvSimd.IsSupported) return new(AdvSimd.FusedMultiplyAdd(c.vector, a.vector, b.vector));" : "")}
        return a * b + c;
    }}
" /* simd */ : /* !simd */ $@"
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} mad({vname} a, {vname} b, {vname} c) => a * b + c;
" /* simd */)}

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} clamp({vname} x, {vname} a, {vname} b) => max(a, min(b, x));

{(meta.Float || meta.Decimal ? $@"

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} saturate({vname} x) => clamp(x, {vname}.zero, {vname}.one);

" : "" /* meta.Float || meta.Decimal */)}

{(meta.Unsigned ? $@"

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} abs({vname} x) => x;

" : $@"

{(simd ? $@"
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} abs({vname} x) => new(Vector{bitSize}.Abs(x.vector));
" : $@"
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} abs({vname} x) => new({fn_value_x("abs")});
" /* simd */)}

" /* meta.Unsigned */)}

{(n == 3 ? $@"
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} cross({vname} x, {vname} y) => (x * y.yzx - x.yzx * y).yzx;
" : "" /* n == 3 */)}


{(simd ? $@"
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type} dot({vname} x, {vname} y)
    {{
        {(bitSize is 128 && n == 3 && type is "float" ? $"if (Sse41.IsSupported) return Sse41.DotProduct(x.vector, y.vector, 113).ToScalar();" : "")}
        return Vector{bitSize}.Dot(x.vector{v3_iz}, y.vector);
    }}
" : $@"
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type} dot({vname} x, {vname} y) => {dot};
" /* simd */)}

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type} mul({vname} a, {vname} b) => dot(a, b);

" : "" /* meta.Number */)}

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
" : "" /* meta.Float */)}

{(meta.Float || meta.Decimal ? $@"

{(simd ? $@"

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} floor({vname} x) => new(Vector{bitSize}.Floor(x.vector));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} ceil({vname} x) => new(Vector{bitSize}.Ceiling(x.vector));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} round({vname} x)
    {{
        {(bitSize is 128 && type is "float" or "double" ? $"if (Sse41.IsSupported) return new(Sse41.RoundToNearestInteger(x.vector));" : "")}
        {(bitSize is 256 && type is "double" ? $"if (Avx.IsSupported) return new(Avx.RoundToNearestInteger(x.vector));" : "")}
        return new({fn_value_x("round")});
    }}

" /* simd */ : /* !simd */ $@"

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} floor({vname} x) => new({fn_value_x("floor")});

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} ceil({vname} x) => new({fn_value_x("ceil")});

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} round({vname} x) => new({fn_value_x("round")});

" /* simd */)}

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} trunc({vname} x) => new({fn_value_x("trunc")});

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} frac({vname} x) => x - floor(x);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} rcp({vname} x) => {meta.One} / x;

" : "" /* meta.Float || meta.Decimal */)}

{(meta.Unsigned ? "" : $@"

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} sign({vname} x) => new({fn_value_x("sign")});

" /* meta.Unsigned */)}

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
" /* simd */)}

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} rsqrt({vname} x) => {meta.One} / sqrt(x);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} normalize({vname} x) => rsqrt(dot(x, x)) * x;

    // todo normalizesafe

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} length({vname} x) => sqrt(dot(x, x));


" : "" /* meta.Float */)}

{(meta.Number ? $@"

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} lengthsq({vname} x) => dot(x, x);

" : "" /* meta.Number */)}

{(meta.Float ? $@"

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} distance({vname} x, {vname} y) => length(y - x);

" : "" /* meta.Float */)}

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

" : "" /* meta.Float */)}


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} project({vname} a, {vname} b) => (dot(a, b) / dot(b, b)) * b;

    // todo projectsafe


{(meta.Unsigned ? "" : $@"

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} faceforward({vname} n, {vname} i, {vname} ng) => select(n, -n, dot(ng, i) >= {meta.Zero});

" /* meta.Unsigned */)}

{(meta.Float || meta.Decimal ? $@"
    
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} radians({vname} x) => x * {(meta.Half ? "(Half)" : "")}0.0174532925199432957692369076848861271344287188854172545609719144{meta.suffix};

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} degrees({vname} x) => x * {(meta.Half ? "(Half)" : "")}57.295779513082320876798154814105170332405472466564321549160243861{meta.suffix};


" : "" /* meta.Float || meta.Decimal */)}

{(simd ? $@"
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type} csum({vname} x) => Vector{bitSize}.Sum(x.vector{v3_iz});
" : $@"
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type} csum({vname} x) => {value_x_add};
")}

" : "" /* meta.Number */)}

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int{na} pop_cnt({vname} x)
    {{
        return new({fn_value_x("pop_cnt")});
    }}

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int count_bits({vname} x)
    {{
{(simd && bitSize is 128 or 64 ? $@"
        if (AdvSimd.Arm64.IsSupported)
        {{
            var a = AdvSimd.Arm64.AddAcross(AdvSimd.PopCount((x.vector{v3_iz}).AsByte()));
            return a.ToScalar();
        }}
" : "")}
        return csum(pop_cnt(x));
    }}

}} // class math

namespace Json
{{

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
}} // class JsonConverter

}} // namespace Json

}} // namespace CCluster.Mathematics
";
                await SaveCode($"{vname}.gen.cs", source);
            }
        }
    }
}
