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

/// <summary>A 3x2 matrix of uint</summary>
[Serializable]
[JsonConverter(typeof(Uint3x2JsonConverter))]
[StructLayout(LayoutKind.Explicit, Size = 32, Pack = 4)]
public unsafe partial struct uint3x2 :
    IEquatable<uint3x2>, IEqualityOperators<uint3x2, uint3x2, bool>, IEqualityOperators<uint3x2, uint3x2, bool3x2>,

    IAdditionOperators<uint3x2, uint3x2, uint3x2>, IAdditiveIdentity<uint3x2, uint3x2>, IUnaryPlusOperators<uint3x2, uint3x2>,
    ISubtractionOperators<uint3x2, uint3x2, uint3x2>, 
    IMultiplyOperators<uint3x2, uint3x2, uint3x2>, IMultiplicativeIdentity<uint3x2, uint3x2>,
    IDivisionOperators<uint3x2, uint3x2, uint3x2>,
    IModulusOperators<uint3x2, uint3x2, uint3x2>,

    IMatrix3x2<uint>, IMatrixSelf<uint3x2>
{
    //////////////////////////////////////////////////////////////////////////////////////////////////// Fields

    #region Fields

    /// <summary>Column 0 of the matrix</summary>
    [FieldOffset(0)]
    public uint3 c0;

    /// <summary>Column 1 of the matrix</summary>
    [FieldOffset(16)]
    public uint3 c1;


    /// <summary>Row 0 column 0 of the matrix</summary>
    [FieldOffset(0)]
    public uint m00;

    /// <summary>Row 1 column 0 of the matrix</summary>
    [FieldOffset(4)]
    public uint m10;

    /// <summary>Row 2 column 0 of the matrix</summary>
    [FieldOffset(8)]
    public uint m20;

    /// <summary>Row 0 column 1 of the matrix</summary>
    [FieldOffset(16)]
    public uint m01;

    /// <summary>Row 1 column 1 of the matrix</summary>
    [FieldOffset(20)]
    public uint m11;

    /// <summary>Row 2 column 1 of the matrix</summary>
    [FieldOffset(24)]
    public uint m21;

    #endregion

    //////////////////////////////////////////////////////////////////////////////////////////////////// Constants

    #region Constants

    public static readonly uint3x2 zero = new(0u);

    public static readonly uint3x2 one = new(1u);

    static uint3x2 IMatrixSelf<uint3x2>.Zero 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => zero;
    }

    static uint3x2 IMatrixSelf<uint3x2>.One 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => one;
    }


    #endregion

    //////////////////////////////////////////////////////////////////////////////////////////////////// Ctor

    #region Ctor


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public uint3x2(uint3 c0, uint3 c1)
    {
        Unsafe.SkipInit(out this);
        this.c0.vector = c0.vector;
        this.c1.vector = c1.vector;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public uint3x2(uint m00, uint m10, uint m20, uint m01, uint m11, uint m21)
    {
        Unsafe.SkipInit(out this);
        this.c0.vector = Vector128.Create(m00, m10, m20, 0u);
        this.c1.vector = Vector128.Create(m01, m11, m21, 0u);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3x2 RowMajor(uint m00, uint m01, uint m10, uint m11, uint m20, uint m21) 
        => new(m00, m10, m20, m01, m11, m21);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public uint3x2(uint value)
    {
        Unsafe.SkipInit(out this);
        this.c0.vector = Vector128.Create(value);
        this.c1.vector = Vector128.Create(value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public uint3x2(uint3 value)
    {
        Unsafe.SkipInit(out this);
        this.c0.vector = value.vector;
        this.c1.vector = value.vector;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator uint3x2(uint value) => new(value);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator uint3x2(uint3 value) => new(value);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static explicit operator uint(uint3x2 value) => value.m00;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static explicit operator uint3(uint3x2 value) => value.c0;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator long3x2(uint3x2 self) => new(self.c0, self.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator long3x2a(uint3x2 self) => new(self.c0, self.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator ulong3x2(uint3x2 self) => new(self.c0, self.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator ulong3x2a(uint3x2 self) => new(self.c0, self.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator float3x2(uint3x2 self) => new(self.c0, self.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator float3x2a(uint3x2 self) => new(self.c0, self.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator double3x2(uint3x2 self) => new(self.c0, self.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator double3x2a(uint3x2 self) => new(self.c0, self.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator decimal3x2(uint3x2 self) => new(self.c0, self.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator decimal3x2a(uint3x2 self) => new(self.c0, self.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static explicit operator int3x2(uint3x2 self) => new((int3)self.c0, (int3)self.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static explicit operator int3x2a(uint3x2 self) => new((int3a)self.c0, (int3a)self.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static explicit operator Half3x2(uint3x2 self) => new((Half3)self.c0, (Half3)self.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static explicit operator Half3x2a(uint3x2 self) => new((Half3a)self.c0, (Half3a)self.c1);

    #endregion

    //////////////////////////////////////////////////////////////////////////////////////////////////// Equals

    #region Equals

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator ==(uint3x2 left, uint3x2 right) 
        => left.c0 == right.c0 && left.c1 == right.c1;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator !=(uint3x2 left, uint3x2 right) 
        => left.c0 != right.c0 || left.c1 != right.c1;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool Equals(uint3x2 other) 
        => this == other;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override bool Equals(object? o) 
        => o is uint3x2 other && Equals(other);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override int GetHashCode() 
        => HashCode.Combine(this.c0, this.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public int3x2 Hash() 
        => new(this.c0.GetHashCode(), this.c1.GetHashCode());

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    static bool3x2 IEqualityOperators<uint3x2, uint3x2, bool3x2>.operator ==(uint3x2 left, uint3x2 right) 
        => new(left.c0 == right.c0, left.c1 == right.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    static bool3x2 IEqualityOperators<uint3x2, uint3x2, bool3x2>.operator !=(uint3x2 left, uint3x2 right) 
        => new(left.c0 != right.c0, left.c1 != right.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool3x2 VEq(uint3x2 other) 
        => new(this.c0 == other.c0, this.c1 == other.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool3x2 VNe(uint3x2 other) 
        => new(this.c0 != other.c0, this.c1 != other.c1);



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool3x2 operator >(uint3x2 left, uint3x2 right) => new(left.c0 > right.c0, left.c1 > right.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool3x2 operator <(uint3x2 left, uint3x2 right) => new(left.c0 < right.c0, left.c1 < right.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool3x2 operator >=(uint3x2 left, uint3x2 right) => new(left.c0 >= right.c0, left.c1 >= right.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool3x2 operator <=(uint3x2 left, uint3x2 right) => new(left.c0 <= right.c0, left.c1 <= right.c1);





    #endregion


    //////////////////////////////////////////////////////////////////////////////////////////////////// Arithmetic

    #region Arithmetic

    public static uint3x2 AdditiveIdentity 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(0u);
    }

    public static uint3x2 MultiplicativeIdentity 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(1u);
    }


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3x2 operator +(uint3x2 left, uint3x2 right) 
        => new(left.c0 + right.c0, left.c1 + right.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3x2 operator -(uint3x2 left, uint3x2 right) 
        => new(left.c0 - right.c0, left.c1 - right.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3x2 operator *(uint3x2 left, uint3x2 right) 
        => new(left.c0 * right.c0, left.c1 * right.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3x2 operator /(uint3x2 left, uint3x2 right) 
        => new(left.c0 / right.c0, left.c1 / right.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3x2 operator %(uint3x2 left, uint3x2 right) 
        => new(left.c0 % right.c0, left.c1 % right.c1);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3x2 operator +(uint3x2 left, uint3 right) => new(left.c0 + right, left.c1 + right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3x2 operator -(uint3x2 left, uint3 right) => new(left.c0 - right, left.c1 - right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3x2 operator *(uint3x2 left, uint3 right) => new(left.c0 * right, left.c1 * right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3x2 operator /(uint3x2 left, uint3 right) => new(left.c0 / right, left.c1 / right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3x2 operator %(uint3x2 left, uint3 right) => new(left.c0 % right, left.c1 % right);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3x2 operator +(uint3 left, uint3x2 right) => new(left + right.c0, left + right.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3x2 operator -(uint3 left, uint3x2 right) => new(left - right.c0, left - right.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3x2 operator *(uint3 left, uint3x2 right) => new(left * right.c0, left * right.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3x2 operator /(uint3 left, uint3x2 right) => new(left / right.c0, left / right.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3x2 operator %(uint3 left, uint3x2 right) => new(left % right.c0, left % right.c1);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3x2 operator +(uint3x2 left, uint right) => new(left.c0 + right, left.c1 + right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3x2 operator -(uint3x2 left, uint right) => new(left.c0 - right, left.c1 - right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3x2 operator *(uint3x2 left, uint right) => new(left.c0 * right, left.c1 * right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3x2 operator /(uint3x2 left, uint right) => new(left.c0 / right, left.c1 / right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3x2 operator %(uint3x2 left, uint right) => new(left.c0 % right, left.c1 % right);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3x2 operator +(uint left, uint3x2 right) => new(left + right.c0, left + right.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3x2 operator -(uint left, uint3x2 right) => new(left - right.c0, left - right.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3x2 operator *(uint left, uint3x2 right) => new(left * right.c0, left * right.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3x2 operator /(uint left, uint3x2 right) => new(left / right.c0, left / right.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3x2 operator %(uint left, uint3x2 right) => new(left % right.c0, left % right.c1);



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3x2 operator +(uint3x2 self) => new(+self.c0, +self.c1);

    #endregion

    //////////////////////////////////////////////////////////////////////////////////////////////////// ToString

    #region ToString

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override string ToString() => $"uint3x2({this.c0}, {this.c1})";

    #endregion

    //////////////////////////////////////////////////////////////////////////////////////////////////// Methods

    #region Methods



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3x2 transpose(uint3x2 v) => new(
        v.c0.x, v.c0.y, v.c0.z,
        v.c1.x, v.c1.y, v.c1.z
    );

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public readonly uint3x2 transpose() => transpose(this);

    #endregion
}

public static unsafe partial class vectors
{


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3x2 uint3x2(uint3 c0, uint3 c1) => new(c0, c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3x2 uint3x2(uint m00, uint m10, uint m20, uint m01, uint m11, uint m21) 
        => new(m00, m10, m20, m01, m11, m21);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3x2 uint3x2(uint value) => new(value);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3x2 uint3x2(uint3 value) => new(value);


} // vectors

public static unsafe partial class math
{

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint2 mul(uint3 a, uint3x2 b) => new(dot(a, b.c0), dot(a, b.c1));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3 mul(uint3x2 a, uint2 b) => a.c0 * b.x + a.c1 * b.y;


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3x2 mul(uint3x2 a, uint2x2 b) => new(
        a.c0 * b.c0.x + a.c1 * b.c0.y,
        a.c0 * b.c1.x + a.c1 * b.c1.y
    );

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3x3 mul(uint3x2 a, uint2x3 b) => new(
        a.c0 * b.c0.x + a.c1 * b.c0.y,
        a.c0 * b.c1.x + a.c1 * b.c1.y,
        a.c0 * b.c2.x + a.c1 * b.c2.y
    );

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3x4 mul(uint3x2 a, uint2x4 b) => new(
        a.c0 * b.c0.x + a.c1 * b.c0.y,
        a.c0 * b.c1.x + a.c1 * b.c1.y,
        a.c0 * b.c2.x + a.c1 * b.c2.y,
        a.c0 * b.c3.x + a.c1 * b.c3.y
    );


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3x2 min(uint3x2 x, uint3x2 y) => new(min(x.c0, y.c0), min(x.c1, y.c1));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3x2 max(uint3x2 x, uint3x2 y) => new(max(x.c0, y.c0), max(x.c1, y.c1));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3x2 min(uint3x2 x, uint3x2 y, uint3x2 z) => new(min(x.c0, y.c0, z.c0), min(x.c1, y.c1, z.c1));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3x2 max(uint3x2 x, uint3x2 y, uint3x2 z) => new(max(x.c0, y.c0, z.c0), max(x.c1, y.c1, z.c1));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3x2 abs(uint3x2 x) => new(abs(x.c0), abs(x.c1));



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3 csum(uint3x2 x) => x.c0 + x.c1;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3 rsum(uint3x2 x) => new(x.c0.x + x.c1.x, x.c0.y + x.c1.y, x.c0.z + x.c1.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint msum(uint3x2 x) => csum(csum(x));



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int3x2 pop_cnt(uint3x2 x) => new(pop_cnt(x.c0), pop_cnt(x.c1));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int count_bits(uint3x2 x) => msum(pop_cnt(x));

} // class math

namespace Json
{

public class Uint3x2JsonConverter : JsonConverter<uint3x2>
{
    private static readonly Type v_type = typeof(uint3);

    public override uint3x2 Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        Unsafe.SkipInit(out uint3x2 result);
        if (reader.TokenType is not JsonTokenType.StartArray) throw new JsonException();
        var conv = (JsonConverter<uint3>)options.GetConverter(v_type);
        reader.Read();
        result.c0 = conv.Read(ref reader, v_type, options);
        reader.Read();
        result.c1 = conv.Read(ref reader, v_type, options);
        reader.Read();
        if (reader.TokenType is not JsonTokenType.EndArray) throw new JsonException();
        return result;
    }

    public override void Write(Utf8JsonWriter writer, uint3x2 value, JsonSerializerOptions options)
    {
        writer.WriteStartArray();
        var conv = (JsonConverter<uint3>)options.GetConverter(v_type);
        conv.Write(writer, value.c0, options);
        conv.Write(writer, value.c1, options);
        writer.WriteEndArray();
    }
} // class JsonConverter

} // namespace Json

} // namespace CCluster.Mathematics
