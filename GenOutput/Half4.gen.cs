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
public unsafe partial struct Half4 : 
    IEquatable<Half4>, IEqualityOperators<Half4, Half4, bool>, IEqualityOperators<Half4, Half4, bool4>,

    IAdditionOperators<Half4, Half4, Half4>, IAdditiveIdentity<Half4, Half4>, IUnaryPlusOperators<Half4, Half4>,
    ISubtractionOperators<Half4, Half4, Half4>, IUnaryNegationOperators<Half4, Half4>,
    IMultiplyOperators<Half4, Half4, Half4>, IMultiplicativeIdentity<Half4, Half4>,
    IDivisionOperators<Half4, Half4, Half4>,
    IModulusOperators<Half4, Half4, Half4>,

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

    public static Half4 Zero
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new Half4(Half.Zero);
    }

    public static Half4 One
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new Half4(Half.One);
    }


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public Half4(Half value) : this(value, value, value, value) { }


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public Half4(Half x, Half y, Half z, Half w)
    {

        this.x = x;

        this.y = y;

        this.z = z;

        this.w = w;

    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator Half4(Half value) => new Half4(value);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool Equals(Half4 other) => this.x == other.x && this.y == other.y && this.z == other.z && this.w == other.w;


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override bool Equals(object? o) => o is Half4 other && Equals(other);



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator ==(Half4 left, Half4 right) => left.x == right.x && left.y == right.y && left.z == right.z && left.w == right.w;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator !=(Half4 left, Half4 right) => left.x != right.x || left.y != right.y || left.z != right.z || left.w != right.w;



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override int GetHashCode() => HashCode.Combine(this.x, this.y, this.z, this.w);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public int4 Hash() => new int4(this.x.GetHashCode(), this.y.GetHashCode(), this.z.GetHashCode(), this.w.GetHashCode());

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    static bool4 IEqualityOperators<Half4, Half4, bool4>.operator ==(Half4 left, Half4 right) => new bool4(left.x == right.x, left.y == right.y, left.z == right.z, left.w == right.w);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    static bool4 IEqualityOperators<Half4, Half4, bool4>.operator !=(Half4 left, Half4 right) => new bool4(left.x != right.x, left.y != right.y, left.z != right.z, left.w != right.w);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool4 VEq(Half4 other) => new bool4(this.x == other.x, this.y == other.y, this.z == other.z, this.w == other.w);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool4 VNe(Half4 other) => new bool4(this.x != other.x, this.y != other.y, this.z != other.z, this.w != other.w);



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool4 operator >(Half4 left, Half4 right) => new bool4(left.x > right.x, left.y > right.y, left.z > right.z, left.w > right.w);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool4 operator <(Half4 left, Half4 right) => new bool4(left.x < right.x, left.y < right.y, left.z < right.z, left.w < right.w);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool4 operator >=(Half4 left, Half4 right) => new bool4(left.x >= right.x, left.y >= right.y, left.z >= right.z, left.w >= right.w);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool4 operator <=(Half4 left, Half4 right) => new bool4(left.x <= right.x, left.y <= right.y, left.z <= right.z, left.w <= right.w);




    public static Half4 AdditiveIdentity 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new Half4(Half.Zero);
    }

    public static Half4 MultiplicativeIdentity 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new Half4(Half.One);
    }



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4 operator +(Half4 left, Half4 right) => new Half4(left.x + right.x, left.y + right.y, left.z + right.z, left.w + right.w);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4 operator -(Half4 left, Half4 right) => new Half4(left.x - right.x, left.y - right.y, left.z - right.z, left.w - right.w);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4 operator *(Half4 left, Half4 right) => new Half4(left.x * right.x, left.y * right.y, left.z * right.z, left.w * right.w);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4 operator /(Half4 left, Half4 right) => new Half4(left.x / right.x, left.y / right.y, left.z / right.z, left.w / right.w);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4 operator %(Half4 left, Half4 right) => new Half4(left.x % right.x, left.y % right.y, left.z % right.z, left.w % right.w);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4 operator +(Half4 left, Half right) => new Half4(left.x + right, left.y + right, left.z + right, left.w + right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4 operator -(Half4 left, Half right) => new Half4(left.x - right, left.y - right, left.z - right, left.w - right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4 operator *(Half4 left, Half right) => new Half4(left.x * right, left.y * right, left.z * right, left.w * right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4 operator /(Half4 left, Half right) => new Half4(left.x / right, left.y / right, left.z / right, left.w / right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4 operator %(Half4 left, Half right) => new Half4(left.x % right, left.y % right, left.z % right, left.w % right);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4 operator +(Half left, Half4 right) => new Half4(left + right.x, left + right.y, left + right.z, left + right.w);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4 operator -(Half left, Half4 right) => new Half4(left - right.x, left - right.y, left - right.z, left - right.w);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4 operator *(Half left, Half4 right) => new Half4(left * right.x, left * right.y, left * right.z, left * right.w);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4 operator /(Half left, Half4 right) => new Half4(left / right.x, left / right.y, left / right.z, left / right.w);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4 operator %(Half left, Half4 right) => new Half4(left % right.x, left % right.y, left % right.z, left % right.w);


    
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4 operator -(Half4 self) => new Half4(-self.x, -self.y, -self.z, -self.w);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4 operator +(Half4 self) => new Half4(+self.x, +self.y, +self.z, +self.w);





    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override string ToString() => $"Half4({this.x}, {this.y}, {this.z}, {this.w})";

}

public static unsafe partial class math
{



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4 min(Half4 x, Half4 y) => new Half4(min(x.x, y.x), min(x.y, y.y), min(x.z, y.z), min(x.w, y.w));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4 max(Half4 x, Half4 y) => new Half4(max(x.x, y.x), max(x.y, y.y), max(x.z, y.z), max(x.w, y.w));



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4 lerp(Half4 s, Half4 x, Half4 y) => x + s * (y - x);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4 unlerp(Half4 x, Half4 a, Half4 b) => (x - a) / (b - a);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4 remap(Half4 x, Half4 a, Half4 b, Half4 c, Half4 d) => lerp(c, d, unlerp(a, b, x));



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4 mad(Half4 a, Half4 b, Half4 c) => a * b + c;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4 clamp(Half4 x, Half4 a, Half4 b) => max(a, min(b, x));



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4 saturate(Half4 x) => clamp(x, Half4.Zero, Half4.One);





    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4 abs(Half4 x) => new Half4(abs(x.x), abs(x.y), abs(x.z), abs(x.w));







    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half dot(Half4 x, Half4 y) => x.x * y.x + x.y * y.y + x.z * y.z + x.w * y.w;






    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4 tan(Half4 x) => new Half4(tan(x.x), tan(x.y), tan(x.z), tan(x.w));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4 tanh(Half4 x) => new Half4(tanh(x.x), tanh(x.y), tanh(x.z), tanh(x.w));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4 atan(Half4 x) => new Half4(atan(x.x), atan(x.y), atan(x.z), atan(x.w));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4 atanh(Half4 x) => new Half4(tanh(x.x), tanh(x.y), tanh(x.z), tanh(x.w));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4 atan2(Half4 y, Half4 x) => new Half4(atan2(y.x, x.x), atan2(y.y, x.y), atan2(y.z, x.z), atan2(y.w, x.w));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4 tanPi(Half4 x) => new Half4(tanPi(x.x), tanPi(x.y), tanPi(x.z), tanPi(x.w));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4 atanPi(Half4 x) => new Half4(atanPi(x.x), atanPi(x.y), atanPi(x.z), atanPi(x.w));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4 atan2Pi(Half4 y, Half4 x) => new Half4(atan2Pi(y.x, x.x), atan2Pi(y.y, x.y), atan2Pi(y.z, x.z), atan2Pi(y.w, x.w));


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4 cos(Half4 x) => new Half4(cos(x.x), cos(x.y), cos(x.z), cos(x.w));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4 cosh(Half4 x) => new Half4(cosh(x.x), cosh(x.y), cosh(x.z), cosh(x.w));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4 acos(Half4 x) => new Half4(acos(x.x), acos(x.y), acos(x.z), acos(x.w));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4 acosh(Half4 x) => new Half4(acosh(x.x), acosh(x.y), acosh(x.z), acosh(x.w));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4 cosPi(Half4 x) => new Half4(cosPi(x.x), cosPi(x.y), cosPi(x.z), cosPi(x.w));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4 acosPi(Half4 x) => new Half4(acosPi(x.x), acosPi(x.y), acosPi(x.z), acosPi(x.w));


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4 sin(Half4 x) => new Half4(sin(x.x), sin(x.y), sin(x.z), sin(x.w));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4 sinh(Half4 x) => new Half4(sinh(x.x), sinh(x.y), sinh(x.z), sinh(x.w));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4 asin(Half4 x) => new Half4(asin(x.x), asin(x.y), asin(x.z), asin(x.w));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4 asinh(Half4 x) => new Half4(asinh(x.x), asinh(x.y), asinh(x.z), asinh(x.w));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4 sinPi(Half4 x) => new Half4(sinPi(x.x), sinPi(x.y), sinPi(x.z), sinPi(x.w));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4 asinPi(Half4 x) => new Half4(asinPi(x.x), asinPi(x.y), asinPi(x.z), asinPi(x.w));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void sincos(Half4 x, out Half4 sin, out Half4 cos)
    {
        Unsafe.SkipInit(out sin);
        Unsafe.SkipInit(out cos);
        sincos(x.x, out sin.x, out cos.x); sincos(x.y, out sin.y, out cos.y); sincos(x.z, out sin.z, out cos.z); sincos(x.w, out sin.w, out cos.w);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static (Half4 sin, Half4 cos) sincos(Half4 x)
    {
        var (s0, c0) = sincos(x.x); var (s1, c1) = sincos(x.y); var (s2, c2) = sincos(x.z); var (s3, c3) = sincos(x.w);
        return (new Half4(s0, s1, s2, s3), new Half4(c0, c1, c2, c3));
    }






    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4 floor(Half4 x) => new Half4(floor(x.x), floor(x.y), floor(x.z), floor(x.w));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4 ceil(Half4 x) => new Half4(ceil(x.x), ceil(x.y), ceil(x.z), ceil(x.w));



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4 round(Half4 x) => new Half4(round(x.x), round(x.y), round(x.z), round(x.w));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4 trunc(Half4 x) => new Half4(trunc(x.x), trunc(x.y), trunc(x.z), trunc(x.w));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4 frac(Half4 x) => x - floor(x);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4 rcp(Half4 x) => Half.One / x;





    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4 sign(Half4 x) => new Half4(sign(x.x), sign(x.y), sign(x.z), sign(x.w));





    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4 pow(Half4 x, Half4 y) => new Half4(pow(x.x, y.x), pow(x.y, y.y), pow(x.z, y.z), pow(x.w, y.w));


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4 exp(Half4 x) => new Half4(exp(x.x), exp(x.y), exp(x.z), exp(x.w));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4 exp2(Half4 x) => new Half4(exp2(x.x), exp2(x.y), exp2(x.z), exp2(x.w));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4 exp10(Half4 x) => new Half4(exp10(x.x), exp10(x.y), exp10(x.z), exp10(x.w));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4 expM1(Half4 x) => new Half4(expM1(x.x), expM1(x.y), expM1(x.z), expM1(x.w));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4 exp2M1(Half4 x) => new Half4(exp2M1(x.x), exp2M1(x.y), exp2M1(x.z), exp2M1(x.w));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4 exp10M1(Half4 x) => new Half4(exp10M1(x.x), exp10M1(x.y), exp10M1(x.z), exp10M1(x.w));


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4 log(Half4 x) => new Half4(log(x.x), log(x.y), log(x.z), log(x.w));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4 log2(Half4 x) => new Half4(log2(x.x), log2(x.y), log2(x.z), log2(x.w));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4 log10(Half4 x) => new Half4(log10(x.x), log10(x.y), log10(x.z), log10(x.w));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4 logP1(Half4 x) => new Half4(logP1(x.x), logP1(x.y), logP1(x.z), logP1(x.w));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4 log2P1(Half4 x) => new Half4(log2P1(x.x), log2P1(x.y), log2P1(x.z), log2P1(x.w));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4 log10P1(Half4 x) => new Half4(log10P1(x.x), log10P1(x.y), log10P1(x.z), log10P1(x.w));


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4 modf(Half4 x, out Half4 i) 
    { 
        i = trunc(x);
        return x - i;
    }



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4 sqrt(Half4 x) => new Half4(sqrt(x.x), sqrt(x.y), sqrt(x.z), sqrt(x.w));


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4 rsqrt(Half4 x) => Half.One / sqrt(x);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4 normalize(Half4 x) => rsqrt(dot(x, x)) * x;

    // todo normalizesafe

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4 length(Half4 x) => sqrt(dot(x, x));






    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4 lengthsq(Half4 x) => dot(x, x);





    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4 distance(Half4 x, Half4 y) => length(y - x);





    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4 distancesq(Half4 x, Half4 y) => lengthsq(y - x);

    
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4 select(Half4 a, Half4 b, bool c) => c ? b : a;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4 select(Half4 a, Half4 b, bool4 c) => new Half4(c.x ? b.x : a.x, c.y ? b.y : a.y, c.z ? b.z : a.z, c.w ? b.w : a.w);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4 step(Half4 y, Half4 x) => select(new Half4(Half.Zero), new Half4(Half.One), x >= y);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4 reflect(Half4 i, Half4 n) => i - (Half.One + Half.One) * n * dot(i, n);



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4 reflect(Half4 i, Half4 n, Half eta)
    {
        var ni = dot(n, i);
        var k = Half.One - eta * eta * (Half.One - ni * ni);
        return select(Half.Zero, eta * i - (eta * ni + sqrt(k)) * n, k >= Half.Zero);
    }




    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4 project(Half4 a, Half4 b) => (dot(a, b) / dot(b, b)) * b;

    // todo projectsafe




    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4 faceforward(Half4 n, Half4 i, Half4 ng) => select(n, -n, dot(ng, i) >= Half.Zero);




    
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4 radians(Half4 x) => x * (Half)0.0174532925199432957692369076848861271344287188854172545609719144;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4 degrees(Half4 x) => x * (Half)57.295779513082320876798154814105170332405472466564321549160243861;






}
