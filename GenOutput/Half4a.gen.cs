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
[StructLayout(LayoutKind.Explicit, Size = 8)]
public unsafe partial struct Half4a : 
    IEquatable<Half4a>, IEqualityOperators<Half4a, Half4a, bool>, IEqualityOperators<Half4a, Half4a, bool4>,

    IAdditionOperators<Half4a, Half4a, Half4a>, IAdditiveIdentity<Half4a, Half4a>, IUnaryPlusOperators<Half4a, Half4a>,
    ISubtractionOperators<Half4a, Half4a, Half4a>, IUnaryNegationOperators<Half4a, Half4a>,
    IMultiplyOperators<Half4a, Half4a, Half4a>, IMultiplicativeIdentity<Half4a, Half4a>,
    IDivisionOperators<Half4a, Half4a, Half4a>,
    IModulusOperators<Half4a, Half4a, Half4a>,

    IVector, IVector4, IVector<Half>, IVector4<Half>
{

    [FieldOffset(0)]
    public Half x;

    [FieldOffset(2)]
    public Half y;

    [FieldOffset(4)]
    public Half z;

    [FieldOffset(6)]
    public Half w;

    [FieldOffset(0)]
    public Half r;

    [FieldOffset(2)]
    public Half g;

    [FieldOffset(4)]
    public Half b;

    [FieldOffset(6)]
    public Half a;


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

    public static Half4a Zero
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new Half4a(Half.Zero);
    }

    public static Half4a One
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new Half4a(Half.One);
    }


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public Half4a(Half value) : this(value, value, value, value) { }


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public Half4a(Half x, Half y, Half z, Half w)
    {

        this.x = x;

        this.y = y;

        this.z = z;

        this.w = w;

    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator Half4a(Half value) => new Half4a(value);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool Equals(Half4a other) => this.x == other.x && this.y == other.y && this.z == other.z && this.w == other.w;


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override bool Equals(object? o) => o is Half4a other && Equals(other);



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator ==(Half4a left, Half4a right) => left.x == right.x && left.y == right.y && left.z == right.z && left.w == right.w;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator !=(Half4a left, Half4a right) => left.x != right.x || left.y != right.y || left.z != right.z || left.w != right.w;



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override int GetHashCode() => HashCode.Combine(this.x, this.y, this.z, this.w);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public int4 Hash() => new int4(this.x.GetHashCode(), this.y.GetHashCode(), this.z.GetHashCode(), this.w.GetHashCode());

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    static bool4 IEqualityOperators<Half4a, Half4a, bool4>.operator ==(Half4a left, Half4a right) => new bool4(left.x == right.x, left.y == right.y, left.z == right.z, left.w == right.w);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    static bool4 IEqualityOperators<Half4a, Half4a, bool4>.operator !=(Half4a left, Half4a right) => new bool4(left.x != right.x, left.y != right.y, left.z != right.z, left.w != right.w);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool4 VEq(Half4a other) => new bool4(this.x == other.x, this.y == other.y, this.z == other.z, this.w == other.w);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool4 VNe(Half4a other) => new bool4(this.x != other.x, this.y != other.y, this.z != other.z, this.w != other.w);



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool4 operator >(Half4a left, Half4a right) => new bool4(left.x > right.x, left.y > right.y, left.z > right.z, left.w > right.w);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool4 operator <(Half4a left, Half4a right) => new bool4(left.x < right.x, left.y < right.y, left.z < right.z, left.w < right.w);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool4 operator >=(Half4a left, Half4a right) => new bool4(left.x >= right.x, left.y >= right.y, left.z >= right.z, left.w >= right.w);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool4 operator <=(Half4a left, Half4a right) => new bool4(left.x <= right.x, left.y <= right.y, left.z <= right.z, left.w <= right.w);




    public static Half4a AdditiveIdentity 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new Half4a(Half.Zero);
    }

    public static Half4a MultiplicativeIdentity 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new Half4a(Half.One);
    }



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4a operator +(Half4a left, Half4a right) => new Half4a(left.x + right.x, left.y + right.y, left.z + right.z, left.w + right.w);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4a operator -(Half4a left, Half4a right) => new Half4a(left.x - right.x, left.y - right.y, left.z - right.z, left.w - right.w);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4a operator *(Half4a left, Half4a right) => new Half4a(left.x * right.x, left.y * right.y, left.z * right.z, left.w * right.w);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4a operator /(Half4a left, Half4a right) => new Half4a(left.x / right.x, left.y / right.y, left.z / right.z, left.w / right.w);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4a operator %(Half4a left, Half4a right) => new Half4a(left.x % right.x, left.y % right.y, left.z % right.z, left.w % right.w);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4a operator +(Half4a left, Half right) => new Half4a(left.x + right, left.y + right, left.z + right, left.w + right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4a operator -(Half4a left, Half right) => new Half4a(left.x - right, left.y - right, left.z - right, left.w - right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4a operator *(Half4a left, Half right) => new Half4a(left.x * right, left.y * right, left.z * right, left.w * right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4a operator /(Half4a left, Half right) => new Half4a(left.x / right, left.y / right, left.z / right, left.w / right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4a operator %(Half4a left, Half right) => new Half4a(left.x % right, left.y % right, left.z % right, left.w % right);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4a operator +(Half left, Half4a right) => new Half4a(left + right.x, left + right.y, left + right.z, left + right.w);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4a operator -(Half left, Half4a right) => new Half4a(left - right.x, left - right.y, left - right.z, left - right.w);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4a operator *(Half left, Half4a right) => new Half4a(left * right.x, left * right.y, left * right.z, left * right.w);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4a operator /(Half left, Half4a right) => new Half4a(left / right.x, left / right.y, left / right.z, left / right.w);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4a operator %(Half left, Half4a right) => new Half4a(left % right.x, left % right.y, left % right.z, left % right.w);


    
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4a operator -(Half4a self) => new Half4a(-self.x, -self.y, -self.z, -self.w);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4a operator +(Half4a self) => new Half4a(+self.x, +self.y, +self.z, +self.w);





    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override string ToString() => $"Half4a({this.x}, {this.y}, {this.z}, {this.w})";

}

public static unsafe partial class math
{



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4a min(Half4a x, Half4a y) => new Half4a(min(x.x, y.x), min(x.y, y.y), min(x.z, y.z), min(x.w, y.w));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4a max(Half4a x, Half4a y) => new Half4a(max(x.x, y.x), max(x.y, y.y), max(x.z, y.z), max(x.w, y.w));



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4a lerp(Half4a s, Half4a x, Half4a y) => x + s * (y - x);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4a unlerp(Half4a x, Half4a a, Half4a b) => (x - a) / (b - a);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4a remap(Half4a x, Half4a a, Half4a b, Half4a c, Half4a d) => lerp(c, d, unlerp(a, b, x));



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4a mad(Half4a a, Half4a b, Half4a c) => a * b + c;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4a clamp(Half4a x, Half4a a, Half4a b) => max(a, min(b, x));



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4a saturate(Half4a x) => clamp(x, Half4a.Zero, Half4a.One);





    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4a abs(Half4a x) => new Half4a(abs(x.x), abs(x.y), abs(x.z), abs(x.w));







    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half dot(Half4a x, Half4a y) => x.x * y.x + x.y * y.y + x.z * y.z + x.w * y.w;






    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4a tan(Half4a x) => new Half4a(tan(x.x), tan(x.y), tan(x.z), tan(x.w));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4a tanh(Half4a x) => new Half4a(tanh(x.x), tanh(x.y), tanh(x.z), tanh(x.w));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4a atan(Half4a x) => new Half4a(atan(x.x), atan(x.y), atan(x.z), atan(x.w));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4a atanh(Half4a x) => new Half4a(tanh(x.x), tanh(x.y), tanh(x.z), tanh(x.w));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4a atan2(Half4a y, Half4a x) => new Half4a(atan2(y.x, x.x), atan2(y.y, x.y), atan2(y.z, x.z), atan2(y.w, x.w));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4a tanPi(Half4a x) => new Half4a(tanPi(x.x), tanPi(x.y), tanPi(x.z), tanPi(x.w));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4a atanPi(Half4a x) => new Half4a(atanPi(x.x), atanPi(x.y), atanPi(x.z), atanPi(x.w));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4a atan2Pi(Half4a y, Half4a x) => new Half4a(atan2Pi(y.x, x.x), atan2Pi(y.y, x.y), atan2Pi(y.z, x.z), atan2Pi(y.w, x.w));


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4a cos(Half4a x) => new Half4a(cos(x.x), cos(x.y), cos(x.z), cos(x.w));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4a cosh(Half4a x) => new Half4a(cosh(x.x), cosh(x.y), cosh(x.z), cosh(x.w));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4a acos(Half4a x) => new Half4a(acos(x.x), acos(x.y), acos(x.z), acos(x.w));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4a acosh(Half4a x) => new Half4a(acosh(x.x), acosh(x.y), acosh(x.z), acosh(x.w));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4a cosPi(Half4a x) => new Half4a(cosPi(x.x), cosPi(x.y), cosPi(x.z), cosPi(x.w));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4a acosPi(Half4a x) => new Half4a(acosPi(x.x), acosPi(x.y), acosPi(x.z), acosPi(x.w));


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4a sin(Half4a x) => new Half4a(sin(x.x), sin(x.y), sin(x.z), sin(x.w));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4a sinh(Half4a x) => new Half4a(sinh(x.x), sinh(x.y), sinh(x.z), sinh(x.w));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4a asin(Half4a x) => new Half4a(asin(x.x), asin(x.y), asin(x.z), asin(x.w));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4a asinh(Half4a x) => new Half4a(asinh(x.x), asinh(x.y), asinh(x.z), asinh(x.w));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4a sinPi(Half4a x) => new Half4a(sinPi(x.x), sinPi(x.y), sinPi(x.z), sinPi(x.w));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4a asinPi(Half4a x) => new Half4a(asinPi(x.x), asinPi(x.y), asinPi(x.z), asinPi(x.w));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void sincos(Half4a x, out Half4a sin, out Half4a cos)
    {
        Unsafe.SkipInit(out sin);
        Unsafe.SkipInit(out cos);
        sincos(x.x, out sin.x, out cos.x); sincos(x.y, out sin.y, out cos.y); sincos(x.z, out sin.z, out cos.z); sincos(x.w, out sin.w, out cos.w);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static (Half4a sin, Half4a cos) sincos(Half4a x)
    {
        var (s0, c0) = sincos(x.x); var (s1, c1) = sincos(x.y); var (s2, c2) = sincos(x.z); var (s3, c3) = sincos(x.w);
        return (new Half4a(s0, s1, s2, s3), new Half4a(c0, c1, c2, c3));
    }






    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4a floor(Half4a x) => new Half4a(floor(x.x), floor(x.y), floor(x.z), floor(x.w));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4a ceil(Half4a x) => new Half4a(ceil(x.x), ceil(x.y), ceil(x.z), ceil(x.w));



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4a round(Half4a x) => new Half4a(round(x.x), round(x.y), round(x.z), round(x.w));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4a trunc(Half4a x) => new Half4a(trunc(x.x), trunc(x.y), trunc(x.z), trunc(x.w));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4a frac(Half4a x) => x - floor(x);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4a rcp(Half4a x) => Half.One / x;





    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4a sign(Half4a x) => new Half4a(sign(x.x), sign(x.y), sign(x.z), sign(x.w));





    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4a pow(Half4a x, Half4a y) => new Half4a(pow(x.x, y.x), pow(x.y, y.y), pow(x.z, y.z), pow(x.w, y.w));


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4a exp(Half4a x) => new Half4a(exp(x.x), exp(x.y), exp(x.z), exp(x.w));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4a exp2(Half4a x) => new Half4a(exp2(x.x), exp2(x.y), exp2(x.z), exp2(x.w));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4a exp10(Half4a x) => new Half4a(exp10(x.x), exp10(x.y), exp10(x.z), exp10(x.w));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4a expM1(Half4a x) => new Half4a(expM1(x.x), expM1(x.y), expM1(x.z), expM1(x.w));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4a exp2M1(Half4a x) => new Half4a(exp2M1(x.x), exp2M1(x.y), exp2M1(x.z), exp2M1(x.w));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4a exp10M1(Half4a x) => new Half4a(exp10M1(x.x), exp10M1(x.y), exp10M1(x.z), exp10M1(x.w));


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4a log(Half4a x) => new Half4a(log(x.x), log(x.y), log(x.z), log(x.w));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4a log2(Half4a x) => new Half4a(log2(x.x), log2(x.y), log2(x.z), log2(x.w));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4a log10(Half4a x) => new Half4a(log10(x.x), log10(x.y), log10(x.z), log10(x.w));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4a logP1(Half4a x) => new Half4a(logP1(x.x), logP1(x.y), logP1(x.z), logP1(x.w));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4a log2P1(Half4a x) => new Half4a(log2P1(x.x), log2P1(x.y), log2P1(x.z), log2P1(x.w));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4a log10P1(Half4a x) => new Half4a(log10P1(x.x), log10P1(x.y), log10P1(x.z), log10P1(x.w));


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4a modf(Half4a x, out Half4a i) 
    { 
        i = trunc(x);
        return x - i;
    }



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4a sqrt(Half4a x) => new Half4a(sqrt(x.x), sqrt(x.y), sqrt(x.z), sqrt(x.w));


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4a rsqrt(Half4a x) => Half.One / sqrt(x);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4a normalize(Half4a x) => rsqrt(dot(x, x)) * x;

    // todo normalizesafe

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4a length(Half4a x) => sqrt(dot(x, x));






    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4a lengthsq(Half4a x) => dot(x, x);





    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4a distance(Half4a x, Half4a y) => length(y - x);





    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4a distancesq(Half4a x, Half4a y) => lengthsq(y - x);

    
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4a select(Half4a a, Half4a b, bool c) => c ? b : a;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4a select(Half4a a, Half4a b, bool4 c) => new Half4a(c.x ? b.x : a.x, c.y ? b.y : a.y, c.z ? b.z : a.z, c.w ? b.w : a.w);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4a step(Half4a y, Half4a x) => select(new Half4a(Half.Zero), new Half4a(Half.One), x >= y);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4a reflect(Half4a i, Half4a n) => i - (Half.One + Half.One) * n * dot(i, n);



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4a reflect(Half4a i, Half4a n, Half eta)
    {
        var ni = dot(n, i);
        var k = Half.One - eta * eta * (Half.One - ni * ni);
        return select(Half.Zero, eta * i - (eta * ni + sqrt(k)) * n, k >= Half.Zero);
    }




    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4a project(Half4a a, Half4a b) => (dot(a, b) / dot(b, b)) * b;

    // todo projectsafe




    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4a faceforward(Half4a n, Half4a i, Half4a ng) => select(n, -n, dot(ng, i) >= Half.Zero);




    
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4a radians(Half4a x) => x * (Half)0.0174532925199432957692369076848861271344287188854172545609719144;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4a degrees(Half4a x) => x * (Half)57.295779513082320876798154814105170332405472466564321549160243861;






}
