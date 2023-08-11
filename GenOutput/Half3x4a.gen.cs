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

/// <summary>A 3x4 matrix of Half</summary>
[Serializable]
[JsonConverter(typeof(Half3x4AJsonConverter))]
[StructLayout(LayoutKind.Explicit, Size = 24, Pack = 2)]
public unsafe partial struct Half3x4a :
    IEquatable<Half3x4a>, IEqualityOperators<Half3x4a, Half3x4a, bool>, IEqualityOperators<Half3x4a, Half3x4a, bool3x4a>,

    IAdditionOperators<Half3x4a, Half3x4a, Half3x4a>, IAdditiveIdentity<Half3x4a, Half3x4a>, IUnaryPlusOperators<Half3x4a, Half3x4a>,
    ISubtractionOperators<Half3x4a, Half3x4a, Half3x4a>, IUnaryNegationOperators<Half3x4a, Half3x4a>,
    IMultiplyOperators<Half3x4a, Half3x4a, Half3x4a>, IMultiplicativeIdentity<Half3x4a, Half3x4a>,
    IDivisionOperators<Half3x4a, Half3x4a, Half3x4a>,
    IModulusOperators<Half3x4a, Half3x4a, Half3x4a>,

    IMatrix3x4<Half>, IMatrixSelf<Half3x4a>
{
    //////////////////////////////////////////////////////////////////////////////////////////////////// Fields

    #region Fields

    /// <summary>Column 0 of the matrix</summary>
    [FieldOffset(0)]
    public Half3a c0;

    /// <summary>Column 1 of the matrix</summary>
    [FieldOffset(6)]
    public Half3a c1;

    /// <summary>Column 2 of the matrix</summary>
    [FieldOffset(12)]
    public Half3a c2;

    /// <summary>Column 3 of the matrix</summary>
    [FieldOffset(18)]
    public Half3a c3;


    /// <summary>Row 0 column 0 of the matrix</summary>
    [FieldOffset(0)]
    public Half m00;

    /// <summary>Row 1 column 0 of the matrix</summary>
    [FieldOffset(2)]
    public Half m10;

    /// <summary>Row 2 column 0 of the matrix</summary>
    [FieldOffset(4)]
    public Half m20;

    /// <summary>Row 0 column 1 of the matrix</summary>
    [FieldOffset(6)]
    public Half m01;

    /// <summary>Row 1 column 1 of the matrix</summary>
    [FieldOffset(8)]
    public Half m11;

    /// <summary>Row 2 column 1 of the matrix</summary>
    [FieldOffset(10)]
    public Half m21;

    /// <summary>Row 0 column 2 of the matrix</summary>
    [FieldOffset(12)]
    public Half m02;

    /// <summary>Row 1 column 2 of the matrix</summary>
    [FieldOffset(14)]
    public Half m12;

    /// <summary>Row 2 column 2 of the matrix</summary>
    [FieldOffset(16)]
    public Half m22;

    /// <summary>Row 0 column 3 of the matrix</summary>
    [FieldOffset(18)]
    public Half m03;

    /// <summary>Row 1 column 3 of the matrix</summary>
    [FieldOffset(20)]
    public Half m13;

    /// <summary>Row 2 column 3 of the matrix</summary>
    [FieldOffset(22)]
    public Half m23;

    #endregion

    //////////////////////////////////////////////////////////////////////////////////////////////////// Constants

    #region Constants

    public static readonly Half3x4a zero = new(Half.Zero);

    public static readonly Half3x4a one = new(Half.One);

    static Half3x4a IMatrixSelf<Half3x4a>.Zero 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => zero;
    }

    static Half3x4a IMatrixSelf<Half3x4a>.One 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => one;
    }


    #endregion

    //////////////////////////////////////////////////////////////////////////////////////////////////// Ctor

    #region Ctor


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public Half3x4a(Half3a c0, Half3a c1, Half3a c2, Half3a c3)
    {
        Unsafe.SkipInit(out this);
        this.c0 = c0;
        this.c1 = c1;
        this.c2 = c2;
        this.c3 = c3;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public Half3x4a(Half m00, Half m10, Half m20, Half m01, Half m11, Half m21, Half m02, Half m12, Half m22, Half m03, Half m13, Half m23)
    {
        Unsafe.SkipInit(out this);
        this.c0 = new(m00, m10, m20);
        this.c1 = new(m01, m11, m21);
        this.c2 = new(m02, m12, m22);
        this.c3 = new(m03, m13, m23);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half3x4a RowMajor(Half m00, Half m01, Half m02, Half m03, Half m10, Half m11, Half m12, Half m13, Half m20, Half m21, Half m22, Half m23) 
        => new(m00, m10, m20, m01, m11, m21, m02, m12, m22, m03, m13, m23);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public Half3x4a(Half value)
    {
        Unsafe.SkipInit(out this);
        this.c0 = new(value);
        this.c1 = new(value);
        this.c2 = new(value);
        this.c3 = new(value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public Half3x4a(Half3a value)
    {
        Unsafe.SkipInit(out this);
        this.c0 = value;
        this.c1 = value;
        this.c2 = value;
        this.c3 = value;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator Half3x4a(Half value) => new(value);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator Half3x4a(Half3a value) => new(value);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static explicit operator Half(Half3x4a value) => value.m00;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static explicit operator Half3a(Half3x4a value) => value.c0;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator Half3x4a(Half3x4 value) => new(value.c0, value.c1, value.c2, value.c3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator Half3x4(Half3x4a value) => new(value.c0, value.c1, value.c2, value.c3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static explicit operator uint3x4(Half3x4a self) => new((uint3)self.c0, (uint3)self.c1, (uint3)self.c2, (uint3)self.c3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static explicit operator uint3x4a(Half3x4a self) => new((uint3a)self.c0, (uint3a)self.c1, (uint3a)self.c2, (uint3a)self.c3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static explicit operator int3x4(Half3x4a self) => new((int3)self.c0, (int3)self.c1, (int3)self.c2, (int3)self.c3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static explicit operator int3x4a(Half3x4a self) => new((int3a)self.c0, (int3a)self.c1, (int3a)self.c2, (int3a)self.c3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static explicit operator ulong3x4(Half3x4a self) => new((ulong3)self.c0, (ulong3)self.c1, (ulong3)self.c2, (ulong3)self.c3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static explicit operator ulong3x4a(Half3x4a self) => new((ulong3a)self.c0, (ulong3a)self.c1, (ulong3a)self.c2, (ulong3a)self.c3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static explicit operator long3x4(Half3x4a self) => new((long3)self.c0, (long3)self.c1, (long3)self.c2, (long3)self.c3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static explicit operator long3x4a(Half3x4a self) => new((long3a)self.c0, (long3a)self.c1, (long3a)self.c2, (long3a)self.c3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static explicit operator float3x4(Half3x4a self) => new((float3)self.c0, (float3)self.c1, (float3)self.c2, (float3)self.c3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static explicit operator float3x4a(Half3x4a self) => new((float3a)self.c0, (float3a)self.c1, (float3a)self.c2, (float3a)self.c3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static explicit operator double3x4(Half3x4a self) => new((double3)self.c0, (double3)self.c1, (double3)self.c2, (double3)self.c3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static explicit operator double3x4a(Half3x4a self) => new((double3a)self.c0, (double3a)self.c1, (double3a)self.c2, (double3a)self.c3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static explicit operator decimal3x4(Half3x4a self) => new((decimal3)self.c0, (decimal3)self.c1, (decimal3)self.c2, (decimal3)self.c3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static explicit operator decimal3x4a(Half3x4a self) => new((decimal3a)self.c0, (decimal3a)self.c1, (decimal3a)self.c2, (decimal3a)self.c3);

    #endregion

    //////////////////////////////////////////////////////////////////////////////////////////////////// Equals

    #region Equals

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator ==(Half3x4a left, Half3x4a right) 
        => left.c0 == right.c0 && left.c1 == right.c1 && left.c2 == right.c2 && left.c3 == right.c3;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator !=(Half3x4a left, Half3x4a right) 
        => left.c0 != right.c0 || left.c1 != right.c1 || left.c2 != right.c2 || left.c3 != right.c3;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool Equals(Half3x4a other) 
        => this == other;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override bool Equals(object? o) 
        => o is Half3x4a other && Equals(other);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override int GetHashCode() 
        => HashCode.Combine(this.c0, this.c1, this.c2, this.c3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public int3x4a Hash() 
        => new(this.c0.GetHashCode(), this.c1.GetHashCode(), this.c2.GetHashCode(), this.c3.GetHashCode());

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    static bool3x4a IEqualityOperators<Half3x4a, Half3x4a, bool3x4a>.operator ==(Half3x4a left, Half3x4a right) 
        => new(left.c0 == right.c0, left.c1 == right.c1, left.c2 == right.c2, left.c3 == right.c3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    static bool3x4a IEqualityOperators<Half3x4a, Half3x4a, bool3x4a>.operator !=(Half3x4a left, Half3x4a right) 
        => new(left.c0 != right.c0, left.c1 != right.c1, left.c2 != right.c2, left.c3 != right.c3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool3x4a VEq(Half3x4a other) 
        => new(this.c0 == other.c0, this.c1 == other.c1, this.c2 == other.c2, this.c3 == other.c3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool3x4a VNe(Half3x4a other) 
        => new(this.c0 != other.c0, this.c1 != other.c1, this.c2 != other.c2, this.c3 != other.c3);



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool3x4a operator >(Half3x4a left, Half3x4a right) => new(left.c0 > right.c0, left.c1 > right.c1, left.c2 > right.c2, left.c3 > right.c3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool3x4a operator <(Half3x4a left, Half3x4a right) => new(left.c0 < right.c0, left.c1 < right.c1, left.c2 < right.c2, left.c3 < right.c3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool3x4a operator >=(Half3x4a left, Half3x4a right) => new(left.c0 >= right.c0, left.c1 >= right.c1, left.c2 >= right.c2, left.c3 >= right.c3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool3x4a operator <=(Half3x4a left, Half3x4a right) => new(left.c0 <= right.c0, left.c1 <= right.c1, left.c2 <= right.c2, left.c3 <= right.c3);





    #endregion


    //////////////////////////////////////////////////////////////////////////////////////////////////// Arithmetic

    #region Arithmetic

    public static Half3x4a AdditiveIdentity 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(Half.Zero);
    }

    public static Half3x4a MultiplicativeIdentity 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(Half.One);
    }


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half3x4a operator +(Half3x4a left, Half3x4a right) 
        => new(left.c0 + right.c0, left.c1 + right.c1, left.c2 + right.c2, left.c3 + right.c3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half3x4a operator -(Half3x4a left, Half3x4a right) 
        => new(left.c0 - right.c0, left.c1 - right.c1, left.c2 - right.c2, left.c3 - right.c3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half3x4a operator *(Half3x4a left, Half3x4a right) 
        => new(left.c0 * right.c0, left.c1 * right.c1, left.c2 * right.c2, left.c3 * right.c3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half3x4a operator /(Half3x4a left, Half3x4a right) 
        => new(left.c0 / right.c0, left.c1 / right.c1, left.c2 / right.c2, left.c3 / right.c3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half3x4a operator %(Half3x4a left, Half3x4a right) 
        => new(left.c0 % right.c0, left.c1 % right.c1, left.c2 % right.c2, left.c3 % right.c3);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half3x4a operator +(Half3x4a left, Half3a right) => new(left.c0 + right, left.c1 + right, left.c2 + right, left.c3 + right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half3x4a operator -(Half3x4a left, Half3a right) => new(left.c0 - right, left.c1 - right, left.c2 - right, left.c3 - right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half3x4a operator *(Half3x4a left, Half3a right) => new(left.c0 * right, left.c1 * right, left.c2 * right, left.c3 * right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half3x4a operator /(Half3x4a left, Half3a right) => new(left.c0 / right, left.c1 / right, left.c2 / right, left.c3 / right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half3x4a operator %(Half3x4a left, Half3a right) => new(left.c0 % right, left.c1 % right, left.c2 % right, left.c3 % right);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half3x4a operator +(Half3a left, Half3x4a right) => new(left + right.c0, left + right.c1, left + right.c2, left + right.c3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half3x4a operator -(Half3a left, Half3x4a right) => new(left - right.c0, left - right.c1, left - right.c2, left - right.c3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half3x4a operator *(Half3a left, Half3x4a right) => new(left * right.c0, left * right.c1, left * right.c2, left * right.c3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half3x4a operator /(Half3a left, Half3x4a right) => new(left / right.c0, left / right.c1, left / right.c2, left / right.c3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half3x4a operator %(Half3a left, Half3x4a right) => new(left % right.c0, left % right.c1, left % right.c2, left % right.c3);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half3x4a operator +(Half3x4a left, Half right) => new(left.c0 + right, left.c1 + right, left.c2 + right, left.c3 + right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half3x4a operator -(Half3x4a left, Half right) => new(left.c0 - right, left.c1 - right, left.c2 - right, left.c3 - right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half3x4a operator *(Half3x4a left, Half right) => new(left.c0 * right, left.c1 * right, left.c2 * right, left.c3 * right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half3x4a operator /(Half3x4a left, Half right) => new(left.c0 / right, left.c1 / right, left.c2 / right, left.c3 / right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half3x4a operator %(Half3x4a left, Half right) => new(left.c0 % right, left.c1 % right, left.c2 % right, left.c3 % right);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half3x4a operator +(Half left, Half3x4a right) => new(left + right.c0, left + right.c1, left + right.c2, left + right.c3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half3x4a operator -(Half left, Half3x4a right) => new(left - right.c0, left - right.c1, left - right.c2, left - right.c3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half3x4a operator *(Half left, Half3x4a right) => new(left * right.c0, left * right.c1, left * right.c2, left * right.c3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half3x4a operator /(Half left, Half3x4a right) => new(left / right.c0, left / right.c1, left / right.c2, left / right.c3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half3x4a operator %(Half left, Half3x4a right) => new(left % right.c0, left % right.c1, left % right.c2, left % right.c3);

    
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half3x4a operator -(Half3x4a self) => new(-self.c0, -self.c1, -self.c2, -self.c3);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half3x4a operator +(Half3x4a self) => new(+self.c0, +self.c1, +self.c2, +self.c3);

    #endregion

    //////////////////////////////////////////////////////////////////////////////////////////////////// ToString

    #region ToString

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override string ToString() => $"Half3x4a({this.c0}, {this.c1}, {this.c2}, {this.c3})";

    #endregion

    //////////////////////////////////////////////////////////////////////////////////////////////////// Methods

    #region Methods



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half3x4a transpose(Half3x4a v) => new(
        v.c0.x, v.c0.y, v.c0.z,
        v.c1.x, v.c1.y, v.c1.z,
        v.c2.x, v.c2.y, v.c2.z,
        v.c3.x, v.c3.y, v.c3.z
    );

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public readonly Half3x4a transpose() => transpose(this);

    #endregion
}

public static unsafe partial class vectors
{


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half3x4a Half3x4a(Half3a c0, Half3a c1, Half3a c2, Half3a c3) => new(c0, c1, c2, c3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half3x4a Half3x4a(Half m00, Half m10, Half m20, Half m01, Half m11, Half m21, Half m02, Half m12, Half m22, Half m03, Half m13, Half m23) 
        => new(m00, m10, m20, m01, m11, m21, m02, m12, m22, m03, m13, m23);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half3x4a Half3x4a(Half value) => new(value);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half3x4a Half3x4a(Half3a value) => new(value);


} // vectors

public static unsafe partial class math
{

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half4 mul(Half3a a, Half3x4a b) => new(dot(a, b.c0), dot(a, b.c1), dot(a, b.c2), dot(a, b.c3));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half3a mul(Half3x4a a, Half4 b) => a.c0 * b.x + a.c1 * b.y + a.c2 * b.z + a.c3 * b.w;


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half3x2a mul(Half3x4a a, Half4x2 b) => new(
        a.c0 * b.c0.x + a.c1 * b.c0.y + a.c2 * b.c0.z + a.c3 * b.c0.w,
        a.c0 * b.c1.x + a.c1 * b.c1.y + a.c2 * b.c1.z + a.c3 * b.c1.w
    );

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half3x3a mul(Half3x4a a, Half4x3 b) => new(
        a.c0 * b.c0.x + a.c1 * b.c0.y + a.c2 * b.c0.z + a.c3 * b.c0.w,
        a.c0 * b.c1.x + a.c1 * b.c1.y + a.c2 * b.c1.z + a.c3 * b.c1.w,
        a.c0 * b.c2.x + a.c1 * b.c2.y + a.c2 * b.c2.z + a.c3 * b.c2.w
    );

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half3x4a mul(Half3x4a a, Half4x4 b) => new(
        a.c0 * b.c0.x + a.c1 * b.c0.y + a.c2 * b.c0.z + a.c3 * b.c0.w,
        a.c0 * b.c1.x + a.c1 * b.c1.y + a.c2 * b.c1.z + a.c3 * b.c1.w,
        a.c0 * b.c2.x + a.c1 * b.c2.y + a.c2 * b.c2.z + a.c3 * b.c2.w,
        a.c0 * b.c3.x + a.c1 * b.c3.y + a.c2 * b.c3.z + a.c3 * b.c3.w
    );


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half3x4a min(Half3x4a x, Half3x4a y) => new(min(x.c0, y.c0), min(x.c1, y.c1), min(x.c2, y.c2), min(x.c3, y.c3));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half3x4a max(Half3x4a x, Half3x4a y) => new(max(x.c0, y.c0), max(x.c1, y.c1), max(x.c2, y.c2), max(x.c3, y.c3));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half3x4a min(Half3x4a x, Half3x4a y, Half3x4a z) => new(min(x.c0, y.c0, z.c0), min(x.c1, y.c1, z.c1), min(x.c2, y.c2, z.c2), min(x.c3, y.c3, z.c3));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half3x4a max(Half3x4a x, Half3x4a y, Half3x4a z) => new(max(x.c0, y.c0, z.c0), max(x.c1, y.c1, z.c1), max(x.c2, y.c2, z.c2), max(x.c3, y.c3, z.c3));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half3x4a abs(Half3x4a x) => new(abs(x.c0), abs(x.c1), abs(x.c2), abs(x.c3));



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half3x4a lerp(Half3x4a s, Half3x4a x, Half3x4a y) => x + s * (y - x);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half3x4a unlerp(Half3x4a x, Half3x4a a, Half3x4a b) => (x - a) / (b - a);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half3x4a remap(Half3x4a x, Half3x4a a, Half3x4a b, Half3x4a c, Half3x4a d) => lerp(c, d, unlerp(a, b, x));


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half3x4a floor(Half3x4a x) => new(floor(x.c0), floor(x.c1), floor(x.c2), floor(x.c3));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half3x4a ceil(Half3x4a x) => new(ceil(x.c0), ceil(x.c1), ceil(x.c2), ceil(x.c3));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half3x4a round(Half3x4a x) => new(round(x.c0), round(x.c1), round(x.c2), round(x.c3));



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half3a csum(Half3x4a x) => x.c0 + x.c1 + x.c2 + x.c3;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half3a rsum(Half3x4a x) => new(x.c0.x + x.c1.x + x.c2.x + x.c3.x, x.c0.y + x.c1.y + x.c2.y + x.c3.y, x.c0.z + x.c1.z + x.c2.z + x.c3.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half msum(Half3x4a x) => csum(csum(x));



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int3x4a pop_cnt(Half3x4a x) => new(pop_cnt(x.c0), pop_cnt(x.c1), pop_cnt(x.c2), pop_cnt(x.c3));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int count_bits(Half3x4a x) => msum(pop_cnt(x));

} // class math

namespace Json
{

public class Half3x4AJsonConverter : JsonConverter<Half3x4a>
{
    private static readonly Type v_type = typeof(Half3a);

    public override Half3x4a Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        Unsafe.SkipInit(out Half3x4a result);
        if (reader.TokenType is not JsonTokenType.StartArray) throw new JsonException();
        var conv = (JsonConverter<Half3a>)options.GetConverter(v_type);
        reader.Read();
        result.c0 = conv.Read(ref reader, v_type, options);
        reader.Read();
        result.c1 = conv.Read(ref reader, v_type, options);
        reader.Read();
        result.c2 = conv.Read(ref reader, v_type, options);
        reader.Read();
        result.c3 = conv.Read(ref reader, v_type, options);
        reader.Read();
        if (reader.TokenType is not JsonTokenType.EndArray) throw new JsonException();
        return result;
    }

    public override void Write(Utf8JsonWriter writer, Half3x4a value, JsonSerializerOptions options)
    {
        writer.WriteStartArray();
        var conv = (JsonConverter<Half3a>)options.GetConverter(v_type);
        conv.Write(writer, value.c0, options);
        conv.Write(writer, value.c1, options);
        conv.Write(writer, value.c2, options);
        conv.Write(writer, value.c3, options);
        writer.WriteEndArray();
    }
} // class JsonConverter

} // namespace Json

} // namespace CCluster.Mathematics
