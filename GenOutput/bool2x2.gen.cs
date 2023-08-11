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

/// <summary>A 2x2 matrix of bool</summary>
[Serializable]
[JsonConverter(typeof(Bool2x2JsonConverter))]
[StructLayout(LayoutKind.Explicit, Size = 4, Pack = 1)]
public unsafe partial struct bool2x2 :
    IEquatable<bool2x2>, IEqualityOperators<bool2x2, bool2x2, bool>, IEqualityOperators<bool2x2, bool2x2, bool2x2>,

    IMatrix2x2<bool>, IMatrixSelf<bool2x2>, IMatrixIdentity<bool2x2>
{
    //////////////////////////////////////////////////////////////////////////////////////////////////// Fields

    #region Fields

    /// <summary>Column 0 of the matrix</summary>
    [FieldOffset(0)]
    public bool2 c0;

    /// <summary>Column 1 of the matrix</summary>
    [FieldOffset(2)]
    public bool2 c1;


    /// <summary>Row 0 column 0 of the matrix</summary>
    [FieldOffset(0)]
    public bool m00;

    /// <summary>Row 1 column 0 of the matrix</summary>
    [FieldOffset(1)]
    public bool m10;

    /// <summary>Row 0 column 1 of the matrix</summary>
    [FieldOffset(2)]
    public bool m01;

    /// <summary>Row 1 column 1 of the matrix</summary>
    [FieldOffset(3)]
    public bool m11;

    #endregion

    //////////////////////////////////////////////////////////////////////////////////////////////////// Constants

    #region Constants

    public static readonly bool2x2 identity = new bool2x2(
        true, false, 
        false, true
    );

    public static readonly bool2x2 zero = new(false);

    public static readonly bool2x2 one = new(true);

    static bool2x2 IMatrixSelf<bool2x2>.Zero 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => zero;
    }

    static bool2x2 IMatrixSelf<bool2x2>.One 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => one;
    }

    static bool2x2 IMatrixIdentity<bool2x2>.Identity 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => identity;
    }

    #endregion

    //////////////////////////////////////////////////////////////////////////////////////////////////// Ctor

    #region Ctor


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool2x2(bool2 c0, bool2 c1)
    {
        Unsafe.SkipInit(out this);
        this.c0 = c0;
        this.c1 = c1;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool2x2(bool m00, bool m10, bool m01, bool m11)
    {
        Unsafe.SkipInit(out this);
        this.c0 = new(m00, m10);
        this.c1 = new(m01, m11);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool2x2 RowMajor(bool m00, bool m01, bool m10, bool m11) 
        => new(m00, m10, m01, m11);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool2x2(bool value)
    {
        Unsafe.SkipInit(out this);
        this.c0 = new(value);
        this.c1 = new(value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool2x2(bool2 value)
    {
        Unsafe.SkipInit(out this);
        this.c0 = value;
        this.c1 = value;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool2x2(bool3x3 m)
    {
        this.c0 = m.c0.xy;
        this.c1 = m.c1.xy;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator bool2x2(bool value) => new(value);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator bool2x2(bool2 value) => new(value);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static explicit operator bool(bool2x2 value) => value.m00;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static explicit operator bool2(bool2x2 value) => value.c0;

    #endregion

    //////////////////////////////////////////////////////////////////////////////////////////////////// Equals

    #region Equals

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator ==(bool2x2 left, bool2x2 right) 
        => left.c0 == right.c0 && left.c1 == right.c1;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator !=(bool2x2 left, bool2x2 right) 
        => left.c0 != right.c0 || left.c1 != right.c1;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool Equals(bool2x2 other) 
        => this == other;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override bool Equals(object? o) 
        => o is bool2x2 other && Equals(other);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override int GetHashCode() 
        => HashCode.Combine(this.c0, this.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public int2x2 Hash() 
        => new(this.c0.GetHashCode(), this.c1.GetHashCode());

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    static bool2x2 IEqualityOperators<bool2x2, bool2x2, bool2x2>.operator ==(bool2x2 left, bool2x2 right) 
        => new(left.c0 == right.c0, left.c1 == right.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    static bool2x2 IEqualityOperators<bool2x2, bool2x2, bool2x2>.operator !=(bool2x2 left, bool2x2 right) 
        => new(left.c0 != right.c0, left.c1 != right.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool2x2 VEq(bool2x2 other) 
        => new(this.c0 == other.c0, this.c1 == other.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool2x2 VNe(bool2x2 other) 
        => new(this.c0 != other.c0, this.c1 != other.c1);




    public bool AllTrue
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => this.c0.AllTrue && this.c1.AllTrue;
    }

    public bool AllFalse
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => this.c0.AllFalse && this.c1.AllFalse;
    }

    public bool AnyTrue
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => this.c0.AnyTrue || this.c1.AnyTrue;
    }

    public bool AnyFalse
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => this.c0.AnyTrue || this.c1.AnyTrue;
    }


    #endregion


    //////////////////////////////////////////////////////////////////////////////////////////////////// ToString

    #region ToString

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override string ToString() => $"bool2x2({this.c0}, {this.c1})";

    #endregion

    //////////////////////////////////////////////////////////////////////////////////////////////////// Methods

    #region Methods



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool2x2 transpose(bool2x2 v) => new(
        v.c0.x, v.c0.y,
        v.c1.x, v.c1.y
    );

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public readonly bool2x2 transpose() => transpose(this);

    #endregion
}

public static unsafe partial class vectors
{


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool2x2 bool2x2(bool2 c0, bool2 c1) => new(c0, c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool2x2 bool2x2(bool m00, bool m10, bool m01, bool m11) 
        => new(m00, m10, m01, m11);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool2x2 bool2x2(bool value) => new(value);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool2x2 bool2x2(bool2 value) => new(value);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool2x2 bool2x2(bool3x3 m) => new(m);


} // vectors

public static unsafe partial class math
{


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int2x2 pop_cnt(bool2x2 x) => new(pop_cnt(x.c0), pop_cnt(x.c1));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int count_bits(bool2x2 x) => msum(pop_cnt(x));

} // class math

namespace Json
{

public class Bool2x2JsonConverter : JsonConverter<bool2x2>
{
    private static readonly Type v_type = typeof(bool2);

    public override bool2x2 Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        Unsafe.SkipInit(out bool2x2 result);
        if (reader.TokenType is not JsonTokenType.StartArray) throw new JsonException();
        var conv = (JsonConverter<bool2>)options.GetConverter(v_type);
        reader.Read();
        result.c0 = conv.Read(ref reader, v_type, options);
        reader.Read();
        result.c1 = conv.Read(ref reader, v_type, options);
        reader.Read();
        if (reader.TokenType is not JsonTokenType.EndArray) throw new JsonException();
        return result;
    }

    public override void Write(Utf8JsonWriter writer, bool2x2 value, JsonSerializerOptions options)
    {
        writer.WriteStartArray();
        var conv = (JsonConverter<bool2>)options.GetConverter(v_type);
        conv.Write(writer, value.c0, options);
        conv.Write(writer, value.c1, options);
        writer.WriteEndArray();
    }
} // class JsonConverter

} // namespace Json

} // namespace CCluster.Mathematics
