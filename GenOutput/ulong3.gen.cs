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

/// <summary>A 3 component vector of ulong</summary>
[Serializable]
[JsonConverter(typeof(Ulong3JsonConverter))]
[StructLayout(LayoutKind.Explicit, Size = 32, Pack = 8)]
public unsafe partial struct ulong3 : 
    IEquatable<ulong3>, IEqualityOperators<ulong3, ulong3, bool>, IEqualityOperators<ulong3, ulong3, bool3>,

    IAdditionOperators<ulong3, ulong3, ulong3>, IAdditiveIdentity<ulong3, ulong3>, IUnaryPlusOperators<ulong3, ulong3>,
    ISubtractionOperators<ulong3, ulong3, ulong3>, 
    IMultiplyOperators<ulong3, ulong3, ulong3>, IMultiplicativeIdentity<ulong3, ulong3>,
    IDivisionOperators<ulong3, ulong3, ulong3>,
    IModulusOperators<ulong3, ulong3, ulong3>,

    IVector3<ulong>, IVectorSelf<ulong3>
{    
    //////////////////////////////////////////////////////////////////////////////////////////////////// Fields

    #region Fields

    /// <summary>Raw simd vector</summary>
    [FieldOffset(0)]
    public Vector256<ulong> vector;


    /// <summary>X component of the vector</summary>
    [FieldOffset(0)]
    public ulong x;

    /// <summary>Y component of the vector</summary>
    [FieldOffset(8)]
    public ulong y;

    /// <summary>Z component of the vector</summary>
    [FieldOffset(16)]
    public ulong z;


    /// <summary>R component of the vector</summary>
    [FieldOffset(0)]
    public ulong r;

    /// <summary>G component of the vector</summary>
    [FieldOffset(8)]
    public ulong g;

    /// <summary>B component of the vector</summary>
    [FieldOffset(16)]
    public ulong b;

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

    public static readonly ulong3 zero = new(0UL);

    public static readonly ulong3 one = new(1UL);

    static ulong3 IVectorSelf<ulong3>.Zero 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => zero;
    }

    static ulong3 IVectorSelf<ulong3>.One 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => one;
    }

    #endregion

    //////////////////////////////////////////////////////////////////////////////////////////////////// Ctor

    #region Ctor

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public ulong3(Vector256<ulong> vector)
    {
        this.vector = vector;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public ulong3(ulong value)
    {
        this.vector = Vector256.Create(value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public ulong3(ulong x, ulong y, ulong z)
    {
        this.vector = Vector256.Create(x, y, z, 0UL);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public ulong3(ulong2 xy, ulong z) : this(xy.x, xy.y, z) { }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public ulong3(ulong x, ulong2 yz) : this(x, yz.x, yz.y) { }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator ulong3(ulong value) => new(value);

    #endregion

    //////////////////////////////////////////////////////////////////////////////////////////////////// Equals

    #region Equals


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool Equals(ulong3 other)
    {
        return this.vector.Equals(other.vector);
    }


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override bool Equals(object? o) => o is ulong3 other && Equals(other);



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator ==(ulong3 left, ulong3 right)
    {
        return left.vector.Equals(right.vector);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator !=(ulong3 left, ulong3 right)
    {
        return !left.vector.Equals(right.vector);
    }



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override int GetHashCode() => HashCode.Combine(this.x, this.y, this.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public int3 Hash() => new(this.x.GetHashCode(), this.y.GetHashCode(), this.z.GetHashCode());

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    static bool3 IEqualityOperators<ulong3, ulong3, bool3>.operator ==(ulong3 left, ulong3 right) => new(left.x == right.x, left.y == right.y, left.z == right.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    static bool3 IEqualityOperators<ulong3, ulong3, bool3>.operator !=(ulong3 left, ulong3 right) => new(left.x != right.x, left.y != right.y, left.z != right.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool3 VEq(ulong3 other) => new(this.x == other.x, this.y == other.y, this.z == other.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool3 VNe(ulong3 other) => new(this.x != other.x, this.y != other.y, this.z != other.z);

    #endregion



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool3 operator >(ulong3 left, ulong3 right) => new(left.x > right.x, left.y > right.y, left.z > right.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool3 operator <(ulong3 left, ulong3 right) => new(left.x < right.x, left.y < right.y, left.z < right.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool3 operator >=(ulong3 left, ulong3 right) => new(left.x >= right.x, left.y >= right.y, left.z >= right.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool3 operator <=(ulong3 left, ulong3 right) => new(left.x <= right.x, left.y <= right.y, left.z <= right.z);




    //////////////////////////////////////////////////////////////////////////////////////////////////// Arithmetic

    #region Arithmetic

    public static ulong3 AdditiveIdentity 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(0UL);
    }

    public static ulong3 MultiplicativeIdentity 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(1UL);
    }



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static ulong3 operator +(ulong3 left, ulong3 right)
    {
        return new(left.vector + right.vector);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static ulong3 operator -(ulong3 left, ulong3 right)
    {
        return new(left.vector - right.vector);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static ulong3 operator *(ulong3 left, ulong3 right)
    {
        return new(left.vector * right.vector);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static ulong3 operator /(ulong3 left, ulong3 right)
    {
        return new(left.vector / right.vector);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static ulong3 operator %(ulong3 left, ulong3 right) => new(left.x % right.x, left.y % right.y, left.z % right.z);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static ulong3 operator +(ulong3 left, ulong right) => left + new ulong3(right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static ulong3 operator -(ulong3 left, ulong right) => left - new ulong3(right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static ulong3 operator *(ulong3 left, ulong right) => left * new ulong3(right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static ulong3 operator /(ulong3 left, ulong right) => left / new ulong3(right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static ulong3 operator %(ulong3 left, ulong right) => left % new ulong3(right);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static ulong3 operator +(ulong left, ulong3 right) => new ulong3(left) + right;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static ulong3 operator -(ulong left, ulong3 right) => new ulong3(left) - right;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static ulong3 operator *(ulong left, ulong3 right) => new ulong3(left) * right;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static ulong3 operator /(ulong left, ulong3 right) => new ulong3(left) / right;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static ulong3 operator %(ulong left, ulong3 right) => new ulong3(left) % right;




    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static ulong3 operator +(ulong3 self) => new(+self.x, +self.y, +self.z);



    #endregion


    //////////////////////////////////////////////////////////////////////////////////////////////////// ToString

    #region ToString

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override string ToString() => $"ulong3({this.x}, {this.y}, {this.z})";

    #endregion
}

public static unsafe partial class math
{



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static ulong3 min(ulong3 x, ulong3 y) => new(min(x.x, y.x), min(x.y, y.y), min(x.z, y.z));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static ulong3 max(ulong3 x, ulong3 y) => new(max(x.x, y.x), max(x.y, y.y), max(x.z, y.z));



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static ulong3 mad(ulong3 a, ulong3 b, ulong3 c) => a * b + c;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static ulong3 clamp(ulong3 x, ulong3 a, ulong3 b) => max(a, min(b, x));





    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static ulong3 abs(ulong3 x) => x;




    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static ulong3 cross(ulong3 x, ulong3 y) => (x * y.yzx - x.yzx * y).yzx;




    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static ulong dot(ulong3 x, ulong3 y) => Vector256.Dot(x.vector, y.vector);














    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static ulong3 lengthsq(ulong3 x) => dot(x, x);







    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static ulong3 distancesq(ulong3 x, ulong3 y) => lengthsq(y - x);

    
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static ulong3 select(ulong3 a, ulong3 b, bool c) => c ? b : a;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static ulong3 select(ulong3 a, ulong3 b, bool3 c) => new(c.x ? b.x : a.x, c.y ? b.y : a.y, c.z ? b.z : a.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static ulong3 step(ulong3 y, ulong3 x) => select(new ulong3(0UL), new ulong3(1UL), x >= y);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static ulong3 reflect(ulong3 i, ulong3 n) => i - 2UL * n * dot(i, n);




    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static ulong3 project(ulong3 a, ulong3 b) => (dot(a, b) / dot(b, b)) * b;

    // todo projectsafe








}

public class Ulong3JsonConverter : JsonConverter<ulong3>
{
    public override ulong3 Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        Unsafe.SkipInit(out ulong3 result);
        if (reader.TokenType is not JsonTokenType.StartArray) throw new JsonException();
        reader.Read();
        result.x = reader.GetUInt64();
        reader.Read();
        result.y = reader.GetUInt64();
        reader.Read();
        result.z = reader.GetUInt64();
        reader.Read();
        if (reader.TokenType is not JsonTokenType.EndArray) throw new JsonException();
        return result;
    }

    public override void Write(Utf8JsonWriter writer, ulong3 value, JsonSerializerOptions options)
    {
        writer.WriteStartArray();
        writer.WriteNumberValue(value.x);
        writer.WriteNumberValue(value.y);
        writer.WriteNumberValue(value.z);
        writer.WriteEndArray();
    }
}
