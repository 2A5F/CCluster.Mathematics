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

/// <summary>A 2x4 matrix of Half</summary>
[Serializable]
[StructLayout(LayoutKind.Explicit, Size = 16, Pack = 2)]
public unsafe partial struct Half2x4 :
    IEquatable<Half2x4>, IEqualityOperators<Half2x4, Half2x4, bool>, IEqualityOperators<Half2x4, Half2x4, bool2x4>,

    IAdditionOperators<Half2x4, Half2x4, Half2x4>, IAdditiveIdentity<Half2x4, Half2x4>, IUnaryPlusOperators<Half2x4, Half2x4>,
    ISubtractionOperators<Half2x4, Half2x4, Half2x4>, IUnaryNegationOperators<Half2x4, Half2x4>,
    IMultiplyOperators<Half2x4, Half2x4, Half2x4>, IMultiplicativeIdentity<Half2x4, Half2x4>,
    IDivisionOperators<Half2x4, Half2x4, Half2x4>,
    IModulusOperators<Half2x4, Half2x4, Half2x4>,

    IMatrix2x4<Half>, IMatrixSelf<Half2x4>
{
    //////////////////////////////////////////////////////////////////////////////////////////////////// Fields

    #region Fields

    /// <summary>Column 0 of the matrix</summary>
    [FieldOffset(0)]
    public Half2 c0;

    /// <summary>Column 1 of the matrix</summary>
    [FieldOffset(4)]
    public Half2 c1;

    /// <summary>Column 2 of the matrix</summary>
    [FieldOffset(8)]
    public Half2 c2;

    /// <summary>Column 3 of the matrix</summary>
    [FieldOffset(12)]
    public Half2 c3;


    /// <summary>Row 0 column 0 of the matrix</summary>
    [FieldOffset(0)]
    public Half m00;

    /// <summary>Row 1 column 0 of the matrix</summary>
    [FieldOffset(2)]
    public Half m10;

    /// <summary>Row 0 column 1 of the matrix</summary>
    [FieldOffset(4)]
    public Half m01;

    /// <summary>Row 1 column 1 of the matrix</summary>
    [FieldOffset(6)]
    public Half m11;

    /// <summary>Row 0 column 2 of the matrix</summary>
    [FieldOffset(8)]
    public Half m02;

    /// <summary>Row 1 column 2 of the matrix</summary>
    [FieldOffset(10)]
    public Half m12;

    /// <summary>Row 0 column 3 of the matrix</summary>
    [FieldOffset(12)]
    public Half m03;

    /// <summary>Row 1 column 3 of the matrix</summary>
    [FieldOffset(14)]
    public Half m13;

    #endregion

    //////////////////////////////////////////////////////////////////////////////////////////////////// Constants

    #region Constants

    public static readonly Half2x4 zero = new(Half.Zero);

    public static readonly Half2x4 one = new(Half.One);

    static Half2x4 IMatrixSelf<Half2x4>.Zero 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => zero;
    }

    static Half2x4 IMatrixSelf<Half2x4>.One 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => one;
    }


    #endregion

    //////////////////////////////////////////////////////////////////////////////////////////////////// Ctor

    #region Ctor


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public Half2x4(Half2 c0, Half2 c1, Half2 c2, Half2 c3)
    {
        Unsafe.SkipInit(out this);
        this.c0 = c0;
        this.c1 = c1;
        this.c2 = c2;
        this.c3 = c3;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public Half2x4(Half m00, Half m10, Half m01, Half m11, Half m02, Half m12, Half m03, Half m13)
    {
        Unsafe.SkipInit(out this);
        this.c0 = new(m00, m10);
        this.c1 = new(m01, m11);
        this.c2 = new(m02, m12);
        this.c3 = new(m03, m13);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public Half2x4(Half value)
    {
        Unsafe.SkipInit(out this);
        this.c0 = new(value);
        this.c1 = new(value);
        this.c2 = new(value);
        this.c3 = new(value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator Half2x4(Half value) => new(value);

    #endregion

    //////////////////////////////////////////////////////////////////////////////////////////////////// Equals

    #region Equals

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator ==(Half2x4 left, Half2x4 right) 
        => left.c0 == right.c0 && left.c1 == right.c1 && left.c2 == right.c2 && left.c3 == right.c3;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator !=(Half2x4 left, Half2x4 right) 
        => left.c0 != right.c0 || left.c1 != right.c1 || left.c2 != right.c2 || left.c3 != right.c3;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool Equals(Half2x4 other) 
        => this == other;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override bool Equals(object? o) 
        => o is Half2x4 other && Equals(other);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override int GetHashCode() 
        => HashCode.Combine(this.c0, this.c1, this.c2, this.c3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public int2x4 Hash() 
        => new(this.c0.GetHashCode(), this.c1.GetHashCode(), this.c2.GetHashCode(), this.c3.GetHashCode());

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    static bool2x4 IEqualityOperators<Half2x4, Half2x4, bool2x4>.operator ==(Half2x4 left, Half2x4 right) 
        => new(left.c0 == right.c0, left.c1 == right.c1, left.c2 == right.c2, left.c3 == right.c3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    static bool2x4 IEqualityOperators<Half2x4, Half2x4, bool2x4>.operator !=(Half2x4 left, Half2x4 right) 
        => new(left.c0 != right.c0, left.c1 != right.c1, left.c2 != right.c2, left.c3 != right.c3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool2x4 VEq(Half2x4 other) 
        => new(this.c0 == other.c0, this.c1 == other.c1, this.c2 == other.c2, this.c3 == other.c3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool2x4 VNe(Half2x4 other) 
        => new(this.c0 != other.c0, this.c1 != other.c1, this.c2 != other.c2, this.c3 != other.c3);

    #endregion


    //////////////////////////////////////////////////////////////////////////////////////////////////// Arithmetic

    #region Arithmetic

    public static Half2x4 AdditiveIdentity 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(Half.Zero);
    }

    public static Half2x4 MultiplicativeIdentity 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(Half.One);
    }


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half2x4 operator +(Half2x4 left, Half2x4 right) 
        => new(left.c0 + right.c0, left.c1 + right.c1, left.c2 + right.c2, left.c3 + right.c3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half2x4 operator -(Half2x4 left, Half2x4 right) 
        => new(left.c0 - right.c0, left.c1 - right.c1, left.c2 - right.c2, left.c3 - right.c3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half2x4 operator *(Half2x4 left, Half2x4 right) 
        => new(left.c0 * right.c0, left.c1 * right.c1, left.c2 * right.c2, left.c3 * right.c3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half2x4 operator /(Half2x4 left, Half2x4 right) 
        => new(left.c0 / right.c0, left.c1 / right.c1, left.c2 / right.c2, left.c3 / right.c3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half2x4 operator %(Half2x4 left, Half2x4 right) 
        => new(left.c0 % right.c0, left.c1 % right.c1, left.c2 % right.c2, left.c3 % right.c3);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half2x4 operator +(Half2x4 left, Half2 right) => new(left.c0 + right, left.c1 + right, left.c2 + right, left.c3 + right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half2x4 operator -(Half2x4 left, Half2 right) => new(left.c0 - right, left.c1 - right, left.c2 - right, left.c3 - right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half2x4 operator *(Half2x4 left, Half2 right) => new(left.c0 * right, left.c1 * right, left.c2 * right, left.c3 * right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half2x4 operator /(Half2x4 left, Half2 right) => new(left.c0 / right, left.c1 / right, left.c2 / right, left.c3 / right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half2x4 operator %(Half2x4 left, Half2 right) => new(left.c0 % right, left.c1 % right, left.c2 % right, left.c3 % right);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half2x4 operator +(Half2 left, Half2x4 right) => new(left + right.c0, left + right.c1, left + right.c2, left + right.c3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half2x4 operator -(Half2 left, Half2x4 right) => new(left - right.c0, left - right.c1, left - right.c2, left - right.c3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half2x4 operator *(Half2 left, Half2x4 right) => new(left * right.c0, left * right.c1, left * right.c2, left * right.c3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half2x4 operator /(Half2 left, Half2x4 right) => new(left / right.c0, left / right.c1, left / right.c2, left / right.c3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half2x4 operator %(Half2 left, Half2x4 right) => new(left % right.c0, left % right.c1, left % right.c2, left % right.c3);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half2x4 operator +(Half2x4 left, Half right) => new(left.c0 + right, left.c1 + right, left.c2 + right, left.c3 + right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half2x4 operator -(Half2x4 left, Half right) => new(left.c0 - right, left.c1 - right, left.c2 - right, left.c3 - right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half2x4 operator *(Half2x4 left, Half right) => new(left.c0 * right, left.c1 * right, left.c2 * right, left.c3 * right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half2x4 operator /(Half2x4 left, Half right) => new(left.c0 / right, left.c1 / right, left.c2 / right, left.c3 / right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half2x4 operator %(Half2x4 left, Half right) => new(left.c0 % right, left.c1 % right, left.c2 % right, left.c3 % right);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half2x4 operator +(Half left, Half2x4 right) => new(left + right.c0, left + right.c1, left + right.c2, left + right.c3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half2x4 operator -(Half left, Half2x4 right) => new(left - right.c0, left - right.c1, left - right.c2, left - right.c3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half2x4 operator *(Half left, Half2x4 right) => new(left * right.c0, left * right.c1, left * right.c2, left * right.c3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half2x4 operator /(Half left, Half2x4 right) => new(left / right.c0, left / right.c1, left / right.c2, left / right.c3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half2x4 operator %(Half left, Half2x4 right) => new(left % right.c0, left % right.c1, left % right.c2, left % right.c3);

    
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half2x4 operator -(Half2x4 self) => new(-self.c0, -self.c1, -self.c2, -self.c3);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Half2x4 operator +(Half2x4 self) => new(+self.c0, +self.c1, +self.c2, +self.c3);

    #endregion

    //////////////////////////////////////////////////////////////////////////////////////////////////// ToString

    #region ToString

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override string ToString() => $"Half2x4({this.c0}, {this.c1}, {this.c2}, {this.c3})";

    #endregion
}
