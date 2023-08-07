using System;
using System.Numerics;
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.X86;
using System.Runtime.Intrinsics.Arm;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

#nullable enable
#pragma warning disable CS8981

namespace CCluster.Mathematics;

[Serializable]
[StructLayout(LayoutKind.Explicit, Size = 2)]
public unsafe partial struct bool2a : 
    IEquatable<bool2a>, IEqualityOperators<bool2a, bool2a, bool>, IEqualityOperators<bool2a, bool2a, bool2>,

    IVector, IVector2, IVector<bool>, IVector2<bool>
{

    [FieldOffset(0)]
    public bool x;

    [FieldOffset(1)]
    public bool y;

    [FieldOffset(0)]
    public bool r;

    [FieldOffset(1)]
    public bool g;


    public static int ByteSize 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => 2;
    }

    public static int BitSize 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => 16;
    }

    public static bool2a Zero
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new bool2a(false);
    }

    public static bool2a One
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new bool2a(true);
    }


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool2a(bool value) : this(value, value) { }


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool2a(bool x, bool y)
    {

        this.x = x;

        this.y = y;

    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator bool2a(bool value) => new bool2a(value);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool Equals(bool2a other) => this.x == other.x && this.y == other.y;


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override bool Equals(object? o) => o is bool2a other && Equals(other);



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator ==(bool2a left, bool2a right) => left.x == right.x && left.y == right.y;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator !=(bool2a left, bool2a right) => left.x != right.x || left.y != right.y;



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override int GetHashCode() => HashCode.Combine(this.x, this.y);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public int2 Hash() => new int2(this.x.GetHashCode(), this.y.GetHashCode());

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    static bool2 IEqualityOperators<bool2a, bool2a, bool2>.operator ==(bool2a left, bool2a right) => new bool2(left.x == right.x, left.y == right.y);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    static bool2 IEqualityOperators<bool2a, bool2a, bool2>.operator !=(bool2a left, bool2a right) => new bool2(left.x != right.x, left.y != right.y);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool2 VEq(bool2a other) => new bool2(this.x == other.x, this.y == other.y);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool2 VNe(bool2a other) => new bool2(this.x != other.x, this.y != other.y);





    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override string ToString() => $"bool2a({this.x}, {this.y})";

}

public static unsafe partial class math
{

















}
