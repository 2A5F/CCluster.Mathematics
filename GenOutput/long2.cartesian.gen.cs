using System;
using System.Numerics;
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.X86;
using System.Runtime.Intrinsics.Arm;
using System.Runtime.CompilerServices;

#nullable enable
#pragma warning disable CS8981

namespace CCluster.Mathematics;

public partial struct long2 
{

    public long2 xx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(0L, 0L)));

        }
    }
    public long2 xy
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
    public long2 yx
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
    public long2 yy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(1L, 1L)));

        }
    }
    public long2 rr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(0L, 0L)));

        }
    }
    public long2 rg
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
    public long2 gr
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
    public long2 gg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(1L, 1L)));

        }
    }
    public long3 xxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            var a = Vector128.Shuffle(this.vector, Vector128.Create(0L, 0L));
            var b = Vector128.Shuffle(this.vector, Vector128.Create(0L, 0L));
            return new(Vector256.Create(a, b) & math.v3_iz_long256);

        }
    }
    public long3 xxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            var a = Vector128.Shuffle(this.vector, Vector128.Create(0L, 0L));
            var b = Vector128.Shuffle(this.vector, Vector128.Create(1L, 0L));
            return new(Vector256.Create(a, b) & math.v3_iz_long256);

        }
    }
    public long3 xyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            var a = Vector128.Shuffle(this.vector, Vector128.Create(0L, 1L));
            var b = Vector128.Shuffle(this.vector, Vector128.Create(0L, 0L));
            return new(Vector256.Create(a, b) & math.v3_iz_long256);

        }
    }
    public long3 xyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            var a = Vector128.Shuffle(this.vector, Vector128.Create(0L, 1L));
            var b = Vector128.Shuffle(this.vector, Vector128.Create(1L, 0L));
            return new(Vector256.Create(a, b) & math.v3_iz_long256);

        }
    }
    public long3 yxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            var a = Vector128.Shuffle(this.vector, Vector128.Create(1L, 0L));
            var b = Vector128.Shuffle(this.vector, Vector128.Create(0L, 0L));
            return new(Vector256.Create(a, b) & math.v3_iz_long256);

        }
    }
    public long3 yxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            var a = Vector128.Shuffle(this.vector, Vector128.Create(1L, 0L));
            var b = Vector128.Shuffle(this.vector, Vector128.Create(1L, 0L));
            return new(Vector256.Create(a, b) & math.v3_iz_long256);

        }
    }
    public long3 yyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            var a = Vector128.Shuffle(this.vector, Vector128.Create(1L, 1L));
            var b = Vector128.Shuffle(this.vector, Vector128.Create(0L, 0L));
            return new(Vector256.Create(a, b) & math.v3_iz_long256);

        }
    }
    public long3 yyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            var a = Vector128.Shuffle(this.vector, Vector128.Create(1L, 1L));
            var b = Vector128.Shuffle(this.vector, Vector128.Create(1L, 0L));
            return new(Vector256.Create(a, b) & math.v3_iz_long256);

        }
    }
    public long3 rrr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            var a = Vector128.Shuffle(this.vector, Vector128.Create(0L, 0L));
            var b = Vector128.Shuffle(this.vector, Vector128.Create(0L, 0L));
            return new(Vector256.Create(a, b) & math.v3_iz_long256);

        }
    }
    public long3 rrg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            var a = Vector128.Shuffle(this.vector, Vector128.Create(0L, 0L));
            var b = Vector128.Shuffle(this.vector, Vector128.Create(1L, 0L));
            return new(Vector256.Create(a, b) & math.v3_iz_long256);

        }
    }
    public long3 rgr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            var a = Vector128.Shuffle(this.vector, Vector128.Create(0L, 1L));
            var b = Vector128.Shuffle(this.vector, Vector128.Create(0L, 0L));
            return new(Vector256.Create(a, b) & math.v3_iz_long256);

        }
    }
    public long3 rgg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            var a = Vector128.Shuffle(this.vector, Vector128.Create(0L, 1L));
            var b = Vector128.Shuffle(this.vector, Vector128.Create(1L, 0L));
            return new(Vector256.Create(a, b) & math.v3_iz_long256);

        }
    }
    public long3 grr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            var a = Vector128.Shuffle(this.vector, Vector128.Create(1L, 0L));
            var b = Vector128.Shuffle(this.vector, Vector128.Create(0L, 0L));
            return new(Vector256.Create(a, b) & math.v3_iz_long256);

        }
    }
    public long3 grg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            var a = Vector128.Shuffle(this.vector, Vector128.Create(1L, 0L));
            var b = Vector128.Shuffle(this.vector, Vector128.Create(1L, 0L));
            return new(Vector256.Create(a, b) & math.v3_iz_long256);

        }
    }
    public long3 ggr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            var a = Vector128.Shuffle(this.vector, Vector128.Create(1L, 1L));
            var b = Vector128.Shuffle(this.vector, Vector128.Create(0L, 0L));
            return new(Vector256.Create(a, b) & math.v3_iz_long256);

        }
    }
    public long3 ggg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            var a = Vector128.Shuffle(this.vector, Vector128.Create(1L, 1L));
            var b = Vector128.Shuffle(this.vector, Vector128.Create(1L, 0L));
            return new(Vector256.Create(a, b) & math.v3_iz_long256);

        }
    }
    public long4 xxxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector128.Shuffle(this.vector, Vector128.Create(0L, 0L));
            var b = Vector128.Shuffle(this.vector, Vector128.Create(0L, 0L));
            return new(Vector256.Create(a, b));

        }
    }
    public long4 xxxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector128.Shuffle(this.vector, Vector128.Create(0L, 0L));
            var b = Vector128.Shuffle(this.vector, Vector128.Create(0L, 1L));
            return new(Vector256.Create(a, b));

        }
    }
    public long4 xxyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector128.Shuffle(this.vector, Vector128.Create(0L, 0L));
            var b = Vector128.Shuffle(this.vector, Vector128.Create(1L, 0L));
            return new(Vector256.Create(a, b));

        }
    }
    public long4 xxyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector128.Shuffle(this.vector, Vector128.Create(0L, 0L));
            var b = Vector128.Shuffle(this.vector, Vector128.Create(1L, 1L));
            return new(Vector256.Create(a, b));

        }
    }
    public long4 xyxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector128.Shuffle(this.vector, Vector128.Create(0L, 1L));
            var b = Vector128.Shuffle(this.vector, Vector128.Create(0L, 0L));
            return new(Vector256.Create(a, b));

        }
    }
    public long4 xyxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector128.Shuffle(this.vector, Vector128.Create(0L, 1L));
            var b = Vector128.Shuffle(this.vector, Vector128.Create(0L, 1L));
            return new(Vector256.Create(a, b));

        }
    }
    public long4 xyyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector128.Shuffle(this.vector, Vector128.Create(0L, 1L));
            var b = Vector128.Shuffle(this.vector, Vector128.Create(1L, 0L));
            return new(Vector256.Create(a, b));

        }
    }
    public long4 xyyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector128.Shuffle(this.vector, Vector128.Create(0L, 1L));
            var b = Vector128.Shuffle(this.vector, Vector128.Create(1L, 1L));
            return new(Vector256.Create(a, b));

        }
    }
    public long4 yxxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector128.Shuffle(this.vector, Vector128.Create(1L, 0L));
            var b = Vector128.Shuffle(this.vector, Vector128.Create(0L, 0L));
            return new(Vector256.Create(a, b));

        }
    }
    public long4 yxxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector128.Shuffle(this.vector, Vector128.Create(1L, 0L));
            var b = Vector128.Shuffle(this.vector, Vector128.Create(0L, 1L));
            return new(Vector256.Create(a, b));

        }
    }
    public long4 yxyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector128.Shuffle(this.vector, Vector128.Create(1L, 0L));
            var b = Vector128.Shuffle(this.vector, Vector128.Create(1L, 0L));
            return new(Vector256.Create(a, b));

        }
    }
    public long4 yxyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector128.Shuffle(this.vector, Vector128.Create(1L, 0L));
            var b = Vector128.Shuffle(this.vector, Vector128.Create(1L, 1L));
            return new(Vector256.Create(a, b));

        }
    }
    public long4 yyxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector128.Shuffle(this.vector, Vector128.Create(1L, 1L));
            var b = Vector128.Shuffle(this.vector, Vector128.Create(0L, 0L));
            return new(Vector256.Create(a, b));

        }
    }
    public long4 yyxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector128.Shuffle(this.vector, Vector128.Create(1L, 1L));
            var b = Vector128.Shuffle(this.vector, Vector128.Create(0L, 1L));
            return new(Vector256.Create(a, b));

        }
    }
    public long4 yyyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector128.Shuffle(this.vector, Vector128.Create(1L, 1L));
            var b = Vector128.Shuffle(this.vector, Vector128.Create(1L, 0L));
            return new(Vector256.Create(a, b));

        }
    }
    public long4 yyyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector128.Shuffle(this.vector, Vector128.Create(1L, 1L));
            var b = Vector128.Shuffle(this.vector, Vector128.Create(1L, 1L));
            return new(Vector256.Create(a, b));

        }
    }
    public long4 rrrr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector128.Shuffle(this.vector, Vector128.Create(0L, 0L));
            var b = Vector128.Shuffle(this.vector, Vector128.Create(0L, 0L));
            return new(Vector256.Create(a, b));

        }
    }
    public long4 rrrg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector128.Shuffle(this.vector, Vector128.Create(0L, 0L));
            var b = Vector128.Shuffle(this.vector, Vector128.Create(0L, 1L));
            return new(Vector256.Create(a, b));

        }
    }
    public long4 rrgr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector128.Shuffle(this.vector, Vector128.Create(0L, 0L));
            var b = Vector128.Shuffle(this.vector, Vector128.Create(1L, 0L));
            return new(Vector256.Create(a, b));

        }
    }
    public long4 rrgg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector128.Shuffle(this.vector, Vector128.Create(0L, 0L));
            var b = Vector128.Shuffle(this.vector, Vector128.Create(1L, 1L));
            return new(Vector256.Create(a, b));

        }
    }
    public long4 rgrr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector128.Shuffle(this.vector, Vector128.Create(0L, 1L));
            var b = Vector128.Shuffle(this.vector, Vector128.Create(0L, 0L));
            return new(Vector256.Create(a, b));

        }
    }
    public long4 rgrg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector128.Shuffle(this.vector, Vector128.Create(0L, 1L));
            var b = Vector128.Shuffle(this.vector, Vector128.Create(0L, 1L));
            return new(Vector256.Create(a, b));

        }
    }
    public long4 rggr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector128.Shuffle(this.vector, Vector128.Create(0L, 1L));
            var b = Vector128.Shuffle(this.vector, Vector128.Create(1L, 0L));
            return new(Vector256.Create(a, b));

        }
    }
    public long4 rggg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector128.Shuffle(this.vector, Vector128.Create(0L, 1L));
            var b = Vector128.Shuffle(this.vector, Vector128.Create(1L, 1L));
            return new(Vector256.Create(a, b));

        }
    }
    public long4 grrr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector128.Shuffle(this.vector, Vector128.Create(1L, 0L));
            var b = Vector128.Shuffle(this.vector, Vector128.Create(0L, 0L));
            return new(Vector256.Create(a, b));

        }
    }
    public long4 grrg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector128.Shuffle(this.vector, Vector128.Create(1L, 0L));
            var b = Vector128.Shuffle(this.vector, Vector128.Create(0L, 1L));
            return new(Vector256.Create(a, b));

        }
    }
    public long4 grgr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector128.Shuffle(this.vector, Vector128.Create(1L, 0L));
            var b = Vector128.Shuffle(this.vector, Vector128.Create(1L, 0L));
            return new(Vector256.Create(a, b));

        }
    }
    public long4 grgg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector128.Shuffle(this.vector, Vector128.Create(1L, 0L));
            var b = Vector128.Shuffle(this.vector, Vector128.Create(1L, 1L));
            return new(Vector256.Create(a, b));

        }
    }
    public long4 ggrr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector128.Shuffle(this.vector, Vector128.Create(1L, 1L));
            var b = Vector128.Shuffle(this.vector, Vector128.Create(0L, 0L));
            return new(Vector256.Create(a, b));

        }
    }
    public long4 ggrg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector128.Shuffle(this.vector, Vector128.Create(1L, 1L));
            var b = Vector128.Shuffle(this.vector, Vector128.Create(0L, 1L));
            return new(Vector256.Create(a, b));

        }
    }
    public long4 gggr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector128.Shuffle(this.vector, Vector128.Create(1L, 1L));
            var b = Vector128.Shuffle(this.vector, Vector128.Create(1L, 0L));
            return new(Vector256.Create(a, b));

        }
    }
    public long4 gggg
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
