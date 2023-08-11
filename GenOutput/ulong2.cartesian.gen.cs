using System;
using System.Numerics;
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.X86;
using System.Runtime.Intrinsics.Arm;
using System.Runtime.CompilerServices;

#nullable enable
#pragma warning disable CS8981

namespace CCluster.Mathematics;

public partial struct ulong2 
{

    public ulong2 xx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(0UL, 0UL)));

        }
    }
    public ulong2 xy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(0UL, 1UL)));

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.x = value.x; this.y = value.y; 
        }
    }
    public ulong2 yx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(1UL, 0UL)));

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.y = value.x; this.x = value.y; 
        }
    }
    public ulong2 yy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(1UL, 1UL)));

        }
    }
    public ulong2 rr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(0UL, 0UL)));

        }
    }
    public ulong2 rg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(0UL, 1UL)));

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.r = value.x; this.g = value.y; 
        }
    }
    public ulong2 gr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(1UL, 0UL)));

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.g = value.x; this.r = value.y; 
        }
    }
    public ulong2 gg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(1UL, 1UL)));

        }
    }
    public ulong3 xxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            var a = Vector128.Shuffle(this.vector, Vector128.Create(0UL, 0UL));
            var b = Vector128.Shuffle(this.vector, Vector128.Create(0UL, 0UL));
            return new(Vector256.Create(a, b) & math.v3_iz_ulong256);

        }
    }
    public ulong3 xxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            var a = Vector128.Shuffle(this.vector, Vector128.Create(0UL, 0UL));
            var b = Vector128.Shuffle(this.vector, Vector128.Create(1UL, 0UL));
            return new(Vector256.Create(a, b) & math.v3_iz_ulong256);

        }
    }
    public ulong3 xyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            var a = Vector128.Shuffle(this.vector, Vector128.Create(0UL, 1UL));
            var b = Vector128.Shuffle(this.vector, Vector128.Create(0UL, 0UL));
            return new(Vector256.Create(a, b) & math.v3_iz_ulong256);

        }
    }
    public ulong3 xyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            var a = Vector128.Shuffle(this.vector, Vector128.Create(0UL, 1UL));
            var b = Vector128.Shuffle(this.vector, Vector128.Create(1UL, 0UL));
            return new(Vector256.Create(a, b) & math.v3_iz_ulong256);

        }
    }
    public ulong3 yxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            var a = Vector128.Shuffle(this.vector, Vector128.Create(1UL, 0UL));
            var b = Vector128.Shuffle(this.vector, Vector128.Create(0UL, 0UL));
            return new(Vector256.Create(a, b) & math.v3_iz_ulong256);

        }
    }
    public ulong3 yxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            var a = Vector128.Shuffle(this.vector, Vector128.Create(1UL, 0UL));
            var b = Vector128.Shuffle(this.vector, Vector128.Create(1UL, 0UL));
            return new(Vector256.Create(a, b) & math.v3_iz_ulong256);

        }
    }
    public ulong3 yyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            var a = Vector128.Shuffle(this.vector, Vector128.Create(1UL, 1UL));
            var b = Vector128.Shuffle(this.vector, Vector128.Create(0UL, 0UL));
            return new(Vector256.Create(a, b) & math.v3_iz_ulong256);

        }
    }
    public ulong3 yyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            var a = Vector128.Shuffle(this.vector, Vector128.Create(1UL, 1UL));
            var b = Vector128.Shuffle(this.vector, Vector128.Create(1UL, 0UL));
            return new(Vector256.Create(a, b) & math.v3_iz_ulong256);

        }
    }
    public ulong3 rrr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            var a = Vector128.Shuffle(this.vector, Vector128.Create(0UL, 0UL));
            var b = Vector128.Shuffle(this.vector, Vector128.Create(0UL, 0UL));
            return new(Vector256.Create(a, b) & math.v3_iz_ulong256);

        }
    }
    public ulong3 rrg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            var a = Vector128.Shuffle(this.vector, Vector128.Create(0UL, 0UL));
            var b = Vector128.Shuffle(this.vector, Vector128.Create(1UL, 0UL));
            return new(Vector256.Create(a, b) & math.v3_iz_ulong256);

        }
    }
    public ulong3 rgr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            var a = Vector128.Shuffle(this.vector, Vector128.Create(0UL, 1UL));
            var b = Vector128.Shuffle(this.vector, Vector128.Create(0UL, 0UL));
            return new(Vector256.Create(a, b) & math.v3_iz_ulong256);

        }
    }
    public ulong3 rgg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            var a = Vector128.Shuffle(this.vector, Vector128.Create(0UL, 1UL));
            var b = Vector128.Shuffle(this.vector, Vector128.Create(1UL, 0UL));
            return new(Vector256.Create(a, b) & math.v3_iz_ulong256);

        }
    }
    public ulong3 grr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            var a = Vector128.Shuffle(this.vector, Vector128.Create(1UL, 0UL));
            var b = Vector128.Shuffle(this.vector, Vector128.Create(0UL, 0UL));
            return new(Vector256.Create(a, b) & math.v3_iz_ulong256);

        }
    }
    public ulong3 grg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            var a = Vector128.Shuffle(this.vector, Vector128.Create(1UL, 0UL));
            var b = Vector128.Shuffle(this.vector, Vector128.Create(1UL, 0UL));
            return new(Vector256.Create(a, b) & math.v3_iz_ulong256);

        }
    }
    public ulong3 ggr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            var a = Vector128.Shuffle(this.vector, Vector128.Create(1UL, 1UL));
            var b = Vector128.Shuffle(this.vector, Vector128.Create(0UL, 0UL));
            return new(Vector256.Create(a, b) & math.v3_iz_ulong256);

        }
    }
    public ulong3 ggg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            var a = Vector128.Shuffle(this.vector, Vector128.Create(1UL, 1UL));
            var b = Vector128.Shuffle(this.vector, Vector128.Create(1UL, 0UL));
            return new(Vector256.Create(a, b) & math.v3_iz_ulong256);

        }
    }
    public ulong4 xxxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector128.Shuffle(this.vector, Vector128.Create(0UL, 0UL));
            var b = Vector128.Shuffle(this.vector, Vector128.Create(0UL, 0UL));
            return new(Vector256.Create(a, b));

        }
    }
    public ulong4 xxxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector128.Shuffle(this.vector, Vector128.Create(0UL, 0UL));
            var b = Vector128.Shuffle(this.vector, Vector128.Create(0UL, 1UL));
            return new(Vector256.Create(a, b));

        }
    }
    public ulong4 xxyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector128.Shuffle(this.vector, Vector128.Create(0UL, 0UL));
            var b = Vector128.Shuffle(this.vector, Vector128.Create(1UL, 0UL));
            return new(Vector256.Create(a, b));

        }
    }
    public ulong4 xxyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector128.Shuffle(this.vector, Vector128.Create(0UL, 0UL));
            var b = Vector128.Shuffle(this.vector, Vector128.Create(1UL, 1UL));
            return new(Vector256.Create(a, b));

        }
    }
    public ulong4 xyxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector128.Shuffle(this.vector, Vector128.Create(0UL, 1UL));
            var b = Vector128.Shuffle(this.vector, Vector128.Create(0UL, 0UL));
            return new(Vector256.Create(a, b));

        }
    }
    public ulong4 xyxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector128.Shuffle(this.vector, Vector128.Create(0UL, 1UL));
            var b = Vector128.Shuffle(this.vector, Vector128.Create(0UL, 1UL));
            return new(Vector256.Create(a, b));

        }
    }
    public ulong4 xyyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector128.Shuffle(this.vector, Vector128.Create(0UL, 1UL));
            var b = Vector128.Shuffle(this.vector, Vector128.Create(1UL, 0UL));
            return new(Vector256.Create(a, b));

        }
    }
    public ulong4 xyyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector128.Shuffle(this.vector, Vector128.Create(0UL, 1UL));
            var b = Vector128.Shuffle(this.vector, Vector128.Create(1UL, 1UL));
            return new(Vector256.Create(a, b));

        }
    }
    public ulong4 yxxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector128.Shuffle(this.vector, Vector128.Create(1UL, 0UL));
            var b = Vector128.Shuffle(this.vector, Vector128.Create(0UL, 0UL));
            return new(Vector256.Create(a, b));

        }
    }
    public ulong4 yxxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector128.Shuffle(this.vector, Vector128.Create(1UL, 0UL));
            var b = Vector128.Shuffle(this.vector, Vector128.Create(0UL, 1UL));
            return new(Vector256.Create(a, b));

        }
    }
    public ulong4 yxyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector128.Shuffle(this.vector, Vector128.Create(1UL, 0UL));
            var b = Vector128.Shuffle(this.vector, Vector128.Create(1UL, 0UL));
            return new(Vector256.Create(a, b));

        }
    }
    public ulong4 yxyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector128.Shuffle(this.vector, Vector128.Create(1UL, 0UL));
            var b = Vector128.Shuffle(this.vector, Vector128.Create(1UL, 1UL));
            return new(Vector256.Create(a, b));

        }
    }
    public ulong4 yyxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector128.Shuffle(this.vector, Vector128.Create(1UL, 1UL));
            var b = Vector128.Shuffle(this.vector, Vector128.Create(0UL, 0UL));
            return new(Vector256.Create(a, b));

        }
    }
    public ulong4 yyxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector128.Shuffle(this.vector, Vector128.Create(1UL, 1UL));
            var b = Vector128.Shuffle(this.vector, Vector128.Create(0UL, 1UL));
            return new(Vector256.Create(a, b));

        }
    }
    public ulong4 yyyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector128.Shuffle(this.vector, Vector128.Create(1UL, 1UL));
            var b = Vector128.Shuffle(this.vector, Vector128.Create(1UL, 0UL));
            return new(Vector256.Create(a, b));

        }
    }
    public ulong4 yyyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector128.Shuffle(this.vector, Vector128.Create(1UL, 1UL));
            var b = Vector128.Shuffle(this.vector, Vector128.Create(1UL, 1UL));
            return new(Vector256.Create(a, b));

        }
    }
    public ulong4 rrrr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector128.Shuffle(this.vector, Vector128.Create(0UL, 0UL));
            var b = Vector128.Shuffle(this.vector, Vector128.Create(0UL, 0UL));
            return new(Vector256.Create(a, b));

        }
    }
    public ulong4 rrrg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector128.Shuffle(this.vector, Vector128.Create(0UL, 0UL));
            var b = Vector128.Shuffle(this.vector, Vector128.Create(0UL, 1UL));
            return new(Vector256.Create(a, b));

        }
    }
    public ulong4 rrgr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector128.Shuffle(this.vector, Vector128.Create(0UL, 0UL));
            var b = Vector128.Shuffle(this.vector, Vector128.Create(1UL, 0UL));
            return new(Vector256.Create(a, b));

        }
    }
    public ulong4 rrgg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector128.Shuffle(this.vector, Vector128.Create(0UL, 0UL));
            var b = Vector128.Shuffle(this.vector, Vector128.Create(1UL, 1UL));
            return new(Vector256.Create(a, b));

        }
    }
    public ulong4 rgrr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector128.Shuffle(this.vector, Vector128.Create(0UL, 1UL));
            var b = Vector128.Shuffle(this.vector, Vector128.Create(0UL, 0UL));
            return new(Vector256.Create(a, b));

        }
    }
    public ulong4 rgrg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector128.Shuffle(this.vector, Vector128.Create(0UL, 1UL));
            var b = Vector128.Shuffle(this.vector, Vector128.Create(0UL, 1UL));
            return new(Vector256.Create(a, b));

        }
    }
    public ulong4 rggr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector128.Shuffle(this.vector, Vector128.Create(0UL, 1UL));
            var b = Vector128.Shuffle(this.vector, Vector128.Create(1UL, 0UL));
            return new(Vector256.Create(a, b));

        }
    }
    public ulong4 rggg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector128.Shuffle(this.vector, Vector128.Create(0UL, 1UL));
            var b = Vector128.Shuffle(this.vector, Vector128.Create(1UL, 1UL));
            return new(Vector256.Create(a, b));

        }
    }
    public ulong4 grrr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector128.Shuffle(this.vector, Vector128.Create(1UL, 0UL));
            var b = Vector128.Shuffle(this.vector, Vector128.Create(0UL, 0UL));
            return new(Vector256.Create(a, b));

        }
    }
    public ulong4 grrg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector128.Shuffle(this.vector, Vector128.Create(1UL, 0UL));
            var b = Vector128.Shuffle(this.vector, Vector128.Create(0UL, 1UL));
            return new(Vector256.Create(a, b));

        }
    }
    public ulong4 grgr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector128.Shuffle(this.vector, Vector128.Create(1UL, 0UL));
            var b = Vector128.Shuffle(this.vector, Vector128.Create(1UL, 0UL));
            return new(Vector256.Create(a, b));

        }
    }
    public ulong4 grgg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector128.Shuffle(this.vector, Vector128.Create(1UL, 0UL));
            var b = Vector128.Shuffle(this.vector, Vector128.Create(1UL, 1UL));
            return new(Vector256.Create(a, b));

        }
    }
    public ulong4 ggrr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector128.Shuffle(this.vector, Vector128.Create(1UL, 1UL));
            var b = Vector128.Shuffle(this.vector, Vector128.Create(0UL, 0UL));
            return new(Vector256.Create(a, b));

        }
    }
    public ulong4 ggrg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector128.Shuffle(this.vector, Vector128.Create(1UL, 1UL));
            var b = Vector128.Shuffle(this.vector, Vector128.Create(0UL, 1UL));
            return new(Vector256.Create(a, b));

        }
    }
    public ulong4 gggr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector128.Shuffle(this.vector, Vector128.Create(1UL, 1UL));
            var b = Vector128.Shuffle(this.vector, Vector128.Create(1UL, 0UL));
            return new(Vector256.Create(a, b));

        }
    }
    public ulong4 gggg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector128.Shuffle(this.vector, Vector128.Create(1UL, 1UL));
            var b = Vector128.Shuffle(this.vector, Vector128.Create(1UL, 1UL));
            return new(Vector256.Create(a, b));

        }
    }


}
