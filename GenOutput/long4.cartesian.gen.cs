using System;
using System.Numerics;
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.X86;
using System.Runtime.Intrinsics.Arm;
using System.Runtime.CompilerServices;

#nullable enable
#pragma warning disable CS8981

namespace CCluster.Mathematics;

public partial struct long4 
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
    public long2 xw
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
    public long2 yw
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
    public long2 zw
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
    public long2 wx
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
    public long2 wy
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
    public long2 wz
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
    public long2 ww
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(this.w, this.w);

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
    public long2 ra
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
    public long2 ga
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
    public long2 ba
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
    public long2 ar
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
    public long2 ag
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
    public long2 ab
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
    public long2 aa
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(this.a, this.a);

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
    public long3 xxw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 0L, 3L, 0L)) & math.v3_iz_long256);

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
    public long3 xyw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 1L, 3L, 0L)) & math.v3_iz_long256);

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.x = value.x; this.y = value.y; this.w = value.z; 
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
    public long3 xzw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 2L, 3L, 0L)) & math.v3_iz_long256);

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.x = value.x; this.z = value.y; this.w = value.z; 
        }
    }
    public long3 xwx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 3L, 0L, 0L)) & math.v3_iz_long256);

        }
    }
    public long3 xwy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 3L, 1L, 0L)) & math.v3_iz_long256);

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.x = value.x; this.w = value.y; this.y = value.z; 
        }
    }
    public long3 xwz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 3L, 2L, 0L)) & math.v3_iz_long256);

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.x = value.x; this.w = value.y; this.z = value.z; 
        }
    }
    public long3 xww
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 3L, 3L, 0L)) & math.v3_iz_long256);

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
    public long3 yxw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 0L, 3L, 0L)) & math.v3_iz_long256);

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.y = value.x; this.x = value.y; this.w = value.z; 
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
    public long3 yyw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 1L, 3L, 0L)) & math.v3_iz_long256);

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
    public long3 yzw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 2L, 3L, 0L)) & math.v3_iz_long256);

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.y = value.x; this.z = value.y; this.w = value.z; 
        }
    }
    public long3 ywx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 3L, 0L, 0L)) & math.v3_iz_long256);

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.y = value.x; this.w = value.y; this.x = value.z; 
        }
    }
    public long3 ywy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 3L, 1L, 0L)) & math.v3_iz_long256);

        }
    }
    public long3 ywz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 3L, 2L, 0L)) & math.v3_iz_long256);

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.y = value.x; this.w = value.y; this.z = value.z; 
        }
    }
    public long3 yww
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 3L, 3L, 0L)) & math.v3_iz_long256);

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
    public long3 zxw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 0L, 3L, 0L)) & math.v3_iz_long256);

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.z = value.x; this.x = value.y; this.w = value.z; 
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
    public long3 zyw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 1L, 3L, 0L)) & math.v3_iz_long256);

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.z = value.x; this.y = value.y; this.w = value.z; 
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
    public long3 zzw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 2L, 3L, 0L)) & math.v3_iz_long256);

        }
    }
    public long3 zwx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 3L, 0L, 0L)) & math.v3_iz_long256);

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.z = value.x; this.w = value.y; this.x = value.z; 
        }
    }
    public long3 zwy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 3L, 1L, 0L)) & math.v3_iz_long256);

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.z = value.x; this.w = value.y; this.y = value.z; 
        }
    }
    public long3 zwz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 3L, 2L, 0L)) & math.v3_iz_long256);

        }
    }
    public long3 zww
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 3L, 3L, 0L)) & math.v3_iz_long256);

        }
    }
    public long3 wxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 0L, 0L, 0L)) & math.v3_iz_long256);

        }
    }
    public long3 wxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 0L, 1L, 0L)) & math.v3_iz_long256);

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.w = value.x; this.x = value.y; this.y = value.z; 
        }
    }
    public long3 wxz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 0L, 2L, 0L)) & math.v3_iz_long256);

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.w = value.x; this.x = value.y; this.z = value.z; 
        }
    }
    public long3 wxw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 0L, 3L, 0L)) & math.v3_iz_long256);

        }
    }
    public long3 wyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 1L, 0L, 0L)) & math.v3_iz_long256);

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.w = value.x; this.y = value.y; this.x = value.z; 
        }
    }
    public long3 wyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 1L, 1L, 0L)) & math.v3_iz_long256);

        }
    }
    public long3 wyz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 1L, 2L, 0L)) & math.v3_iz_long256);

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.w = value.x; this.y = value.y; this.z = value.z; 
        }
    }
    public long3 wyw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 1L, 3L, 0L)) & math.v3_iz_long256);

        }
    }
    public long3 wzx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 2L, 0L, 0L)) & math.v3_iz_long256);

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.w = value.x; this.z = value.y; this.x = value.z; 
        }
    }
    public long3 wzy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 2L, 1L, 0L)) & math.v3_iz_long256);

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.w = value.x; this.z = value.y; this.y = value.z; 
        }
    }
    public long3 wzz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 2L, 2L, 0L)) & math.v3_iz_long256);

        }
    }
    public long3 wzw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 2L, 3L, 0L)) & math.v3_iz_long256);

        }
    }
    public long3 wwx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 3L, 0L, 0L)) & math.v3_iz_long256);

        }
    }
    public long3 wwy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 3L, 1L, 0L)) & math.v3_iz_long256);

        }
    }
    public long3 wwz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 3L, 2L, 0L)) & math.v3_iz_long256);

        }
    }
    public long3 www
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 3L, 3L, 0L)) & math.v3_iz_long256);

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
    public long3 rra
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 0L, 3L, 0L)) & math.v3_iz_long256);

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
    public long3 rga
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 1L, 3L, 0L)) & math.v3_iz_long256);

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.r = value.x; this.g = value.y; this.a = value.z; 
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
    public long3 rba
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 2L, 3L, 0L)) & math.v3_iz_long256);

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.r = value.x; this.b = value.y; this.a = value.z; 
        }
    }
    public long3 rar
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 3L, 0L, 0L)) & math.v3_iz_long256);

        }
    }
    public long3 rag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 3L, 1L, 0L)) & math.v3_iz_long256);

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.r = value.x; this.a = value.y; this.g = value.z; 
        }
    }
    public long3 rab
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 3L, 2L, 0L)) & math.v3_iz_long256);

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.r = value.x; this.a = value.y; this.b = value.z; 
        }
    }
    public long3 raa
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 3L, 3L, 0L)) & math.v3_iz_long256);

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
    public long3 gra
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 0L, 3L, 0L)) & math.v3_iz_long256);

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.g = value.x; this.r = value.y; this.a = value.z; 
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
    public long3 gga
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 1L, 3L, 0L)) & math.v3_iz_long256);

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
    public long3 gba
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 2L, 3L, 0L)) & math.v3_iz_long256);

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.g = value.x; this.b = value.y; this.a = value.z; 
        }
    }
    public long3 gar
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 3L, 0L, 0L)) & math.v3_iz_long256);

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.g = value.x; this.a = value.y; this.r = value.z; 
        }
    }
    public long3 gag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 3L, 1L, 0L)) & math.v3_iz_long256);

        }
    }
    public long3 gab
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 3L, 2L, 0L)) & math.v3_iz_long256);

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.g = value.x; this.a = value.y; this.b = value.z; 
        }
    }
    public long3 gaa
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 3L, 3L, 0L)) & math.v3_iz_long256);

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
    public long3 bra
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 0L, 3L, 0L)) & math.v3_iz_long256);

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.b = value.x; this.r = value.y; this.a = value.z; 
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
    public long3 bga
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 1L, 3L, 0L)) & math.v3_iz_long256);

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.b = value.x; this.g = value.y; this.a = value.z; 
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
    public long3 bba
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 2L, 3L, 0L)) & math.v3_iz_long256);

        }
    }
    public long3 bar
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 3L, 0L, 0L)) & math.v3_iz_long256);

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.b = value.x; this.a = value.y; this.r = value.z; 
        }
    }
    public long3 bag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 3L, 1L, 0L)) & math.v3_iz_long256);

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.b = value.x; this.a = value.y; this.g = value.z; 
        }
    }
    public long3 bab
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 3L, 2L, 0L)) & math.v3_iz_long256);

        }
    }
    public long3 baa
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 3L, 3L, 0L)) & math.v3_iz_long256);

        }
    }
    public long3 arr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 0L, 0L, 0L)) & math.v3_iz_long256);

        }
    }
    public long3 arg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 0L, 1L, 0L)) & math.v3_iz_long256);

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.a = value.x; this.r = value.y; this.g = value.z; 
        }
    }
    public long3 arb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 0L, 2L, 0L)) & math.v3_iz_long256);

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.a = value.x; this.r = value.y; this.b = value.z; 
        }
    }
    public long3 ara
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 0L, 3L, 0L)) & math.v3_iz_long256);

        }
    }
    public long3 agr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 1L, 0L, 0L)) & math.v3_iz_long256);

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.a = value.x; this.g = value.y; this.r = value.z; 
        }
    }
    public long3 agg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 1L, 1L, 0L)) & math.v3_iz_long256);

        }
    }
    public long3 agb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 1L, 2L, 0L)) & math.v3_iz_long256);

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.a = value.x; this.g = value.y; this.b = value.z; 
        }
    }
    public long3 aga
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 1L, 3L, 0L)) & math.v3_iz_long256);

        }
    }
    public long3 abr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 2L, 0L, 0L)) & math.v3_iz_long256);

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.a = value.x; this.b = value.y; this.r = value.z; 
        }
    }
    public long3 abg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 2L, 1L, 0L)) & math.v3_iz_long256);

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.a = value.x; this.b = value.y; this.g = value.z; 
        }
    }
    public long3 abb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 2L, 2L, 0L)) & math.v3_iz_long256);

        }
    }
    public long3 aba
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 2L, 3L, 0L)) & math.v3_iz_long256);

        }
    }
    public long3 aar
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 3L, 0L, 0L)) & math.v3_iz_long256);

        }
    }
    public long3 aag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 3L, 1L, 0L)) & math.v3_iz_long256);

        }
    }
    public long3 aab
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 3L, 2L, 0L)) & math.v3_iz_long256);

        }
    }
    public long3 aaa
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 3L, 3L, 0L)) & math.v3_iz_long256);

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
    public long4 xxxw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 0L, 0L, 3L)));

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
    public long4 xxyw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 0L, 1L, 3L)));

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
    public long4 xxzw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 0L, 2L, 3L)));

        }
    }
    public long4 xxwx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 0L, 3L, 0L)));

        }
    }
    public long4 xxwy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 0L, 3L, 1L)));

        }
    }
    public long4 xxwz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 0L, 3L, 2L)));

        }
    }
    public long4 xxww
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 0L, 3L, 3L)));

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
    public long4 xyxw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 1L, 0L, 3L)));

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
    public long4 xyyw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 1L, 1L, 3L)));

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
    public long4 xyzw
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
    public long4 xywx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 1L, 3L, 0L)));

        }
    }
    public long4 xywy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 1L, 3L, 1L)));

        }
    }
    public long4 xywz
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
    public long4 xyww
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 1L, 3L, 3L)));

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
    public long4 xzxw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 2L, 0L, 3L)));

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
    public long4 xzyw
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
    public long4 xzzw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 2L, 2L, 3L)));

        }
    }
    public long4 xzwx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 2L, 3L, 0L)));

        }
    }
    public long4 xzwy
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
    public long4 xzwz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 2L, 3L, 2L)));

        }
    }
    public long4 xzww
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 2L, 3L, 3L)));

        }
    }
    public long4 xwxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 3L, 0L, 0L)));

        }
    }
    public long4 xwxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 3L, 0L, 1L)));

        }
    }
    public long4 xwxz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 3L, 0L, 2L)));

        }
    }
    public long4 xwxw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 3L, 0L, 3L)));

        }
    }
    public long4 xwyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 3L, 1L, 0L)));

        }
    }
    public long4 xwyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 3L, 1L, 1L)));

        }
    }
    public long4 xwyz
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
    public long4 xwyw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 3L, 1L, 3L)));

        }
    }
    public long4 xwzx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 3L, 2L, 0L)));

        }
    }
    public long4 xwzy
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
    public long4 xwzz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 3L, 2L, 2L)));

        }
    }
    public long4 xwzw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 3L, 2L, 3L)));

        }
    }
    public long4 xwwx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 3L, 3L, 0L)));

        }
    }
    public long4 xwwy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 3L, 3L, 1L)));

        }
    }
    public long4 xwwz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 3L, 3L, 2L)));

        }
    }
    public long4 xwww
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 3L, 3L, 3L)));

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
    public long4 yxxw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 0L, 0L, 3L)));

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
    public long4 yxyw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 0L, 1L, 3L)));

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
    public long4 yxzw
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
    public long4 yxwx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 0L, 3L, 0L)));

        }
    }
    public long4 yxwy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 0L, 3L, 1L)));

        }
    }
    public long4 yxwz
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
    public long4 yxww
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 0L, 3L, 3L)));

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
    public long4 yyxw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 1L, 0L, 3L)));

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
    public long4 yyyw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 1L, 1L, 3L)));

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
    public long4 yyzw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 1L, 2L, 3L)));

        }
    }
    public long4 yywx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 1L, 3L, 0L)));

        }
    }
    public long4 yywy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 1L, 3L, 1L)));

        }
    }
    public long4 yywz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 1L, 3L, 2L)));

        }
    }
    public long4 yyww
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 1L, 3L, 3L)));

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
    public long4 yzxw
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
    public long4 yzyw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 2L, 1L, 3L)));

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
    public long4 yzzw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 2L, 2L, 3L)));

        }
    }
    public long4 yzwx
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
    public long4 yzwy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 2L, 3L, 1L)));

        }
    }
    public long4 yzwz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 2L, 3L, 2L)));

        }
    }
    public long4 yzww
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 2L, 3L, 3L)));

        }
    }
    public long4 ywxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 3L, 0L, 0L)));

        }
    }
    public long4 ywxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 3L, 0L, 1L)));

        }
    }
    public long4 ywxz
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
    public long4 ywxw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 3L, 0L, 3L)));

        }
    }
    public long4 ywyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 3L, 1L, 0L)));

        }
    }
    public long4 ywyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 3L, 1L, 1L)));

        }
    }
    public long4 ywyz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 3L, 1L, 2L)));

        }
    }
    public long4 ywyw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 3L, 1L, 3L)));

        }
    }
    public long4 ywzx
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
    public long4 ywzy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 3L, 2L, 1L)));

        }
    }
    public long4 ywzz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 3L, 2L, 2L)));

        }
    }
    public long4 ywzw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 3L, 2L, 3L)));

        }
    }
    public long4 ywwx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 3L, 3L, 0L)));

        }
    }
    public long4 ywwy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 3L, 3L, 1L)));

        }
    }
    public long4 ywwz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 3L, 3L, 2L)));

        }
    }
    public long4 ywww
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 3L, 3L, 3L)));

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
    public long4 zxxw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 0L, 0L, 3L)));

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
    public long4 zxyw
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
    public long4 zxzw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 0L, 2L, 3L)));

        }
    }
    public long4 zxwx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 0L, 3L, 0L)));

        }
    }
    public long4 zxwy
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
    public long4 zxwz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 0L, 3L, 2L)));

        }
    }
    public long4 zxww
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 0L, 3L, 3L)));

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
    public long4 zyxw
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
    public long4 zyyw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 1L, 1L, 3L)));

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
    public long4 zyzw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 1L, 2L, 3L)));

        }
    }
    public long4 zywx
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
    public long4 zywy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 1L, 3L, 1L)));

        }
    }
    public long4 zywz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 1L, 3L, 2L)));

        }
    }
    public long4 zyww
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 1L, 3L, 3L)));

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
    public long4 zzxw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 2L, 0L, 3L)));

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
    public long4 zzyw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 2L, 1L, 3L)));

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
    public long4 zzzw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 2L, 2L, 3L)));

        }
    }
    public long4 zzwx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 2L, 3L, 0L)));

        }
    }
    public long4 zzwy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 2L, 3L, 1L)));

        }
    }
    public long4 zzwz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 2L, 3L, 2L)));

        }
    }
    public long4 zzww
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 2L, 3L, 3L)));

        }
    }
    public long4 zwxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 3L, 0L, 0L)));

        }
    }
    public long4 zwxy
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
    public long4 zwxz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 3L, 0L, 2L)));

        }
    }
    public long4 zwxw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 3L, 0L, 3L)));

        }
    }
    public long4 zwyx
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
    public long4 zwyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 3L, 1L, 1L)));

        }
    }
    public long4 zwyz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 3L, 1L, 2L)));

        }
    }
    public long4 zwyw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 3L, 1L, 3L)));

        }
    }
    public long4 zwzx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 3L, 2L, 0L)));

        }
    }
    public long4 zwzy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 3L, 2L, 1L)));

        }
    }
    public long4 zwzz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 3L, 2L, 2L)));

        }
    }
    public long4 zwzw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 3L, 2L, 3L)));

        }
    }
    public long4 zwwx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 3L, 3L, 0L)));

        }
    }
    public long4 zwwy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 3L, 3L, 1L)));

        }
    }
    public long4 zwwz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 3L, 3L, 2L)));

        }
    }
    public long4 zwww
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 3L, 3L, 3L)));

        }
    }
    public long4 wxxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 0L, 0L, 0L)));

        }
    }
    public long4 wxxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 0L, 0L, 1L)));

        }
    }
    public long4 wxxz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 0L, 0L, 2L)));

        }
    }
    public long4 wxxw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 0L, 0L, 3L)));

        }
    }
    public long4 wxyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 0L, 1L, 0L)));

        }
    }
    public long4 wxyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 0L, 1L, 1L)));

        }
    }
    public long4 wxyz
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
    public long4 wxyw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 0L, 1L, 3L)));

        }
    }
    public long4 wxzx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 0L, 2L, 0L)));

        }
    }
    public long4 wxzy
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
    public long4 wxzz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 0L, 2L, 2L)));

        }
    }
    public long4 wxzw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 0L, 2L, 3L)));

        }
    }
    public long4 wxwx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 0L, 3L, 0L)));

        }
    }
    public long4 wxwy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 0L, 3L, 1L)));

        }
    }
    public long4 wxwz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 0L, 3L, 2L)));

        }
    }
    public long4 wxww
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 0L, 3L, 3L)));

        }
    }
    public long4 wyxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 1L, 0L, 0L)));

        }
    }
    public long4 wyxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 1L, 0L, 1L)));

        }
    }
    public long4 wyxz
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
    public long4 wyxw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 1L, 0L, 3L)));

        }
    }
    public long4 wyyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 1L, 1L, 0L)));

        }
    }
    public long4 wyyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 1L, 1L, 1L)));

        }
    }
    public long4 wyyz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 1L, 1L, 2L)));

        }
    }
    public long4 wyyw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 1L, 1L, 3L)));

        }
    }
    public long4 wyzx
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
    public long4 wyzy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 1L, 2L, 1L)));

        }
    }
    public long4 wyzz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 1L, 2L, 2L)));

        }
    }
    public long4 wyzw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 1L, 2L, 3L)));

        }
    }
    public long4 wywx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 1L, 3L, 0L)));

        }
    }
    public long4 wywy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 1L, 3L, 1L)));

        }
    }
    public long4 wywz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 1L, 3L, 2L)));

        }
    }
    public long4 wyww
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 1L, 3L, 3L)));

        }
    }
    public long4 wzxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 2L, 0L, 0L)));

        }
    }
    public long4 wzxy
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
    public long4 wzxz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 2L, 0L, 2L)));

        }
    }
    public long4 wzxw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 2L, 0L, 3L)));

        }
    }
    public long4 wzyx
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
    public long4 wzyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 2L, 1L, 1L)));

        }
    }
    public long4 wzyz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 2L, 1L, 2L)));

        }
    }
    public long4 wzyw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 2L, 1L, 3L)));

        }
    }
    public long4 wzzx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 2L, 2L, 0L)));

        }
    }
    public long4 wzzy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 2L, 2L, 1L)));

        }
    }
    public long4 wzzz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 2L, 2L, 2L)));

        }
    }
    public long4 wzzw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 2L, 2L, 3L)));

        }
    }
    public long4 wzwx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 2L, 3L, 0L)));

        }
    }
    public long4 wzwy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 2L, 3L, 1L)));

        }
    }
    public long4 wzwz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 2L, 3L, 2L)));

        }
    }
    public long4 wzww
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 2L, 3L, 3L)));

        }
    }
    public long4 wwxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 3L, 0L, 0L)));

        }
    }
    public long4 wwxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 3L, 0L, 1L)));

        }
    }
    public long4 wwxz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 3L, 0L, 2L)));

        }
    }
    public long4 wwxw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 3L, 0L, 3L)));

        }
    }
    public long4 wwyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 3L, 1L, 0L)));

        }
    }
    public long4 wwyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 3L, 1L, 1L)));

        }
    }
    public long4 wwyz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 3L, 1L, 2L)));

        }
    }
    public long4 wwyw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 3L, 1L, 3L)));

        }
    }
    public long4 wwzx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 3L, 2L, 0L)));

        }
    }
    public long4 wwzy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 3L, 2L, 1L)));

        }
    }
    public long4 wwzz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 3L, 2L, 2L)));

        }
    }
    public long4 wwzw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 3L, 2L, 3L)));

        }
    }
    public long4 wwwx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 3L, 3L, 0L)));

        }
    }
    public long4 wwwy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 3L, 3L, 1L)));

        }
    }
    public long4 wwwz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 3L, 3L, 2L)));

        }
    }
    public long4 wwww
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 3L, 3L, 3L)));

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
    public long4 rrra
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 0L, 0L, 3L)));

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
    public long4 rrga
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 0L, 1L, 3L)));

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
    public long4 rrba
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 0L, 2L, 3L)));

        }
    }
    public long4 rrar
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 0L, 3L, 0L)));

        }
    }
    public long4 rrag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 0L, 3L, 1L)));

        }
    }
    public long4 rrab
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 0L, 3L, 2L)));

        }
    }
    public long4 rraa
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 0L, 3L, 3L)));

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
    public long4 rgra
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 1L, 0L, 3L)));

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
    public long4 rgga
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 1L, 1L, 3L)));

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
    public long4 rgba
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
    public long4 rgar
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 1L, 3L, 0L)));

        }
    }
    public long4 rgag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 1L, 3L, 1L)));

        }
    }
    public long4 rgab
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
    public long4 rgaa
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 1L, 3L, 3L)));

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
    public long4 rbra
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 2L, 0L, 3L)));

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
    public long4 rbga
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
    public long4 rbba
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 2L, 2L, 3L)));

        }
    }
    public long4 rbar
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 2L, 3L, 0L)));

        }
    }
    public long4 rbag
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
    public long4 rbab
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 2L, 3L, 2L)));

        }
    }
    public long4 rbaa
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 2L, 3L, 3L)));

        }
    }
    public long4 rarr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 3L, 0L, 0L)));

        }
    }
    public long4 rarg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 3L, 0L, 1L)));

        }
    }
    public long4 rarb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 3L, 0L, 2L)));

        }
    }
    public long4 rara
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 3L, 0L, 3L)));

        }
    }
    public long4 ragr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 3L, 1L, 0L)));

        }
    }
    public long4 ragg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 3L, 1L, 1L)));

        }
    }
    public long4 ragb
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
    public long4 raga
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 3L, 1L, 3L)));

        }
    }
    public long4 rabr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 3L, 2L, 0L)));

        }
    }
    public long4 rabg
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
    public long4 rabb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 3L, 2L, 2L)));

        }
    }
    public long4 raba
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 3L, 2L, 3L)));

        }
    }
    public long4 raar
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 3L, 3L, 0L)));

        }
    }
    public long4 raag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 3L, 3L, 1L)));

        }
    }
    public long4 raab
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 3L, 3L, 2L)));

        }
    }
    public long4 raaa
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(0L, 3L, 3L, 3L)));

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
    public long4 grra
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 0L, 0L, 3L)));

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
    public long4 grga
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 0L, 1L, 3L)));

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
    public long4 grba
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
    public long4 grar
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 0L, 3L, 0L)));

        }
    }
    public long4 grag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 0L, 3L, 1L)));

        }
    }
    public long4 grab
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
    public long4 graa
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 0L, 3L, 3L)));

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
    public long4 ggra
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 1L, 0L, 3L)));

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
    public long4 ggga
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 1L, 1L, 3L)));

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
    public long4 ggba
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 1L, 2L, 3L)));

        }
    }
    public long4 ggar
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 1L, 3L, 0L)));

        }
    }
    public long4 ggag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 1L, 3L, 1L)));

        }
    }
    public long4 ggab
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 1L, 3L, 2L)));

        }
    }
    public long4 ggaa
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 1L, 3L, 3L)));

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
    public long4 gbra
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
    public long4 gbga
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 2L, 1L, 3L)));

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
    public long4 gbba
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 2L, 2L, 3L)));

        }
    }
    public long4 gbar
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
    public long4 gbag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 2L, 3L, 1L)));

        }
    }
    public long4 gbab
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 2L, 3L, 2L)));

        }
    }
    public long4 gbaa
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 2L, 3L, 3L)));

        }
    }
    public long4 garr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 3L, 0L, 0L)));

        }
    }
    public long4 garg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 3L, 0L, 1L)));

        }
    }
    public long4 garb
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
    public long4 gara
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 3L, 0L, 3L)));

        }
    }
    public long4 gagr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 3L, 1L, 0L)));

        }
    }
    public long4 gagg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 3L, 1L, 1L)));

        }
    }
    public long4 gagb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 3L, 1L, 2L)));

        }
    }
    public long4 gaga
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 3L, 1L, 3L)));

        }
    }
    public long4 gabr
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
    public long4 gabg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 3L, 2L, 1L)));

        }
    }
    public long4 gabb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 3L, 2L, 2L)));

        }
    }
    public long4 gaba
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 3L, 2L, 3L)));

        }
    }
    public long4 gaar
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 3L, 3L, 0L)));

        }
    }
    public long4 gaag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 3L, 3L, 1L)));

        }
    }
    public long4 gaab
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 3L, 3L, 2L)));

        }
    }
    public long4 gaaa
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(1L, 3L, 3L, 3L)));

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
    public long4 brra
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 0L, 0L, 3L)));

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
    public long4 brga
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
    public long4 brba
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 0L, 2L, 3L)));

        }
    }
    public long4 brar
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 0L, 3L, 0L)));

        }
    }
    public long4 brag
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
    public long4 brab
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 0L, 3L, 2L)));

        }
    }
    public long4 braa
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 0L, 3L, 3L)));

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
    public long4 bgra
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
    public long4 bgga
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 1L, 1L, 3L)));

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
    public long4 bgba
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 1L, 2L, 3L)));

        }
    }
    public long4 bgar
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
    public long4 bgag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 1L, 3L, 1L)));

        }
    }
    public long4 bgab
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 1L, 3L, 2L)));

        }
    }
    public long4 bgaa
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 1L, 3L, 3L)));

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
    public long4 bbra
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 2L, 0L, 3L)));

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
    public long4 bbga
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 2L, 1L, 3L)));

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
    public long4 bbba
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 2L, 2L, 3L)));

        }
    }
    public long4 bbar
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 2L, 3L, 0L)));

        }
    }
    public long4 bbag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 2L, 3L, 1L)));

        }
    }
    public long4 bbab
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 2L, 3L, 2L)));

        }
    }
    public long4 bbaa
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 2L, 3L, 3L)));

        }
    }
    public long4 barr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 3L, 0L, 0L)));

        }
    }
    public long4 barg
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
    public long4 barb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 3L, 0L, 2L)));

        }
    }
    public long4 bara
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 3L, 0L, 3L)));

        }
    }
    public long4 bagr
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
    public long4 bagg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 3L, 1L, 1L)));

        }
    }
    public long4 bagb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 3L, 1L, 2L)));

        }
    }
    public long4 baga
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 3L, 1L, 3L)));

        }
    }
    public long4 babr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 3L, 2L, 0L)));

        }
    }
    public long4 babg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 3L, 2L, 1L)));

        }
    }
    public long4 babb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 3L, 2L, 2L)));

        }
    }
    public long4 baba
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 3L, 2L, 3L)));

        }
    }
    public long4 baar
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 3L, 3L, 0L)));

        }
    }
    public long4 baag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 3L, 3L, 1L)));

        }
    }
    public long4 baab
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 3L, 3L, 2L)));

        }
    }
    public long4 baaa
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(2L, 3L, 3L, 3L)));

        }
    }
    public long4 arrr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 0L, 0L, 0L)));

        }
    }
    public long4 arrg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 0L, 0L, 1L)));

        }
    }
    public long4 arrb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 0L, 0L, 2L)));

        }
    }
    public long4 arra
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 0L, 0L, 3L)));

        }
    }
    public long4 argr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 0L, 1L, 0L)));

        }
    }
    public long4 argg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 0L, 1L, 1L)));

        }
    }
    public long4 argb
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
    public long4 arga
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 0L, 1L, 3L)));

        }
    }
    public long4 arbr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 0L, 2L, 0L)));

        }
    }
    public long4 arbg
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
    public long4 arbb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 0L, 2L, 2L)));

        }
    }
    public long4 arba
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 0L, 2L, 3L)));

        }
    }
    public long4 arar
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 0L, 3L, 0L)));

        }
    }
    public long4 arag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 0L, 3L, 1L)));

        }
    }
    public long4 arab
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 0L, 3L, 2L)));

        }
    }
    public long4 araa
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 0L, 3L, 3L)));

        }
    }
    public long4 agrr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 1L, 0L, 0L)));

        }
    }
    public long4 agrg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 1L, 0L, 1L)));

        }
    }
    public long4 agrb
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
    public long4 agra
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 1L, 0L, 3L)));

        }
    }
    public long4 aggr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 1L, 1L, 0L)));

        }
    }
    public long4 aggg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 1L, 1L, 1L)));

        }
    }
    public long4 aggb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 1L, 1L, 2L)));

        }
    }
    public long4 agga
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 1L, 1L, 3L)));

        }
    }
    public long4 agbr
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
    public long4 agbg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 1L, 2L, 1L)));

        }
    }
    public long4 agbb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 1L, 2L, 2L)));

        }
    }
    public long4 agba
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 1L, 2L, 3L)));

        }
    }
    public long4 agar
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 1L, 3L, 0L)));

        }
    }
    public long4 agag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 1L, 3L, 1L)));

        }
    }
    public long4 agab
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 1L, 3L, 2L)));

        }
    }
    public long4 agaa
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 1L, 3L, 3L)));

        }
    }
    public long4 abrr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 2L, 0L, 0L)));

        }
    }
    public long4 abrg
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
    public long4 abrb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 2L, 0L, 2L)));

        }
    }
    public long4 abra
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 2L, 0L, 3L)));

        }
    }
    public long4 abgr
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
    public long4 abgg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 2L, 1L, 1L)));

        }
    }
    public long4 abgb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 2L, 1L, 2L)));

        }
    }
    public long4 abga
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 2L, 1L, 3L)));

        }
    }
    public long4 abbr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 2L, 2L, 0L)));

        }
    }
    public long4 abbg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 2L, 2L, 1L)));

        }
    }
    public long4 abbb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 2L, 2L, 2L)));

        }
    }
    public long4 abba
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 2L, 2L, 3L)));

        }
    }
    public long4 abar
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 2L, 3L, 0L)));

        }
    }
    public long4 abag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 2L, 3L, 1L)));

        }
    }
    public long4 abab
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 2L, 3L, 2L)));

        }
    }
    public long4 abaa
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 2L, 3L, 3L)));

        }
    }
    public long4 aarr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 3L, 0L, 0L)));

        }
    }
    public long4 aarg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 3L, 0L, 1L)));

        }
    }
    public long4 aarb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 3L, 0L, 2L)));

        }
    }
    public long4 aara
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 3L, 0L, 3L)));

        }
    }
    public long4 aagr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 3L, 1L, 0L)));

        }
    }
    public long4 aagg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 3L, 1L, 1L)));

        }
    }
    public long4 aagb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 3L, 1L, 2L)));

        }
    }
    public long4 aaga
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 3L, 1L, 3L)));

        }
    }
    public long4 aabr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 3L, 2L, 0L)));

        }
    }
    public long4 aabg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 3L, 2L, 1L)));

        }
    }
    public long4 aabb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 3L, 2L, 2L)));

        }
    }
    public long4 aaba
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 3L, 2L, 3L)));

        }
    }
    public long4 aaar
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 3L, 3L, 0L)));

        }
    }
    public long4 aaag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 3L, 3L, 1L)));

        }
    }
    public long4 aaab
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 3L, 3L, 2L)));

        }
    }
    public long4 aaaa
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector256.Shuffle(this.vector, Vector256.Create(3L, 3L, 3L, 3L)));

        }
    }


}
