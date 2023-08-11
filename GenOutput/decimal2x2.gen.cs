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

/// <summary>A 2x2 matrix of decimal</summary>
[Serializable]
[JsonConverter(typeof(Decimal2x2JsonConverter))]
[StructLayout(LayoutKind.Explicit, Size = 64, Pack = 16)]
public unsafe partial struct decimal2x2 :
    IEquatable<decimal2x2>, IEqualityOperators<decimal2x2, decimal2x2, bool>, IEqualityOperators<decimal2x2, decimal2x2, bool2x2>,

    IAdditionOperators<decimal2x2, decimal2x2, decimal2x2>, IAdditiveIdentity<decimal2x2, decimal2x2>, IUnaryPlusOperators<decimal2x2, decimal2x2>,
    ISubtractionOperators<decimal2x2, decimal2x2, decimal2x2>, IUnaryNegationOperators<decimal2x2, decimal2x2>,
    IMultiplyOperators<decimal2x2, decimal2x2, decimal2x2>, IMultiplicativeIdentity<decimal2x2, decimal2x2>,
    IDivisionOperators<decimal2x2, decimal2x2, decimal2x2>,
    IModulusOperators<decimal2x2, decimal2x2, decimal2x2>,

    IMatrix2x2<decimal>, IMatrixSelf<decimal2x2>, IMatrixIdentity<decimal2x2>
{
    //////////////////////////////////////////////////////////////////////////////////////////////////// Fields

    #region Fields

    /// <summary>Column 0 of the matrix</summary>
    [FieldOffset(0)]
    public decimal2 c0;

    /// <summary>Column 1 of the matrix</summary>
    [FieldOffset(32)]
    public decimal2 c1;


    /// <summary>Row 0 column 0 of the matrix</summary>
    [FieldOffset(0)]
    public decimal m00;

    /// <summary>Row 1 column 0 of the matrix</summary>
    [FieldOffset(16)]
    public decimal m10;

    /// <summary>Row 0 column 1 of the matrix</summary>
    [FieldOffset(32)]
    public decimal m01;

    /// <summary>Row 1 column 1 of the matrix</summary>
    [FieldOffset(48)]
    public decimal m11;

    #endregion

    //////////////////////////////////////////////////////////////////////////////////////////////////// Constants

    #region Constants

    public static readonly decimal2x2 identity = new decimal2x2(
        1m, 0m, 
        0m, 1m
    );

    public static readonly decimal2x2 zero = new(0m);

    public static readonly decimal2x2 one = new(1m);

    static decimal2x2 IMatrixSelf<decimal2x2>.Zero 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => zero;
    }

    static decimal2x2 IMatrixSelf<decimal2x2>.One 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => one;
    }

    static decimal2x2 IMatrixIdentity<decimal2x2>.Identity 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => identity;
    }

    #endregion

    //////////////////////////////////////////////////////////////////////////////////////////////////// Ctor

    #region Ctor


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public decimal2x2(decimal2 c0, decimal2 c1)
    {
        Unsafe.SkipInit(out this);
        this.c0 = c0;
        this.c1 = c1;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public decimal2x2(decimal m00, decimal m10, decimal m01, decimal m11)
    {
        Unsafe.SkipInit(out this);
        this.c0 = new(m00, m10);
        this.c1 = new(m01, m11);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal2x2 RowMajor(decimal m00, decimal m01, decimal m10, decimal m11) 
        => new(m00, m10, m01, m11);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public decimal2x2(decimal value)
    {
        Unsafe.SkipInit(out this);
        this.c0 = new(value);
        this.c1 = new(value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public decimal2x2(decimal2 value)
    {
        Unsafe.SkipInit(out this);
        this.c0 = value;
        this.c1 = value;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public decimal2x2(decimal3x3 m)
    {
        this.c0 = m.c0.xy;
        this.c1 = m.c1.xy;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator decimal2x2(decimal value) => new(value);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator decimal2x2(decimal2 value) => new(value);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static explicit operator decimal(decimal2x2 value) => value.m00;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static explicit operator decimal2(decimal2x2 value) => value.c0;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static explicit operator uint2x2(decimal2x2 self) => new((uint2)self.c0, (uint2)self.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static explicit operator int2x2(decimal2x2 self) => new((int2)self.c0, (int2)self.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static explicit operator ulong2x2(decimal2x2 self) => new((ulong2)self.c0, (ulong2)self.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static explicit operator long2x2(decimal2x2 self) => new((long2)self.c0, (long2)self.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static explicit operator float2x2(decimal2x2 self) => new((float2)self.c0, (float2)self.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static explicit operator double2x2(decimal2x2 self) => new((double2)self.c0, (double2)self.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static explicit operator Half2x2(decimal2x2 self) => new((Half2)self.c0, (Half2)self.c1);

    #endregion

    //////////////////////////////////////////////////////////////////////////////////////////////////// Equals

    #region Equals

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator ==(decimal2x2 left, decimal2x2 right) 
        => left.c0 == right.c0 && left.c1 == right.c1;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator !=(decimal2x2 left, decimal2x2 right) 
        => left.c0 != right.c0 || left.c1 != right.c1;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool Equals(decimal2x2 other) 
        => this == other;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override bool Equals(object? o) 
        => o is decimal2x2 other && Equals(other);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override int GetHashCode() 
        => HashCode.Combine(this.c0, this.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public int2x2 Hash() 
        => new(this.c0.GetHashCode(), this.c1.GetHashCode());

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    static bool2x2 IEqualityOperators<decimal2x2, decimal2x2, bool2x2>.operator ==(decimal2x2 left, decimal2x2 right) 
        => new(left.c0 == right.c0, left.c1 == right.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    static bool2x2 IEqualityOperators<decimal2x2, decimal2x2, bool2x2>.operator !=(decimal2x2 left, decimal2x2 right) 
        => new(left.c0 != right.c0, left.c1 != right.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool2x2 VEq(decimal2x2 other) 
        => new(this.c0 == other.c0, this.c1 == other.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool2x2 VNe(decimal2x2 other) 
        => new(this.c0 != other.c0, this.c1 != other.c1);



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool2x2 operator >(decimal2x2 left, decimal2x2 right) => new(left.c0 > right.c0, left.c1 > right.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool2x2 operator <(decimal2x2 left, decimal2x2 right) => new(left.c0 < right.c0, left.c1 < right.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool2x2 operator >=(decimal2x2 left, decimal2x2 right) => new(left.c0 >= right.c0, left.c1 >= right.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool2x2 operator <=(decimal2x2 left, decimal2x2 right) => new(left.c0 <= right.c0, left.c1 <= right.c1);





    #endregion


    //////////////////////////////////////////////////////////////////////////////////////////////////// Arithmetic

    #region Arithmetic

    public static decimal2x2 AdditiveIdentity 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(0m);
    }

    public static decimal2x2 MultiplicativeIdentity 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(1m);
    }


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal2x2 operator +(decimal2x2 left, decimal2x2 right) 
        => new(left.c0 + right.c0, left.c1 + right.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal2x2 operator -(decimal2x2 left, decimal2x2 right) 
        => new(left.c0 - right.c0, left.c1 - right.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal2x2 operator *(decimal2x2 left, decimal2x2 right) 
        => new(left.c0 * right.c0, left.c1 * right.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal2x2 operator /(decimal2x2 left, decimal2x2 right) 
        => new(left.c0 / right.c0, left.c1 / right.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal2x2 operator %(decimal2x2 left, decimal2x2 right) 
        => new(left.c0 % right.c0, left.c1 % right.c1);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal2x2 operator +(decimal2x2 left, decimal2 right) => new(left.c0 + right, left.c1 + right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal2x2 operator -(decimal2x2 left, decimal2 right) => new(left.c0 - right, left.c1 - right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal2x2 operator *(decimal2x2 left, decimal2 right) => new(left.c0 * right, left.c1 * right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal2x2 operator /(decimal2x2 left, decimal2 right) => new(left.c0 / right, left.c1 / right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal2x2 operator %(decimal2x2 left, decimal2 right) => new(left.c0 % right, left.c1 % right);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal2x2 operator +(decimal2 left, decimal2x2 right) => new(left + right.c0, left + right.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal2x2 operator -(decimal2 left, decimal2x2 right) => new(left - right.c0, left - right.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal2x2 operator *(decimal2 left, decimal2x2 right) => new(left * right.c0, left * right.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal2x2 operator /(decimal2 left, decimal2x2 right) => new(left / right.c0, left / right.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal2x2 operator %(decimal2 left, decimal2x2 right) => new(left % right.c0, left % right.c1);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal2x2 operator +(decimal2x2 left, decimal right) => new(left.c0 + right, left.c1 + right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal2x2 operator -(decimal2x2 left, decimal right) => new(left.c0 - right, left.c1 - right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal2x2 operator *(decimal2x2 left, decimal right) => new(left.c0 * right, left.c1 * right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal2x2 operator /(decimal2x2 left, decimal right) => new(left.c0 / right, left.c1 / right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal2x2 operator %(decimal2x2 left, decimal right) => new(left.c0 % right, left.c1 % right);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal2x2 operator +(decimal left, decimal2x2 right) => new(left + right.c0, left + right.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal2x2 operator -(decimal left, decimal2x2 right) => new(left - right.c0, left - right.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal2x2 operator *(decimal left, decimal2x2 right) => new(left * right.c0, left * right.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal2x2 operator /(decimal left, decimal2x2 right) => new(left / right.c0, left / right.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal2x2 operator %(decimal left, decimal2x2 right) => new(left % right.c0, left % right.c1);

    
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal2x2 operator -(decimal2x2 self) => new(-self.c0, -self.c1);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal2x2 operator +(decimal2x2 self) => new(+self.c0, +self.c1);

    #endregion

    //////////////////////////////////////////////////////////////////////////////////////////////////// ToString

    #region ToString

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override string ToString() => $"decimal2x2({this.c0}, {this.c1})";

    #endregion

    //////////////////////////////////////////////////////////////////////////////////////////////////// Methods

    #region Methods



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal2x2 transpose(decimal2x2 v) => new(
        v.c0.x, v.c0.y,
        v.c1.x, v.c1.y
    );

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public readonly decimal2x2 transpose() => transpose(this);

    #endregion
}

public static unsafe partial class vectors
{


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal2x2 decimal2x2(decimal2 c0, decimal2 c1) => new(c0, c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal2x2 decimal2x2(decimal m00, decimal m10, decimal m01, decimal m11) 
        => new(m00, m10, m01, m11);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal2x2 decimal2x2(decimal value) => new(value);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal2x2 decimal2x2(decimal2 value) => new(value);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal2x2 decimal2x2(decimal3x3 m) => new(m);


} // vectors

public static unsafe partial class math
{

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal2 mul(decimal2 a, decimal2x2 b) => new(dot(a, b.c0), dot(a, b.c1));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal2 mul(decimal2x2 a, decimal2 b) => a.c0 * b.x + a.c1 * b.y;


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal2x2 mul(decimal2x2 a, decimal2x2 b) => new(
        a.c0 * b.c0.x + a.c1 * b.c0.y,
        a.c0 * b.c1.x + a.c1 * b.c1.y
    );

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal2x3 mul(decimal2x2 a, decimal2x3 b) => new(
        a.c0 * b.c0.x + a.c1 * b.c0.y,
        a.c0 * b.c1.x + a.c1 * b.c1.y,
        a.c0 * b.c2.x + a.c1 * b.c2.y
    );

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal2x4 mul(decimal2x2 a, decimal2x4 b) => new(
        a.c0 * b.c0.x + a.c1 * b.c0.y,
        a.c0 * b.c1.x + a.c1 * b.c1.y,
        a.c0 * b.c2.x + a.c1 * b.c2.y,
        a.c0 * b.c3.x + a.c1 * b.c3.y
    );


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal2x2 min(decimal2x2 x, decimal2x2 y) => new(min(x.c0, y.c0), min(x.c1, y.c1));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal2x2 max(decimal2x2 x, decimal2x2 y) => new(max(x.c0, y.c0), max(x.c1, y.c1));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal2x2 min(decimal2x2 x, decimal2x2 y, decimal2x2 z) => new(min(x.c0, y.c0, z.c0), min(x.c1, y.c1, z.c1));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal2x2 max(decimal2x2 x, decimal2x2 y, decimal2x2 z) => new(max(x.c0, y.c0, z.c0), max(x.c1, y.c1, z.c1));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal2x2 abs(decimal2x2 x) => new(abs(x.c0), abs(x.c1));



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal2x2 lerp(decimal2x2 s, decimal2x2 x, decimal2x2 y) => x + s * (y - x);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal2x2 unlerp(decimal2x2 x, decimal2x2 a, decimal2x2 b) => (x - a) / (b - a);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal2x2 remap(decimal2x2 x, decimal2x2 a, decimal2x2 b, decimal2x2 c, decimal2x2 d) => lerp(c, d, unlerp(a, b, x));


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal2x2 floor(decimal2x2 x) => new(floor(x.c0), floor(x.c1));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal2x2 ceil(decimal2x2 x) => new(ceil(x.c0), ceil(x.c1));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal2x2 round(decimal2x2 x) => new(round(x.c0), round(x.c1));



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal2 csum(decimal2x2 x) => x.c0 + x.c1;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal2 rsum(decimal2x2 x) => new(x.c0.x + x.c1.x, x.c0.y + x.c1.y);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal msum(decimal2x2 x) => csum(csum(x));



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int2x2 pop_cnt(decimal2x2 x) => new(pop_cnt(x.c0), pop_cnt(x.c1));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int count_bits(decimal2x2 x) => msum(pop_cnt(x));

} // class math

namespace Json
{

public class Decimal2x2JsonConverter : JsonConverter<decimal2x2>
{
    private static readonly Type v_type = typeof(decimal2);

    public override decimal2x2 Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        Unsafe.SkipInit(out decimal2x2 result);
        if (reader.TokenType is not JsonTokenType.StartArray) throw new JsonException();
        var conv = (JsonConverter<decimal2>)options.GetConverter(v_type);
        reader.Read();
        result.c0 = conv.Read(ref reader, v_type, options);
        reader.Read();
        result.c1 = conv.Read(ref reader, v_type, options);
        reader.Read();
        if (reader.TokenType is not JsonTokenType.EndArray) throw new JsonException();
        return result;
    }

    public override void Write(Utf8JsonWriter writer, decimal2x2 value, JsonSerializerOptions options)
    {
        writer.WriteStartArray();
        var conv = (JsonConverter<decimal2>)options.GetConverter(v_type);
        conv.Write(writer, value.c0, options);
        conv.Write(writer, value.c1, options);
        writer.WriteEndArray();
    }
} // class JsonConverter

} // namespace Json

} // namespace CCluster.Mathematics
