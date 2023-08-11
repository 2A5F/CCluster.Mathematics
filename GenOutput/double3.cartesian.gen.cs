using System;
using System.Numerics;
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.X86;
using System.Runtime.Intrinsics.Arm;
using System.Runtime.CompilerServices;

#nullable enable
#pragma warning disable CS8981

namespace CCluster.Mathematics;

public partial struct double3 
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


}
