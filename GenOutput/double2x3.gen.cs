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
using CCluster.Mathematics.Json;

#nullable enable
#pragma warning disable CS8981

namespace CCluster.Mathematics
{

/// <summary>A 2x3 matrix of double</summary>
[Serializable]
[JsonConverter(typeof(Double2x3JsonConverter))]
[StructLayout(LayoutKind.Explicit, Size = 48, Pack = 8)]
public unsafe partial struct double2x3 :
    IEquatable<double2x3>, IEqualityOperators<double2x3, double2x3, bool>, IEqualityOperators<double2x3, double2x3, bool2x3>,

    IAdditionOperators<double2x3, double2x3, double2x3>, IAdditiveIdentity<double2x3, double2x3>, IUnaryPlusOperators<double2x3, double2x3>,
    ISubtractionOperators<double2x3, double2x3, double2x3>, IUnaryNegationOperators<double2x3, double2x3>,
    IMultiplyOperators<double2x3, double2x3, double2x3>, IMultiplicativeIdentity<double2x3, double2x3>,
    IDivisionOperators<double2x3, double2x3, double2x3>,
    IModulusOperators<double2x3, double2x3, double2x3>,

    IMatrix2x3<double>, IMatrixSelf<double2x3>
{
    //////////////////////////////////////////////////////////////////////////////////////////////////// Fields

    #region Fields

    /// <summary>Column 0 of the matrix</summary>
    [FieldOffset(0)]
    public double2 c0;

    /// <summary>Column 1 of the matrix</summary>
    [FieldOffset(16)]
    public double2 c1;

    /// <summary>Column 2 of the matrix</summary>
    [FieldOffset(32)]
    public double2 c2;


    /// <summary>Row 0 column 0 of the matrix</summary>
    [FieldOffset(0)]
    public double m00;

    /// <summary>Row 1 column 0 of the matrix</summary>
    [FieldOffset(8)]
    public double m10;

    /// <summary>Row 0 column 1 of the matrix</summary>
    [FieldOffset(16)]
    public double m01;

    /// <summary>Row 1 column 1 of the matrix</summary>
    [FieldOffset(24)]
    public double m11;

    /// <summary>Row 0 column 2 of the matrix</summary>
    [FieldOffset(32)]
    public double m02;

    /// <summary>Row 1 column 2 of the matrix</summary>
    [FieldOffset(40)]
    public double m12;

    #endregion

    //////////////////////////////////////////////////////////////////////////////////////////////////// Constants

    #region Constants

    public static readonly double2x3 zero = new(0d);

    public static readonly double2x3 one = new(1d);

    static double2x3 IMatrixSelf<double2x3>.Zero 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => zero;
    }

    static double2x3 IMatrixSelf<double2x3>.One 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => one;
    }


    #endregion

    //////////////////////////////////////////////////////////////////////////////////////////////////// Ctor

    #region Ctor


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public double2x3(double2 c0, double2 c1, double2 c2)
    {
        Unsafe.SkipInit(out this);
        this.c0.vector = c0.vector;
        this.c1.vector = c1.vector;
        this.c2.vector = c2.vector;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public double2x3(double m00, double m10, double m01, double m11, double m02, double m12)
    {
        Unsafe.SkipInit(out this);
        this.c0.vector = Vector128.Create(m00, m10);
        this.c1.vector = Vector128.Create(m01, m11);
        this.c2.vector = Vector128.Create(m02, m12);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double2x3 RowMajor(double m00, double m01, double m02, double m10, double m11, double m12) 
        => new(m00, m10, m01, m11, m02, m12);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public double2x3(double value)
    {
        Unsafe.SkipInit(out this);
        this.c0.vector = Vector128.Create(value);
        this.c1.vector = Vector128.Create(value);
        this.c2.vector = Vector128.Create(value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public double2x3(double2 value)
    {
        Unsafe.SkipInit(out this);
        this.c0.vector = value.vector;
        this.c1.vector = value.vector;
        this.c2.vector = value.vector;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator double2x3(double value) => new(value);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator double2x3(double2 value) => new(value);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static explicit operator double(double2x3 value) => value.m00;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static explicit operator double2(double2x3 value) => value.c0;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static explicit operator uint2x3(double2x3 self) => new((uint2)self.c0, (uint2)self.c1, (uint2)self.c2);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static explicit operator int2x3(double2x3 self) => new((int2)self.c0, (int2)self.c1, (int2)self.c2);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static explicit operator ulong2x3(double2x3 self) => new((ulong2)self.c0, (ulong2)self.c1, (ulong2)self.c2);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static explicit operator long2x3(double2x3 self) => new((long2)self.c0, (long2)self.c1, (long2)self.c2);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static explicit operator float2x3(double2x3 self) => new((float2)self.c0, (float2)self.c1, (float2)self.c2);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static explicit operator decimal2x3(double2x3 self) => new((decimal2)self.c0, (decimal2)self.c1, (decimal2)self.c2);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static explicit operator Half2x3(double2x3 self) => new((Half2)self.c0, (Half2)self.c1, (Half2)self.c2);

    #endregion

    //////////////////////////////////////////////////////////////////////////////////////////////////// Equals

    #region Equals

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator ==(double2x3 left, double2x3 right) 
        => left.c0 == right.c0 && left.c1 == right.c1 && left.c2 == right.c2;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator !=(double2x3 left, double2x3 right) 
        => left.c0 != right.c0 || left.c1 != right.c1 || left.c2 != right.c2;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool Equals(double2x3 other) 
        => this == other;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override bool Equals(object? o) 
        => o is double2x3 other && Equals(other);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override int GetHashCode() 
        => HashCode.Combine(this.c0, this.c1, this.c2);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public int2x3 Hash() 
        => new(this.c0.GetHashCode(), this.c1.GetHashCode(), this.c2.GetHashCode());

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    static bool2x3 IEqualityOperators<double2x3, double2x3, bool2x3>.operator ==(double2x3 left, double2x3 right) 
        => new(left.c0 == right.c0, left.c1 == right.c1, left.c2 == right.c2);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    static bool2x3 IEqualityOperators<double2x3, double2x3, bool2x3>.operator !=(double2x3 left, double2x3 right) 
        => new(left.c0 != right.c0, left.c1 != right.c1, left.c2 != right.c2);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool2x3 VEq(double2x3 other) 
        => new(this.c0 == other.c0, this.c1 == other.c1, this.c2 == other.c2);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool2x3 VNe(double2x3 other) 
        => new(this.c0 != other.c0, this.c1 != other.c1, this.c2 != other.c2);



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool2x3 operator >(double2x3 left, double2x3 right) => new(left.c0 > right.c0, left.c1 > right.c1, left.c2 > right.c2);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool2x3 operator <(double2x3 left, double2x3 right) => new(left.c0 < right.c0, left.c1 < right.c1, left.c2 < right.c2);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool2x3 operator >=(double2x3 left, double2x3 right) => new(left.c0 >= right.c0, left.c1 >= right.c1, left.c2 >= right.c2);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool2x3 operator <=(double2x3 left, double2x3 right) => new(left.c0 <= right.c0, left.c1 <= right.c1, left.c2 <= right.c2);





    #endregion


    //////////////////////////////////////////////////////////////////////////////////////////////////// Arithmetic

    #region Arithmetic

    public static double2x3 AdditiveIdentity 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(0d);
    }

    public static double2x3 MultiplicativeIdentity 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(1d);
    }


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double2x3 operator +(double2x3 left, double2x3 right) 
        => new(left.c0 + right.c0, left.c1 + right.c1, left.c2 + right.c2);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double2x3 operator -(double2x3 left, double2x3 right) 
        => new(left.c0 - right.c0, left.c1 - right.c1, left.c2 - right.c2);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double2x3 operator *(double2x3 left, double2x3 right) 
        => new(left.c0 * right.c0, left.c1 * right.c1, left.c2 * right.c2);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double2x3 operator /(double2x3 left, double2x3 right) 
        => new(left.c0 / right.c0, left.c1 / right.c1, left.c2 / right.c2);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double2x3 operator %(double2x3 left, double2x3 right) 
        => new(left.c0 % right.c0, left.c1 % right.c1, left.c2 % right.c2);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double2x3 operator +(double2x3 left, double2 right) => new(left.c0 + right, left.c1 + right, left.c2 + right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double2x3 operator -(double2x3 left, double2 right) => new(left.c0 - right, left.c1 - right, left.c2 - right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double2x3 operator *(double2x3 left, double2 right) => new(left.c0 * right, left.c1 * right, left.c2 * right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double2x3 operator /(double2x3 left, double2 right) => new(left.c0 / right, left.c1 / right, left.c2 / right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double2x3 operator %(double2x3 left, double2 right) => new(left.c0 % right, left.c1 % right, left.c2 % right);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double2x3 operator +(double2 left, double2x3 right) => new(left + right.c0, left + right.c1, left + right.c2);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double2x3 operator -(double2 left, double2x3 right) => new(left - right.c0, left - right.c1, left - right.c2);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double2x3 operator *(double2 left, double2x3 right) => new(left * right.c0, left * right.c1, left * right.c2);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double2x3 operator /(double2 left, double2x3 right) => new(left / right.c0, left / right.c1, left / right.c2);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double2x3 operator %(double2 left, double2x3 right) => new(left % right.c0, left % right.c1, left % right.c2);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double2x3 operator +(double2x3 left, double right) => new(left.c0 + right, left.c1 + right, left.c2 + right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double2x3 operator -(double2x3 left, double right) => new(left.c0 - right, left.c1 - right, left.c2 - right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double2x3 operator *(double2x3 left, double right) => new(left.c0 * right, left.c1 * right, left.c2 * right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double2x3 operator /(double2x3 left, double right) => new(left.c0 / right, left.c1 / right, left.c2 / right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double2x3 operator %(double2x3 left, double right) => new(left.c0 % right, left.c1 % right, left.c2 % right);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double2x3 operator +(double left, double2x3 right) => new(left + right.c0, left + right.c1, left + right.c2);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double2x3 operator -(double left, double2x3 right) => new(left - right.c0, left - right.c1, left - right.c2);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double2x3 operator *(double left, double2x3 right) => new(left * right.c0, left * right.c1, left * right.c2);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double2x3 operator /(double left, double2x3 right) => new(left / right.c0, left / right.c1, left / right.c2);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double2x3 operator %(double left, double2x3 right) => new(left % right.c0, left % right.c1, left % right.c2);

    
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double2x3 operator -(double2x3 self) => new(-self.c0, -self.c1, -self.c2);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double2x3 operator +(double2x3 self) => new(+self.c0, +self.c1, +self.c2);

    #endregion

    //////////////////////////////////////////////////////////////////////////////////////////////////// ToString

    #region ToString

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override string ToString() => $"double2x3({this.c0}, {this.c1}, {this.c2})";

    #endregion

    //////////////////////////////////////////////////////////////////////////////////////////////////// Methods

    #region Methods



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double2x3 transpose(double2x3 v) => new(
        v.c0.x, v.c0.y,
        v.c1.x, v.c1.y,
        v.c2.x, v.c2.y
    );

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public readonly double2x3 transpose() => transpose(this);

    #endregion
}

public static unsafe partial class vectors
{


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double2x3 double2x3(double2 c0, double2 c1, double2 c2) => new(c0, c1, c2);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double2x3 double2x3(double m00, double m10, double m01, double m11, double m02, double m12) 
        => new(m00, m10, m01, m11, m02, m12);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double2x3 double2x3(double value) => new(value);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double2x3 double2x3(double2 value) => new(value);


} // vectors

public static unsafe partial class math
{

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3 mul(double2 a, double2x3 b) => new(dot(a, b.c0), dot(a, b.c1), dot(a, b.c2));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double2 mul(double2x3 a, double3 b) => a.c0 * b.x + a.c1 * b.y + a.c2 * b.z;


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double2x2 mul(double2x3 a, double3x2 b) => new(
        a.c0 * b.c0.x + a.c1 * b.c0.y + a.c2 * b.c0.z,
        a.c0 * b.c1.x + a.c1 * b.c1.y + a.c2 * b.c1.z
    );

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double2x3 mul(double2x3 a, double3x3 b) => new(
        a.c0 * b.c0.x + a.c1 * b.c0.y + a.c2 * b.c0.z,
        a.c0 * b.c1.x + a.c1 * b.c1.y + a.c2 * b.c1.z,
        a.c0 * b.c2.x + a.c1 * b.c2.y + a.c2 * b.c2.z
    );

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double2x4 mul(double2x3 a, double3x4 b) => new(
        a.c0 * b.c0.x + a.c1 * b.c0.y + a.c2 * b.c0.z,
        a.c0 * b.c1.x + a.c1 * b.c1.y + a.c2 * b.c1.z,
        a.c0 * b.c2.x + a.c1 * b.c2.y + a.c2 * b.c2.z,
        a.c0 * b.c3.x + a.c1 * b.c3.y + a.c2 * b.c3.z
    );


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double2x3 min(double2x3 x, double2x3 y) => new(min(x.c0, y.c0), min(x.c1, y.c1), min(x.c2, y.c2));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double2x3 max(double2x3 x, double2x3 y) => new(max(x.c0, y.c0), max(x.c1, y.c1), max(x.c2, y.c2));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double2x3 min(double2x3 x, double2x3 y, double2x3 z) => new(min(x.c0, y.c0, z.c0), min(x.c1, y.c1, z.c1), min(x.c2, y.c2, z.c2));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double2x3 max(double2x3 x, double2x3 y, double2x3 z) => new(max(x.c0, y.c0, z.c0), max(x.c1, y.c1, z.c1), max(x.c2, y.c2, z.c2));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double2x3 abs(double2x3 x) => new(abs(x.c0), abs(x.c1), abs(x.c2));



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double2x3 lerp(double2x3 s, double2x3 x, double2x3 y) => x + s * (y - x);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double2x3 unlerp(double2x3 x, double2x3 a, double2x3 b) => (x - a) / (b - a);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double2x3 remap(double2x3 x, double2x3 a, double2x3 b, double2x3 c, double2x3 d) => lerp(c, d, unlerp(a, b, x));


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double2x3 floor(double2x3 x) => new(floor(x.c0), floor(x.c1), floor(x.c2));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double2x3 ceil(double2x3 x) => new(ceil(x.c0), ceil(x.c1), ceil(x.c2));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double2x3 round(double2x3 x) => new(round(x.c0), round(x.c1), round(x.c2));



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double2 csum(double2x3 x) => x.c0 + x.c1 + x.c2;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double2 rsum(double2x3 x) => new(x.c0.x + x.c1.x + x.c2.x, x.c0.y + x.c1.y + x.c2.y);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double msum(double2x3 x) => csum(csum(x));



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int2x3 pop_cnt(double2x3 x) => new(pop_cnt(x.c0), pop_cnt(x.c1), pop_cnt(x.c2));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int count_bits(double2x3 x) => msum(pop_cnt(x));

} // class math

namespace Json
{

public class Double2x3JsonConverter : JsonConverter<double2x3>
{
    private static readonly Type v_type = typeof(double2);

    public override double2x3 Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        Unsafe.SkipInit(out double2x3 result);
        if (reader.TokenType is not JsonTokenType.StartArray) throw new JsonException();
        var conv = (JsonConverter<double2>)options.GetConverter(v_type);
        reader.Read();
        result.c0 = conv.Read(ref reader, v_type, options);
        reader.Read();
        result.c1 = conv.Read(ref reader, v_type, options);
        reader.Read();
        result.c2 = conv.Read(ref reader, v_type, options);
        reader.Read();
        if (reader.TokenType is not JsonTokenType.EndArray) throw new JsonException();
        return result;
    }

    public override void Write(Utf8JsonWriter writer, double2x3 value, JsonSerializerOptions options)
    {
        writer.WriteStartArray();
        var conv = (JsonConverter<double2>)options.GetConverter(v_type);
        conv.Write(writer, value.c0, options);
        conv.Write(writer, value.c1, options);
        conv.Write(writer, value.c2, options);
        writer.WriteEndArray();
    }
} // class JsonConverter

} // namespace Json

} // namespace CCluster.Mathematics
