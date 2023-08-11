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

/// <summary>A 4x2 matrix of Half</summary>
[Serializable]
[JsonConverter(typeof(Half4x2JsonConverter))]
[StructLayout(LayoutKind.Explicit, Size = 16, Pack = 2)]
public unsafe partial struct Half4x2 :
    IEquatable<Half4x2>, IEqualityOperators<Half4x2, Half4x2, bool>, IEqualityOperators<Half4x2, Half4x2, bool4x2>,

    IAdditionOperators<Half4x2, Half4x2, Half4x2>, IAdditiveIdentity<Half4x2, Half4x2>, IUnaryPlusOperators<Half4x2, Half4x2>,
    ISubtractionOperators<Half4x2, Half4x2, Half4x2>, IUnaryNegationOperators<Half4x2, Half4x2>,
    IMultiplyOperators<Half4x2, Half4x2, Half4x2>, IMultiplicativeIdentity<Half4x2, Half4x2>,
    IDivisionOperators<Half4x2, Half4x2, Half4x2>,
    IModulusOperators<Half4x2, Half4x2, Half4x2>,

    IMatrix4x2<Half>, IMatrixSelf<Half4x2>
{
    //////////////////////////////////////////////////////////////////////////////////////////////////// Fields

    #region Fields

    /// <summary>Column 0 of the matrix</summary>
    [FieldOffset(0)]
    public Half4 c0;

    /// <summary>Column 1 of the matrix</summary>
    [FieldOffset(8)]
    public Half4 c1;


    /// <summary>Row 0 column 0 of the matrix</summary>
    [FieldOffset(0)]
    public Half m00;

    /// <summary>Row 1 column 0 of the matrix</summary>
    [FieldOffset(2)]
    public Half m10;

    /// <summary>Row 2 column 0 of the matrix</summary>
    [FieldOffset(4)]
    public Half m20;

    /// <summary>Row 3 column 0 of the matrix</summary>
    [FieldOffset(6)]
    public Half m30;

    /// <summary>Row 0 column 1 of the matrix</summary>
    [FieldOffset(8)]
    public Half m01;

    /// <summary>Row 1 column 1 of the matrix</summary>
    [FieldOffset(10)]
    public Half m11;

    /// <summary>Row 2 column 1 of the matrix</summary>
    [FieldOffset(12)]
    public Half m21;

    /// <summary>Row 3 column 1 of the matrix</summary>
    [FieldOffset(14)]
    public Half m31;

    #endregion

    //////////////////////////////////////////////////////////////////////////////////////////////////// Constants

    #region Constants

    public static readonly Half4x2 zero = new(Half.Zero);

    public static readonly Half4x2 one = new(Half.One);

    static Half4x2 IMatrixSelf<Half4x2>.Zero 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => zero;
    }

    static Half4x2 IMatrixSelf<Half4x2>.One 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => one;
    }


    #endregion

    //////////////////////////////////////////////////////////////////////////////////////////////////// Ctor

    #region Ctor


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public Half4x2(Half4 c0, Half4 c1)
    {
        Unsafe.SkipInit(out this);
        this.c0 = c0;
        this.c1 = c1;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public Half4x2(Half m00, Half m10, Half m20, Half m30, Half m01, Half m11, Half m21, Half m31)
    {
        Unsafe.SkipInit(out this);
        this.c0 = new(m00, m10, m20, m30);
        this.c1 = new(m01, m11, m21, m31);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4x2 RowMajor(Half m00, Half m01, Half m10, Half m11, Half m20, Half m21, Half m30, Half m31) 
        => new(m00, m10, m20, m30, m01, m11, m21, m31);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public Half4x2(Half value)
    {
        Unsafe.SkipInit(out this);
        this.c0 = new(value);
        this.c1 = new(value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public Half4x2(Half4 value)
    {
        Unsafe.SkipInit(out this);
        this.c0 = value;
        this.c1 = value;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator Half4x2(Half value) => new(value);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator Half4x2(Half4 value) => new(value);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static explicit operator Half(Half4x2 value) => value.m00;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static explicit operator Half4(Half4x2 value) => value.c0;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static explicit operator uint4x2(Half4x2 self) => new((uint4)self.c0, (uint4)self.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static explicit operator int4x2(Half4x2 self) => new((int4)self.c0, (int4)self.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static explicit operator ulong4x2(Half4x2 self) => new((ulong4)self.c0, (ulong4)self.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static explicit operator long4x2(Half4x2 self) => new((long4)self.c0, (long4)self.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static explicit operator float4x2(Half4x2 self) => new((float4)self.c0, (float4)self.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static explicit operator double4x2(Half4x2 self) => new((double4)self.c0, (double4)self.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static explicit operator decimal4x2(Half4x2 self) => new((decimal4)self.c0, (decimal4)self.c1);

    #endregion

    //////////////////////////////////////////////////////////////////////////////////////////////////// Equals

    #region Equals

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator ==(Half4x2 left, Half4x2 right) 
        => left.c0 == right.c0 && left.c1 == right.c1;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator !=(Half4x2 left, Half4x2 right) 
        => left.c0 != right.c0 || left.c1 != right.c1;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool Equals(Half4x2 other) 
        => this == other;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override bool Equals(object? o) 
        => o is Half4x2 other && Equals(other);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override int GetHashCode() 
        => HashCode.Combine(this.c0, this.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public int4x2 Hash() 
        => new(this.c0.GetHashCode(), this.c1.GetHashCode());

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    static bool4x2 IEqualityOperators<Half4x2, Half4x2, bool4x2>.operator ==(Half4x2 left, Half4x2 right) 
        => new(left.c0 == right.c0, left.c1 == right.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    static bool4x2 IEqualityOperators<Half4x2, Half4x2, bool4x2>.operator !=(Half4x2 left, Half4x2 right) 
        => new(left.c0 != right.c0, left.c1 != right.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool4x2 VEq(Half4x2 other) 
        => new(this.c0 == other.c0, this.c1 == other.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool4x2 VNe(Half4x2 other) 
        => new(this.c0 != other.c0, this.c1 != other.c1);



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool4x2 operator >(Half4x2 left, Half4x2 right) => new(left.c0 > right.c0, left.c1 > right.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool4x2 operator <(Half4x2 left, Half4x2 right) => new(left.c0 < right.c0, left.c1 < right.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool4x2 operator >=(Half4x2 left, Half4x2 right) => new(left.c0 >= right.c0, left.c1 >= right.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool4x2 operator <=(Half4x2 left, Half4x2 right) => new(left.c0 <= right.c0, left.c1 <= right.c1);





    #endregion


    //////////////////////////////////////////////////////////////////////////////////////////////////// Arithmetic

    #region Arithmetic

    public static Half4x2 AdditiveIdentity 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(Half.Zero);
    }

    public static Half4x2 MultiplicativeIdentity 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(Half.One);
    }


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4x2 operator +(Half4x2 left, Half4x2 right) 
        => new(left.c0 + right.c0, left.c1 + right.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4x2 operator -(Half4x2 left, Half4x2 right) 
        => new(left.c0 - right.c0, left.c1 - right.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4x2 operator *(Half4x2 left, Half4x2 right) 
        => new(left.c0 * right.c0, left.c1 * right.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4x2 operator /(Half4x2 left, Half4x2 right) 
        => new(left.c0 / right.c0, left.c1 / right.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4x2 operator %(Half4x2 left, Half4x2 right) 
        => new(left.c0 % right.c0, left.c1 % right.c1);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4x2 operator +(Half4x2 left, Half4 right) => new(left.c0 + right, left.c1 + right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4x2 operator -(Half4x2 left, Half4 right) => new(left.c0 - right, left.c1 - right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4x2 operator *(Half4x2 left, Half4 right) => new(left.c0 * right, left.c1 * right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4x2 operator /(Half4x2 left, Half4 right) => new(left.c0 / right, left.c1 / right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4x2 operator %(Half4x2 left, Half4 right) => new(left.c0 % right, left.c1 % right);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4x2 operator +(Half4 left, Half4x2 right) => new(left + right.c0, left + right.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4x2 operator -(Half4 left, Half4x2 right) => new(left - right.c0, left - right.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4x2 operator *(Half4 left, Half4x2 right) => new(left * right.c0, left * right.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4x2 operator /(Half4 left, Half4x2 right) => new(left / right.c0, left / right.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4x2 operator %(Half4 left, Half4x2 right) => new(left % right.c0, left % right.c1);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4x2 operator +(Half4x2 left, Half right) => new(left.c0 + right, left.c1 + right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4x2 operator -(Half4x2 left, Half right) => new(left.c0 - right, left.c1 - right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4x2 operator *(Half4x2 left, Half right) => new(left.c0 * right, left.c1 * right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4x2 operator /(Half4x2 left, Half right) => new(left.c0 / right, left.c1 / right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4x2 operator %(Half4x2 left, Half right) => new(left.c0 % right, left.c1 % right);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4x2 operator +(Half left, Half4x2 right) => new(left + right.c0, left + right.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4x2 operator -(Half left, Half4x2 right) => new(left - right.c0, left - right.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4x2 operator *(Half left, Half4x2 right) => new(left * right.c0, left * right.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4x2 operator /(Half left, Half4x2 right) => new(left / right.c0, left / right.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4x2 operator %(Half left, Half4x2 right) => new(left % right.c0, left % right.c1);

    
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4x2 operator -(Half4x2 self) => new(-self.c0, -self.c1);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4x2 operator +(Half4x2 self) => new(+self.c0, +self.c1);

    #endregion

    //////////////////////////////////////////////////////////////////////////////////////////////////// ToString

    #region ToString

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override string ToString() => $"Half4x2({this.c0}, {this.c1})";

    #endregion

    //////////////////////////////////////////////////////////////////////////////////////////////////// Methods

    #region Methods



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4x2 transpose(Half4x2 v) => new(
        v.c0.x, v.c0.y, v.c0.z, v.c0.w,
        v.c1.x, v.c1.y, v.c1.z, v.c1.w
    );

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public readonly Half4x2 transpose() => transpose(this);

    #endregion
}

public static unsafe partial class vectors
{


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4x2 Half4x2(Half4 c0, Half4 c1) => new(c0, c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4x2 Half4x2(Half m00, Half m10, Half m20, Half m30, Half m01, Half m11, Half m21, Half m31) 
        => new(m00, m10, m20, m30, m01, m11, m21, m31);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4x2 Half4x2(Half value) => new(value);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4x2 Half4x2(Half4 value) => new(value);


} // vectors

public static unsafe partial class math
{

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half2 mul(Half4 a, Half4x2 b) => new(dot(a, b.c0), dot(a, b.c1));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4 mul(Half4x2 a, Half2 b) => a.c0 * b.x + a.c1 * b.y;


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4x2 mul(Half4x2 a, Half2x2 b) => new(
        a.c0 * b.c0.x + a.c1 * b.c0.y,
        a.c0 * b.c1.x + a.c1 * b.c1.y
    );

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4x3 mul(Half4x2 a, Half2x3 b) => new(
        a.c0 * b.c0.x + a.c1 * b.c0.y,
        a.c0 * b.c1.x + a.c1 * b.c1.y,
        a.c0 * b.c2.x + a.c1 * b.c2.y
    );

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4x4 mul(Half4x2 a, Half2x4 b) => new(
        a.c0 * b.c0.x + a.c1 * b.c0.y,
        a.c0 * b.c1.x + a.c1 * b.c1.y,
        a.c0 * b.c2.x + a.c1 * b.c2.y,
        a.c0 * b.c3.x + a.c1 * b.c3.y
    );


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4x2 min(Half4x2 x, Half4x2 y) => new(min(x.c0, y.c0), min(x.c1, y.c1));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4x2 max(Half4x2 x, Half4x2 y) => new(max(x.c0, y.c0), max(x.c1, y.c1));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4x2 min(Half4x2 x, Half4x2 y, Half4x2 z) => new(min(x.c0, y.c0, z.c0), min(x.c1, y.c1, z.c1));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4x2 max(Half4x2 x, Half4x2 y, Half4x2 z) => new(max(x.c0, y.c0, z.c0), max(x.c1, y.c1, z.c1));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4x2 abs(Half4x2 x) => new(abs(x.c0), abs(x.c1));



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4x2 lerp(Half4x2 s, Half4x2 x, Half4x2 y) => x + s * (y - x);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4x2 unlerp(Half4x2 x, Half4x2 a, Half4x2 b) => (x - a) / (b - a);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4x2 remap(Half4x2 x, Half4x2 a, Half4x2 b, Half4x2 c, Half4x2 d) => lerp(c, d, unlerp(a, b, x));


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4x2 floor(Half4x2 x) => new(floor(x.c0), floor(x.c1));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4x2 ceil(Half4x2 x) => new(ceil(x.c0), ceil(x.c1));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4x2 round(Half4x2 x) => new(round(x.c0), round(x.c1));



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4 csum(Half4x2 x) => x.c0 + x.c1;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4 rsum(Half4x2 x) => new(x.c0.x + x.c1.x, x.c0.y + x.c1.y, x.c0.z + x.c1.z, x.c0.w + x.c1.w);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half msum(Half4x2 x) => csum(csum(x));



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int4x2 pop_cnt(Half4x2 x) => new(pop_cnt(x.c0), pop_cnt(x.c1));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int count_bits(Half4x2 x) => msum(pop_cnt(x));

} // class math

namespace Json
{

public class Half4x2JsonConverter : JsonConverter<Half4x2>
{
    private static readonly Type v_type = typeof(Half4);

    public override Half4x2 Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        Unsafe.SkipInit(out Half4x2 result);
        if (reader.TokenType is not JsonTokenType.StartArray) throw new JsonException();
        var conv = (JsonConverter<Half4>)options.GetConverter(v_type);
        reader.Read();
        result.c0 = conv.Read(ref reader, v_type, options);
        reader.Read();
        result.c1 = conv.Read(ref reader, v_type, options);
        reader.Read();
        if (reader.TokenType is not JsonTokenType.EndArray) throw new JsonException();
        return result;
    }

    public override void Write(Utf8JsonWriter writer, Half4x2 value, JsonSerializerOptions options)
    {
        writer.WriteStartArray();
        var conv = (JsonConverter<Half4>)options.GetConverter(v_type);
        conv.Write(writer, value.c0, options);
        conv.Write(writer, value.c1, options);
        writer.WriteEndArray();
    }
} // class JsonConverter

} // namespace Json

} // namespace CCluster.Mathematics
