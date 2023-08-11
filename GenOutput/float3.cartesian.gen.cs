using System;
using System.Numerics;
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.X86;
using System.Runtime.Intrinsics.Arm;
using System.Runtime.CompilerServices;

#nullable enable
#pragma warning disable CS8981

namespace CCluster.Mathematics;

public partial struct float3 
{

    public float2 xx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(this.x, this.x);

        }
    }
    public float2 xy
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
    public float2 xz
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
    public float2 yx
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
    public float2 yy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(this.y, this.y);

        }
    }
    public float2 yz
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
    public float2 zx
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
    public float2 zy
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
    public float2 zz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(this.z, this.z);

        }
    }
    public float2 rr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(this.r, this.r);

        }
    }
    public float2 rg
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
    public float2 rb
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
    public float2 gr
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
    public float2 gg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(this.g, this.g);

        }
    }
    public float2 gb
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
    public float2 br
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
    public float2 bg
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
    public float2 bb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(this.b, this.b);

        }
    }
    public float3 xxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(0, 0, 0, 0)) & math.v3_iz_float128);

        }
    }
    public float3 xxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(0, 0, 1, 0)) & math.v3_iz_float128);

        }
    }
    public float3 xxz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(0, 0, 2, 0)) & math.v3_iz_float128);

        }
    }
    public float3 xyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(0, 1, 0, 0)) & math.v3_iz_float128);

        }
    }
    public float3 xyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(0, 1, 1, 0)) & math.v3_iz_float128);

        }
    }
    public float3 xyz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(0, 1, 2, 0)) & math.v3_iz_float128);

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.x = value.x; this.y = value.y; this.z = value.z; 
        }
    }
    public float3 xzx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(0, 2, 0, 0)) & math.v3_iz_float128);

        }
    }
    public float3 xzy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(0, 2, 1, 0)) & math.v3_iz_float128);

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.x = value.x; this.z = value.y; this.y = value.z; 
        }
    }
    public float3 xzz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(0, 2, 2, 0)) & math.v3_iz_float128);

        }
    }
    public float3 yxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(1, 0, 0, 0)) & math.v3_iz_float128);

        }
    }
    public float3 yxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(1, 0, 1, 0)) & math.v3_iz_float128);

        }
    }
    public float3 yxz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(1, 0, 2, 0)) & math.v3_iz_float128);

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.y = value.x; this.x = value.y; this.z = value.z; 
        }
    }
    public float3 yyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(1, 1, 0, 0)) & math.v3_iz_float128);

        }
    }
    public float3 yyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(1, 1, 1, 0)) & math.v3_iz_float128);

        }
    }
    public float3 yyz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(1, 1, 2, 0)) & math.v3_iz_float128);

        }
    }
    public float3 yzx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(1, 2, 0, 0)) & math.v3_iz_float128);

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.y = value.x; this.z = value.y; this.x = value.z; 
        }
    }
    public float3 yzy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(1, 2, 1, 0)) & math.v3_iz_float128);

        }
    }
    public float3 yzz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(1, 2, 2, 0)) & math.v3_iz_float128);

        }
    }
    public float3 zxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(2, 0, 0, 0)) & math.v3_iz_float128);

        }
    }
    public float3 zxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(2, 0, 1, 0)) & math.v3_iz_float128);

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.z = value.x; this.x = value.y; this.y = value.z; 
        }
    }
    public float3 zxz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(2, 0, 2, 0)) & math.v3_iz_float128);

        }
    }
    public float3 zyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(2, 1, 0, 0)) & math.v3_iz_float128);

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.z = value.x; this.y = value.y; this.x = value.z; 
        }
    }
    public float3 zyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(2, 1, 1, 0)) & math.v3_iz_float128);

        }
    }
    public float3 zyz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(2, 1, 2, 0)) & math.v3_iz_float128);

        }
    }
    public float3 zzx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(2, 2, 0, 0)) & math.v3_iz_float128);

        }
    }
    public float3 zzy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(2, 2, 1, 0)) & math.v3_iz_float128);

        }
    }
    public float3 zzz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(2, 2, 2, 0)) & math.v3_iz_float128);

        }
    }
    public float3 rrr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(0, 0, 0, 0)) & math.v3_iz_float128);

        }
    }
    public float3 rrg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(0, 0, 1, 0)) & math.v3_iz_float128);

        }
    }
    public float3 rrb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(0, 0, 2, 0)) & math.v3_iz_float128);

        }
    }
    public float3 rgr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(0, 1, 0, 0)) & math.v3_iz_float128);

        }
    }
    public float3 rgg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(0, 1, 1, 0)) & math.v3_iz_float128);

        }
    }
    public float3 rgb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(0, 1, 2, 0)) & math.v3_iz_float128);

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.r = value.x; this.g = value.y; this.b = value.z; 
        }
    }
    public float3 rbr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(0, 2, 0, 0)) & math.v3_iz_float128);

        }
    }
    public float3 rbg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(0, 2, 1, 0)) & math.v3_iz_float128);

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.r = value.x; this.b = value.y; this.g = value.z; 
        }
    }
    public float3 rbb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(0, 2, 2, 0)) & math.v3_iz_float128);

        }
    }
    public float3 grr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(1, 0, 0, 0)) & math.v3_iz_float128);

        }
    }
    public float3 grg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(1, 0, 1, 0)) & math.v3_iz_float128);

        }
    }
    public float3 grb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(1, 0, 2, 0)) & math.v3_iz_float128);

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.g = value.x; this.r = value.y; this.b = value.z; 
        }
    }
    public float3 ggr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(1, 1, 0, 0)) & math.v3_iz_float128);

        }
    }
    public float3 ggg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(1, 1, 1, 0)) & math.v3_iz_float128);

        }
    }
    public float3 ggb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(1, 1, 2, 0)) & math.v3_iz_float128);

        }
    }
    public float3 gbr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(1, 2, 0, 0)) & math.v3_iz_float128);

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.g = value.x; this.b = value.y; this.r = value.z; 
        }
    }
    public float3 gbg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(1, 2, 1, 0)) & math.v3_iz_float128);

        }
    }
    public float3 gbb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(1, 2, 2, 0)) & math.v3_iz_float128);

        }
    }
    public float3 brr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(2, 0, 0, 0)) & math.v3_iz_float128);

        }
    }
    public float3 brg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(2, 0, 1, 0)) & math.v3_iz_float128);

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.b = value.x; this.r = value.y; this.g = value.z; 
        }
    }
    public float3 brb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(2, 0, 2, 0)) & math.v3_iz_float128);

        }
    }
    public float3 bgr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(2, 1, 0, 0)) & math.v3_iz_float128);

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.b = value.x; this.g = value.y; this.r = value.z; 
        }
    }
    public float3 bgg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(2, 1, 1, 0)) & math.v3_iz_float128);

        }
    }
    public float3 bgb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(2, 1, 2, 0)) & math.v3_iz_float128);

        }
    }
    public float3 bbr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(2, 2, 0, 0)) & math.v3_iz_float128);

        }
    }
    public float3 bbg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(2, 2, 1, 0)) & math.v3_iz_float128);

        }
    }
    public float3 bbb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(2, 2, 2, 0)) & math.v3_iz_float128);

        }
    }
    public float4 xxxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(0, 0, 0, 0)));

        }
    }
    public float4 xxxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(0, 0, 0, 1)));

        }
    }
    public float4 xxxz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(0, 0, 0, 2)));

        }
    }
    public float4 xxyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(0, 0, 1, 0)));

        }
    }
    public float4 xxyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(0, 0, 1, 1)));

        }
    }
    public float4 xxyz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(0, 0, 1, 2)));

        }
    }
    public float4 xxzx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(0, 0, 2, 0)));

        }
    }
    public float4 xxzy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(0, 0, 2, 1)));

        }
    }
    public float4 xxzz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(0, 0, 2, 2)));

        }
    }
    public float4 xyxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(0, 1, 0, 0)));

        }
    }
    public float4 xyxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(0, 1, 0, 1)));

        }
    }
    public float4 xyxz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(0, 1, 0, 2)));

        }
    }
    public float4 xyyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(0, 1, 1, 0)));

        }
    }
    public float4 xyyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(0, 1, 1, 1)));

        }
    }
    public float4 xyyz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(0, 1, 1, 2)));

        }
    }
    public float4 xyzx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(0, 1, 2, 0)));

        }
    }
    public float4 xyzy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(0, 1, 2, 1)));

        }
    }
    public float4 xyzz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(0, 1, 2, 2)));

        }
    }
    public float4 xzxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(0, 2, 0, 0)));

        }
    }
    public float4 xzxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(0, 2, 0, 1)));

        }
    }
    public float4 xzxz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(0, 2, 0, 2)));

        }
    }
    public float4 xzyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(0, 2, 1, 0)));

        }
    }
    public float4 xzyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(0, 2, 1, 1)));

        }
    }
    public float4 xzyz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(0, 2, 1, 2)));

        }
    }
    public float4 xzzx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(0, 2, 2, 0)));

        }
    }
    public float4 xzzy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(0, 2, 2, 1)));

        }
    }
    public float4 xzzz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(0, 2, 2, 2)));

        }
    }
    public float4 yxxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(1, 0, 0, 0)));

        }
    }
    public float4 yxxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(1, 0, 0, 1)));

        }
    }
    public float4 yxxz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(1, 0, 0, 2)));

        }
    }
    public float4 yxyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(1, 0, 1, 0)));

        }
    }
    public float4 yxyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(1, 0, 1, 1)));

        }
    }
    public float4 yxyz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(1, 0, 1, 2)));

        }
    }
    public float4 yxzx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(1, 0, 2, 0)));

        }
    }
    public float4 yxzy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(1, 0, 2, 1)));

        }
    }
    public float4 yxzz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(1, 0, 2, 2)));

        }
    }
    public float4 yyxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(1, 1, 0, 0)));

        }
    }
    public float4 yyxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(1, 1, 0, 1)));

        }
    }
    public float4 yyxz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(1, 1, 0, 2)));

        }
    }
    public float4 yyyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(1, 1, 1, 0)));

        }
    }
    public float4 yyyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(1, 1, 1, 1)));

        }
    }
    public float4 yyyz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(1, 1, 1, 2)));

        }
    }
    public float4 yyzx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(1, 1, 2, 0)));

        }
    }
    public float4 yyzy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(1, 1, 2, 1)));

        }
    }
    public float4 yyzz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(1, 1, 2, 2)));

        }
    }
    public float4 yzxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(1, 2, 0, 0)));

        }
    }
    public float4 yzxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(1, 2, 0, 1)));

        }
    }
    public float4 yzxz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(1, 2, 0, 2)));

        }
    }
    public float4 yzyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(1, 2, 1, 0)));

        }
    }
    public float4 yzyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(1, 2, 1, 1)));

        }
    }
    public float4 yzyz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(1, 2, 1, 2)));

        }
    }
    public float4 yzzx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(1, 2, 2, 0)));

        }
    }
    public float4 yzzy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(1, 2, 2, 1)));

        }
    }
    public float4 yzzz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(1, 2, 2, 2)));

        }
    }
    public float4 zxxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(2, 0, 0, 0)));

        }
    }
    public float4 zxxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(2, 0, 0, 1)));

        }
    }
    public float4 zxxz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(2, 0, 0, 2)));

        }
    }
    public float4 zxyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(2, 0, 1, 0)));

        }
    }
    public float4 zxyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(2, 0, 1, 1)));

        }
    }
    public float4 zxyz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(2, 0, 1, 2)));

        }
    }
    public float4 zxzx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(2, 0, 2, 0)));

        }
    }
    public float4 zxzy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(2, 0, 2, 1)));

        }
    }
    public float4 zxzz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(2, 0, 2, 2)));

        }
    }
    public float4 zyxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(2, 1, 0, 0)));

        }
    }
    public float4 zyxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(2, 1, 0, 1)));

        }
    }
    public float4 zyxz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(2, 1, 0, 2)));

        }
    }
    public float4 zyyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(2, 1, 1, 0)));

        }
    }
    public float4 zyyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(2, 1, 1, 1)));

        }
    }
    public float4 zyyz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(2, 1, 1, 2)));

        }
    }
    public float4 zyzx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(2, 1, 2, 0)));

        }
    }
    public float4 zyzy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(2, 1, 2, 1)));

        }
    }
    public float4 zyzz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(2, 1, 2, 2)));

        }
    }
    public float4 zzxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(2, 2, 0, 0)));

        }
    }
    public float4 zzxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(2, 2, 0, 1)));

        }
    }
    public float4 zzxz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(2, 2, 0, 2)));

        }
    }
    public float4 zzyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(2, 2, 1, 0)));

        }
    }
    public float4 zzyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(2, 2, 1, 1)));

        }
    }
    public float4 zzyz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(2, 2, 1, 2)));

        }
    }
    public float4 zzzx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(2, 2, 2, 0)));

        }
    }
    public float4 zzzy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(2, 2, 2, 1)));

        }
    }
    public float4 zzzz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(2, 2, 2, 2)));

        }
    }
    public float4 rrrr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(0, 0, 0, 0)));

        }
    }
    public float4 rrrg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(0, 0, 0, 1)));

        }
    }
    public float4 rrrb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(0, 0, 0, 2)));

        }
    }
    public float4 rrgr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(0, 0, 1, 0)));

        }
    }
    public float4 rrgg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(0, 0, 1, 1)));

        }
    }
    public float4 rrgb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(0, 0, 1, 2)));

        }
    }
    public float4 rrbr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(0, 0, 2, 0)));

        }
    }
    public float4 rrbg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(0, 0, 2, 1)));

        }
    }
    public float4 rrbb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(0, 0, 2, 2)));

        }
    }
    public float4 rgrr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(0, 1, 0, 0)));

        }
    }
    public float4 rgrg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(0, 1, 0, 1)));

        }
    }
    public float4 rgrb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(0, 1, 0, 2)));

        }
    }
    public float4 rggr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(0, 1, 1, 0)));

        }
    }
    public float4 rggg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(0, 1, 1, 1)));

        }
    }
    public float4 rggb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(0, 1, 1, 2)));

        }
    }
    public float4 rgbr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(0, 1, 2, 0)));

        }
    }
    public float4 rgbg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(0, 1, 2, 1)));

        }
    }
    public float4 rgbb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(0, 1, 2, 2)));

        }
    }
    public float4 rbrr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(0, 2, 0, 0)));

        }
    }
    public float4 rbrg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(0, 2, 0, 1)));

        }
    }
    public float4 rbrb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(0, 2, 0, 2)));

        }
    }
    public float4 rbgr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(0, 2, 1, 0)));

        }
    }
    public float4 rbgg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(0, 2, 1, 1)));

        }
    }
    public float4 rbgb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(0, 2, 1, 2)));

        }
    }
    public float4 rbbr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(0, 2, 2, 0)));

        }
    }
    public float4 rbbg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(0, 2, 2, 1)));

        }
    }
    public float4 rbbb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(0, 2, 2, 2)));

        }
    }
    public float4 grrr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(1, 0, 0, 0)));

        }
    }
    public float4 grrg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(1, 0, 0, 1)));

        }
    }
    public float4 grrb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(1, 0, 0, 2)));

        }
    }
    public float4 grgr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(1, 0, 1, 0)));

        }
    }
    public float4 grgg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(1, 0, 1, 1)));

        }
    }
    public float4 grgb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(1, 0, 1, 2)));

        }
    }
    public float4 grbr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(1, 0, 2, 0)));

        }
    }
    public float4 grbg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(1, 0, 2, 1)));

        }
    }
    public float4 grbb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(1, 0, 2, 2)));

        }
    }
    public float4 ggrr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(1, 1, 0, 0)));

        }
    }
    public float4 ggrg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(1, 1, 0, 1)));

        }
    }
    public float4 ggrb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(1, 1, 0, 2)));

        }
    }
    public float4 gggr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(1, 1, 1, 0)));

        }
    }
    public float4 gggg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(1, 1, 1, 1)));

        }
    }
    public float4 gggb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(1, 1, 1, 2)));

        }
    }
    public float4 ggbr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(1, 1, 2, 0)));

        }
    }
    public float4 ggbg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(1, 1, 2, 1)));

        }
    }
    public float4 ggbb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(1, 1, 2, 2)));

        }
    }
    public float4 gbrr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(1, 2, 0, 0)));

        }
    }
    public float4 gbrg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(1, 2, 0, 1)));

        }
    }
    public float4 gbrb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(1, 2, 0, 2)));

        }
    }
    public float4 gbgr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(1, 2, 1, 0)));

        }
    }
    public float4 gbgg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(1, 2, 1, 1)));

        }
    }
    public float4 gbgb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(1, 2, 1, 2)));

        }
    }
    public float4 gbbr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(1, 2, 2, 0)));

        }
    }
    public float4 gbbg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(1, 2, 2, 1)));

        }
    }
    public float4 gbbb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(1, 2, 2, 2)));

        }
    }
    public float4 brrr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(2, 0, 0, 0)));

        }
    }
    public float4 brrg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(2, 0, 0, 1)));

        }
    }
    public float4 brrb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(2, 0, 0, 2)));

        }
    }
    public float4 brgr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(2, 0, 1, 0)));

        }
    }
    public float4 brgg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(2, 0, 1, 1)));

        }
    }
    public float4 brgb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(2, 0, 1, 2)));

        }
    }
    public float4 brbr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(2, 0, 2, 0)));

        }
    }
    public float4 brbg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(2, 0, 2, 1)));

        }
    }
    public float4 brbb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(2, 0, 2, 2)));

        }
    }
    public float4 bgrr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(2, 1, 0, 0)));

        }
    }
    public float4 bgrg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(2, 1, 0, 1)));

        }
    }
    public float4 bgrb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(2, 1, 0, 2)));

        }
    }
    public float4 bggr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(2, 1, 1, 0)));

        }
    }
    public float4 bggg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(2, 1, 1, 1)));

        }
    }
    public float4 bggb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(2, 1, 1, 2)));

        }
    }
    public float4 bgbr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(2, 1, 2, 0)));

        }
    }
    public float4 bgbg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(2, 1, 2, 1)));

        }
    }
    public float4 bgbb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(2, 1, 2, 2)));

        }
    }
    public float4 bbrr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(2, 2, 0, 0)));

        }
    }
    public float4 bbrg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(2, 2, 0, 1)));

        }
    }
    public float4 bbrb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(2, 2, 0, 2)));

        }
    }
    public float4 bbgr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(2, 2, 1, 0)));

        }
    }
    public float4 bbgg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(2, 2, 1, 1)));

        }
    }
    public float4 bbgb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(2, 2, 1, 2)));

        }
    }
    public float4 bbbr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(2, 2, 2, 0)));

        }
    }
    public float4 bbbg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(2, 2, 2, 1)));

        }
    }
    public float4 bbbb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            return new(Vector128.Shuffle(this.vector, Vector128.Create(2, 2, 2, 2)));

        }
    }


}
