using System.Text;

namespace CodeGen;

public class GenMatrix : Base
{
    public override async Task Gen()
    {
        foreach (var tm in TypeMeta.types)
        {
            var type = tm.Key;
            var meta = tm.Value;

            foreach (var _nv in Enumerable.Range(2, 4))
            {
                foreach (var nm in Enumerable.Range(2, 3))
                {
                    var nv = _nv;

                    var no_align = false;
                    if (nv == 5)
                    {
                        nv = 3;
                        no_align = true;
                    }

                    var align_name = no_align ? "a" : string.Empty;
                    var na = $"{nv}{align_name}";
                    var ma = nm == 3 && no_align ? $"{nm}a" : $"{nm}";
                    var vname = $"{type}{na}";
                    var nma = $"{nv}x{nm}{align_name}";
                    var mname = $"{type}{nma}";

                    var byteSize = meta.Size * (nv == 3 && !no_align ? 4 : nv);
                    var bitSize = byteSize * 8;
                    var simd = !no_align && meta.Simd && bitSize is 64 or 128 or 256;

                    #region fields

                    var fields = new StringBuilder();
                    foreach (var i in Enumerable.Range(0, nm))
                    {
                        fields.Append($@"
    /// <summary>Column {i} of the matrix</summary>
    [FieldOffset({i * byteSize})]
    public {vname} c{i};
");
                    }

                    fields.Append($"\n");

                    foreach (var im in Enumerable.Range(0, nm))
                    {
                        foreach (var iv in Enumerable.Range(0, nv))
                        {
                            fields.Append($@"
    /// <summary>Row {iv} column {im} of the matrix</summary>
    [FieldOffset({im * byteSize + iv * meta.Size})]
    public {type} m{iv}{im};
");
                        }
                    }

                    #endregion

                    #region Identity

                    var has_identity = false;
                    var identity = new StringBuilder();

                    if (nv == nm)
                    {
                        if (nv == 2)
                        {
                            has_identity = true;
                            identity.Append($@"
    public static readonly {mname} identity = new {mname}(
        {meta.One}, {meta.Zero}, 
        {meta.Zero}, {meta.One}
    );
");
                        }
                        else if (nv == 3)
                        {
                            has_identity = true;
                            identity.Append($@"
    public static readonly {mname} identity = new {mname}(
        {meta.One}, {meta.Zero}, {meta.Zero},
        {meta.Zero}, {meta.One}, {meta.Zero}, 
        {meta.Zero}, {meta.Zero}, {meta.One}
    );
");
                        }
                        else if (nv == 4)
                        {
                            has_identity = true;
                            identity.Append($@"
    public static readonly {mname} identity = new {mname}(
        {meta.One}, {meta.Zero}, {meta.Zero}, {meta.Zero},
        {meta.Zero}, {meta.One}, {meta.Zero}, {meta.Zero},
        {meta.Zero}, {meta.Zero}, {meta.One}, {meta.Zero},
        {meta.Zero}, {meta.Zero}, {meta.Zero}, {meta.One}
    );
");
                        }
                    }

                    #endregion

                    #region ctors

                    var ctors = new StringBuilder();

                    #region ctor1

                    {
                        var cols = string.Join(", ", Enumerable.Range(0, nm).Select(i => $"{vname} c{i}"));

                        ctors.Append($@"
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public {mname}({cols})
    {{
        Unsafe.SkipInit(out this);
");
                        foreach (var i in Enumerable.Range(0, nm))
                        {
                            if (simd)
                            {
                                ctors.Append($"        this.c{i}.vector = c{i}.vector;\n");
                            }
                            else
                            {
                                ctors.Append($"        this.c{i} = c{i};\n");
                            }
                        }
                        ctors.Append($@"    }}
");
                    }

                    #endregion

                    #region ctor2

                    {
                        var args = string.Join(", ", Enumerable.Range(0, nm)
                            .SelectMany(im => Enumerable.Range(0, nv).Select(iv => $"{type} m{iv}{im}")));

                        ctors.Append($@"
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public {mname}({args})
    {{
        Unsafe.SkipInit(out this);
");
                        foreach (var im in Enumerable.Range(0, nm))
                        {
                            var items = string.Join(", ", Enumerable.Range(0, nv)
                                .Select(iv => $"m{iv}{im}"));
                            if (simd)
                            {
                                if (nv == 3)
                                {
                                    ctors.Append(
                                        $"        this.c{im}.vector = Vector{bitSize}.Create({items}, {meta.Zero});\n");
                                }
                                else
                                {
                                    ctors.Append($"        this.c{im}.vector = Vector{bitSize}.Create({items});\n");
                                }
                            }
                            else
                            {
                                ctors.Append($"        this.c{im} = new({items});\n");
                            }
                        }
                        ctors.Append($@"    }}
");
                    }

                    #endregion

                    #region ctor3

                    {
                        ctors.Append($@"
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public {mname}({type} value)
    {{
        Unsafe.SkipInit(out this);
");
                        foreach (var im in Enumerable.Range(0, nm))
                        {
                            if (simd)
                            {
                                ctors.Append($"        this.c{im}.vector = Vector{bitSize}.Create(value);\n");
                            }
                            else
                            {
                                ctors.Append($"        this.c{im} = new(value);\n");
                            }
                        }
                        ctors.Append($@"    }}
");
                    }

                    #endregion

                    #region ctor4

                    {
                        ctors.Append($@"
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public {mname}({vname} value)
    {{
        Unsafe.SkipInit(out this);
");
                        foreach (var im in Enumerable.Range(0, nm))
                        {
                            if (simd)
                            {
                                ctors.Append($"        this.c{im}.vector = value.vector;\n");
                            }
                            else
                            {
                                ctors.Append($"        this.c{im} = value;\n");
                            }
                        }
                        ctors.Append($@"    }}
");
                    }

                    #endregion
                    
                    #endregion

                    #region aligned convert
                    
                    var aligned_convert = new StringBuilder();
                    
                    var value_c_value = string.Join(", ", Enumerable.Range(0, nm).Select(i => $"value.c{i}"));

                    if (no_align)
                    {
                        aligned_convert.Append($@"
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator {type}{nv}x{nm}{align_name}({type}{nv}x{nm} value) => new({value_c_value});

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator {type}{nv}x{nm}({type}{nv}x{nm}{align_name} value) => new({value_c_value});
");
                    }
                    
                    #endregion
                    
                    var take_self_c_value = string.Join(", ",
                        Enumerable.Range(0, nm).Select(i => $"self.c{i}"));
                
                    string cast_self_c_value(string t, string a) => string.Join(", ",
                        Enumerable.Range(0, nm).Select(i => $"({t}{nv}{a})self.c{i}"));
                    
                    #region converts

                    var converts = new StringBuilder();

                    if (TypeMeta.typeImplicitConvert.TryGetValue(type, out var implicit_targets))
                    {
                        foreach (var it in implicit_targets)
                        {
                            converts.Append($@"
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator {it}{nv}x{nm}({mname} self) => new({take_self_c_value});
");
                            if (nv == 3)
                            {
                                converts.Append($@"
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator {it}{nv}x{nm}a({mname} self) => new({take_self_c_value});
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
    public static explicit operator {et}{nv}x{nm}({mname} self) => new({cast_self_c_value(et, "")});
");
                            if (nv == 3)
                            {
                                converts.Append($@"
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static explicit operator {et}{nv}x{nm}a({mname} self) => new({cast_self_c_value(et, "a")});
");
                            }
                        }
                    }

                    #endregion

                    
                    var hash_value = string.Join(", ", Enumerable.Range(0, nm).Select(i => $"this.c{i}.GetHashCode()"));

                    var eq_and = string.Join(" && ",
                        Enumerable.Range(0, nm).Select(i => $"left.c{i} == right.c{i}"));
                    var ne_or = string.Join(" || ",
                        Enumerable.Range(0, nm).Select(i => $"left.c{i} != right.c{i}"));

                    var c_this_value = string.Join(", ", Enumerable.Range(0, nm).Select(i => $"this.c{i}"));

                    var c_this_value_to_str =
                        string.Join(", ", Enumerable.Range(0, nm).Select(i => $"{{this.c{i}}}"));

                    string this_oper_c_value(string op) => string.Join(", ",
                        Enumerable.Range(0, nm).Select(i => $"this.c{i} {op} other.c{i}"));

                    string oper_c_value(string op) => string.Join(", ",
                        Enumerable.Range(0, nm).Select(i => $"left.c{i} {op} right.c{i}"));

                    string unary_oper_c_value(string op) => string.Join(", ",
                        Enumerable.Range(0, nm).Select(i => $"{op}self.c{i}"));

                    string oper_c_scalar_right_value(string op) => string.Join(", ",
                        Enumerable.Range(0, nm).Select(i => $"left.c{i} {op} right"));

                    string oper_c_scalar_left_value(string op) => string.Join(", ",
                        Enumerable.Range(0, nm).Select(i => $"left {op} right.c{i}"));

                    var matrix_mul_scalar_a = string.Join(", ",
                        Enumerable.Range(0, nm).Select(i => $"dot(a, b.c{i})"));

                    var matrix_mul_scalar_b = string.Join(" + ",
                        Enumerable.Range(0, nm).Select(i => $"a.c{i} * b.{xyzw[i]}"));

                    var matrix_muls = new StringBuilder();

                    if (meta.Number)
                    {
                        foreach (var ibm in Enumerable.Range(2, 3))
                        {
                            var matrix_mul = string.Join(",\n        ", Enumerable.Range(0, ibm).Select(j =>
                                string.Join(" + ", Enumerable.Range(0, nm)
                                    .Select(i => $"a.c{i} * b.c{j}.{xyzw[i]}")
                                )
                            ));
                            var a1 = no_align && nm == 3 ? "a" : string.Empty;
                            var a2 = no_align && nv == 3 ? "a" : string.Empty;
                            var rm_type = $"{type}{nm}x{ibm}{a1}";
                            var re_type = $"{type}{nv}x{ibm}{a2}";
                            matrix_muls.Append($@"
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {re_type} mul({mname} a, {rm_type} b) => new(
        {matrix_mul}
    );
");
                        }
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

/// <summary>A {nv}x{nm} matrix of {type}</summary>
[Serializable]
[StructLayout(LayoutKind.Explicit, Size = {byteSize * nm}, Pack = {meta.Size})]
public unsafe partial struct {mname} :
    IEquatable<{mname}>, IEqualityOperators<{mname}, {mname}, bool>, IEqualityOperators<{mname}, {mname}, bool{nma}>,
{(meta.Number ? $@"
    IAdditionOperators<{mname}, {mname}, {mname}>, IAdditiveIdentity<{mname}, {mname}>, IUnaryPlusOperators<{mname}, {mname}>,
    ISubtractionOperators<{mname}, {mname}, {mname}>, {(meta.Unsigned ? "" : $@"IUnaryNegationOperators<{mname}, {mname}>,")}
    IMultiplyOperators<{mname}, {mname}, {mname}>, IMultiplicativeIdentity<{mname}, {mname}>,
    IDivisionOperators<{mname}, {mname}, {mname}>,
    IModulusOperators<{mname}, {mname}, {mname}>,
" : "" /* meta.Number */)}
    IMatrix{nv}x{nm}<{type}>, IMatrixSelf<{mname}>{(has_identity ? $", IMatrixIdentity<{mname}>" : "")}
{{
    //////////////////////////////////////////////////////////////////////////////////////////////////// Fields

    #region Fields
{fields}
    #endregion

    //////////////////////////////////////////////////////////////////////////////////////////////////// Constants

    #region Constants
{identity}
    public static readonly {mname} zero = new({meta.Zero});

    public static readonly {mname} one = new({meta.One});

    static {mname} IMatrixSelf<{mname}>.Zero 
    {{
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => zero;
    }}

    static {mname} IMatrixSelf<{mname}>.One 
    {{
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => one;
    }}
{(has_identity ? $@"
    static {mname} IMatrixIdentity<{mname}>.Identity 
    {{
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => identity;
    }}" : "" /* has_identity */)}

    #endregion

    //////////////////////////////////////////////////////////////////////////////////////////////////// Ctor

    #region Ctor

{ctors}
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator {mname}({type} value) => new(value);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator {mname}({vname} value) => new(value);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static explicit operator {type}({mname} value) => value.m00;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static explicit operator {vname}({mname} value) => value.c0;
{aligned_convert}{converts}
    #endregion

    //////////////////////////////////////////////////////////////////////////////////////////////////// Equals

    #region Equals

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator ==({mname} left, {mname} right) 
        => {eq_and};

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator !=({mname} left, {mname} right) 
        => {ne_or};

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool Equals({mname} other) 
        => this == other;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override bool Equals(object? o) 
        => o is {mname} other && Equals(other);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override int GetHashCode() 
        => HashCode.Combine({c_this_value});

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public int{nv}x{nm}{align_name} Hash() 
        => new({hash_value});

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    static bool{nv}x{nm}{align_name} IEqualityOperators<{mname}, {mname}, bool{nv}x{nm}{align_name}>.operator ==({mname} left, {mname} right) 
        => new({oper_c_value("==")});

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    static bool{nv}x{nm}{align_name} IEqualityOperators<{mname}, {mname}, bool{nv}x{nm}{align_name}>.operator !=({mname} left, {mname} right) 
        => new({oper_c_value("!=")});

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool{nv}x{nm}{align_name} VEq({mname} other) 
        => new({this_oper_c_value("==")});

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool{nv}x{nm}{align_name} VNe({mname} other) 
        => new({this_oper_c_value("!=")});

    #endregion

{(meta.Number ? $@"
    //////////////////////////////////////////////////////////////////////////////////////////////////// Arithmetic

    #region Arithmetic

    public static {mname} AdditiveIdentity 
    {{
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new({meta.Zero});
    }}

    public static {mname} MultiplicativeIdentity 
    {{
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new({meta.One});
    }}


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {mname} operator +({mname} left, {mname} right) 
        => new({oper_c_value("+")});

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {mname} operator -({mname} left, {mname} right) 
        => new({oper_c_value("-")});

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {mname} operator *({mname} left, {mname} right) 
        => new({oper_c_value("*")});

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {mname} operator /({mname} left, {mname} right) 
        => new({oper_c_value("/")});

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {mname} operator %({mname} left, {mname} right) 
        => new({oper_c_value("%")});


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {mname} operator +({mname} left, {vname} right) => new({oper_c_scalar_right_value("+")});

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {mname} operator -({mname} left, {vname} right) => new({oper_c_scalar_right_value("-")});

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {mname} operator *({mname} left, {vname} right) => new({oper_c_scalar_right_value("*")});

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {mname} operator /({mname} left, {vname} right) => new({oper_c_scalar_right_value("/")});

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {mname} operator %({mname} left, {vname} right) => new({oper_c_scalar_right_value("%")});


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {mname} operator +({vname} left, {mname} right) => new({oper_c_scalar_left_value("+")});

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {mname} operator -({vname} left, {mname} right) => new({oper_c_scalar_left_value("-")});

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {mname} operator *({vname} left, {mname} right) => new({oper_c_scalar_left_value("*")});

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {mname} operator /({vname} left, {mname} right) => new({oper_c_scalar_left_value("/")});

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {mname} operator %({vname} left, {mname} right) => new({oper_c_scalar_left_value("%")});


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {mname} operator +({mname} left, {type} right) => new({oper_c_scalar_right_value("+")});

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {mname} operator -({mname} left, {type} right) => new({oper_c_scalar_right_value("-")});

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {mname} operator *({mname} left, {type} right) => new({oper_c_scalar_right_value("*")});

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {mname} operator /({mname} left, {type} right) => new({oper_c_scalar_right_value("/")});

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {mname} operator %({mname} left, {type} right) => new({oper_c_scalar_right_value("%")});


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {mname} operator +({type} left, {mname} right) => new({oper_c_scalar_left_value("+")});

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {mname} operator -({type} left, {mname} right) => new({oper_c_scalar_left_value("-")});

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {mname} operator *({type} left, {mname} right) => new({oper_c_scalar_left_value("*")});

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {mname} operator /({type} left, {mname} right) => new({oper_c_scalar_left_value("/")});

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {mname} operator %({type} left, {mname} right) => new({oper_c_scalar_left_value("%")});

{(meta.Unsigned ? "" : $@"    
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {mname} operator -({mname} self) => new({unary_oper_c_value("-")});
")}

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {mname} operator +({mname} self) => new({unary_oper_c_value("+")});

    #endregion
" : "" /* meta.Number */)}
    //////////////////////////////////////////////////////////////////////////////////////////////////// ToString

    #region ToString

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override string ToString() => $""{mname}({c_this_value_to_str})"";

    #endregion
}}

public static unsafe partial class math
{{
{(meta.Number ? $@"
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type}{ma} mul({vname} a, {mname} b) => new({matrix_mul_scalar_a});

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {vname} mul({mname} a, {type}{ma} b) => {matrix_mul_scalar_b};

{matrix_muls}

" : "" /* meta.Number */)}
}}
";
                    await SaveCode($"{mname}.gen.cs", source);
                }
            }
        }
    }
}
