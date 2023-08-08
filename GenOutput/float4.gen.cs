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

/// <summary>A 4 component vector of float</summary>
[Serializable]
[JsonConverter(typeof(Float4JsonConverter))]
[StructLayout(LayoutKind.Explicit, Size = 16, Pack = 4)]
public unsafe partial struct float4 : 
    IEquatable<float4>, IEqualityOperators<float4, float4, bool>, IEqualityOperators<float4, float4, bool4>,

    IAdditionOperators<float4, float4, float4>, IAdditiveIdentity<float4, float4>, IUnaryPlusOperators<float4, float4>,
    ISubtractionOperators<float4, float4, float4>, IUnaryNegationOperators<float4, float4>,
    IMultiplyOperators<float4, float4, float4>, IMultiplicativeIdentity<float4, float4>,
    IDivisionOperators<float4, float4, float4>,
    IModulusOperators<float4, float4, float4>,

    IVector4<float>, IVectorSelf<float4>
{    
    //////////////////////////////////////////////////////////////////////////////////////////////////// Fields

    #region Fields

    /// <summary>Raw simd vector</summary>
    [FieldOffset(0)]
    public Vector128<float> vector;


    /// <summary>X component of the vector</summary>
    [FieldOffset(0)]
    public float x;

    /// <summary>Y component of the vector</summary>
    [FieldOffset(4)]
    public float y;

    /// <summary>Z component of the vector</summary>
    [FieldOffset(8)]
    public float z;

    /// <summary>W component of the vector</summary>
    [FieldOffset(12)]
    public float w;


    /// <summary>R component of the vector</summary>
    [FieldOffset(0)]
    public float r;

    /// <summary>G component of the vector</summary>
    [FieldOffset(4)]
    public float g;

    /// <summary>B component of the vector</summary>
    [FieldOffset(8)]
    public float b;

    /// <summary>A component of the vector</summary>
    [FieldOffset(12)]
    public float a;

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

    public static readonly float4 zero = new(0f);

    public static readonly float4 one = new(1f);

    static float4 IVectorSelf<float4>.Zero 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => zero;
    }

    static float4 IVectorSelf<float4>.One 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => one;
    }

    #endregion

    //////////////////////////////////////////////////////////////////////////////////////////////////// Ctor

    #region Ctor

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public float4(Vector128<float> vector)
    {
        this.vector = vector;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public float4(float value)
    {
        this.vector = Vector128.Create(value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public float4(float x, float y, float z, float w)
    {
        this.vector = Vector128.Create(x, y, z, w);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public float4(float2 xy, float2 zw) : this(xy.x, xy.y, zw.x, zw.y) { }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public float4(float2 xy, float z, float w) : this(xy.x, xy.y, z, w) { }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public float4(float x, float2 yz, float w) : this(x, yz.x, yz.y, w) { }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public float4(float x, float y, float2 zw) : this(x, y, zw.x, zw.y) { }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public float4(float3 xyz, float w) : this(xyz.x, xyz.y, xyz.z, w) { }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public float4(float x, float3 yzw) : this(x, yzw.x, yzw.y, yzw.z) { }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator float4(float value) => new(value);

    #endregion

    //////////////////////////////////////////////////////////////////////////////////////////////////// Equals

    #region Equals


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool Equals(float4 other)
    {
        return this.vector.Equals(other.vector);
    }


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override bool Equals(object? o) => o is float4 other && Equals(other);



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator ==(float4 left, float4 right)
    {
        return left.vector.Equals(right.vector);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator !=(float4 left, float4 right)
    {
        return !left.vector.Equals(right.vector);
    }



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override int GetHashCode() => HashCode.Combine(this.x, this.y, this.z, this.w);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public int4 Hash() => new(this.x.GetHashCode(), this.y.GetHashCode(), this.z.GetHashCode(), this.w.GetHashCode());

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    static bool4 IEqualityOperators<float4, float4, bool4>.operator ==(float4 left, float4 right) => new(left.x == right.x, left.y == right.y, left.z == right.z, left.w == right.w);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    static bool4 IEqualityOperators<float4, float4, bool4>.operator !=(float4 left, float4 right) => new(left.x != right.x, left.y != right.y, left.z != right.z, left.w != right.w);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool4 VEq(float4 other) => new(this.x == other.x, this.y == other.y, this.z == other.z, this.w == other.w);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool4 VNe(float4 other) => new(this.x != other.x, this.y != other.y, this.z != other.z, this.w != other.w);

    #endregion



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool4 operator >(float4 left, float4 right) => new(left.x > right.x, left.y > right.y, left.z > right.z, left.w > right.w);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool4 operator <(float4 left, float4 right) => new(left.x < right.x, left.y < right.y, left.z < right.z, left.w < right.w);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool4 operator >=(float4 left, float4 right) => new(left.x >= right.x, left.y >= right.y, left.z >= right.z, left.w >= right.w);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool4 operator <=(float4 left, float4 right) => new(left.x <= right.x, left.y <= right.y, left.z <= right.z, left.w <= right.w);




    //////////////////////////////////////////////////////////////////////////////////////////////////// Arithmetic

    #region Arithmetic

    public static float4 AdditiveIdentity 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(0f);
    }

    public static float4 MultiplicativeIdentity 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(1f);
    }



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float4 operator +(float4 left, float4 right)
    {
        return new(left.vector + right.vector);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float4 operator -(float4 left, float4 right)
    {
        return new(left.vector - right.vector);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float4 operator *(float4 left, float4 right)
    {
        return new(left.vector * right.vector);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float4 operator /(float4 left, float4 right)
    {
        return new(left.vector / right.vector);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float4 operator %(float4 left, float4 right) => new(left.x % right.x, left.y % right.y, left.z % right.z, left.w % right.w);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float4 operator +(float4 left, float right) => left + new float4(right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float4 operator -(float4 left, float right) => left - new float4(right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float4 operator *(float4 left, float right) => left * new float4(right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float4 operator /(float4 left, float right) => left / new float4(right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float4 operator %(float4 left, float right) => left % new float4(right);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float4 operator +(float left, float4 right) => new float4(left) + right;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float4 operator -(float left, float4 right) => new float4(left) - right;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float4 operator *(float left, float4 right) => new float4(left) * right;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float4 operator /(float left, float4 right) => new float4(left) / right;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float4 operator %(float left, float4 right) => new float4(left) % right;


    
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float4 operator -(float4 self) => new(-self.x, -self.y, -self.z, -self.w);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float4 operator +(float4 self) => new(+self.x, +self.y, +self.z, +self.w);



    #endregion


    //////////////////////////////////////////////////////////////////////////////////////////////////// ToString

    #region ToString

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override string ToString() => $"float4({this.x}, {this.y}, {this.z}, {this.w})";

    #endregion
}

public static unsafe partial class math
{



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float4 min(float4 x, float4 y) => new(min(x.x, y.x), min(x.y, y.y), min(x.z, y.z), min(x.w, y.w));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float4 max(float4 x, float4 y) => new(max(x.x, y.x), max(x.y, y.y), max(x.z, y.z), max(x.w, y.w));



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float4 lerp(float4 s, float4 x, float4 y) => x + s * (y - x);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float4 unlerp(float4 x, float4 a, float4 b) => (x - a) / (b - a);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float4 remap(float4 x, float4 a, float4 b, float4 c, float4 d) => lerp(c, d, unlerp(a, b, x));



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float4 mad(float4 a, float4 b, float4 c) => a * b + c;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float4 clamp(float4 x, float4 a, float4 b) => max(a, min(b, x));



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float4 saturate(float4 x) => clamp(x, float4.zero, float4.one);





    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float4 abs(float4 x) => new(abs(x.x), abs(x.y), abs(x.z), abs(x.w));







    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float dot(float4 x, float4 y) => Vector128.Dot(x.vector, y.vector);






    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float4 tan(float4 x) => new(tan(x.x), tan(x.y), tan(x.z), tan(x.w));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float4 tanh(float4 x) => new(tanh(x.x), tanh(x.y), tanh(x.z), tanh(x.w));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float4 atan(float4 x) => new(atan(x.x), atan(x.y), atan(x.z), atan(x.w));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float4 atanh(float4 x) => new(tanh(x.x), tanh(x.y), tanh(x.z), tanh(x.w));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float4 atan2(float4 y, float4 x) => new(atan2(y.x, x.x), atan2(y.y, x.y), atan2(y.z, x.z), atan2(y.w, x.w));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float4 tanPi(float4 x) => new(tanPi(x.x), tanPi(x.y), tanPi(x.z), tanPi(x.w));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float4 atanPi(float4 x) => new(atanPi(x.x), atanPi(x.y), atanPi(x.z), atanPi(x.w));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float4 atan2Pi(float4 y, float4 x) => new(atan2Pi(y.x, x.x), atan2Pi(y.y, x.y), atan2Pi(y.z, x.z), atan2Pi(y.w, x.w));


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float4 cos(float4 x) => new(cos(x.x), cos(x.y), cos(x.z), cos(x.w));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float4 cosh(float4 x) => new(cosh(x.x), cosh(x.y), cosh(x.z), cosh(x.w));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float4 acos(float4 x) => new(acos(x.x), acos(x.y), acos(x.z), acos(x.w));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float4 acosh(float4 x) => new(acosh(x.x), acosh(x.y), acosh(x.z), acosh(x.w));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float4 cosPi(float4 x) => new(cosPi(x.x), cosPi(x.y), cosPi(x.z), cosPi(x.w));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float4 acosPi(float4 x) => new(acosPi(x.x), acosPi(x.y), acosPi(x.z), acosPi(x.w));


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float4 sin(float4 x) => new(sin(x.x), sin(x.y), sin(x.z), sin(x.w));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float4 sinh(float4 x) => new(sinh(x.x), sinh(x.y), sinh(x.z), sinh(x.w));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float4 asin(float4 x) => new(asin(x.x), asin(x.y), asin(x.z), asin(x.w));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float4 asinh(float4 x) => new(asinh(x.x), asinh(x.y), asinh(x.z), asinh(x.w));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float4 sinPi(float4 x) => new(sinPi(x.x), sinPi(x.y), sinPi(x.z), sinPi(x.w));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float4 asinPi(float4 x) => new(asinPi(x.x), asinPi(x.y), asinPi(x.z), asinPi(x.w));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void sincos(float4 x, out float4 sin, out float4 cos)
    {
        Unsafe.SkipInit(out sin);
        Unsafe.SkipInit(out cos);
        sincos(x.x, out sin.x, out cos.x); sincos(x.y, out sin.y, out cos.y); sincos(x.z, out sin.z, out cos.z); sincos(x.w, out sin.w, out cos.w);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static (float4 sin, float4 cos) sincos(float4 x)
    {
        var (s0, c0) = sincos(x.x); var (s1, c1) = sincos(x.y); var (s2, c2) = sincos(x.z); var (s3, c3) = sincos(x.w);
        return (new(s0, s1, s2, s3), new(c0, c1, c2, c3));
    }






    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float4 floor(float4 x) => new(Vector128.Floor(x.vector));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float4 ceil(float4 x) => new(Vector128.Ceiling(x.vector));



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float4 round(float4 x) => new(round(x.x), round(x.y), round(x.z), round(x.w));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float4 trunc(float4 x) => new(trunc(x.x), trunc(x.y), trunc(x.z), trunc(x.w));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float4 frac(float4 x) => x - floor(x);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float4 rcp(float4 x) => 1f / x;





    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float4 sign(float4 x) => new(sign(x.x), sign(x.y), sign(x.z), sign(x.w));





    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float4 pow(float4 x, float4 y) => new(pow(x.x, y.x), pow(x.y, y.y), pow(x.z, y.z), pow(x.w, y.w));


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float4 exp(float4 x) => new(exp(x.x), exp(x.y), exp(x.z), exp(x.w));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float4 exp2(float4 x) => new(exp2(x.x), exp2(x.y), exp2(x.z), exp2(x.w));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float4 exp10(float4 x) => new(exp10(x.x), exp10(x.y), exp10(x.z), exp10(x.w));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float4 expM1(float4 x) => new(expM1(x.x), expM1(x.y), expM1(x.z), expM1(x.w));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float4 exp2M1(float4 x) => new(exp2M1(x.x), exp2M1(x.y), exp2M1(x.z), exp2M1(x.w));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float4 exp10M1(float4 x) => new(exp10M1(x.x), exp10M1(x.y), exp10M1(x.z), exp10M1(x.w));


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float4 log(float4 x) => new(log(x.x), log(x.y), log(x.z), log(x.w));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float4 log2(float4 x) => new(log2(x.x), log2(x.y), log2(x.z), log2(x.w));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float4 log10(float4 x) => new(log10(x.x), log10(x.y), log10(x.z), log10(x.w));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float4 logP1(float4 x) => new(logP1(x.x), logP1(x.y), logP1(x.z), logP1(x.w));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float4 log2P1(float4 x) => new(log2P1(x.x), log2P1(x.y), log2P1(x.z), log2P1(x.w));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float4 log10P1(float4 x) => new(log10P1(x.x), log10P1(x.y), log10P1(x.z), log10P1(x.w));


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float4 modf(float4 x, out float4 i) 
    { 
        i = trunc(x);
        return x - i;
    }



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float4 sqrt(float4 x) => new(Vector128.Sqrt(x.vector));


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float4 rsqrt(float4 x) => 1f / sqrt(x);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float4 normalize(float4 x) => rsqrt(dot(x, x)) * x;

    // todo normalizesafe

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float4 length(float4 x) => sqrt(dot(x, x));






    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float4 lengthsq(float4 x) => dot(x, x);





    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float4 distance(float4 x, float4 y) => length(y - x);





    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float4 distancesq(float4 x, float4 y) => lengthsq(y - x);

    
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float4 select(float4 a, float4 b, bool c) => c ? b : a;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float4 select(float4 a, float4 b, bool4 c) => new(c.x ? b.x : a.x, c.y ? b.y : a.y, c.z ? b.z : a.z, c.w ? b.w : a.w);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float4 step(float4 y, float4 x) => select(new float4(0f), new float4(1f), x >= y);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float4 reflect(float4 i, float4 n) => i - 2f * n * dot(i, n);



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float4 reflect(float4 i, float4 n, float eta)
    {
        var ni = dot(n, i);
        var k = 1f - eta * eta * (1f - ni * ni);
        return select(0f, eta * i - (eta * ni + sqrt(k)) * n, k >= 0f);
    }




    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float4 project(float4 a, float4 b) => (dot(a, b) / dot(b, b)) * b;

    // todo projectsafe




    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float4 faceforward(float4 n, float4 i, float4 ng) => select(n, -n, dot(ng, i) >= 0f);




    
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float4 radians(float4 x) => x * 0.0174532925199432957692369076848861271344287188854172545609719144f;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float4 degrees(float4 x) => x * 57.295779513082320876798154814105170332405472466564321549160243861f;






}

public class Float4JsonConverter : JsonConverter<float4>
{
    public override float4 Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        Unsafe.SkipInit(out float4 result);
        if (reader.TokenType is not JsonTokenType.StartArray) throw new JsonException();
        reader.Read();
        result.x = reader.GetSingle();
        reader.Read();
        result.y = reader.GetSingle();
        reader.Read();
        result.z = reader.GetSingle();
        reader.Read();
        result.w = reader.GetSingle();
        reader.Read();
        if (reader.TokenType is not JsonTokenType.EndArray) throw new JsonException();
        return result;
    }

    public override void Write(Utf8JsonWriter writer, float4 value, JsonSerializerOptions options)
    {
        writer.WriteStartArray();
        writer.WriteNumberValue(value.x);
        writer.WriteNumberValue(value.y);
        writer.WriteNumberValue(value.z);
        writer.WriteNumberValue(value.w);
        writer.WriteEndArray();
    }
}
