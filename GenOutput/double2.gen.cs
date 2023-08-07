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
[JsonConverter(typeof(Double2Converter))]
[StructLayout(LayoutKind.Explicit, Size = 16)]
public unsafe partial struct double2 : 
    IEquatable<double2>, IEqualityOperators<double2, double2, bool>, IEqualityOperators<double2, double2, bool2>,

    IAdditionOperators<double2, double2, double2>, IAdditiveIdentity<double2, double2>, IUnaryPlusOperators<double2, double2>,
    ISubtractionOperators<double2, double2, double2>, IUnaryNegationOperators<double2, double2>,
    IMultiplyOperators<double2, double2, double2>, IMultiplicativeIdentity<double2, double2>,
    IDivisionOperators<double2, double2, double2>,
    IModulusOperators<double2, double2, double2>,

    IVector, IVector2, IVector<double>, IVector2<double>
{

    [FieldOffset(0)]
    public Vector128<double> vector;


    [FieldOffset(0)]
    public double x;

    [FieldOffset(8)]
    public double y;

    [FieldOffset(0)]
    public double r;

    [FieldOffset(8)]
    public double g;


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

    public static double2 Zero
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new double2(0d);
    }

    public static double2 One
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new double2(1d);
    }


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public double2(Vector128<double> vector)
    {
        this.vector = vector;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public double2(double value)
    {
        this.vector = Vector128.Create(value);
    }


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public double2(double x, double y)
    {

        this.vector = Vector128.Create(x, y);

    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator double2(double value) => new double2(value);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool Equals(double2 other)
    {
        return this.vector.Equals(other.vector);
    }


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override bool Equals(object? o) => o is double2 other && Equals(other);



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator ==(double2 left, double2 right)
    {
        return left.vector.Equals(right.vector);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator !=(double2 left, double2 right)
    {
        return !left.vector.Equals(right.vector);
    }



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override int GetHashCode() => HashCode.Combine(this.x, this.y);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public int2 Hash() => new int2(this.x.GetHashCode(), this.y.GetHashCode());

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    static bool2 IEqualityOperators<double2, double2, bool2>.operator ==(double2 left, double2 right) => new bool2(left.x == right.x, left.y == right.y);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    static bool2 IEqualityOperators<double2, double2, bool2>.operator !=(double2 left, double2 right) => new bool2(left.x != right.x, left.y != right.y);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool2 VEq(double2 other) => new bool2(this.x == other.x, this.y == other.y);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool2 VNe(double2 other) => new bool2(this.x != other.x, this.y != other.y);



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool2 operator >(double2 left, double2 right) => new bool2(left.x > right.x, left.y > right.y);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool2 operator <(double2 left, double2 right) => new bool2(left.x < right.x, left.y < right.y);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool2 operator >=(double2 left, double2 right) => new bool2(left.x >= right.x, left.y >= right.y);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool2 operator <=(double2 left, double2 right) => new bool2(left.x <= right.x, left.y <= right.y);




    public static double2 AdditiveIdentity 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new double2(0d);
    }

    public static double2 MultiplicativeIdentity 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new double2(1d);
    }



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double2 operator +(double2 left, double2 right)
    {
        return new double2(left.vector + right.vector);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double2 operator -(double2 left, double2 right)
    {
        return new double2(left.vector - right.vector);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double2 operator *(double2 left, double2 right)
    {
        return new double2(left.vector * right.vector);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double2 operator /(double2 left, double2 right)
    {
        return new double2(left.vector / right.vector);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double2 operator %(double2 left, double2 right) => new double2(left.x % right.x, left.y % right.y);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double2 operator +(double2 left, double right) => left + new double2(right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double2 operator -(double2 left, double right) => left - new double2(right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double2 operator *(double2 left, double right) => left * new double2(right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double2 operator /(double2 left, double right) => left / new double2(right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double2 operator %(double2 left, double right) => left % new double2(right);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double2 operator +(double left, double2 right) => new double2(left) + right;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double2 operator -(double left, double2 right) => new double2(left) - right;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double2 operator *(double left, double2 right) => new double2(left) * right;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double2 operator /(double left, double2 right) => new double2(left) / right;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double2 operator %(double left, double2 right) => new double2(left) % right;


    
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double2 operator -(double2 self) => new double2(-self.x, -self.y);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double2 operator +(double2 self) => new double2(+self.x, +self.y);





    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override string ToString() => $"double2({this.x}, {this.y})";

}

public static unsafe partial class math
{



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double2 min(double2 x, double2 y) => new double2(min(x.x, y.x), min(x.y, y.y));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double2 max(double2 x, double2 y) => new double2(max(x.x, y.x), max(x.y, y.y));



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double2 lerp(double2 s, double2 x, double2 y) => x + s * (y - x);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double2 unlerp(double2 x, double2 a, double2 b) => (x - a) / (b - a);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double2 remap(double2 x, double2 a, double2 b, double2 c, double2 d) => lerp(c, d, unlerp(a, b, x));



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double2 mad(double2 a, double2 b, double2 c) => a * b + c;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double2 clamp(double2 x, double2 a, double2 b) => max(a, min(b, x));



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double2 saturate(double2 x) => clamp(x, double2.Zero, double2.One);





    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double2 abs(double2 x) => new double2(abs(x.x), abs(x.y));







    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double dot(double2 x, double2 y) => Vector128.Dot(x.vector, y.vector);






    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double2 tan(double2 x) => new double2(tan(x.x), tan(x.y));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double2 tanh(double2 x) => new double2(tanh(x.x), tanh(x.y));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double2 atan(double2 x) => new double2(atan(x.x), atan(x.y));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double2 atanh(double2 x) => new double2(tanh(x.x), tanh(x.y));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double2 atan2(double2 y, double2 x) => new double2(atan2(y.x, x.x), atan2(y.y, x.y));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double2 tanPi(double2 x) => new double2(tanPi(x.x), tanPi(x.y));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double2 atanPi(double2 x) => new double2(atanPi(x.x), atanPi(x.y));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double2 atan2Pi(double2 y, double2 x) => new double2(atan2Pi(y.x, x.x), atan2Pi(y.y, x.y));


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double2 cos(double2 x) => new double2(cos(x.x), cos(x.y));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double2 cosh(double2 x) => new double2(cosh(x.x), cosh(x.y));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double2 acos(double2 x) => new double2(acos(x.x), acos(x.y));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double2 acosh(double2 x) => new double2(acosh(x.x), acosh(x.y));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double2 cosPi(double2 x) => new double2(cosPi(x.x), cosPi(x.y));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double2 acosPi(double2 x) => new double2(acosPi(x.x), acosPi(x.y));


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double2 sin(double2 x) => new double2(sin(x.x), sin(x.y));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double2 sinh(double2 x) => new double2(sinh(x.x), sinh(x.y));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double2 asin(double2 x) => new double2(asin(x.x), asin(x.y));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double2 asinh(double2 x) => new double2(asinh(x.x), asinh(x.y));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double2 sinPi(double2 x) => new double2(sinPi(x.x), sinPi(x.y));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double2 asinPi(double2 x) => new double2(asinPi(x.x), asinPi(x.y));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void sincos(double2 x, out double2 sin, out double2 cos)
    {
        Unsafe.SkipInit(out sin);
        Unsafe.SkipInit(out cos);
        sincos(x.x, out sin.x, out cos.x); sincos(x.y, out sin.y, out cos.y);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static (double2 sin, double2 cos) sincos(double2 x)
    {
        var (s0, c0) = sincos(x.x); var (s1, c1) = sincos(x.y);
        return (new double2(s0, s1), new double2(c0, c1));
    }






    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double2 floor(double2 x) => new double2(Vector128.Floor(x.vector));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double2 ceil(double2 x) => new double2(Vector128.Ceiling(x.vector));



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double2 round(double2 x) => new double2(round(x.x), round(x.y));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double2 trunc(double2 x) => new double2(trunc(x.x), trunc(x.y));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double2 frac(double2 x) => x - floor(x);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double2 rcp(double2 x) => 1d / x;





    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double2 sign(double2 x) => new double2(sign(x.x), sign(x.y));





    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double2 pow(double2 x, double2 y) => new double2(pow(x.x, y.x), pow(x.y, y.y));


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double2 exp(double2 x) => new double2(exp(x.x), exp(x.y));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double2 exp2(double2 x) => new double2(exp2(x.x), exp2(x.y));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double2 exp10(double2 x) => new double2(exp10(x.x), exp10(x.y));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double2 expM1(double2 x) => new double2(expM1(x.x), expM1(x.y));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double2 exp2M1(double2 x) => new double2(exp2M1(x.x), exp2M1(x.y));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double2 exp10M1(double2 x) => new double2(exp10M1(x.x), exp10M1(x.y));


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double2 log(double2 x) => new double2(log(x.x), log(x.y));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double2 log2(double2 x) => new double2(log2(x.x), log2(x.y));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double2 log10(double2 x) => new double2(log10(x.x), log10(x.y));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double2 logP1(double2 x) => new double2(logP1(x.x), logP1(x.y));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double2 log2P1(double2 x) => new double2(log2P1(x.x), log2P1(x.y));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double2 log10P1(double2 x) => new double2(log10P1(x.x), log10P1(x.y));


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double2 modf(double2 x, out double2 i) 
    { 
        i = trunc(x);
        return x - i;
    }



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double2 sqrt(double2 x) => new double2(Vector128.Sqrt(x.vector));


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double2 rsqrt(double2 x) => 1d / sqrt(x);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double2 normalize(double2 x) => rsqrt(dot(x, x)) * x;

    // todo normalizesafe

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double2 length(double2 x) => sqrt(dot(x, x));






    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double2 lengthsq(double2 x) => dot(x, x);





    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double2 distance(double2 x, double2 y) => length(y - x);





    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double2 distancesq(double2 x, double2 y) => lengthsq(y - x);

    
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double2 select(double2 a, double2 b, bool c) => c ? b : a;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double2 select(double2 a, double2 b, bool2 c) => new double2(c.x ? b.x : a.x, c.y ? b.y : a.y);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double2 step(double2 y, double2 x) => select(new double2(0d), new double2(1d), x >= y);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double2 reflect(double2 i, double2 n) => i - 2d * n * dot(i, n);



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double2 reflect(double2 i, double2 n, double eta)
    {
        var ni = dot(n, i);
        var k = 1d - eta * eta * (1d - ni * ni);
        return select(0d, eta * i - (eta * ni + sqrt(k)) * n, k >= 0d);
    }




    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double2 project(double2 a, double2 b) => (dot(a, b) / dot(b, b)) * b;

    // todo projectsafe




    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double2 faceforward(double2 n, double2 i, double2 ng) => select(n, -n, dot(ng, i) >= 0d);




    
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double2 radians(double2 x) => x * 0.0174532925199432957692369076848861271344287188854172545609719144d;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double2 degrees(double2 x) => x * 57.295779513082320876798154814105170332405472466564321549160243861d;






}

public class Double2Converter : JsonConverter<double2>
{
    public override double2 Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        Unsafe.SkipInit(out double2 result);
        if (reader.TokenType is not JsonTokenType.StartArray) throw new JsonException();
        reader.Read();
        result.x = reader.GetDouble();
        reader.Read();
        result.y = reader.GetDouble();
        reader.Read();
        if (reader.TokenType is not JsonTokenType.EndArray) throw new JsonException();
        return result;
    }

    public override void Write(Utf8JsonWriter writer, double2 value, JsonSerializerOptions options)
    {
        writer.WriteStartArray();
        writer.WriteNumberValue(value.x);
        writer.WriteNumberValue(value.y);
        writer.WriteEndArray();
    }
}
