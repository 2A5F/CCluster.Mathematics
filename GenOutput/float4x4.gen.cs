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

/// <summary>A 4x4 matrix of float</summary>
[Serializable]
[StructLayout(LayoutKind.Explicit, Size = 64, Pack = 4)]
public unsafe partial struct float4x4 :
    IEquatable<float4x4>, IEqualityOperators<float4x4, float4x4, bool>, IEqualityOperators<float4x4, float4x4, bool4x4>,

    IAdditionOperators<float4x4, float4x4, float4x4>, IAdditiveIdentity<float4x4, float4x4>, IUnaryPlusOperators<float4x4, float4x4>,
    ISubtractionOperators<float4x4, float4x4, float4x4>, IUnaryNegationOperators<float4x4, float4x4>,
    IMultiplyOperators<float4x4, float4x4, float4x4>, IMultiplicativeIdentity<float4x4, float4x4>,
    IDivisionOperators<float4x4, float4x4, float4x4>,
    IModulusOperators<float4x4, float4x4, float4x4>,

    IMatrix4x4<float>, IMatrixSelf<float4x4>, IMatrixIdentity<float4x4>
{
    //////////////////////////////////////////////////////////////////////////////////////////////////// Fields

    #region Fields

    /// <summary>Column 0 of the matrix</summary>
    [FieldOffset(0)]
    public float4 c0;

    /// <summary>Column 1 of the matrix</summary>
    [FieldOffset(16)]
    public float4 c1;

    /// <summary>Column 2 of the matrix</summary>
    [FieldOffset(32)]
    public float4 c2;

    /// <summary>Column 3 of the matrix</summary>
    [FieldOffset(48)]
    public float4 c3;


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

    /// <summary>Row 0 column 2 of the matrix</summary>
    [FieldOffset(32)]
    public float m02;

    /// <summary>Row 1 column 2 of the matrix</summary>
    [FieldOffset(36)]
    public float m12;

    /// <summary>Row 2 column 2 of the matrix</summary>
    [FieldOffset(40)]
    public float m22;

    /// <summary>Row 3 column 2 of the matrix</summary>
    [FieldOffset(44)]
    public float m32;

    /// <summary>Row 0 column 3 of the matrix</summary>
    [FieldOffset(48)]
    public float m03;

    /// <summary>Row 1 column 3 of the matrix</summary>
    [FieldOffset(52)]
    public float m13;

    /// <summary>Row 2 column 3 of the matrix</summary>
    [FieldOffset(56)]
    public float m23;

    /// <summary>Row 3 column 3 of the matrix</summary>
    [FieldOffset(60)]
    public float m33;

    #endregion

    //////////////////////////////////////////////////////////////////////////////////////////////////// Constants

    #region Constants

    public static readonly float4x4 identity = new float4x4(
        1f, 0f, 0f, 0f,
        0f, 1f, 0f, 0f,
        0f, 0f, 1f, 0f,
        0f, 0f, 0f, 1f
    );

    public static readonly float4x4 zero = new(0f);

    public static readonly float4x4 one = new(1f);

    static float4x4 IMatrixSelf<float4x4>.Zero 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => zero;
    }

    static float4x4 IMatrixSelf<float4x4>.One 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => one;
    }

    static float4x4 IMatrixIdentity<float4x4>.Identity 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => identity;
    }

    #endregion

    //////////////////////////////////////////////////////////////////////////////////////////////////// Ctor

    #region Ctor


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public float4x4(float4 c0, float4 c1, float4 c2, float4 c3)
    {
        Unsafe.SkipInit(out this);
        this.c0.vector = c0.vector;
        this.c1.vector = c1.vector;
        this.c2.vector = c2.vector;
        this.c3.vector = c3.vector;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public float4x4(float m00, float m10, float m20, float m30, float m01, float m11, float m21, float m31, float m02, float m12, float m22, float m32, float m03, float m13, float m23, float m33)
    {
        Unsafe.SkipInit(out this);
        this.c0.vector = Vector128.Create(m00, m10, m20, m30);
        this.c1.vector = Vector128.Create(m01, m11, m21, m31);
        this.c2.vector = Vector128.Create(m02, m12, m22, m32);
        this.c3.vector = Vector128.Create(m03, m13, m23, m33);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public float4x4(float value)
    {
        Unsafe.SkipInit(out this);
        this.c0.vector = Vector128.Create(value);
        this.c1.vector = Vector128.Create(value);
        this.c2.vector = Vector128.Create(value);
        this.c3.vector = Vector128.Create(value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator float4x4(float value) => new(value);

    #endregion

    //////////////////////////////////////////////////////////////////////////////////////////////////// Equals

    #region Equals

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator ==(float4x4 left, float4x4 right) 
        => left.c0 == right.c0 && left.c1 == right.c1 && left.c2 == right.c2 && left.c3 == right.c3;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator !=(float4x4 left, float4x4 right) 
        => left.c0 != right.c0 || left.c1 != right.c1 || left.c2 != right.c2 || left.c3 != right.c3;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool Equals(float4x4 other) 
        => this == other;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override bool Equals(object? o) 
        => o is float4x4 other && Equals(other);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override int GetHashCode() 
        => HashCode.Combine(this.c0, this.c1, this.c2, this.c3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public int4x4 Hash() 
        => new(this.c0.GetHashCode(), this.c1.GetHashCode(), this.c2.GetHashCode(), this.c3.GetHashCode());

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    static bool4x4 IEqualityOperators<float4x4, float4x4, bool4x4>.operator ==(float4x4 left, float4x4 right) 
        => new(left.c0 == right.c0, left.c1 == right.c1, left.c2 == right.c2, left.c3 == right.c3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    static bool4x4 IEqualityOperators<float4x4, float4x4, bool4x4>.operator !=(float4x4 left, float4x4 right) 
        => new(left.c0 != right.c0, left.c1 != right.c1, left.c2 != right.c2, left.c3 != right.c3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool4x4 VEq(float4x4 other) 
        => new(this.c0 == other.c0, this.c1 == other.c1, this.c2 == other.c2, this.c3 == other.c3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool4x4 VNe(float4x4 other) 
        => new(this.c0 != other.c0, this.c1 != other.c1, this.c2 != other.c2, this.c3 != other.c3);

    #endregion


    //////////////////////////////////////////////////////////////////////////////////////////////////// Arithmetic

    #region Arithmetic

    public static float4x4 AdditiveIdentity 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(0f);
    }

    public static float4x4 MultiplicativeIdentity 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(1f);
    }


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float4x4 operator +(float4x4 left, float4x4 right) 
        => new(left.c0 + right.c0, left.c1 + right.c1, left.c2 + right.c2, left.c3 + right.c3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float4x4 operator -(float4x4 left, float4x4 right) 
        => new(left.c0 - right.c0, left.c1 - right.c1, left.c2 - right.c2, left.c3 - right.c3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float4x4 operator *(float4x4 left, float4x4 right) 
        => new(left.c0 * right.c0, left.c1 * right.c1, left.c2 * right.c2, left.c3 * right.c3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float4x4 operator /(float4x4 left, float4x4 right) 
        => new(left.c0 / right.c0, left.c1 / right.c1, left.c2 / right.c2, left.c3 / right.c3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float4x4 operator %(float4x4 left, float4x4 right) 
        => new(left.c0 % right.c0, left.c1 % right.c1, left.c2 % right.c2, left.c3 % right.c3);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float4x4 operator +(float4x4 left, float4 right) => new(left.c0 + right, left.c1 + right, left.c2 + right, left.c3 + right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float4x4 operator -(float4x4 left, float4 right) => new(left.c0 - right, left.c1 - right, left.c2 - right, left.c3 - right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float4x4 operator *(float4x4 left, float4 right) => new(left.c0 * right, left.c1 * right, left.c2 * right, left.c3 * right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float4x4 operator /(float4x4 left, float4 right) => new(left.c0 / right, left.c1 / right, left.c2 / right, left.c3 / right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float4x4 operator %(float4x4 left, float4 right) => new(left.c0 % right, left.c1 % right, left.c2 % right, left.c3 % right);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float4x4 operator +(float4 left, float4x4 right) => new(left + right.c0, left + right.c1, left + right.c2, left + right.c3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float4x4 operator -(float4 left, float4x4 right) => new(left - right.c0, left - right.c1, left - right.c2, left - right.c3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float4x4 operator *(float4 left, float4x4 right) => new(left * right.c0, left * right.c1, left * right.c2, left * right.c3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float4x4 operator /(float4 left, float4x4 right) => new(left / right.c0, left / right.c1, left / right.c2, left / right.c3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float4x4 operator %(float4 left, float4x4 right) => new(left % right.c0, left % right.c1, left % right.c2, left % right.c3);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float4x4 operator +(float4x4 left, float right) => new(left.c0 + right, left.c1 + right, left.c2 + right, left.c3 + right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float4x4 operator -(float4x4 left, float right) => new(left.c0 - right, left.c1 - right, left.c2 - right, left.c3 - right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float4x4 operator *(float4x4 left, float right) => new(left.c0 * right, left.c1 * right, left.c2 * right, left.c3 * right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float4x4 operator /(float4x4 left, float right) => new(left.c0 / right, left.c1 / right, left.c2 / right, left.c3 / right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float4x4 operator %(float4x4 left, float right) => new(left.c0 % right, left.c1 % right, left.c2 % right, left.c3 % right);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float4x4 operator +(float left, float4x4 right) => new(left + right.c0, left + right.c1, left + right.c2, left + right.c3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float4x4 operator -(float left, float4x4 right) => new(left - right.c0, left - right.c1, left - right.c2, left - right.c3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float4x4 operator *(float left, float4x4 right) => new(left * right.c0, left * right.c1, left * right.c2, left * right.c3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float4x4 operator /(float left, float4x4 right) => new(left / right.c0, left / right.c1, left / right.c2, left / right.c3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float4x4 operator %(float left, float4x4 right) => new(left % right.c0, left % right.c1, left % right.c2, left % right.c3);

    
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float4x4 operator -(float4x4 self) => new(-self.c0, -self.c1, -self.c2, -self.c3);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float4x4 operator +(float4x4 self) => new(+self.c0, +self.c1, +self.c2, +self.c3);

    #endregion

    //////////////////////////////////////////////////////////////////////////////////////////////////// ToString

    #region ToString

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override string ToString() => $"float4x4({this.c0}, {this.c1}, {this.c2}, {this.c3})";

    #endregion
}
