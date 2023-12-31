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

/// <summary>A 4 component vector of long</summary>
[Serializable]
[JsonConverter(typeof(Long4JsonConverter))]
[StructLayout(LayoutKind.Explicit, Size = 32, Pack = 8)]
public unsafe partial struct long4 : 
    IEquatable<long4>, IEqualityOperators<long4, long4, bool>, IEqualityOperators<long4, long4, bool4>,

    IAdditionOperators<long4, long4, long4>, IAdditiveIdentity<long4, long4>, IUnaryPlusOperators<long4, long4>,
    ISubtractionOperators<long4, long4, long4>, IUnaryNegationOperators<long4, long4>,
    IMultiplyOperators<long4, long4, long4>, IMultiplicativeIdentity<long4, long4>,
    IDivisionOperators<long4, long4, long4>,
    IModulusOperators<long4, long4, long4>,

    IVector4<long>, IVectorSelf<long4>
{    
    //////////////////////////////////////////////////////////////////////////////////////////////////// Fields

    #region Fields

    /// <summary>Raw simd vector</summary>
    [FieldOffset(0)]
    public Vector256<long> vector;


    /// <summary>X component of the vector</summary>
    [FieldOffset(0)]
    public long x;

    /// <summary>Y component of the vector</summary>
    [FieldOffset(8)]
    public long y;

    /// <summary>Z component of the vector</summary>
    [FieldOffset(16)]
    public long z;

    /// <summary>W component of the vector</summary>
    [FieldOffset(24)]
    public long w;


    /// <summary>R component of the vector</summary>
    [FieldOffset(0)]
    public long r;

    /// <summary>G component of the vector</summary>
    [FieldOffset(8)]
    public long g;

    /// <summary>B component of the vector</summary>
    [FieldOffset(16)]
    public long b;

    /// <summary>A component of the vector</summary>
    [FieldOffset(24)]
    public long a;

    #endregion

    //////////////////////////////////////////////////////////////////////////////////////////////////// Constants

    #region Constants

    public static int ByteSize 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => 32;
    }

    public static int BitSize 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => 256;
    }

    public static readonly long4 zero = new(0L);

    public static readonly long4 one = new(1L);

    static long4 IVectorSelf<long4>.Zero 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => zero;
    }

    static long4 IVectorSelf<long4>.One 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => one;
    }

    #endregion

    //////////////////////////////////////////////////////////////////////////////////////////////////// Ctor

    #region Ctor

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public long4(Vector256<long> vector)
    {
        this.vector = vector;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public long4(long value)
    {
        this.vector = Vector256.Create(value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public long4(long x, long y, long z, long w)
    {
        this.vector = Vector256.Create(x, y, z, w);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public long4(long2 xy, long2 zw) : this(xy.x, xy.y, zw.x, zw.y) { }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public long4(long2 xy, long z, long w) : this(xy.x, xy.y, z, w) { }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public long4(long x, long2 yz, long w) : this(x, yz.x, yz.y, w) { }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public long4(long x, long y, long2 zw) : this(x, y, zw.x, zw.y) { }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public long4(long3 xyz, long w) : this(xyz.x, xyz.y, xyz.z, w) { }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public long4(long x, long3 yzw) : this(x, yzw.x, yzw.y, yzw.z) { }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator long4(long value) => new(value);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static explicit operator long(long4 value) => value.x;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator float4(long4 self) => new(self.x, self.y, self.z, self.w);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator double4(long4 self) => new(self.x, self.y, self.z, self.w);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator decimal4(long4 self) => new(self.x, self.y, self.z, self.w);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static explicit operator uint4(long4 self) => new((uint)self.x, (uint)self.y, (uint)self.z, (uint)self.w);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static explicit operator int4(long4 self) => new((int)self.x, (int)self.y, (int)self.z, (int)self.w);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static explicit operator ulong4(long4 self) => new((ulong)self.x, (ulong)self.y, (ulong)self.z, (ulong)self.w);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static explicit operator Half4(long4 self) => new((Half)self.x, (Half)self.y, (Half)self.z, (Half)self.w);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator long4(Vector256<long> vector) => new(vector);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator Vector256<long>(long4 self) => self.vector;

    #endregion

    //////////////////////////////////////////////////////////////////////////////////////////////////// Equals

    #region Equals


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool Equals(long4 other)
    {
        return (this.vector).Equals((other.vector));
    }


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override bool Equals(object? o) => o is long4 other && Equals(other);



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator ==(long4 left, long4 right)
    {
        return (left.vector).Equals((right.vector));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator !=(long4 left, long4 right)
    {
        return !(left.vector).Equals((right.vector));
    }



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override int GetHashCode() => HashCode.Combine(this.x, this.y, this.z, this.w);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public int4 Hash() => new(this.x.GetHashCode(), this.y.GetHashCode(), this.z.GetHashCode(), this.w.GetHashCode());

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    static bool4 IEqualityOperators<long4, long4, bool4>.operator ==(long4 left, long4 right) => new(left.x == right.x, left.y == right.y, left.z == right.z, left.w == right.w);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    static bool4 IEqualityOperators<long4, long4, bool4>.operator !=(long4 left, long4 right) => new(left.x != right.x, left.y != right.y, left.z != right.z, left.w != right.w);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool4 VEq(long4 other) => new(this.x == other.x, this.y == other.y, this.z == other.z, this.w == other.w);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool4 VNe(long4 other) => new(this.x != other.x, this.y != other.y, this.z != other.z, this.w != other.w);

    #endregion



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool4 operator >(long4 left, long4 right) => new(left.x > right.x, left.y > right.y, left.z > right.z, left.w > right.w);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool4 operator <(long4 left, long4 right) => new(left.x < right.x, left.y < right.y, left.z < right.z, left.w < right.w);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool4 operator >=(long4 left, long4 right) => new(left.x >= right.x, left.y >= right.y, left.z >= right.z, left.w >= right.w);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool4 operator <=(long4 left, long4 right) => new(left.x <= right.x, left.y <= right.y, left.z <= right.z, left.w <= right.w);




    //////////////////////////////////////////////////////////////////////////////////////////////////// Arithmetic

    #region Arithmetic

    public static long4 AdditiveIdentity 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(0L);
    }

    public static long4 MultiplicativeIdentity 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(1L);
    }



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long4 operator +(long4 left, long4 right) => new(left.vector + right.vector);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long4 operator -(long4 left, long4 right) => new(left.vector - right.vector);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long4 operator *(long4 left, long4 right) => new(left.vector * right.vector);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long4 operator /(long4 left, long4 right) => new(left.vector / right.vector);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long4 operator %(long4 left, long4 right) => new(left.x % right.x, left.y % right.y, left.z % right.z, left.w % right.w);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long4 operator +(long4 left, long right) => left + new long4(right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long4 operator -(long4 left, long right) => left - new long4(right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long4 operator *(long4 left, long right) => left * new long4(right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long4 operator /(long4 left, long right) => left / new long4(right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long4 operator %(long4 left, long right) => left % new long4(right);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long4 operator +(long left, long4 right) => new long4(left) + right;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long4 operator -(long left, long4 right) => new long4(left) - right;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long4 operator *(long left, long4 right) => new long4(left) * right;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long4 operator /(long left, long4 right) => new long4(left) / right;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long4 operator %(long left, long4 right) => new long4(left) % right;


    
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long4 operator -(long4 self) => new(-self.x, -self.y, -self.z, -self.w);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long4 operator +(long4 self) => new(+self.x, +self.y, +self.z, +self.w);



    #endregion


    //////////////////////////////////////////////////////////////////////////////////////////////////// BitOpers

    #region BitOpers


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long4 operator &(long4 left, long4 right) => new(left.vector & right.vector);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long4 operator |(long4 left, long4 right) => new(left.vector | right.vector);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long4 operator ^(long4 left, long4 right) => new(left.vector ^ right.vector);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long4 operator ~(long4 self) => new(~self.vector);




    #endregion

    //////////////////////////////////////////////////////////////////////////////////////////////////// ToString

    #region ToString

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override string ToString() => $"long4({this.x}, {this.y}, {this.z}, {this.w})";

    #endregion
}

public static unsafe partial class vectors
{


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long4 long4(Vector256<long> vector) => new(vector);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long4 long4(long value) => new(value);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long4 long4(long x, long y, long z, long w) => new(x, y, z, w);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long4 long4(long2 xy, long2 zw) => new(xy, zw);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long4 long4(long2 xy, long z, long w) => new(xy, z, w);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long4 long4(long x, long2 yz, long w) => new(x, yz, w);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long4 long4(long x, long y, long2 zw) => new(x, y, zw);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long4 long4(long3 xyz, long w) => new(xyz, w);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long4 long4(long x, long3 yzw) => new(x, yzw);



    /// <summary>transmute long4 memory to double4 memory</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double4 as_double(this long4 val) => new(val.vector.As<long, double>());

    /// <summary>transmute long4 memory to double4 memory</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double4 asdouble(long4 val) => as_double(val);

    /// <summary>transmute long4 memory to ulong4 memory</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static ulong4 as_ulong(this long4 val) => new(val.vector.As<long, ulong>());

    /// <summary>transmute long4 memory to ulong4 memory</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static ulong4 asulong(long4 val) => as_ulong(val);


} // vectors

public static unsafe partial class math
{




    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long4 min(long4 x, long4 y) => new(Vector256.Min(x.vector, y.vector));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long4 max(long4 x, long4 y) => new(Vector256.Max(x.vector, y.vector));


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long4 min(long4 x, long4 y, long4 z) => min(min(x, y), z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long4 max(long4 x, long4 y, long4 z) => max(max(x, y), z);




    


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long4 mad(long4 a, long4 b, long4 c)
    {
        
        
        
        return a * b + c;
    }


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long4 clamp(long4 x, long4 a, long4 b) => max(a, min(b, x));






    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long4 abs(long4 x) => new(Vector256.Abs(x.vector));








    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long dot(long4 x, long4 y)
    {
        
        return Vector256.Dot(x.vector, y.vector);
    }


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long mul(long4 a, long4 b) => dot(a, b);









    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long4 sign(long4 x) => new(sign(x.x), sign(x.y), sign(x.z), sign(x.w));







    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long4 lengthsq(long4 x) => dot(x, x);







    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long4 distancesq(long4 x, long4 y) => lengthsq(y - x);

    
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long4 select(long4 a, long4 b, bool c) => c ? b : a;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long4 select(long4 a, long4 b, bool4 c) => new(c.x ? b.x : a.x, c.y ? b.y : a.y, c.z ? b.z : a.z, c.w ? b.w : a.w);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long4 step(long4 y, long4 x) => select(new long4(0L), new long4(1L), x >= y);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long4 reflect(long4 i, long4 n) => i - 2L * n * dot(i, n);




    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long4 project(long4 a, long4 b) => (dot(a, b) / dot(b, b)) * b;

    // todo projectsafe




    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long4 faceforward(long4 n, long4 i, long4 ng) => select(n, -n, dot(ng, i) >= 0L);






    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long csum(long4 x) => Vector256.Sum(x.vector);




    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int4 pop_cnt(long4 x)
    {
        return new(pop_cnt(x.x), pop_cnt(x.y), pop_cnt(x.z), pop_cnt(x.w));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int count_bits(long4 x)
    {

        return csum(pop_cnt(x));
    }

} // class math

namespace Json
{

public class Long4JsonConverter : JsonConverter<long4>
{
    public override long4 Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        Unsafe.SkipInit(out long4 result);
        if (reader.TokenType is not JsonTokenType.StartArray) throw new JsonException();
        reader.Read();
        result.x = reader.GetInt64();
        reader.Read();
        result.y = reader.GetInt64();
        reader.Read();
        result.z = reader.GetInt64();
        reader.Read();
        result.w = reader.GetInt64();
        reader.Read();
        if (reader.TokenType is not JsonTokenType.EndArray) throw new JsonException();
        return result;
    }

    public override void Write(Utf8JsonWriter writer, long4 value, JsonSerializerOptions options)
    {
        writer.WriteStartArray();
        writer.WriteNumberValue(value.x);
        writer.WriteNumberValue(value.y);
        writer.WriteNumberValue(value.z);
        writer.WriteNumberValue(value.w);
        writer.WriteEndArray();
    }
} // class JsonConverter

} // namespace Json

} // namespace CCluster.Mathematics
