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

/// <summary>A 3 component vector of decimal, with no aligned</summary>
[Serializable]
[JsonConverter(typeof(Decimal3AJsonConverter))]
[StructLayout(LayoutKind.Explicit, Size = 48, Pack = 16)]
public unsafe partial struct decimal3a : 
    IEquatable<decimal3a>, IEqualityOperators<decimal3a, decimal3a, bool>, IEqualityOperators<decimal3a, decimal3a, bool3a>,

    IAdditionOperators<decimal3a, decimal3a, decimal3a>, IAdditiveIdentity<decimal3a, decimal3a>, IUnaryPlusOperators<decimal3a, decimal3a>,
    ISubtractionOperators<decimal3a, decimal3a, decimal3a>, IUnaryNegationOperators<decimal3a, decimal3a>,
    IMultiplyOperators<decimal3a, decimal3a, decimal3a>, IMultiplicativeIdentity<decimal3a, decimal3a>,
    IDivisionOperators<decimal3a, decimal3a, decimal3a>,
    IModulusOperators<decimal3a, decimal3a, decimal3a>,

    IVector3<decimal>, IVectorSelf<decimal3a>
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


    /// <summary>R component of the vector</summary>
    [FieldOffset(0)]
    public decimal r;

    /// <summary>G component of the vector</summary>
    [FieldOffset(16)]
    public decimal g;

    /// <summary>B component of the vector</summary>
    [FieldOffset(32)]
    public decimal b;

    #endregion

    //////////////////////////////////////////////////////////////////////////////////////////////////// Constants

    #region Constants

    public static int ByteSize 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => 48;
    }

    public static int BitSize 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => 384;
    }

    public static readonly decimal3a zero = new(0m);

    public static readonly decimal3a one = new(1m);

    static decimal3a IVectorSelf<decimal3a>.Zero 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => zero;
    }

    static decimal3a IVectorSelf<decimal3a>.One 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => one;
    }

    #endregion

    //////////////////////////////////////////////////////////////////////////////////////////////////// Ctor

    #region Ctor

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public decimal3a(decimal value) : this(value, value, value) { }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public decimal3a(decimal x, decimal y, decimal z)
    {
        this.x = x;

        this.y = y;

        this.z = z;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public decimal3a(decimal2 xy, decimal z) : this(xy.x, xy.y, z) { }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public decimal3a(decimal x, decimal2 yz) : this(x, yz.x, yz.y) { }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator decimal3a(decimal value) => new(value);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator decimal3a(decimal3 value) => new(value.x, value.y, value.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator decimal3(decimal3a value) => new(value.x, value.y, value.z);

    #endregion

    //////////////////////////////////////////////////////////////////////////////////////////////////// Equals

    #region Equals


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool Equals(decimal3a other) => this.x == other.x && this.y == other.y && this.z == other.z;


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override bool Equals(object? o) => o is decimal3a other && Equals(other);



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator ==(decimal3a left, decimal3a right) => left.x == right.x && left.y == right.y && left.z == right.z;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator !=(decimal3a left, decimal3a right) => left.x != right.x || left.y != right.y || left.z != right.z;



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override int GetHashCode() => HashCode.Combine(this.x, this.y, this.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public int3a Hash() => new(this.x.GetHashCode(), this.y.GetHashCode(), this.z.GetHashCode());

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    static bool3a IEqualityOperators<decimal3a, decimal3a, bool3a>.operator ==(decimal3a left, decimal3a right) => new(left.x == right.x, left.y == right.y, left.z == right.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    static bool3a IEqualityOperators<decimal3a, decimal3a, bool3a>.operator !=(decimal3a left, decimal3a right) => new(left.x != right.x, left.y != right.y, left.z != right.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool3a VEq(decimal3a other) => new(this.x == other.x, this.y == other.y, this.z == other.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool3a VNe(decimal3a other) => new(this.x != other.x, this.y != other.y, this.z != other.z);

    #endregion



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool3a operator >(decimal3a left, decimal3a right) => new(left.x > right.x, left.y > right.y, left.z > right.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool3a operator <(decimal3a left, decimal3a right) => new(left.x < right.x, left.y < right.y, left.z < right.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool3a operator >=(decimal3a left, decimal3a right) => new(left.x >= right.x, left.y >= right.y, left.z >= right.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool3a operator <=(decimal3a left, decimal3a right) => new(left.x <= right.x, left.y <= right.y, left.z <= right.z);




    //////////////////////////////////////////////////////////////////////////////////////////////////// Arithmetic

    #region Arithmetic

    public static decimal3a AdditiveIdentity 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(0m);
    }

    public static decimal3a MultiplicativeIdentity 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(1m);
    }



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal3a operator +(decimal3a left, decimal3a right) => new(left.x + right.x, left.y + right.y, left.z + right.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal3a operator -(decimal3a left, decimal3a right) => new(left.x - right.x, left.y - right.y, left.z - right.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal3a operator *(decimal3a left, decimal3a right) => new(left.x * right.x, left.y * right.y, left.z * right.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal3a operator /(decimal3a left, decimal3a right) => new(left.x / right.x, left.y / right.y, left.z / right.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal3a operator %(decimal3a left, decimal3a right) => new(left.x % right.x, left.y % right.y, left.z % right.z);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal3a operator +(decimal3a left, decimal right) => new(left.x + right, left.y + right, left.z + right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal3a operator -(decimal3a left, decimal right) => new(left.x - right, left.y - right, left.z - right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal3a operator *(decimal3a left, decimal right) => new(left.x * right, left.y * right, left.z * right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal3a operator /(decimal3a left, decimal right) => new(left.x / right, left.y / right, left.z / right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal3a operator %(decimal3a left, decimal right) => new(left.x % right, left.y % right, left.z % right);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal3a operator +(decimal left, decimal3a right) => new(left + right.x, left + right.y, left + right.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal3a operator -(decimal left, decimal3a right) => new(left - right.x, left - right.y, left - right.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal3a operator *(decimal left, decimal3a right) => new(left * right.x, left * right.y, left * right.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal3a operator /(decimal left, decimal3a right) => new(left / right.x, left / right.y, left / right.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal3a operator %(decimal left, decimal3a right) => new(left % right.x, left % right.y, left % right.z);


    
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal3a operator -(decimal3a self) => new(-self.x, -self.y, -self.z);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal3a operator +(decimal3a self) => new(+self.x, +self.y, +self.z);



    #endregion


    //////////////////////////////////////////////////////////////////////////////////////////////////// ToString

    #region ToString

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override string ToString() => $"decimal3a({this.x}, {this.y}, {this.z})";

    #endregion
}

public static unsafe partial class math
{



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal3a min(decimal3a x, decimal3a y) => new(min(x.x, y.x), min(x.y, y.y), min(x.z, y.z));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal3a max(decimal3a x, decimal3a y) => new(max(x.x, y.x), max(x.y, y.y), max(x.z, y.z));



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal3a lerp(decimal3a s, decimal3a x, decimal3a y) => x + s * (y - x);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal3a unlerp(decimal3a x, decimal3a a, decimal3a b) => (x - a) / (b - a);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal3a remap(decimal3a x, decimal3a a, decimal3a b, decimal3a c, decimal3a d) => lerp(c, d, unlerp(a, b, x));



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal3a mad(decimal3a a, decimal3a b, decimal3a c) => a * b + c;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal3a clamp(decimal3a x, decimal3a a, decimal3a b) => max(a, min(b, x));



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal3a saturate(decimal3a x) => clamp(x, decimal3a.zero, decimal3a.one);





    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal3a abs(decimal3a x) => new(abs(x.x), abs(x.y), abs(x.z));




    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal3a cross(decimal3a x, decimal3a y) => (x * y.yzx - x.yzx * y).yzx;




    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal dot(decimal3a x, decimal3a y) => x.x * y.x + x.y * y.y + x.z * y.z;










    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal3a floor(decimal3a x) => new(floor(x.x), floor(x.y), floor(x.z));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal3a ceil(decimal3a x) => new(ceil(x.x), ceil(x.y), ceil(x.z));



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal3a round(decimal3a x) => new(round(x.x), round(x.y), round(x.z));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal3a trunc(decimal3a x) => new(trunc(x.x), trunc(x.y), trunc(x.z));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal3a frac(decimal3a x) => x - floor(x);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal3a rcp(decimal3a x) => 1m / x;





    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal3a sign(decimal3a x) => new(sign(x.x), sign(x.y), sign(x.z));







    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal3a lengthsq(decimal3a x) => dot(x, x);







    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal3a distancesq(decimal3a x, decimal3a y) => lengthsq(y - x);

    
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal3a select(decimal3a a, decimal3a b, bool c) => c ? b : a;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal3a select(decimal3a a, decimal3a b, bool3a c) => new(c.x ? b.x : a.x, c.y ? b.y : a.y, c.z ? b.z : a.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal3a step(decimal3a y, decimal3a x) => select(new decimal3a(0m), new decimal3a(1m), x >= y);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal3a reflect(decimal3a i, decimal3a n) => i - 2m * n * dot(i, n);




    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal3a project(decimal3a a, decimal3a b) => (dot(a, b) / dot(b, b)) * b;

    // todo projectsafe




    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal3a faceforward(decimal3a n, decimal3a i, decimal3a ng) => select(n, -n, dot(ng, i) >= 0m);




    
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal3a radians(decimal3a x) => x * 0.0174532925199432957692369076848861271344287188854172545609719144m;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal3a degrees(decimal3a x) => x * 57.295779513082320876798154814105170332405472466564321549160243861m;






}

public class Decimal3AJsonConverter : JsonConverter<decimal3a>
{
    public override decimal3a Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        Unsafe.SkipInit(out decimal3a result);
        if (reader.TokenType is not JsonTokenType.StartArray) throw new JsonException();
        reader.Read();
        result.x = reader.GetDecimal();
        reader.Read();
        result.y = reader.GetDecimal();
        reader.Read();
        result.z = reader.GetDecimal();
        reader.Read();
        if (reader.TokenType is not JsonTokenType.EndArray) throw new JsonException();
        return result;
    }

    public override void Write(Utf8JsonWriter writer, decimal3a value, JsonSerializerOptions options)
    {
        writer.WriteStartArray();
        writer.WriteNumberValue(value.x);
        writer.WriteNumberValue(value.y);
        writer.WriteNumberValue(value.z);
        writer.WriteEndArray();
    }
}
