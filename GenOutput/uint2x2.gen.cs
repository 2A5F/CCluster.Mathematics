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

/// <summary>A 2x2 matrix of uint</summary>
[Serializable]
[StructLayout(LayoutKind.Explicit, Size = 16)]
public unsafe partial struct uint2x2 :
    IEquatable<uint2x2>, IEqualityOperators<uint2x2, uint2x2, bool>, IEqualityOperators<uint2x2, uint2x2, bool2x2>,

    IAdditionOperators<uint2x2, uint2x2, uint2x2>, IAdditiveIdentity<uint2x2, uint2x2>, IUnaryPlusOperators<uint2x2, uint2x2>,
    ISubtractionOperators<uint2x2, uint2x2, uint2x2>, 
    IMultiplyOperators<uint2x2, uint2x2, uint2x2>, IMultiplicativeIdentity<uint2x2, uint2x2>,
    IDivisionOperators<uint2x2, uint2x2, uint2x2>,
    IModulusOperators<uint2x2, uint2x2, uint2x2>,

    IMatrix2x2<uint>, IMatrixSelf<uint2x2>, IMatrixIdentity<uint2x2>
{
    //////////////////////////////////////////////////////////////////////////////////////////////////// Fields

    #region Fields

    /// <summary>Column 0 of the matrix</summary>
    [FieldOffset(0)]
    public uint2 c0;

    /// <summary>Column 1 of the matrix</summary>
    [FieldOffset(8)]
    public uint2 c1;


    /// <summary>Row 0 column 0 of the matrix</summary>
    [FieldOffset(0)]
    public uint m00;

    /// <summary>Row 1 column 0 of the matrix</summary>
    [FieldOffset(4)]
    public uint m10;

    /// <summary>Row 0 column 1 of the matrix</summary>
    [FieldOffset(8)]
    public uint m01;

    /// <summary>Row 1 column 1 of the matrix</summary>
    [FieldOffset(12)]
    public uint m11;

    #endregion

    //////////////////////////////////////////////////////////////////////////////////////////////////// Constants

    #region Constants

    public static readonly uint2x2 identity = new uint2x2(
        1u, 0u, 
        0u, 1u
    );

    public static readonly uint2x2 zero = new(0u);

    public static readonly uint2x2 one = new(1u);

    static uint2x2 IMatrixSelf<uint2x2>.Zero 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => zero;
    }

    static uint2x2 IMatrixSelf<uint2x2>.One 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => one;
    }

    static uint2x2 IMatrixIdentity<uint2x2>.Identity 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => identity;
    }

    #endregion

    //////////////////////////////////////////////////////////////////////////////////////////////////// Ctor

    #region Ctor


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public uint2x2(uint2 c0, uint2 c1)
    {
        Unsafe.SkipInit(out this);
        this.c0.vector = c0.vector;
        this.c1.vector = c1.vector;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public uint2x2(uint m00, uint m10, uint m01, uint m11)
    {
        Unsafe.SkipInit(out this);
        this.c0.vector = Vector64.Create(m00, m10);
        this.c1.vector = Vector64.Create(m01, m11);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public uint2x2(uint value)
    {
        Unsafe.SkipInit(out this);
        this.c0.vector = Vector64.Create(value);
        this.c1.vector = Vector64.Create(value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator uint2x2(uint value) => new(value);

    #endregion

    //////////////////////////////////////////////////////////////////////////////////////////////////// Equals

    #region Equals

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator ==(uint2x2 left, uint2x2 right) 
        => left.c0 == right.c0 && left.c1 == right.c1;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator !=(uint2x2 left, uint2x2 right) 
        => left.c0 != right.c0 || left.c1 != right.c1;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool Equals(uint2x2 other) 
        => this == other;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override bool Equals(object? o) 
        => o is uint2x2 other && Equals(other);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override int GetHashCode() 
        => HashCode.Combine(this.c0, this.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public int2x2 Hash() 
        => new(this.c0.GetHashCode(), this.c1.GetHashCode());

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    static bool2x2 IEqualityOperators<uint2x2, uint2x2, bool2x2>.operator ==(uint2x2 left, uint2x2 right) 
        => new(left.c0 == right.c0, left.c1 == right.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    static bool2x2 IEqualityOperators<uint2x2, uint2x2, bool2x2>.operator !=(uint2x2 left, uint2x2 right) 
        => new(left.c0 != right.c0, left.c1 != right.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool2x2 VEq(uint2x2 other) 
        => new(this.c0 == other.c0, this.c1 == other.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool2x2 VNe(uint2x2 other) 
        => new(this.c0 != other.c0, this.c1 != other.c1);

    #endregion


    //////////////////////////////////////////////////////////////////////////////////////////////////// Arithmetic

    #region Arithmetic

    public static uint2x2 AdditiveIdentity 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(0u);
    }

    public static uint2x2 MultiplicativeIdentity 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(1u);
    }


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint2x2 operator +(uint2x2 left, uint2x2 right) 
        => new(left.c0 + right.c0, left.c1 + right.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint2x2 operator -(uint2x2 left, uint2x2 right) 
        => new(left.c0 - right.c0, left.c1 - right.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint2x2 operator *(uint2x2 left, uint2x2 right) 
        => new(left.c0 * right.c0, left.c1 * right.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint2x2 operator /(uint2x2 left, uint2x2 right) 
        => new(left.c0 / right.c0, left.c1 / right.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint2x2 operator %(uint2x2 left, uint2x2 right) 
        => new(left.c0 % right.c0, left.c1 % right.c1);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint2x2 operator +(uint2x2 left, uint2 right) => new(left.c0 + right, left.c1 + right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint2x2 operator -(uint2x2 left, uint2 right) => new(left.c0 - right, left.c1 - right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint2x2 operator *(uint2x2 left, uint2 right) => new(left.c0 * right, left.c1 * right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint2x2 operator /(uint2x2 left, uint2 right) => new(left.c0 / right, left.c1 / right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint2x2 operator %(uint2x2 left, uint2 right) => new(left.c0 % right, left.c1 % right);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint2x2 operator +(uint2 left, uint2x2 right) => new(left + right.c0, left + right.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint2x2 operator -(uint2 left, uint2x2 right) => new(left - right.c0, left - right.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint2x2 operator *(uint2 left, uint2x2 right) => new(left * right.c0, left * right.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint2x2 operator /(uint2 left, uint2x2 right) => new(left / right.c0, left / right.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint2x2 operator %(uint2 left, uint2x2 right) => new(left % right.c0, left % right.c1);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint2x2 operator +(uint2x2 left, uint right) => new(left.c0 + right, left.c1 + right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint2x2 operator -(uint2x2 left, uint right) => new(left.c0 - right, left.c1 - right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint2x2 operator *(uint2x2 left, uint right) => new(left.c0 * right, left.c1 * right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint2x2 operator /(uint2x2 left, uint right) => new(left.c0 / right, left.c1 / right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint2x2 operator %(uint2x2 left, uint right) => new(left.c0 % right, left.c1 % right);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint2x2 operator +(uint left, uint2x2 right) => new(left + right.c0, left + right.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint2x2 operator -(uint left, uint2x2 right) => new(left - right.c0, left - right.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint2x2 operator *(uint left, uint2x2 right) => new(left * right.c0, left * right.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint2x2 operator /(uint left, uint2x2 right) => new(left / right.c0, left / right.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint2x2 operator %(uint left, uint2x2 right) => new(left % right.c0, left % right.c1);



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint2x2 operator +(uint2x2 self) => new(+self.c0, +self.c1);

    #endregion

    //////////////////////////////////////////////////////////////////////////////////////////////////// ToString

    #region ToString

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override string ToString() => $"uint2x2({this.c0}, {this.c1})";

    #endregion
}
