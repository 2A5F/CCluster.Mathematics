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

/// <summary>A 3 component vector of double</summary>
[Serializable]
[JsonConverter(typeof(Double3JsonConverter))]
[StructLayout(LayoutKind.Explicit, Size = 32)]
public unsafe partial struct double3 : 
    IEquatable<double3>, IEqualityOperators<double3, double3, bool>, IEqualityOperators<double3, double3, bool3>,

    IAdditionOperators<double3, double3, double3>, IAdditiveIdentity<double3, double3>, IUnaryPlusOperators<double3, double3>,
    ISubtractionOperators<double3, double3, double3>, IUnaryNegationOperators<double3, double3>,
    IMultiplyOperators<double3, double3, double3>, IMultiplicativeIdentity<double3, double3>,
    IDivisionOperators<double3, double3, double3>,
    IModulusOperators<double3, double3, double3>,

    IVector3<double>, IVectorSelf<double3>
{

    /// <summary>Raw simd vector</summary>
    [FieldOffset(0)]
    public Vector256<double> vector;


    /// <summary>X component of the vector</summary>
    [FieldOffset(0)]
    public double x;

    /// <summary>Y component of the vector</summary>
    [FieldOffset(8)]
    public double y;

    /// <summary>Z component of the vector</summary>
    [FieldOffset(16)]
    public double z;


    /// <summary>R component of the vector</summary>
    [FieldOffset(0)]
    public double r;

    /// <summary>G component of the vector</summary>
    [FieldOffset(8)]
    public double g;

    /// <summary>B component of the vector</summary>
    [FieldOffset(16)]
    public double b;


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

    public static readonly double3 zero = new(0d);

    public static readonly double3 one = new(1d);

    static double3 IVectorSelf<double3>.Zero 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => zero;
    }

    static double3 IVectorSelf<double3>.One 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => one;
    }


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public double3(Vector256<double> vector)
    {
        this.vector = vector;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public double3(double value)
    {
        this.vector = Vector256.Create(value);
    }


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public double3(double x, double y, double z)
    {

        this.vector = Vector256.Create(x, y, z, 0d);

    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator double3(double value) => new(value);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool Equals(double3 other)
    {
        return this.vector.Equals(other.vector);
    }


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override bool Equals(object? o) => o is double3 other && Equals(other);



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator ==(double3 left, double3 right)
    {
        return left.vector.Equals(right.vector);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator !=(double3 left, double3 right)
    {
        return !left.vector.Equals(right.vector);
    }



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override int GetHashCode() => HashCode.Combine(this.x, this.y, this.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public int3 Hash() => new(this.x.GetHashCode(), this.y.GetHashCode(), this.z.GetHashCode());

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    static bool3 IEqualityOperators<double3, double3, bool3>.operator ==(double3 left, double3 right) => new(left.x == right.x, left.y == right.y, left.z == right.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    static bool3 IEqualityOperators<double3, double3, bool3>.operator !=(double3 left, double3 right) => new(left.x != right.x, left.y != right.y, left.z != right.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool3 VEq(double3 other) => new(this.x == other.x, this.y == other.y, this.z == other.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool3 VNe(double3 other) => new(this.x != other.x, this.y != other.y, this.z != other.z);



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool3 operator >(double3 left, double3 right) => new(left.x > right.x, left.y > right.y, left.z > right.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool3 operator <(double3 left, double3 right) => new(left.x < right.x, left.y < right.y, left.z < right.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool3 operator >=(double3 left, double3 right) => new(left.x >= right.x, left.y >= right.y, left.z >= right.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool3 operator <=(double3 left, double3 right) => new(left.x <= right.x, left.y <= right.y, left.z <= right.z);




    public static double3 AdditiveIdentity 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(0d);
    }

    public static double3 MultiplicativeIdentity 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(1d);
    }



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3 operator +(double3 left, double3 right)
    {
        return new(left.vector + right.vector);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3 operator -(double3 left, double3 right)
    {
        return new(left.vector - right.vector);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3 operator *(double3 left, double3 right)
    {
        return new(left.vector * right.vector);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3 operator /(double3 left, double3 right)
    {
        return new(left.vector / right.vector);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3 operator %(double3 left, double3 right) => new(left.x % right.x, left.y % right.y, left.z % right.z);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3 operator +(double3 left, double right) => left + new double3(right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3 operator -(double3 left, double right) => left - new double3(right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3 operator *(double3 left, double right) => left * new double3(right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3 operator /(double3 left, double right) => left / new double3(right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3 operator %(double3 left, double right) => left % new double3(right);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3 operator +(double left, double3 right) => new double3(left) + right;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3 operator -(double left, double3 right) => new double3(left) - right;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3 operator *(double left, double3 right) => new double3(left) * right;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3 operator /(double left, double3 right) => new double3(left) / right;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3 operator %(double left, double3 right) => new double3(left) % right;


    
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3 operator -(double3 self) => new(-self.x, -self.y, -self.z);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3 operator +(double3 self) => new(+self.x, +self.y, +self.z);





    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override string ToString() => $"double3({this.x}, {this.y}, {this.z})";

}

public static unsafe partial class math
{



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3 min(double3 x, double3 y) => new(min(x.x, y.x), min(x.y, y.y), min(x.z, y.z));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3 max(double3 x, double3 y) => new(max(x.x, y.x), max(x.y, y.y), max(x.z, y.z));



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3 lerp(double3 s, double3 x, double3 y) => x + s * (y - x);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3 unlerp(double3 x, double3 a, double3 b) => (x - a) / (b - a);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3 remap(double3 x, double3 a, double3 b, double3 c, double3 d) => lerp(c, d, unlerp(a, b, x));



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3 mad(double3 a, double3 b, double3 c) => a * b + c;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3 clamp(double3 x, double3 a, double3 b) => max(a, min(b, x));



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3 saturate(double3 x) => clamp(x, double3.zero, double3.one);





    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3 abs(double3 x) => new(abs(x.x), abs(x.y), abs(x.z));




    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3 cross(double3 x, double3 y) => (x * y.yzx - x.yzx * y).yzx;




    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double dot(double3 x, double3 y) => Vector256.Dot(x.vector, y.vector);






    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3 tan(double3 x) => new(tan(x.x), tan(x.y), tan(x.z));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3 tanh(double3 x) => new(tanh(x.x), tanh(x.y), tanh(x.z));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3 atan(double3 x) => new(atan(x.x), atan(x.y), atan(x.z));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3 atanh(double3 x) => new(tanh(x.x), tanh(x.y), tanh(x.z));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3 atan2(double3 y, double3 x) => new(atan2(y.x, x.x), atan2(y.y, x.y), atan2(y.z, x.z));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3 tanPi(double3 x) => new(tanPi(x.x), tanPi(x.y), tanPi(x.z));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3 atanPi(double3 x) => new(atanPi(x.x), atanPi(x.y), atanPi(x.z));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3 atan2Pi(double3 y, double3 x) => new(atan2Pi(y.x, x.x), atan2Pi(y.y, x.y), atan2Pi(y.z, x.z));


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3 cos(double3 x) => new(cos(x.x), cos(x.y), cos(x.z));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3 cosh(double3 x) => new(cosh(x.x), cosh(x.y), cosh(x.z));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3 acos(double3 x) => new(acos(x.x), acos(x.y), acos(x.z));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3 acosh(double3 x) => new(acosh(x.x), acosh(x.y), acosh(x.z));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3 cosPi(double3 x) => new(cosPi(x.x), cosPi(x.y), cosPi(x.z));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3 acosPi(double3 x) => new(acosPi(x.x), acosPi(x.y), acosPi(x.z));


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3 sin(double3 x) => new(sin(x.x), sin(x.y), sin(x.z));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3 sinh(double3 x) => new(sinh(x.x), sinh(x.y), sinh(x.z));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3 asin(double3 x) => new(asin(x.x), asin(x.y), asin(x.z));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3 asinh(double3 x) => new(asinh(x.x), asinh(x.y), asinh(x.z));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3 sinPi(double3 x) => new(sinPi(x.x), sinPi(x.y), sinPi(x.z));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3 asinPi(double3 x) => new(asinPi(x.x), asinPi(x.y), asinPi(x.z));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void sincos(double3 x, out double3 sin, out double3 cos)
    {
        Unsafe.SkipInit(out sin);
        Unsafe.SkipInit(out cos);
        sincos(x.x, out sin.x, out cos.x); sincos(x.y, out sin.y, out cos.y); sincos(x.z, out sin.z, out cos.z);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static (double3 sin, double3 cos) sincos(double3 x)
    {
        var (s0, c0) = sincos(x.x); var (s1, c1) = sincos(x.y); var (s2, c2) = sincos(x.z);
        return (new(s0, s1, s2), new(c0, c1, c2));
    }






    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3 floor(double3 x) => new(Vector256.Floor(x.vector));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3 ceil(double3 x) => new(Vector256.Ceiling(x.vector));



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3 round(double3 x) => new(round(x.x), round(x.y), round(x.z));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3 trunc(double3 x) => new(trunc(x.x), trunc(x.y), trunc(x.z));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3 frac(double3 x) => x - floor(x);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3 rcp(double3 x) => 1d / x;





    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3 sign(double3 x) => new(sign(x.x), sign(x.y), sign(x.z));





    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3 pow(double3 x, double3 y) => new(pow(x.x, y.x), pow(x.y, y.y), pow(x.z, y.z));


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3 exp(double3 x) => new(exp(x.x), exp(x.y), exp(x.z));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3 exp2(double3 x) => new(exp2(x.x), exp2(x.y), exp2(x.z));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3 exp10(double3 x) => new(exp10(x.x), exp10(x.y), exp10(x.z));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3 expM1(double3 x) => new(expM1(x.x), expM1(x.y), expM1(x.z));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3 exp2M1(double3 x) => new(exp2M1(x.x), exp2M1(x.y), exp2M1(x.z));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3 exp10M1(double3 x) => new(exp10M1(x.x), exp10M1(x.y), exp10M1(x.z));


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3 log(double3 x) => new(log(x.x), log(x.y), log(x.z));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3 log2(double3 x) => new(log2(x.x), log2(x.y), log2(x.z));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3 log10(double3 x) => new(log10(x.x), log10(x.y), log10(x.z));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3 logP1(double3 x) => new(logP1(x.x), logP1(x.y), logP1(x.z));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3 log2P1(double3 x) => new(log2P1(x.x), log2P1(x.y), log2P1(x.z));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3 log10P1(double3 x) => new(log10P1(x.x), log10P1(x.y), log10P1(x.z));


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3 modf(double3 x, out double3 i) 
    { 
        i = trunc(x);
        return x - i;
    }



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3 sqrt(double3 x) => new(Vector256.Sqrt(x.vector));


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3 rsqrt(double3 x) => 1d / sqrt(x);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3 normalize(double3 x) => rsqrt(dot(x, x)) * x;

    // todo normalizesafe

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3 length(double3 x) => sqrt(dot(x, x));






    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3 lengthsq(double3 x) => dot(x, x);





    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3 distance(double3 x, double3 y) => length(y - x);





    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3 distancesq(double3 x, double3 y) => lengthsq(y - x);

    
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3 select(double3 a, double3 b, bool c) => c ? b : a;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3 select(double3 a, double3 b, bool3 c) => new(c.x ? b.x : a.x, c.y ? b.y : a.y, c.z ? b.z : a.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3 step(double3 y, double3 x) => select(new double3(0d), new double3(1d), x >= y);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3 reflect(double3 i, double3 n) => i - 2d * n * dot(i, n);



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3 reflect(double3 i, double3 n, double eta)
    {
        var ni = dot(n, i);
        var k = 1d - eta * eta * (1d - ni * ni);
        return select(0d, eta * i - (eta * ni + sqrt(k)) * n, k >= 0d);
    }




    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3 project(double3 a, double3 b) => (dot(a, b) / dot(b, b)) * b;

    // todo projectsafe




    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3 faceforward(double3 n, double3 i, double3 ng) => select(n, -n, dot(ng, i) >= 0d);




    
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3 radians(double3 x) => x * 0.0174532925199432957692369076848861271344287188854172545609719144d;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3 degrees(double3 x) => x * 57.295779513082320876798154814105170332405472466564321549160243861d;






}

public class Double3JsonConverter : JsonConverter<double3>
{
    public override double3 Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        Unsafe.SkipInit(out double3 result);
        if (reader.TokenType is not JsonTokenType.StartArray) throw new JsonException();
        reader.Read();
        result.x = reader.GetDouble();
        reader.Read();
        result.y = reader.GetDouble();
        reader.Read();
        result.z = reader.GetDouble();
        reader.Read();
        if (reader.TokenType is not JsonTokenType.EndArray) throw new JsonException();
        return result;
    }

    public override void Write(Utf8JsonWriter writer, double3 value, JsonSerializerOptions options)
    {
        writer.WriteStartArray();
        writer.WriteNumberValue(value.x);
        writer.WriteNumberValue(value.y);
        writer.WriteNumberValue(value.z);
        writer.WriteEndArray();
    }
}
