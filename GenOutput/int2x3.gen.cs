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

/// <summary>A 2x3 matrix of int</summary>
[Serializable]
[StructLayout(LayoutKind.Explicit, Size = 24, Pack = 4)]
public unsafe partial struct int2x3 :
    IEquatable<int2x3>, IEqualityOperators<int2x3, int2x3, bool>, IEqualityOperators<int2x3, int2x3, bool2x3>,

    IAdditionOperators<int2x3, int2x3, int2x3>, IAdditiveIdentity<int2x3, int2x3>, IUnaryPlusOperators<int2x3, int2x3>,
    ISubtractionOperators<int2x3, int2x3, int2x3>, IUnaryNegationOperators<int2x3, int2x3>,
    IMultiplyOperators<int2x3, int2x3, int2x3>, IMultiplicativeIdentity<int2x3, int2x3>,
    IDivisionOperators<int2x3, int2x3, int2x3>,
    IModulusOperators<int2x3, int2x3, int2x3>,

    IMatrix2x3<int>, IMatrixSelf<int2x3>
{
    //////////////////////////////////////////////////////////////////////////////////////////////////// Fields

    #region Fields

    /// <summary>Column 0 of the matrix</summary>
    [FieldOffset(0)]
    public int2 c0;

    /// <summary>Column 1 of the matrix</summary>
    [FieldOffset(8)]
    public int2 c1;

    /// <summary>Column 2 of the matrix</summary>
    [FieldOffset(16)]
    public int2 c2;


    /// <summary>Row 0 column 0 of the matrix</summary>
    [FieldOffset(0)]
    public int m00;

    /// <summary>Row 1 column 0 of the matrix</summary>
    [FieldOffset(4)]
    public int m10;

    /// <summary>Row 0 column 1 of the matrix</summary>
    [FieldOffset(8)]
    public int m01;

    /// <summary>Row 1 column 1 of the matrix</summary>
    [FieldOffset(12)]
    public int m11;

    /// <summary>Row 0 column 2 of the matrix</summary>
    [FieldOffset(16)]
    public int m02;

    /// <summary>Row 1 column 2 of the matrix</summary>
    [FieldOffset(20)]
    public int m12;

    #endregion

    //////////////////////////////////////////////////////////////////////////////////////////////////// Constants

    #region Constants

    public static readonly int2x3 zero = new(0);

    public static readonly int2x3 one = new(1);

    static int2x3 IMatrixSelf<int2x3>.Zero 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => zero;
    }

    static int2x3 IMatrixSelf<int2x3>.One 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => one;
    }


    #endregion

    //////////////////////////////////////////////////////////////////////////////////////////////////// Ctor

    #region Ctor


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public int2x3(int2 c0, int2 c1, int2 c2)
    {
        Unsafe.SkipInit(out this);
        this.c0.vector = c0.vector;
        this.c1.vector = c1.vector;
        this.c2.vector = c2.vector;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public int2x3(int m00, int m10, int m01, int m11, int m02, int m12)
    {
        Unsafe.SkipInit(out this);
        this.c0.vector = Vector64.Create(m00, m10);
        this.c1.vector = Vector64.Create(m01, m11);
        this.c2.vector = Vector64.Create(m02, m12);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public int2x3(int value)
    {
        Unsafe.SkipInit(out this);
        this.c0.vector = Vector64.Create(value);
        this.c1.vector = Vector64.Create(value);
        this.c2.vector = Vector64.Create(value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator int2x3(int value) => new(value);

    #endregion

    //////////////////////////////////////////////////////////////////////////////////////////////////// Equals

    #region Equals

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator ==(int2x3 left, int2x3 right) 
        => left.c0 == right.c0 && left.c1 == right.c1 && left.c2 == right.c2;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator !=(int2x3 left, int2x3 right) 
        => left.c0 != right.c0 || left.c1 != right.c1 || left.c2 != right.c2;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool Equals(int2x3 other) 
        => this == other;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override bool Equals(object? o) 
        => o is int2x3 other && Equals(other);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override int GetHashCode() 
        => HashCode.Combine(this.c0, this.c1, this.c2);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public int2x3 Hash() 
        => new(this.c0.GetHashCode(), this.c1.GetHashCode(), this.c2.GetHashCode());

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    static bool2x3 IEqualityOperators<int2x3, int2x3, bool2x3>.operator ==(int2x3 left, int2x3 right) 
        => new(left.c0 == right.c0, left.c1 == right.c1, left.c2 == right.c2);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    static bool2x3 IEqualityOperators<int2x3, int2x3, bool2x3>.operator !=(int2x3 left, int2x3 right) 
        => new(left.c0 != right.c0, left.c1 != right.c1, left.c2 != right.c2);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool2x3 VEq(int2x3 other) 
        => new(this.c0 == other.c0, this.c1 == other.c1, this.c2 == other.c2);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool2x3 VNe(int2x3 other) 
        => new(this.c0 != other.c0, this.c1 != other.c1, this.c2 != other.c2);

    #endregion


    //////////////////////////////////////////////////////////////////////////////////////////////////// Arithmetic

    #region Arithmetic

    public static int2x3 AdditiveIdentity 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(0);
    }

    public static int2x3 MultiplicativeIdentity 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(1);
    }


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int2x3 operator +(int2x3 left, int2x3 right) 
        => new(left.c0 + right.c0, left.c1 + right.c1, left.c2 + right.c2);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int2x3 operator -(int2x3 left, int2x3 right) 
        => new(left.c0 - right.c0, left.c1 - right.c1, left.c2 - right.c2);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int2x3 operator *(int2x3 left, int2x3 right) 
        => new(left.c0 * right.c0, left.c1 * right.c1, left.c2 * right.c2);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int2x3 operator /(int2x3 left, int2x3 right) 
        => new(left.c0 / right.c0, left.c1 / right.c1, left.c2 / right.c2);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int2x3 operator %(int2x3 left, int2x3 right) 
        => new(left.c0 % right.c0, left.c1 % right.c1, left.c2 % right.c2);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int2x3 operator +(int2x3 left, int2 right) => new(left.c0 + right, left.c1 + right, left.c2 + right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int2x3 operator -(int2x3 left, int2 right) => new(left.c0 - right, left.c1 - right, left.c2 - right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int2x3 operator *(int2x3 left, int2 right) => new(left.c0 * right, left.c1 * right, left.c2 * right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int2x3 operator /(int2x3 left, int2 right) => new(left.c0 / right, left.c1 / right, left.c2 / right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int2x3 operator %(int2x3 left, int2 right) => new(left.c0 % right, left.c1 % right, left.c2 % right);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int2x3 operator +(int2 left, int2x3 right) => new(left + right.c0, left + right.c1, left + right.c2);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int2x3 operator -(int2 left, int2x3 right) => new(left - right.c0, left - right.c1, left - right.c2);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int2x3 operator *(int2 left, int2x3 right) => new(left * right.c0, left * right.c1, left * right.c2);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int2x3 operator /(int2 left, int2x3 right) => new(left / right.c0, left / right.c1, left / right.c2);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int2x3 operator %(int2 left, int2x3 right) => new(left % right.c0, left % right.c1, left % right.c2);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int2x3 operator +(int2x3 left, int right) => new(left.c0 + right, left.c1 + right, left.c2 + right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int2x3 operator -(int2x3 left, int right) => new(left.c0 - right, left.c1 - right, left.c2 - right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int2x3 operator *(int2x3 left, int right) => new(left.c0 * right, left.c1 * right, left.c2 * right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int2x3 operator /(int2x3 left, int right) => new(left.c0 / right, left.c1 / right, left.c2 / right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int2x3 operator %(int2x3 left, int right) => new(left.c0 % right, left.c1 % right, left.c2 % right);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int2x3 operator +(int left, int2x3 right) => new(left + right.c0, left + right.c1, left + right.c2);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int2x3 operator -(int left, int2x3 right) => new(left - right.c0, left - right.c1, left - right.c2);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int2x3 operator *(int left, int2x3 right) => new(left * right.c0, left * right.c1, left * right.c2);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int2x3 operator /(int left, int2x3 right) => new(left / right.c0, left / right.c1, left / right.c2);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int2x3 operator %(int left, int2x3 right) => new(left % right.c0, left % right.c1, left % right.c2);

    
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int2x3 operator -(int2x3 self) => new(-self.c0, -self.c1, -self.c2);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int2x3 operator +(int2x3 self) => new(+self.c0, +self.c1, +self.c2);

    #endregion

    //////////////////////////////////////////////////////////////////////////////////////////////////// ToString

    #region ToString

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override string ToString() => $"int2x3({this.c0}, {this.c1}, {this.c2})";

    #endregion
}
