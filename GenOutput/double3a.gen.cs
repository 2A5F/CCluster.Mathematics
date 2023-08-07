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
[JsonConverter(typeof(Double3AConverter))]
[StructLayout(LayoutKind.Explicit, Size = 24)]
public unsafe partial struct double3a : 
    IEquatable<double3a>, IEqualityOperators<double3a, double3a, bool>, IEqualityOperators<double3a, double3a, bool3>,

    IAdditionOperators<double3a, double3a, double3a>, IAdditiveIdentity<double3a, double3a>, IUnaryPlusOperators<double3a, double3a>,
    ISubtractionOperators<double3a, double3a, double3a>, IUnaryNegationOperators<double3a, double3a>,
    IMultiplyOperators<double3a, double3a, double3a>, IMultiplicativeIdentity<double3a, double3a>,
    IDivisionOperators<double3a, double3a, double3a>,
    IModulusOperators<double3a, double3a, double3a>,

    IVector, IVector3, IVector<double>, IVector3<double>
{

    [FieldOffset(0)]
    public double x;

    [FieldOffset(8)]
    public double y;

    [FieldOffset(16)]
    public double z;

    [FieldOffset(0)]
    public double r;

    [FieldOffset(8)]
    public double g;

    [FieldOffset(16)]
    public double b;


    public static int ByteSize 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => 24;
    }

    public static int BitSize 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => 192;
    }

    public static double3a Zero
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new double3a(0d);
    }

    public static double3a One
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new double3a(1d);
    }


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public double3a(double value) : this(value, value, value) { }


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public double3a(double x, double y, double z)
    {

        this.x = x;

        this.y = y;

        this.z = z;

    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator double3a(double value) => new double3a(value);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool Equals(double3a other) => this.x == other.x && this.y == other.y && this.z == other.z;


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override bool Equals(object? o) => o is double3a other && Equals(other);



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator ==(double3a left, double3a right) => left.x == right.x && left.y == right.y && left.z == right.z;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator !=(double3a left, double3a right) => left.x != right.x || left.y != right.y || left.z != right.z;



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override int GetHashCode() => HashCode.Combine(this.x, this.y, this.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public int3 Hash() => new int3(this.x.GetHashCode(), this.y.GetHashCode(), this.z.GetHashCode());

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    static bool3 IEqualityOperators<double3a, double3a, bool3>.operator ==(double3a left, double3a right) => new bool3(left.x == right.x, left.y == right.y, left.z == right.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    static bool3 IEqualityOperators<double3a, double3a, bool3>.operator !=(double3a left, double3a right) => new bool3(left.x != right.x, left.y != right.y, left.z != right.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool3 VEq(double3a other) => new bool3(this.x == other.x, this.y == other.y, this.z == other.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool3 VNe(double3a other) => new bool3(this.x != other.x, this.y != other.y, this.z != other.z);



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool3 operator >(double3a left, double3a right) => new bool3(left.x > right.x, left.y > right.y, left.z > right.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool3 operator <(double3a left, double3a right) => new bool3(left.x < right.x, left.y < right.y, left.z < right.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool3 operator >=(double3a left, double3a right) => new bool3(left.x >= right.x, left.y >= right.y, left.z >= right.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool3 operator <=(double3a left, double3a right) => new bool3(left.x <= right.x, left.y <= right.y, left.z <= right.z);




    public static double3a AdditiveIdentity 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new double3a(0d);
    }

    public static double3a MultiplicativeIdentity 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new double3a(1d);
    }



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3a operator +(double3a left, double3a right) => new double3a(left.x + right.x, left.y + right.y, left.z + right.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3a operator -(double3a left, double3a right) => new double3a(left.x - right.x, left.y - right.y, left.z - right.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3a operator *(double3a left, double3a right) => new double3a(left.x * right.x, left.y * right.y, left.z * right.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3a operator /(double3a left, double3a right) => new double3a(left.x / right.x, left.y / right.y, left.z / right.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3a operator %(double3a left, double3a right) => new double3a(left.x % right.x, left.y % right.y, left.z % right.z);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3a operator +(double3a left, double right) => new double3a(left.x + right, left.y + right, left.z + right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3a operator -(double3a left, double right) => new double3a(left.x - right, left.y - right, left.z - right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3a operator *(double3a left, double right) => new double3a(left.x * right, left.y * right, left.z * right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3a operator /(double3a left, double right) => new double3a(left.x / right, left.y / right, left.z / right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3a operator %(double3a left, double right) => new double3a(left.x % right, left.y % right, left.z % right);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3a operator +(double left, double3a right) => new double3a(left + right.x, left + right.y, left + right.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3a operator -(double left, double3a right) => new double3a(left - right.x, left - right.y, left - right.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3a operator *(double left, double3a right) => new double3a(left * right.x, left * right.y, left * right.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3a operator /(double left, double3a right) => new double3a(left / right.x, left / right.y, left / right.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3a operator %(double left, double3a right) => new double3a(left % right.x, left % right.y, left % right.z);


    
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3a operator -(double3a self) => new double3a(-self.x, -self.y, -self.z);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3a operator +(double3a self) => new double3a(+self.x, +self.y, +self.z);





    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override string ToString() => $"double3a({this.x}, {this.y}, {this.z})";

}

public static unsafe partial class math
{



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3a min(double3a x, double3a y) => new double3a(min(x.x, y.x), min(x.y, y.y), min(x.z, y.z));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3a max(double3a x, double3a y) => new double3a(max(x.x, y.x), max(x.y, y.y), max(x.z, y.z));



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3a lerp(double3a s, double3a x, double3a y) => x + s * (y - x);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3a unlerp(double3a x, double3a a, double3a b) => (x - a) / (b - a);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3a remap(double3a x, double3a a, double3a b, double3a c, double3a d) => lerp(c, d, unlerp(a, b, x));



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3a mad(double3a a, double3a b, double3a c) => a * b + c;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3a clamp(double3a x, double3a a, double3a b) => max(a, min(b, x));



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3a saturate(double3a x) => clamp(x, double3a.Zero, double3a.One);





    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3a abs(double3a x) => new double3a(abs(x.x), abs(x.y), abs(x.z));




    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3a cross(double3a x, double3a y) => (x * y.yzx - x.yzx * y).yzx;




    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double dot(double3a x, double3a y) => x.x * y.x + x.y * y.y + x.z * y.z;






    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3a tan(double3a x) => new double3a(tan(x.x), tan(x.y), tan(x.z));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3a tanh(double3a x) => new double3a(tanh(x.x), tanh(x.y), tanh(x.z));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3a atan(double3a x) => new double3a(atan(x.x), atan(x.y), atan(x.z));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3a atanh(double3a x) => new double3a(tanh(x.x), tanh(x.y), tanh(x.z));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3a atan2(double3a y, double3a x) => new double3a(atan2(y.x, x.x), atan2(y.y, x.y), atan2(y.z, x.z));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3a tanPi(double3a x) => new double3a(tanPi(x.x), tanPi(x.y), tanPi(x.z));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3a atanPi(double3a x) => new double3a(atanPi(x.x), atanPi(x.y), atanPi(x.z));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3a atan2Pi(double3a y, double3a x) => new double3a(atan2Pi(y.x, x.x), atan2Pi(y.y, x.y), atan2Pi(y.z, x.z));


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3a cos(double3a x) => new double3a(cos(x.x), cos(x.y), cos(x.z));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3a cosh(double3a x) => new double3a(cosh(x.x), cosh(x.y), cosh(x.z));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3a acos(double3a x) => new double3a(acos(x.x), acos(x.y), acos(x.z));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3a acosh(double3a x) => new double3a(acosh(x.x), acosh(x.y), acosh(x.z));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3a cosPi(double3a x) => new double3a(cosPi(x.x), cosPi(x.y), cosPi(x.z));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3a acosPi(double3a x) => new double3a(acosPi(x.x), acosPi(x.y), acosPi(x.z));


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3a sin(double3a x) => new double3a(sin(x.x), sin(x.y), sin(x.z));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3a sinh(double3a x) => new double3a(sinh(x.x), sinh(x.y), sinh(x.z));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3a asin(double3a x) => new double3a(asin(x.x), asin(x.y), asin(x.z));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3a asinh(double3a x) => new double3a(asinh(x.x), asinh(x.y), asinh(x.z));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3a sinPi(double3a x) => new double3a(sinPi(x.x), sinPi(x.y), sinPi(x.z));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3a asinPi(double3a x) => new double3a(asinPi(x.x), asinPi(x.y), asinPi(x.z));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void sincos(double3a x, out double3a sin, out double3a cos)
    {
        Unsafe.SkipInit(out sin);
        Unsafe.SkipInit(out cos);
        sincos(x.x, out sin.x, out cos.x); sincos(x.y, out sin.y, out cos.y); sincos(x.z, out sin.z, out cos.z);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static (double3a sin, double3a cos) sincos(double3a x)
    {
        var (s0, c0) = sincos(x.x); var (s1, c1) = sincos(x.y); var (s2, c2) = sincos(x.z);
        return (new double3a(s0, s1, s2), new double3a(c0, c1, c2));
    }






    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3a floor(double3a x) => new double3a(floor(x.x), floor(x.y), floor(x.z));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3a ceil(double3a x) => new double3a(ceil(x.x), ceil(x.y), ceil(x.z));



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3a round(double3a x) => new double3a(round(x.x), round(x.y), round(x.z));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3a trunc(double3a x) => new double3a(trunc(x.x), trunc(x.y), trunc(x.z));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3a frac(double3a x) => x - floor(x);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3a rcp(double3a x) => 1d / x;





    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3a sign(double3a x) => new double3a(sign(x.x), sign(x.y), sign(x.z));





    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3a pow(double3a x, double3a y) => new double3a(pow(x.x, y.x), pow(x.y, y.y), pow(x.z, y.z));


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3a exp(double3a x) => new double3a(exp(x.x), exp(x.y), exp(x.z));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3a exp2(double3a x) => new double3a(exp2(x.x), exp2(x.y), exp2(x.z));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3a exp10(double3a x) => new double3a(exp10(x.x), exp10(x.y), exp10(x.z));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3a expM1(double3a x) => new double3a(expM1(x.x), expM1(x.y), expM1(x.z));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3a exp2M1(double3a x) => new double3a(exp2M1(x.x), exp2M1(x.y), exp2M1(x.z));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3a exp10M1(double3a x) => new double3a(exp10M1(x.x), exp10M1(x.y), exp10M1(x.z));


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3a log(double3a x) => new double3a(log(x.x), log(x.y), log(x.z));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3a log2(double3a x) => new double3a(log2(x.x), log2(x.y), log2(x.z));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3a log10(double3a x) => new double3a(log10(x.x), log10(x.y), log10(x.z));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3a logP1(double3a x) => new double3a(logP1(x.x), logP1(x.y), logP1(x.z));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3a log2P1(double3a x) => new double3a(log2P1(x.x), log2P1(x.y), log2P1(x.z));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3a log10P1(double3a x) => new double3a(log10P1(x.x), log10P1(x.y), log10P1(x.z));


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3a modf(double3a x, out double3a i) 
    { 
        i = trunc(x);
        return x - i;
    }



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3a sqrt(double3a x) => new double3a(sqrt(x.x), sqrt(x.y), sqrt(x.z));


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3a rsqrt(double3a x) => 1d / sqrt(x);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3a normalize(double3a x) => rsqrt(dot(x, x)) * x;

    // todo normalizesafe

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3a length(double3a x) => sqrt(dot(x, x));






    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3a lengthsq(double3a x) => dot(x, x);





    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3a distance(double3a x, double3a y) => length(y - x);





    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3a distancesq(double3a x, double3a y) => lengthsq(y - x);

    
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3a select(double3a a, double3a b, bool c) => c ? b : a;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3a select(double3a a, double3a b, bool3 c) => new double3a(c.x ? b.x : a.x, c.y ? b.y : a.y, c.z ? b.z : a.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3a step(double3a y, double3a x) => select(new double3a(0d), new double3a(1d), x >= y);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3a reflect(double3a i, double3a n) => i - 2d * n * dot(i, n);



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3a reflect(double3a i, double3a n, double eta)
    {
        var ni = dot(n, i);
        var k = 1d - eta * eta * (1d - ni * ni);
        return select(0d, eta * i - (eta * ni + sqrt(k)) * n, k >= 0d);
    }




    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3a project(double3a a, double3a b) => (dot(a, b) / dot(b, b)) * b;

    // todo projectsafe




    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3a faceforward(double3a n, double3a i, double3a ng) => select(n, -n, dot(ng, i) >= 0d);




    
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3a radians(double3a x) => x * 0.0174532925199432957692369076848861271344287188854172545609719144d;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3a degrees(double3a x) => x * 57.295779513082320876798154814105170332405472466564321549160243861d;






}

public class Double3AConverter : JsonConverter<double3a>
{
    public override double3a Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        Unsafe.SkipInit(out double3a result);
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

    public override void Write(Utf8JsonWriter writer, double3a value, JsonSerializerOptions options)
    {
        writer.WriteStartArray();
        writer.WriteNumberValue(value.x);
        writer.WriteNumberValue(value.y);
        writer.WriteNumberValue(value.z);
        writer.WriteEndArray();
    }
}
