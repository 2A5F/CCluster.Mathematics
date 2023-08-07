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
[JsonConverter(typeof(Float3AConverter))]
[StructLayout(LayoutKind.Explicit, Size = 12)]
public unsafe partial struct float3a : 
    IEquatable<float3a>, IEqualityOperators<float3a, float3a, bool>, IEqualityOperators<float3a, float3a, bool3>,

    IAdditionOperators<float3a, float3a, float3a>, IAdditiveIdentity<float3a, float3a>, IUnaryPlusOperators<float3a, float3a>,
    ISubtractionOperators<float3a, float3a, float3a>, IUnaryNegationOperators<float3a, float3a>,
    IMultiplyOperators<float3a, float3a, float3a>, IMultiplicativeIdentity<float3a, float3a>,
    IDivisionOperators<float3a, float3a, float3a>,
    IModulusOperators<float3a, float3a, float3a>,

    IVector, IVector3, IVector<float>, IVector3<float>
{

    [FieldOffset(0)]
    public float x;

    [FieldOffset(4)]
    public float y;

    [FieldOffset(8)]
    public float z;

    [FieldOffset(0)]
    public float r;

    [FieldOffset(4)]
    public float g;

    [FieldOffset(8)]
    public float b;


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

    public static float3a Zero
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new float3a(0f);
    }

    public static float3a One
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new float3a(1f);
    }


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public float3a(float value) : this(value, value, value) { }


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public float3a(float x, float y, float z)
    {

        this.x = x;

        this.y = y;

        this.z = z;

    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator float3a(float value) => new float3a(value);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool Equals(float3a other) => this.x == other.x && this.y == other.y && this.z == other.z;


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override bool Equals(object? o) => o is float3a other && Equals(other);



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator ==(float3a left, float3a right) => left.x == right.x && left.y == right.y && left.z == right.z;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator !=(float3a left, float3a right) => left.x != right.x || left.y != right.y || left.z != right.z;



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override int GetHashCode() => HashCode.Combine(this.x, this.y, this.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public int3 Hash() => new int3(this.x.GetHashCode(), this.y.GetHashCode(), this.z.GetHashCode());

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    static bool3 IEqualityOperators<float3a, float3a, bool3>.operator ==(float3a left, float3a right) => new bool3(left.x == right.x, left.y == right.y, left.z == right.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    static bool3 IEqualityOperators<float3a, float3a, bool3>.operator !=(float3a left, float3a right) => new bool3(left.x != right.x, left.y != right.y, left.z != right.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool3 VEq(float3a other) => new bool3(this.x == other.x, this.y == other.y, this.z == other.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool3 VNe(float3a other) => new bool3(this.x != other.x, this.y != other.y, this.z != other.z);



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool3 operator >(float3a left, float3a right) => new bool3(left.x > right.x, left.y > right.y, left.z > right.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool3 operator <(float3a left, float3a right) => new bool3(left.x < right.x, left.y < right.y, left.z < right.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool3 operator >=(float3a left, float3a right) => new bool3(left.x >= right.x, left.y >= right.y, left.z >= right.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool3 operator <=(float3a left, float3a right) => new bool3(left.x <= right.x, left.y <= right.y, left.z <= right.z);




    public static float3a AdditiveIdentity 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new float3a(0f);
    }

    public static float3a MultiplicativeIdentity 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new float3a(1f);
    }



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3a operator +(float3a left, float3a right) => new float3a(left.x + right.x, left.y + right.y, left.z + right.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3a operator -(float3a left, float3a right) => new float3a(left.x - right.x, left.y - right.y, left.z - right.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3a operator *(float3a left, float3a right) => new float3a(left.x * right.x, left.y * right.y, left.z * right.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3a operator /(float3a left, float3a right) => new float3a(left.x / right.x, left.y / right.y, left.z / right.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3a operator %(float3a left, float3a right) => new float3a(left.x % right.x, left.y % right.y, left.z % right.z);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3a operator +(float3a left, float right) => new float3a(left.x + right, left.y + right, left.z + right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3a operator -(float3a left, float right) => new float3a(left.x - right, left.y - right, left.z - right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3a operator *(float3a left, float right) => new float3a(left.x * right, left.y * right, left.z * right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3a operator /(float3a left, float right) => new float3a(left.x / right, left.y / right, left.z / right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3a operator %(float3a left, float right) => new float3a(left.x % right, left.y % right, left.z % right);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3a operator +(float left, float3a right) => new float3a(left + right.x, left + right.y, left + right.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3a operator -(float left, float3a right) => new float3a(left - right.x, left - right.y, left - right.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3a operator *(float left, float3a right) => new float3a(left * right.x, left * right.y, left * right.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3a operator /(float left, float3a right) => new float3a(left / right.x, left / right.y, left / right.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3a operator %(float left, float3a right) => new float3a(left % right.x, left % right.y, left % right.z);


    
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3a operator -(float3a self) => new float3a(-self.x, -self.y, -self.z);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3a operator +(float3a self) => new float3a(+self.x, +self.y, +self.z);





    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override string ToString() => $"float3a({this.x}, {this.y}, {this.z})";

}

public static unsafe partial class math
{



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3a min(float3a x, float3a y) => new float3a(min(x.x, y.x), min(x.y, y.y), min(x.z, y.z));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3a max(float3a x, float3a y) => new float3a(max(x.x, y.x), max(x.y, y.y), max(x.z, y.z));



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3a lerp(float3a s, float3a x, float3a y) => x + s * (y - x);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3a unlerp(float3a x, float3a a, float3a b) => (x - a) / (b - a);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3a remap(float3a x, float3a a, float3a b, float3a c, float3a d) => lerp(c, d, unlerp(a, b, x));



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3a mad(float3a a, float3a b, float3a c) => a * b + c;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3a clamp(float3a x, float3a a, float3a b) => max(a, min(b, x));



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3a saturate(float3a x) => clamp(x, float3a.Zero, float3a.One);





    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3a abs(float3a x) => new float3a(abs(x.x), abs(x.y), abs(x.z));




    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3a cross(float3a x, float3a y) => (x * y.yzx - x.yzx * y).yzx;




    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float dot(float3a x, float3a y) => x.x * y.x + x.y * y.y + x.z * y.z;






    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3a tan(float3a x) => new float3a(tan(x.x), tan(x.y), tan(x.z));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3a tanh(float3a x) => new float3a(tanh(x.x), tanh(x.y), tanh(x.z));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3a atan(float3a x) => new float3a(atan(x.x), atan(x.y), atan(x.z));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3a atanh(float3a x) => new float3a(tanh(x.x), tanh(x.y), tanh(x.z));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3a atan2(float3a y, float3a x) => new float3a(atan2(y.x, x.x), atan2(y.y, x.y), atan2(y.z, x.z));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3a tanPi(float3a x) => new float3a(tanPi(x.x), tanPi(x.y), tanPi(x.z));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3a atanPi(float3a x) => new float3a(atanPi(x.x), atanPi(x.y), atanPi(x.z));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3a atan2Pi(float3a y, float3a x) => new float3a(atan2Pi(y.x, x.x), atan2Pi(y.y, x.y), atan2Pi(y.z, x.z));


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3a cos(float3a x) => new float3a(cos(x.x), cos(x.y), cos(x.z));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3a cosh(float3a x) => new float3a(cosh(x.x), cosh(x.y), cosh(x.z));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3a acos(float3a x) => new float3a(acos(x.x), acos(x.y), acos(x.z));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3a acosh(float3a x) => new float3a(acosh(x.x), acosh(x.y), acosh(x.z));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3a cosPi(float3a x) => new float3a(cosPi(x.x), cosPi(x.y), cosPi(x.z));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3a acosPi(float3a x) => new float3a(acosPi(x.x), acosPi(x.y), acosPi(x.z));


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3a sin(float3a x) => new float3a(sin(x.x), sin(x.y), sin(x.z));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3a sinh(float3a x) => new float3a(sinh(x.x), sinh(x.y), sinh(x.z));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3a asin(float3a x) => new float3a(asin(x.x), asin(x.y), asin(x.z));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3a asinh(float3a x) => new float3a(asinh(x.x), asinh(x.y), asinh(x.z));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3a sinPi(float3a x) => new float3a(sinPi(x.x), sinPi(x.y), sinPi(x.z));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3a asinPi(float3a x) => new float3a(asinPi(x.x), asinPi(x.y), asinPi(x.z));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void sincos(float3a x, out float3a sin, out float3a cos)
    {
        Unsafe.SkipInit(out sin);
        Unsafe.SkipInit(out cos);
        sincos(x.x, out sin.x, out cos.x); sincos(x.y, out sin.y, out cos.y); sincos(x.z, out sin.z, out cos.z);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static (float3a sin, float3a cos) sincos(float3a x)
    {
        var (s0, c0) = sincos(x.x); var (s1, c1) = sincos(x.y); var (s2, c2) = sincos(x.z);
        return (new float3a(s0, s1, s2), new float3a(c0, c1, c2));
    }






    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3a floor(float3a x) => new float3a(floor(x.x), floor(x.y), floor(x.z));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3a ceil(float3a x) => new float3a(ceil(x.x), ceil(x.y), ceil(x.z));



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3a round(float3a x) => new float3a(round(x.x), round(x.y), round(x.z));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3a trunc(float3a x) => new float3a(trunc(x.x), trunc(x.y), trunc(x.z));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3a frac(float3a x) => x - floor(x);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3a rcp(float3a x) => 1f / x;





    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3a sign(float3a x) => new float3a(sign(x.x), sign(x.y), sign(x.z));





    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3a pow(float3a x, float3a y) => new float3a(pow(x.x, y.x), pow(x.y, y.y), pow(x.z, y.z));


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3a exp(float3a x) => new float3a(exp(x.x), exp(x.y), exp(x.z));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3a exp2(float3a x) => new float3a(exp2(x.x), exp2(x.y), exp2(x.z));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3a exp10(float3a x) => new float3a(exp10(x.x), exp10(x.y), exp10(x.z));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3a expM1(float3a x) => new float3a(expM1(x.x), expM1(x.y), expM1(x.z));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3a exp2M1(float3a x) => new float3a(exp2M1(x.x), exp2M1(x.y), exp2M1(x.z));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3a exp10M1(float3a x) => new float3a(exp10M1(x.x), exp10M1(x.y), exp10M1(x.z));


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3a log(float3a x) => new float3a(log(x.x), log(x.y), log(x.z));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3a log2(float3a x) => new float3a(log2(x.x), log2(x.y), log2(x.z));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3a log10(float3a x) => new float3a(log10(x.x), log10(x.y), log10(x.z));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3a logP1(float3a x) => new float3a(logP1(x.x), logP1(x.y), logP1(x.z));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3a log2P1(float3a x) => new float3a(log2P1(x.x), log2P1(x.y), log2P1(x.z));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3a log10P1(float3a x) => new float3a(log10P1(x.x), log10P1(x.y), log10P1(x.z));


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3a modf(float3a x, out float3a i) 
    { 
        i = trunc(x);
        return x - i;
    }



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3a sqrt(float3a x) => new float3a(sqrt(x.x), sqrt(x.y), sqrt(x.z));


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3a rsqrt(float3a x) => 1f / sqrt(x);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3a normalize(float3a x) => rsqrt(dot(x, x)) * x;

    // todo normalizesafe

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3a length(float3a x) => sqrt(dot(x, x));






    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3a lengthsq(float3a x) => dot(x, x);





    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3a distance(float3a x, float3a y) => length(y - x);





    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3a distancesq(float3a x, float3a y) => lengthsq(y - x);

    
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3a select(float3a a, float3a b, bool c) => c ? b : a;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3a select(float3a a, float3a b, bool3 c) => new float3a(c.x ? b.x : a.x, c.y ? b.y : a.y, c.z ? b.z : a.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3a step(float3a y, float3a x) => select(new float3a(0f), new float3a(1f), x >= y);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3a reflect(float3a i, float3a n) => i - 2f * n * dot(i, n);



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3a reflect(float3a i, float3a n, float eta)
    {
        var ni = dot(n, i);
        var k = 1f - eta * eta * (1f - ni * ni);
        return select(0f, eta * i - (eta * ni + sqrt(k)) * n, k >= 0f);
    }




    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3a project(float3a a, float3a b) => (dot(a, b) / dot(b, b)) * b;

    // todo projectsafe




    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3a faceforward(float3a n, float3a i, float3a ng) => select(n, -n, dot(ng, i) >= 0f);




    
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3a radians(float3a x) => x * 0.0174532925199432957692369076848861271344287188854172545609719144f;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3a degrees(float3a x) => x * 57.295779513082320876798154814105170332405472466564321549160243861f;






}

public class Float3AConverter : JsonConverter<float3a>
{
    public override float3a Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        Unsafe.SkipInit(out float3a result);
        if (reader.TokenType is not JsonTokenType.StartArray) throw new JsonException();
        reader.Read();
        result.x = reader.GetSingle();
        reader.Read();
        result.y = reader.GetSingle();
        reader.Read();
        result.z = reader.GetSingle();
        reader.Read();
        if (reader.TokenType is not JsonTokenType.EndArray) throw new JsonException();
        return result;
    }

    public override void Write(Utf8JsonWriter writer, float3a value, JsonSerializerOptions options)
    {
        writer.WriteStartArray();
        writer.WriteNumberValue(value.x);
        writer.WriteNumberValue(value.y);
        writer.WriteNumberValue(value.z);
        writer.WriteEndArray();
    }
}
