using System;
using System.Numerics;
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.X86;
using System.Runtime.Intrinsics.Arm;
using System.Runtime.CompilerServices;

#nullable enable
#pragma warning disable CS8981

namespace CCluster.Mathematics;

public partial struct double4 
{

    public double2 xx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(this.x, this.x);

        }
    }
    public double2 xy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(this.x, this.y);

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.x = value.x; this.y = value.y; 
        }
    }
    public double2 xz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(this.x, this.z);

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.x = value.x; this.z = value.y; 
        }
    }
    public double2 xw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(this.x, this.w);

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.x = value.x; this.w = value.y; 
        }
    }
    public double2 yx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(this.y, this.x);

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.y = value.x; this.x = value.y; 
        }
    }
    public double2 yy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(this.y, this.y);

        }
    }
    public double2 yz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(this.y, this.z);

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.y = value.x; this.z = value.y; 
        }
    }
    public double2 yw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(this.y, this.w);

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.y = value.x; this.w = value.y; 
        }
    }
    public double2 zx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(this.z, this.x);

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.z = value.x; this.x = value.y; 
        }
    }
    public double2 zy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(this.z, this.y);

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.z = value.x; this.y = value.y; 
        }
    }
    public double2 zz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(this.z, this.z);

        }
    }
    public double2 zw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(this.z, this.w);

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.z = value.x; this.w = value.y; 
        }
    }
    public double2 wx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(this.w, this.x);

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.w = value.x; this.x = value.y; 
        }
    }
    public double2 wy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(this.w, this.y);

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.w = value.x; this.y = value.y; 
        }
    }
    public double2 wz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(this.w, this.z);

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.w = value.x; this.z = value.y; 
        }
    }
    public double2 ww
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(this.w, this.w);

        }
    }
    public double2 rr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(this.r, this.r);

        }
    }
    public double2 rg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(this.r, this.g);

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.r = value.x; this.g = value.y; 
        }
    }
    public double2 rb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(this.r, this.b);

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.r = value.x; this.b = value.y; 
        }
    }
    public double2 ra
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(this.r, this.a);

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.r = value.x; this.a = value.y; 
        }
    }
    public double2 gr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(this.g, this.r);

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.g = value.x; this.r = value.y; 
        }
    }
    public double2 gg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(this.g, this.g);

        }
    }
    public double2 gb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(this.g, this.b);

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.g = value.x; this.b = value.y; 
        }
    }
    public double2 ga
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(this.g, this.a);

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.g = value.x; this.a = value.y; 
        }
    }
    public double2 br
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(this.b, this.r);

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.b = value.x; this.r = value.y; 
        }
    }
    public double2 bg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(this.b, this.g);

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.b = value.x; this.g = value.y; 
        }
    }
    public double2 bb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(this.b, this.b);

        }
    }
    public double2 ba
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(this.b, this.a);

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.b = value.x; this.a = value.y; 
        }
    }
    public double2 ar
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(this.a, this.r);

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.a = value.x; this.r = value.y; 
        }
    }
    public double2 ag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(this.a, this.g);

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.a = value.x; this.g = value.y; 
        }
    }
    public double2 ab
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(this.a, this.b);

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.a = value.x; this.b = value.y; 
        }
    }
    public double2 aa
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(this.a, this.a);

        }
    }
    public double3 xxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 0L, 0L, 0L)) & math.v3_iz_double256);

        }
    }
    public double3 xxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 0L, 1L, 0L)) & math.v3_iz_double256);

        }
    }
    public double3 xxz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 0L, 2L, 0L)) & math.v3_iz_double256);

        }
    }
    public double3 xxw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 0L, 3L, 0L)) & math.v3_iz_double256);

        }
    }
    public double3 xyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 1L, 0L, 0L)) & math.v3_iz_double256);

        }
    }
    public double3 xyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 1L, 1L, 0L)) & math.v3_iz_double256);

        }
    }
    public double3 xyz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 1L, 2L, 0L)) & math.v3_iz_double256);

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.x = value.x; this.y = value.y; this.z = value.z; 
        }
    }
    public double3 xyw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 1L, 3L, 0L)) & math.v3_iz_double256);

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.x = value.x; this.y = value.y; this.w = value.z; 
        }
    }
    public double3 xzx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 2L, 0L, 0L)) & math.v3_iz_double256);

        }
    }
    public double3 xzy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 2L, 1L, 0L)) & math.v3_iz_double256);

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.x = value.x; this.z = value.y; this.y = value.z; 
        }
    }
    public double3 xzz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 2L, 2L, 0L)) & math.v3_iz_double256);

        }
    }
    public double3 xzw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 2L, 3L, 0L)) & math.v3_iz_double256);

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.x = value.x; this.z = value.y; this.w = value.z; 
        }
    }
    public double3 xwx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 3L, 0L, 0L)) & math.v3_iz_double256);

        }
    }
    public double3 xwy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 3L, 1L, 0L)) & math.v3_iz_double256);

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.x = value.x; this.w = value.y; this.y = value.z; 
        }
    }
    public double3 xwz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 3L, 2L, 0L)) & math.v3_iz_double256);

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.x = value.x; this.w = value.y; this.z = value.z; 
        }
    }
    public double3 xww
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 3L, 3L, 0L)) & math.v3_iz_double256);

        }
    }
    public double3 yxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 0L, 0L, 0L)) & math.v3_iz_double256);

        }
    }
    public double3 yxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 0L, 1L, 0L)) & math.v3_iz_double256);

        }
    }
    public double3 yxz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 0L, 2L, 0L)) & math.v3_iz_double256);

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.y = value.x; this.x = value.y; this.z = value.z; 
        }
    }
    public double3 yxw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 0L, 3L, 0L)) & math.v3_iz_double256);

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.y = value.x; this.x = value.y; this.w = value.z; 
        }
    }
    public double3 yyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 1L, 0L, 0L)) & math.v3_iz_double256);

        }
    }
    public double3 yyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 1L, 1L, 0L)) & math.v3_iz_double256);

        }
    }
    public double3 yyz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 1L, 2L, 0L)) & math.v3_iz_double256);

        }
    }
    public double3 yyw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 1L, 3L, 0L)) & math.v3_iz_double256);

        }
    }
    public double3 yzx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 2L, 0L, 0L)) & math.v3_iz_double256);

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.y = value.x; this.z = value.y; this.x = value.z; 
        }
    }
    public double3 yzy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 2L, 1L, 0L)) & math.v3_iz_double256);

        }
    }
    public double3 yzz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 2L, 2L, 0L)) & math.v3_iz_double256);

        }
    }
    public double3 yzw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 2L, 3L, 0L)) & math.v3_iz_double256);

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.y = value.x; this.z = value.y; this.w = value.z; 
        }
    }
    public double3 ywx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 3L, 0L, 0L)) & math.v3_iz_double256);

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.y = value.x; this.w = value.y; this.x = value.z; 
        }
    }
    public double3 ywy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 3L, 1L, 0L)) & math.v3_iz_double256);

        }
    }
    public double3 ywz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 3L, 2L, 0L)) & math.v3_iz_double256);

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.y = value.x; this.w = value.y; this.z = value.z; 
        }
    }
    public double3 yww
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 3L, 3L, 0L)) & math.v3_iz_double256);

        }
    }
    public double3 zxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 0L, 0L, 0L)) & math.v3_iz_double256);

        }
    }
    public double3 zxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 0L, 1L, 0L)) & math.v3_iz_double256);

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.z = value.x; this.x = value.y; this.y = value.z; 
        }
    }
    public double3 zxz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 0L, 2L, 0L)) & math.v3_iz_double256);

        }
    }
    public double3 zxw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 0L, 3L, 0L)) & math.v3_iz_double256);

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.z = value.x; this.x = value.y; this.w = value.z; 
        }
    }
    public double3 zyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 1L, 0L, 0L)) & math.v3_iz_double256);

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.z = value.x; this.y = value.y; this.x = value.z; 
        }
    }
    public double3 zyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 1L, 1L, 0L)) & math.v3_iz_double256);

        }
    }
    public double3 zyz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 1L, 2L, 0L)) & math.v3_iz_double256);

        }
    }
    public double3 zyw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 1L, 3L, 0L)) & math.v3_iz_double256);

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.z = value.x; this.y = value.y; this.w = value.z; 
        }
    }
    public double3 zzx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 2L, 0L, 0L)) & math.v3_iz_double256);

        }
    }
    public double3 zzy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 2L, 1L, 0L)) & math.v3_iz_double256);

        }
    }
    public double3 zzz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 2L, 2L, 0L)) & math.v3_iz_double256);

        }
    }
    public double3 zzw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 2L, 3L, 0L)) & math.v3_iz_double256);

        }
    }
    public double3 zwx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 3L, 0L, 0L)) & math.v3_iz_double256);

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.z = value.x; this.w = value.y; this.x = value.z; 
        }
    }
    public double3 zwy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 3L, 1L, 0L)) & math.v3_iz_double256);

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.z = value.x; this.w = value.y; this.y = value.z; 
        }
    }
    public double3 zwz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 3L, 2L, 0L)) & math.v3_iz_double256);

        }
    }
    public double3 zww
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 3L, 3L, 0L)) & math.v3_iz_double256);

        }
    }
    public double3 wxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 0L, 0L, 0L)) & math.v3_iz_double256);

        }
    }
    public double3 wxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 0L, 1L, 0L)) & math.v3_iz_double256);

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.w = value.x; this.x = value.y; this.y = value.z; 
        }
    }
    public double3 wxz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 0L, 2L, 0L)) & math.v3_iz_double256);

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.w = value.x; this.x = value.y; this.z = value.z; 
        }
    }
    public double3 wxw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 0L, 3L, 0L)) & math.v3_iz_double256);

        }
    }
    public double3 wyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 1L, 0L, 0L)) & math.v3_iz_double256);

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.w = value.x; this.y = value.y; this.x = value.z; 
        }
    }
    public double3 wyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 1L, 1L, 0L)) & math.v3_iz_double256);

        }
    }
    public double3 wyz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 1L, 2L, 0L)) & math.v3_iz_double256);

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.w = value.x; this.y = value.y; this.z = value.z; 
        }
    }
    public double3 wyw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 1L, 3L, 0L)) & math.v3_iz_double256);

        }
    }
    public double3 wzx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 2L, 0L, 0L)) & math.v3_iz_double256);

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.w = value.x; this.z = value.y; this.x = value.z; 
        }
    }
    public double3 wzy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 2L, 1L, 0L)) & math.v3_iz_double256);

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.w = value.x; this.z = value.y; this.y = value.z; 
        }
    }
    public double3 wzz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 2L, 2L, 0L)) & math.v3_iz_double256);

        }
    }
    public double3 wzw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 2L, 3L, 0L)) & math.v3_iz_double256);

        }
    }
    public double3 wwx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 3L, 0L, 0L)) & math.v3_iz_double256);

        }
    }
    public double3 wwy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 3L, 1L, 0L)) & math.v3_iz_double256);

        }
    }
    public double3 wwz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 3L, 2L, 0L)) & math.v3_iz_double256);

        }
    }
    public double3 www
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 3L, 3L, 0L)) & math.v3_iz_double256);

        }
    }
    public double3 rrr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 0L, 0L, 0L)) & math.v3_iz_double256);

        }
    }
    public double3 rrg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 0L, 1L, 0L)) & math.v3_iz_double256);

        }
    }
    public double3 rrb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 0L, 2L, 0L)) & math.v3_iz_double256);

        }
    }
    public double3 rra
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 0L, 3L, 0L)) & math.v3_iz_double256);

        }
    }
    public double3 rgr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 1L, 0L, 0L)) & math.v3_iz_double256);

        }
    }
    public double3 rgg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 1L, 1L, 0L)) & math.v3_iz_double256);

        }
    }
    public double3 rgb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 1L, 2L, 0L)) & math.v3_iz_double256);

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.r = value.x; this.g = value.y; this.b = value.z; 
        }
    }
    public double3 rga
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 1L, 3L, 0L)) & math.v3_iz_double256);

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.r = value.x; this.g = value.y; this.a = value.z; 
        }
    }
    public double3 rbr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 2L, 0L, 0L)) & math.v3_iz_double256);

        }
    }
    public double3 rbg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 2L, 1L, 0L)) & math.v3_iz_double256);

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.r = value.x; this.b = value.y; this.g = value.z; 
        }
    }
    public double3 rbb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 2L, 2L, 0L)) & math.v3_iz_double256);

        }
    }
    public double3 rba
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 2L, 3L, 0L)) & math.v3_iz_double256);

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.r = value.x; this.b = value.y; this.a = value.z; 
        }
    }
    public double3 rar
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 3L, 0L, 0L)) & math.v3_iz_double256);

        }
    }
    public double3 rag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 3L, 1L, 0L)) & math.v3_iz_double256);

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.r = value.x; this.a = value.y; this.g = value.z; 
        }
    }
    public double3 rab
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 3L, 2L, 0L)) & math.v3_iz_double256);

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.r = value.x; this.a = value.y; this.b = value.z; 
        }
    }
    public double3 raa
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 3L, 3L, 0L)) & math.v3_iz_double256);

        }
    }
    public double3 grr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 0L, 0L, 0L)) & math.v3_iz_double256);

        }
    }
    public double3 grg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 0L, 1L, 0L)) & math.v3_iz_double256);

        }
    }
    public double3 grb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 0L, 2L, 0L)) & math.v3_iz_double256);

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.g = value.x; this.r = value.y; this.b = value.z; 
        }
    }
    public double3 gra
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 0L, 3L, 0L)) & math.v3_iz_double256);

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.g = value.x; this.r = value.y; this.a = value.z; 
        }
    }
    public double3 ggr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 1L, 0L, 0L)) & math.v3_iz_double256);

        }
    }
    public double3 ggg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 1L, 1L, 0L)) & math.v3_iz_double256);

        }
    }
    public double3 ggb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 1L, 2L, 0L)) & math.v3_iz_double256);

        }
    }
    public double3 gga
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 1L, 3L, 0L)) & math.v3_iz_double256);

        }
    }
    public double3 gbr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 2L, 0L, 0L)) & math.v3_iz_double256);

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.g = value.x; this.b = value.y; this.r = value.z; 
        }
    }
    public double3 gbg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 2L, 1L, 0L)) & math.v3_iz_double256);

        }
    }
    public double3 gbb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 2L, 2L, 0L)) & math.v3_iz_double256);

        }
    }
    public double3 gba
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 2L, 3L, 0L)) & math.v3_iz_double256);

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.g = value.x; this.b = value.y; this.a = value.z; 
        }
    }
    public double3 gar
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 3L, 0L, 0L)) & math.v3_iz_double256);

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.g = value.x; this.a = value.y; this.r = value.z; 
        }
    }
    public double3 gag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 3L, 1L, 0L)) & math.v3_iz_double256);

        }
    }
    public double3 gab
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 3L, 2L, 0L)) & math.v3_iz_double256);

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.g = value.x; this.a = value.y; this.b = value.z; 
        }
    }
    public double3 gaa
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 3L, 3L, 0L)) & math.v3_iz_double256);

        }
    }
    public double3 brr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 0L, 0L, 0L)) & math.v3_iz_double256);

        }
    }
    public double3 brg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 0L, 1L, 0L)) & math.v3_iz_double256);

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.b = value.x; this.r = value.y; this.g = value.z; 
        }
    }
    public double3 brb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 0L, 2L, 0L)) & math.v3_iz_double256);

        }
    }
    public double3 bra
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 0L, 3L, 0L)) & math.v3_iz_double256);

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.b = value.x; this.r = value.y; this.a = value.z; 
        }
    }
    public double3 bgr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 1L, 0L, 0L)) & math.v3_iz_double256);

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.b = value.x; this.g = value.y; this.r = value.z; 
        }
    }
    public double3 bgg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 1L, 1L, 0L)) & math.v3_iz_double256);

        }
    }
    public double3 bgb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 1L, 2L, 0L)) & math.v3_iz_double256);

        }
    }
    public double3 bga
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 1L, 3L, 0L)) & math.v3_iz_double256);

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.b = value.x; this.g = value.y; this.a = value.z; 
        }
    }
    public double3 bbr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 2L, 0L, 0L)) & math.v3_iz_double256);

        }
    }
    public double3 bbg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 2L, 1L, 0L)) & math.v3_iz_double256);

        }
    }
    public double3 bbb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 2L, 2L, 0L)) & math.v3_iz_double256);

        }
    }
    public double3 bba
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 2L, 3L, 0L)) & math.v3_iz_double256);

        }
    }
    public double3 bar
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 3L, 0L, 0L)) & math.v3_iz_double256);

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.b = value.x; this.a = value.y; this.r = value.z; 
        }
    }
    public double3 bag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 3L, 1L, 0L)) & math.v3_iz_double256);

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.b = value.x; this.a = value.y; this.g = value.z; 
        }
    }
    public double3 bab
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 3L, 2L, 0L)) & math.v3_iz_double256);

        }
    }
    public double3 baa
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 3L, 3L, 0L)) & math.v3_iz_double256);

        }
    }
    public double3 arr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 0L, 0L, 0L)) & math.v3_iz_double256);

        }
    }
    public double3 arg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 0L, 1L, 0L)) & math.v3_iz_double256);

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.a = value.x; this.r = value.y; this.g = value.z; 
        }
    }
    public double3 arb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 0L, 2L, 0L)) & math.v3_iz_double256);

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.a = value.x; this.r = value.y; this.b = value.z; 
        }
    }
    public double3 ara
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 0L, 3L, 0L)) & math.v3_iz_double256);

        }
    }
    public double3 agr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 1L, 0L, 0L)) & math.v3_iz_double256);

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.a = value.x; this.g = value.y; this.r = value.z; 
        }
    }
    public double3 agg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 1L, 1L, 0L)) & math.v3_iz_double256);

        }
    }
    public double3 agb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 1L, 2L, 0L)) & math.v3_iz_double256);

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.a = value.x; this.g = value.y; this.b = value.z; 
        }
    }
    public double3 aga
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 1L, 3L, 0L)) & math.v3_iz_double256);

        }
    }
    public double3 abr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 2L, 0L, 0L)) & math.v3_iz_double256);

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.a = value.x; this.b = value.y; this.r = value.z; 
        }
    }
    public double3 abg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 2L, 1L, 0L)) & math.v3_iz_double256);

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.a = value.x; this.b = value.y; this.g = value.z; 
        }
    }
    public double3 abb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 2L, 2L, 0L)) & math.v3_iz_double256);

        }
    }
    public double3 aba
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 2L, 3L, 0L)) & math.v3_iz_double256);

        }
    }
    public double3 aar
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 3L, 0L, 0L)) & math.v3_iz_double256);

        }
    }
    public double3 aag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 3L, 1L, 0L)) & math.v3_iz_double256);

        }
    }
    public double3 aab
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 3L, 2L, 0L)) & math.v3_iz_double256);

        }
    }
    public double3 aaa
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 3L, 3L, 0L)) & math.v3_iz_double256);

        }
    }
    public double4 xxxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 0L, 0L, 0L)));

        }
    }
    public double4 xxxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 0L, 0L, 1L)));

        }
    }
    public double4 xxxz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 0L, 0L, 2L)));

        }
    }
    public double4 xxxw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 0L, 0L, 3L)));

        }
    }
    public double4 xxyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 0L, 1L, 0L)));

        }
    }
    public double4 xxyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 0L, 1L, 1L)));

        }
    }
    public double4 xxyz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 0L, 1L, 2L)));

        }
    }
    public double4 xxyw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 0L, 1L, 3L)));

        }
    }
    public double4 xxzx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 0L, 2L, 0L)));

        }
    }
    public double4 xxzy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 0L, 2L, 1L)));

        }
    }
    public double4 xxzz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 0L, 2L, 2L)));

        }
    }
    public double4 xxzw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 0L, 2L, 3L)));

        }
    }
    public double4 xxwx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 0L, 3L, 0L)));

        }
    }
    public double4 xxwy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 0L, 3L, 1L)));

        }
    }
    public double4 xxwz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 0L, 3L, 2L)));

        }
    }
    public double4 xxww
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 0L, 3L, 3L)));

        }
    }
    public double4 xyxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 1L, 0L, 0L)));

        }
    }
    public double4 xyxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 1L, 0L, 1L)));

        }
    }
    public double4 xyxz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 1L, 0L, 2L)));

        }
    }
    public double4 xyxw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 1L, 0L, 3L)));

        }
    }
    public double4 xyyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 1L, 1L, 0L)));

        }
    }
    public double4 xyyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 1L, 1L, 1L)));

        }
    }
    public double4 xyyz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 1L, 1L, 2L)));

        }
    }
    public double4 xyyw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 1L, 1L, 3L)));

        }
    }
    public double4 xyzx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 1L, 2L, 0L)));

        }
    }
    public double4 xyzy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 1L, 2L, 1L)));

        }
    }
    public double4 xyzz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 1L, 2L, 2L)));

        }
    }
    public double4 xyzw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 1L, 2L, 3L)));

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        {
            this.x = value.x; this.y = value.y; this.z = value.z; this.w = value.w; 
        }
    }
    public double4 xywx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 1L, 3L, 0L)));

        }
    }
    public double4 xywy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 1L, 3L, 1L)));

        }
    }
    public double4 xywz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 1L, 3L, 2L)));

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        {
            this.x = value.x; this.y = value.y; this.w = value.z; this.z = value.w; 
        }
    }
    public double4 xyww
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 1L, 3L, 3L)));

        }
    }
    public double4 xzxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 2L, 0L, 0L)));

        }
    }
    public double4 xzxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 2L, 0L, 1L)));

        }
    }
    public double4 xzxz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 2L, 0L, 2L)));

        }
    }
    public double4 xzxw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 2L, 0L, 3L)));

        }
    }
    public double4 xzyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 2L, 1L, 0L)));

        }
    }
    public double4 xzyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 2L, 1L, 1L)));

        }
    }
    public double4 xzyz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 2L, 1L, 2L)));

        }
    }
    public double4 xzyw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 2L, 1L, 3L)));

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        {
            this.x = value.x; this.z = value.y; this.y = value.z; this.w = value.w; 
        }
    }
    public double4 xzzx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 2L, 2L, 0L)));

        }
    }
    public double4 xzzy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 2L, 2L, 1L)));

        }
    }
    public double4 xzzz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 2L, 2L, 2L)));

        }
    }
    public double4 xzzw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 2L, 2L, 3L)));

        }
    }
    public double4 xzwx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 2L, 3L, 0L)));

        }
    }
    public double4 xzwy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 2L, 3L, 1L)));

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        {
            this.x = value.x; this.z = value.y; this.w = value.z; this.y = value.w; 
        }
    }
    public double4 xzwz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 2L, 3L, 2L)));

        }
    }
    public double4 xzww
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 2L, 3L, 3L)));

        }
    }
    public double4 xwxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 3L, 0L, 0L)));

        }
    }
    public double4 xwxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 3L, 0L, 1L)));

        }
    }
    public double4 xwxz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 3L, 0L, 2L)));

        }
    }
    public double4 xwxw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 3L, 0L, 3L)));

        }
    }
    public double4 xwyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 3L, 1L, 0L)));

        }
    }
    public double4 xwyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 3L, 1L, 1L)));

        }
    }
    public double4 xwyz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 3L, 1L, 2L)));

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        {
            this.x = value.x; this.w = value.y; this.y = value.z; this.z = value.w; 
        }
    }
    public double4 xwyw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 3L, 1L, 3L)));

        }
    }
    public double4 xwzx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 3L, 2L, 0L)));

        }
    }
    public double4 xwzy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 3L, 2L, 1L)));

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        {
            this.x = value.x; this.w = value.y; this.z = value.z; this.y = value.w; 
        }
    }
    public double4 xwzz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 3L, 2L, 2L)));

        }
    }
    public double4 xwzw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 3L, 2L, 3L)));

        }
    }
    public double4 xwwx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 3L, 3L, 0L)));

        }
    }
    public double4 xwwy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 3L, 3L, 1L)));

        }
    }
    public double4 xwwz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 3L, 3L, 2L)));

        }
    }
    public double4 xwww
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 3L, 3L, 3L)));

        }
    }
    public double4 yxxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 0L, 0L, 0L)));

        }
    }
    public double4 yxxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 0L, 0L, 1L)));

        }
    }
    public double4 yxxz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 0L, 0L, 2L)));

        }
    }
    public double4 yxxw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 0L, 0L, 3L)));

        }
    }
    public double4 yxyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 0L, 1L, 0L)));

        }
    }
    public double4 yxyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 0L, 1L, 1L)));

        }
    }
    public double4 yxyz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 0L, 1L, 2L)));

        }
    }
    public double4 yxyw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 0L, 1L, 3L)));

        }
    }
    public double4 yxzx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 0L, 2L, 0L)));

        }
    }
    public double4 yxzy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 0L, 2L, 1L)));

        }
    }
    public double4 yxzz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 0L, 2L, 2L)));

        }
    }
    public double4 yxzw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 0L, 2L, 3L)));

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        {
            this.y = value.x; this.x = value.y; this.z = value.z; this.w = value.w; 
        }
    }
    public double4 yxwx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 0L, 3L, 0L)));

        }
    }
    public double4 yxwy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 0L, 3L, 1L)));

        }
    }
    public double4 yxwz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 0L, 3L, 2L)));

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        {
            this.y = value.x; this.x = value.y; this.w = value.z; this.z = value.w; 
        }
    }
    public double4 yxww
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 0L, 3L, 3L)));

        }
    }
    public double4 yyxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 1L, 0L, 0L)));

        }
    }
    public double4 yyxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 1L, 0L, 1L)));

        }
    }
    public double4 yyxz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 1L, 0L, 2L)));

        }
    }
    public double4 yyxw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 1L, 0L, 3L)));

        }
    }
    public double4 yyyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 1L, 1L, 0L)));

        }
    }
    public double4 yyyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 1L, 1L, 1L)));

        }
    }
    public double4 yyyz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 1L, 1L, 2L)));

        }
    }
    public double4 yyyw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 1L, 1L, 3L)));

        }
    }
    public double4 yyzx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 1L, 2L, 0L)));

        }
    }
    public double4 yyzy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 1L, 2L, 1L)));

        }
    }
    public double4 yyzz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 1L, 2L, 2L)));

        }
    }
    public double4 yyzw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 1L, 2L, 3L)));

        }
    }
    public double4 yywx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 1L, 3L, 0L)));

        }
    }
    public double4 yywy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 1L, 3L, 1L)));

        }
    }
    public double4 yywz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 1L, 3L, 2L)));

        }
    }
    public double4 yyww
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 1L, 3L, 3L)));

        }
    }
    public double4 yzxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 2L, 0L, 0L)));

        }
    }
    public double4 yzxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 2L, 0L, 1L)));

        }
    }
    public double4 yzxz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 2L, 0L, 2L)));

        }
    }
    public double4 yzxw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 2L, 0L, 3L)));

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        {
            this.y = value.x; this.z = value.y; this.x = value.z; this.w = value.w; 
        }
    }
    public double4 yzyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 2L, 1L, 0L)));

        }
    }
    public double4 yzyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 2L, 1L, 1L)));

        }
    }
    public double4 yzyz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 2L, 1L, 2L)));

        }
    }
    public double4 yzyw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 2L, 1L, 3L)));

        }
    }
    public double4 yzzx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 2L, 2L, 0L)));

        }
    }
    public double4 yzzy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 2L, 2L, 1L)));

        }
    }
    public double4 yzzz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 2L, 2L, 2L)));

        }
    }
    public double4 yzzw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 2L, 2L, 3L)));

        }
    }
    public double4 yzwx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 2L, 3L, 0L)));

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        {
            this.y = value.x; this.z = value.y; this.w = value.z; this.x = value.w; 
        }
    }
    public double4 yzwy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 2L, 3L, 1L)));

        }
    }
    public double4 yzwz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 2L, 3L, 2L)));

        }
    }
    public double4 yzww
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 2L, 3L, 3L)));

        }
    }
    public double4 ywxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 3L, 0L, 0L)));

        }
    }
    public double4 ywxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 3L, 0L, 1L)));

        }
    }
    public double4 ywxz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 3L, 0L, 2L)));

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        {
            this.y = value.x; this.w = value.y; this.x = value.z; this.z = value.w; 
        }
    }
    public double4 ywxw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 3L, 0L, 3L)));

        }
    }
    public double4 ywyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 3L, 1L, 0L)));

        }
    }
    public double4 ywyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 3L, 1L, 1L)));

        }
    }
    public double4 ywyz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 3L, 1L, 2L)));

        }
    }
    public double4 ywyw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 3L, 1L, 3L)));

        }
    }
    public double4 ywzx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 3L, 2L, 0L)));

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        {
            this.y = value.x; this.w = value.y; this.z = value.z; this.x = value.w; 
        }
    }
    public double4 ywzy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 3L, 2L, 1L)));

        }
    }
    public double4 ywzz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 3L, 2L, 2L)));

        }
    }
    public double4 ywzw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 3L, 2L, 3L)));

        }
    }
    public double4 ywwx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 3L, 3L, 0L)));

        }
    }
    public double4 ywwy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 3L, 3L, 1L)));

        }
    }
    public double4 ywwz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 3L, 3L, 2L)));

        }
    }
    public double4 ywww
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 3L, 3L, 3L)));

        }
    }
    public double4 zxxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 0L, 0L, 0L)));

        }
    }
    public double4 zxxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 0L, 0L, 1L)));

        }
    }
    public double4 zxxz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 0L, 0L, 2L)));

        }
    }
    public double4 zxxw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 0L, 0L, 3L)));

        }
    }
    public double4 zxyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 0L, 1L, 0L)));

        }
    }
    public double4 zxyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 0L, 1L, 1L)));

        }
    }
    public double4 zxyz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 0L, 1L, 2L)));

        }
    }
    public double4 zxyw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 0L, 1L, 3L)));

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        {
            this.z = value.x; this.x = value.y; this.y = value.z; this.w = value.w; 
        }
    }
    public double4 zxzx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 0L, 2L, 0L)));

        }
    }
    public double4 zxzy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 0L, 2L, 1L)));

        }
    }
    public double4 zxzz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 0L, 2L, 2L)));

        }
    }
    public double4 zxzw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 0L, 2L, 3L)));

        }
    }
    public double4 zxwx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 0L, 3L, 0L)));

        }
    }
    public double4 zxwy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 0L, 3L, 1L)));

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        {
            this.z = value.x; this.x = value.y; this.w = value.z; this.y = value.w; 
        }
    }
    public double4 zxwz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 0L, 3L, 2L)));

        }
    }
    public double4 zxww
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 0L, 3L, 3L)));

        }
    }
    public double4 zyxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 1L, 0L, 0L)));

        }
    }
    public double4 zyxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 1L, 0L, 1L)));

        }
    }
    public double4 zyxz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 1L, 0L, 2L)));

        }
    }
    public double4 zyxw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 1L, 0L, 3L)));

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        {
            this.z = value.x; this.y = value.y; this.x = value.z; this.w = value.w; 
        }
    }
    public double4 zyyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 1L, 1L, 0L)));

        }
    }
    public double4 zyyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 1L, 1L, 1L)));

        }
    }
    public double4 zyyz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 1L, 1L, 2L)));

        }
    }
    public double4 zyyw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 1L, 1L, 3L)));

        }
    }
    public double4 zyzx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 1L, 2L, 0L)));

        }
    }
    public double4 zyzy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 1L, 2L, 1L)));

        }
    }
    public double4 zyzz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 1L, 2L, 2L)));

        }
    }
    public double4 zyzw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 1L, 2L, 3L)));

        }
    }
    public double4 zywx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 1L, 3L, 0L)));

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        {
            this.z = value.x; this.y = value.y; this.w = value.z; this.x = value.w; 
        }
    }
    public double4 zywy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 1L, 3L, 1L)));

        }
    }
    public double4 zywz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 1L, 3L, 2L)));

        }
    }
    public double4 zyww
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 1L, 3L, 3L)));

        }
    }
    public double4 zzxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 2L, 0L, 0L)));

        }
    }
    public double4 zzxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 2L, 0L, 1L)));

        }
    }
    public double4 zzxz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 2L, 0L, 2L)));

        }
    }
    public double4 zzxw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 2L, 0L, 3L)));

        }
    }
    public double4 zzyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 2L, 1L, 0L)));

        }
    }
    public double4 zzyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 2L, 1L, 1L)));

        }
    }
    public double4 zzyz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 2L, 1L, 2L)));

        }
    }
    public double4 zzyw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 2L, 1L, 3L)));

        }
    }
    public double4 zzzx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 2L, 2L, 0L)));

        }
    }
    public double4 zzzy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 2L, 2L, 1L)));

        }
    }
    public double4 zzzz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 2L, 2L, 2L)));

        }
    }
    public double4 zzzw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 2L, 2L, 3L)));

        }
    }
    public double4 zzwx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 2L, 3L, 0L)));

        }
    }
    public double4 zzwy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 2L, 3L, 1L)));

        }
    }
    public double4 zzwz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 2L, 3L, 2L)));

        }
    }
    public double4 zzww
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 2L, 3L, 3L)));

        }
    }
    public double4 zwxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 3L, 0L, 0L)));

        }
    }
    public double4 zwxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 3L, 0L, 1L)));

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        {
            this.z = value.x; this.w = value.y; this.x = value.z; this.y = value.w; 
        }
    }
    public double4 zwxz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 3L, 0L, 2L)));

        }
    }
    public double4 zwxw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 3L, 0L, 3L)));

        }
    }
    public double4 zwyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 3L, 1L, 0L)));

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        {
            this.z = value.x; this.w = value.y; this.y = value.z; this.x = value.w; 
        }
    }
    public double4 zwyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 3L, 1L, 1L)));

        }
    }
    public double4 zwyz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 3L, 1L, 2L)));

        }
    }
    public double4 zwyw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 3L, 1L, 3L)));

        }
    }
    public double4 zwzx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 3L, 2L, 0L)));

        }
    }
    public double4 zwzy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 3L, 2L, 1L)));

        }
    }
    public double4 zwzz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 3L, 2L, 2L)));

        }
    }
    public double4 zwzw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 3L, 2L, 3L)));

        }
    }
    public double4 zwwx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 3L, 3L, 0L)));

        }
    }
    public double4 zwwy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 3L, 3L, 1L)));

        }
    }
    public double4 zwwz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 3L, 3L, 2L)));

        }
    }
    public double4 zwww
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 3L, 3L, 3L)));

        }
    }
    public double4 wxxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 0L, 0L, 0L)));

        }
    }
    public double4 wxxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 0L, 0L, 1L)));

        }
    }
    public double4 wxxz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 0L, 0L, 2L)));

        }
    }
    public double4 wxxw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 0L, 0L, 3L)));

        }
    }
    public double4 wxyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 0L, 1L, 0L)));

        }
    }
    public double4 wxyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 0L, 1L, 1L)));

        }
    }
    public double4 wxyz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 0L, 1L, 2L)));

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        {
            this.w = value.x; this.x = value.y; this.y = value.z; this.z = value.w; 
        }
    }
    public double4 wxyw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 0L, 1L, 3L)));

        }
    }
    public double4 wxzx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 0L, 2L, 0L)));

        }
    }
    public double4 wxzy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 0L, 2L, 1L)));

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        {
            this.w = value.x; this.x = value.y; this.z = value.z; this.y = value.w; 
        }
    }
    public double4 wxzz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 0L, 2L, 2L)));

        }
    }
    public double4 wxzw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 0L, 2L, 3L)));

        }
    }
    public double4 wxwx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 0L, 3L, 0L)));

        }
    }
    public double4 wxwy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 0L, 3L, 1L)));

        }
    }
    public double4 wxwz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 0L, 3L, 2L)));

        }
    }
    public double4 wxww
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 0L, 3L, 3L)));

        }
    }
    public double4 wyxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 1L, 0L, 0L)));

        }
    }
    public double4 wyxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 1L, 0L, 1L)));

        }
    }
    public double4 wyxz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 1L, 0L, 2L)));

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        {
            this.w = value.x; this.y = value.y; this.x = value.z; this.z = value.w; 
        }
    }
    public double4 wyxw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 1L, 0L, 3L)));

        }
    }
    public double4 wyyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 1L, 1L, 0L)));

        }
    }
    public double4 wyyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 1L, 1L, 1L)));

        }
    }
    public double4 wyyz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 1L, 1L, 2L)));

        }
    }
    public double4 wyyw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 1L, 1L, 3L)));

        }
    }
    public double4 wyzx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 1L, 2L, 0L)));

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        {
            this.w = value.x; this.y = value.y; this.z = value.z; this.x = value.w; 
        }
    }
    public double4 wyzy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 1L, 2L, 1L)));

        }
    }
    public double4 wyzz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 1L, 2L, 2L)));

        }
    }
    public double4 wyzw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 1L, 2L, 3L)));

        }
    }
    public double4 wywx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 1L, 3L, 0L)));

        }
    }
    public double4 wywy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 1L, 3L, 1L)));

        }
    }
    public double4 wywz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 1L, 3L, 2L)));

        }
    }
    public double4 wyww
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 1L, 3L, 3L)));

        }
    }
    public double4 wzxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 2L, 0L, 0L)));

        }
    }
    public double4 wzxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 2L, 0L, 1L)));

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        {
            this.w = value.x; this.z = value.y; this.x = value.z; this.y = value.w; 
        }
    }
    public double4 wzxz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 2L, 0L, 2L)));

        }
    }
    public double4 wzxw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 2L, 0L, 3L)));

        }
    }
    public double4 wzyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 2L, 1L, 0L)));

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        {
            this.w = value.x; this.z = value.y; this.y = value.z; this.x = value.w; 
        }
    }
    public double4 wzyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 2L, 1L, 1L)));

        }
    }
    public double4 wzyz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 2L, 1L, 2L)));

        }
    }
    public double4 wzyw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 2L, 1L, 3L)));

        }
    }
    public double4 wzzx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 2L, 2L, 0L)));

        }
    }
    public double4 wzzy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 2L, 2L, 1L)));

        }
    }
    public double4 wzzz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 2L, 2L, 2L)));

        }
    }
    public double4 wzzw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 2L, 2L, 3L)));

        }
    }
    public double4 wzwx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 2L, 3L, 0L)));

        }
    }
    public double4 wzwy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 2L, 3L, 1L)));

        }
    }
    public double4 wzwz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 2L, 3L, 2L)));

        }
    }
    public double4 wzww
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 2L, 3L, 3L)));

        }
    }
    public double4 wwxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 3L, 0L, 0L)));

        }
    }
    public double4 wwxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 3L, 0L, 1L)));

        }
    }
    public double4 wwxz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 3L, 0L, 2L)));

        }
    }
    public double4 wwxw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 3L, 0L, 3L)));

        }
    }
    public double4 wwyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 3L, 1L, 0L)));

        }
    }
    public double4 wwyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 3L, 1L, 1L)));

        }
    }
    public double4 wwyz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 3L, 1L, 2L)));

        }
    }
    public double4 wwyw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 3L, 1L, 3L)));

        }
    }
    public double4 wwzx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 3L, 2L, 0L)));

        }
    }
    public double4 wwzy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 3L, 2L, 1L)));

        }
    }
    public double4 wwzz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 3L, 2L, 2L)));

        }
    }
    public double4 wwzw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 3L, 2L, 3L)));

        }
    }
    public double4 wwwx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 3L, 3L, 0L)));

        }
    }
    public double4 wwwy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 3L, 3L, 1L)));

        }
    }
    public double4 wwwz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 3L, 3L, 2L)));

        }
    }
    public double4 wwww
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 3L, 3L, 3L)));

        }
    }
    public double4 rrrr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 0L, 0L, 0L)));

        }
    }
    public double4 rrrg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 0L, 0L, 1L)));

        }
    }
    public double4 rrrb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 0L, 0L, 2L)));

        }
    }
    public double4 rrra
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 0L, 0L, 3L)));

        }
    }
    public double4 rrgr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 0L, 1L, 0L)));

        }
    }
    public double4 rrgg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 0L, 1L, 1L)));

        }
    }
    public double4 rrgb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 0L, 1L, 2L)));

        }
    }
    public double4 rrga
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 0L, 1L, 3L)));

        }
    }
    public double4 rrbr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 0L, 2L, 0L)));

        }
    }
    public double4 rrbg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 0L, 2L, 1L)));

        }
    }
    public double4 rrbb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 0L, 2L, 2L)));

        }
    }
    public double4 rrba
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 0L, 2L, 3L)));

        }
    }
    public double4 rrar
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 0L, 3L, 0L)));

        }
    }
    public double4 rrag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 0L, 3L, 1L)));

        }
    }
    public double4 rrab
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 0L, 3L, 2L)));

        }
    }
    public double4 rraa
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 0L, 3L, 3L)));

        }
    }
    public double4 rgrr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 1L, 0L, 0L)));

        }
    }
    public double4 rgrg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 1L, 0L, 1L)));

        }
    }
    public double4 rgrb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 1L, 0L, 2L)));

        }
    }
    public double4 rgra
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 1L, 0L, 3L)));

        }
    }
    public double4 rggr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 1L, 1L, 0L)));

        }
    }
    public double4 rggg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 1L, 1L, 1L)));

        }
    }
    public double4 rggb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 1L, 1L, 2L)));

        }
    }
    public double4 rgga
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 1L, 1L, 3L)));

        }
    }
    public double4 rgbr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 1L, 2L, 0L)));

        }
    }
    public double4 rgbg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 1L, 2L, 1L)));

        }
    }
    public double4 rgbb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 1L, 2L, 2L)));

        }
    }
    public double4 rgba
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 1L, 2L, 3L)));

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        {
            this.r = value.x; this.g = value.y; this.b = value.z; this.a = value.w; 
        }
    }
    public double4 rgar
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 1L, 3L, 0L)));

        }
    }
    public double4 rgag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 1L, 3L, 1L)));

        }
    }
    public double4 rgab
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 1L, 3L, 2L)));

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        {
            this.r = value.x; this.g = value.y; this.a = value.z; this.b = value.w; 
        }
    }
    public double4 rgaa
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 1L, 3L, 3L)));

        }
    }
    public double4 rbrr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 2L, 0L, 0L)));

        }
    }
    public double4 rbrg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 2L, 0L, 1L)));

        }
    }
    public double4 rbrb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 2L, 0L, 2L)));

        }
    }
    public double4 rbra
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 2L, 0L, 3L)));

        }
    }
    public double4 rbgr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 2L, 1L, 0L)));

        }
    }
    public double4 rbgg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 2L, 1L, 1L)));

        }
    }
    public double4 rbgb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 2L, 1L, 2L)));

        }
    }
    public double4 rbga
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 2L, 1L, 3L)));

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        {
            this.r = value.x; this.b = value.y; this.g = value.z; this.a = value.w; 
        }
    }
    public double4 rbbr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 2L, 2L, 0L)));

        }
    }
    public double4 rbbg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 2L, 2L, 1L)));

        }
    }
    public double4 rbbb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 2L, 2L, 2L)));

        }
    }
    public double4 rbba
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 2L, 2L, 3L)));

        }
    }
    public double4 rbar
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 2L, 3L, 0L)));

        }
    }
    public double4 rbag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 2L, 3L, 1L)));

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        {
            this.r = value.x; this.b = value.y; this.a = value.z; this.g = value.w; 
        }
    }
    public double4 rbab
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 2L, 3L, 2L)));

        }
    }
    public double4 rbaa
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 2L, 3L, 3L)));

        }
    }
    public double4 rarr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 3L, 0L, 0L)));

        }
    }
    public double4 rarg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 3L, 0L, 1L)));

        }
    }
    public double4 rarb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 3L, 0L, 2L)));

        }
    }
    public double4 rara
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 3L, 0L, 3L)));

        }
    }
    public double4 ragr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 3L, 1L, 0L)));

        }
    }
    public double4 ragg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 3L, 1L, 1L)));

        }
    }
    public double4 ragb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 3L, 1L, 2L)));

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        {
            this.r = value.x; this.a = value.y; this.g = value.z; this.b = value.w; 
        }
    }
    public double4 raga
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 3L, 1L, 3L)));

        }
    }
    public double4 rabr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 3L, 2L, 0L)));

        }
    }
    public double4 rabg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 3L, 2L, 1L)));

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        {
            this.r = value.x; this.a = value.y; this.b = value.z; this.g = value.w; 
        }
    }
    public double4 rabb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 3L, 2L, 2L)));

        }
    }
    public double4 raba
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 3L, 2L, 3L)));

        }
    }
    public double4 raar
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 3L, 3L, 0L)));

        }
    }
    public double4 raag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 3L, 3L, 1L)));

        }
    }
    public double4 raab
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 3L, 3L, 2L)));

        }
    }
    public double4 raaa
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 3L, 3L, 3L)));

        }
    }
    public double4 grrr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 0L, 0L, 0L)));

        }
    }
    public double4 grrg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 0L, 0L, 1L)));

        }
    }
    public double4 grrb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 0L, 0L, 2L)));

        }
    }
    public double4 grra
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 0L, 0L, 3L)));

        }
    }
    public double4 grgr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 0L, 1L, 0L)));

        }
    }
    public double4 grgg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 0L, 1L, 1L)));

        }
    }
    public double4 grgb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 0L, 1L, 2L)));

        }
    }
    public double4 grga
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 0L, 1L, 3L)));

        }
    }
    public double4 grbr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 0L, 2L, 0L)));

        }
    }
    public double4 grbg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 0L, 2L, 1L)));

        }
    }
    public double4 grbb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 0L, 2L, 2L)));

        }
    }
    public double4 grba
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 0L, 2L, 3L)));

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        {
            this.g = value.x; this.r = value.y; this.b = value.z; this.a = value.w; 
        }
    }
    public double4 grar
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 0L, 3L, 0L)));

        }
    }
    public double4 grag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 0L, 3L, 1L)));

        }
    }
    public double4 grab
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 0L, 3L, 2L)));

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        {
            this.g = value.x; this.r = value.y; this.a = value.z; this.b = value.w; 
        }
    }
    public double4 graa
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 0L, 3L, 3L)));

        }
    }
    public double4 ggrr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 1L, 0L, 0L)));

        }
    }
    public double4 ggrg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 1L, 0L, 1L)));

        }
    }
    public double4 ggrb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 1L, 0L, 2L)));

        }
    }
    public double4 ggra
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 1L, 0L, 3L)));

        }
    }
    public double4 gggr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 1L, 1L, 0L)));

        }
    }
    public double4 gggg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 1L, 1L, 1L)));

        }
    }
    public double4 gggb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 1L, 1L, 2L)));

        }
    }
    public double4 ggga
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 1L, 1L, 3L)));

        }
    }
    public double4 ggbr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 1L, 2L, 0L)));

        }
    }
    public double4 ggbg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 1L, 2L, 1L)));

        }
    }
    public double4 ggbb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 1L, 2L, 2L)));

        }
    }
    public double4 ggba
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 1L, 2L, 3L)));

        }
    }
    public double4 ggar
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 1L, 3L, 0L)));

        }
    }
    public double4 ggag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 1L, 3L, 1L)));

        }
    }
    public double4 ggab
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 1L, 3L, 2L)));

        }
    }
    public double4 ggaa
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 1L, 3L, 3L)));

        }
    }
    public double4 gbrr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 2L, 0L, 0L)));

        }
    }
    public double4 gbrg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 2L, 0L, 1L)));

        }
    }
    public double4 gbrb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 2L, 0L, 2L)));

        }
    }
    public double4 gbra
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 2L, 0L, 3L)));

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        {
            this.g = value.x; this.b = value.y; this.r = value.z; this.a = value.w; 
        }
    }
    public double4 gbgr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 2L, 1L, 0L)));

        }
    }
    public double4 gbgg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 2L, 1L, 1L)));

        }
    }
    public double4 gbgb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 2L, 1L, 2L)));

        }
    }
    public double4 gbga
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 2L, 1L, 3L)));

        }
    }
    public double4 gbbr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 2L, 2L, 0L)));

        }
    }
    public double4 gbbg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 2L, 2L, 1L)));

        }
    }
    public double4 gbbb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 2L, 2L, 2L)));

        }
    }
    public double4 gbba
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 2L, 2L, 3L)));

        }
    }
    public double4 gbar
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 2L, 3L, 0L)));

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        {
            this.g = value.x; this.b = value.y; this.a = value.z; this.r = value.w; 
        }
    }
    public double4 gbag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 2L, 3L, 1L)));

        }
    }
    public double4 gbab
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 2L, 3L, 2L)));

        }
    }
    public double4 gbaa
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 2L, 3L, 3L)));

        }
    }
    public double4 garr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 3L, 0L, 0L)));

        }
    }
    public double4 garg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 3L, 0L, 1L)));

        }
    }
    public double4 garb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 3L, 0L, 2L)));

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        {
            this.g = value.x; this.a = value.y; this.r = value.z; this.b = value.w; 
        }
    }
    public double4 gara
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 3L, 0L, 3L)));

        }
    }
    public double4 gagr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 3L, 1L, 0L)));

        }
    }
    public double4 gagg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 3L, 1L, 1L)));

        }
    }
    public double4 gagb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 3L, 1L, 2L)));

        }
    }
    public double4 gaga
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 3L, 1L, 3L)));

        }
    }
    public double4 gabr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 3L, 2L, 0L)));

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        {
            this.g = value.x; this.a = value.y; this.b = value.z; this.r = value.w; 
        }
    }
    public double4 gabg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 3L, 2L, 1L)));

        }
    }
    public double4 gabb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 3L, 2L, 2L)));

        }
    }
    public double4 gaba
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 3L, 2L, 3L)));

        }
    }
    public double4 gaar
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 3L, 3L, 0L)));

        }
    }
    public double4 gaag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 3L, 3L, 1L)));

        }
    }
    public double4 gaab
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 3L, 3L, 2L)));

        }
    }
    public double4 gaaa
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 3L, 3L, 3L)));

        }
    }
    public double4 brrr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 0L, 0L, 0L)));

        }
    }
    public double4 brrg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 0L, 0L, 1L)));

        }
    }
    public double4 brrb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 0L, 0L, 2L)));

        }
    }
    public double4 brra
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 0L, 0L, 3L)));

        }
    }
    public double4 brgr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 0L, 1L, 0L)));

        }
    }
    public double4 brgg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 0L, 1L, 1L)));

        }
    }
    public double4 brgb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 0L, 1L, 2L)));

        }
    }
    public double4 brga
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 0L, 1L, 3L)));

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        {
            this.b = value.x; this.r = value.y; this.g = value.z; this.a = value.w; 
        }
    }
    public double4 brbr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 0L, 2L, 0L)));

        }
    }
    public double4 brbg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 0L, 2L, 1L)));

        }
    }
    public double4 brbb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 0L, 2L, 2L)));

        }
    }
    public double4 brba
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 0L, 2L, 3L)));

        }
    }
    public double4 brar
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 0L, 3L, 0L)));

        }
    }
    public double4 brag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 0L, 3L, 1L)));

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        {
            this.b = value.x; this.r = value.y; this.a = value.z; this.g = value.w; 
        }
    }
    public double4 brab
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 0L, 3L, 2L)));

        }
    }
    public double4 braa
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 0L, 3L, 3L)));

        }
    }
    public double4 bgrr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 1L, 0L, 0L)));

        }
    }
    public double4 bgrg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 1L, 0L, 1L)));

        }
    }
    public double4 bgrb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 1L, 0L, 2L)));

        }
    }
    public double4 bgra
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 1L, 0L, 3L)));

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        {
            this.b = value.x; this.g = value.y; this.r = value.z; this.a = value.w; 
        }
    }
    public double4 bggr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 1L, 1L, 0L)));

        }
    }
    public double4 bggg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 1L, 1L, 1L)));

        }
    }
    public double4 bggb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 1L, 1L, 2L)));

        }
    }
    public double4 bgga
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 1L, 1L, 3L)));

        }
    }
    public double4 bgbr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 1L, 2L, 0L)));

        }
    }
    public double4 bgbg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 1L, 2L, 1L)));

        }
    }
    public double4 bgbb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 1L, 2L, 2L)));

        }
    }
    public double4 bgba
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 1L, 2L, 3L)));

        }
    }
    public double4 bgar
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 1L, 3L, 0L)));

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        {
            this.b = value.x; this.g = value.y; this.a = value.z; this.r = value.w; 
        }
    }
    public double4 bgag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 1L, 3L, 1L)));

        }
    }
    public double4 bgab
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 1L, 3L, 2L)));

        }
    }
    public double4 bgaa
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 1L, 3L, 3L)));

        }
    }
    public double4 bbrr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 2L, 0L, 0L)));

        }
    }
    public double4 bbrg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 2L, 0L, 1L)));

        }
    }
    public double4 bbrb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 2L, 0L, 2L)));

        }
    }
    public double4 bbra
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 2L, 0L, 3L)));

        }
    }
    public double4 bbgr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 2L, 1L, 0L)));

        }
    }
    public double4 bbgg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 2L, 1L, 1L)));

        }
    }
    public double4 bbgb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 2L, 1L, 2L)));

        }
    }
    public double4 bbga
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 2L, 1L, 3L)));

        }
    }
    public double4 bbbr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 2L, 2L, 0L)));

        }
    }
    public double4 bbbg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 2L, 2L, 1L)));

        }
    }
    public double4 bbbb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 2L, 2L, 2L)));

        }
    }
    public double4 bbba
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 2L, 2L, 3L)));

        }
    }
    public double4 bbar
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 2L, 3L, 0L)));

        }
    }
    public double4 bbag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 2L, 3L, 1L)));

        }
    }
    public double4 bbab
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 2L, 3L, 2L)));

        }
    }
    public double4 bbaa
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 2L, 3L, 3L)));

        }
    }
    public double4 barr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 3L, 0L, 0L)));

        }
    }
    public double4 barg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 3L, 0L, 1L)));

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        {
            this.b = value.x; this.a = value.y; this.r = value.z; this.g = value.w; 
        }
    }
    public double4 barb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 3L, 0L, 2L)));

        }
    }
    public double4 bara
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 3L, 0L, 3L)));

        }
    }
    public double4 bagr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 3L, 1L, 0L)));

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        {
            this.b = value.x; this.a = value.y; this.g = value.z; this.r = value.w; 
        }
    }
    public double4 bagg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 3L, 1L, 1L)));

        }
    }
    public double4 bagb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 3L, 1L, 2L)));

        }
    }
    public double4 baga
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 3L, 1L, 3L)));

        }
    }
    public double4 babr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 3L, 2L, 0L)));

        }
    }
    public double4 babg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 3L, 2L, 1L)));

        }
    }
    public double4 babb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 3L, 2L, 2L)));

        }
    }
    public double4 baba
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 3L, 2L, 3L)));

        }
    }
    public double4 baar
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 3L, 3L, 0L)));

        }
    }
    public double4 baag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 3L, 3L, 1L)));

        }
    }
    public double4 baab
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 3L, 3L, 2L)));

        }
    }
    public double4 baaa
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 3L, 3L, 3L)));

        }
    }
    public double4 arrr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 0L, 0L, 0L)));

        }
    }
    public double4 arrg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 0L, 0L, 1L)));

        }
    }
    public double4 arrb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 0L, 0L, 2L)));

        }
    }
    public double4 arra
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 0L, 0L, 3L)));

        }
    }
    public double4 argr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 0L, 1L, 0L)));

        }
    }
    public double4 argg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 0L, 1L, 1L)));

        }
    }
    public double4 argb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 0L, 1L, 2L)));

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        {
            this.a = value.x; this.r = value.y; this.g = value.z; this.b = value.w; 
        }
    }
    public double4 arga
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 0L, 1L, 3L)));

        }
    }
    public double4 arbr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 0L, 2L, 0L)));

        }
    }
    public double4 arbg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 0L, 2L, 1L)));

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        {
            this.a = value.x; this.r = value.y; this.b = value.z; this.g = value.w; 
        }
    }
    public double4 arbb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 0L, 2L, 2L)));

        }
    }
    public double4 arba
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 0L, 2L, 3L)));

        }
    }
    public double4 arar
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 0L, 3L, 0L)));

        }
    }
    public double4 arag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 0L, 3L, 1L)));

        }
    }
    public double4 arab
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 0L, 3L, 2L)));

        }
    }
    public double4 araa
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 0L, 3L, 3L)));

        }
    }
    public double4 agrr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 1L, 0L, 0L)));

        }
    }
    public double4 agrg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 1L, 0L, 1L)));

        }
    }
    public double4 agrb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 1L, 0L, 2L)));

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        {
            this.a = value.x; this.g = value.y; this.r = value.z; this.b = value.w; 
        }
    }
    public double4 agra
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 1L, 0L, 3L)));

        }
    }
    public double4 aggr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 1L, 1L, 0L)));

        }
    }
    public double4 aggg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 1L, 1L, 1L)));

        }
    }
    public double4 aggb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 1L, 1L, 2L)));

        }
    }
    public double4 agga
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 1L, 1L, 3L)));

        }
    }
    public double4 agbr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 1L, 2L, 0L)));

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        {
            this.a = value.x; this.g = value.y; this.b = value.z; this.r = value.w; 
        }
    }
    public double4 agbg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 1L, 2L, 1L)));

        }
    }
    public double4 agbb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 1L, 2L, 2L)));

        }
    }
    public double4 agba
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 1L, 2L, 3L)));

        }
    }
    public double4 agar
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 1L, 3L, 0L)));

        }
    }
    public double4 agag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 1L, 3L, 1L)));

        }
    }
    public double4 agab
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 1L, 3L, 2L)));

        }
    }
    public double4 agaa
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 1L, 3L, 3L)));

        }
    }
    public double4 abrr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 2L, 0L, 0L)));

        }
    }
    public double4 abrg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 2L, 0L, 1L)));

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        {
            this.a = value.x; this.b = value.y; this.r = value.z; this.g = value.w; 
        }
    }
    public double4 abrb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 2L, 0L, 2L)));

        }
    }
    public double4 abra
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 2L, 0L, 3L)));

        }
    }
    public double4 abgr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 2L, 1L, 0L)));

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        {
            this.a = value.x; this.b = value.y; this.g = value.z; this.r = value.w; 
        }
    }
    public double4 abgg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 2L, 1L, 1L)));

        }
    }
    public double4 abgb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 2L, 1L, 2L)));

        }
    }
    public double4 abga
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 2L, 1L, 3L)));

        }
    }
    public double4 abbr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 2L, 2L, 0L)));

        }
    }
    public double4 abbg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 2L, 2L, 1L)));

        }
    }
    public double4 abbb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 2L, 2L, 2L)));

        }
    }
    public double4 abba
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 2L, 2L, 3L)));

        }
    }
    public double4 abar
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 2L, 3L, 0L)));

        }
    }
    public double4 abag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 2L, 3L, 1L)));

        }
    }
    public double4 abab
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 2L, 3L, 2L)));

        }
    }
    public double4 abaa
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 2L, 3L, 3L)));

        }
    }
    public double4 aarr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 3L, 0L, 0L)));

        }
    }
    public double4 aarg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 3L, 0L, 1L)));

        }
    }
    public double4 aarb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 3L, 0L, 2L)));

        }
    }
    public double4 aara
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 3L, 0L, 3L)));

        }
    }
    public double4 aagr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 3L, 1L, 0L)));

        }
    }
    public double4 aagg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 3L, 1L, 1L)));

        }
    }
    public double4 aagb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 3L, 1L, 2L)));

        }
    }
    public double4 aaga
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 3L, 1L, 3L)));

        }
    }
    public double4 aabr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 3L, 2L, 0L)));

        }
    }
    public double4 aabg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 3L, 2L, 1L)));

        }
    }
    public double4 aabb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 3L, 2L, 2L)));

        }
    }
    public double4 aaba
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 3L, 2L, 3L)));

        }
    }
    public double4 aaar
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 3L, 3L, 0L)));

        }
    }
    public double4 aaag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 3L, 3L, 1L)));

        }
    }
    public double4 aaab
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 3L, 3L, 2L)));

        }
    }
    public double4 aaaa
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 3L, 3L, 3L)));

        }
    }


}
