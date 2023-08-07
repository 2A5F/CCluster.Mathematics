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

[Serializable]
[JsonConverter(typeof(Ulong3Converter))]
[StructLayout(LayoutKind.Explicit, Size = 32)]
public unsafe partial struct ulong3 : 
    IEquatable<ulong3>, IEqualityOperators<ulong3, ulong3, bool>, IEqualityOperators<ulong3, ulong3, bool3>,

    IAdditionOperators<ulong3, ulong3, ulong3>, IAdditiveIdentity<ulong3, ulong3>, IUnaryPlusOperators<ulong3, ulong3>,
    ISubtractionOperators<ulong3, ulong3, ulong3>, 
    IMultiplyOperators<ulong3, ulong3, ulong3>, IMultiplicativeIdentity<ulong3, ulong3>,
    IDivisionOperators<ulong3, ulong3, ulong3>,
    IModulusOperators<ulong3, ulong3, ulong3>,

    IVector, IVector3, IVector<ulong>, IVector3<ulong>
{

    [FieldOffset(0)]
    public Vector256<ulong> vector;


    [FieldOffset(0)]
    public ulong x;

    [FieldOffset(8)]
    public ulong y;

    [FieldOffset(16)]
    public ulong z;

    [FieldOffset(0)]
    public ulong r;

    [FieldOffset(8)]
    public ulong g;

    [FieldOffset(16)]
    public ulong b;


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

    public static ulong3 Zero
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new ulong3(0UL);
    }

    public static ulong3 One
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new ulong3(1UL);
    }


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
    public static implicit operator ulong3(ulong value) => new ulong3(value);


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
    public int3 Hash() => new int3(this.x.GetHashCode(), this.y.GetHashCode(), this.z.GetHashCode());

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    static bool3 IEqualityOperators<ulong3, ulong3, bool3>.operator ==(ulong3 left, ulong3 right) => new bool3(left.x == right.x, left.y == right.y, left.z == right.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    static bool3 IEqualityOperators<ulong3, ulong3, bool3>.operator !=(ulong3 left, ulong3 right) => new bool3(left.x != right.x, left.y != right.y, left.z != right.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool3 VEq(ulong3 other) => new bool3(this.x == other.x, this.y == other.y, this.z == other.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool3 VNe(ulong3 other) => new bool3(this.x != other.x, this.y != other.y, this.z != other.z);



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool3 operator >(ulong3 left, ulong3 right) => new bool3(left.x > right.x, left.y > right.y, left.z > right.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool3 operator <(ulong3 left, ulong3 right) => new bool3(left.x < right.x, left.y < right.y, left.z < right.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool3 operator >=(ulong3 left, ulong3 right) => new bool3(left.x >= right.x, left.y >= right.y, left.z >= right.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool3 operator <=(ulong3 left, ulong3 right) => new bool3(left.x <= right.x, left.y <= right.y, left.z <= right.z);




    public static ulong3 AdditiveIdentity 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new ulong3(0UL);
    }

    public static ulong3 MultiplicativeIdentity 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new ulong3(1UL);
    }



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static ulong3 operator +(ulong3 left, ulong3 right)
    {
        return new ulong3(left.vector + right.vector);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static ulong3 operator -(ulong3 left, ulong3 right)
    {
        return new ulong3(left.vector - right.vector);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static ulong3 operator *(ulong3 left, ulong3 right)
    {
        return new ulong3(left.vector * right.vector);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static ulong3 operator /(ulong3 left, ulong3 right)
    {
        return new ulong3(left.vector / right.vector);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static ulong3 operator %(ulong3 left, ulong3 right) => new ulong3(left.x % right.x, left.y % right.y, left.z % right.z);


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
    public static ulong3 operator +(ulong3 self) => new ulong3(+self.x, +self.y, +self.z);





    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override string ToString() => $"ulong3({this.x}, {this.y}, {this.z})";

}

public static unsafe partial class math
{



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static ulong3 min(ulong3 x, ulong3 y) => new ulong3(min(x.x, y.x), min(x.y, y.y), min(x.z, y.z));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static ulong3 max(ulong3 x, ulong3 y) => new ulong3(max(x.x, y.x), max(x.y, y.y), max(x.z, y.z));



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
    public static ulong3 select(ulong3 a, ulong3 b, bool3 c) => new ulong3(c.x ? b.x : a.x, c.y ? b.y : a.y, c.z ? b.z : a.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static ulong3 step(ulong3 y, ulong3 x) => select(new ulong3(0UL), new ulong3(1UL), x >= y);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static ulong3 reflect(ulong3 i, ulong3 n) => i - 2UL * n * dot(i, n);




    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static ulong3 project(ulong3 a, ulong3 b) => (dot(a, b) / dot(b, b)) * b;

    // todo projectsafe








}

public class Ulong3Converter : JsonConverter<ulong3>
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
