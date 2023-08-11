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
using CCluster.Mathematics.Json;

#nullable enable
#pragma warning disable CS8981

namespace CCluster.Mathematics
{

/// <summary>A 3x4 matrix of uint</summary>
[Serializable]
[JsonConverter(typeof(Uint3x4JsonConverter))]
[StructLayout(LayoutKind.Explicit, Size = 64, Pack = 4)]
public unsafe partial struct uint3x4 :
    IEquatable<uint3x4>, IEqualityOperators<uint3x4, uint3x4, bool>, IEqualityOperators<uint3x4, uint3x4, bool3x4>,

    IAdditionOperators<uint3x4, uint3x4, uint3x4>, IAdditiveIdentity<uint3x4, uint3x4>, IUnaryPlusOperators<uint3x4, uint3x4>,
    ISubtractionOperators<uint3x4, uint3x4, uint3x4>, 
    IMultiplyOperators<uint3x4, uint3x4, uint3x4>, IMultiplicativeIdentity<uint3x4, uint3x4>,
    IDivisionOperators<uint3x4, uint3x4, uint3x4>,
    IModulusOperators<uint3x4, uint3x4, uint3x4>,

    IMatrix3x4<uint>, IMatrixSelf<uint3x4>
{
    //////////////////////////////////////////////////////////////////////////////////////////////////// Fields

    #region Fields

    /// <summary>Column 0 of the matrix</summary>
    [FieldOffset(0)]
    public uint3 c0;

    /// <summary>Column 1 of the matrix</summary>
    [FieldOffset(16)]
    public uint3 c1;

    /// <summary>Column 2 of the matrix</summary>
    [FieldOffset(32)]
    public uint3 c2;

    /// <summary>Column 3 of the matrix</summary>
    [FieldOffset(48)]
    public uint3 c3;


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
    [FieldOffset(16)]
    public uint m01;

    /// <summary>Row 1 column 1 of the matrix</summary>
    [FieldOffset(20)]
    public uint m11;

    /// <summary>Row 2 column 1 of the matrix</summary>
    [FieldOffset(24)]
    public uint m21;

    /// <summary>Row 0 column 2 of the matrix</summary>
    [FieldOffset(32)]
    public uint m02;

    /// <summary>Row 1 column 2 of the matrix</summary>
    [FieldOffset(36)]
    public uint m12;

    /// <summary>Row 2 column 2 of the matrix</summary>
    [FieldOffset(40)]
    public uint m22;

    /// <summary>Row 0 column 3 of the matrix</summary>
    [FieldOffset(48)]
    public uint m03;

    /// <summary>Row 1 column 3 of the matrix</summary>
    [FieldOffset(52)]
    public uint m13;

    /// <summary>Row 2 column 3 of the matrix</summary>
    [FieldOffset(56)]
    public uint m23;

    #endregion

    //////////////////////////////////////////////////////////////////////////////////////////////////// Constants

    #region Constants

    public static readonly uint3x4 zero = new(0u);

    public static readonly uint3x4 one = new(1u);

    static uint3x4 IMatrixSelf<uint3x4>.Zero 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => zero;
    }

    static uint3x4 IMatrixSelf<uint3x4>.One 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => one;
    }


    #endregion

    //////////////////////////////////////////////////////////////////////////////////////////////////// Ctor

    #region Ctor


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public uint3x4(uint3 c0, uint3 c1, uint3 c2, uint3 c3)
    {
        Unsafe.SkipInit(out this);
        this.c0.vector = c0.vector;
        this.c1.vector = c1.vector;
        this.c2.vector = c2.vector;
        this.c3.vector = c3.vector;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public uint3x4(uint m00, uint m10, uint m20, uint m01, uint m11, uint m21, uint m02, uint m12, uint m22, uint m03, uint m13, uint m23)
    {
        Unsafe.SkipInit(out this);
        this.c0.vector = Vector128.Create(m00, m10, m20, 0u);
        this.c1.vector = Vector128.Create(m01, m11, m21, 0u);
        this.c2.vector = Vector128.Create(m02, m12, m22, 0u);
        this.c3.vector = Vector128.Create(m03, m13, m23, 0u);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3x4 RowMajor(uint m00, uint m01, uint m02, uint m03, uint m10, uint m11, uint m12, uint m13, uint m20, uint m21, uint m22, uint m23) 
        => new(m00, m10, m20, m01, m11, m21, m02, m12, m22, m03, m13, m23);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public uint3x4(uint value)
    {
        Unsafe.SkipInit(out this);
        this.c0.vector = Vector128.Create(value);
        this.c1.vector = Vector128.Create(value);
        this.c2.vector = Vector128.Create(value);
        this.c3.vector = Vector128.Create(value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public uint3x4(uint3 value)
    {
        Unsafe.SkipInit(out this);
        this.c0.vector = value.vector;
        this.c1.vector = value.vector;
        this.c2.vector = value.vector;
        this.c3.vector = value.vector;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator uint3x4(uint value) => new(value);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator uint3x4(uint3 value) => new(value);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static explicit operator uint(uint3x4 value) => value.m00;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static explicit operator uint3(uint3x4 value) => value.c0;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator long3x4(uint3x4 self) => new(self.c0, self.c1, self.c2, self.c3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator long3x4a(uint3x4 self) => new(self.c0, self.c1, self.c2, self.c3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator ulong3x4(uint3x4 self) => new(self.c0, self.c1, self.c2, self.c3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator ulong3x4a(uint3x4 self) => new(self.c0, self.c1, self.c2, self.c3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator float3x4(uint3x4 self) => new(self.c0, self.c1, self.c2, self.c3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator float3x4a(uint3x4 self) => new(self.c0, self.c1, self.c2, self.c3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator double3x4(uint3x4 self) => new(self.c0, self.c1, self.c2, self.c3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator double3x4a(uint3x4 self) => new(self.c0, self.c1, self.c2, self.c3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator decimal3x4(uint3x4 self) => new(self.c0, self.c1, self.c2, self.c3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator decimal3x4a(uint3x4 self) => new(self.c0, self.c1, self.c2, self.c3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static explicit operator int3x4(uint3x4 self) => new((int3)self.c0, (int3)self.c1, (int3)self.c2, (int3)self.c3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static explicit operator int3x4a(uint3x4 self) => new((int3a)self.c0, (int3a)self.c1, (int3a)self.c2, (int3a)self.c3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static explicit operator Half3x4(uint3x4 self) => new((Half3)self.c0, (Half3)self.c1, (Half3)self.c2, (Half3)self.c3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static explicit operator Half3x4a(uint3x4 self) => new((Half3a)self.c0, (Half3a)self.c1, (Half3a)self.c2, (Half3a)self.c3);

    #endregion

    //////////////////////////////////////////////////////////////////////////////////////////////////// Equals

    #region Equals

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator ==(uint3x4 left, uint3x4 right) 
        => left.c0 == right.c0 && left.c1 == right.c1 && left.c2 == right.c2 && left.c3 == right.c3;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator !=(uint3x4 left, uint3x4 right) 
        => left.c0 != right.c0 || left.c1 != right.c1 || left.c2 != right.c2 || left.c3 != right.c3;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool Equals(uint3x4 other) 
        => this == other;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override bool Equals(object? o) 
        => o is uint3x4 other && Equals(other);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override int GetHashCode() 
        => HashCode.Combine(this.c0, this.c1, this.c2, this.c3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public int3x4 Hash() 
        => new(this.c0.GetHashCode(), this.c1.GetHashCode(), this.c2.GetHashCode(), this.c3.GetHashCode());

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    static bool3x4 IEqualityOperators<uint3x4, uint3x4, bool3x4>.operator ==(uint3x4 left, uint3x4 right) 
        => new(left.c0 == right.c0, left.c1 == right.c1, left.c2 == right.c2, left.c3 == right.c3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    static bool3x4 IEqualityOperators<uint3x4, uint3x4, bool3x4>.operator !=(uint3x4 left, uint3x4 right) 
        => new(left.c0 != right.c0, left.c1 != right.c1, left.c2 != right.c2, left.c3 != right.c3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool3x4 VEq(uint3x4 other) 
        => new(this.c0 == other.c0, this.c1 == other.c1, this.c2 == other.c2, this.c3 == other.c3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool3x4 VNe(uint3x4 other) 
        => new(this.c0 != other.c0, this.c1 != other.c1, this.c2 != other.c2, this.c3 != other.c3);



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool3x4 operator >(uint3x4 left, uint3x4 right) => new(left.c0 > right.c0, left.c1 > right.c1, left.c2 > right.c2, left.c3 > right.c3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool3x4 operator <(uint3x4 left, uint3x4 right) => new(left.c0 < right.c0, left.c1 < right.c1, left.c2 < right.c2, left.c3 < right.c3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool3x4 operator >=(uint3x4 left, uint3x4 right) => new(left.c0 >= right.c0, left.c1 >= right.c1, left.c2 >= right.c2, left.c3 >= right.c3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool3x4 operator <=(uint3x4 left, uint3x4 right) => new(left.c0 <= right.c0, left.c1 <= right.c1, left.c2 <= right.c2, left.c3 <= right.c3);





    #endregion


    //////////////////////////////////////////////////////////////////////////////////////////////////// Arithmetic

    #region Arithmetic

    public static uint3x4 AdditiveIdentity 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(0u);
    }

    public static uint3x4 MultiplicativeIdentity 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(1u);
    }


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3x4 operator +(uint3x4 left, uint3x4 right) 
        => new(left.c0 + right.c0, left.c1 + right.c1, left.c2 + right.c2, left.c3 + right.c3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3x4 operator -(uint3x4 left, uint3x4 right) 
        => new(left.c0 - right.c0, left.c1 - right.c1, left.c2 - right.c2, left.c3 - right.c3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3x4 operator *(uint3x4 left, uint3x4 right) 
        => new(left.c0 * right.c0, left.c1 * right.c1, left.c2 * right.c2, left.c3 * right.c3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3x4 operator /(uint3x4 left, uint3x4 right) 
        => new(left.c0 / right.c0, left.c1 / right.c1, left.c2 / right.c2, left.c3 / right.c3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3x4 operator %(uint3x4 left, uint3x4 right) 
        => new(left.c0 % right.c0, left.c1 % right.c1, left.c2 % right.c2, left.c3 % right.c3);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3x4 operator +(uint3x4 left, uint3 right) => new(left.c0 + right, left.c1 + right, left.c2 + right, left.c3 + right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3x4 operator -(uint3x4 left, uint3 right) => new(left.c0 - right, left.c1 - right, left.c2 - right, left.c3 - right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3x4 operator *(uint3x4 left, uint3 right) => new(left.c0 * right, left.c1 * right, left.c2 * right, left.c3 * right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3x4 operator /(uint3x4 left, uint3 right) => new(left.c0 / right, left.c1 / right, left.c2 / right, left.c3 / right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3x4 operator %(uint3x4 left, uint3 right) => new(left.c0 % right, left.c1 % right, left.c2 % right, left.c3 % right);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3x4 operator +(uint3 left, uint3x4 right) => new(left + right.c0, left + right.c1, left + right.c2, left + right.c3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3x4 operator -(uint3 left, uint3x4 right) => new(left - right.c0, left - right.c1, left - right.c2, left - right.c3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3x4 operator *(uint3 left, uint3x4 right) => new(left * right.c0, left * right.c1, left * right.c2, left * right.c3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3x4 operator /(uint3 left, uint3x4 right) => new(left / right.c0, left / right.c1, left / right.c2, left / right.c3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3x4 operator %(uint3 left, uint3x4 right) => new(left % right.c0, left % right.c1, left % right.c2, left % right.c3);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3x4 operator +(uint3x4 left, uint right) => new(left.c0 + right, left.c1 + right, left.c2 + right, left.c3 + right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3x4 operator -(uint3x4 left, uint right) => new(left.c0 - right, left.c1 - right, left.c2 - right, left.c3 - right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3x4 operator *(uint3x4 left, uint right) => new(left.c0 * right, left.c1 * right, left.c2 * right, left.c3 * right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3x4 operator /(uint3x4 left, uint right) => new(left.c0 / right, left.c1 / right, left.c2 / right, left.c3 / right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3x4 operator %(uint3x4 left, uint right) => new(left.c0 % right, left.c1 % right, left.c2 % right, left.c3 % right);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3x4 operator +(uint left, uint3x4 right) => new(left + right.c0, left + right.c1, left + right.c2, left + right.c3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3x4 operator -(uint left, uint3x4 right) => new(left - right.c0, left - right.c1, left - right.c2, left - right.c3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3x4 operator *(uint left, uint3x4 right) => new(left * right.c0, left * right.c1, left * right.c2, left * right.c3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3x4 operator /(uint left, uint3x4 right) => new(left / right.c0, left / right.c1, left / right.c2, left / right.c3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3x4 operator %(uint left, uint3x4 right) => new(left % right.c0, left % right.c1, left % right.c2, left % right.c3);



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3x4 operator +(uint3x4 self) => new(+self.c0, +self.c1, +self.c2, +self.c3);

    #endregion

    //////////////////////////////////////////////////////////////////////////////////////////////////// ToString

    #region ToString

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override string ToString() => $"uint3x4({this.c0}, {this.c1}, {this.c2}, {this.c3})";

    #endregion

    //////////////////////////////////////////////////////////////////////////////////////////////////// Methods

    #region Methods



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3x4 transpose(uint3x4 v) => new(
        v.c0.x, v.c0.y, v.c0.z,
        v.c1.x, v.c1.y, v.c1.z,
        v.c2.x, v.c2.y, v.c2.z,
        v.c3.x, v.c3.y, v.c3.z
    );

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public readonly uint3x4 transpose() => transpose(this);

    #endregion
}

public static unsafe partial class vectors
{


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3x4 uint3x4(uint3 c0, uint3 c1, uint3 c2, uint3 c3) => new(c0, c1, c2, c3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3x4 uint3x4(uint m00, uint m10, uint m20, uint m01, uint m11, uint m21, uint m02, uint m12, uint m22, uint m03, uint m13, uint m23) 
        => new(m00, m10, m20, m01, m11, m21, m02, m12, m22, m03, m13, m23);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3x4 uint3x4(uint value) => new(value);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3x4 uint3x4(uint3 value) => new(value);


} // vectors

public static unsafe partial class math
{

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint4 mul(uint3 a, uint3x4 b) => new(dot(a, b.c0), dot(a, b.c1), dot(a, b.c2), dot(a, b.c3));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3 mul(uint3x4 a, uint4 b) => a.c0 * b.x + a.c1 * b.y + a.c2 * b.z + a.c3 * b.w;


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3x2 mul(uint3x4 a, uint4x2 b) => new(
        a.c0 * b.c0.x + a.c1 * b.c0.y + a.c2 * b.c0.z + a.c3 * b.c0.w,
        a.c0 * b.c1.x + a.c1 * b.c1.y + a.c2 * b.c1.z + a.c3 * b.c1.w
    );

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3x3 mul(uint3x4 a, uint4x3 b) => new(
        a.c0 * b.c0.x + a.c1 * b.c0.y + a.c2 * b.c0.z + a.c3 * b.c0.w,
        a.c0 * b.c1.x + a.c1 * b.c1.y + a.c2 * b.c1.z + a.c3 * b.c1.w,
        a.c0 * b.c2.x + a.c1 * b.c2.y + a.c2 * b.c2.z + a.c3 * b.c2.w
    );

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3x4 mul(uint3x4 a, uint4x4 b) => new(
        a.c0 * b.c0.x + a.c1 * b.c0.y + a.c2 * b.c0.z + a.c3 * b.c0.w,
        a.c0 * b.c1.x + a.c1 * b.c1.y + a.c2 * b.c1.z + a.c3 * b.c1.w,
        a.c0 * b.c2.x + a.c1 * b.c2.y + a.c2 * b.c2.z + a.c3 * b.c2.w,
        a.c0 * b.c3.x + a.c1 * b.c3.y + a.c2 * b.c3.z + a.c3 * b.c3.w
    );


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3x4 min(uint3x4 x, uint3x4 y) => new(min(x.c0, y.c0), min(x.c1, y.c1), min(x.c2, y.c2), min(x.c3, y.c3));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3x4 max(uint3x4 x, uint3x4 y) => new(max(x.c0, y.c0), max(x.c1, y.c1), max(x.c2, y.c2), max(x.c3, y.c3));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3x4 min(uint3x4 x, uint3x4 y, uint3x4 z) => new(min(x.c0, y.c0, z.c0), min(x.c1, y.c1, z.c1), min(x.c2, y.c2, z.c2), min(x.c3, y.c3, z.c3));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3x4 max(uint3x4 x, uint3x4 y, uint3x4 z) => new(max(x.c0, y.c0, z.c0), max(x.c1, y.c1, z.c1), max(x.c2, y.c2, z.c2), max(x.c3, y.c3, z.c3));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3x4 abs(uint3x4 x) => new(abs(x.c0), abs(x.c1), abs(x.c2), abs(x.c3));



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3 csum(uint3x4 x) => x.c0 + x.c1 + x.c2 + x.c3;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3 rsum(uint3x4 x) => new(x.c0.x + x.c1.x + x.c2.x + x.c3.x, x.c0.y + x.c1.y + x.c2.y + x.c3.y, x.c0.z + x.c1.z + x.c2.z + x.c3.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint msum(uint3x4 x) => csum(csum(x));



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int3x4 pop_cnt(uint3x4 x) => new(pop_cnt(x.c0), pop_cnt(x.c1), pop_cnt(x.c2), pop_cnt(x.c3));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int count_bits(uint3x4 x) => msum(pop_cnt(x));

} // class math

namespace Json
{

public class Uint3x4JsonConverter : JsonConverter<uint3x4>
{
    private static readonly Type v_type = typeof(uint3);

    public override uint3x4 Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        Unsafe.SkipInit(out uint3x4 result);
        if (reader.TokenType is not JsonTokenType.StartArray) throw new JsonException();
        var conv = (JsonConverter<uint3>)options.GetConverter(v_type);
        reader.Read();
        result.c0 = conv.Read(ref reader, v_type, options);
        reader.Read();
        result.c1 = conv.Read(ref reader, v_type, options);
        reader.Read();
        result.c2 = conv.Read(ref reader, v_type, options);
        reader.Read();
        result.c3 = conv.Read(ref reader, v_type, options);
        reader.Read();
        if (reader.TokenType is not JsonTokenType.EndArray) throw new JsonException();
        return result;
    }

    public override void Write(Utf8JsonWriter writer, uint3x4 value, JsonSerializerOptions options)
    {
        writer.WriteStartArray();
        var conv = (JsonConverter<uint3>)options.GetConverter(v_type);
        conv.Write(writer, value.c0, options);
        conv.Write(writer, value.c1, options);
        conv.Write(writer, value.c2, options);
        conv.Write(writer, value.c3, options);
        writer.WriteEndArray();
    }
} // class JsonConverter

} // namespace Json

} // namespace CCluster.Mathematics
