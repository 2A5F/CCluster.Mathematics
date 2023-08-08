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

/// <summary>A 3x2 matrix of uint</summary>
[Serializable]
[StructLayout(LayoutKind.Explicit, Size = 24, Pack = 4)]
public unsafe partial struct uint3x2a :
    IEquatable<uint3x2a>, IEqualityOperators<uint3x2a, uint3x2a, bool>, IEqualityOperators<uint3x2a, uint3x2a, bool3x2a>,

    IAdditionOperators<uint3x2a, uint3x2a, uint3x2a>, IAdditiveIdentity<uint3x2a, uint3x2a>, IUnaryPlusOperators<uint3x2a, uint3x2a>,
    ISubtractionOperators<uint3x2a, uint3x2a, uint3x2a>, 
    IMultiplyOperators<uint3x2a, uint3x2a, uint3x2a>, IMultiplicativeIdentity<uint3x2a, uint3x2a>,
    IDivisionOperators<uint3x2a, uint3x2a, uint3x2a>,
    IModulusOperators<uint3x2a, uint3x2a, uint3x2a>,

    IMatrix3x2<uint>, IMatrixSelf<uint3x2a>
{
    //////////////////////////////////////////////////////////////////////////////////////////////////// Fields

    #region Fields

    /// <summary>Column 0 of the matrix</summary>
    [FieldOffset(0)]
    public uint3a c0;

    /// <summary>Column 1 of the matrix</summary>
    [FieldOffset(12)]
    public uint3a c1;


    /// <summary>Row 0 column 0 of the matrix</summary>
    [FieldOffset(0)]
    public uint m00;

    /// <summary>Row 1 column 0 of the matrix</summary>
    [FieldOffset(4)]
    public uint m10;

    /// <summary>Row 2 column 0 of the matrix</summary>
    [FieldOffset(8)]
    public uint m20;

    /// <summary>Row 0 column 1 of the matrix</summary>
    [FieldOffset(12)]
    public uint m01;

    /// <summary>Row 1 column 1 of the matrix</summary>
    [FieldOffset(16)]
    public uint m11;

    /// <summary>Row 2 column 1 of the matrix</summary>
    [FieldOffset(20)]
    public uint m21;

    #endregion

    //////////////////////////////////////////////////////////////////////////////////////////////////// Constants

    #region Constants

    public static readonly uint3x2a zero = new(0u);

    public static readonly uint3x2a one = new(1u);

    static uint3x2a IMatrixSelf<uint3x2a>.Zero 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => zero;
    }

    static uint3x2a IMatrixSelf<uint3x2a>.One 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => one;
    }


    #endregion

    //////////////////////////////////////////////////////////////////////////////////////////////////// Ctor

    #region Ctor


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public uint3x2a(uint3a c0, uint3a c1)
    {
        Unsafe.SkipInit(out this);
        this.c0 = c0;
        this.c1 = c1;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public uint3x2a(uint m00, uint m10, uint m20, uint m01, uint m11, uint m21)
    {
        Unsafe.SkipInit(out this);
        this.c0 = new(m00, m10, m20);
        this.c1 = new(m01, m11, m21);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public uint3x2a(uint value)
    {
        Unsafe.SkipInit(out this);
        this.c0 = new(value);
        this.c1 = new(value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator uint3x2a(uint value) => new(value);

    #endregion

    //////////////////////////////////////////////////////////////////////////////////////////////////// Equals

    #region Equals

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator ==(uint3x2a left, uint3x2a right) 
        => left.c0 == right.c0 && left.c1 == right.c1;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator !=(uint3x2a left, uint3x2a right) 
        => left.c0 != right.c0 || left.c1 != right.c1;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool Equals(uint3x2a other) 
        => this == other;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override bool Equals(object? o) 
        => o is uint3x2a other && Equals(other);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override int GetHashCode() 
        => HashCode.Combine(this.c0, this.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public int3x2a Hash() 
        => new(this.c0.GetHashCode(), this.c1.GetHashCode());

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    static bool3x2a IEqualityOperators<uint3x2a, uint3x2a, bool3x2a>.operator ==(uint3x2a left, uint3x2a right) 
        => new(left.c0 == right.c0, left.c1 == right.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    static bool3x2a IEqualityOperators<uint3x2a, uint3x2a, bool3x2a>.operator !=(uint3x2a left, uint3x2a right) 
        => new(left.c0 != right.c0, left.c1 != right.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool3x2a VEq(uint3x2a other) 
        => new(this.c0 == other.c0, this.c1 == other.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool3x2a VNe(uint3x2a other) 
        => new(this.c0 != other.c0, this.c1 != other.c1);

    #endregion


    //////////////////////////////////////////////////////////////////////////////////////////////////// Arithmetic

    #region Arithmetic

    public static uint3x2a AdditiveIdentity 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(0u);
    }

    public static uint3x2a MultiplicativeIdentity 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(1u);
    }


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3x2a operator +(uint3x2a left, uint3x2a right) 
        => new(left.c0 + right.c0, left.c1 + right.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3x2a operator -(uint3x2a left, uint3x2a right) 
        => new(left.c0 - right.c0, left.c1 - right.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3x2a operator *(uint3x2a left, uint3x2a right) 
        => new(left.c0 * right.c0, left.c1 * right.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3x2a operator /(uint3x2a left, uint3x2a right) 
        => new(left.c0 / right.c0, left.c1 / right.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3x2a operator %(uint3x2a left, uint3x2a right) 
        => new(left.c0 % right.c0, left.c1 % right.c1);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3x2a operator +(uint3x2a left, uint3a right) => new(left.c0 + right, left.c1 + right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3x2a operator -(uint3x2a left, uint3a right) => new(left.c0 - right, left.c1 - right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3x2a operator *(uint3x2a left, uint3a right) => new(left.c0 * right, left.c1 * right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3x2a operator /(uint3x2a left, uint3a right) => new(left.c0 / right, left.c1 / right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3x2a operator %(uint3x2a left, uint3a right) => new(left.c0 % right, left.c1 % right);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3x2a operator +(uint3a left, uint3x2a right) => new(left + right.c0, left + right.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3x2a operator -(uint3a left, uint3x2a right) => new(left - right.c0, left - right.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3x2a operator *(uint3a left, uint3x2a right) => new(left * right.c0, left * right.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3x2a operator /(uint3a left, uint3x2a right) => new(left / right.c0, left / right.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3x2a operator %(uint3a left, uint3x2a right) => new(left % right.c0, left % right.c1);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3x2a operator +(uint3x2a left, uint right) => new(left.c0 + right, left.c1 + right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3x2a operator -(uint3x2a left, uint right) => new(left.c0 - right, left.c1 - right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3x2a operator *(uint3x2a left, uint right) => new(left.c0 * right, left.c1 * right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3x2a operator /(uint3x2a left, uint right) => new(left.c0 / right, left.c1 / right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3x2a operator %(uint3x2a left, uint right) => new(left.c0 % right, left.c1 % right);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3x2a operator +(uint left, uint3x2a right) => new(left + right.c0, left + right.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3x2a operator -(uint left, uint3x2a right) => new(left - right.c0, left - right.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3x2a operator *(uint left, uint3x2a right) => new(left * right.c0, left * right.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3x2a operator /(uint left, uint3x2a right) => new(left / right.c0, left / right.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3x2a operator %(uint left, uint3x2a right) => new(left % right.c0, left % right.c1);



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3x2a operator +(uint3x2a self) => new(+self.c0, +self.c1);

    #endregion

    //////////////////////////////////////////////////////////////////////////////////////////////////// ToString

    #region ToString

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override string ToString() => $"uint3x2a({this.c0}, {this.c1})";

    #endregion
}
