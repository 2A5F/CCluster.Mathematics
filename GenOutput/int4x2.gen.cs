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

/// <summary>A 4x2 matrix of int</summary>
[Serializable]
[JsonConverter(typeof(Int4x2JsonConverter))]
[StructLayout(LayoutKind.Explicit, Size = 32, Pack = 4)]
public unsafe partial struct int4x2 :
    IEquatable<int4x2>, IEqualityOperators<int4x2, int4x2, bool>, IEqualityOperators<int4x2, int4x2, bool4x2>,

    IAdditionOperators<int4x2, int4x2, int4x2>, IAdditiveIdentity<int4x2, int4x2>, IUnaryPlusOperators<int4x2, int4x2>,
    ISubtractionOperators<int4x2, int4x2, int4x2>, IUnaryNegationOperators<int4x2, int4x2>,
    IMultiplyOperators<int4x2, int4x2, int4x2>, IMultiplicativeIdentity<int4x2, int4x2>,
    IDivisionOperators<int4x2, int4x2, int4x2>,
    IModulusOperators<int4x2, int4x2, int4x2>,

    IMatrix4x2<int>, IMatrixSelf<int4x2>
{
    //////////////////////////////////////////////////////////////////////////////////////////////////// Fields

    #region Fields

    /// <summary>Column 0 of the matrix</summary>
    [FieldOffset(0)]
    public int4 c0;

    /// <summary>Column 1 of the matrix</summary>
    [FieldOffset(16)]
    public int4 c1;


    /// <summary>Row 0 column 0 of the matrix</summary>
    [FieldOffset(0)]
    public int m00;

    /// <summary>Row 1 column 0 of the matrix</summary>
    [FieldOffset(4)]
    public int m10;

    /// <summary>Row 2 column 0 of the matrix</summary>
    [FieldOffset(8)]
    public int m20;

    /// <summary>Row 3 column 0 of the matrix</summary>
    [FieldOffset(12)]
    public int m30;

    /// <summary>Row 0 column 1 of the matrix</summary>
    [FieldOffset(16)]
    public int m01;

    /// <summary>Row 1 column 1 of the matrix</summary>
    [FieldOffset(20)]
    public int m11;

    /// <summary>Row 2 column 1 of the matrix</summary>
    [FieldOffset(24)]
    public int m21;

    /// <summary>Row 3 column 1 of the matrix</summary>
    [FieldOffset(28)]
    public int m31;

    #endregion

    //////////////////////////////////////////////////////////////////////////////////////////////////// Constants

    #region Constants

    public static readonly int4x2 zero = new(0);

    public static readonly int4x2 one = new(1);

    static int4x2 IMatrixSelf<int4x2>.Zero 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => zero;
    }

    static int4x2 IMatrixSelf<int4x2>.One 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => one;
    }


    #endregion

    //////////////////////////////////////////////////////////////////////////////////////////////////// Ctor

    #region Ctor


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public int4x2(int4 c0, int4 c1)
    {
        Unsafe.SkipInit(out this);
        this.c0.vector = c0.vector;
        this.c1.vector = c1.vector;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public int4x2(int m00, int m10, int m20, int m30, int m01, int m11, int m21, int m31)
    {
        Unsafe.SkipInit(out this);
        this.c0.vector = Vector128.Create(m00, m10, m20, m30);
        this.c1.vector = Vector128.Create(m01, m11, m21, m31);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int4x2 RowMajor(int m00, int m01, int m10, int m11, int m20, int m21, int m30, int m31) 
        => new(m00, m10, m20, m30, m01, m11, m21, m31);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public int4x2(int value)
    {
        Unsafe.SkipInit(out this);
        this.c0.vector = Vector128.Create(value);
        this.c1.vector = Vector128.Create(value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public int4x2(int4 value)
    {
        Unsafe.SkipInit(out this);
        this.c0.vector = value.vector;
        this.c1.vector = value.vector;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator int4x2(int value) => new(value);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator int4x2(int4 value) => new(value);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static explicit operator int(int4x2 value) => value.m00;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static explicit operator int4(int4x2 value) => value.c0;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator long4x2(int4x2 self) => new(self.c0, self.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator float4x2(int4x2 self) => new(self.c0, self.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator double4x2(int4x2 self) => new(self.c0, self.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator decimal4x2(int4x2 self) => new(self.c0, self.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static explicit operator uint4x2(int4x2 self) => new((uint4)self.c0, (uint4)self.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static explicit operator ulong4x2(int4x2 self) => new((ulong4)self.c0, (ulong4)self.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static explicit operator Half4x2(int4x2 self) => new((Half4)self.c0, (Half4)self.c1);

    #endregion

    //////////////////////////////////////////////////////////////////////////////////////////////////// Equals

    #region Equals

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator ==(int4x2 left, int4x2 right) 
        => left.c0 == right.c0 && left.c1 == right.c1;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator !=(int4x2 left, int4x2 right) 
        => left.c0 != right.c0 || left.c1 != right.c1;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool Equals(int4x2 other) 
        => this == other;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override bool Equals(object? o) 
        => o is int4x2 other && Equals(other);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override int GetHashCode() 
        => HashCode.Combine(this.c0, this.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public int4x2 Hash() 
        => new(this.c0.GetHashCode(), this.c1.GetHashCode());

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    static bool4x2 IEqualityOperators<int4x2, int4x2, bool4x2>.operator ==(int4x2 left, int4x2 right) 
        => new(left.c0 == right.c0, left.c1 == right.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    static bool4x2 IEqualityOperators<int4x2, int4x2, bool4x2>.operator !=(int4x2 left, int4x2 right) 
        => new(left.c0 != right.c0, left.c1 != right.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool4x2 VEq(int4x2 other) 
        => new(this.c0 == other.c0, this.c1 == other.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool4x2 VNe(int4x2 other) 
        => new(this.c0 != other.c0, this.c1 != other.c1);



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool4x2 operator >(int4x2 left, int4x2 right) => new(left.c0 > right.c0, left.c1 > right.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool4x2 operator <(int4x2 left, int4x2 right) => new(left.c0 < right.c0, left.c1 < right.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool4x2 operator >=(int4x2 left, int4x2 right) => new(left.c0 >= right.c0, left.c1 >= right.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool4x2 operator <=(int4x2 left, int4x2 right) => new(left.c0 <= right.c0, left.c1 <= right.c1);





    #endregion


    //////////////////////////////////////////////////////////////////////////////////////////////////// Arithmetic

    #region Arithmetic

    public static int4x2 AdditiveIdentity 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(0);
    }

    public static int4x2 MultiplicativeIdentity 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(1);
    }


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int4x2 operator +(int4x2 left, int4x2 right) 
        => new(left.c0 + right.c0, left.c1 + right.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int4x2 operator -(int4x2 left, int4x2 right) 
        => new(left.c0 - right.c0, left.c1 - right.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int4x2 operator *(int4x2 left, int4x2 right) 
        => new(left.c0 * right.c0, left.c1 * right.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int4x2 operator /(int4x2 left, int4x2 right) 
        => new(left.c0 / right.c0, left.c1 / right.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int4x2 operator %(int4x2 left, int4x2 right) 
        => new(left.c0 % right.c0, left.c1 % right.c1);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int4x2 operator +(int4x2 left, int4 right) => new(left.c0 + right, left.c1 + right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int4x2 operator -(int4x2 left, int4 right) => new(left.c0 - right, left.c1 - right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int4x2 operator *(int4x2 left, int4 right) => new(left.c0 * right, left.c1 * right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int4x2 operator /(int4x2 left, int4 right) => new(left.c0 / right, left.c1 / right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int4x2 operator %(int4x2 left, int4 right) => new(left.c0 % right, left.c1 % right);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int4x2 operator +(int4 left, int4x2 right) => new(left + right.c0, left + right.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int4x2 operator -(int4 left, int4x2 right) => new(left - right.c0, left - right.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int4x2 operator *(int4 left, int4x2 right) => new(left * right.c0, left * right.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int4x2 operator /(int4 left, int4x2 right) => new(left / right.c0, left / right.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int4x2 operator %(int4 left, int4x2 right) => new(left % right.c0, left % right.c1);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int4x2 operator +(int4x2 left, int right) => new(left.c0 + right, left.c1 + right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int4x2 operator -(int4x2 left, int right) => new(left.c0 - right, left.c1 - right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int4x2 operator *(int4x2 left, int right) => new(left.c0 * right, left.c1 * right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int4x2 operator /(int4x2 left, int right) => new(left.c0 / right, left.c1 / right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int4x2 operator %(int4x2 left, int right) => new(left.c0 % right, left.c1 % right);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int4x2 operator +(int left, int4x2 right) => new(left + right.c0, left + right.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int4x2 operator -(int left, int4x2 right) => new(left - right.c0, left - right.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int4x2 operator *(int left, int4x2 right) => new(left * right.c0, left * right.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int4x2 operator /(int left, int4x2 right) => new(left / right.c0, left / right.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int4x2 operator %(int left, int4x2 right) => new(left % right.c0, left % right.c1);

    
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int4x2 operator -(int4x2 self) => new(-self.c0, -self.c1);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int4x2 operator +(int4x2 self) => new(+self.c0, +self.c1);

    #endregion

    //////////////////////////////////////////////////////////////////////////////////////////////////// ToString

    #region ToString

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override string ToString() => $"int4x2({this.c0}, {this.c1})";

    #endregion

    //////////////////////////////////////////////////////////////////////////////////////////////////// Methods

    #region Methods



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int4x2 transpose(int4x2 v) => new(
        v.c0.x, v.c0.y, v.c0.z, v.c0.w,
        v.c1.x, v.c1.y, v.c1.z, v.c1.w
    );

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public readonly int4x2 transpose() => transpose(this);

    #endregion
}

public static unsafe partial class vectors
{


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int4x2 int4x2(int4 c0, int4 c1) => new(c0, c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int4x2 int4x2(int m00, int m10, int m20, int m30, int m01, int m11, int m21, int m31) 
        => new(m00, m10, m20, m30, m01, m11, m21, m31);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int4x2 int4x2(int value) => new(value);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int4x2 int4x2(int4 value) => new(value);


} // vectors

public static unsafe partial class math
{

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int2 mul(int4 a, int4x2 b) => new(dot(a, b.c0), dot(a, b.c1));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int4 mul(int4x2 a, int2 b) => a.c0 * b.x + a.c1 * b.y;


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int4x2 mul(int4x2 a, int2x2 b) => new(
        a.c0 * b.c0.x + a.c1 * b.c0.y,
        a.c0 * b.c1.x + a.c1 * b.c1.y
    );

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int4x3 mul(int4x2 a, int2x3 b) => new(
        a.c0 * b.c0.x + a.c1 * b.c0.y,
        a.c0 * b.c1.x + a.c1 * b.c1.y,
        a.c0 * b.c2.x + a.c1 * b.c2.y
    );

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int4x4 mul(int4x2 a, int2x4 b) => new(
        a.c0 * b.c0.x + a.c1 * b.c0.y,
        a.c0 * b.c1.x + a.c1 * b.c1.y,
        a.c0 * b.c2.x + a.c1 * b.c2.y,
        a.c0 * b.c3.x + a.c1 * b.c3.y
    );


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int4x2 min(int4x2 x, int4x2 y) => new(min(x.c0, y.c0), min(x.c1, y.c1));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int4x2 max(int4x2 x, int4x2 y) => new(max(x.c0, y.c0), max(x.c1, y.c1));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int4x2 min(int4x2 x, int4x2 y, int4x2 z) => new(min(x.c0, y.c0, z.c0), min(x.c1, y.c1, z.c1));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int4x2 max(int4x2 x, int4x2 y, int4x2 z) => new(max(x.c0, y.c0, z.c0), max(x.c1, y.c1, z.c1));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int4x2 abs(int4x2 x) => new(abs(x.c0), abs(x.c1));



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int4 csum(int4x2 x) => x.c0 + x.c1;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int4 rsum(int4x2 x) => new(x.c0.x + x.c1.x, x.c0.y + x.c1.y, x.c0.z + x.c1.z, x.c0.w + x.c1.w);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int msum(int4x2 x) => csum(csum(x));



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int4x2 pop_cnt(int4x2 x) => new(pop_cnt(x.c0), pop_cnt(x.c1));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int count_bits(int4x2 x) => msum(pop_cnt(x));

} // class math

namespace Json
{

public class Int4x2JsonConverter : JsonConverter<int4x2>
{
    private static readonly Type v_type = typeof(int4);

    public override int4x2 Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        Unsafe.SkipInit(out int4x2 result);
        if (reader.TokenType is not JsonTokenType.StartArray) throw new JsonException();
        var conv = (JsonConverter<int4>)options.GetConverter(v_type);
        reader.Read();
        result.c0 = conv.Read(ref reader, v_type, options);
        reader.Read();
        result.c1 = conv.Read(ref reader, v_type, options);
        reader.Read();
        if (reader.TokenType is not JsonTokenType.EndArray) throw new JsonException();
        return result;
    }

    public override void Write(Utf8JsonWriter writer, int4x2 value, JsonSerializerOptions options)
    {
        writer.WriteStartArray();
        var conv = (JsonConverter<int4>)options.GetConverter(v_type);
        conv.Write(writer, value.c0, options);
        conv.Write(writer, value.c1, options);
        writer.WriteEndArray();
    }
} // class JsonConverter

} // namespace Json

} // namespace CCluster.Mathematics
