using System;
using System.Numerics;
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.X86;
using System.Runtime.Intrinsics.Arm;
using System.Runtime.CompilerServices;

#nullable enable
#pragma warning disable CS8981

namespace CCluster.Mathematics;

public partial struct double2 
{

    public double2 xx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(0L, 0L)));

        }
    }
    public double2 xy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(0L, 1L)));

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.x = value.x; this.y = value.y; 
        }
    }
    public double2 yx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(1L, 0L)));

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

            return new(Vector128.Shuffle(this.vector, Vector128.Create(1L, 1L)));

        }
    }
    public double2 rr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(0L, 0L)));

        }
    }
    public double2 rg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(0L, 1L)));

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.r = value.x; this.g = value.y; 
        }
    }
    public double2 gr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(1L, 0L)));

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

            return new(Vector128.Shuffle(this.vector, Vector128.Create(1L, 1L)));

        }
    }
    public double3 xxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            var a = Vector128.Shuffle(this.vector, Vector128.Create(0L, 0L));
            var b = Vector128.Shuffle(this.vector, Vector128.Create(0L, 0L));
            return new(Vector256.Create(a, b) & math.v3_iz_double256);

        }
    }
    public double3 xxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            var a = Vector128.Shuffle(this.vector, Vector128.Create(0L, 0L));
            var b = Vector128.Shuffle(this.vector, Vector128.Create(1L, 0L));
            return new(Vector256.Create(a, b) & math.v3_iz_double256);

        }
    }
    public double3 xyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            var a = Vector128.Shuffle(this.vector, Vector128.Create(0L, 1L));
            var b = Vector128.Shuffle(this.vector, Vector128.Create(0L, 0L));
            return new(Vector256.Create(a, b) & math.v3_iz_double256);

        }
    }
    public double3 xyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            var a = Vector128.Shuffle(this.vector, Vector128.Create(0L, 1L));
            var b = Vector128.Shuffle(this.vector, Vector128.Create(1L, 0L));
            return new(Vector256.Create(a, b) & math.v3_iz_double256);

        }
    }
    public double3 yxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            var a = Vector128.Shuffle(this.vector, Vector128.Create(1L, 0L));
            var b = Vector128.Shuffle(this.vector, Vector128.Create(0L, 0L));
            return new(Vector256.Create(a, b) & math.v3_iz_double256);

        }
    }
    public double3 yxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            var a = Vector128.Shuffle(this.vector, Vector128.Create(1L, 0L));
            var b = Vector128.Shuffle(this.vector, Vector128.Create(1L, 0L));
            return new(Vector256.Create(a, b) & math.v3_iz_double256);

        }
    }
    public double3 yyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            var a = Vector128.Shuffle(this.vector, Vector128.Create(1L, 1L));
            var b = Vector128.Shuffle(this.vector, Vector128.Create(0L, 0L));
            return new(Vector256.Create(a, b) & math.v3_iz_double256);

        }
    }
    public double3 yyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            var a = Vector128.Shuffle(this.vector, Vector128.Create(1L, 1L));
            var b = Vector128.Shuffle(this.vector, Vector128.Create(1L, 0L));
            return new(Vector256.Create(a, b) & math.v3_iz_double256);

        }
    }
    public double3 rrr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            var a = Vector128.Shuffle(this.vector, Vector128.Create(0L, 0L));
            var b = Vector128.Shuffle(this.vector, Vector128.Create(0L, 0L));
            return new(Vector256.Create(a, b) & math.v3_iz_double256);

        }
    }
    public double3 rrg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            var a = Vector128.Shuffle(this.vector, Vector128.Create(0L, 0L));
            var b = Vector128.Shuffle(this.vector, Vector128.Create(1L, 0L));
            return new(Vector256.Create(a, b) & math.v3_iz_double256);

        }
    }
    public double3 rgr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            var a = Vector128.Shuffle(this.vector, Vector128.Create(0L, 1L));
            var b = Vector128.Shuffle(this.vector, Vector128.Create(0L, 0L));
            return new(Vector256.Create(a, b) & math.v3_iz_double256);

        }
    }
    public double3 rgg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            var a = Vector128.Shuffle(this.vector, Vector128.Create(0L, 1L));
            var b = Vector128.Shuffle(this.vector, Vector128.Create(1L, 0L));
            return new(Vector256.Create(a, b) & math.v3_iz_double256);

        }
    }
    public double3 grr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            var a = Vector128.Shuffle(this.vector, Vector128.Create(1L, 0L));
            var b = Vector128.Shuffle(this.vector, Vector128.Create(0L, 0L));
            return new(Vector256.Create(a, b) & math.v3_iz_double256);

        }
    }
    public double3 grg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            var a = Vector128.Shuffle(this.vector, Vector128.Create(1L, 0L));
            var b = Vector128.Shuffle(this.vector, Vector128.Create(1L, 0L));
            return new(Vector256.Create(a, b) & math.v3_iz_double256);

        }
    }
    public double3 ggr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            var a = Vector128.Shuffle(this.vector, Vector128.Create(1L, 1L));
            var b = Vector128.Shuffle(this.vector, Vector128.Create(0L, 0L));
            return new(Vector256.Create(a, b) & math.v3_iz_double256);

        }
    }
    public double3 ggg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            var a = Vector128.Shuffle(this.vector, Vector128.Create(1L, 1L));
            var b = Vector128.Shuffle(this.vector, Vector128.Create(1L, 0L));
            return new(Vector256.Create(a, b) & math.v3_iz_double256);

        }
    }
    public double4 xxxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector128.Shuffle(this.vector, Vector128.Create(0L, 0L));
            var b = Vector128.Shuffle(this.vector, Vector128.Create(0L, 0L));
            return new(Vector256.Create(a, b));

        }
    }
    public double4 xxxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector128.Shuffle(this.vector, Vector128.Create(0L, 0L));
            var b = Vector128.Shuffle(this.vector, Vector128.Create(0L, 1L));
            return new(Vector256.Create(a, b));

        }
    }
    public double4 xxyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector128.Shuffle(this.vector, Vector128.Create(0L, 0L));
            var b = Vector128.Shuffle(this.vector, Vector128.Create(1L, 0L));
            return new(Vector256.Create(a, b));

        }
    }
    public double4 xxyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector128.Shuffle(this.vector, Vector128.Create(0L, 0L));
            var b = Vector128.Shuffle(this.vector, Vector128.Create(1L, 1L));
            return new(Vector256.Create(a, b));

        }
    }
    public double4 xyxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector128.Shuffle(this.vector, Vector128.Create(0L, 1L));
            var b = Vector128.Shuffle(this.vector, Vector128.Create(0L, 0L));
            return new(Vector256.Create(a, b));

        }
    }
    public double4 xyxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector128.Shuffle(this.vector, Vector128.Create(0L, 1L));
            var b = Vector128.Shuffle(this.vector, Vector128.Create(0L, 1L));
            return new(Vector256.Create(a, b));

        }
    }
    public double4 xyyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector128.Shuffle(this.vector, Vector128.Create(0L, 1L));
            var b = Vector128.Shuffle(this.vector, Vector128.Create(1L, 0L));
            return new(Vector256.Create(a, b));

        }
    }
    public double4 xyyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector128.Shuffle(this.vector, Vector128.Create(0L, 1L));
            var b = Vector128.Shuffle(this.vector, Vector128.Create(1L, 1L));
            return new(Vector256.Create(a, b));

        }
    }
    public double4 yxxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector128.Shuffle(this.vector, Vector128.Create(1L, 0L));
            var b = Vector128.Shuffle(this.vector, Vector128.Create(0L, 0L));
            return new(Vector256.Create(a, b));

        }
    }
    public double4 yxxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector128.Shuffle(this.vector, Vector128.Create(1L, 0L));
            var b = Vector128.Shuffle(this.vector, Vector128.Create(0L, 1L));
            return new(Vector256.Create(a, b));

        }
    }
    public double4 yxyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector128.Shuffle(this.vector, Vector128.Create(1L, 0L));
            var b = Vector128.Shuffle(this.vector, Vector128.Create(1L, 0L));
            return new(Vector256.Create(a, b));

        }
    }
    public double4 yxyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector128.Shuffle(this.vector, Vector128.Create(1L, 0L));
            var b = Vector128.Shuffle(this.vector, Vector128.Create(1L, 1L));
            return new(Vector256.Create(a, b));

        }
    }
    public double4 yyxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector128.Shuffle(this.vector, Vector128.Create(1L, 1L));
            var b = Vector128.Shuffle(this.vector, Vector128.Create(0L, 0L));
            return new(Vector256.Create(a, b));

        }
    }
    public double4 yyxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector128.Shuffle(this.vector, Vector128.Create(1L, 1L));
            var b = Vector128.Shuffle(this.vector, Vector128.Create(0L, 1L));
            return new(Vector256.Create(a, b));

        }
    }
    public double4 yyyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector128.Shuffle(this.vector, Vector128.Create(1L, 1L));
            var b = Vector128.Shuffle(this.vector, Vector128.Create(1L, 0L));
            return new(Vector256.Create(a, b));

        }
    }
    public double4 yyyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector128.Shuffle(this.vector, Vector128.Create(1L, 1L));
            var b = Vector128.Shuffle(this.vector, Vector128.Create(1L, 1L));
            return new(Vector256.Create(a, b));

        }
    }
    public double4 rrrr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector128.Shuffle(this.vector, Vector128.Create(0L, 0L));
            var b = Vector128.Shuffle(this.vector, Vector128.Create(0L, 0L));
            return new(Vector256.Create(a, b));

        }
    }
    public double4 rrrg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector128.Shuffle(this.vector, Vector128.Create(0L, 0L));
            var b = Vector128.Shuffle(this.vector, Vector128.Create(0L, 1L));
            return new(Vector256.Create(a, b));

        }
    }
    public double4 rrgr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector128.Shuffle(this.vector, Vector128.Create(0L, 0L));
            var b = Vector128.Shuffle(this.vector, Vector128.Create(1L, 0L));
            return new(Vector256.Create(a, b));

        }
    }
    public double4 rrgg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector128.Shuffle(this.vector, Vector128.Create(0L, 0L));
            var b = Vector128.Shuffle(this.vector, Vector128.Create(1L, 1L));
            return new(Vector256.Create(a, b));

        }
    }
    public double4 rgrr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector128.Shuffle(this.vector, Vector128.Create(0L, 1L));
            var b = Vector128.Shuffle(this.vector, Vector128.Create(0L, 0L));
            return new(Vector256.Create(a, b));

        }
    }
    public double4 rgrg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector128.Shuffle(this.vector, Vector128.Create(0L, 1L));
            var b = Vector128.Shuffle(this.vector, Vector128.Create(0L, 1L));
            return new(Vector256.Create(a, b));

        }
    }
    public double4 rggr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector128.Shuffle(this.vector, Vector128.Create(0L, 1L));
            var b = Vector128.Shuffle(this.vector, Vector128.Create(1L, 0L));
            return new(Vector256.Create(a, b));

        }
    }
    public double4 rggg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector128.Shuffle(this.vector, Vector128.Create(0L, 1L));
            var b = Vector128.Shuffle(this.vector, Vector128.Create(1L, 1L));
            return new(Vector256.Create(a, b));

        }
    }
    public double4 grrr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector128.Shuffle(this.vector, Vector128.Create(1L, 0L));
            var b = Vector128.Shuffle(this.vector, Vector128.Create(0L, 0L));
            return new(Vector256.Create(a, b));

        }
    }
    public double4 grrg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector128.Shuffle(this.vector, Vector128.Create(1L, 0L));
            var b = Vector128.Shuffle(this.vector, Vector128.Create(0L, 1L));
            return new(Vector256.Create(a, b));

        }
    }
    public double4 grgr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector128.Shuffle(this.vector, Vector128.Create(1L, 0L));
            var b = Vector128.Shuffle(this.vector, Vector128.Create(1L, 0L));
            return new(Vector256.Create(a, b));

        }
    }
    public double4 grgg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector128.Shuffle(this.vector, Vector128.Create(1L, 0L));
            var b = Vector128.Shuffle(this.vector, Vector128.Create(1L, 1L));
            return new(Vector256.Create(a, b));

        }
    }
    public double4 ggrr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector128.Shuffle(this.vector, Vector128.Create(1L, 1L));
            var b = Vector128.Shuffle(this.vector, Vector128.Create(0L, 0L));
            return new(Vector256.Create(a, b));

        }
    }
    public double4 ggrg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector128.Shuffle(this.vector, Vector128.Create(1L, 1L));
            var b = Vector128.Shuffle(this.vector, Vector128.Create(0L, 1L));
            return new(Vector256.Create(a, b));

        }
    }
    public double4 gggr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector128.Shuffle(this.vector, Vector128.Create(1L, 1L));
            var b = Vector128.Shuffle(this.vector, Vector128.Create(1L, 0L));
            return new(Vector256.Create(a, b));

        }
    }
    public double4 gggg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector128.Shuffle(this.vector, Vector128.Create(1L, 1L));
            var b = Vector128.Shuffle(this.vector, Vector128.Create(1L, 1L));
            return new(Vector256.Create(a, b));

        }
    }


}
