using System;
using System.Numerics;
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.X86;
using System.Runtime.Intrinsics.Arm;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

#nullable enable
#pragma warning disable CS8981

namespace CCluster.Mathematics;

[Serializable]
[StructLayout(LayoutKind.Explicit, Size = 4)]
public unsafe partial struct Half2a : 
    IEquatable<Half2a>, IEqualityOperators<Half2a, Half2a, bool>, IEqualityOperators<Half2a, Half2a, bool2>,

    IAdditionOperators<Half2a, Half2a, Half2a>, IAdditiveIdentity<Half2a, Half2a>, IUnaryPlusOperators<Half2a, Half2a>,
    ISubtractionOperators<Half2a, Half2a, Half2a>, IUnaryNegationOperators<Half2a, Half2a>,
    IMultiplyOperators<Half2a, Half2a, Half2a>, IMultiplicativeIdentity<Half2a, Half2a>,
    IDivisionOperators<Half2a, Half2a, Half2a>,
    IModulusOperators<Half2a, Half2a, Half2a>,

    IVector, IVector2, IVector<Half>, IVector2<Half>
{

    [FieldOffset(0)]
    public Half x;

    [FieldOffset(2)]
    public Half y;

    [FieldOffset(0)]
    public Half r;

    [FieldOffset(2)]
    public Half g;


    public static int ByteSize 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => 4;
    }

    public static int BitSize 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => 32;
    }

    public static Half2a Zero
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new Half2a(Half.Zero);
    }

    public static Half2a One
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new Half2a(Half.One);
    }


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public Half2a(Half value) : this(value, value) { }


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public Half2a(Half x, Half y)
    {

        this.x = x;

        this.y = y;

    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator Half2a(Half value) => new Half2a(value);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool Equals(Half2a other) => this.x == other.x && this.y == other.y;


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override bool Equals(object? o) => o is Half2a other && Equals(other);



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator ==(Half2a left, Half2a right) => left.x == right.x && left.y == right.y;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator !=(Half2a left, Half2a right) => left.x != right.x || left.y != right.y;



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override int GetHashCode() => HashCode.Combine(this.x, this.y);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public int2 Hash() => new int2(this.x.GetHashCode(), this.y.GetHashCode());

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    static bool2 IEqualityOperators<Half2a, Half2a, bool2>.operator ==(Half2a left, Half2a right) => new bool2(left.x == right.x, left.y == right.y);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    static bool2 IEqualityOperators<Half2a, Half2a, bool2>.operator !=(Half2a left, Half2a right) => new bool2(left.x != right.x, left.y != right.y);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool2 VEq(Half2a other) => new bool2(this.x == other.x, this.y == other.y);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool2 VNe(Half2a other) => new bool2(this.x != other.x, this.y != other.y);



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool2 operator >(Half2a left, Half2a right) => new bool2(left.x > right.x, left.y > right.y);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool2 operator <(Half2a left, Half2a right) => new bool2(left.x < right.x, left.y < right.y);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool2 operator >=(Half2a left, Half2a right) => new bool2(left.x >= right.x, left.y >= right.y);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool2 operator <=(Half2a left, Half2a right) => new bool2(left.x <= right.x, left.y <= right.y);




    public static Half2a AdditiveIdentity 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new Half2a(Half.Zero);
    }

    public static Half2a MultiplicativeIdentity 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new Half2a(Half.One);
    }



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half2a operator +(Half2a left, Half2a right) => new Half2a(left.x + right.x, left.y + right.y);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half2a operator -(Half2a left, Half2a right) => new Half2a(left.x - right.x, left.y - right.y);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half2a operator *(Half2a left, Half2a right) => new Half2a(left.x * right.x, left.y * right.y);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half2a operator /(Half2a left, Half2a right) => new Half2a(left.x / right.x, left.y / right.y);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half2a operator %(Half2a left, Half2a right) => new Half2a(left.x % right.x, left.y % right.y);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half2a operator +(Half2a left, Half right) => new Half2a(left.x + right, left.y + right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half2a operator -(Half2a left, Half right) => new Half2a(left.x - right, left.y - right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half2a operator *(Half2a left, Half right) => new Half2a(left.x * right, left.y * right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half2a operator /(Half2a left, Half right) => new Half2a(left.x / right, left.y / right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half2a operator %(Half2a left, Half right) => new Half2a(left.x % right, left.y % right);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half2a operator +(Half left, Half2a right) => new Half2a(left + right.x, left + right.y);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half2a operator -(Half left, Half2a right) => new Half2a(left - right.x, left - right.y);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half2a operator *(Half left, Half2a right) => new Half2a(left * right.x, left * right.y);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half2a operator /(Half left, Half2a right) => new Half2a(left / right.x, left / right.y);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half2a operator %(Half left, Half2a right) => new Half2a(left % right.x, left % right.y);


    
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half2a operator -(Half2a self) => new Half2a(-self.x, -self.y);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half2a operator +(Half2a self) => new Half2a(+self.x, +self.y);





    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override string ToString() => $"Half2a({this.x}, {this.y})";

}

public static unsafe partial class math
{



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half2a min(Half2a x, Half2a y) => new Half2a(min(x.x, y.x), min(x.y, y.y));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half2a max(Half2a x, Half2a y) => new Half2a(max(x.x, y.x), max(x.y, y.y));



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half2a lerp(Half2a s, Half2a x, Half2a y) => x + s * (y - x);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half2a unlerp(Half2a x, Half2a a, Half2a b) => (x - a) / (b - a);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half2a remap(Half2a x, Half2a a, Half2a b, Half2a c, Half2a d) => lerp(c, d, unlerp(a, b, x));



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half2a mad(Half2a a, Half2a b, Half2a c) => a * b + c;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half2a clamp(Half2a x, Half2a a, Half2a b) => max(a, min(b, x));



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half2a saturate(Half2a x) => clamp(x, Half2a.Zero, Half2a.One);





    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half2a abs(Half2a x) => new Half2a(abs(x.x), abs(x.y));







    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half dot(Half2a x, Half2a y) => x.x * y.x + x.y * y.y;






    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half2a tan(Half2a x) => new Half2a(tan(x.x), tan(x.y));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half2a tanh(Half2a x) => new Half2a(tanh(x.x), tanh(x.y));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half2a atan(Half2a x) => new Half2a(atan(x.x), atan(x.y));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half2a atanh(Half2a x) => new Half2a(tanh(x.x), tanh(x.y));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half2a atan2(Half2a y, Half2a x) => new Half2a(atan2(y.x, x.x), atan2(y.y, x.y));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half2a tanPi(Half2a x) => new Half2a(tanPi(x.x), tanPi(x.y));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half2a atanPi(Half2a x) => new Half2a(atanPi(x.x), atanPi(x.y));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half2a atan2Pi(Half2a y, Half2a x) => new Half2a(atan2Pi(y.x, x.x), atan2Pi(y.y, x.y));


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half2a cos(Half2a x) => new Half2a(cos(x.x), cos(x.y));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half2a cosh(Half2a x) => new Half2a(cosh(x.x), cosh(x.y));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half2a acos(Half2a x) => new Half2a(acos(x.x), acos(x.y));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half2a acosh(Half2a x) => new Half2a(acosh(x.x), acosh(x.y));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half2a cosPi(Half2a x) => new Half2a(cosPi(x.x), cosPi(x.y));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half2a acosPi(Half2a x) => new Half2a(acosPi(x.x), acosPi(x.y));


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half2a sin(Half2a x) => new Half2a(sin(x.x), sin(x.y));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half2a sinh(Half2a x) => new Half2a(sinh(x.x), sinh(x.y));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half2a asin(Half2a x) => new Half2a(asin(x.x), asin(x.y));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half2a asinh(Half2a x) => new Half2a(asinh(x.x), asinh(x.y));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half2a sinPi(Half2a x) => new Half2a(sinPi(x.x), sinPi(x.y));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half2a asinPi(Half2a x) => new Half2a(asinPi(x.x), asinPi(x.y));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void sincos(Half2a x, out Half2a sin, out Half2a cos)
    {
        Unsafe.SkipInit(out sin);
        Unsafe.SkipInit(out cos);
        sincos(x.x, out sin.x, out cos.x); sincos(x.y, out sin.y, out cos.y);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static (Half2a sin, Half2a cos) sincos(Half2a x)
    {
        var (s0, c0) = sincos(x.x); var (s1, c1) = sincos(x.y);
        return (new Half2a(s0, s1), new Half2a(c0, c1));
    }






    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half2a floor(Half2a x) => new Half2a(floor(x.x), floor(x.y));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half2a ceil(Half2a x) => new Half2a(ceil(x.x), ceil(x.y));



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half2a round(Half2a x) => new Half2a(round(x.x), round(x.y));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half2a trunc(Half2a x) => new Half2a(trunc(x.x), trunc(x.y));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half2a frac(Half2a x) => x - floor(x);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half2a rcp(Half2a x) => Half.One / x;





    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half2a sign(Half2a x) => new Half2a(sign(x.x), sign(x.y));





    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half2a pow(Half2a x, Half2a y) => new Half2a(pow(x.x, y.x), pow(x.y, y.y));


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half2a exp(Half2a x) => new Half2a(exp(x.x), exp(x.y));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half2a exp2(Half2a x) => new Half2a(exp2(x.x), exp2(x.y));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half2a exp10(Half2a x) => new Half2a(exp10(x.x), exp10(x.y));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half2a expM1(Half2a x) => new Half2a(expM1(x.x), expM1(x.y));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half2a exp2M1(Half2a x) => new Half2a(exp2M1(x.x), exp2M1(x.y));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half2a exp10M1(Half2a x) => new Half2a(exp10M1(x.x), exp10M1(x.y));


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half2a log(Half2a x) => new Half2a(log(x.x), log(x.y));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half2a log2(Half2a x) => new Half2a(log2(x.x), log2(x.y));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half2a log10(Half2a x) => new Half2a(log10(x.x), log10(x.y));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half2a logP1(Half2a x) => new Half2a(logP1(x.x), logP1(x.y));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half2a log2P1(Half2a x) => new Half2a(log2P1(x.x), log2P1(x.y));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half2a log10P1(Half2a x) => new Half2a(log10P1(x.x), log10P1(x.y));


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half2a modf(Half2a x, out Half2a i) 
    { 
        i = trunc(x);
        return x - i;
    }



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half2a sqrt(Half2a x) => new Half2a(sqrt(x.x), sqrt(x.y));


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half2a rsqrt(Half2a x) => Half.One / sqrt(x);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half2a normalize(Half2a x) => rsqrt(dot(x, x)) * x;

    // todo normalizesafe

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half2a length(Half2a x) => sqrt(dot(x, x));






    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half2a lengthsq(Half2a x) => dot(x, x);





    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half2a distance(Half2a x, Half2a y) => length(y - x);





    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half2a distancesq(Half2a x, Half2a y) => lengthsq(y - x);

    
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half2a select(Half2a a, Half2a b, bool c) => c ? b : a;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half2a select(Half2a a, Half2a b, bool2 c) => new Half2a(c.x ? b.x : a.x, c.y ? b.y : a.y);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half2a step(Half2a y, Half2a x) => select(new Half2a(Half.Zero), new Half2a(Half.One), x >= y);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half2a reflect(Half2a i, Half2a n) => i - (Half.One + Half.One) * n * dot(i, n);



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half2a reflect(Half2a i, Half2a n, Half eta)
    {
        var ni = dot(n, i);
        var k = Half.One - eta * eta * (Half.One - ni * ni);
        return select(Half.Zero, eta * i - (eta * ni + sqrt(k)) * n, k >= Half.Zero);
    }




    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half2a project(Half2a a, Half2a b) => (dot(a, b) / dot(b, b)) * b;

    // todo projectsafe




    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half2a faceforward(Half2a n, Half2a i, Half2a ng) => select(n, -n, dot(ng, i) >= Half.Zero);




    
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half2a radians(Half2a x) => x * (Half)0.0174532925199432957692369076848861271344287188854172545609719144;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half2a degrees(Half2a x) => x * (Half)57.295779513082320876798154814105170332405472466564321549160243861;






}
