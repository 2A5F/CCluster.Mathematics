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

/// <summary>A 4x4 matrix of decimal</summary>
[Serializable]
[StructLayout(LayoutKind.Explicit, Size = 256, Pack = 16)]
public unsafe partial struct decimal4x4 :
    IEquatable<decimal4x4>, IEqualityOperators<decimal4x4, decimal4x4, bool>, IEqualityOperators<decimal4x4, decimal4x4, bool4x4>,

    IAdditionOperators<decimal4x4, decimal4x4, decimal4x4>, IAdditiveIdentity<decimal4x4, decimal4x4>, IUnaryPlusOperators<decimal4x4, decimal4x4>,
    ISubtractionOperators<decimal4x4, decimal4x4, decimal4x4>, IUnaryNegationOperators<decimal4x4, decimal4x4>,
    IMultiplyOperators<decimal4x4, decimal4x4, decimal4x4>, IMultiplicativeIdentity<decimal4x4, decimal4x4>,
    IDivisionOperators<decimal4x4, decimal4x4, decimal4x4>,
    IModulusOperators<decimal4x4, decimal4x4, decimal4x4>,

    IMatrix4x4<decimal>, IMatrixSelf<decimal4x4>, IMatrixIdentity<decimal4x4>
{
    //////////////////////////////////////////////////////////////////////////////////////////////////// Fields

    #region Fields

    /// <summary>Column 0 of the matrix</summary>
    [FieldOffset(0)]
    public decimal4 c0;

    /// <summary>Column 1 of the matrix</summary>
    [FieldOffset(64)]
    public decimal4 c1;

    /// <summary>Column 2 of the matrix</summary>
    [FieldOffset(128)]
    public decimal4 c2;

    /// <summary>Column 3 of the matrix</summary>
    [FieldOffset(192)]
    public decimal4 c3;


    /// <summary>Row 0 column 0 of the matrix</summary>
    [FieldOffset(0)]
    public decimal m00;

    /// <summary>Row 1 column 0 of the matrix</summary>
    [FieldOffset(16)]
    public decimal m10;

    /// <summary>Row 2 column 0 of the matrix</summary>
    [FieldOffset(32)]
    public decimal m20;

    /// <summary>Row 3 column 0 of the matrix</summary>
    [FieldOffset(48)]
    public decimal m30;

    /// <summary>Row 0 column 1 of the matrix</summary>
    [FieldOffset(64)]
    public decimal m01;

    /// <summary>Row 1 column 1 of the matrix</summary>
    [FieldOffset(80)]
    public decimal m11;

    /// <summary>Row 2 column 1 of the matrix</summary>
    [FieldOffset(96)]
    public decimal m21;

    /// <summary>Row 3 column 1 of the matrix</summary>
    [FieldOffset(112)]
    public decimal m31;

    /// <summary>Row 0 column 2 of the matrix</summary>
    [FieldOffset(128)]
    public decimal m02;

    /// <summary>Row 1 column 2 of the matrix</summary>
    [FieldOffset(144)]
    public decimal m12;

    /// <summary>Row 2 column 2 of the matrix</summary>
    [FieldOffset(160)]
    public decimal m22;

    /// <summary>Row 3 column 2 of the matrix</summary>
    [FieldOffset(176)]
    public decimal m32;

    /// <summary>Row 0 column 3 of the matrix</summary>
    [FieldOffset(192)]
    public decimal m03;

    /// <summary>Row 1 column 3 of the matrix</summary>
    [FieldOffset(208)]
    public decimal m13;

    /// <summary>Row 2 column 3 of the matrix</summary>
    [FieldOffset(224)]
    public decimal m23;

    /// <summary>Row 3 column 3 of the matrix</summary>
    [FieldOffset(240)]
    public decimal m33;

    #endregion

    //////////////////////////////////////////////////////////////////////////////////////////////////// Constants

    #region Constants

    public static readonly decimal4x4 identity = new decimal4x4(
        1m, 0m, 0m, 0m,
        0m, 1m, 0m, 0m,
        0m, 0m, 1m, 0m,
        0m, 0m, 0m, 1m
    );

    public static readonly decimal4x4 zero = new(0m);

    public static readonly decimal4x4 one = new(1m);

    static decimal4x4 IMatrixSelf<decimal4x4>.Zero 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => zero;
    }

    static decimal4x4 IMatrixSelf<decimal4x4>.One 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => one;
    }

    static decimal4x4 IMatrixIdentity<decimal4x4>.Identity 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => identity;
    }

    #endregion

    //////////////////////////////////////////////////////////////////////////////////////////////////// Ctor

    #region Ctor


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public decimal4x4(decimal4 c0, decimal4 c1, decimal4 c2, decimal4 c3)
    {
        Unsafe.SkipInit(out this);
        this.c0 = c0;
        this.c1 = c1;
        this.c2 = c2;
        this.c3 = c3;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public decimal4x4(decimal m00, decimal m10, decimal m20, decimal m30, decimal m01, decimal m11, decimal m21, decimal m31, decimal m02, decimal m12, decimal m22, decimal m32, decimal m03, decimal m13, decimal m23, decimal m33)
    {
        Unsafe.SkipInit(out this);
        this.c0 = new(m00, m10, m20, m30);
        this.c1 = new(m01, m11, m21, m31);
        this.c2 = new(m02, m12, m22, m32);
        this.c3 = new(m03, m13, m23, m33);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public decimal4x4(decimal value)
    {
        Unsafe.SkipInit(out this);
        this.c0 = new(value);
        this.c1 = new(value);
        this.c2 = new(value);
        this.c3 = new(value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator decimal4x4(decimal value) => new(value);

    #endregion

    //////////////////////////////////////////////////////////////////////////////////////////////////// Equals

    #region Equals

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator ==(decimal4x4 left, decimal4x4 right) 
        => left.c0 == right.c0 && left.c1 == right.c1 && left.c2 == right.c2 && left.c3 == right.c3;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator !=(decimal4x4 left, decimal4x4 right) 
        => left.c0 != right.c0 || left.c1 != right.c1 || left.c2 != right.c2 || left.c3 != right.c3;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool Equals(decimal4x4 other) 
        => this == other;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override bool Equals(object? o) 
        => o is decimal4x4 other && Equals(other);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override int GetHashCode() 
        => HashCode.Combine(this.c0, this.c1, this.c2, this.c3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public int4x4 Hash() 
        => new(this.c0.GetHashCode(), this.c1.GetHashCode(), this.c2.GetHashCode(), this.c3.GetHashCode());

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    static bool4x4 IEqualityOperators<decimal4x4, decimal4x4, bool4x4>.operator ==(decimal4x4 left, decimal4x4 right) 
        => new(left.c0 == right.c0, left.c1 == right.c1, left.c2 == right.c2, left.c3 == right.c3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    static bool4x4 IEqualityOperators<decimal4x4, decimal4x4, bool4x4>.operator !=(decimal4x4 left, decimal4x4 right) 
        => new(left.c0 != right.c0, left.c1 != right.c1, left.c2 != right.c2, left.c3 != right.c3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool4x4 VEq(decimal4x4 other) 
        => new(this.c0 == other.c0, this.c1 == other.c1, this.c2 == other.c2, this.c3 == other.c3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool4x4 VNe(decimal4x4 other) 
        => new(this.c0 != other.c0, this.c1 != other.c1, this.c2 != other.c2, this.c3 != other.c3);

    #endregion


    //////////////////////////////////////////////////////////////////////////////////////////////////// Arithmetic

    #region Arithmetic

    public static decimal4x4 AdditiveIdentity 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(0m);
    }

    public static decimal4x4 MultiplicativeIdentity 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(1m);
    }


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal4x4 operator +(decimal4x4 left, decimal4x4 right) 
        => new(left.c0 + right.c0, left.c1 + right.c1, left.c2 + right.c2, left.c3 + right.c3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal4x4 operator -(decimal4x4 left, decimal4x4 right) 
        => new(left.c0 - right.c0, left.c1 - right.c1, left.c2 - right.c2, left.c3 - right.c3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal4x4 operator *(decimal4x4 left, decimal4x4 right) 
        => new(left.c0 * right.c0, left.c1 * right.c1, left.c2 * right.c2, left.c3 * right.c3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal4x4 operator /(decimal4x4 left, decimal4x4 right) 
        => new(left.c0 / right.c0, left.c1 / right.c1, left.c2 / right.c2, left.c3 / right.c3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal4x4 operator %(decimal4x4 left, decimal4x4 right) 
        => new(left.c0 % right.c0, left.c1 % right.c1, left.c2 % right.c2, left.c3 % right.c3);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal4x4 operator +(decimal4x4 left, decimal4 right) => new(left.c0 + right, left.c1 + right, left.c2 + right, left.c3 + right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal4x4 operator -(decimal4x4 left, decimal4 right) => new(left.c0 - right, left.c1 - right, left.c2 - right, left.c3 - right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal4x4 operator *(decimal4x4 left, decimal4 right) => new(left.c0 * right, left.c1 * right, left.c2 * right, left.c3 * right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal4x4 operator /(decimal4x4 left, decimal4 right) => new(left.c0 / right, left.c1 / right, left.c2 / right, left.c3 / right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal4x4 operator %(decimal4x4 left, decimal4 right) => new(left.c0 % right, left.c1 % right, left.c2 % right, left.c3 % right);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal4x4 operator +(decimal4 left, decimal4x4 right) => new(left + right.c0, left + right.c1, left + right.c2, left + right.c3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal4x4 operator -(decimal4 left, decimal4x4 right) => new(left - right.c0, left - right.c1, left - right.c2, left - right.c3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal4x4 operator *(decimal4 left, decimal4x4 right) => new(left * right.c0, left * right.c1, left * right.c2, left * right.c3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal4x4 operator /(decimal4 left, decimal4x4 right) => new(left / right.c0, left / right.c1, left / right.c2, left / right.c3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal4x4 operator %(decimal4 left, decimal4x4 right) => new(left % right.c0, left % right.c1, left % right.c2, left % right.c3);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal4x4 operator +(decimal4x4 left, decimal right) => new(left.c0 + right, left.c1 + right, left.c2 + right, left.c3 + right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal4x4 operator -(decimal4x4 left, decimal right) => new(left.c0 - right, left.c1 - right, left.c2 - right, left.c3 - right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal4x4 operator *(decimal4x4 left, decimal right) => new(left.c0 * right, left.c1 * right, left.c2 * right, left.c3 * right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal4x4 operator /(decimal4x4 left, decimal right) => new(left.c0 / right, left.c1 / right, left.c2 / right, left.c3 / right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal4x4 operator %(decimal4x4 left, decimal right) => new(left.c0 % right, left.c1 % right, left.c2 % right, left.c3 % right);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal4x4 operator +(decimal left, decimal4x4 right) => new(left + right.c0, left + right.c1, left + right.c2, left + right.c3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal4x4 operator -(decimal left, decimal4x4 right) => new(left - right.c0, left - right.c1, left - right.c2, left - right.c3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal4x4 operator *(decimal left, decimal4x4 right) => new(left * right.c0, left * right.c1, left * right.c2, left * right.c3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal4x4 operator /(decimal left, decimal4x4 right) => new(left / right.c0, left / right.c1, left / right.c2, left / right.c3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal4x4 operator %(decimal left, decimal4x4 right) => new(left % right.c0, left % right.c1, left % right.c2, left % right.c3);

    
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal4x4 operator -(decimal4x4 self) => new(-self.c0, -self.c1, -self.c2, -self.c3);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal4x4 operator +(decimal4x4 self) => new(+self.c0, +self.c1, +self.c2, +self.c3);

    #endregion

    //////////////////////////////////////////////////////////////////////////////////////////////////// ToString

    #region ToString

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override string ToString() => $"decimal4x4({this.c0}, {this.c1}, {this.c2}, {this.c3})";

    #endregion
}

public static unsafe partial class math
{

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal4 mul(decimal4 a, decimal4x4 b) => new(dot(a, b.c0), dot(a, b.c1), dot(a, b.c2), dot(a, b.c3));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal4 mul(decimal4x4 a, decimal4 b) => a.c0 * b.x + a.c1 * b.y + a.c2 * b.z + a.c3 * b.w;


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal4x2 mul(decimal4x4 a, decimal4x2 b) => new(
        a.c0 * b.c0.x + a.c1 * b.c0.y + a.c2 * b.c0.z + a.c3 * b.c0.w,
        a.c0 * b.c1.x + a.c1 * b.c1.y + a.c2 * b.c1.z + a.c3 * b.c1.w
    );

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal4x3 mul(decimal4x4 a, decimal4x3 b) => new(
        a.c0 * b.c0.x + a.c1 * b.c0.y + a.c2 * b.c0.z + a.c3 * b.c0.w,
        a.c0 * b.c1.x + a.c1 * b.c1.y + a.c2 * b.c1.z + a.c3 * b.c1.w,
        a.c0 * b.c2.x + a.c1 * b.c2.y + a.c2 * b.c2.z + a.c3 * b.c2.w
    );

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal4x4 mul(decimal4x4 a, decimal4x4 b) => new(
        a.c0 * b.c0.x + a.c1 * b.c0.y + a.c2 * b.c0.z + a.c3 * b.c0.w,
        a.c0 * b.c1.x + a.c1 * b.c1.y + a.c2 * b.c1.z + a.c3 * b.c1.w,
        a.c0 * b.c2.x + a.c1 * b.c2.y + a.c2 * b.c2.z + a.c3 * b.c2.w,
        a.c0 * b.c3.x + a.c1 * b.c3.y + a.c2 * b.c3.z + a.c3 * b.c3.w
    );



}
