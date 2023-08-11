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

/// <summary>A 3x2 matrix of long</summary>
[Serializable]
[JsonConverter(typeof(Long3x2JsonConverter))]
[StructLayout(LayoutKind.Explicit, Size = 64, Pack = 8)]
public unsafe partial struct long3x2 :
    IEquatable<long3x2>, IEqualityOperators<long3x2, long3x2, bool>, IEqualityOperators<long3x2, long3x2, bool3x2>,

    IAdditionOperators<long3x2, long3x2, long3x2>, IAdditiveIdentity<long3x2, long3x2>, IUnaryPlusOperators<long3x2, long3x2>,
    ISubtractionOperators<long3x2, long3x2, long3x2>, IUnaryNegationOperators<long3x2, long3x2>,
    IMultiplyOperators<long3x2, long3x2, long3x2>, IMultiplicativeIdentity<long3x2, long3x2>,
    IDivisionOperators<long3x2, long3x2, long3x2>,
    IModulusOperators<long3x2, long3x2, long3x2>,

    IMatrix3x2<long>, IMatrixSelf<long3x2>
{
    //////////////////////////////////////////////////////////////////////////////////////////////////// Fields

    #region Fields

    /// <summary>Column 0 of the matrix</summary>
    [FieldOffset(0)]
    public long3 c0;

    /// <summary>Column 1 of the matrix</summary>
    [FieldOffset(32)]
    public long3 c1;


    /// <summary>Row 0 column 0 of the matrix</summary>
    [FieldOffset(0)]
    public long m00;

    /// <summary>Row 1 column 0 of the matrix</summary>
    [FieldOffset(8)]
    public long m10;

    /// <summary>Row 2 column 0 of the matrix</summary>
    [FieldOffset(16)]
    public long m20;

    /// <summary>Row 0 column 1 of the matrix</summary>
    [FieldOffset(32)]
    public long m01;

    /// <summary>Row 1 column 1 of the matrix</summary>
    [FieldOffset(40)]
    public long m11;

    /// <summary>Row 2 column 1 of the matrix</summary>
    [FieldOffset(48)]
    public long m21;

    #endregion

    //////////////////////////////////////////////////////////////////////////////////////////////////// Constants

    #region Constants

    public static readonly long3x2 zero = new(0L);

    public static readonly long3x2 one = new(1L);

    static long3x2 IMatrixSelf<long3x2>.Zero 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => zero;
    }

    static long3x2 IMatrixSelf<long3x2>.One 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => one;
    }


    #endregion

    //////////////////////////////////////////////////////////////////////////////////////////////////// Ctor

    #region Ctor


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public long3x2(long3 c0, long3 c1)
    {
        Unsafe.SkipInit(out this);
        this.c0.vector = c0.vector;
        this.c1.vector = c1.vector;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public long3x2(long m00, long m10, long m20, long m01, long m11, long m21)
    {
        Unsafe.SkipInit(out this);
        this.c0.vector = Vector256.Create(m00, m10, m20, 0L);
        this.c1.vector = Vector256.Create(m01, m11, m21, 0L);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long3x2 RowMajor(long m00, long m01, long m10, long m11, long m20, long m21) 
        => new(m00, m10, m20, m01, m11, m21);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public long3x2(long value)
    {
        Unsafe.SkipInit(out this);
        this.c0.vector = Vector256.Create(value);
        this.c1.vector = Vector256.Create(value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public long3x2(long3 value)
    {
        Unsafe.SkipInit(out this);
        this.c0.vector = value.vector;
        this.c1.vector = value.vector;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator long3x2(long value) => new(value);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator long3x2(long3 value) => new(value);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static explicit operator long(long3x2 value) => value.m00;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static explicit operator long3(long3x2 value) => value.c0;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator float3x2(long3x2 self) => new(self.c0, self.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator float3x2a(long3x2 self) => new(self.c0, self.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator double3x2(long3x2 self) => new(self.c0, self.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator double3x2a(long3x2 self) => new(self.c0, self.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator decimal3x2(long3x2 self) => new(self.c0, self.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator decimal3x2a(long3x2 self) => new(self.c0, self.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static explicit operator uint3x2(long3x2 self) => new((uint3)self.c0, (uint3)self.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static explicit operator uint3x2a(long3x2 self) => new((uint3a)self.c0, (uint3a)self.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static explicit operator int3x2(long3x2 self) => new((int3)self.c0, (int3)self.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static explicit operator int3x2a(long3x2 self) => new((int3a)self.c0, (int3a)self.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static explicit operator ulong3x2(long3x2 self) => new((ulong3)self.c0, (ulong3)self.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static explicit operator ulong3x2a(long3x2 self) => new((ulong3a)self.c0, (ulong3a)self.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static explicit operator Half3x2(long3x2 self) => new((Half3)self.c0, (Half3)self.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static explicit operator Half3x2a(long3x2 self) => new((Half3a)self.c0, (Half3a)self.c1);

    #endregion

    //////////////////////////////////////////////////////////////////////////////////////////////////// Equals

    #region Equals

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator ==(long3x2 left, long3x2 right) 
        => left.c0 == right.c0 && left.c1 == right.c1;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator !=(long3x2 left, long3x2 right) 
        => left.c0 != right.c0 || left.c1 != right.c1;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool Equals(long3x2 other) 
        => this == other;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override bool Equals(object? o) 
        => o is long3x2 other && Equals(other);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override int GetHashCode() 
        => HashCode.Combine(this.c0, this.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public int3x2 Hash() 
        => new(this.c0.GetHashCode(), this.c1.GetHashCode());

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    static bool3x2 IEqualityOperators<long3x2, long3x2, bool3x2>.operator ==(long3x2 left, long3x2 right) 
        => new(left.c0 == right.c0, left.c1 == right.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    static bool3x2 IEqualityOperators<long3x2, long3x2, bool3x2>.operator !=(long3x2 left, long3x2 right) 
        => new(left.c0 != right.c0, left.c1 != right.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool3x2 VEq(long3x2 other) 
        => new(this.c0 == other.c0, this.c1 == other.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool3x2 VNe(long3x2 other) 
        => new(this.c0 != other.c0, this.c1 != other.c1);



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool3x2 operator >(long3x2 left, long3x2 right) => new(left.c0 > right.c0, left.c1 > right.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool3x2 operator <(long3x2 left, long3x2 right) => new(left.c0 < right.c0, left.c1 < right.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool3x2 operator >=(long3x2 left, long3x2 right) => new(left.c0 >= right.c0, left.c1 >= right.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool3x2 operator <=(long3x2 left, long3x2 right) => new(left.c0 <= right.c0, left.c1 <= right.c1);





    #endregion


    //////////////////////////////////////////////////////////////////////////////////////////////////// Arithmetic

    #region Arithmetic

    public static long3x2 AdditiveIdentity 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(0L);
    }

    public static long3x2 MultiplicativeIdentity 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(1L);
    }


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long3x2 operator +(long3x2 left, long3x2 right) 
        => new(left.c0 + right.c0, left.c1 + right.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long3x2 operator -(long3x2 left, long3x2 right) 
        => new(left.c0 - right.c0, left.c1 - right.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long3x2 operator *(long3x2 left, long3x2 right) 
        => new(left.c0 * right.c0, left.c1 * right.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long3x2 operator /(long3x2 left, long3x2 right) 
        => new(left.c0 / right.c0, left.c1 / right.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long3x2 operator %(long3x2 left, long3x2 right) 
        => new(left.c0 % right.c0, left.c1 % right.c1);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long3x2 operator +(long3x2 left, long3 right) => new(left.c0 + right, left.c1 + right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long3x2 operator -(long3x2 left, long3 right) => new(left.c0 - right, left.c1 - right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long3x2 operator *(long3x2 left, long3 right) => new(left.c0 * right, left.c1 * right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long3x2 operator /(long3x2 left, long3 right) => new(left.c0 / right, left.c1 / right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long3x2 operator %(long3x2 left, long3 right) => new(left.c0 % right, left.c1 % right);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long3x2 operator +(long3 left, long3x2 right) => new(left + right.c0, left + right.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long3x2 operator -(long3 left, long3x2 right) => new(left - right.c0, left - right.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long3x2 operator *(long3 left, long3x2 right) => new(left * right.c0, left * right.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long3x2 operator /(long3 left, long3x2 right) => new(left / right.c0, left / right.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long3x2 operator %(long3 left, long3x2 right) => new(left % right.c0, left % right.c1);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long3x2 operator +(long3x2 left, long right) => new(left.c0 + right, left.c1 + right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long3x2 operator -(long3x2 left, long right) => new(left.c0 - right, left.c1 - right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long3x2 operator *(long3x2 left, long right) => new(left.c0 * right, left.c1 * right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long3x2 operator /(long3x2 left, long right) => new(left.c0 / right, left.c1 / right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long3x2 operator %(long3x2 left, long right) => new(left.c0 % right, left.c1 % right);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long3x2 operator +(long left, long3x2 right) => new(left + right.c0, left + right.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long3x2 operator -(long left, long3x2 right) => new(left - right.c0, left - right.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long3x2 operator *(long left, long3x2 right) => new(left * right.c0, left * right.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long3x2 operator /(long left, long3x2 right) => new(left / right.c0, left / right.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long3x2 operator %(long left, long3x2 right) => new(left % right.c0, left % right.c1);

    
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long3x2 operator -(long3x2 self) => new(-self.c0, -self.c1);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long3x2 operator +(long3x2 self) => new(+self.c0, +self.c1);

    #endregion

    //////////////////////////////////////////////////////////////////////////////////////////////////// ToString

    #region ToString

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override string ToString() => $"long3x2({this.c0}, {this.c1})";

    #endregion

    //////////////////////////////////////////////////////////////////////////////////////////////////// Methods

    #region Methods



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long3x2 transpose(long3x2 v) => new(
        v.c0.x, v.c0.y, v.c0.z,
        v.c1.x, v.c1.y, v.c1.z
    );

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public readonly long3x2 transpose() => transpose(this);

    #endregion
}

public static unsafe partial class vectors
{


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long3x2 long3x2(long3 c0, long3 c1) => new(c0, c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long3x2 long3x2(long m00, long m10, long m20, long m01, long m11, long m21) 
        => new(m00, m10, m20, m01, m11, m21);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long3x2 long3x2(long value) => new(value);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long3x2 long3x2(long3 value) => new(value);


} // vectors

public static unsafe partial class math
{

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long2 mul(long3 a, long3x2 b) => new(dot(a, b.c0), dot(a, b.c1));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long3 mul(long3x2 a, long2 b) => a.c0 * b.x + a.c1 * b.y;


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long3x2 mul(long3x2 a, long2x2 b) => new(
        a.c0 * b.c0.x + a.c1 * b.c0.y,
        a.c0 * b.c1.x + a.c1 * b.c1.y
    );

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long3x3 mul(long3x2 a, long2x3 b) => new(
        a.c0 * b.c0.x + a.c1 * b.c0.y,
        a.c0 * b.c1.x + a.c1 * b.c1.y,
        a.c0 * b.c2.x + a.c1 * b.c2.y
    );

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long3x4 mul(long3x2 a, long2x4 b) => new(
        a.c0 * b.c0.x + a.c1 * b.c0.y,
        a.c0 * b.c1.x + a.c1 * b.c1.y,
        a.c0 * b.c2.x + a.c1 * b.c2.y,
        a.c0 * b.c3.x + a.c1 * b.c3.y
    );


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long3x2 min(long3x2 x, long3x2 y) => new(min(x.c0, y.c0), min(x.c1, y.c1));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long3x2 max(long3x2 x, long3x2 y) => new(max(x.c0, y.c0), max(x.c1, y.c1));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long3x2 min(long3x2 x, long3x2 y, long3x2 z) => new(min(x.c0, y.c0, z.c0), min(x.c1, y.c1, z.c1));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long3x2 max(long3x2 x, long3x2 y, long3x2 z) => new(max(x.c0, y.c0, z.c0), max(x.c1, y.c1, z.c1));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long3x2 abs(long3x2 x) => new(abs(x.c0), abs(x.c1));



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long3 csum(long3x2 x) => x.c0 + x.c1;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long3 rsum(long3x2 x) => new(x.c0.x + x.c1.x, x.c0.y + x.c1.y, x.c0.z + x.c1.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long msum(long3x2 x) => csum(csum(x));



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int3x2 pop_cnt(long3x2 x) => new(pop_cnt(x.c0), pop_cnt(x.c1));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int count_bits(long3x2 x) => msum(pop_cnt(x));

} // class math

namespace Json
{

public class Long3x2JsonConverter : JsonConverter<long3x2>
{
    private static readonly Type v_type = typeof(long3);

    public override long3x2 Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        Unsafe.SkipInit(out long3x2 result);
        if (reader.TokenType is not JsonTokenType.StartArray) throw new JsonException();
        var conv = (JsonConverter<long3>)options.GetConverter(v_type);
        reader.Read();
        result.c0 = conv.Read(ref reader, v_type, options);
        reader.Read();
        result.c1 = conv.Read(ref reader, v_type, options);
        reader.Read();
        if (reader.TokenType is not JsonTokenType.EndArray) throw new JsonException();
        return result;
    }

    public override void Write(Utf8JsonWriter writer, long3x2 value, JsonSerializerOptions options)
    {
        writer.WriteStartArray();
        var conv = (JsonConverter<long3>)options.GetConverter(v_type);
        conv.Write(writer, value.c0, options);
        conv.Write(writer, value.c1, options);
        writer.WriteEndArray();
    }
} // class JsonConverter

} // namespace Json

} // namespace CCluster.Mathematics
