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

/// <summary>A 3 component vector of uint</summary>
[Serializable]
[JsonConverter(typeof(Uint3JsonConverter))]
[StructLayout(LayoutKind.Explicit, Size = 16, Pack = 4)]
public unsafe partial struct uint3 : 
    IEquatable<uint3>, IEqualityOperators<uint3, uint3, bool>, IEqualityOperators<uint3, uint3, bool3>,

    IAdditionOperators<uint3, uint3, uint3>, IAdditiveIdentity<uint3, uint3>, IUnaryPlusOperators<uint3, uint3>,
    ISubtractionOperators<uint3, uint3, uint3>, 
    IMultiplyOperators<uint3, uint3, uint3>, IMultiplicativeIdentity<uint3, uint3>,
    IDivisionOperators<uint3, uint3, uint3>,
    IModulusOperators<uint3, uint3, uint3>,

    IVector3<uint>, IVectorSelf<uint3>
{    
    //////////////////////////////////////////////////////////////////////////////////////////////////// Fields

    #region Fields

    /// <summary>Raw simd vector</summary>
    [FieldOffset(0)]
    public Vector128<uint> vector;


    /// <summary>X component of the vector</summary>
    [FieldOffset(0)]
    public uint x;

    /// <summary>Y component of the vector</summary>
    [FieldOffset(4)]
    public uint y;

    /// <summary>Z component of the vector</summary>
    [FieldOffset(8)]
    public uint z;


    /// <summary>R component of the vector</summary>
    [FieldOffset(0)]
    public uint r;

    /// <summary>G component of the vector</summary>
    [FieldOffset(4)]
    public uint g;

    /// <summary>B component of the vector</summary>
    [FieldOffset(8)]
    public uint b;

    #endregion

    //////////////////////////////////////////////////////////////////////////////////////////////////// Constants

    #region Constants

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

    public static readonly uint3 zero = new(0u);

    public static readonly uint3 one = new(1u);

    static uint3 IVectorSelf<uint3>.Zero 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => zero;
    }

    static uint3 IVectorSelf<uint3>.One 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => one;
    }

    #endregion

    //////////////////////////////////////////////////////////////////////////////////////////////////// Ctor

    #region Ctor

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public uint3(Vector128<uint> vector)
    {
        this.vector = vector;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public uint3(uint value)
    {
        this.vector = Vector128.Create(value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public uint3(uint x, uint y, uint z)
    {
        this.vector = Vector128.Create(x, y, z, 0u);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public uint3(uint2 xy, uint z) : this(xy.x, xy.y, z) { }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public uint3(uint x, uint2 yz) : this(x, yz.x, yz.y) { }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator uint3(uint value) => new(value);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static explicit operator uint(uint3 value) => value.x;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator long3(uint3 self) => new(self.x, self.y, self.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator long3a(uint3 self) => new(self.x, self.y, self.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator ulong3(uint3 self) => new(self.x, self.y, self.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator ulong3a(uint3 self) => new(self.x, self.y, self.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator float3(uint3 self) => new(self.x, self.y, self.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator float3a(uint3 self) => new(self.x, self.y, self.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator double3(uint3 self) => new(self.x, self.y, self.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator double3a(uint3 self) => new(self.x, self.y, self.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator decimal3(uint3 self) => new(self.x, self.y, self.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator decimal3a(uint3 self) => new(self.x, self.y, self.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static explicit operator int3(uint3 self) => new((int)self.x, (int)self.y, (int)self.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static explicit operator int3a(uint3 self) => new((int)self.x, (int)self.y, (int)self.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static explicit operator Half3(uint3 self) => new((Half)self.x, (Half)self.y, (Half)self.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static explicit operator Half3a(uint3 self) => new((Half)self.x, (Half)self.y, (Half)self.z);

    #endregion

    //////////////////////////////////////////////////////////////////////////////////////////////////// Equals

    #region Equals


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool Equals(uint3 other)
    {
        return (this.vector & math.v3_iz_uint128).Equals((other.vector & math.v3_iz_uint128));
    }


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override bool Equals(object? o) => o is uint3 other && Equals(other);



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator ==(uint3 left, uint3 right)
    {
        return (left.vector & math.v3_iz_uint128).Equals((right.vector & math.v3_iz_uint128));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator !=(uint3 left, uint3 right)
    {
        return !(left.vector & math.v3_iz_uint128).Equals((right.vector & math.v3_iz_uint128));
    }



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override int GetHashCode() => HashCode.Combine(this.x, this.y, this.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public int3 Hash() => new(this.x.GetHashCode(), this.y.GetHashCode(), this.z.GetHashCode());

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    static bool3 IEqualityOperators<uint3, uint3, bool3>.operator ==(uint3 left, uint3 right) => new(left.x == right.x, left.y == right.y, left.z == right.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    static bool3 IEqualityOperators<uint3, uint3, bool3>.operator !=(uint3 left, uint3 right) => new(left.x != right.x, left.y != right.y, left.z != right.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool3 VEq(uint3 other) => new(this.x == other.x, this.y == other.y, this.z == other.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool3 VNe(uint3 other) => new(this.x != other.x, this.y != other.y, this.z != other.z);

    #endregion



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool3 operator >(uint3 left, uint3 right) => new(left.x > right.x, left.y > right.y, left.z > right.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool3 operator <(uint3 left, uint3 right) => new(left.x < right.x, left.y < right.y, left.z < right.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool3 operator >=(uint3 left, uint3 right) => new(left.x >= right.x, left.y >= right.y, left.z >= right.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool3 operator <=(uint3 left, uint3 right) => new(left.x <= right.x, left.y <= right.y, left.z <= right.z);




    //////////////////////////////////////////////////////////////////////////////////////////////////// Arithmetic

    #region Arithmetic

    public static uint3 AdditiveIdentity 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(0u);
    }

    public static uint3 MultiplicativeIdentity 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(1u);
    }



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3 operator +(uint3 left, uint3 right)
    {
        return new(left.vector + right.vector);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3 operator -(uint3 left, uint3 right)
    {
        return new(left.vector - right.vector);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3 operator *(uint3 left, uint3 right)
    {
        return new(left.vector * right.vector);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3 operator /(uint3 left, uint3 right)
    {
        return new(left.vector / right.vector);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3 operator %(uint3 left, uint3 right) => new(left.x % right.x, left.y % right.y, left.z % right.z);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3 operator +(uint3 left, uint right) => left + new uint3(right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3 operator -(uint3 left, uint right) => left - new uint3(right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3 operator *(uint3 left, uint right) => left * new uint3(right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3 operator /(uint3 left, uint right) => left / new uint3(right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3 operator %(uint3 left, uint right) => left % new uint3(right);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3 operator +(uint left, uint3 right) => new uint3(left) + right;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3 operator -(uint left, uint3 right) => new uint3(left) - right;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3 operator *(uint left, uint3 right) => new uint3(left) * right;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3 operator /(uint left, uint3 right) => new uint3(left) / right;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3 operator %(uint left, uint3 right) => new uint3(left) % right;




    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3 operator +(uint3 self) => new(+self.x, +self.y, +self.z);



    #endregion


    //////////////////////////////////////////////////////////////////////////////////////////////////// ToString

    #region ToString

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override string ToString() => $"uint3({this.x}, {this.y}, {this.z})";

    #endregion
}

public static unsafe partial class math
{



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3 min(uint3 x, uint3 y) => new(min(x.x, y.x), min(x.y, y.y), min(x.z, y.z));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3 max(uint3 x, uint3 y) => new(max(x.x, y.x), max(x.y, y.y), max(x.z, y.z));




    

    internal static readonly Vector128<uint> v3_iz_uint128 = Vector128.Create(-1, -1, -1, 0).As<int, uint>();


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3 mad(uint3 a, uint3 b, uint3 c)
    {
        
        
        
        return a * b + c;
    }


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3 clamp(uint3 x, uint3 a, uint3 b) => max(a, min(b, x));





    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3 abs(uint3 x) => x;




    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3 cross(uint3 x, uint3 y) => (x * y.yzx - x.yzx * y).yzx;




    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint dot(uint3 x, uint3 y) => Vector128.Dot(x.vector & math.v3_iz_uint128, y.vector);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint mul(uint3 a, uint3 b) => dot(a, b);













    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3 lengthsq(uint3 x) => dot(x, x);







    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3 distancesq(uint3 x, uint3 y) => lengthsq(y - x);

    
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3 select(uint3 a, uint3 b, bool c) => c ? b : a;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3 select(uint3 a, uint3 b, bool3 c) => new(c.x ? b.x : a.x, c.y ? b.y : a.y, c.z ? b.z : a.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3 step(uint3 y, uint3 x) => select(new uint3(0u), new uint3(1u), x >= y);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3 reflect(uint3 i, uint3 n) => i - 2u * n * dot(i, n);




    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3 project(uint3 a, uint3 b) => (dot(a, b) / dot(b, b)) * b;

    // todo projectsafe








}

public class Uint3JsonConverter : JsonConverter<uint3>
{
    public override uint3 Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        Unsafe.SkipInit(out uint3 result);
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

    public override void Write(Utf8JsonWriter writer, uint3 value, JsonSerializerOptions options)
    {
        writer.WriteStartArray();
        writer.WriteNumberValue(value.x);
        writer.WriteNumberValue(value.y);
        writer.WriteNumberValue(value.z);
        writer.WriteEndArray();
    }
}
