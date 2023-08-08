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

/// <summary>A 3x4 matrix of float</summary>
[Serializable]
[StructLayout(LayoutKind.Explicit, Size = 48, Pack = 4)]
public unsafe partial struct float3x4a :
    IEquatable<float3x4a>, IEqualityOperators<float3x4a, float3x4a, bool>, IEqualityOperators<float3x4a, float3x4a, bool3x4a>,

    IAdditionOperators<float3x4a, float3x4a, float3x4a>, IAdditiveIdentity<float3x4a, float3x4a>, IUnaryPlusOperators<float3x4a, float3x4a>,
    ISubtractionOperators<float3x4a, float3x4a, float3x4a>, IUnaryNegationOperators<float3x4a, float3x4a>,
    IMultiplyOperators<float3x4a, float3x4a, float3x4a>, IMultiplicativeIdentity<float3x4a, float3x4a>,
    IDivisionOperators<float3x4a, float3x4a, float3x4a>,
    IModulusOperators<float3x4a, float3x4a, float3x4a>,

    IMatrix3x4<float>, IMatrixSelf<float3x4a>
{
    //////////////////////////////////////////////////////////////////////////////////////////////////// Fields

    #region Fields

    /// <summary>Column 0 of the matrix</summary>
    [FieldOffset(0)]
    public float3a c0;

    /// <summary>Column 1 of the matrix</summary>
    [FieldOffset(12)]
    public float3a c1;

    /// <summary>Column 2 of the matrix</summary>
    [FieldOffset(24)]
    public float3a c2;

    /// <summary>Column 3 of the matrix</summary>
    [FieldOffset(36)]
    public float3a c3;


    /// <summary>Row 0 column 0 of the matrix</summary>
    [FieldOffset(0)]
    public float m00;

    /// <summary>Row 1 column 0 of the matrix</summary>
    [FieldOffset(4)]
    public float m10;

    /// <summary>Row 2 column 0 of the matrix</summary>
    [FieldOffset(8)]
    public float m20;

    /// <summary>Row 0 column 1 of the matrix</summary>
    [FieldOffset(12)]
    public float m01;

    /// <summary>Row 1 column 1 of the matrix</summary>
    [FieldOffset(16)]
    public float m11;

    /// <summary>Row 2 column 1 of the matrix</summary>
    [FieldOffset(20)]
    public float m21;

    /// <summary>Row 0 column 2 of the matrix</summary>
    [FieldOffset(24)]
    public float m02;

    /// <summary>Row 1 column 2 of the matrix</summary>
    [FieldOffset(28)]
    public float m12;

    /// <summary>Row 2 column 2 of the matrix</summary>
    [FieldOffset(32)]
    public float m22;

    /// <summary>Row 0 column 3 of the matrix</summary>
    [FieldOffset(36)]
    public float m03;

    /// <summary>Row 1 column 3 of the matrix</summary>
    [FieldOffset(40)]
    public float m13;

    /// <summary>Row 2 column 3 of the matrix</summary>
    [FieldOffset(44)]
    public float m23;

    #endregion

    //////////////////////////////////////////////////////////////////////////////////////////////////// Constants

    #region Constants

    public static readonly float3x4a zero = new(0f);

    public static readonly float3x4a one = new(1f);

    static float3x4a IMatrixSelf<float3x4a>.Zero 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => zero;
    }

    static float3x4a IMatrixSelf<float3x4a>.One 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => one;
    }


    #endregion

    //////////////////////////////////////////////////////////////////////////////////////////////////// Ctor

    #region Ctor


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public float3x4a(float3a c0, float3a c1, float3a c2, float3a c3)
    {
        Unsafe.SkipInit(out this);
        this.c0 = c0;
        this.c1 = c1;
        this.c2 = c2;
        this.c3 = c3;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public float3x4a(float m00, float m10, float m20, float m01, float m11, float m21, float m02, float m12, float m22, float m03, float m13, float m23)
    {
        Unsafe.SkipInit(out this);
        this.c0 = new(m00, m10, m20);
        this.c1 = new(m01, m11, m21);
        this.c2 = new(m02, m12, m22);
        this.c3 = new(m03, m13, m23);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public float3x4a(float value)
    {
        Unsafe.SkipInit(out this);
        this.c0 = new(value);
        this.c1 = new(value);
        this.c2 = new(value);
        this.c3 = new(value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator float3x4a(float value) => new(value);

    #endregion

    //////////////////////////////////////////////////////////////////////////////////////////////////// Equals

    #region Equals

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator ==(float3x4a left, float3x4a right) 
        => left.c0 == right.c0 && left.c1 == right.c1 && left.c2 == right.c2 && left.c3 == right.c3;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator !=(float3x4a left, float3x4a right) 
        => left.c0 != right.c0 || left.c1 != right.c1 || left.c2 != right.c2 || left.c3 != right.c3;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool Equals(float3x4a other) 
        => this == other;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override bool Equals(object? o) 
        => o is float3x4a other && Equals(other);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override int GetHashCode() 
        => HashCode.Combine(this.c0, this.c1, this.c2, this.c3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public int3x4a Hash() 
        => new(this.c0.GetHashCode(), this.c1.GetHashCode(), this.c2.GetHashCode(), this.c3.GetHashCode());

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    static bool3x4a IEqualityOperators<float3x4a, float3x4a, bool3x4a>.operator ==(float3x4a left, float3x4a right) 
        => new(left.c0 == right.c0, left.c1 == right.c1, left.c2 == right.c2, left.c3 == right.c3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    static bool3x4a IEqualityOperators<float3x4a, float3x4a, bool3x4a>.operator !=(float3x4a left, float3x4a right) 
        => new(left.c0 != right.c0, left.c1 != right.c1, left.c2 != right.c2, left.c3 != right.c3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool3x4a VEq(float3x4a other) 
        => new(this.c0 == other.c0, this.c1 == other.c1, this.c2 == other.c2, this.c3 == other.c3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool3x4a VNe(float3x4a other) 
        => new(this.c0 != other.c0, this.c1 != other.c1, this.c2 != other.c2, this.c3 != other.c3);

    #endregion


    //////////////////////////////////////////////////////////////////////////////////////////////////// Arithmetic

    #region Arithmetic

    public static float3x4a AdditiveIdentity 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(0f);
    }

    public static float3x4a MultiplicativeIdentity 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(1f);
    }


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3x4a operator +(float3x4a left, float3x4a right) 
        => new(left.c0 + right.c0, left.c1 + right.c1, left.c2 + right.c2, left.c3 + right.c3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3x4a operator -(float3x4a left, float3x4a right) 
        => new(left.c0 - right.c0, left.c1 - right.c1, left.c2 - right.c2, left.c3 - right.c3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3x4a operator *(float3x4a left, float3x4a right) 
        => new(left.c0 * right.c0, left.c1 * right.c1, left.c2 * right.c2, left.c3 * right.c3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3x4a operator /(float3x4a left, float3x4a right) 
        => new(left.c0 / right.c0, left.c1 / right.c1, left.c2 / right.c2, left.c3 / right.c3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3x4a operator %(float3x4a left, float3x4a right) 
        => new(left.c0 % right.c0, left.c1 % right.c1, left.c2 % right.c2, left.c3 % right.c3);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3x4a operator +(float3x4a left, float3a right) => new(left.c0 + right, left.c1 + right, left.c2 + right, left.c3 + right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3x4a operator -(float3x4a left, float3a right) => new(left.c0 - right, left.c1 - right, left.c2 - right, left.c3 - right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3x4a operator *(float3x4a left, float3a right) => new(left.c0 * right, left.c1 * right, left.c2 * right, left.c3 * right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3x4a operator /(float3x4a left, float3a right) => new(left.c0 / right, left.c1 / right, left.c2 / right, left.c3 / right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3x4a operator %(float3x4a left, float3a right) => new(left.c0 % right, left.c1 % right, left.c2 % right, left.c3 % right);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3x4a operator +(float3a left, float3x4a right) => new(left + right.c0, left + right.c1, left + right.c2, left + right.c3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3x4a operator -(float3a left, float3x4a right) => new(left - right.c0, left - right.c1, left - right.c2, left - right.c3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3x4a operator *(float3a left, float3x4a right) => new(left * right.c0, left * right.c1, left * right.c2, left * right.c3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3x4a operator /(float3a left, float3x4a right) => new(left / right.c0, left / right.c1, left / right.c2, left / right.c3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3x4a operator %(float3a left, float3x4a right) => new(left % right.c0, left % right.c1, left % right.c2, left % right.c3);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3x4a operator +(float3x4a left, float right) => new(left.c0 + right, left.c1 + right, left.c2 + right, left.c3 + right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3x4a operator -(float3x4a left, float right) => new(left.c0 - right, left.c1 - right, left.c2 - right, left.c3 - right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3x4a operator *(float3x4a left, float right) => new(left.c0 * right, left.c1 * right, left.c2 * right, left.c3 * right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3x4a operator /(float3x4a left, float right) => new(left.c0 / right, left.c1 / right, left.c2 / right, left.c3 / right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3x4a operator %(float3x4a left, float right) => new(left.c0 % right, left.c1 % right, left.c2 % right, left.c3 % right);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3x4a operator +(float left, float3x4a right) => new(left + right.c0, left + right.c1, left + right.c2, left + right.c3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3x4a operator -(float left, float3x4a right) => new(left - right.c0, left - right.c1, left - right.c2, left - right.c3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3x4a operator *(float left, float3x4a right) => new(left * right.c0, left * right.c1, left * right.c2, left * right.c3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3x4a operator /(float left, float3x4a right) => new(left / right.c0, left / right.c1, left / right.c2, left / right.c3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3x4a operator %(float left, float3x4a right) => new(left % right.c0, left % right.c1, left % right.c2, left % right.c3);

    
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3x4a operator -(float3x4a self) => new(-self.c0, -self.c1, -self.c2, -self.c3);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3x4a operator +(float3x4a self) => new(+self.c0, +self.c1, +self.c2, +self.c3);

    #endregion

    //////////////////////////////////////////////////////////////////////////////////////////////////// ToString

    #region ToString

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override string ToString() => $"float3x4a({this.c0}, {this.c1}, {this.c2}, {this.c3})";

    #endregion
}
