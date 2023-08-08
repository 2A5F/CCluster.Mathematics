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

/// <summary>A 4 component vector of ulong</summary>
[Serializable]
[JsonConverter(typeof(Ulong4JsonConverter))]
[StructLayout(LayoutKind.Explicit, Size = 32)]
public unsafe partial struct ulong4 : 
    IEquatable<ulong4>, IEqualityOperators<ulong4, ulong4, bool>, IEqualityOperators<ulong4, ulong4, bool4>,

    IAdditionOperators<ulong4, ulong4, ulong4>, IAdditiveIdentity<ulong4, ulong4>, IUnaryPlusOperators<ulong4, ulong4>,
    ISubtractionOperators<ulong4, ulong4, ulong4>, 
    IMultiplyOperators<ulong4, ulong4, ulong4>, IMultiplicativeIdentity<ulong4, ulong4>,
    IDivisionOperators<ulong4, ulong4, ulong4>,
    IModulusOperators<ulong4, ulong4, ulong4>,

    IVector4<ulong>, IVectorSelf<ulong4>
{

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

    /// <summary>W component of the vector</summary>
    [FieldOffset(24)]
    public ulong w;


    /// <summary>R component of the vector</summary>
    [FieldOffset(0)]
    public ulong r;

    /// <summary>G component of the vector</summary>
    [FieldOffset(8)]
    public ulong g;

    /// <summary>B component of the vector</summary>
    [FieldOffset(16)]
    public ulong b;

    /// <summary>A component of the vector</summary>
    [FieldOffset(24)]
    public ulong a;


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

    public static readonly ulong4 zero = new(0UL);

    public static readonly ulong4 one = new(1UL);

    static ulong4 IVectorSelf<ulong4>.Zero 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => zero;
    }

    static ulong4 IVectorSelf<ulong4>.One 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => one;
    }


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public ulong4(Vector256<ulong> vector)
    {
        this.vector = vector;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public ulong4(ulong value)
    {
        this.vector = Vector256.Create(value);
    }


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public ulong4(ulong x, ulong y, ulong z, ulong w)
    {

        this.vector = Vector256.Create(x, y, z, w);

    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator ulong4(ulong value) => new(value);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool Equals(ulong4 other)
    {
        return this.vector.Equals(other.vector);
    }


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override bool Equals(object? o) => o is ulong4 other && Equals(other);



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator ==(ulong4 left, ulong4 right)
    {
        return left.vector.Equals(right.vector);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator !=(ulong4 left, ulong4 right)
    {
        return !left.vector.Equals(right.vector);
    }



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override int GetHashCode() => HashCode.Combine(this.x, this.y, this.z, this.w);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public int4 Hash() => new(this.x.GetHashCode(), this.y.GetHashCode(), this.z.GetHashCode(), this.w.GetHashCode());

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    static bool4 IEqualityOperators<ulong4, ulong4, bool4>.operator ==(ulong4 left, ulong4 right) => new(left.x == right.x, left.y == right.y, left.z == right.z, left.w == right.w);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    static bool4 IEqualityOperators<ulong4, ulong4, bool4>.operator !=(ulong4 left, ulong4 right) => new(left.x != right.x, left.y != right.y, left.z != right.z, left.w != right.w);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool4 VEq(ulong4 other) => new(this.x == other.x, this.y == other.y, this.z == other.z, this.w == other.w);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool4 VNe(ulong4 other) => new(this.x != other.x, this.y != other.y, this.z != other.z, this.w != other.w);



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool4 operator >(ulong4 left, ulong4 right) => new(left.x > right.x, left.y > right.y, left.z > right.z, left.w > right.w);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool4 operator <(ulong4 left, ulong4 right) => new(left.x < right.x, left.y < right.y, left.z < right.z, left.w < right.w);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool4 operator >=(ulong4 left, ulong4 right) => new(left.x >= right.x, left.y >= right.y, left.z >= right.z, left.w >= right.w);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool4 operator <=(ulong4 left, ulong4 right) => new(left.x <= right.x, left.y <= right.y, left.z <= right.z, left.w <= right.w);




    public static ulong4 AdditiveIdentity 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(0UL);
    }

    public static ulong4 MultiplicativeIdentity 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(1UL);
    }



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static ulong4 operator +(ulong4 left, ulong4 right)
    {
        return new(left.vector + right.vector);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static ulong4 operator -(ulong4 left, ulong4 right)
    {
        return new(left.vector - right.vector);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static ulong4 operator *(ulong4 left, ulong4 right)
    {
        return new(left.vector * right.vector);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static ulong4 operator /(ulong4 left, ulong4 right)
    {
        return new(left.vector / right.vector);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static ulong4 operator %(ulong4 left, ulong4 right) => new(left.x % right.x, left.y % right.y, left.z % right.z, left.w % right.w);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static ulong4 operator +(ulong4 left, ulong right) => left + new ulong4(right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static ulong4 operator -(ulong4 left, ulong right) => left - new ulong4(right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static ulong4 operator *(ulong4 left, ulong right) => left * new ulong4(right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static ulong4 operator /(ulong4 left, ulong right) => left / new ulong4(right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static ulong4 operator %(ulong4 left, ulong right) => left % new ulong4(right);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static ulong4 operator +(ulong left, ulong4 right) => new ulong4(left) + right;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static ulong4 operator -(ulong left, ulong4 right) => new ulong4(left) - right;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static ulong4 operator *(ulong left, ulong4 right) => new ulong4(left) * right;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static ulong4 operator /(ulong left, ulong4 right) => new ulong4(left) / right;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static ulong4 operator %(ulong left, ulong4 right) => new ulong4(left) % right;




    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static ulong4 operator +(ulong4 self) => new(+self.x, +self.y, +self.z, +self.w);





    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override string ToString() => $"ulong4({this.x}, {this.y}, {this.z}, {this.w})";

}

public static unsafe partial class math
{



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static ulong4 min(ulong4 x, ulong4 y) => new(min(x.x, y.x), min(x.y, y.y), min(x.z, y.z), min(x.w, y.w));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static ulong4 max(ulong4 x, ulong4 y) => new(max(x.x, y.x), max(x.y, y.y), max(x.z, y.z), max(x.w, y.w));



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static ulong4 mad(ulong4 a, ulong4 b, ulong4 c) => a * b + c;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static ulong4 clamp(ulong4 x, ulong4 a, ulong4 b) => max(a, min(b, x));





    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static ulong4 abs(ulong4 x) => x;







    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static ulong dot(ulong4 x, ulong4 y) => Vector256.Dot(x.vector, y.vector);














    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static ulong4 lengthsq(ulong4 x) => dot(x, x);







    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static ulong4 distancesq(ulong4 x, ulong4 y) => lengthsq(y - x);

    
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static ulong4 select(ulong4 a, ulong4 b, bool c) => c ? b : a;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static ulong4 select(ulong4 a, ulong4 b, bool4 c) => new(c.x ? b.x : a.x, c.y ? b.y : a.y, c.z ? b.z : a.z, c.w ? b.w : a.w);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static ulong4 step(ulong4 y, ulong4 x) => select(new ulong4(0UL), new ulong4(1UL), x >= y);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static ulong4 reflect(ulong4 i, ulong4 n) => i - 2UL * n * dot(i, n);




    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static ulong4 project(ulong4 a, ulong4 b) => (dot(a, b) / dot(b, b)) * b;

    // todo projectsafe








}

public class Ulong4JsonConverter : JsonConverter<ulong4>
{
    public override ulong4 Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        Unsafe.SkipInit(out ulong4 result);
        if (reader.TokenType is not JsonTokenType.StartArray) throw new JsonException();
        reader.Read();
        result.x = reader.GetUInt64();
        reader.Read();
        result.y = reader.GetUInt64();
        reader.Read();
        result.z = reader.GetUInt64();
        reader.Read();
        result.w = reader.GetUInt64();
        reader.Read();
        if (reader.TokenType is not JsonTokenType.EndArray) throw new JsonException();
        return result;
    }

    public override void Write(Utf8JsonWriter writer, ulong4 value, JsonSerializerOptions options)
    {
        writer.WriteStartArray();
        writer.WriteNumberValue(value.x);
        writer.WriteNumberValue(value.y);
        writer.WriteNumberValue(value.z);
        writer.WriteNumberValue(value.w);
        writer.WriteEndArray();
    }
}
