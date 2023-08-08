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

/// <summary>A 2x4 matrix of bool</summary>
[Serializable]
[StructLayout(LayoutKind.Explicit, Size = 8)]
public unsafe partial struct bool2x4 :
    IEquatable<bool2x4>, IEqualityOperators<bool2x4, bool2x4, bool>, IEqualityOperators<bool2x4, bool2x4, bool2x4>,

    IMatrix2x4<bool>, IMatrixSelf<bool2x4>
{
    //////////////////////////////////////////////////////////////////////////////////////////////////// Fields

    #region Fields

    /// <summary>Column 0 of the matrix</summary>
    [FieldOffset(0)]
    public bool2 c0;

    /// <summary>Column 1 of the matrix</summary>
    [FieldOffset(2)]
    public bool2 c1;

    /// <summary>Column 2 of the matrix</summary>
    [FieldOffset(4)]
    public bool2 c2;

    /// <summary>Column 3 of the matrix</summary>
    [FieldOffset(6)]
    public bool2 c3;


    /// <summary>Row 0 column 0 of the matrix</summary>
    [FieldOffset(0)]
    public bool m00;

    /// <summary>Row 1 column 0 of the matrix</summary>
    [FieldOffset(1)]
    public bool m10;

    /// <summary>Row 0 column 1 of the matrix</summary>
    [FieldOffset(2)]
    public bool m01;

    /// <summary>Row 1 column 1 of the matrix</summary>
    [FieldOffset(3)]
    public bool m11;

    /// <summary>Row 0 column 2 of the matrix</summary>
    [FieldOffset(4)]
    public bool m02;

    /// <summary>Row 1 column 2 of the matrix</summary>
    [FieldOffset(5)]
    public bool m12;

    /// <summary>Row 0 column 3 of the matrix</summary>
    [FieldOffset(6)]
    public bool m03;

    /// <summary>Row 1 column 3 of the matrix</summary>
    [FieldOffset(7)]
    public bool m13;

    #endregion

    //////////////////////////////////////////////////////////////////////////////////////////////////// Constants

    #region Constants

    public static readonly bool2x4 zero = new(false);

    public static readonly bool2x4 one = new(true);

    static bool2x4 IMatrixSelf<bool2x4>.Zero 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => zero;
    }

    static bool2x4 IMatrixSelf<bool2x4>.One 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => one;
    }


    #endregion

    //////////////////////////////////////////////////////////////////////////////////////////////////// Ctor

    #region Ctor


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool2x4(bool2 c0, bool2 c1, bool2 c2, bool2 c3)
    {
        Unsafe.SkipInit(out this);
        this.c0 = c0;
        this.c1 = c1;
        this.c2 = c2;
        this.c3 = c3;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool2x4(bool m00, bool m10, bool m01, bool m11, bool m02, bool m12, bool m03, bool m13)
    {
        Unsafe.SkipInit(out this);
        this.c0 = new(m00, m10);
        this.c1 = new(m01, m11);
        this.c2 = new(m02, m12);
        this.c3 = new(m03, m13);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool2x4(bool value)
    {
        Unsafe.SkipInit(out this);
        this.c0 = new(value);
        this.c1 = new(value);
        this.c2 = new(value);
        this.c3 = new(value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator bool2x4(bool value) => new(value);

    #endregion

    //////////////////////////////////////////////////////////////////////////////////////////////////// Equals

    #region Equals

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator ==(bool2x4 left, bool2x4 right) 
        => left.c0 == right.c0 && left.c1 == right.c1 && left.c2 == right.c2 && left.c3 == right.c3;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator !=(bool2x4 left, bool2x4 right) 
        => left.c0 != right.c0 || left.c1 != right.c1 || left.c2 != right.c2 || left.c3 != right.c3;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool Equals(bool2x4 other) 
        => this == other;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override bool Equals(object? o) 
        => o is bool2x4 other && Equals(other);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override int GetHashCode() 
        => HashCode.Combine(this.c0, this.c1, this.c2, this.c3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public int2x4 Hash() 
        => new(this.c0.GetHashCode(), this.c1.GetHashCode(), this.c2.GetHashCode(), this.c3.GetHashCode());

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    static bool2x4 IEqualityOperators<bool2x4, bool2x4, bool2x4>.operator ==(bool2x4 left, bool2x4 right) 
        => new(left.c0 == right.c0, left.c1 == right.c1, left.c2 == right.c2, left.c3 == right.c3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    static bool2x4 IEqualityOperators<bool2x4, bool2x4, bool2x4>.operator !=(bool2x4 left, bool2x4 right) 
        => new(left.c0 != right.c0, left.c1 != right.c1, left.c2 != right.c2, left.c3 != right.c3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool2x4 VEq(bool2x4 other) 
        => new(this.c0 == other.c0, this.c1 == other.c1, this.c2 == other.c2, this.c3 == other.c3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool2x4 VNe(bool2x4 other) 
        => new(this.c0 != other.c0, this.c1 != other.c1, this.c2 != other.c2, this.c3 != other.c3);

    #endregion


    //////////////////////////////////////////////////////////////////////////////////////////////////// ToString

    #region ToString

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override string ToString() => $"bool2x4({this.c0}, {this.c1}, {this.c2}, {this.c3})";

    #endregion
}
