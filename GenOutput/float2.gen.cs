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

/// <summary>A 2 component vector of float</summary>
[Serializable]
[JsonConverter(typeof(Float2JsonConverter))]
[StructLayout(LayoutKind.Explicit, Size = 8, Pack = 4)]
public unsafe partial struct float2 : 
    IEquatable<float2>, IEqualityOperators<float2, float2, bool>, IEqualityOperators<float2, float2, bool2>,

    IAdditionOperators<float2, float2, float2>, IAdditiveIdentity<float2, float2>, IUnaryPlusOperators<float2, float2>,
    ISubtractionOperators<float2, float2, float2>, IUnaryNegationOperators<float2, float2>,
    IMultiplyOperators<float2, float2, float2>, IMultiplicativeIdentity<float2, float2>,
    IDivisionOperators<float2, float2, float2>,
    IModulusOperators<float2, float2, float2>,

    IVector2<float>, IVectorSelf<float2>
{    
    //////////////////////////////////////////////////////////////////////////////////////////////////// Fields

    #region Fields

    /// <summary>Raw simd vector</summary>
    [FieldOffset(0)]
    public Vector64<float> vector;


    /// <summary>X component of the vector</summary>
    [FieldOffset(0)]
    public float x;

    /// <summary>Y component of the vector</summary>
    [FieldOffset(4)]
    public float y;


    /// <summary>R component of the vector</summary>
    [FieldOffset(0)]
    public float r;

    /// <summary>G component of the vector</summary>
    [FieldOffset(4)]
    public float g;

    #endregion

    //////////////////////////////////////////////////////////////////////////////////////////////////// Constants

    #region Constants

    public static int ByteSize 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => 8;
    }

    public static int BitSize 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => 64;
    }

    public static readonly float2 zero = new(0f);

    public static readonly float2 one = new(1f);

    static float2 IVectorSelf<float2>.Zero 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => zero;
    }

    static float2 IVectorSelf<float2>.One 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => one;
    }

    #endregion

    //////////////////////////////////////////////////////////////////////////////////////////////////// Ctor

    #region Ctor

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public float2(Vector64<float> vector)
    {
        this.vector = vector;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public float2(float value)
    {
        this.vector = Vector64.Create(value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public float2(float x, float y)
    {
        this.vector = Vector64.Create(x, y);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator float2(float value) => new(value);

    #endregion

    //////////////////////////////////////////////////////////////////////////////////////////////////// Equals

    #region Equals


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool Equals(float2 other)
    {
        return this.vector.Equals(other.vector);
    }


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override bool Equals(object? o) => o is float2 other && Equals(other);



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator ==(float2 left, float2 right)
    {
        return left.vector.Equals(right.vector);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator !=(float2 left, float2 right)
    {
        return !left.vector.Equals(right.vector);
    }



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override int GetHashCode() => HashCode.Combine(this.x, this.y);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public int2 Hash() => new(this.x.GetHashCode(), this.y.GetHashCode());

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    static bool2 IEqualityOperators<float2, float2, bool2>.operator ==(float2 left, float2 right) => new(left.x == right.x, left.y == right.y);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    static bool2 IEqualityOperators<float2, float2, bool2>.operator !=(float2 left, float2 right) => new(left.x != right.x, left.y != right.y);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool2 VEq(float2 other) => new(this.x == other.x, this.y == other.y);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool2 VNe(float2 other) => new(this.x != other.x, this.y != other.y);

    #endregion



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool2 operator >(float2 left, float2 right) => new(left.x > right.x, left.y > right.y);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool2 operator <(float2 left, float2 right) => new(left.x < right.x, left.y < right.y);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool2 operator >=(float2 left, float2 right) => new(left.x >= right.x, left.y >= right.y);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool2 operator <=(float2 left, float2 right) => new(left.x <= right.x, left.y <= right.y);




    //////////////////////////////////////////////////////////////////////////////////////////////////// Arithmetic

    #region Arithmetic

    public static float2 AdditiveIdentity 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(0f);
    }

    public static float2 MultiplicativeIdentity 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(1f);
    }



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float2 operator +(float2 left, float2 right)
    {
        return new(left.vector + right.vector);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float2 operator -(float2 left, float2 right)
    {
        return new(left.vector - right.vector);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float2 operator *(float2 left, float2 right)
    {
        return new(left.vector * right.vector);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float2 operator /(float2 left, float2 right)
    {
        return new(left.vector / right.vector);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float2 operator %(float2 left, float2 right) => new(left.x % right.x, left.y % right.y);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float2 operator +(float2 left, float right) => left + new float2(right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float2 operator -(float2 left, float right) => left - new float2(right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float2 operator *(float2 left, float right) => left * new float2(right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float2 operator /(float2 left, float right) => left / new float2(right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float2 operator %(float2 left, float right) => left % new float2(right);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float2 operator +(float left, float2 right) => new float2(left) + right;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float2 operator -(float left, float2 right) => new float2(left) - right;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float2 operator *(float left, float2 right) => new float2(left) * right;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float2 operator /(float left, float2 right) => new float2(left) / right;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float2 operator %(float left, float2 right) => new float2(left) % right;


    
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float2 operator -(float2 self) => new(-self.x, -self.y);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float2 operator +(float2 self) => new(+self.x, +self.y);



    #endregion


    //////////////////////////////////////////////////////////////////////////////////////////////////// ToString

    #region ToString

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override string ToString() => $"float2({this.x}, {this.y})";

    #endregion
}

public static unsafe partial class math
{



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float2 min(float2 x, float2 y) => new(min(x.x, y.x), min(x.y, y.y));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float2 max(float2 x, float2 y) => new(max(x.x, y.x), max(x.y, y.y));



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float2 lerp(float2 s, float2 x, float2 y) => x + s * (y - x);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float2 unlerp(float2 x, float2 a, float2 b) => (x - a) / (b - a);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float2 remap(float2 x, float2 a, float2 b, float2 c, float2 d) => lerp(c, d, unlerp(a, b, x));



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float2 mad(float2 a, float2 b, float2 c) => a * b + c;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float2 clamp(float2 x, float2 a, float2 b) => max(a, min(b, x));



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float2 saturate(float2 x) => clamp(x, float2.zero, float2.one);





    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float2 abs(float2 x) => new(abs(x.x), abs(x.y));







    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float dot(float2 x, float2 y) => Vector64.Dot(x.vector, y.vector);






    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float2 tan(float2 x) => new(tan(x.x), tan(x.y));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float2 tanh(float2 x) => new(tanh(x.x), tanh(x.y));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float2 atan(float2 x) => new(atan(x.x), atan(x.y));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float2 atanh(float2 x) => new(tanh(x.x), tanh(x.y));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float2 atan2(float2 y, float2 x) => new(atan2(y.x, x.x), atan2(y.y, x.y));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float2 tanPi(float2 x) => new(tanPi(x.x), tanPi(x.y));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float2 atanPi(float2 x) => new(atanPi(x.x), atanPi(x.y));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float2 atan2Pi(float2 y, float2 x) => new(atan2Pi(y.x, x.x), atan2Pi(y.y, x.y));


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float2 cos(float2 x) => new(cos(x.x), cos(x.y));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float2 cosh(float2 x) => new(cosh(x.x), cosh(x.y));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float2 acos(float2 x) => new(acos(x.x), acos(x.y));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float2 acosh(float2 x) => new(acosh(x.x), acosh(x.y));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float2 cosPi(float2 x) => new(cosPi(x.x), cosPi(x.y));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float2 acosPi(float2 x) => new(acosPi(x.x), acosPi(x.y));


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float2 sin(float2 x) => new(sin(x.x), sin(x.y));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float2 sinh(float2 x) => new(sinh(x.x), sinh(x.y));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float2 asin(float2 x) => new(asin(x.x), asin(x.y));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float2 asinh(float2 x) => new(asinh(x.x), asinh(x.y));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float2 sinPi(float2 x) => new(sinPi(x.x), sinPi(x.y));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float2 asinPi(float2 x) => new(asinPi(x.x), asinPi(x.y));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void sincos(float2 x, out float2 sin, out float2 cos)
    {
        Unsafe.SkipInit(out sin);
        Unsafe.SkipInit(out cos);
        sincos(x.x, out sin.x, out cos.x); sincos(x.y, out sin.y, out cos.y);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static (float2 sin, float2 cos) sincos(float2 x)
    {
        var (s0, c0) = sincos(x.x); var (s1, c1) = sincos(x.y);
        return (new(s0, s1), new(c0, c1));
    }






    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float2 floor(float2 x) => new(Vector64.Floor(x.vector));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float2 ceil(float2 x) => new(Vector64.Ceiling(x.vector));



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float2 round(float2 x) => new(round(x.x), round(x.y));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float2 trunc(float2 x) => new(trunc(x.x), trunc(x.y));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float2 frac(float2 x) => x - floor(x);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float2 rcp(float2 x) => 1f / x;





    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float2 sign(float2 x) => new(sign(x.x), sign(x.y));





    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float2 pow(float2 x, float2 y) => new(pow(x.x, y.x), pow(x.y, y.y));


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float2 exp(float2 x) => new(exp(x.x), exp(x.y));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float2 exp2(float2 x) => new(exp2(x.x), exp2(x.y));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float2 exp10(float2 x) => new(exp10(x.x), exp10(x.y));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float2 expM1(float2 x) => new(expM1(x.x), expM1(x.y));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float2 exp2M1(float2 x) => new(exp2M1(x.x), exp2M1(x.y));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float2 exp10M1(float2 x) => new(exp10M1(x.x), exp10M1(x.y));


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float2 log(float2 x) => new(log(x.x), log(x.y));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float2 log2(float2 x) => new(log2(x.x), log2(x.y));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float2 log10(float2 x) => new(log10(x.x), log10(x.y));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float2 logP1(float2 x) => new(logP1(x.x), logP1(x.y));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float2 log2P1(float2 x) => new(log2P1(x.x), log2P1(x.y));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float2 log10P1(float2 x) => new(log10P1(x.x), log10P1(x.y));


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float2 modf(float2 x, out float2 i) 
    { 
        i = trunc(x);
        return x - i;
    }



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float2 sqrt(float2 x) => new(Vector64.Sqrt(x.vector));


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float2 rsqrt(float2 x) => 1f / sqrt(x);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float2 normalize(float2 x) => rsqrt(dot(x, x)) * x;

    // todo normalizesafe

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float2 length(float2 x) => sqrt(dot(x, x));






    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float2 lengthsq(float2 x) => dot(x, x);





    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float2 distance(float2 x, float2 y) => length(y - x);





    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float2 distancesq(float2 x, float2 y) => lengthsq(y - x);

    
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float2 select(float2 a, float2 b, bool c) => c ? b : a;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float2 select(float2 a, float2 b, bool2 c) => new(c.x ? b.x : a.x, c.y ? b.y : a.y);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float2 step(float2 y, float2 x) => select(new float2(0f), new float2(1f), x >= y);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float2 reflect(float2 i, float2 n) => i - 2f * n * dot(i, n);



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float2 reflect(float2 i, float2 n, float eta)
    {
        var ni = dot(n, i);
        var k = 1f - eta * eta * (1f - ni * ni);
        return select(0f, eta * i - (eta * ni + sqrt(k)) * n, k >= 0f);
    }




    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float2 project(float2 a, float2 b) => (dot(a, b) / dot(b, b)) * b;

    // todo projectsafe




    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float2 faceforward(float2 n, float2 i, float2 ng) => select(n, -n, dot(ng, i) >= 0f);




    
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float2 radians(float2 x) => x * 0.0174532925199432957692369076848861271344287188854172545609719144f;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float2 degrees(float2 x) => x * 57.295779513082320876798154814105170332405472466564321549160243861f;






}

public class Float2JsonConverter : JsonConverter<float2>
{
    public override float2 Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        Unsafe.SkipInit(out float2 result);
        if (reader.TokenType is not JsonTokenType.StartArray) throw new JsonException();
        reader.Read();
        result.x = reader.GetSingle();
        reader.Read();
        result.y = reader.GetSingle();
        reader.Read();
        if (reader.TokenType is not JsonTokenType.EndArray) throw new JsonException();
        return result;
    }

    public override void Write(Utf8JsonWriter writer, float2 value, JsonSerializerOptions options)
    {
        writer.WriteStartArray();
        writer.WriteNumberValue(value.x);
        writer.WriteNumberValue(value.y);
        writer.WriteEndArray();
    }
}
