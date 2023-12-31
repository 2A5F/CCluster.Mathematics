using System;
using System.Numerics;
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.X86;
using System.Runtime.Intrinsics.Arm;
using System.Runtime.CompilerServices;

#nullable enable
#pragma warning disable CS8981

namespace CCluster.Mathematics;

public partial struct long3 
{

    public long2 xx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(this.x, this.x);

        }
    }
    public long2 xy
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
    public long2 xz
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
    public long2 yx
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
    public long2 yy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(this.y, this.y);

        }
    }
    public long2 yz
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
    public long2 zx
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
    public long2 zy
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
    public long2 zz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(this.z, this.z);

        }
    }
    public long2 rr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(this.r, this.r);

        }
    }
    public long2 rg
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
    public long2 rb
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
    public long2 gr
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
    public long2 gg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(this.g, this.g);

        }
    }
    public long2 gb
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
    public long2 br
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
    public long2 bg
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
    public long2 bb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(this.b, this.b);

        }
    }
    public long3 xxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 0L, 0L, 0L)) & math.v3_iz_long256);

        }
    }
    public long3 xxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 0L, 1L, 0L)) & math.v3_iz_long256);

        }
    }
    public long3 xxz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 0L, 2L, 0L)) & math.v3_iz_long256);

        }
    }
    public long3 xyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 1L, 0L, 0L)) & math.v3_iz_long256);

        }
    }
    public long3 xyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 1L, 1L, 0L)) & math.v3_iz_long256);

        }
    }
    public long3 xyz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 1L, 2L, 0L)) & math.v3_iz_long256);

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.x = value.x; this.y = value.y; this.z = value.z; 
        }
    }
    public long3 xzx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 2L, 0L, 0L)) & math.v3_iz_long256);

        }
    }
    public long3 xzy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 2L, 1L, 0L)) & math.v3_iz_long256);

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.x = value.x; this.z = value.y; this.y = value.z; 
        }
    }
    public long3 xzz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 2L, 2L, 0L)) & math.v3_iz_long256);

        }
    }
    public long3 yxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 0L, 0L, 0L)) & math.v3_iz_long256);

        }
    }
    public long3 yxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 0L, 1L, 0L)) & math.v3_iz_long256);

        }
    }
    public long3 yxz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 0L, 2L, 0L)) & math.v3_iz_long256);

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.y = value.x; this.x = value.y; this.z = value.z; 
        }
    }
    public long3 yyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 1L, 0L, 0L)) & math.v3_iz_long256);

        }
    }
    public long3 yyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 1L, 1L, 0L)) & math.v3_iz_long256);

        }
    }
    public long3 yyz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 1L, 2L, 0L)) & math.v3_iz_long256);

        }
    }
    public long3 yzx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 2L, 0L, 0L)) & math.v3_iz_long256);

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.y = value.x; this.z = value.y; this.x = value.z; 
        }
    }
    public long3 yzy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 2L, 1L, 0L)) & math.v3_iz_long256);

        }
    }
    public long3 yzz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 2L, 2L, 0L)) & math.v3_iz_long256);

        }
    }
    public long3 zxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 0L, 0L, 0L)) & math.v3_iz_long256);

        }
    }
    public long3 zxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 0L, 1L, 0L)) & math.v3_iz_long256);

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.z = value.x; this.x = value.y; this.y = value.z; 
        }
    }
    public long3 zxz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 0L, 2L, 0L)) & math.v3_iz_long256);

        }
    }
    public long3 zyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 1L, 0L, 0L)) & math.v3_iz_long256);

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.z = value.x; this.y = value.y; this.x = value.z; 
        }
    }
    public long3 zyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 1L, 1L, 0L)) & math.v3_iz_long256);

        }
    }
    public long3 zyz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 1L, 2L, 0L)) & math.v3_iz_long256);

        }
    }
    public long3 zzx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 2L, 0L, 0L)) & math.v3_iz_long256);

        }
    }
    public long3 zzy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 2L, 1L, 0L)) & math.v3_iz_long256);

        }
    }
    public long3 zzz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 2L, 2L, 0L)) & math.v3_iz_long256);

        }
    }
    public long3 rrr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 0L, 0L, 0L)) & math.v3_iz_long256);

        }
    }
    public long3 rrg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 0L, 1L, 0L)) & math.v3_iz_long256);

        }
    }
    public long3 rrb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 0L, 2L, 0L)) & math.v3_iz_long256);

        }
    }
    public long3 rgr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 1L, 0L, 0L)) & math.v3_iz_long256);

        }
    }
    public long3 rgg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 1L, 1L, 0L)) & math.v3_iz_long256);

        }
    }
    public long3 rgb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 1L, 2L, 0L)) & math.v3_iz_long256);

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.r = value.x; this.g = value.y; this.b = value.z; 
        }
    }
    public long3 rbr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 2L, 0L, 0L)) & math.v3_iz_long256);

        }
    }
    public long3 rbg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 2L, 1L, 0L)) & math.v3_iz_long256);

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.r = value.x; this.b = value.y; this.g = value.z; 
        }
    }
    public long3 rbb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 2L, 2L, 0L)) & math.v3_iz_long256);

        }
    }
    public long3 grr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 0L, 0L, 0L)) & math.v3_iz_long256);

        }
    }
    public long3 grg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 0L, 1L, 0L)) & math.v3_iz_long256);

        }
    }
    public long3 grb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 0L, 2L, 0L)) & math.v3_iz_long256);

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.g = value.x; this.r = value.y; this.b = value.z; 
        }
    }
    public long3 ggr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 1L, 0L, 0L)) & math.v3_iz_long256);

        }
    }
    public long3 ggg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 1L, 1L, 0L)) & math.v3_iz_long256);

        }
    }
    public long3 ggb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 1L, 2L, 0L)) & math.v3_iz_long256);

        }
    }
    public long3 gbr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 2L, 0L, 0L)) & math.v3_iz_long256);

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.g = value.x; this.b = value.y; this.r = value.z; 
        }
    }
    public long3 gbg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 2L, 1L, 0L)) & math.v3_iz_long256);

        }
    }
    public long3 gbb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 2L, 2L, 0L)) & math.v3_iz_long256);

        }
    }
    public long3 brr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 0L, 0L, 0L)) & math.v3_iz_long256);

        }
    }
    public long3 brg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 0L, 1L, 0L)) & math.v3_iz_long256);

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.b = value.x; this.r = value.y; this.g = value.z; 
        }
    }
    public long3 brb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 0L, 2L, 0L)) & math.v3_iz_long256);

        }
    }
    public long3 bgr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 1L, 0L, 0L)) & math.v3_iz_long256);

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.b = value.x; this.g = value.y; this.r = value.z; 
        }
    }
    public long3 bgg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 1L, 1L, 0L)) & math.v3_iz_long256);

        }
    }
    public long3 bgb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 1L, 2L, 0L)) & math.v3_iz_long256);

        }
    }
    public long3 bbr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 2L, 0L, 0L)) & math.v3_iz_long256);

        }
    }
    public long3 bbg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 2L, 1L, 0L)) & math.v3_iz_long256);

        }
    }
    public long3 bbb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 2L, 2L, 0L)) & math.v3_iz_long256);

        }
    }
    public long4 xxxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 0L, 0L, 0L)));

        }
    }
    public long4 xxxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 0L, 0L, 1L)));

        }
    }
    public long4 xxxz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 0L, 0L, 2L)));

        }
    }
    public long4 xxyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 0L, 1L, 0L)));

        }
    }
    public long4 xxyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 0L, 1L, 1L)));

        }
    }
    public long4 xxyz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 0L, 1L, 2L)));

        }
    }
    public long4 xxzx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 0L, 2L, 0L)));

        }
    }
    public long4 xxzy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 0L, 2L, 1L)));

        }
    }
    public long4 xxzz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 0L, 2L, 2L)));

        }
    }
    public long4 xyxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 1L, 0L, 0L)));

        }
    }
    public long4 xyxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 1L, 0L, 1L)));

        }
    }
    public long4 xyxz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 1L, 0L, 2L)));

        }
    }
    public long4 xyyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 1L, 1L, 0L)));

        }
    }
    public long4 xyyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 1L, 1L, 1L)));

        }
    }
    public long4 xyyz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 1L, 1L, 2L)));

        }
    }
    public long4 xyzx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 1L, 2L, 0L)));

        }
    }
    public long4 xyzy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 1L, 2L, 1L)));

        }
    }
    public long4 xyzz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 1L, 2L, 2L)));

        }
    }
    public long4 xzxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 2L, 0L, 0L)));

        }
    }
    public long4 xzxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 2L, 0L, 1L)));

        }
    }
    public long4 xzxz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 2L, 0L, 2L)));

        }
    }
    public long4 xzyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 2L, 1L, 0L)));

        }
    }
    public long4 xzyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 2L, 1L, 1L)));

        }
    }
    public long4 xzyz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 2L, 1L, 2L)));

        }
    }
    public long4 xzzx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 2L, 2L, 0L)));

        }
    }
    public long4 xzzy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 2L, 2L, 1L)));

        }
    }
    public long4 xzzz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 2L, 2L, 2L)));

        }
    }
    public long4 yxxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 0L, 0L, 0L)));

        }
    }
    public long4 yxxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 0L, 0L, 1L)));

        }
    }
    public long4 yxxz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 0L, 0L, 2L)));

        }
    }
    public long4 yxyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 0L, 1L, 0L)));

        }
    }
    public long4 yxyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 0L, 1L, 1L)));

        }
    }
    public long4 yxyz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 0L, 1L, 2L)));

        }
    }
    public long4 yxzx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 0L, 2L, 0L)));

        }
    }
    public long4 yxzy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 0L, 2L, 1L)));

        }
    }
    public long4 yxzz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 0L, 2L, 2L)));

        }
    }
    public long4 yyxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 1L, 0L, 0L)));

        }
    }
    public long4 yyxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 1L, 0L, 1L)));

        }
    }
    public long4 yyxz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 1L, 0L, 2L)));

        }
    }
    public long4 yyyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 1L, 1L, 0L)));

        }
    }
    public long4 yyyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 1L, 1L, 1L)));

        }
    }
    public long4 yyyz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 1L, 1L, 2L)));

        }
    }
    public long4 yyzx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 1L, 2L, 0L)));

        }
    }
    public long4 yyzy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 1L, 2L, 1L)));

        }
    }
    public long4 yyzz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 1L, 2L, 2L)));

        }
    }
    public long4 yzxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 2L, 0L, 0L)));

        }
    }
    public long4 yzxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 2L, 0L, 1L)));

        }
    }
    public long4 yzxz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 2L, 0L, 2L)));

        }
    }
    public long4 yzyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 2L, 1L, 0L)));

        }
    }
    public long4 yzyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 2L, 1L, 1L)));

        }
    }
    public long4 yzyz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 2L, 1L, 2L)));

        }
    }
    public long4 yzzx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 2L, 2L, 0L)));

        }
    }
    public long4 yzzy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 2L, 2L, 1L)));

        }
    }
    public long4 yzzz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 2L, 2L, 2L)));

        }
    }
    public long4 zxxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 0L, 0L, 0L)));

        }
    }
    public long4 zxxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 0L, 0L, 1L)));

        }
    }
    public long4 zxxz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 0L, 0L, 2L)));

        }
    }
    public long4 zxyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 0L, 1L, 0L)));

        }
    }
    public long4 zxyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 0L, 1L, 1L)));

        }
    }
    public long4 zxyz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 0L, 1L, 2L)));

        }
    }
    public long4 zxzx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 0L, 2L, 0L)));

        }
    }
    public long4 zxzy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 0L, 2L, 1L)));

        }
    }
    public long4 zxzz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 0L, 2L, 2L)));

        }
    }
    public long4 zyxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 1L, 0L, 0L)));

        }
    }
    public long4 zyxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 1L, 0L, 1L)));

        }
    }
    public long4 zyxz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 1L, 0L, 2L)));

        }
    }
    public long4 zyyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 1L, 1L, 0L)));

        }
    }
    public long4 zyyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 1L, 1L, 1L)));

        }
    }
    public long4 zyyz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 1L, 1L, 2L)));

        }
    }
    public long4 zyzx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 1L, 2L, 0L)));

        }
    }
    public long4 zyzy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 1L, 2L, 1L)));

        }
    }
    public long4 zyzz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 1L, 2L, 2L)));

        }
    }
    public long4 zzxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 2L, 0L, 0L)));

        }
    }
    public long4 zzxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 2L, 0L, 1L)));

        }
    }
    public long4 zzxz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 2L, 0L, 2L)));

        }
    }
    public long4 zzyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 2L, 1L, 0L)));

        }
    }
    public long4 zzyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 2L, 1L, 1L)));

        }
    }
    public long4 zzyz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 2L, 1L, 2L)));

        }
    }
    public long4 zzzx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 2L, 2L, 0L)));

        }
    }
    public long4 zzzy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 2L, 2L, 1L)));

        }
    }
    public long4 zzzz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 2L, 2L, 2L)));

        }
    }
    public long4 rrrr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 0L, 0L, 0L)));

        }
    }
    public long4 rrrg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 0L, 0L, 1L)));

        }
    }
    public long4 rrrb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 0L, 0L, 2L)));

        }
    }
    public long4 rrgr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 0L, 1L, 0L)));

        }
    }
    public long4 rrgg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 0L, 1L, 1L)));

        }
    }
    public long4 rrgb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 0L, 1L, 2L)));

        }
    }
    public long4 rrbr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 0L, 2L, 0L)));

        }
    }
    public long4 rrbg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 0L, 2L, 1L)));

        }
    }
    public long4 rrbb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 0L, 2L, 2L)));

        }
    }
    public long4 rgrr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 1L, 0L, 0L)));

        }
    }
    public long4 rgrg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 1L, 0L, 1L)));

        }
    }
    public long4 rgrb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 1L, 0L, 2L)));

        }
    }
    public long4 rggr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 1L, 1L, 0L)));

        }
    }
    public long4 rggg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 1L, 1L, 1L)));

        }
    }
    public long4 rggb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 1L, 1L, 2L)));

        }
    }
    public long4 rgbr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 1L, 2L, 0L)));

        }
    }
    public long4 rgbg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 1L, 2L, 1L)));

        }
    }
    public long4 rgbb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 1L, 2L, 2L)));

        }
    }
    public long4 rbrr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 2L, 0L, 0L)));

        }
    }
    public long4 rbrg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 2L, 0L, 1L)));

        }
    }
    public long4 rbrb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 2L, 0L, 2L)));

        }
    }
    public long4 rbgr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 2L, 1L, 0L)));

        }
    }
    public long4 rbgg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 2L, 1L, 1L)));

        }
    }
    public long4 rbgb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 2L, 1L, 2L)));

        }
    }
    public long4 rbbr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 2L, 2L, 0L)));

        }
    }
    public long4 rbbg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 2L, 2L, 1L)));

        }
    }
    public long4 rbbb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 2L, 2L, 2L)));

        }
    }
    public long4 grrr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 0L, 0L, 0L)));

        }
    }
    public long4 grrg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 0L, 0L, 1L)));

        }
    }
    public long4 grrb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 0L, 0L, 2L)));

        }
    }
    public long4 grgr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 0L, 1L, 0L)));

        }
    }
    public long4 grgg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 0L, 1L, 1L)));

        }
    }
    public long4 grgb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 0L, 1L, 2L)));

        }
    }
    public long4 grbr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 0L, 2L, 0L)));

        }
    }
    public long4 grbg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 0L, 2L, 1L)));

        }
    }
    public long4 grbb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 0L, 2L, 2L)));

        }
    }
    public long4 ggrr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 1L, 0L, 0L)));

        }
    }
    public long4 ggrg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 1L, 0L, 1L)));

        }
    }
    public long4 ggrb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 1L, 0L, 2L)));

        }
    }
    public long4 gggr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 1L, 1L, 0L)));

        }
    }
    public long4 gggg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 1L, 1L, 1L)));

        }
    }
    public long4 gggb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 1L, 1L, 2L)));

        }
    }
    public long4 ggbr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 1L, 2L, 0L)));

        }
    }
    public long4 ggbg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 1L, 2L, 1L)));

        }
    }
    public long4 ggbb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 1L, 2L, 2L)));

        }
    }
    public long4 gbrr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 2L, 0L, 0L)));

        }
    }
    public long4 gbrg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 2L, 0L, 1L)));

        }
    }
    public long4 gbrb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 2L, 0L, 2L)));

        }
    }
    public long4 gbgr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 2L, 1L, 0L)));

        }
    }
    public long4 gbgg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 2L, 1L, 1L)));

        }
    }
    public long4 gbgb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 2L, 1L, 2L)));

        }
    }
    public long4 gbbr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 2L, 2L, 0L)));

        }
    }
    public long4 gbbg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 2L, 2L, 1L)));

        }
    }
    public long4 gbbb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 2L, 2L, 2L)));

        }
    }
    public long4 brrr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 0L, 0L, 0L)));

        }
    }
    public long4 brrg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 0L, 0L, 1L)));

        }
    }
    public long4 brrb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 0L, 0L, 2L)));

        }
    }
    public long4 brgr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 0L, 1L, 0L)));

        }
    }
    public long4 brgg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 0L, 1L, 1L)));

        }
    }
    public long4 brgb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 0L, 1L, 2L)));

        }
    }
    public long4 brbr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 0L, 2L, 0L)));

        }
    }
    public long4 brbg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 0L, 2L, 1L)));

        }
    }
    public long4 brbb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 0L, 2L, 2L)));

        }
    }
    public long4 bgrr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 1L, 0L, 0L)));

        }
    }
    public long4 bgrg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 1L, 0L, 1L)));

        }
    }
    public long4 bgrb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 1L, 0L, 2L)));

        }
    }
    public long4 bggr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 1L, 1L, 0L)));

        }
    }
    public long4 bggg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 1L, 1L, 1L)));

        }
    }
    public long4 bggb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 1L, 1L, 2L)));

        }
    }
    public long4 bgbr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 1L, 2L, 0L)));

        }
    }
    public long4 bgbg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 1L, 2L, 1L)));

        }
    }
    public long4 bgbb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 1L, 2L, 2L)));

        }
    }
    public long4 bbrr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 2L, 0L, 0L)));

        }
    }
    public long4 bbrg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 2L, 0L, 1L)));

        }
    }
    public long4 bbrb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 2L, 0L, 2L)));

        }
    }
    public long4 bbgr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 2L, 1L, 0L)));

        }
    }
    public long4 bbgg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 2L, 1L, 1L)));

        }
    }
    public long4 bbgb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 2L, 1L, 2L)));

        }
    }
    public long4 bbbr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 2L, 2L, 0L)));

        }
    }
    public long4 bbbg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 2L, 2L, 1L)));

        }
    }
    public long4 bbbb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 2L, 2L, 2L)));

        }
    }


}
