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
[JsonConverter(typeof(Uint4Converter))]
[StructLayout(LayoutKind.Explicit, Size = 16)]
public unsafe partial struct uint4 : 
    IEquatable<uint4>, IEqualityOperators<uint4, uint4, bool>, IEqualityOperators<uint4, uint4, bool4>,

    IAdditionOperators<uint4, uint4, uint4>, IAdditiveIdentity<uint4, uint4>, IUnaryPlusOperators<uint4, uint4>,
    ISubtractionOperators<uint4, uint4, uint4>, 
    IMultiplyOperators<uint4, uint4, uint4>, IMultiplicativeIdentity<uint4, uint4>,
    IDivisionOperators<uint4, uint4, uint4>,
    IModulusOperators<uint4, uint4, uint4>,

    IVector, IVector4, IVector<uint>, IVector4<uint>
{

    [FieldOffset(0)]
    public Vector128<uint> vector;


    [FieldOffset(0)]
    public uint x;

    [FieldOffset(4)]
    public uint y;

    [FieldOffset(8)]
    public uint z;

    [FieldOffset(12)]
    public uint w;

    [FieldOffset(0)]
    public uint r;

    [FieldOffset(4)]
    public uint g;

    [FieldOffset(8)]
    public uint b;

    [FieldOffset(12)]
    public uint a;


    public static int ByteSize 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => 16;
    }

    public static int BitSize 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => 128;
    }

    public static uint4 Zero
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new uint4(0u);
    }

    public static uint4 One
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new uint4(1u);
    }


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public uint4(Vector128<uint> vector)
    {
        this.vector = vector;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public uint4(uint value)
    {
        this.vector = Vector128.Create(value);
    }


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public uint4(uint x, uint y, uint z, uint w)
    {

        this.vector = Vector128.Create(x, y, z, w);

    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator uint4(uint value) => new uint4(value);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool Equals(uint4 other)
    {
        return this.vector.Equals(other.vector);
    }


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override bool Equals(object? o) => o is uint4 other && Equals(other);



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator ==(uint4 left, uint4 right)
    {
        return left.vector.Equals(right.vector);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator !=(uint4 left, uint4 right)
    {
        return !left.vector.Equals(right.vector);
    }



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override int GetHashCode() => HashCode.Combine(this.x, this.y, this.z, this.w);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public int4 Hash() => new int4(this.x.GetHashCode(), this.y.GetHashCode(), this.z.GetHashCode(), this.w.GetHashCode());

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    static bool4 IEqualityOperators<uint4, uint4, bool4>.operator ==(uint4 left, uint4 right) => new bool4(left.x == right.x, left.y == right.y, left.z == right.z, left.w == right.w);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    static bool4 IEqualityOperators<uint4, uint4, bool4>.operator !=(uint4 left, uint4 right) => new bool4(left.x != right.x, left.y != right.y, left.z != right.z, left.w != right.w);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool4 VEq(uint4 other) => new bool4(this.x == other.x, this.y == other.y, this.z == other.z, this.w == other.w);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool4 VNe(uint4 other) => new bool4(this.x != other.x, this.y != other.y, this.z != other.z, this.w != other.w);



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool4 operator >(uint4 left, uint4 right) => new bool4(left.x > right.x, left.y > right.y, left.z > right.z, left.w > right.w);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool4 operator <(uint4 left, uint4 right) => new bool4(left.x < right.x, left.y < right.y, left.z < right.z, left.w < right.w);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool4 operator >=(uint4 left, uint4 right) => new bool4(left.x >= right.x, left.y >= right.y, left.z >= right.z, left.w >= right.w);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool4 operator <=(uint4 left, uint4 right) => new bool4(left.x <= right.x, left.y <= right.y, left.z <= right.z, left.w <= right.w);




    public static uint4 AdditiveIdentity 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new uint4(0u);
    }

    public static uint4 MultiplicativeIdentity 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new uint4(1u);
    }



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint4 operator +(uint4 left, uint4 right)
    {
        return new uint4(left.vector + right.vector);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint4 operator -(uint4 left, uint4 right)
    {
        return new uint4(left.vector - right.vector);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint4 operator *(uint4 left, uint4 right)
    {
        return new uint4(left.vector * right.vector);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint4 operator /(uint4 left, uint4 right)
    {
        return new uint4(left.vector / right.vector);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint4 operator %(uint4 left, uint4 right) => new uint4(left.x % right.x, left.y % right.y, left.z % right.z, left.w % right.w);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint4 operator +(uint4 left, uint right) => left + new uint4(right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint4 operator -(uint4 left, uint right) => left - new uint4(right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint4 operator *(uint4 left, uint right) => left * new uint4(right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint4 operator /(uint4 left, uint right) => left / new uint4(right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint4 operator %(uint4 left, uint right) => left % new uint4(right);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint4 operator +(uint left, uint4 right) => new uint4(left) + right;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint4 operator -(uint left, uint4 right) => new uint4(left) - right;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint4 operator *(uint left, uint4 right) => new uint4(left) * right;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint4 operator /(uint left, uint4 right) => new uint4(left) / right;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint4 operator %(uint left, uint4 right) => new uint4(left) % right;




    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint4 operator +(uint4 self) => new uint4(+self.x, +self.y, +self.z, +self.w);





    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override string ToString() => $"uint4({this.x}, {this.y}, {this.z}, {this.w})";

}

public static unsafe partial class math
{



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint4 min(uint4 x, uint4 y) => new uint4(min(x.x, y.x), min(x.y, y.y), min(x.z, y.z), min(x.w, y.w));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint4 max(uint4 x, uint4 y) => new uint4(max(x.x, y.x), max(x.y, y.y), max(x.z, y.z), max(x.w, y.w));



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint4 mad(uint4 a, uint4 b, uint4 c) => a * b + c;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint4 clamp(uint4 x, uint4 a, uint4 b) => max(a, min(b, x));





    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint4 abs(uint4 x) => x;







    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint dot(uint4 x, uint4 y) => Vector128.Dot(x.vector, y.vector);














    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint4 lengthsq(uint4 x) => dot(x, x);







    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint4 distancesq(uint4 x, uint4 y) => lengthsq(y - x);

    
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint4 select(uint4 a, uint4 b, bool c) => c ? b : a;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint4 select(uint4 a, uint4 b, bool4 c) => new uint4(c.x ? b.x : a.x, c.y ? b.y : a.y, c.z ? b.z : a.z, c.w ? b.w : a.w);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint4 step(uint4 y, uint4 x) => select(new uint4(0u), new uint4(1u), x >= y);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint4 reflect(uint4 i, uint4 n) => i - 2u * n * dot(i, n);




    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint4 project(uint4 a, uint4 b) => (dot(a, b) / dot(b, b)) * b;

    // todo projectsafe








}

public class Uint4Converter : JsonConverter<uint4>
{
    public override uint4 Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        Unsafe.SkipInit(out uint4 result);
        if (reader.TokenType is not JsonTokenType.StartArray) throw new JsonException();
        reader.Read();
        result.x = reader.GetUInt32();
        reader.Read();
        result.y = reader.GetUInt32();
        reader.Read();
        result.z = reader.GetUInt32();
        reader.Read();
        result.w = reader.GetUInt32();
        reader.Read();
        if (reader.TokenType is not JsonTokenType.EndArray) throw new JsonException();
        return result;
    }

    public override void Write(Utf8JsonWriter writer, uint4 value, JsonSerializerOptions options)
    {
        writer.WriteStartArray();
        writer.WriteNumberValue(value.x);
        writer.WriteNumberValue(value.y);
        writer.WriteNumberValue(value.z);
        writer.WriteNumberValue(value.w);
        writer.WriteEndArray();
    }
}
