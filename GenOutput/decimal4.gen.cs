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

/// <summary>A 4 component vector of decimal</summary>
[Serializable]
[JsonConverter(typeof(Decimal4JsonConverter))]
[StructLayout(LayoutKind.Explicit, Size = 64, Pack = 16)]
public unsafe partial struct decimal4 : 
    IEquatable<decimal4>, IEqualityOperators<decimal4, decimal4, bool>, IEqualityOperators<decimal4, decimal4, bool4>,

    IAdditionOperators<decimal4, decimal4, decimal4>, IAdditiveIdentity<decimal4, decimal4>, IUnaryPlusOperators<decimal4, decimal4>,
    ISubtractionOperators<decimal4, decimal4, decimal4>, IUnaryNegationOperators<decimal4, decimal4>,
    IMultiplyOperators<decimal4, decimal4, decimal4>, IMultiplicativeIdentity<decimal4, decimal4>,
    IDivisionOperators<decimal4, decimal4, decimal4>,
    IModulusOperators<decimal4, decimal4, decimal4>,

    IVector4<decimal>, IVectorSelf<decimal4>
{    
    //////////////////////////////////////////////////////////////////////////////////////////////////// Fields

    #region Fields

    /// <summary>X component of the vector</summary>
    [FieldOffset(0)]
    public decimal x;

    /// <summary>Y component of the vector</summary>
    [FieldOffset(16)]
    public decimal y;

    /// <summary>Z component of the vector</summary>
    [FieldOffset(32)]
    public decimal z;

    /// <summary>W component of the vector</summary>
    [FieldOffset(48)]
    public decimal w;


    /// <summary>R component of the vector</summary>
    [FieldOffset(0)]
    public decimal r;

    /// <summary>G component of the vector</summary>
    [FieldOffset(16)]
    public decimal g;

    /// <summary>B component of the vector</summary>
    [FieldOffset(32)]
    public decimal b;

    /// <summary>A component of the vector</summary>
    [FieldOffset(48)]
    public decimal a;

    #endregion

    //////////////////////////////////////////////////////////////////////////////////////////////////// Constants

    #region Constants

    public static int ByteSize 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => 64;
    }

    public static int BitSize 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => 512;
    }

    public static readonly decimal4 zero = new(0m);

    public static readonly decimal4 one = new(1m);

    static decimal4 IVectorSelf<decimal4>.Zero 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => zero;
    }

    static decimal4 IVectorSelf<decimal4>.One 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => one;
    }

    #endregion

    //////////////////////////////////////////////////////////////////////////////////////////////////// Ctor

    #region Ctor

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public decimal4(decimal value) : this(value, value, value, value) { }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public decimal4(decimal x, decimal y, decimal z, decimal w)
    {
        this.x = x;

        this.y = y;

        this.z = z;

        this.w = w;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public decimal4(decimal2 xy, decimal2 zw) : this(xy.x, xy.y, zw.x, zw.y) { }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public decimal4(decimal2 xy, decimal z, decimal w) : this(xy.x, xy.y, z, w) { }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public decimal4(decimal x, decimal2 yz, decimal w) : this(x, yz.x, yz.y, w) { }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public decimal4(decimal x, decimal y, decimal2 zw) : this(x, y, zw.x, zw.y) { }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public decimal4(decimal3 xyz, decimal w) : this(xyz.x, xyz.y, xyz.z, w) { }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public decimal4(decimal x, decimal3 yzw) : this(x, yzw.x, yzw.y, yzw.z) { }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator decimal4(decimal value) => new(value);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static explicit operator decimal(decimal4 value) => value.x;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static explicit operator uint4(decimal4 self) => new((uint)self.x, (uint)self.y, (uint)self.z, (uint)self.w);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static explicit operator int4(decimal4 self) => new((int)self.x, (int)self.y, (int)self.z, (int)self.w);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static explicit operator ulong4(decimal4 self) => new((ulong)self.x, (ulong)self.y, (ulong)self.z, (ulong)self.w);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static explicit operator long4(decimal4 self) => new((long)self.x, (long)self.y, (long)self.z, (long)self.w);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static explicit operator float4(decimal4 self) => new((float)self.x, (float)self.y, (float)self.z, (float)self.w);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static explicit operator double4(decimal4 self) => new((double)self.x, (double)self.y, (double)self.z, (double)self.w);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static explicit operator Half4(decimal4 self) => new((Half)self.x, (Half)self.y, (Half)self.z, (Half)self.w);


    #endregion

    //////////////////////////////////////////////////////////////////////////////////////////////////// Equals

    #region Equals


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool Equals(decimal4 other) => this.x == other.x && this.y == other.y && this.z == other.z && this.w == other.w;


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override bool Equals(object? o) => o is decimal4 other && Equals(other);



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator ==(decimal4 left, decimal4 right) => left.x == right.x && left.y == right.y && left.z == right.z && left.w == right.w;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator !=(decimal4 left, decimal4 right) => left.x != right.x || left.y != right.y || left.z != right.z || left.w != right.w;



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override int GetHashCode() => HashCode.Combine(this.x, this.y, this.z, this.w);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public int4 Hash() => new(this.x.GetHashCode(), this.y.GetHashCode(), this.z.GetHashCode(), this.w.GetHashCode());

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    static bool4 IEqualityOperators<decimal4, decimal4, bool4>.operator ==(decimal4 left, decimal4 right) => new(left.x == right.x, left.y == right.y, left.z == right.z, left.w == right.w);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    static bool4 IEqualityOperators<decimal4, decimal4, bool4>.operator !=(decimal4 left, decimal4 right) => new(left.x != right.x, left.y != right.y, left.z != right.z, left.w != right.w);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool4 VEq(decimal4 other) => new(this.x == other.x, this.y == other.y, this.z == other.z, this.w == other.w);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool4 VNe(decimal4 other) => new(this.x != other.x, this.y != other.y, this.z != other.z, this.w != other.w);

    #endregion



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool4 operator >(decimal4 left, decimal4 right) => new(left.x > right.x, left.y > right.y, left.z > right.z, left.w > right.w);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool4 operator <(decimal4 left, decimal4 right) => new(left.x < right.x, left.y < right.y, left.z < right.z, left.w < right.w);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool4 operator >=(decimal4 left, decimal4 right) => new(left.x >= right.x, left.y >= right.y, left.z >= right.z, left.w >= right.w);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool4 operator <=(decimal4 left, decimal4 right) => new(left.x <= right.x, left.y <= right.y, left.z <= right.z, left.w <= right.w);




    //////////////////////////////////////////////////////////////////////////////////////////////////// Arithmetic

    #region Arithmetic

    public static decimal4 AdditiveIdentity 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(0m);
    }

    public static decimal4 MultiplicativeIdentity 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(1m);
    }



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal4 operator +(decimal4 left, decimal4 right) => new(left.x + right.x, left.y + right.y, left.z + right.z, left.w + right.w);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal4 operator -(decimal4 left, decimal4 right) => new(left.x - right.x, left.y - right.y, left.z - right.z, left.w - right.w);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal4 operator *(decimal4 left, decimal4 right) => new(left.x * right.x, left.y * right.y, left.z * right.z, left.w * right.w);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal4 operator /(decimal4 left, decimal4 right) => new(left.x / right.x, left.y / right.y, left.z / right.z, left.w / right.w);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal4 operator %(decimal4 left, decimal4 right) => new(left.x % right.x, left.y % right.y, left.z % right.z, left.w % right.w);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal4 operator +(decimal4 left, decimal right) => new(left.x + right, left.y + right, left.z + right, left.w + right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal4 operator -(decimal4 left, decimal right) => new(left.x - right, left.y - right, left.z - right, left.w - right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal4 operator *(decimal4 left, decimal right) => new(left.x * right, left.y * right, left.z * right, left.w * right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal4 operator /(decimal4 left, decimal right) => new(left.x / right, left.y / right, left.z / right, left.w / right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal4 operator %(decimal4 left, decimal right) => new(left.x % right, left.y % right, left.z % right, left.w % right);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal4 operator +(decimal left, decimal4 right) => new(left + right.x, left + right.y, left + right.z, left + right.w);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal4 operator -(decimal left, decimal4 right) => new(left - right.x, left - right.y, left - right.z, left - right.w);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal4 operator *(decimal left, decimal4 right) => new(left * right.x, left * right.y, left * right.z, left * right.w);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal4 operator /(decimal left, decimal4 right) => new(left / right.x, left / right.y, left / right.z, left / right.w);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal4 operator %(decimal left, decimal4 right) => new(left % right.x, left % right.y, left % right.z, left % right.w);


    
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal4 operator -(decimal4 self) => new(-self.x, -self.y, -self.z, -self.w);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal4 operator +(decimal4 self) => new(+self.x, +self.y, +self.z, +self.w);



    #endregion


    //////////////////////////////////////////////////////////////////////////////////////////////////// BitOpers

    #region BitOpers



    #endregion

    //////////////////////////////////////////////////////////////////////////////////////////////////// ToString

    #region ToString

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override string ToString() => $"decimal4({this.x}, {this.y}, {this.z}, {this.w})";

    #endregion
}

public static unsafe partial class vectors
{


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal4 decimal4(decimal value) => new(value);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal4 decimal4(decimal x, decimal y, decimal z, decimal w) => new(x, y, z, w);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal4 decimal4(decimal2 xy, decimal2 zw) => new(xy, zw);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal4 decimal4(decimal2 xy, decimal z, decimal w) => new(xy, z, w);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal4 decimal4(decimal x, decimal2 yz, decimal w) => new(x, yz, w);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal4 decimal4(decimal x, decimal y, decimal2 zw) => new(x, y, zw);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal4 decimal4(decimal3 xyz, decimal w) => new(xyz, w);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal4 decimal4(decimal x, decimal3 yzw) => new(x, yzw);




} // vectors

public static unsafe partial class math
{




    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal4 min(decimal4 x, decimal4 y) => new(min(x.x, y.x), min(x.y, y.y), min(x.z, y.z), min(x.w, y.w));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal4 max(decimal4 x, decimal4 y) => new(max(x.x, y.x), max(x.y, y.y), max(x.z, y.z), max(x.w, y.w));


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal4 min(decimal4 x, decimal4 y, decimal4 z) => min(min(x, y), z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal4 max(decimal4 x, decimal4 y, decimal4 z) => max(max(x, y), z);



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal4 lerp(decimal4 s, decimal4 x, decimal4 y) => x + s * (y - x);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal4 unlerp(decimal4 x, decimal4 a, decimal4 b) => (x - a) / (b - a);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal4 remap(decimal4 x, decimal4 a, decimal4 b, decimal4 c, decimal4 d) => lerp(c, d, unlerp(a, b, x));




    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal4 mad(decimal4 a, decimal4 b, decimal4 c) => a * b + c;


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal4 clamp(decimal4 x, decimal4 a, decimal4 b) => max(a, min(b, x));



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal4 saturate(decimal4 x) => clamp(x, decimal4.zero, decimal4.one);






        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal4 abs(decimal4 x) => new(abs(x.x), abs(x.y), abs(x.z), abs(x.w));








    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal dot(decimal4 x, decimal4 y) => x.x * y.x + x.y * y.y + x.z * y.z + x.w * y.w;


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal mul(decimal4 a, decimal4 b) => dot(a, b);









    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal4 floor(decimal4 x) => new(floor(x.x), floor(x.y), floor(x.z), floor(x.w));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal4 ceil(decimal4 x) => new(ceil(x.x), ceil(x.y), ceil(x.z), ceil(x.w));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal4 round(decimal4 x) => new(round(x.x), round(x.y), round(x.z), round(x.w));



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal4 trunc(decimal4 x) => new(trunc(x.x), trunc(x.y), trunc(x.z), trunc(x.w));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal4 frac(decimal4 x) => x - floor(x);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal4 rcp(decimal4 x) => 1m / x;





    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal4 sign(decimal4 x) => new(sign(x.x), sign(x.y), sign(x.z), sign(x.w));







    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal4 lengthsq(decimal4 x) => dot(x, x);







    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal4 distancesq(decimal4 x, decimal4 y) => lengthsq(y - x);

    
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal4 select(decimal4 a, decimal4 b, bool c) => c ? b : a;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal4 select(decimal4 a, decimal4 b, bool4 c) => new(c.x ? b.x : a.x, c.y ? b.y : a.y, c.z ? b.z : a.z, c.w ? b.w : a.w);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal4 step(decimal4 y, decimal4 x) => select(new decimal4(0m), new decimal4(1m), x >= y);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal4 reflect(decimal4 i, decimal4 n) => i - 2m * n * dot(i, n);




    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal4 project(decimal4 a, decimal4 b) => (dot(a, b) / dot(b, b)) * b;

    // todo projectsafe




    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal4 faceforward(decimal4 n, decimal4 i, decimal4 ng) => select(n, -n, dot(ng, i) >= 0m);




    
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal4 radians(decimal4 x) => x * 0.0174532925199432957692369076848861271344287188854172545609719144m;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal4 degrees(decimal4 x) => x * 57.295779513082320876798154814105170332405472466564321549160243861m;





    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal csum(decimal4 x) => x.x + x.y + x.z + x.w;




    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int4 pop_cnt(decimal4 x)
    {
        return new(pop_cnt(x.x), pop_cnt(x.y), pop_cnt(x.z), pop_cnt(x.w));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int count_bits(decimal4 x)
    {

        return csum(pop_cnt(x));
    }

} // class math

namespace Json
{

public class Decimal4JsonConverter : JsonConverter<decimal4>
{
    public override decimal4 Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        Unsafe.SkipInit(out decimal4 result);
        if (reader.TokenType is not JsonTokenType.StartArray) throw new JsonException();
        reader.Read();
        result.x = reader.GetDecimal();
        reader.Read();
        result.y = reader.GetDecimal();
        reader.Read();
        result.z = reader.GetDecimal();
        reader.Read();
        result.w = reader.GetDecimal();
        reader.Read();
        if (reader.TokenType is not JsonTokenType.EndArray) throw new JsonException();
        return result;
    }

    public override void Write(Utf8JsonWriter writer, decimal4 value, JsonSerializerOptions options)
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
