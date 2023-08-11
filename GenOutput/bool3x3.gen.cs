using System;
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
{

/// <summary>A 3x3 matrix of bool</summary>
[Serializable]
[JsonConverter(typeof(Bool3x3JsonConverter))]
[StructLayout(LayoutKind.Explicit, Size = 12, Pack = 1)]
public unsafe partial struct bool3x3 :
    IEquatable<bool3x3>, IEqualityOperators<bool3x3, bool3x3, bool>, IEqualityOperators<bool3x3, bool3x3, bool3x3>,

    IMatrix3x3<bool>, IMatrixSelf<bool3x3>, IMatrixIdentity<bool3x3>
{
    //////////////////////////////////////////////////////////////////////////////////////////////////// Fields

    #region Fields

    /// <summary>Column 0 of the matrix</summary>
    [FieldOffset(0)]
    public bool3 c0;

    /// <summary>Column 1 of the matrix</summary>
    [FieldOffset(4)]
    public bool3 c1;

    /// <summary>Column 2 of the matrix</summary>
    [FieldOffset(8)]
    public bool3 c2;


    /// <summary>Row 0 column 0 of the matrix</summary>
    [FieldOffset(0)]
    public bool m00;

    /// <summary>Row 1 column 0 of the matrix</summary>
    [FieldOffset(1)]
    public bool m10;

    /// <summary>Row 2 column 0 of the matrix</summary>
    [FieldOffset(2)]
    public bool m20;

    /// <summary>Row 0 column 1 of the matrix</summary>
    [FieldOffset(4)]
    public bool m01;

    /// <summary>Row 1 column 1 of the matrix</summary>
    [FieldOffset(5)]
    public bool m11;

    /// <summary>Row 2 column 1 of the matrix</summary>
    [FieldOffset(6)]
    public bool m21;

    /// <summary>Row 0 column 2 of the matrix</summary>
    [FieldOffset(8)]
    public bool m02;

    /// <summary>Row 1 column 2 of the matrix</summary>
    [FieldOffset(9)]
    public bool m12;

    /// <summary>Row 2 column 2 of the matrix</summary>
    [FieldOffset(10)]
    public bool m22;

    #endregion

    //////////////////////////////////////////////////////////////////////////////////////////////////// Constants

    #region Constants

    public static readonly bool3x3 identity = new bool3x3(
        true, false, false,
        false, true, false, 
        false, false, true
    );

    public static readonly bool3x3 zero = new(false);

    public static readonly bool3x3 one = new(true);

    static bool3x3 IMatrixSelf<bool3x3>.Zero 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => zero;
    }

    static bool3x3 IMatrixSelf<bool3x3>.One 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => one;
    }

    static bool3x3 IMatrixIdentity<bool3x3>.Identity 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => identity;
    }

    #endregion

    //////////////////////////////////////////////////////////////////////////////////////////////////// Ctor

    #region Ctor


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool3x3(bool3 c0, bool3 c1, bool3 c2)
    {
        Unsafe.SkipInit(out this);
        this.c0 = c0;
        this.c1 = c1;
        this.c2 = c2;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool3x3(bool m00, bool m10, bool m20, bool m01, bool m11, bool m21, bool m02, bool m12, bool m22)
    {
        Unsafe.SkipInit(out this);
        this.c0 = new(m00, m10, m20);
        this.c1 = new(m01, m11, m21);
        this.c2 = new(m02, m12, m22);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool3x3 RowMajor(bool m00, bool m01, bool m02, bool m10, bool m11, bool m12, bool m20, bool m21, bool m22) 
        => new(m00, m10, m20, m01, m11, m21, m02, m12, m22);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool3x3(bool value)
    {
        Unsafe.SkipInit(out this);
        this.c0 = new(value);
        this.c1 = new(value);
        this.c2 = new(value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool3x3(bool3 value)
    {
        Unsafe.SkipInit(out this);
        this.c0 = value;
        this.c1 = value;
        this.c2 = value;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool3x3(bool4x4 m)
    {
        this.c0 = m.c0.xyz;
        this.c1 = m.c1.xyz;
        this.c2 = m.c2.xyz;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator bool3x3(bool value) => new(value);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator bool3x3(bool3 value) => new(value);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static explicit operator bool(bool3x3 value) => value.m00;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static explicit operator bool3(bool3x3 value) => value.c0;

    #endregion

    //////////////////////////////////////////////////////////////////////////////////////////////////// Equals

    #region Equals

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator ==(bool3x3 left, bool3x3 right) 
        => left.c0 == right.c0 && left.c1 == right.c1 && left.c2 == right.c2;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator !=(bool3x3 left, bool3x3 right) 
        => left.c0 != right.c0 || left.c1 != right.c1 || left.c2 != right.c2;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool Equals(bool3x3 other) 
        => this == other;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override bool Equals(object? o) 
        => o is bool3x3 other && Equals(other);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override int GetHashCode() 
        => HashCode.Combine(this.c0, this.c1, this.c2);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public int3x3 Hash() 
        => new(this.c0.GetHashCode(), this.c1.GetHashCode(), this.c2.GetHashCode());

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    static bool3x3 IEqualityOperators<bool3x3, bool3x3, bool3x3>.operator ==(bool3x3 left, bool3x3 right) 
        => new(left.c0 == right.c0, left.c1 == right.c1, left.c2 == right.c2);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    static bool3x3 IEqualityOperators<bool3x3, bool3x3, bool3x3>.operator !=(bool3x3 left, bool3x3 right) 
        => new(left.c0 != right.c0, left.c1 != right.c1, left.c2 != right.c2);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool3x3 VEq(bool3x3 other) 
        => new(this.c0 == other.c0, this.c1 == other.c1, this.c2 == other.c2);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool3x3 VNe(bool3x3 other) 
        => new(this.c0 != other.c0, this.c1 != other.c1, this.c2 != other.c2);




    public bool AllTrue
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => this.c0.AllTrue && this.c1.AllTrue && this.c2.AllTrue;
    }

    public bool AllFalse
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => this.c0.AllFalse && this.c1.AllFalse && this.c2.AllFalse;
    }

    public bool AnyTrue
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => this.c0.AnyTrue || this.c1.AnyTrue || this.c2.AnyTrue;
    }

    public bool AnyFalse
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => this.c0.AnyTrue || this.c1.AnyTrue || this.c2.AnyTrue;
    }


    #endregion


    //////////////////////////////////////////////////////////////////////////////////////////////////// ToString

    #region ToString

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override string ToString() => $"bool3x3({this.c0}, {this.c1}, {this.c2})";

    #endregion

    //////////////////////////////////////////////////////////////////////////////////////////////////// Methods

    #region Methods



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool3x3 transpose(bool3x3 v) => new(
        v.c0.x, v.c0.y, v.c0.z,
        v.c1.x, v.c1.y, v.c1.z,
        v.c2.x, v.c2.y, v.c2.z
    );

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public readonly bool3x3 transpose() => transpose(this);

    #endregion
}

public static unsafe partial class vectors
{


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool3x3 bool3x3(bool3 c0, bool3 c1, bool3 c2) => new(c0, c1, c2);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool3x3 bool3x3(bool m00, bool m10, bool m20, bool m01, bool m11, bool m21, bool m02, bool m12, bool m22) 
        => new(m00, m10, m20, m01, m11, m21, m02, m12, m22);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool3x3 bool3x3(bool value) => new(value);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool3x3 bool3x3(bool3 value) => new(value);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool3x3 bool3x3(bool4x4 m) => new(m);


} // vectors

public static unsafe partial class math
{


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int3x3 pop_cnt(bool3x3 x) => new(pop_cnt(x.c0), pop_cnt(x.c1), pop_cnt(x.c2));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int count_bits(bool3x3 x) => msum(pop_cnt(x));

} // class math

namespace Json
{

public class Bool3x3JsonConverter : JsonConverter<bool3x3>
{
    private static readonly Type v_type = typeof(bool3);

    public override bool3x3 Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        Unsafe.SkipInit(out bool3x3 result);
        if (reader.TokenType is not JsonTokenType.StartArray) throw new JsonException();
        var conv = (JsonConverter<bool3>)options.GetConverter(v_type);
        reader.Read();
        result.c0 = conv.Read(ref reader, v_type, options);
        reader.Read();
        result.c1 = conv.Read(ref reader, v_type, options);
        reader.Read();
        result.c2 = conv.Read(ref reader, v_type, options);
        reader.Read();
        if (reader.TokenType is not JsonTokenType.EndArray) throw new JsonException();
        return result;
    }

    public override void Write(Utf8JsonWriter writer, bool3x3 value, JsonSerializerOptions options)
    {
        writer.WriteStartArray();
        var conv = (JsonConverter<bool3>)options.GetConverter(v_type);
        conv.Write(writer, value.c0, options);
        conv.Write(writer, value.c1, options);
        conv.Write(writer, value.c2, options);
        writer.WriteEndArray();
    }
} // class JsonConverter

} // namespace Json

} // namespace CCluster.Mathematics
