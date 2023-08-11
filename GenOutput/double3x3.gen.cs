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

/// <summary>A 3x3 matrix of double</summary>
[Serializable]
[JsonConverter(typeof(Double3x3JsonConverter))]
[StructLayout(LayoutKind.Explicit, Size = 96, Pack = 8)]
public unsafe partial struct double3x3 :
    IEquatable<double3x3>, IEqualityOperators<double3x3, double3x3, bool>, IEqualityOperators<double3x3, double3x3, bool3x3>,

    IAdditionOperators<double3x3, double3x3, double3x3>, IAdditiveIdentity<double3x3, double3x3>, IUnaryPlusOperators<double3x3, double3x3>,
    ISubtractionOperators<double3x3, double3x3, double3x3>, IUnaryNegationOperators<double3x3, double3x3>,
    IMultiplyOperators<double3x3, double3x3, double3x3>, IMultiplicativeIdentity<double3x3, double3x3>,
    IDivisionOperators<double3x3, double3x3, double3x3>,
    IModulusOperators<double3x3, double3x3, double3x3>,

    IMatrix3x3<double>, IMatrixSelf<double3x3>, IMatrixIdentity<double3x3>
{
    //////////////////////////////////////////////////////////////////////////////////////////////////// Fields

    #region Fields

    /// <summary>Column 0 of the matrix</summary>
    [FieldOffset(0)]
    public double3 c0;

    /// <summary>Column 1 of the matrix</summary>
    [FieldOffset(32)]
    public double3 c1;

    /// <summary>Column 2 of the matrix</summary>
    [FieldOffset(64)]
    public double3 c2;


    /// <summary>Row 0 column 0 of the matrix</summary>
    [FieldOffset(0)]
    public double m00;

    /// <summary>Row 1 column 0 of the matrix</summary>
    [FieldOffset(8)]
    public double m10;

    /// <summary>Row 2 column 0 of the matrix</summary>
    [FieldOffset(16)]
    public double m20;

    /// <summary>Row 0 column 1 of the matrix</summary>
    [FieldOffset(32)]
    public double m01;

    /// <summary>Row 1 column 1 of the matrix</summary>
    [FieldOffset(40)]
    public double m11;

    /// <summary>Row 2 column 1 of the matrix</summary>
    [FieldOffset(48)]
    public double m21;

    /// <summary>Row 0 column 2 of the matrix</summary>
    [FieldOffset(64)]
    public double m02;

    /// <summary>Row 1 column 2 of the matrix</summary>
    [FieldOffset(72)]
    public double m12;

    /// <summary>Row 2 column 2 of the matrix</summary>
    [FieldOffset(80)]
    public double m22;

    #endregion

    //////////////////////////////////////////////////////////////////////////////////////////////////// Constants

    #region Constants

    public static readonly double3x3 identity = new double3x3(
        1d, 0d, 0d,
        0d, 1d, 0d, 
        0d, 0d, 1d
    );

    public static readonly double3x3 zero = new(0d);

    public static readonly double3x3 one = new(1d);

    static double3x3 IMatrixSelf<double3x3>.Zero 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => zero;
    }

    static double3x3 IMatrixSelf<double3x3>.One 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => one;
    }

    static double3x3 IMatrixIdentity<double3x3>.Identity 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => identity;
    }

    #endregion

    //////////////////////////////////////////////////////////////////////////////////////////////////// Ctor

    #region Ctor


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public double3x3(double3 c0, double3 c1, double3 c2)
    {
        Unsafe.SkipInit(out this);
        this.c0.vector = c0.vector;
        this.c1.vector = c1.vector;
        this.c2.vector = c2.vector;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public double3x3(double m00, double m10, double m20, double m01, double m11, double m21, double m02, double m12, double m22)
    {
        Unsafe.SkipInit(out this);
        this.c0.vector = Vector256.Create(m00, m10, m20, 0d);
        this.c1.vector = Vector256.Create(m01, m11, m21, 0d);
        this.c2.vector = Vector256.Create(m02, m12, m22, 0d);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3x3 RowMajor(double m00, double m01, double m02, double m10, double m11, double m12, double m20, double m21, double m22) 
        => new(m00, m10, m20, m01, m11, m21, m02, m12, m22);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public double3x3(double value)
    {
        Unsafe.SkipInit(out this);
        this.c0.vector = Vector256.Create(value);
        this.c1.vector = Vector256.Create(value);
        this.c2.vector = Vector256.Create(value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public double3x3(double3 value)
    {
        Unsafe.SkipInit(out this);
        this.c0.vector = value.vector;
        this.c1.vector = value.vector;
        this.c2.vector = value.vector;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public double3x3(double4x4 m)
    {
        this.c0 = m.c0.xyz;
        this.c1 = m.c1.xyz;
        this.c2 = m.c2.xyz;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator double3x3(double value) => new(value);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator double3x3(double3 value) => new(value);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static explicit operator double(double3x3 value) => value.m00;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static explicit operator double3(double3x3 value) => value.c0;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static explicit operator uint3x3(double3x3 self) => new((uint3)self.c0, (uint3)self.c1, (uint3)self.c2);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static explicit operator uint3x3a(double3x3 self) => new((uint3a)self.c0, (uint3a)self.c1, (uint3a)self.c2);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static explicit operator int3x3(double3x3 self) => new((int3)self.c0, (int3)self.c1, (int3)self.c2);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static explicit operator int3x3a(double3x3 self) => new((int3a)self.c0, (int3a)self.c1, (int3a)self.c2);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static explicit operator ulong3x3(double3x3 self) => new((ulong3)self.c0, (ulong3)self.c1, (ulong3)self.c2);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static explicit operator ulong3x3a(double3x3 self) => new((ulong3a)self.c0, (ulong3a)self.c1, (ulong3a)self.c2);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static explicit operator long3x3(double3x3 self) => new((long3)self.c0, (long3)self.c1, (long3)self.c2);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static explicit operator long3x3a(double3x3 self) => new((long3a)self.c0, (long3a)self.c1, (long3a)self.c2);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static explicit operator float3x3(double3x3 self) => new((float3)self.c0, (float3)self.c1, (float3)self.c2);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static explicit operator float3x3a(double3x3 self) => new((float3a)self.c0, (float3a)self.c1, (float3a)self.c2);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static explicit operator decimal3x3(double3x3 self) => new((decimal3)self.c0, (decimal3)self.c1, (decimal3)self.c2);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static explicit operator decimal3x3a(double3x3 self) => new((decimal3a)self.c0, (decimal3a)self.c1, (decimal3a)self.c2);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static explicit operator Half3x3(double3x3 self) => new((Half3)self.c0, (Half3)self.c1, (Half3)self.c2);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static explicit operator Half3x3a(double3x3 self) => new((Half3a)self.c0, (Half3a)self.c1, (Half3a)self.c2);

    #endregion

    //////////////////////////////////////////////////////////////////////////////////////////////////// Equals

    #region Equals

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator ==(double3x3 left, double3x3 right) 
        => left.c0 == right.c0 && left.c1 == right.c1 && left.c2 == right.c2;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator !=(double3x3 left, double3x3 right) 
        => left.c0 != right.c0 || left.c1 != right.c1 || left.c2 != right.c2;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool Equals(double3x3 other) 
        => this == other;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override bool Equals(object? o) 
        => o is double3x3 other && Equals(other);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override int GetHashCode() 
        => HashCode.Combine(this.c0, this.c1, this.c2);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public int3x3 Hash() 
        => new(this.c0.GetHashCode(), this.c1.GetHashCode(), this.c2.GetHashCode());

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    static bool3x3 IEqualityOperators<double3x3, double3x3, bool3x3>.operator ==(double3x3 left, double3x3 right) 
        => new(left.c0 == right.c0, left.c1 == right.c1, left.c2 == right.c2);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    static bool3x3 IEqualityOperators<double3x3, double3x3, bool3x3>.operator !=(double3x3 left, double3x3 right) 
        => new(left.c0 != right.c0, left.c1 != right.c1, left.c2 != right.c2);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool3x3 VEq(double3x3 other) 
        => new(this.c0 == other.c0, this.c1 == other.c1, this.c2 == other.c2);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool3x3 VNe(double3x3 other) 
        => new(this.c0 != other.c0, this.c1 != other.c1, this.c2 != other.c2);



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool3x3 operator >(double3x3 left, double3x3 right) => new(left.c0 > right.c0, left.c1 > right.c1, left.c2 > right.c2);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool3x3 operator <(double3x3 left, double3x3 right) => new(left.c0 < right.c0, left.c1 < right.c1, left.c2 < right.c2);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool3x3 operator >=(double3x3 left, double3x3 right) => new(left.c0 >= right.c0, left.c1 >= right.c1, left.c2 >= right.c2);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool3x3 operator <=(double3x3 left, double3x3 right) => new(left.c0 <= right.c0, left.c1 <= right.c1, left.c2 <= right.c2);





    #endregion


    //////////////////////////////////////////////////////////////////////////////////////////////////// Arithmetic

    #region Arithmetic

    public static double3x3 AdditiveIdentity 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(0d);
    }

    public static double3x3 MultiplicativeIdentity 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(1d);
    }


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3x3 operator +(double3x3 left, double3x3 right) 
        => new(left.c0 + right.c0, left.c1 + right.c1, left.c2 + right.c2);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3x3 operator -(double3x3 left, double3x3 right) 
        => new(left.c0 - right.c0, left.c1 - right.c1, left.c2 - right.c2);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3x3 operator *(double3x3 left, double3x3 right) 
        => new(left.c0 * right.c0, left.c1 * right.c1, left.c2 * right.c2);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3x3 operator /(double3x3 left, double3x3 right) 
        => new(left.c0 / right.c0, left.c1 / right.c1, left.c2 / right.c2);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3x3 operator %(double3x3 left, double3x3 right) 
        => new(left.c0 % right.c0, left.c1 % right.c1, left.c2 % right.c2);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3x3 operator +(double3x3 left, double3 right) => new(left.c0 + right, left.c1 + right, left.c2 + right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3x3 operator -(double3x3 left, double3 right) => new(left.c0 - right, left.c1 - right, left.c2 - right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3x3 operator *(double3x3 left, double3 right) => new(left.c0 * right, left.c1 * right, left.c2 * right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3x3 operator /(double3x3 left, double3 right) => new(left.c0 / right, left.c1 / right, left.c2 / right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3x3 operator %(double3x3 left, double3 right) => new(left.c0 % right, left.c1 % right, left.c2 % right);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3x3 operator +(double3 left, double3x3 right) => new(left + right.c0, left + right.c1, left + right.c2);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3x3 operator -(double3 left, double3x3 right) => new(left - right.c0, left - right.c1, left - right.c2);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3x3 operator *(double3 left, double3x3 right) => new(left * right.c0, left * right.c1, left * right.c2);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3x3 operator /(double3 left, double3x3 right) => new(left / right.c0, left / right.c1, left / right.c2);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3x3 operator %(double3 left, double3x3 right) => new(left % right.c0, left % right.c1, left % right.c2);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3x3 operator +(double3x3 left, double right) => new(left.c0 + right, left.c1 + right, left.c2 + right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3x3 operator -(double3x3 left, double right) => new(left.c0 - right, left.c1 - right, left.c2 - right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3x3 operator *(double3x3 left, double right) => new(left.c0 * right, left.c1 * right, left.c2 * right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3x3 operator /(double3x3 left, double right) => new(left.c0 / right, left.c1 / right, left.c2 / right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3x3 operator %(double3x3 left, double right) => new(left.c0 % right, left.c1 % right, left.c2 % right);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3x3 operator +(double left, double3x3 right) => new(left + right.c0, left + right.c1, left + right.c2);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3x3 operator -(double left, double3x3 right) => new(left - right.c0, left - right.c1, left - right.c2);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3x3 operator *(double left, double3x3 right) => new(left * right.c0, left * right.c1, left * right.c2);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3x3 operator /(double left, double3x3 right) => new(left / right.c0, left / right.c1, left / right.c2);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3x3 operator %(double left, double3x3 right) => new(left % right.c0, left % right.c1, left % right.c2);

    
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3x3 operator -(double3x3 self) => new(-self.c0, -self.c1, -self.c2);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3x3 operator +(double3x3 self) => new(+self.c0, +self.c1, +self.c2);

    #endregion

    //////////////////////////////////////////////////////////////////////////////////////////////////// ToString

    #region ToString

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override string ToString() => $"double3x3({this.c0}, {this.c1}, {this.c2})";

    #endregion

    //////////////////////////////////////////////////////////////////////////////////////////////////// Methods

    #region Methods



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3x3 transpose(double3x3 v) => new(
        v.c0.x, v.c0.y, v.c0.z,
        v.c1.x, v.c1.y, v.c1.z,
        v.c2.x, v.c2.y, v.c2.z
    );

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public readonly double3x3 transpose() => transpose(this);

    #endregion
}

public static unsafe partial class vectors
{


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3x3 double3x3(double3 c0, double3 c1, double3 c2) => new(c0, c1, c2);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3x3 double3x3(double m00, double m10, double m20, double m01, double m11, double m21, double m02, double m12, double m22) 
        => new(m00, m10, m20, m01, m11, m21, m02, m12, m22);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3x3 double3x3(double value) => new(value);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3x3 double3x3(double3 value) => new(value);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3x3 double3x3(double4x4 m) => new(m);


} // vectors

public static unsafe partial class math
{

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3 mul(double3 a, double3x3 b) => new(dot(a, b.c0), dot(a, b.c1), dot(a, b.c2));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3 mul(double3x3 a, double3 b) => a.c0 * b.x + a.c1 * b.y + a.c2 * b.z;


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3x2 mul(double3x3 a, double3x2 b) => new(
        a.c0 * b.c0.x + a.c1 * b.c0.y + a.c2 * b.c0.z,
        a.c0 * b.c1.x + a.c1 * b.c1.y + a.c2 * b.c1.z
    );

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3x3 mul(double3x3 a, double3x3 b) => new(
        a.c0 * b.c0.x + a.c1 * b.c0.y + a.c2 * b.c0.z,
        a.c0 * b.c1.x + a.c1 * b.c1.y + a.c2 * b.c1.z,
        a.c0 * b.c2.x + a.c1 * b.c2.y + a.c2 * b.c2.z
    );

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3x4 mul(double3x3 a, double3x4 b) => new(
        a.c0 * b.c0.x + a.c1 * b.c0.y + a.c2 * b.c0.z,
        a.c0 * b.c1.x + a.c1 * b.c1.y + a.c2 * b.c1.z,
        a.c0 * b.c2.x + a.c1 * b.c2.y + a.c2 * b.c2.z,
        a.c0 * b.c3.x + a.c1 * b.c3.y + a.c2 * b.c3.z
    );


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3x3 min(double3x3 x, double3x3 y) => new(min(x.c0, y.c0), min(x.c1, y.c1), min(x.c2, y.c2));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3x3 max(double3x3 x, double3x3 y) => new(max(x.c0, y.c0), max(x.c1, y.c1), max(x.c2, y.c2));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3x3 min(double3x3 x, double3x3 y, double3x3 z) => new(min(x.c0, y.c0, z.c0), min(x.c1, y.c1, z.c1), min(x.c2, y.c2, z.c2));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3x3 max(double3x3 x, double3x3 y, double3x3 z) => new(max(x.c0, y.c0, z.c0), max(x.c1, y.c1, z.c1), max(x.c2, y.c2, z.c2));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3x3 abs(double3x3 x) => new(abs(x.c0), abs(x.c1), abs(x.c2));



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3x3 lerp(double3x3 s, double3x3 x, double3x3 y) => x + s * (y - x);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3x3 unlerp(double3x3 x, double3x3 a, double3x3 b) => (x - a) / (b - a);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3x3 remap(double3x3 x, double3x3 a, double3x3 b, double3x3 c, double3x3 d) => lerp(c, d, unlerp(a, b, x));


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3x3 floor(double3x3 x) => new(floor(x.c0), floor(x.c1), floor(x.c2));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3x3 ceil(double3x3 x) => new(ceil(x.c0), ceil(x.c1), ceil(x.c2));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3x3 round(double3x3 x) => new(round(x.c0), round(x.c1), round(x.c2));



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3 csum(double3x3 x) => x.c0 + x.c1 + x.c2;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double3 rsum(double3x3 x) => new(x.c0.x + x.c1.x + x.c2.x, x.c0.y + x.c1.y + x.c2.y, x.c0.z + x.c1.z + x.c2.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double msum(double3x3 x) => csum(csum(x));



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int3x3 pop_cnt(double3x3 x) => new(pop_cnt(x.c0), pop_cnt(x.c1), pop_cnt(x.c2));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int count_bits(double3x3 x) => msum(pop_cnt(x));

} // class math

namespace Json
{

public class Double3x3JsonConverter : JsonConverter<double3x3>
{
    private static readonly Type v_type = typeof(double3);

    public override double3x3 Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        Unsafe.SkipInit(out double3x3 result);
        if (reader.TokenType is not JsonTokenType.StartArray) throw new JsonException();
        var conv = (JsonConverter<double3>)options.GetConverter(v_type);
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

    public override void Write(Utf8JsonWriter writer, double3x3 value, JsonSerializerOptions options)
    {
        writer.WriteStartArray();
        var conv = (JsonConverter<double3>)options.GetConverter(v_type);
        conv.Write(writer, value.c0, options);
        conv.Write(writer, value.c1, options);
        conv.Write(writer, value.c2, options);
        writer.WriteEndArray();
    }
} // class JsonConverter

} // namespace Json

} // namespace CCluster.Mathematics
