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

/// <summary>A 3x4 matrix of long</summary>
[Serializable]
[StructLayout(LayoutKind.Explicit, Size = 128, Pack = 8)]
public unsafe partial struct long3x4 :
    IEquatable<long3x4>, IEqualityOperators<long3x4, long3x4, bool>, IEqualityOperators<long3x4, long3x4, bool3x4>,

    IAdditionOperators<long3x4, long3x4, long3x4>, IAdditiveIdentity<long3x4, long3x4>, IUnaryPlusOperators<long3x4, long3x4>,
    ISubtractionOperators<long3x4, long3x4, long3x4>, IUnaryNegationOperators<long3x4, long3x4>,
    IMultiplyOperators<long3x4, long3x4, long3x4>, IMultiplicativeIdentity<long3x4, long3x4>,
    IDivisionOperators<long3x4, long3x4, long3x4>,
    IModulusOperators<long3x4, long3x4, long3x4>,

    IMatrix3x4<long>, IMatrixSelf<long3x4>
{
    //////////////////////////////////////////////////////////////////////////////////////////////////// Fields

    #region Fields

    /// <summary>Column 0 of the matrix</summary>
    [FieldOffset(0)]
    public long3 c0;

    /// <summary>Column 1 of the matrix</summary>
    [FieldOffset(32)]
    public long3 c1;

    /// <summary>Column 2 of the matrix</summary>
    [FieldOffset(64)]
    public long3 c2;

    /// <summary>Column 3 of the matrix</summary>
    [FieldOffset(96)]
    public long3 c3;


    /// <summary>Row 0 column 0 of the matrix</summary>
    [FieldOffset(0)]
    public long m00;

    /// <summary>Row 1 column 0 of the matrix</summary>
    [FieldOffset(8)]
    public long m10;

    /// <summary>Row 2 column 0 of the matrix</summary>
    [FieldOffset(16)]
    public long m20;

    /// <summary>Row 0 column 1 of the matrix</summary>
    [FieldOffset(32)]
    public long m01;

    /// <summary>Row 1 column 1 of the matrix</summary>
    [FieldOffset(40)]
    public long m11;

    /// <summary>Row 2 column 1 of the matrix</summary>
    [FieldOffset(48)]
    public long m21;

    /// <summary>Row 0 column 2 of the matrix</summary>
    [FieldOffset(64)]
    public long m02;

    /// <summary>Row 1 column 2 of the matrix</summary>
    [FieldOffset(72)]
    public long m12;

    /// <summary>Row 2 column 2 of the matrix</summary>
    [FieldOffset(80)]
    public long m22;

    /// <summary>Row 0 column 3 of the matrix</summary>
    [FieldOffset(96)]
    public long m03;

    /// <summary>Row 1 column 3 of the matrix</summary>
    [FieldOffset(104)]
    public long m13;

    /// <summary>Row 2 column 3 of the matrix</summary>
    [FieldOffset(112)]
    public long m23;

    #endregion

    //////////////////////////////////////////////////////////////////////////////////////////////////// Constants

    #region Constants

    public static readonly long3x4 zero = new(0L);

    public static readonly long3x4 one = new(1L);

    static long3x4 IMatrixSelf<long3x4>.Zero 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => zero;
    }

    static long3x4 IMatrixSelf<long3x4>.One 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => one;
    }


    #endregion

    //////////////////////////////////////////////////////////////////////////////////////////////////// Ctor

    #region Ctor


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public long3x4(long3 c0, long3 c1, long3 c2, long3 c3)
    {
        Unsafe.SkipInit(out this);
        this.c0.vector = c0.vector;
        this.c1.vector = c1.vector;
        this.c2.vector = c2.vector;
        this.c3.vector = c3.vector;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public long3x4(long m00, long m10, long m20, long m01, long m11, long m21, long m02, long m12, long m22, long m03, long m13, long m23)
    {
        Unsafe.SkipInit(out this);
        this.c0.vector = Vector256.Create(m00, m10, m20, 0L);
        this.c1.vector = Vector256.Create(m01, m11, m21, 0L);
        this.c2.vector = Vector256.Create(m02, m12, m22, 0L);
        this.c3.vector = Vector256.Create(m03, m13, m23, 0L);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public long3x4(long value)
    {
        Unsafe.SkipInit(out this);
        this.c0.vector = Vector256.Create(value);
        this.c1.vector = Vector256.Create(value);
        this.c2.vector = Vector256.Create(value);
        this.c3.vector = Vector256.Create(value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator long3x4(long value) => new(value);

    #endregion

    //////////////////////////////////////////////////////////////////////////////////////////////////// Equals

    #region Equals

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator ==(long3x4 left, long3x4 right) 
        => left.c0 == right.c0 && left.c1 == right.c1 && left.c2 == right.c2 && left.c3 == right.c3;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator !=(long3x4 left, long3x4 right) 
        => left.c0 != right.c0 || left.c1 != right.c1 || left.c2 != right.c2 || left.c3 != right.c3;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool Equals(long3x4 other) 
        => this == other;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override bool Equals(object? o) 
        => o is long3x4 other && Equals(other);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override int GetHashCode() 
        => HashCode.Combine(this.c0, this.c1, this.c2, this.c3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public int3x4 Hash() 
        => new(this.c0.GetHashCode(), this.c1.GetHashCode(), this.c2.GetHashCode(), this.c3.GetHashCode());

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    static bool3x4 IEqualityOperators<long3x4, long3x4, bool3x4>.operator ==(long3x4 left, long3x4 right) 
        => new(left.c0 == right.c0, left.c1 == right.c1, left.c2 == right.c2, left.c3 == right.c3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    static bool3x4 IEqualityOperators<long3x4, long3x4, bool3x4>.operator !=(long3x4 left, long3x4 right) 
        => new(left.c0 != right.c0, left.c1 != right.c1, left.c2 != right.c2, left.c3 != right.c3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool3x4 VEq(long3x4 other) 
        => new(this.c0 == other.c0, this.c1 == other.c1, this.c2 == other.c2, this.c3 == other.c3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool3x4 VNe(long3x4 other) 
        => new(this.c0 != other.c0, this.c1 != other.c1, this.c2 != other.c2, this.c3 != other.c3);

    #endregion


    //////////////////////////////////////////////////////////////////////////////////////////////////// Arithmetic

    #region Arithmetic

    public static long3x4 AdditiveIdentity 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(0L);
    }

    public static long3x4 MultiplicativeIdentity 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(1L);
    }


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long3x4 operator +(long3x4 left, long3x4 right) 
        => new(left.c0 + right.c0, left.c1 + right.c1, left.c2 + right.c2, left.c3 + right.c3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long3x4 operator -(long3x4 left, long3x4 right) 
        => new(left.c0 - right.c0, left.c1 - right.c1, left.c2 - right.c2, left.c3 - right.c3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long3x4 operator *(long3x4 left, long3x4 right) 
        => new(left.c0 * right.c0, left.c1 * right.c1, left.c2 * right.c2, left.c3 * right.c3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long3x4 operator /(long3x4 left, long3x4 right) 
        => new(left.c0 / right.c0, left.c1 / right.c1, left.c2 / right.c2, left.c3 / right.c3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long3x4 operator %(long3x4 left, long3x4 right) 
        => new(left.c0 % right.c0, left.c1 % right.c1, left.c2 % right.c2, left.c3 % right.c3);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long3x4 operator +(long3x4 left, long3 right) => new(left.c0 + right, left.c1 + right, left.c2 + right, left.c3 + right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long3x4 operator -(long3x4 left, long3 right) => new(left.c0 - right, left.c1 - right, left.c2 - right, left.c3 - right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long3x4 operator *(long3x4 left, long3 right) => new(left.c0 * right, left.c1 * right, left.c2 * right, left.c3 * right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long3x4 operator /(long3x4 left, long3 right) => new(left.c0 / right, left.c1 / right, left.c2 / right, left.c3 / right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long3x4 operator %(long3x4 left, long3 right) => new(left.c0 % right, left.c1 % right, left.c2 % right, left.c3 % right);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long3x4 operator +(long3 left, long3x4 right) => new(left + right.c0, left + right.c1, left + right.c2, left + right.c3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long3x4 operator -(long3 left, long3x4 right) => new(left - right.c0, left - right.c1, left - right.c2, left - right.c3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long3x4 operator *(long3 left, long3x4 right) => new(left * right.c0, left * right.c1, left * right.c2, left * right.c3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long3x4 operator /(long3 left, long3x4 right) => new(left / right.c0, left / right.c1, left / right.c2, left / right.c3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long3x4 operator %(long3 left, long3x4 right) => new(left % right.c0, left % right.c1, left % right.c2, left % right.c3);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long3x4 operator +(long3x4 left, long right) => new(left.c0 + right, left.c1 + right, left.c2 + right, left.c3 + right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long3x4 operator -(long3x4 left, long right) => new(left.c0 - right, left.c1 - right, left.c2 - right, left.c3 - right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long3x4 operator *(long3x4 left, long right) => new(left.c0 * right, left.c1 * right, left.c2 * right, left.c3 * right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long3x4 operator /(long3x4 left, long right) => new(left.c0 / right, left.c1 / right, left.c2 / right, left.c3 / right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long3x4 operator %(long3x4 left, long right) => new(left.c0 % right, left.c1 % right, left.c2 % right, left.c3 % right);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long3x4 operator +(long left, long3x4 right) => new(left + right.c0, left + right.c1, left + right.c2, left + right.c3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long3x4 operator -(long left, long3x4 right) => new(left - right.c0, left - right.c1, left - right.c2, left - right.c3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long3x4 operator *(long left, long3x4 right) => new(left * right.c0, left * right.c1, left * right.c2, left * right.c3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long3x4 operator /(long left, long3x4 right) => new(left / right.c0, left / right.c1, left / right.c2, left / right.c3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long3x4 operator %(long left, long3x4 right) => new(left % right.c0, left % right.c1, left % right.c2, left % right.c3);

    
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long3x4 operator -(long3x4 self) => new(-self.c0, -self.c1, -self.c2, -self.c3);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long3x4 operator +(long3x4 self) => new(+self.c0, +self.c1, +self.c2, +self.c3);

    #endregion

    //////////////////////////////////////////////////////////////////////////////////////////////////// ToString

    #region ToString

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override string ToString() => $"long3x4({this.c0}, {this.c1}, {this.c2}, {this.c3})";

    #endregion
}
