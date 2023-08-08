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

/// <summary>A 4x2 matrix of float</summary>
[Serializable]
[StructLayout(LayoutKind.Explicit, Size = 32)]
public unsafe partial struct float4x2 :
    IEquatable<float4x2>, IEqualityOperators<float4x2, float4x2, bool>, IEqualityOperators<float4x2, float4x2, bool4x2>,

    IAdditionOperators<float4x2, float4x2, float4x2>, IAdditiveIdentity<float4x2, float4x2>, IUnaryPlusOperators<float4x2, float4x2>,
    ISubtractionOperators<float4x2, float4x2, float4x2>, IUnaryNegationOperators<float4x2, float4x2>,
    IMultiplyOperators<float4x2, float4x2, float4x2>, IMultiplicativeIdentity<float4x2, float4x2>,
    IDivisionOperators<float4x2, float4x2, float4x2>,
    IModulusOperators<float4x2, float4x2, float4x2>,

    IMatrix4x2<float>, IMatrixSelf<float4x2>
{
    //////////////////////////////////////////////////////////////////////////////////////////////////// Fields

    #region Fields

    /// <summary>Column 0 of the matrix</summary>
    [FieldOffset(0)]
    public float4 c0;

    /// <summary>Column 1 of the matrix</summary>
    [FieldOffset(16)]
    public float4 c1;


    /// <summary>Row 0 column 0 of the matrix</summary>
    [FieldOffset(0)]
    public float m00;

    /// <summary>Row 1 column 0 of the matrix</summary>
    [FieldOffset(4)]
    public float m10;

    /// <summary>Row 2 column 0 of the matrix</summary>
    [FieldOffset(8)]
    public float m20;

    /// <summary>Row 3 column 0 of the matrix</summary>
    [FieldOffset(12)]
    public float m30;

    /// <summary>Row 0 column 1 of the matrix</summary>
    [FieldOffset(16)]
    public float m01;

    /// <summary>Row 1 column 1 of the matrix</summary>
    [FieldOffset(20)]
    public float m11;

    /// <summary>Row 2 column 1 of the matrix</summary>
    [FieldOffset(24)]
    public float m21;

    /// <summary>Row 3 column 1 of the matrix</summary>
    [FieldOffset(28)]
    public float m31;

    #endregion

    //////////////////////////////////////////////////////////////////////////////////////////////////// Constants

    #region Constants

    public static readonly float4x2 zero = new(0f);

    public static readonly float4x2 one = new(1f);

    static float4x2 IMatrixSelf<float4x2>.Zero 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => zero;
    }

    static float4x2 IMatrixSelf<float4x2>.One 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => one;
    }


    #endregion

    //////////////////////////////////////////////////////////////////////////////////////////////////// Ctor

    #region Ctor


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public float4x2(float4 c0, float4 c1)
    {
        Unsafe.SkipInit(out this);
        this.c0.vector = c0.vector;
        this.c1.vector = c1.vector;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public float4x2(float m00, float m10, float m20, float m30, float m01, float m11, float m21, float m31)
    {
        Unsafe.SkipInit(out this);
        this.c0.vector = Vector128.Create(m00, m10, m20, m30);
        this.c1.vector = Vector128.Create(m01, m11, m21, m31);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public float4x2(float value)
    {
        Unsafe.SkipInit(out this);
        this.c0.vector = Vector128.Create(value);
        this.c1.vector = Vector128.Create(value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator float4x2(float value) => new(value);

    #endregion

    //////////////////////////////////////////////////////////////////////////////////////////////////// Equals

    #region Equals

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator ==(float4x2 left, float4x2 right) 
        => left.c0 == right.c0 && left.c1 == right.c1;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator !=(float4x2 left, float4x2 right) 
        => left.c0 != right.c0 || left.c1 != right.c1;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool Equals(float4x2 other) 
        => this == other;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override bool Equals(object? o) 
        => o is float4x2 other && Equals(other);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override int GetHashCode() 
        => HashCode.Combine(this.c0, this.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public int4x2 Hash() 
        => new(this.c0.GetHashCode(), this.c1.GetHashCode());

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    static bool4x2 IEqualityOperators<float4x2, float4x2, bool4x2>.operator ==(float4x2 left, float4x2 right) 
        => new(left.c0 == right.c0, left.c1 == right.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    static bool4x2 IEqualityOperators<float4x2, float4x2, bool4x2>.operator !=(float4x2 left, float4x2 right) 
        => new(left.c0 != right.c0, left.c1 != right.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool4x2 VEq(float4x2 other) 
        => new(this.c0 == other.c0, this.c1 == other.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool4x2 VNe(float4x2 other) 
        => new(this.c0 != other.c0, this.c1 != other.c1);

    #endregion


    //////////////////////////////////////////////////////////////////////////////////////////////////// Arithmetic

    #region Arithmetic

    public static float4x2 AdditiveIdentity 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(0f);
    }

    public static float4x2 MultiplicativeIdentity 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(1f);
    }


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float4x2 operator +(float4x2 left, float4x2 right) 
        => new(left.c0 + right.c0, left.c1 + right.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float4x2 operator -(float4x2 left, float4x2 right) 
        => new(left.c0 - right.c0, left.c1 - right.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float4x2 operator *(float4x2 left, float4x2 right) 
        => new(left.c0 * right.c0, left.c1 * right.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float4x2 operator /(float4x2 left, float4x2 right) 
        => new(left.c0 / right.c0, left.c1 / right.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float4x2 operator %(float4x2 left, float4x2 right) 
        => new(left.c0 % right.c0, left.c1 % right.c1);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float4x2 operator +(float4x2 left, float4 right) => new(left.c0 + right, left.c1 + right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float4x2 operator -(float4x2 left, float4 right) => new(left.c0 - right, left.c1 - right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float4x2 operator *(float4x2 left, float4 right) => new(left.c0 * right, left.c1 * right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float4x2 operator /(float4x2 left, float4 right) => new(left.c0 / right, left.c1 / right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float4x2 operator %(float4x2 left, float4 right) => new(left.c0 % right, left.c1 % right);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float4x2 operator +(float4 left, float4x2 right) => new(left + right.c0, left + right.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float4x2 operator -(float4 left, float4x2 right) => new(left - right.c0, left - right.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float4x2 operator *(float4 left, float4x2 right) => new(left * right.c0, left * right.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float4x2 operator /(float4 left, float4x2 right) => new(left / right.c0, left / right.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float4x2 operator %(float4 left, float4x2 right) => new(left % right.c0, left % right.c1);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float4x2 operator +(float4x2 left, float right) => new(left.c0 + right, left.c1 + right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float4x2 operator -(float4x2 left, float right) => new(left.c0 - right, left.c1 - right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float4x2 operator *(float4x2 left, float right) => new(left.c0 * right, left.c1 * right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float4x2 operator /(float4x2 left, float right) => new(left.c0 / right, left.c1 / right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float4x2 operator %(float4x2 left, float right) => new(left.c0 % right, left.c1 % right);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float4x2 operator +(float left, float4x2 right) => new(left + right.c0, left + right.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float4x2 operator -(float left, float4x2 right) => new(left - right.c0, left - right.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float4x2 operator *(float left, float4x2 right) => new(left * right.c0, left * right.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float4x2 operator /(float left, float4x2 right) => new(left / right.c0, left / right.c1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float4x2 operator %(float left, float4x2 right) => new(left % right.c0, left % right.c1);

    
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float4x2 operator -(float4x2 self) => new(-self.c0, -self.c1);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float4x2 operator +(float4x2 self) => new(+self.c0, +self.c1);

    #endregion

    //////////////////////////////////////////////////////////////////////////////////////////////////// ToString

    #region ToString

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override string ToString() => $"float4x2({this.c0}, {this.c1})";

    #endregion
}
