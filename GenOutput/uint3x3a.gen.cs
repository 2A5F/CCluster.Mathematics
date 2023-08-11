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

/// <summary>A 3x3 matrix of uint</summary>
[Serializable]
[JsonConverter(typeof(Uint3x3AJsonConverter))]
[StructLayout(LayoutKind.Explicit, Size = 36, Pack = 4)]
public unsafe partial struct uint3x3a :
    IEquatable<uint3x3a>, IEqualityOperators<uint3x3a, uint3x3a, bool>, IEqualityOperators<uint3x3a, uint3x3a, bool3x3a>,

    IAdditionOperators<uint3x3a, uint3x3a, uint3x3a>, IAdditiveIdentity<uint3x3a, uint3x3a>, IUnaryPlusOperators<uint3x3a, uint3x3a>,
    ISubtractionOperators<uint3x3a, uint3x3a, uint3x3a>, 
    IMultiplyOperators<uint3x3a, uint3x3a, uint3x3a>, IMultiplicativeIdentity<uint3x3a, uint3x3a>,
    IDivisionOperators<uint3x3a, uint3x3a, uint3x3a>,
    IModulusOperators<uint3x3a, uint3x3a, uint3x3a>,

    IMatrix3x3<uint>, IMatrixSelf<uint3x3a>, IMatrixIdentity<uint3x3a>
{
    //////////////////////////////////////////////////////////////////////////////////////////////////// Fields

    #region Fields

    /// <summary>Column 0 of the matrix</summary>
    [FieldOffset(0)]
    public uint3a c0;

    /// <summary>Column 1 of the matrix</summary>
    [FieldOffset(12)]
    public uint3a c1;

    /// <summary>Column 2 of the matrix</summary>
    [FieldOffset(24)]
    public uint3a c2;


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
    [FieldOffset(12)]
    public uint m01;

    /// <summary>Row 1 column 1 of the matrix</summary>
    [FieldOffset(16)]
    public uint m11;

    /// <summary>Row 2 column 1 of the matrix</summary>
    [FieldOffset(20)]
    public uint m21;

    /// <summary>Row 0 column 2 of the matrix</summary>
    [FieldOffset(24)]
    public uint m02;

    /// <summary>Row 1 column 2 of the matrix</summary>
    [FieldOffset(28)]
    public uint m12;

    /// <summary>Row 2 column 2 of the matrix</summary>
    [FieldOffset(32)]
    public uint m22;

    #endregion

    //////////////////////////////////////////////////////////////////////////////////////////////////// Constants

    #region Constants

    public static readonly uint3x3a identity = new uint3x3a(
        1u, 0u, 0u,
        0u, 1u, 0u, 
        0u, 0u, 1u
    );

    public static readonly uint3x3a zero = new(0u);

    public static readonly uint3x3a one = new(1u);

    static uint3x3a IMatrixSelf<uint3x3a>.Zero 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => zero;
    }

    static uint3x3a IMatrixSelf<uint3x3a>.One 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => one;
    }

    static uint3x3a IMatrixIdentity<uint3x3a>.Identity 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => identity;
    }

    #endregion

    //////////////////////////////////////////////////////////////////////////////////////////////////// Ctor

    #region Ctor


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public uint3x3a(uint3a c0, uint3a c1, uint3a c2)
    {
        Unsafe.SkipInit(out this);
        this.c0 = c0;
        this.c1 = c1;
        this.c2 = c2;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public uint3x3a(uint m00, uint m10, uint m20, uint m01, uint m11, uint m21, uint m02, uint m12, uint m22)
    {
        Unsafe.SkipInit(out this);
        this.c0 = new(m00, m10, m20);
        this.c1 = new(m01, m11, m21);
        this.c2 = new(m02, m12, m22);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3x3a RowMajor(uint m00, uint m01, uint m02, uint m10, uint m11, uint m12, uint m20, uint m21, uint m22) 
        => new(m00, m10, m20, m01, m11, m21, m02, m12, m22);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public uint3x3a(uint value)
    {
        Unsafe.SkipInit(out this);
        this.c0 = new(value);
        this.c1 = new(value);
        this.c2 = new(value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public uint3x3a(uint3a value)
    {
        Unsafe.SkipInit(out this);
        this.c0 = value;
        this.c1 = value;
        this.c2 = value;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public uint3x3a(uint4x4 m)
    {
        this.c0 = m.c0.xyz;
        this.c1 = m.c1.xyz;
        this.c2 = m.c2.xyz;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator uint3x3a(uint value) => new(value);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator uint3x3a(uint3a value) => new(value);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static explicit operator uint(uint3x3a value) => value.m00;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static explicit operator uint3a(uint3x3a value) => value.c0;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator uint3x3a(uint3x3 value) => new(value.c0, value.c1, value.c2);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator uint3x3(uint3x3a value) => new(value.c0, value.c1, value.c2);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator long3x3(uint3x3a self) => new(self.c0, self.c1, self.c2);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator long3x3a(uint3x3a self) => new(self.c0, self.c1, self.c2);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator ulong3x3(uint3x3a self) => new(self.c0, self.c1, self.c2);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator ulong3x3a(uint3x3a self) => new(self.c0, self.c1, self.c2);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator float3x3(uint3x3a self) => new(self.c0, self.c1, self.c2);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator float3x3a(uint3x3a self) => new(self.c0, self.c1, self.c2);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator double3x3(uint3x3a self) => new(self.c0, self.c1, self.c2);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator double3x3a(uint3x3a self) => new(self.c0, self.c1, self.c2);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator decimal3x3(uint3x3a self) => new(self.c0, self.c1, self.c2);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator decimal3x3a(uint3x3a self) => new(self.c0, self.c1, self.c2);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static explicit operator int3x3(uint3x3a self) => new((int3)self.c0, (int3)self.c1, (int3)self.c2);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static explicit operator int3x3a(uint3x3a self) => new((int3a)self.c0, (int3a)self.c1, (int3a)self.c2);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static explicit operator Half3x3(uint3x3a self) => new((Half3)self.c0, (Half3)self.c1, (Half3)self.c2);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static explicit operator Half3x3a(uint3x3a self) => new((Half3a)self.c0, (Half3a)self.c1, (Half3a)self.c2);

    #endregion

    //////////////////////////////////////////////////////////////////////////////////////////////////// Equals

    #region Equals

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator ==(uint3x3a left, uint3x3a right) 
        => left.c0 == right.c0 && left.c1 == right.c1 && left.c2 == right.c2;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator !=(uint3x3a left, uint3x3a right) 
        => left.c0 != right.c0 || left.c1 != right.c1 || left.c2 != right.c2;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool Equals(uint3x3a other) 
        => this == other;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override bool Equals(object? o) 
        => o is uint3x3a other && Equals(other);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override int GetHashCode() 
        => HashCode.Combine(this.c0, this.c1, this.c2);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public int3x3a Hash() 
        => new(this.c0.GetHashCode(), this.c1.GetHashCode(), this.c2.GetHashCode());

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    static bool3x3a IEqualityOperators<uint3x3a, uint3x3a, bool3x3a>.operator ==(uint3x3a left, uint3x3a right) 
        => new(left.c0 == right.c0, left.c1 == right.c1, left.c2 == right.c2);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    static bool3x3a IEqualityOperators<uint3x3a, uint3x3a, bool3x3a>.operator !=(uint3x3a left, uint3x3a right) 
        => new(left.c0 != right.c0, left.c1 != right.c1, left.c2 != right.c2);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool3x3a VEq(uint3x3a other) 
        => new(this.c0 == other.c0, this.c1 == other.c1, this.c2 == other.c2);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool3x3a VNe(uint3x3a other) 
        => new(this.c0 != other.c0, this.c1 != other.c1, this.c2 != other.c2);



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool3x3a operator >(uint3x3a left, uint3x3a right) => new(left.c0 > right.c0, left.c1 > right.c1, left.c2 > right.c2);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool3x3a operator <(uint3x3a left, uint3x3a right) => new(left.c0 < right.c0, left.c1 < right.c1, left.c2 < right.c2);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool3x3a operator >=(uint3x3a left, uint3x3a right) => new(left.c0 >= right.c0, left.c1 >= right.c1, left.c2 >= right.c2);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool3x3a operator <=(uint3x3a left, uint3x3a right) => new(left.c0 <= right.c0, left.c1 <= right.c1, left.c2 <= right.c2);





    #endregion


    //////////////////////////////////////////////////////////////////////////////////////////////////// Arithmetic

    #region Arithmetic

    public static uint3x3a AdditiveIdentity 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(0u);
    }

    public static uint3x3a MultiplicativeIdentity 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(1u);
    }


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3x3a operator +(uint3x3a left, uint3x3a right) 
        => new(left.c0 + right.c0, left.c1 + right.c1, left.c2 + right.c2);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3x3a operator -(uint3x3a left, uint3x3a right) 
        => new(left.c0 - right.c0, left.c1 - right.c1, left.c2 - right.c2);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3x3a operator *(uint3x3a left, uint3x3a right) 
        => new(left.c0 * right.c0, left.c1 * right.c1, left.c2 * right.c2);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3x3a operator /(uint3x3a left, uint3x3a right) 
        => new(left.c0 / right.c0, left.c1 / right.c1, left.c2 / right.c2);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3x3a operator %(uint3x3a left, uint3x3a right) 
        => new(left.c0 % right.c0, left.c1 % right.c1, left.c2 % right.c2);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3x3a operator +(uint3x3a left, uint3a right) => new(left.c0 + right, left.c1 + right, left.c2 + right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3x3a operator -(uint3x3a left, uint3a right) => new(left.c0 - right, left.c1 - right, left.c2 - right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3x3a operator *(uint3x3a left, uint3a right) => new(left.c0 * right, left.c1 * right, left.c2 * right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3x3a operator /(uint3x3a left, uint3a right) => new(left.c0 / right, left.c1 / right, left.c2 / right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3x3a operator %(uint3x3a left, uint3a right) => new(left.c0 % right, left.c1 % right, left.c2 % right);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3x3a operator +(uint3a left, uint3x3a right) => new(left + right.c0, left + right.c1, left + right.c2);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3x3a operator -(uint3a left, uint3x3a right) => new(left - right.c0, left - right.c1, left - right.c2);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3x3a operator *(uint3a left, uint3x3a right) => new(left * right.c0, left * right.c1, left * right.c2);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3x3a operator /(uint3a left, uint3x3a right) => new(left / right.c0, left / right.c1, left / right.c2);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3x3a operator %(uint3a left, uint3x3a right) => new(left % right.c0, left % right.c1, left % right.c2);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3x3a operator +(uint3x3a left, uint right) => new(left.c0 + right, left.c1 + right, left.c2 + right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3x3a operator -(uint3x3a left, uint right) => new(left.c0 - right, left.c1 - right, left.c2 - right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3x3a operator *(uint3x3a left, uint right) => new(left.c0 * right, left.c1 * right, left.c2 * right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3x3a operator /(uint3x3a left, uint right) => new(left.c0 / right, left.c1 / right, left.c2 / right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3x3a operator %(uint3x3a left, uint right) => new(left.c0 % right, left.c1 % right, left.c2 % right);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3x3a operator +(uint left, uint3x3a right) => new(left + right.c0, left + right.c1, left + right.c2);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3x3a operator -(uint left, uint3x3a right) => new(left - right.c0, left - right.c1, left - right.c2);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3x3a operator *(uint left, uint3x3a right) => new(left * right.c0, left * right.c1, left * right.c2);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3x3a operator /(uint left, uint3x3a right) => new(left / right.c0, left / right.c1, left / right.c2);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3x3a operator %(uint left, uint3x3a right) => new(left % right.c0, left % right.c1, left % right.c2);



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3x3a operator +(uint3x3a self) => new(+self.c0, +self.c1, +self.c2);

    #endregion

    //////////////////////////////////////////////////////////////////////////////////////////////////// ToString

    #region ToString

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override string ToString() => $"uint3x3a({this.c0}, {this.c1}, {this.c2})";

    #endregion

    //////////////////////////////////////////////////////////////////////////////////////////////////// Methods

    #region Methods



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3x3a transpose(uint3x3a v) => new(
        v.c0.x, v.c0.y, v.c0.z,
        v.c1.x, v.c1.y, v.c1.z,
        v.c2.x, v.c2.y, v.c2.z
    );

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public readonly uint3x3a transpose() => transpose(this);

    #endregion
}

public static unsafe partial class vectors
{


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3x3a uint3x3a(uint3a c0, uint3a c1, uint3a c2) => new(c0, c1, c2);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3x3a uint3x3a(uint m00, uint m10, uint m20, uint m01, uint m11, uint m21, uint m02, uint m12, uint m22) 
        => new(m00, m10, m20, m01, m11, m21, m02, m12, m22);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3x3a uint3x3a(uint value) => new(value);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3x3a uint3x3a(uint3a value) => new(value);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3x3a uint3x3a(uint4x4 m) => new(m);


} // vectors

public static unsafe partial class math
{

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3a mul(uint3a a, uint3x3a b) => new(dot(a, b.c0), dot(a, b.c1), dot(a, b.c2));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3a mul(uint3x3a a, uint3a b) => a.c0 * b.x + a.c1 * b.y + a.c2 * b.z;


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3x2a mul(uint3x3a a, uint3x2a b) => new(
        a.c0 * b.c0.x + a.c1 * b.c0.y + a.c2 * b.c0.z,
        a.c0 * b.c1.x + a.c1 * b.c1.y + a.c2 * b.c1.z
    );

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3x3a mul(uint3x3a a, uint3x3a b) => new(
        a.c0 * b.c0.x + a.c1 * b.c0.y + a.c2 * b.c0.z,
        a.c0 * b.c1.x + a.c1 * b.c1.y + a.c2 * b.c1.z,
        a.c0 * b.c2.x + a.c1 * b.c2.y + a.c2 * b.c2.z
    );

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3x4a mul(uint3x3a a, uint3x4a b) => new(
        a.c0 * b.c0.x + a.c1 * b.c0.y + a.c2 * b.c0.z,
        a.c0 * b.c1.x + a.c1 * b.c1.y + a.c2 * b.c1.z,
        a.c0 * b.c2.x + a.c1 * b.c2.y + a.c2 * b.c2.z,
        a.c0 * b.c3.x + a.c1 * b.c3.y + a.c2 * b.c3.z
    );


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3x3a min(uint3x3a x, uint3x3a y) => new(min(x.c0, y.c0), min(x.c1, y.c1), min(x.c2, y.c2));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3x3a max(uint3x3a x, uint3x3a y) => new(max(x.c0, y.c0), max(x.c1, y.c1), max(x.c2, y.c2));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3x3a min(uint3x3a x, uint3x3a y, uint3x3a z) => new(min(x.c0, y.c0, z.c0), min(x.c1, y.c1, z.c1), min(x.c2, y.c2, z.c2));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3x3a max(uint3x3a x, uint3x3a y, uint3x3a z) => new(max(x.c0, y.c0, z.c0), max(x.c1, y.c1, z.c1), max(x.c2, y.c2, z.c2));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3x3a abs(uint3x3a x) => new(abs(x.c0), abs(x.c1), abs(x.c2));



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3a csum(uint3x3a x) => x.c0 + x.c1 + x.c2;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint3a rsum(uint3x3a x) => new(x.c0.x + x.c1.x + x.c2.x, x.c0.y + x.c1.y + x.c2.y, x.c0.z + x.c1.z + x.c2.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint msum(uint3x3a x) => csum(csum(x));



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int3x3a pop_cnt(uint3x3a x) => new(pop_cnt(x.c0), pop_cnt(x.c1), pop_cnt(x.c2));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int count_bits(uint3x3a x) => msum(pop_cnt(x));

} // class math

namespace Json
{

public class Uint3x3AJsonConverter : JsonConverter<uint3x3a>
{
    private static readonly Type v_type = typeof(uint3a);

    public override uint3x3a Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        Unsafe.SkipInit(out uint3x3a result);
        if (reader.TokenType is not JsonTokenType.StartArray) throw new JsonException();
        var conv = (JsonConverter<uint3a>)options.GetConverter(v_type);
        reader.Read();
        result.c0 = conv.Read(ref reader, v_type, options);
        reader.Read();
        result.c1 = conv.Read(ref reader, v_type, options);
        reader.Read();
        result.c2 = conv.Read(ref reader, v_type, options);
        reader.Read();
        if (reader.TokenType is not JsonTokenType.EndArray) throw new JsonException();
        return result;
    }

    public override void Write(Utf8JsonWriter writer, uint3x3a value, JsonSerializerOptions options)
    {
        writer.WriteStartArray();
        var conv = (JsonConverter<uint3a>)options.GetConverter(v_type);
        conv.Write(writer, value.c0, options);
        conv.Write(writer, value.c1, options);
        conv.Write(writer, value.c2, options);
        writer.WriteEndArray();
    }
} // class JsonConverter

} // namespace Json

} // namespace CCluster.Mathematics
