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

#nullable enable
#pragma warning disable CS8981

namespace CCluster.Mathematics;

/// <summary>A 4 component vector of long</summary>
[Serializable]
[JsonConverter(typeof(Long4JsonConverter))]
[StructLayout(LayoutKind.Explicit, Size = 32)]
public unsafe partial struct long4 : 
    IEquatable<long4>, IEqualityOperators<long4, long4, bool>, IEqualityOperators<long4, long4, bool4>,

    IAdditionOperators<long4, long4, long4>, IAdditiveIdentity<long4, long4>, IUnaryPlusOperators<long4, long4>,
    ISubtractionOperators<long4, long4, long4>, IUnaryNegationOperators<long4, long4>,
    IMultiplyOperators<long4, long4, long4>, IMultiplicativeIdentity<long4, long4>,
    IDivisionOperators<long4, long4, long4>,
    IModulusOperators<long4, long4, long4>,

    IVector4<long>, IVectorSelf<long4>
{

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
    public static implicit operator long4(long value) => new(value);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool Equals(long4 other)
    {
        return this.vector.Equals(other.vector);
    }


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override bool Equals(object? o) => o is long4 other && Equals(other);



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator ==(long4 left, long4 right)
    {
        return left.vector.Equals(right.vector);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator !=(long4 left, long4 right)
    {
        return !left.vector.Equals(right.vector);
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



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool4 operator >(long4 left, long4 right) => new(left.x > right.x, left.y > right.y, left.z > right.z, left.w > right.w);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool4 operator <(long4 left, long4 right) => new(left.x < right.x, left.y < right.y, left.z < right.z, left.w < right.w);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool4 operator >=(long4 left, long4 right) => new(left.x >= right.x, left.y >= right.y, left.z >= right.z, left.w >= right.w);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool4 operator <=(long4 left, long4 right) => new(left.x <= right.x, left.y <= right.y, left.z <= right.z, left.w <= right.w);




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
    public static long4 operator +(long4 left, long4 right)
    {
        return new(left.vector + right.vector);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long4 operator -(long4 left, long4 right)
    {
        return new(left.vector - right.vector);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long4 operator *(long4 left, long4 right)
    {
        return new(left.vector * right.vector);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long4 operator /(long4 left, long4 right)
    {
        return new(left.vector / right.vector);
    }

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





    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override string ToString() => $"long4({this.x}, {this.y}, {this.z}, {this.w})";

}

public static unsafe partial class math
{



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long4 min(long4 x, long4 y) => new(min(x.x, y.x), min(x.y, y.y), min(x.z, y.z), min(x.w, y.w));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long4 max(long4 x, long4 y) => new(max(x.x, y.x), max(x.y, y.y), max(x.z, y.z), max(x.w, y.w));



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long4 mad(long4 a, long4 b, long4 c) => a * b + c;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long4 clamp(long4 x, long4 a, long4 b) => max(a, min(b, x));





    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long4 abs(long4 x) => new(abs(x.x), abs(x.y), abs(x.z), abs(x.w));







    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long dot(long4 x, long4 y) => Vector256.Dot(x.vector, y.vector);










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







}

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
}
