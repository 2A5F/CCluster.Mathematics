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

/// <summary>A 3x2 matrix of int</summary>
[Serializable]
[StructLayout(LayoutKind.Explicit, Size = 24, Pack = 4)]
public unsafe partial struct int3x2a :
    IEquatable<int3x2a>, IEqualityOperators<int3x2a, int3x2a, bool>, IEqualityOperators<int3x2a, int3x2a, bool3x2a>,

    IAdditionOperators<int3x2a, int3x2a, int3x2a>, IAdditiveIdentity<int3x2a, int3x2a>, IUnaryPlusOperators<int3x2a, int3x2a>,
    ISubtractionOperators<int3x2a, int3x2a, int3x2a>, IUnaryNegationOperators<int3x2a, int3x2a>,
    IMultiplyOperators<int3x2a, int3x2a, int3x2a>, IMultiplicativeIdentity<int3x2a, int3x2a>,
    IDivisionOperators<int3x2a, int3x2a, int3x2a>,
    IModulusOperators<int3x2a, int3x2a, int3x2a>,

    IMatrix3x2<int>, IMatrixSelf<int3x2a>
{
    //////////////////////////////////////////////////////////////////////////////////////////////////// Fields

    #region Fields

    /// <summary>Column 0 of the matrix</summary>
    [FieldOffset(0)]
    public int3a c0;

    /// <summary>Column 1 of the matrix</summary>
    [FieldOffset(12)]
    public int3a c1;


    /// <summary>Row 0 column 0 of the matrix</summary>
    [FieldOffset(0)]
    public int m00;

    /// <summary>Row 1 column 0 of the matrix</summary>
    [FieldOffset(4)]
    public int m10;

    /// <summary>Row 2 column 0 of the matrix</summary>
    [FieldOffset(8)]
    public int m20;

    /// <summary>Row 0 column 1 of the matrix</summary>
    [FieldOffset(12)]
    public int m01;

    /// <summary>Row 1 column 1 of the matrix</summary>
    [FieldOffset(16)]
    public int m11;

    /// <summary>Row 2 column 1 of the matrix</summary>
    [FieldOffset(20)]
    public int m21;

    #endregion

    //////////////////////////////////////////////////////////////////////////////////////////////////// Constants

    #region Constants

    public static readonly int3x2a zero = new(0);

    public static readonly int3x2a one = new(1);

    static int3x2a IMatrixSelf<int3x2a>.Zero 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => zero;
    }

    static int3x2a IMatrixSelf<int3x2a>.One 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => one;
    }


    #endregion

    //////////////////////////////////////////////////////////////////////////////////////////////////// Ctor

    #region Ctor


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public int3x2a(int3a c0, int3a c1)
    {
        Unsafe.SkipInit(out this);
        this.c0 = c0;
        this.c1 = c1;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public int3x2a(int m00, int m10, int m20, int m01, int m11, int m21)
    {
        Unsafe.SkipInit(out this);
        this.c0 = new(m00, m10, m20);
        this.c1 = new(m01, m11, m21);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public int3x2a(int value)
    {
        Unsafe.SkipInit(out this);
        this.c0 = new(value);
        this.c1 = new(value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator int3x2a(int value) => new(value);

    #endregion

    //////////////////////////////////////////////////////////////////////////////////////////////////// Equals

    #region Equals

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator ==(int3x2a left, int3x2a right) 
        => left.c0 == right.c0 && left.c1 == right.c1;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator !=(int3x2a left, int3x2a right) 
        => left.c0 != right.c0 || left.c1 != right.c1;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool Equals(int3x2a other) 
        => this == other;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override bool Equals(object? o) 
        => o is int3x2a other && Equals(other);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override int GetHashCode() 
        => HashCode.Combine(this.c0, this.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public int3x2a Hash() 
        => new(this.c0.GetHashCode(), this.c1.GetHashCode());

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    static bool3x2a IEqualityOperators<int3x2a, int3x2a, bool3x2a>.operator ==(int3x2a left, int3x2a right) 
        => new(left.c0 == right.c0, left.c1 == right.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    static bool3x2a IEqualityOperators<int3x2a, int3x2a, bool3x2a>.operator !=(int3x2a left, int3x2a right) 
        => new(left.c0 != right.c0, left.c1 != right.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool3x2a VEq(int3x2a other) 
        => new(this.c0 == other.c0, this.c1 == other.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool3x2a VNe(int3x2a other) 
        => new(this.c0 != other.c0, this.c1 != other.c1);

    #endregion


    //////////////////////////////////////////////////////////////////////////////////////////////////// Arithmetic

    #region Arithmetic

    public static int3x2a AdditiveIdentity 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(0);
    }

    public static int3x2a MultiplicativeIdentity 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(1);
    }


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int3x2a operator +(int3x2a left, int3x2a right) 
        => new(left.c0 + right.c0, left.c1 + right.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int3x2a operator -(int3x2a left, int3x2a right) 
        => new(left.c0 - right.c0, left.c1 - right.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int3x2a operator *(int3x2a left, int3x2a right) 
        => new(left.c0 * right.c0, left.c1 * right.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int3x2a operator /(int3x2a left, int3x2a right) 
        => new(left.c0 / right.c0, left.c1 / right.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int3x2a operator %(int3x2a left, int3x2a right) 
        => new(left.c0 % right.c0, left.c1 % right.c1);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int3x2a operator +(int3x2a left, int3a right) => new(left.c0 + right, left.c1 + right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int3x2a operator -(int3x2a left, int3a right) => new(left.c0 - right, left.c1 - right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int3x2a operator *(int3x2a left, int3a right) => new(left.c0 * right, left.c1 * right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int3x2a operator /(int3x2a left, int3a right) => new(left.c0 / right, left.c1 / right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int3x2a operator %(int3x2a left, int3a right) => new(left.c0 % right, left.c1 % right);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int3x2a operator +(int3a left, int3x2a right) => new(left + right.c0, left + right.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int3x2a operator -(int3a left, int3x2a right) => new(left - right.c0, left - right.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int3x2a operator *(int3a left, int3x2a right) => new(left * right.c0, left * right.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int3x2a operator /(int3a left, int3x2a right) => new(left / right.c0, left / right.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int3x2a operator %(int3a left, int3x2a right) => new(left % right.c0, left % right.c1);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int3x2a operator +(int3x2a left, int right) => new(left.c0 + right, left.c1 + right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int3x2a operator -(int3x2a left, int right) => new(left.c0 - right, left.c1 - right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int3x2a operator *(int3x2a left, int right) => new(left.c0 * right, left.c1 * right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int3x2a operator /(int3x2a left, int right) => new(left.c0 / right, left.c1 / right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int3x2a operator %(int3x2a left, int right) => new(left.c0 % right, left.c1 % right);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int3x2a operator +(int left, int3x2a right) => new(left + right.c0, left + right.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int3x2a operator -(int left, int3x2a right) => new(left - right.c0, left - right.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int3x2a operator *(int left, int3x2a right) => new(left * right.c0, left * right.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int3x2a operator /(int left, int3x2a right) => new(left / right.c0, left / right.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int3x2a operator %(int left, int3x2a right) => new(left % right.c0, left % right.c1);

    
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int3x2a operator -(int3x2a self) => new(-self.c0, -self.c1);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int3x2a operator +(int3x2a self) => new(+self.c0, +self.c1);

    #endregion

    //////////////////////////////////////////////////////////////////////////////////////////////////// ToString

    #region ToString

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override string ToString() => $"int3x2a({this.c0}, {this.c1})";

    #endregion
}
