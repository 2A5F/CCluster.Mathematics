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

/// <summary>A 3 component vector of long</summary>
[Serializable]
[JsonConverter(typeof(Long3JsonConverter))]
[StructLayout(LayoutKind.Explicit, Size = 32, Pack = 8)]
public unsafe partial struct long3 : 
    IEquatable<long3>, IEqualityOperators<long3, long3, bool>, IEqualityOperators<long3, long3, bool3>,

    IAdditionOperators<long3, long3, long3>, IAdditiveIdentity<long3, long3>, IUnaryPlusOperators<long3, long3>,
    ISubtractionOperators<long3, long3, long3>, IUnaryNegationOperators<long3, long3>,
    IMultiplyOperators<long3, long3, long3>, IMultiplicativeIdentity<long3, long3>,
    IDivisionOperators<long3, long3, long3>,
    IModulusOperators<long3, long3, long3>,

    IVector3<long>, IVectorSelf<long3>
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


    /// <summary>R component of the vector</summary>
    [FieldOffset(0)]
    public long r;

    /// <summary>G component of the vector</summary>
    [FieldOffset(8)]
    public long g;

    /// <summary>B component of the vector</summary>
    [FieldOffset(16)]
    public long b;

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

    public static readonly long3 zero = new(0L);

    public static readonly long3 one = new(1L);

    static long3 IVectorSelf<long3>.Zero 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => zero;
    }

    static long3 IVectorSelf<long3>.One 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => one;
    }

    #endregion

    //////////////////////////////////////////////////////////////////////////////////////////////////// Ctor

    #region Ctor

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public long3(Vector256<long> vector)
    {
        this.vector = vector;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public long3(long value)
    {
        this.vector = Vector256.Create(value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public long3(long x, long y, long z)
    {
        this.vector = Vector256.Create(x, y, z, 0L);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public long3(long2 xy, long z) : this(xy.x, xy.y, z) { }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public long3(long x, long2 yz) : this(x, yz.x, yz.y) { }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator long3(long value) => new(value);

    #endregion

    //////////////////////////////////////////////////////////////////////////////////////////////////// Equals

    #region Equals


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool Equals(long3 other)
    {
        return this.vector.Equals(other.vector);
    }


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override bool Equals(object? o) => o is long3 other && Equals(other);



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator ==(long3 left, long3 right)
    {
        return left.vector.Equals(right.vector);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator !=(long3 left, long3 right)
    {
        return !left.vector.Equals(right.vector);
    }



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override int GetHashCode() => HashCode.Combine(this.x, this.y, this.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public int3 Hash() => new(this.x.GetHashCode(), this.y.GetHashCode(), this.z.GetHashCode());

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    static bool3 IEqualityOperators<long3, long3, bool3>.operator ==(long3 left, long3 right) => new(left.x == right.x, left.y == right.y, left.z == right.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    static bool3 IEqualityOperators<long3, long3, bool3>.operator !=(long3 left, long3 right) => new(left.x != right.x, left.y != right.y, left.z != right.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool3 VEq(long3 other) => new(this.x == other.x, this.y == other.y, this.z == other.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool3 VNe(long3 other) => new(this.x != other.x, this.y != other.y, this.z != other.z);

    #endregion



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool3 operator >(long3 left, long3 right) => new(left.x > right.x, left.y > right.y, left.z > right.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool3 operator <(long3 left, long3 right) => new(left.x < right.x, left.y < right.y, left.z < right.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool3 operator >=(long3 left, long3 right) => new(left.x >= right.x, left.y >= right.y, left.z >= right.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool3 operator <=(long3 left, long3 right) => new(left.x <= right.x, left.y <= right.y, left.z <= right.z);




    //////////////////////////////////////////////////////////////////////////////////////////////////// Arithmetic

    #region Arithmetic

    public static long3 AdditiveIdentity 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(0L);
    }

    public static long3 MultiplicativeIdentity 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(1L);
    }



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long3 operator +(long3 left, long3 right)
    {
        return new(left.vector + right.vector);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long3 operator -(long3 left, long3 right)
    {
        return new(left.vector - right.vector);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long3 operator *(long3 left, long3 right)
    {
        return new(left.vector * right.vector);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long3 operator /(long3 left, long3 right)
    {
        return new(left.vector / right.vector);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long3 operator %(long3 left, long3 right) => new(left.x % right.x, left.y % right.y, left.z % right.z);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long3 operator +(long3 left, long right) => left + new long3(right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long3 operator -(long3 left, long right) => left - new long3(right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long3 operator *(long3 left, long right) => left * new long3(right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long3 operator /(long3 left, long right) => left / new long3(right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long3 operator %(long3 left, long right) => left % new long3(right);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long3 operator +(long left, long3 right) => new long3(left) + right;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long3 operator -(long left, long3 right) => new long3(left) - right;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long3 operator *(long left, long3 right) => new long3(left) * right;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long3 operator /(long left, long3 right) => new long3(left) / right;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long3 operator %(long left, long3 right) => new long3(left) % right;


    
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long3 operator -(long3 self) => new(-self.x, -self.y, -self.z);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long3 operator +(long3 self) => new(+self.x, +self.y, +self.z);



    #endregion


    //////////////////////////////////////////////////////////////////////////////////////////////////// ToString

    #region ToString

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override string ToString() => $"long3({this.x}, {this.y}, {this.z})";

    #endregion
}

public static unsafe partial class math
{



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long3 min(long3 x, long3 y) => new(min(x.x, y.x), min(x.y, y.y), min(x.z, y.z));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long3 max(long3 x, long3 y) => new(max(x.x, y.x), max(x.y, y.y), max(x.z, y.z));



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long3 mad(long3 a, long3 b, long3 c) => a * b + c;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long3 clamp(long3 x, long3 a, long3 b) => max(a, min(b, x));





    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long3 abs(long3 x) => new(abs(x.x), abs(x.y), abs(x.z));




    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long3 cross(long3 x, long3 y) => (x * y.yzx - x.yzx * y).yzx;




    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long dot(long3 x, long3 y) => Vector256.Dot(x.vector, y.vector);










    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long3 sign(long3 x) => new(sign(x.x), sign(x.y), sign(x.z));







    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long3 lengthsq(long3 x) => dot(x, x);







    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long3 distancesq(long3 x, long3 y) => lengthsq(y - x);

    
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long3 select(long3 a, long3 b, bool c) => c ? b : a;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long3 select(long3 a, long3 b, bool3 c) => new(c.x ? b.x : a.x, c.y ? b.y : a.y, c.z ? b.z : a.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long3 step(long3 y, long3 x) => select(new long3(0L), new long3(1L), x >= y);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long3 reflect(long3 i, long3 n) => i - 2L * n * dot(i, n);




    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long3 project(long3 a, long3 b) => (dot(a, b) / dot(b, b)) * b;

    // todo projectsafe




    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long3 faceforward(long3 n, long3 i, long3 ng) => select(n, -n, dot(ng, i) >= 0L);







}

public class Long3JsonConverter : JsonConverter<long3>
{
    public override long3 Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        Unsafe.SkipInit(out long3 result);
        if (reader.TokenType is not JsonTokenType.StartArray) throw new JsonException();
        reader.Read();
        result.x = reader.GetInt64();
        reader.Read();
        result.y = reader.GetInt64();
        reader.Read();
        result.z = reader.GetInt64();
        reader.Read();
        if (reader.TokenType is not JsonTokenType.EndArray) throw new JsonException();
        return result;
    }

    public override void Write(Utf8JsonWriter writer, long3 value, JsonSerializerOptions options)
    {
        writer.WriteStartArray();
        writer.WriteNumberValue(value.x);
        writer.WriteNumberValue(value.y);
        writer.WriteNumberValue(value.z);
        writer.WriteEndArray();
    }
}
