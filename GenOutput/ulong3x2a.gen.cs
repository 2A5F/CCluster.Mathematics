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

/// <summary>A 3x2 matrix of ulong</summary>
[Serializable]
[StructLayout(LayoutKind.Explicit, Size = 48, Pack = 8)]
public unsafe partial struct ulong3x2a :
    IEquatable<ulong3x2a>, IEqualityOperators<ulong3x2a, ulong3x2a, bool>, IEqualityOperators<ulong3x2a, ulong3x2a, bool3x2a>,

    IAdditionOperators<ulong3x2a, ulong3x2a, ulong3x2a>, IAdditiveIdentity<ulong3x2a, ulong3x2a>, IUnaryPlusOperators<ulong3x2a, ulong3x2a>,
    ISubtractionOperators<ulong3x2a, ulong3x2a, ulong3x2a>, 
    IMultiplyOperators<ulong3x2a, ulong3x2a, ulong3x2a>, IMultiplicativeIdentity<ulong3x2a, ulong3x2a>,
    IDivisionOperators<ulong3x2a, ulong3x2a, ulong3x2a>,
    IModulusOperators<ulong3x2a, ulong3x2a, ulong3x2a>,

    IMatrix3x2<ulong>, IMatrixSelf<ulong3x2a>
{
    //////////////////////////////////////////////////////////////////////////////////////////////////// Fields

    #region Fields

    /// <summary>Column 0 of the matrix</summary>
    [FieldOffset(0)]
    public ulong3a c0;

    /// <summary>Column 1 of the matrix</summary>
    [FieldOffset(24)]
    public ulong3a c1;


    /// <summary>Row 0 column 0 of the matrix</summary>
    [FieldOffset(0)]
    public ulong m00;

    /// <summary>Row 1 column 0 of the matrix</summary>
    [FieldOffset(8)]
    public ulong m10;

    /// <summary>Row 2 column 0 of the matrix</summary>
    [FieldOffset(16)]
    public ulong m20;

    /// <summary>Row 0 column 1 of the matrix</summary>
    [FieldOffset(24)]
    public ulong m01;

    /// <summary>Row 1 column 1 of the matrix</summary>
    [FieldOffset(32)]
    public ulong m11;

    /// <summary>Row 2 column 1 of the matrix</summary>
    [FieldOffset(40)]
    public ulong m21;

    #endregion

    //////////////////////////////////////////////////////////////////////////////////////////////////// Constants

    #region Constants

    public static readonly ulong3x2a zero = new(0UL);

    public static readonly ulong3x2a one = new(1UL);

    static ulong3x2a IMatrixSelf<ulong3x2a>.Zero 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => zero;
    }

    static ulong3x2a IMatrixSelf<ulong3x2a>.One 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => one;
    }


    #endregion

    //////////////////////////////////////////////////////////////////////////////////////////////////// Ctor

    #region Ctor


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public ulong3x2a(ulong3a c0, ulong3a c1)
    {
        Unsafe.SkipInit(out this);
        this.c0 = c0;
        this.c1 = c1;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public ulong3x2a(ulong m00, ulong m10, ulong m20, ulong m01, ulong m11, ulong m21)
    {
        Unsafe.SkipInit(out this);
        this.c0 = new(m00, m10, m20);
        this.c1 = new(m01, m11, m21);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public ulong3x2a(ulong value)
    {
        Unsafe.SkipInit(out this);
        this.c0 = new(value);
        this.c1 = new(value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator ulong3x2a(ulong value) => new(value);

    #endregion

    //////////////////////////////////////////////////////////////////////////////////////////////////// Equals

    #region Equals

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator ==(ulong3x2a left, ulong3x2a right) 
        => left.c0 == right.c0 && left.c1 == right.c1;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator !=(ulong3x2a left, ulong3x2a right) 
        => left.c0 != right.c0 || left.c1 != right.c1;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool Equals(ulong3x2a other) 
        => this == other;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override bool Equals(object? o) 
        => o is ulong3x2a other && Equals(other);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override int GetHashCode() 
        => HashCode.Combine(this.c0, this.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public int3x2a Hash() 
        => new(this.c0.GetHashCode(), this.c1.GetHashCode());

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    static bool3x2a IEqualityOperators<ulong3x2a, ulong3x2a, bool3x2a>.operator ==(ulong3x2a left, ulong3x2a right) 
        => new(left.c0 == right.c0, left.c1 == right.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    static bool3x2a IEqualityOperators<ulong3x2a, ulong3x2a, bool3x2a>.operator !=(ulong3x2a left, ulong3x2a right) 
        => new(left.c0 != right.c0, left.c1 != right.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool3x2a VEq(ulong3x2a other) 
        => new(this.c0 == other.c0, this.c1 == other.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool3x2a VNe(ulong3x2a other) 
        => new(this.c0 != other.c0, this.c1 != other.c1);

    #endregion


    //////////////////////////////////////////////////////////////////////////////////////////////////// Arithmetic

    #region Arithmetic

    public static ulong3x2a AdditiveIdentity 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(0UL);
    }

    public static ulong3x2a MultiplicativeIdentity 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(1UL);
    }


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static ulong3x2a operator +(ulong3x2a left, ulong3x2a right) 
        => new(left.c0 + right.c0, left.c1 + right.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static ulong3x2a operator -(ulong3x2a left, ulong3x2a right) 
        => new(left.c0 - right.c0, left.c1 - right.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static ulong3x2a operator *(ulong3x2a left, ulong3x2a right) 
        => new(left.c0 * right.c0, left.c1 * right.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static ulong3x2a operator /(ulong3x2a left, ulong3x2a right) 
        => new(left.c0 / right.c0, left.c1 / right.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static ulong3x2a operator %(ulong3x2a left, ulong3x2a right) 
        => new(left.c0 % right.c0, left.c1 % right.c1);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static ulong3x2a operator +(ulong3x2a left, ulong3a right) => new(left.c0 + right, left.c1 + right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static ulong3x2a operator -(ulong3x2a left, ulong3a right) => new(left.c0 - right, left.c1 - right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static ulong3x2a operator *(ulong3x2a left, ulong3a right) => new(left.c0 * right, left.c1 * right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static ulong3x2a operator /(ulong3x2a left, ulong3a right) => new(left.c0 / right, left.c1 / right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static ulong3x2a operator %(ulong3x2a left, ulong3a right) => new(left.c0 % right, left.c1 % right);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static ulong3x2a operator +(ulong3a left, ulong3x2a right) => new(left + right.c0, left + right.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static ulong3x2a operator -(ulong3a left, ulong3x2a right) => new(left - right.c0, left - right.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static ulong3x2a operator *(ulong3a left, ulong3x2a right) => new(left * right.c0, left * right.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static ulong3x2a operator /(ulong3a left, ulong3x2a right) => new(left / right.c0, left / right.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static ulong3x2a operator %(ulong3a left, ulong3x2a right) => new(left % right.c0, left % right.c1);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static ulong3x2a operator +(ulong3x2a left, ulong right) => new(left.c0 + right, left.c1 + right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static ulong3x2a operator -(ulong3x2a left, ulong right) => new(left.c0 - right, left.c1 - right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static ulong3x2a operator *(ulong3x2a left, ulong right) => new(left.c0 * right, left.c1 * right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static ulong3x2a operator /(ulong3x2a left, ulong right) => new(left.c0 / right, left.c1 / right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static ulong3x2a operator %(ulong3x2a left, ulong right) => new(left.c0 % right, left.c1 % right);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static ulong3x2a operator +(ulong left, ulong3x2a right) => new(left + right.c0, left + right.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static ulong3x2a operator -(ulong left, ulong3x2a right) => new(left - right.c0, left - right.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static ulong3x2a operator *(ulong left, ulong3x2a right) => new(left * right.c0, left * right.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static ulong3x2a operator /(ulong left, ulong3x2a right) => new(left / right.c0, left / right.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static ulong3x2a operator %(ulong left, ulong3x2a right) => new(left % right.c0, left % right.c1);



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static ulong3x2a operator +(ulong3x2a self) => new(+self.c0, +self.c1);

    #endregion

    //////////////////////////////////////////////////////////////////////////////////////////////////// ToString

    #region ToString

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override string ToString() => $"ulong3x2a({this.c0}, {this.c1})";

    #endregion
}
