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

/// <summary>A 3 component vector of float</summary>
[Serializable]
[JsonConverter(typeof(Float3JsonConverter))]
[StructLayout(LayoutKind.Explicit, Size = 16, Pack = 4)]
public unsafe partial struct float3 : 
    IEquatable<float3>, IEqualityOperators<float3, float3, bool>, IEqualityOperators<float3, float3, bool3>,

    IAdditionOperators<float3, float3, float3>, IAdditiveIdentity<float3, float3>, IUnaryPlusOperators<float3, float3>,
    ISubtractionOperators<float3, float3, float3>, IUnaryNegationOperators<float3, float3>,
    IMultiplyOperators<float3, float3, float3>, IMultiplicativeIdentity<float3, float3>,
    IDivisionOperators<float3, float3, float3>,
    IModulusOperators<float3, float3, float3>,

    IVector3<float>, IVectorSelf<float3>
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


    /// <summary>R component of the vector</summary>
    [FieldOffset(0)]
    public float r;

    /// <summary>G component of the vector</summary>
    [FieldOffset(4)]
    public float g;

    /// <summary>B component of the vector</summary>
    [FieldOffset(8)]
    public float b;

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

    public static readonly float3 zero = new(0f);

    public static readonly float3 one = new(1f);

    static float3 IVectorSelf<float3>.Zero 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => zero;
    }

    static float3 IVectorSelf<float3>.One 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => one;
    }

    #endregion

    //////////////////////////////////////////////////////////////////////////////////////////////////// Ctor

    #region Ctor

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public float3(Vector128<float> vector)
    {
        this.vector = vector;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public float3(float value)
    {
        this.vector = Vector128.Create(value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public float3(float x, float y, float z)
    {
        this.vector = Vector128.Create(x, y, z, 0f);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public float3(float2 xy, float z) : this(xy.x, xy.y, z) { }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public float3(float x, float2 yz) : this(x, yz.x, yz.y) { }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator float3(float value) => new(value);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static explicit operator float(float3 value) => value.x;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator double3(float3 self) => new(self.x, self.y, self.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator double3a(float3 self) => new(self.x, self.y, self.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static explicit operator uint3(float3 self) => new((uint)self.x, (uint)self.y, (uint)self.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static explicit operator uint3a(float3 self) => new((uint)self.x, (uint)self.y, (uint)self.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static explicit operator int3(float3 self) => new((int)self.x, (int)self.y, (int)self.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static explicit operator int3a(float3 self) => new((int)self.x, (int)self.y, (int)self.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static explicit operator ulong3(float3 self) => new((ulong)self.x, (ulong)self.y, (ulong)self.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static explicit operator ulong3a(float3 self) => new((ulong)self.x, (ulong)self.y, (ulong)self.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static explicit operator long3(float3 self) => new((long)self.x, (long)self.y, (long)self.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static explicit operator long3a(float3 self) => new((long)self.x, (long)self.y, (long)self.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static explicit operator decimal3(float3 self) => new((decimal)self.x, (decimal)self.y, (decimal)self.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static explicit operator decimal3a(float3 self) => new((decimal)self.x, (decimal)self.y, (decimal)self.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static explicit operator Half3(float3 self) => new((Half)self.x, (Half)self.y, (Half)self.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static explicit operator Half3a(float3 self) => new((Half)self.x, (Half)self.y, (Half)self.z);

    #endregion

    //////////////////////////////////////////////////////////////////////////////////////////////////// Equals

    #region Equals


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool Equals(float3 other)
    {
        return (this.vector & math.v3_iz_float128).Equals((other.vector & math.v3_iz_float128));
    }


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override bool Equals(object? o) => o is float3 other && Equals(other);



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator ==(float3 left, float3 right)
    {
        return (left.vector & math.v3_iz_float128).Equals((right.vector & math.v3_iz_float128));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator !=(float3 left, float3 right)
    {
        return !(left.vector & math.v3_iz_float128).Equals((right.vector & math.v3_iz_float128));
    }



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override int GetHashCode() => HashCode.Combine(this.x, this.y, this.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public int3 Hash() => new(this.x.GetHashCode(), this.y.GetHashCode(), this.z.GetHashCode());

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    static bool3 IEqualityOperators<float3, float3, bool3>.operator ==(float3 left, float3 right) => new(left.x == right.x, left.y == right.y, left.z == right.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    static bool3 IEqualityOperators<float3, float3, bool3>.operator !=(float3 left, float3 right) => new(left.x != right.x, left.y != right.y, left.z != right.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool3 VEq(float3 other) => new(this.x == other.x, this.y == other.y, this.z == other.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool3 VNe(float3 other) => new(this.x != other.x, this.y != other.y, this.z != other.z);

    #endregion



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool3 operator >(float3 left, float3 right) => new(left.x > right.x, left.y > right.y, left.z > right.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool3 operator <(float3 left, float3 right) => new(left.x < right.x, left.y < right.y, left.z < right.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool3 operator >=(float3 left, float3 right) => new(left.x >= right.x, left.y >= right.y, left.z >= right.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool3 operator <=(float3 left, float3 right) => new(left.x <= right.x, left.y <= right.y, left.z <= right.z);




    //////////////////////////////////////////////////////////////////////////////////////////////////// Arithmetic

    #region Arithmetic

    public static float3 AdditiveIdentity 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(0f);
    }

    public static float3 MultiplicativeIdentity 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(1f);
    }



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3 operator +(float3 left, float3 right)
    {
        return new(left.vector + right.vector);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3 operator -(float3 left, float3 right)
    {
        return new(left.vector - right.vector);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3 operator *(float3 left, float3 right)
    {
        return new(left.vector * right.vector);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3 operator /(float3 left, float3 right)
    {
        return new(left.vector / right.vector);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3 operator %(float3 left, float3 right) => new(left.x % right.x, left.y % right.y, left.z % right.z);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3 operator +(float3 left, float right) => left + new float3(right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3 operator -(float3 left, float right) => left - new float3(right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3 operator *(float3 left, float right) => left * new float3(right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3 operator /(float3 left, float right) => left / new float3(right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3 operator %(float3 left, float right) => left % new float3(right);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3 operator +(float left, float3 right) => new float3(left) + right;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3 operator -(float left, float3 right) => new float3(left) - right;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3 operator *(float left, float3 right) => new float3(left) * right;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3 operator /(float left, float3 right) => new float3(left) / right;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3 operator %(float left, float3 right) => new float3(left) % right;


    
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3 operator -(float3 self) => new(-self.x, -self.y, -self.z);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3 operator +(float3 self) => new(+self.x, +self.y, +self.z);



    #endregion


    //////////////////////////////////////////////////////////////////////////////////////////////////// ToString

    #region ToString

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override string ToString() => $"float3({this.x}, {this.y}, {this.z})";

    #endregion
}

public static unsafe partial class math
{



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3 min(float3 x, float3 y) => new(min(x.x, y.x), min(x.y, y.y), min(x.z, y.z));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3 max(float3 x, float3 y) => new(max(x.x, y.x), max(x.y, y.y), max(x.z, y.z));



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3 lerp(float3 s, float3 x, float3 y) => x + s * (y - x);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3 unlerp(float3 x, float3 a, float3 b) => (x - a) / (b - a);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3 remap(float3 x, float3 a, float3 b, float3 c, float3 d) => lerp(c, d, unlerp(a, b, x));




    

    internal static readonly Vector128<float> v3_iz_float128 = Vector128.Create(-1, -1, -1, 0).As<int, float>();


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3 mad(float3 a, float3 b, float3 c)
    {
        if (Fma.IsSupported) return new(Fma.MultiplyAdd(a.vector, b.vector, c.vector));
        
        if (AdvSimd.IsSupported) return new(AdvSimd.FusedMultiplyAdd(c.vector, a.vector, b.vector));
        return a * b + c;
    }


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3 clamp(float3 x, float3 a, float3 b) => max(a, min(b, x));



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3 saturate(float3 x) => clamp(x, float3.zero, float3.one);





    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3 abs(float3 x) => new(abs(x.x), abs(x.y), abs(x.z));




    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3 cross(float3 x, float3 y) => (x * y.yzx - x.yzx * y).yzx;




    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float dot(float3 x, float3 y) => Vector128.Dot(x.vector & math.v3_iz_float128, y.vector);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float mul(float3 a, float3 b) => dot(a, b);





    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3 tan(float3 x) => new(tan(x.x), tan(x.y), tan(x.z));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3 tanh(float3 x) => new(tanh(x.x), tanh(x.y), tanh(x.z));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3 atan(float3 x) => new(atan(x.x), atan(x.y), atan(x.z));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3 atanh(float3 x) => new(tanh(x.x), tanh(x.y), tanh(x.z));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3 atan2(float3 y, float3 x) => new(atan2(y.x, x.x), atan2(y.y, x.y), atan2(y.z, x.z));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3 tanPi(float3 x) => new(tanPi(x.x), tanPi(x.y), tanPi(x.z));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3 atanPi(float3 x) => new(atanPi(x.x), atanPi(x.y), atanPi(x.z));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3 atan2Pi(float3 y, float3 x) => new(atan2Pi(y.x, x.x), atan2Pi(y.y, x.y), atan2Pi(y.z, x.z));


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3 cos(float3 x) => new(cos(x.x), cos(x.y), cos(x.z));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3 cosh(float3 x) => new(cosh(x.x), cosh(x.y), cosh(x.z));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3 acos(float3 x) => new(acos(x.x), acos(x.y), acos(x.z));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3 acosh(float3 x) => new(acosh(x.x), acosh(x.y), acosh(x.z));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3 cosPi(float3 x) => new(cosPi(x.x), cosPi(x.y), cosPi(x.z));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3 acosPi(float3 x) => new(acosPi(x.x), acosPi(x.y), acosPi(x.z));


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3 sin(float3 x) => new(sin(x.x), sin(x.y), sin(x.z));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3 sinh(float3 x) => new(sinh(x.x), sinh(x.y), sinh(x.z));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3 asin(float3 x) => new(asin(x.x), asin(x.y), asin(x.z));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3 asinh(float3 x) => new(asinh(x.x), asinh(x.y), asinh(x.z));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3 sinPi(float3 x) => new(sinPi(x.x), sinPi(x.y), sinPi(x.z));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3 asinPi(float3 x) => new(asinPi(x.x), asinPi(x.y), asinPi(x.z));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void sincos(float3 x, out float3 sin, out float3 cos)
    {
        Unsafe.SkipInit(out sin);
        Unsafe.SkipInit(out cos);
        sincos(x.x, out sin.x, out cos.x); sincos(x.y, out sin.y, out cos.y); sincos(x.z, out sin.z, out cos.z);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static (float3 sin, float3 cos) sincos(float3 x)
    {
        var (s0, c0) = sincos(x.x); var (s1, c1) = sincos(x.y); var (s2, c2) = sincos(x.z);
        return (new(s0, s1, s2), new(c0, c1, c2));
    }






    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3 floor(float3 x) => new(Vector128.Floor(x.vector));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3 ceil(float3 x) => new(Vector128.Ceiling(x.vector));



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3 round(float3 x) => new(round(x.x), round(x.y), round(x.z));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3 trunc(float3 x) => new(trunc(x.x), trunc(x.y), trunc(x.z));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3 frac(float3 x) => x - floor(x);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3 rcp(float3 x) => 1f / x;





    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3 sign(float3 x) => new(sign(x.x), sign(x.y), sign(x.z));





    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3 pow(float3 x, float3 y) => new(pow(x.x, y.x), pow(x.y, y.y), pow(x.z, y.z));


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3 exp(float3 x) => new(exp(x.x), exp(x.y), exp(x.z));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3 exp2(float3 x) => new(exp2(x.x), exp2(x.y), exp2(x.z));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3 exp10(float3 x) => new(exp10(x.x), exp10(x.y), exp10(x.z));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3 expM1(float3 x) => new(expM1(x.x), expM1(x.y), expM1(x.z));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3 exp2M1(float3 x) => new(exp2M1(x.x), exp2M1(x.y), exp2M1(x.z));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3 exp10M1(float3 x) => new(exp10M1(x.x), exp10M1(x.y), exp10M1(x.z));


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3 log(float3 x) => new(log(x.x), log(x.y), log(x.z));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3 log2(float3 x) => new(log2(x.x), log2(x.y), log2(x.z));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3 log10(float3 x) => new(log10(x.x), log10(x.y), log10(x.z));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3 logP1(float3 x) => new(logP1(x.x), logP1(x.y), logP1(x.z));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3 log2P1(float3 x) => new(log2P1(x.x), log2P1(x.y), log2P1(x.z));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3 log10P1(float3 x) => new(log10P1(x.x), log10P1(x.y), log10P1(x.z));


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3 modf(float3 x, out float3 i) 
    { 
        i = trunc(x);
        return x - i;
    }



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3 sqrt(float3 x) => new(Vector128.Sqrt(x.vector));


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3 rsqrt(float3 x) => 1f / sqrt(x);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3 normalize(float3 x) => rsqrt(dot(x, x)) * x;

    // todo normalizesafe

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3 length(float3 x) => sqrt(dot(x, x));






    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3 lengthsq(float3 x) => dot(x, x);





    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3 distance(float3 x, float3 y) => length(y - x);





    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3 distancesq(float3 x, float3 y) => lengthsq(y - x);

    
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3 select(float3 a, float3 b, bool c) => c ? b : a;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3 select(float3 a, float3 b, bool3 c) => new(c.x ? b.x : a.x, c.y ? b.y : a.y, c.z ? b.z : a.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3 step(float3 y, float3 x) => select(new float3(0f), new float3(1f), x >= y);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3 reflect(float3 i, float3 n) => i - 2f * n * dot(i, n);



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3 reflect(float3 i, float3 n, float eta)
    {
        var ni = dot(n, i);
        var k = 1f - eta * eta * (1f - ni * ni);
        return select(0f, eta * i - (eta * ni + sqrt(k)) * n, k >= 0f);
    }




    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3 project(float3 a, float3 b) => (dot(a, b) / dot(b, b)) * b;

    // todo projectsafe




    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3 faceforward(float3 n, float3 i, float3 ng) => select(n, -n, dot(ng, i) >= 0f);




    
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3 radians(float3 x) => x * 0.0174532925199432957692369076848861271344287188854172545609719144f;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3 degrees(float3 x) => x * 57.295779513082320876798154814105170332405472466564321549160243861f;






}

public class Float3JsonConverter : JsonConverter<float3>
{
    public override float3 Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        Unsafe.SkipInit(out float3 result);
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

    public override void Write(Utf8JsonWriter writer, float3 value, JsonSerializerOptions options)
    {
        writer.WriteStartArray();
        writer.WriteNumberValue(value.x);
        writer.WriteNumberValue(value.y);
        writer.WriteNumberValue(value.z);
        writer.WriteEndArray();
    }
}
