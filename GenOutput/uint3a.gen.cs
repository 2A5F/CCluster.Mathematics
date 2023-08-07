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
[JsonConverter(typeof(Uint3AConverter))]
[StructLayout(LayoutKind.Explicit, Size = 12)]
public unsafe partial struct uint3a : 
    IEquatable<uint3a>, IEqualityOperators<uint3a, uint3a, bool>, IEqualityOperators<uint3a, uint3a, bool3>,

    IAdditionOperators<uint3a, uint3a, uint3a>, IAdditiveIdentity<uint3a, uint3a>, IUnaryPlusOperators<uint3a, uint3a>,
    ISubtractionOperators<uint3a, uint3a, uint3a>, 
    IMultiplyOperators<uint3a, uint3a, uint3a>, IMultiplicativeIdentity<uint3a, uint3a>,
    IDivisionOperators<uint3a, uint3a, uint3a>,
    IModulusOperators<uint3a, uint3a, uint3a>,

    IVector, IVector3, IVector<uint>, IVector3<uint>
{

    [FieldOffset(0)]
    public uint x;

    [FieldOffset(4)]
    public uint y;

    [FieldOffset(8)]
    public uint z;

    [FieldOffset(0)]
    public uint r;

    [FieldOffset(4)]
    public uint g;

    [FieldOffset(8)]
    public uint b;


    public static int ByteSize 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => 12;
    }

    public static int BitSize 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => 96;
    }

    public static uint3a Zero
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new uint3a(0u);
    }

    public static uint3a One
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new uint3a(1u);
    }


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public uint3a(uint value) : this(value, value, value) { }


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public uint3a(uint x, uint y, uint z)
    {

        this.x = x;

        this.y = y;

        this.z = z;

    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator uint3a(uint value) => new uint3a(value);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool Equals(uint3a other) => this.x == other.x && this.y == other.y && this.z == other.z;


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override bool Equals(object? o) => o is uint3a other && Equals(other);



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator ==(uint3a left, uint3a right) => left.x == right.x && left.y == right.y && left.z == right.z;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator !=(uint3a left, uint3a right) => left.x != right.x || left.y != right.y || left.z != right.z;



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override int GetHashCode() => HashCode.Combine(this.x, this.y, this.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public int3 Hash() => new int3(this.x.GetHashCode(), this.y.GetHashCode(), this.z.GetHashCode());

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    static bool3 IEqualityOperators<uint3a, uint3a, bool3>.operator ==(uint3a left, uint3a right) => new bool3(left.x == right.x, left.y == right.y, left.z == right.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    static bool3 IEqualityOperators<uint3a, uint3a, bool3>.operator !=(uint3a left, uint3a right) => new bool3(left.x != right.x, left.y != right.y, left.z != right.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool3 VEq(uint3a other) => new bool3(this.x == other.x, this.y == other.y, this.z == other.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool3 VNe(uint3a other) => new bool3(this.x != other.x, this.y != other.y, this.z != other.z);



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool3 operator >(uint3a left, uint3a right) => new bool3(left.x > right.x, left.y > right.y, left.z > right.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool3 operator <(uint3a left, uint3a right) => new bool3(left.x < right.x, left.y < right.y, left.z < right.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool3 operator >=(uint3a left, uint3a right) => new bool3(left.x >= right.x, left.y >= right.y, left.z >= right.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool3 operator <=(uint3a left, uint3a right) => new bool3(left.x <= right.x, left.y <= right.y, left.z <= right.z);




    public static uint3a AdditiveIdentity 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new uint3a(0u);
    }

    public static uint3a MultiplicativeIdentity 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new uint3a(1u);
    }



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3a operator +(uint3a left, uint3a right) => new uint3a(left.x + right.x, left.y + right.y, left.z + right.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3a operator -(uint3a left, uint3a right) => new uint3a(left.x - right.x, left.y - right.y, left.z - right.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3a operator *(uint3a left, uint3a right) => new uint3a(left.x * right.x, left.y * right.y, left.z * right.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3a operator /(uint3a left, uint3a right) => new uint3a(left.x / right.x, left.y / right.y, left.z / right.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3a operator %(uint3a left, uint3a right) => new uint3a(left.x % right.x, left.y % right.y, left.z % right.z);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3a operator +(uint3a left, uint right) => new uint3a(left.x + right, left.y + right, left.z + right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3a operator -(uint3a left, uint right) => new uint3a(left.x - right, left.y - right, left.z - right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3a operator *(uint3a left, uint right) => new uint3a(left.x * right, left.y * right, left.z * right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3a operator /(uint3a left, uint right) => new uint3a(left.x / right, left.y / right, left.z / right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3a operator %(uint3a left, uint right) => new uint3a(left.x % right, left.y % right, left.z % right);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3a operator +(uint left, uint3a right) => new uint3a(left + right.x, left + right.y, left + right.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3a operator -(uint left, uint3a right) => new uint3a(left - right.x, left - right.y, left - right.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3a operator *(uint left, uint3a right) => new uint3a(left * right.x, left * right.y, left * right.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3a operator /(uint left, uint3a right) => new uint3a(left / right.x, left / right.y, left / right.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3a operator %(uint left, uint3a right) => new uint3a(left % right.x, left % right.y, left % right.z);




    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3a operator +(uint3a self) => new uint3a(+self.x, +self.y, +self.z);





    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override string ToString() => $"uint3a({this.x}, {this.y}, {this.z})";

}

public static unsafe partial class math
{



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3a min(uint3a x, uint3a y) => new uint3a(min(x.x, y.x), min(x.y, y.y), min(x.z, y.z));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3a max(uint3a x, uint3a y) => new uint3a(max(x.x, y.x), max(x.y, y.y), max(x.z, y.z));



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3a mad(uint3a a, uint3a b, uint3a c) => a * b + c;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3a clamp(uint3a x, uint3a a, uint3a b) => max(a, min(b, x));





    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3a abs(uint3a x) => x;




    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3a cross(uint3a x, uint3a y) => (x * y.yzx - x.yzx * y).yzx;




    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint dot(uint3a x, uint3a y) => x.x * y.x + x.y * y.y + x.z * y.z;














    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3a lengthsq(uint3a x) => dot(x, x);







    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3a distancesq(uint3a x, uint3a y) => lengthsq(y - x);

    
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3a select(uint3a a, uint3a b, bool c) => c ? b : a;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3a select(uint3a a, uint3a b, bool3 c) => new uint3a(c.x ? b.x : a.x, c.y ? b.y : a.y, c.z ? b.z : a.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3a step(uint3a y, uint3a x) => select(new uint3a(0u), new uint3a(1u), x >= y);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3a reflect(uint3a i, uint3a n) => i - 2u * n * dot(i, n);




    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3a project(uint3a a, uint3a b) => (dot(a, b) / dot(b, b)) * b;

    // todo projectsafe








}

public class Uint3AConverter : JsonConverter<uint3a>
{
    public override uint3a Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        Unsafe.SkipInit(out uint3a result);
        if (reader.TokenType is not JsonTokenType.StartArray) throw new JsonException();
        reader.Read();
        result.x = reader.GetUInt32();
        reader.Read();
        result.y = reader.GetUInt32();
        reader.Read();
        result.z = reader.GetUInt32();
        reader.Read();
        if (reader.TokenType is not JsonTokenType.EndArray) throw new JsonException();
        return result;
    }

    public override void Write(Utf8JsonWriter writer, uint3a value, JsonSerializerOptions options)
    {
        writer.WriteStartArray();
        writer.WriteNumberValue(value.x);
        writer.WriteNumberValue(value.y);
        writer.WriteNumberValue(value.z);
        writer.WriteEndArray();
    }
}
