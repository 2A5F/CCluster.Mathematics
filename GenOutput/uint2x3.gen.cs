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

/// <summary>A 2x3 matrix of uint</summary>
[Serializable]
[StructLayout(LayoutKind.Explicit, Size = 24)]
public unsafe partial struct uint2x3 :
    IEquatable<uint2x3>, IEqualityOperators<uint2x3, uint2x3, bool>, IEqualityOperators<uint2x3, uint2x3, bool2x3>,

    IAdditionOperators<uint2x3, uint2x3, uint2x3>, IAdditiveIdentity<uint2x3, uint2x3>, IUnaryPlusOperators<uint2x3, uint2x3>,
    ISubtractionOperators<uint2x3, uint2x3, uint2x3>, 
    IMultiplyOperators<uint2x3, uint2x3, uint2x3>, IMultiplicativeIdentity<uint2x3, uint2x3>,
    IDivisionOperators<uint2x3, uint2x3, uint2x3>,
    IModulusOperators<uint2x3, uint2x3, uint2x3>,

    IMatrix2x3<uint>, IMatrixSelf<uint2x3>
{
    //////////////////////////////////////////////////////////////////////////////////////////////////// Fields

    #region Fields

    /// <summary>Column 0 of the matrix</summary>
    [FieldOffset(0)]
    public uint2 c0;

    /// <summary>Column 1 of the matrix</summary>
    [FieldOffset(8)]
    public uint2 c1;

    /// <summary>Column 2 of the matrix</summary>
    [FieldOffset(16)]
    public uint2 c2;


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

    /// <summary>Row 0 column 2 of the matrix</summary>
    [FieldOffset(16)]
    public uint m02;

    /// <summary>Row 1 column 2 of the matrix</summary>
    [FieldOffset(20)]
    public uint m12;

    #endregion

    //////////////////////////////////////////////////////////////////////////////////////////////////// Constants

    #region Constants

    public static readonly uint2x3 zero = new(0u);

    public static readonly uint2x3 one = new(1u);

    static uint2x3 IMatrixSelf<uint2x3>.Zero 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => zero;
    }

    static uint2x3 IMatrixSelf<uint2x3>.One 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => one;
    }


    #endregion

    //////////////////////////////////////////////////////////////////////////////////////////////////// Ctor

    #region Ctor


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public uint2x3(uint2 c0, uint2 c1, uint2 c2)
    {
        Unsafe.SkipInit(out this);
        this.c0.vector = c0.vector;
        this.c1.vector = c1.vector;
        this.c2.vector = c2.vector;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public uint2x3(uint m00, uint m10, uint m01, uint m11, uint m02, uint m12)
    {
        Unsafe.SkipInit(out this);
        this.c0.vector = Vector64.Create(m00, m10);
        this.c1.vector = Vector64.Create(m01, m11);
        this.c2.vector = Vector64.Create(m02, m12);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public uint2x3(uint value)
    {
        Unsafe.SkipInit(out this);
        this.c0.vector = Vector64.Create(value);
        this.c1.vector = Vector64.Create(value);
        this.c2.vector = Vector64.Create(value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator uint2x3(uint value) => new(value);

    #endregion

    //////////////////////////////////////////////////////////////////////////////////////////////////// Equals

    #region Equals

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator ==(uint2x3 left, uint2x3 right) 
        => left.c0 == right.c0 && left.c1 == right.c1 && left.c2 == right.c2;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator !=(uint2x3 left, uint2x3 right) 
        => left.c0 != right.c0 || left.c1 != right.c1 || left.c2 != right.c2;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool Equals(uint2x3 other) 
        => this == other;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override bool Equals(object? o) 
        => o is uint2x3 other && Equals(other);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override int GetHashCode() 
        => HashCode.Combine(this.c0, this.c1, this.c2);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public int2x3 Hash() 
        => new(this.c0.GetHashCode(), this.c1.GetHashCode(), this.c2.GetHashCode());

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    static bool2x3 IEqualityOperators<uint2x3, uint2x3, bool2x3>.operator ==(uint2x3 left, uint2x3 right) 
        => new(left.c0 == right.c0, left.c1 == right.c1, left.c2 == right.c2);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    static bool2x3 IEqualityOperators<uint2x3, uint2x3, bool2x3>.operator !=(uint2x3 left, uint2x3 right) 
        => new(left.c0 != right.c0, left.c1 != right.c1, left.c2 != right.c2);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool2x3 VEq(uint2x3 other) 
        => new(this.c0 == other.c0, this.c1 == other.c1, this.c2 == other.c2);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool2x3 VNe(uint2x3 other) 
        => new(this.c0 != other.c0, this.c1 != other.c1, this.c2 != other.c2);

    #endregion


    //////////////////////////////////////////////////////////////////////////////////////////////////// Arithmetic

    #region Arithmetic

    public static uint2x3 AdditiveIdentity 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(0u);
    }

    public static uint2x3 MultiplicativeIdentity 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(1u);
    }


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint2x3 operator +(uint2x3 left, uint2x3 right) 
        => new(left.c0 + right.c0, left.c1 + right.c1, left.c2 + right.c2);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint2x3 operator -(uint2x3 left, uint2x3 right) 
        => new(left.c0 - right.c0, left.c1 - right.c1, left.c2 - right.c2);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint2x3 operator *(uint2x3 left, uint2x3 right) 
        => new(left.c0 * right.c0, left.c1 * right.c1, left.c2 * right.c2);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint2x3 operator /(uint2x3 left, uint2x3 right) 
        => new(left.c0 / right.c0, left.c1 / right.c1, left.c2 / right.c2);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint2x3 operator %(uint2x3 left, uint2x3 right) 
        => new(left.c0 % right.c0, left.c1 % right.c1, left.c2 % right.c2);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint2x3 operator +(uint2x3 left, uint2 right) => new(left.c0 + right, left.c1 + right, left.c2 + right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint2x3 operator -(uint2x3 left, uint2 right) => new(left.c0 - right, left.c1 - right, left.c2 - right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint2x3 operator *(uint2x3 left, uint2 right) => new(left.c0 * right, left.c1 * right, left.c2 * right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint2x3 operator /(uint2x3 left, uint2 right) => new(left.c0 / right, left.c1 / right, left.c2 / right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint2x3 operator %(uint2x3 left, uint2 right) => new(left.c0 % right, left.c1 % right, left.c2 % right);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint2x3 operator +(uint2 left, uint2x3 right) => new(left + right.c0, left + right.c1, left + right.c2);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint2x3 operator -(uint2 left, uint2x3 right) => new(left - right.c0, left - right.c1, left - right.c2);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint2x3 operator *(uint2 left, uint2x3 right) => new(left * right.c0, left * right.c1, left * right.c2);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint2x3 operator /(uint2 left, uint2x3 right) => new(left / right.c0, left / right.c1, left / right.c2);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint2x3 operator %(uint2 left, uint2x3 right) => new(left % right.c0, left % right.c1, left % right.c2);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint2x3 operator +(uint2x3 left, uint right) => new(left.c0 + right, left.c1 + right, left.c2 + right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint2x3 operator -(uint2x3 left, uint right) => new(left.c0 - right, left.c1 - right, left.c2 - right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint2x3 operator *(uint2x3 left, uint right) => new(left.c0 * right, left.c1 * right, left.c2 * right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint2x3 operator /(uint2x3 left, uint right) => new(left.c0 / right, left.c1 / right, left.c2 / right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint2x3 operator %(uint2x3 left, uint right) => new(left.c0 % right, left.c1 % right, left.c2 % right);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint2x3 operator +(uint left, uint2x3 right) => new(left + right.c0, left + right.c1, left + right.c2);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint2x3 operator -(uint left, uint2x3 right) => new(left - right.c0, left - right.c1, left - right.c2);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint2x3 operator *(uint left, uint2x3 right) => new(left * right.c0, left * right.c1, left * right.c2);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint2x3 operator /(uint left, uint2x3 right) => new(left / right.c0, left / right.c1, left / right.c2);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint2x3 operator %(uint left, uint2x3 right) => new(left % right.c0, left % right.c1, left % right.c2);



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint2x3 operator +(uint2x3 self) => new(+self.c0, +self.c1, +self.c2);

    #endregion

    //////////////////////////////////////////////////////////////////////////////////////////////////// ToString

    #region ToString

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override string ToString() => $"uint2x3({this.c0}, {this.c1}, {this.c2})";

    #endregion
}
