using System;
using System.Numerics;
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.X86;
using System.Runtime.Intrinsics.Arm;
using System.Runtime.CompilerServices;

#nullable enable
#pragma warning disable CS8981

namespace CCluster.Mathematics;

public partial struct uint2 
{

    public uint2 xx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector64.Shuffle(this.vector, Vector64.Create(0u, 0u)));

        }
    }
    public uint2 xy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector64.Shuffle(this.vector, Vector64.Create(0u, 1u)));

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.x = value.x; this.y = value.y; 
        }
    }
    public uint2 yx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector64.Shuffle(this.vector, Vector64.Create(1u, 0u)));

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.y = value.x; this.x = value.y; 
        }
    }
    public uint2 yy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector64.Shuffle(this.vector, Vector64.Create(1u, 1u)));

        }
    }
    public uint2 rr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector64.Shuffle(this.vector, Vector64.Create(0u, 0u)));

        }
    }
    public uint2 rg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector64.Shuffle(this.vector, Vector64.Create(0u, 1u)));

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.r = value.x; this.g = value.y; 
        }
    }
    public uint2 gr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector64.Shuffle(this.vector, Vector64.Create(1u, 0u)));

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.g = value.x; this.r = value.y; 
        }
    }
    public uint2 gg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector64.Shuffle(this.vector, Vector64.Create(1u, 1u)));

        }
    }
    public uint3 xxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            var a = Vector64.Shuffle(this.vector, Vector64.Create(0u, 0u));
            var b = Vector64.Shuffle(this.vector, Vector64.Create(0u, 0u));
            return new(Vector128.Create(a, b) & math.v3_iz_uint128);

        }
    }
    public uint3 xxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            var a = Vector64.Shuffle(this.vector, Vector64.Create(0u, 0u));
            var b = Vector64.Shuffle(this.vector, Vector64.Create(1u, 0u));
            return new(Vector128.Create(a, b) & math.v3_iz_uint128);

        }
    }
    public uint3 xyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            var a = Vector64.Shuffle(this.vector, Vector64.Create(0u, 1u));
            var b = Vector64.Shuffle(this.vector, Vector64.Create(0u, 0u));
            return new(Vector128.Create(a, b) & math.v3_iz_uint128);

        }
    }
    public uint3 xyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            var a = Vector64.Shuffle(this.vector, Vector64.Create(0u, 1u));
            var b = Vector64.Shuffle(this.vector, Vector64.Create(1u, 0u));
            return new(Vector128.Create(a, b) & math.v3_iz_uint128);

        }
    }
    public uint3 yxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            var a = Vector64.Shuffle(this.vector, Vector64.Create(1u, 0u));
            var b = Vector64.Shuffle(this.vector, Vector64.Create(0u, 0u));
            return new(Vector128.Create(a, b) & math.v3_iz_uint128);

        }
    }
    public uint3 yxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            var a = Vector64.Shuffle(this.vector, Vector64.Create(1u, 0u));
            var b = Vector64.Shuffle(this.vector, Vector64.Create(1u, 0u));
            return new(Vector128.Create(a, b) & math.v3_iz_uint128);

        }
    }
    public uint3 yyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            var a = Vector64.Shuffle(this.vector, Vector64.Create(1u, 1u));
            var b = Vector64.Shuffle(this.vector, Vector64.Create(0u, 0u));
            return new(Vector128.Create(a, b) & math.v3_iz_uint128);

        }
    }
    public uint3 yyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            var a = Vector64.Shuffle(this.vector, Vector64.Create(1u, 1u));
            var b = Vector64.Shuffle(this.vector, Vector64.Create(1u, 0u));
            return new(Vector128.Create(a, b) & math.v3_iz_uint128);

        }
    }
    public uint3 rrr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            var a = Vector64.Shuffle(this.vector, Vector64.Create(0u, 0u));
            var b = Vector64.Shuffle(this.vector, Vector64.Create(0u, 0u));
            return new(Vector128.Create(a, b) & math.v3_iz_uint128);

        }
    }
    public uint3 rrg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            var a = Vector64.Shuffle(this.vector, Vector64.Create(0u, 0u));
            var b = Vector64.Shuffle(this.vector, Vector64.Create(1u, 0u));
            return new(Vector128.Create(a, b) & math.v3_iz_uint128);

        }
    }
    public uint3 rgr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            var a = Vector64.Shuffle(this.vector, Vector64.Create(0u, 1u));
            var b = Vector64.Shuffle(this.vector, Vector64.Create(0u, 0u));
            return new(Vector128.Create(a, b) & math.v3_iz_uint128);

        }
    }
    public uint3 rgg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            var a = Vector64.Shuffle(this.vector, Vector64.Create(0u, 1u));
            var b = Vector64.Shuffle(this.vector, Vector64.Create(1u, 0u));
            return new(Vector128.Create(a, b) & math.v3_iz_uint128);

        }
    }
    public uint3 grr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            var a = Vector64.Shuffle(this.vector, Vector64.Create(1u, 0u));
            var b = Vector64.Shuffle(this.vector, Vector64.Create(0u, 0u));
            return new(Vector128.Create(a, b) & math.v3_iz_uint128);

        }
    }
    public uint3 grg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            var a = Vector64.Shuffle(this.vector, Vector64.Create(1u, 0u));
            var b = Vector64.Shuffle(this.vector, Vector64.Create(1u, 0u));
            return new(Vector128.Create(a, b) & math.v3_iz_uint128);

        }
    }
    public uint3 ggr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            var a = Vector64.Shuffle(this.vector, Vector64.Create(1u, 1u));
            var b = Vector64.Shuffle(this.vector, Vector64.Create(0u, 0u));
            return new(Vector128.Create(a, b) & math.v3_iz_uint128);

        }
    }
    public uint3 ggg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            var a = Vector64.Shuffle(this.vector, Vector64.Create(1u, 1u));
            var b = Vector64.Shuffle(this.vector, Vector64.Create(1u, 0u));
            return new(Vector128.Create(a, b) & math.v3_iz_uint128);

        }
    }
    public uint4 xxxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector64.Shuffle(this.vector, Vector64.Create(0u, 0u));
            var b = Vector64.Shuffle(this.vector, Vector64.Create(0u, 0u));
            return new(Vector128.Create(a, b));

        }
    }
    public uint4 xxxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector64.Shuffle(this.vector, Vector64.Create(0u, 0u));
            var b = Vector64.Shuffle(this.vector, Vector64.Create(0u, 1u));
            return new(Vector128.Create(a, b));

        }
    }
    public uint4 xxyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector64.Shuffle(this.vector, Vector64.Create(0u, 0u));
            var b = Vector64.Shuffle(this.vector, Vector64.Create(1u, 0u));
            return new(Vector128.Create(a, b));

        }
    }
    public uint4 xxyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector64.Shuffle(this.vector, Vector64.Create(0u, 0u));
            var b = Vector64.Shuffle(this.vector, Vector64.Create(1u, 1u));
            return new(Vector128.Create(a, b));

        }
    }
    public uint4 xyxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector64.Shuffle(this.vector, Vector64.Create(0u, 1u));
            var b = Vector64.Shuffle(this.vector, Vector64.Create(0u, 0u));
            return new(Vector128.Create(a, b));

        }
    }
    public uint4 xyxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector64.Shuffle(this.vector, Vector64.Create(0u, 1u));
            var b = Vector64.Shuffle(this.vector, Vector64.Create(0u, 1u));
            return new(Vector128.Create(a, b));

        }
    }
    public uint4 xyyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector64.Shuffle(this.vector, Vector64.Create(0u, 1u));
            var b = Vector64.Shuffle(this.vector, Vector64.Create(1u, 0u));
            return new(Vector128.Create(a, b));

        }
    }
    public uint4 xyyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector64.Shuffle(this.vector, Vector64.Create(0u, 1u));
            var b = Vector64.Shuffle(this.vector, Vector64.Create(1u, 1u));
            return new(Vector128.Create(a, b));

        }
    }
    public uint4 yxxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector64.Shuffle(this.vector, Vector64.Create(1u, 0u));
            var b = Vector64.Shuffle(this.vector, Vector64.Create(0u, 0u));
            return new(Vector128.Create(a, b));

        }
    }
    public uint4 yxxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector64.Shuffle(this.vector, Vector64.Create(1u, 0u));
            var b = Vector64.Shuffle(this.vector, Vector64.Create(0u, 1u));
            return new(Vector128.Create(a, b));

        }
    }
    public uint4 yxyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector64.Shuffle(this.vector, Vector64.Create(1u, 0u));
            var b = Vector64.Shuffle(this.vector, Vector64.Create(1u, 0u));
            return new(Vector128.Create(a, b));

        }
    }
    public uint4 yxyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector64.Shuffle(this.vector, Vector64.Create(1u, 0u));
            var b = Vector64.Shuffle(this.vector, Vector64.Create(1u, 1u));
            return new(Vector128.Create(a, b));

        }
    }
    public uint4 yyxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector64.Shuffle(this.vector, Vector64.Create(1u, 1u));
            var b = Vector64.Shuffle(this.vector, Vector64.Create(0u, 0u));
            return new(Vector128.Create(a, b));

        }
    }
    public uint4 yyxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector64.Shuffle(this.vector, Vector64.Create(1u, 1u));
            var b = Vector64.Shuffle(this.vector, Vector64.Create(0u, 1u));
            return new(Vector128.Create(a, b));

        }
    }
    public uint4 yyyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector64.Shuffle(this.vector, Vector64.Create(1u, 1u));
            var b = Vector64.Shuffle(this.vector, Vector64.Create(1u, 0u));
            return new(Vector128.Create(a, b));

        }
    }
    public uint4 yyyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector64.Shuffle(this.vector, Vector64.Create(1u, 1u));
            var b = Vector64.Shuffle(this.vector, Vector64.Create(1u, 1u));
            return new(Vector128.Create(a, b));

        }
    }
    public uint4 rrrr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector64.Shuffle(this.vector, Vector64.Create(0u, 0u));
            var b = Vector64.Shuffle(this.vector, Vector64.Create(0u, 0u));
            return new(Vector128.Create(a, b));

        }
    }
    public uint4 rrrg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector64.Shuffle(this.vector, Vector64.Create(0u, 0u));
            var b = Vector64.Shuffle(this.vector, Vector64.Create(0u, 1u));
            return new(Vector128.Create(a, b));

        }
    }
    public uint4 rrgr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector64.Shuffle(this.vector, Vector64.Create(0u, 0u));
            var b = Vector64.Shuffle(this.vector, Vector64.Create(1u, 0u));
            return new(Vector128.Create(a, b));

        }
    }
    public uint4 rrgg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector64.Shuffle(this.vector, Vector64.Create(0u, 0u));
            var b = Vector64.Shuffle(this.vector, Vector64.Create(1u, 1u));
            return new(Vector128.Create(a, b));

        }
    }
    public uint4 rgrr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector64.Shuffle(this.vector, Vector64.Create(0u, 1u));
            var b = Vector64.Shuffle(this.vector, Vector64.Create(0u, 0u));
            return new(Vector128.Create(a, b));

        }
    }
    public uint4 rgrg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector64.Shuffle(this.vector, Vector64.Create(0u, 1u));
            var b = Vector64.Shuffle(this.vector, Vector64.Create(0u, 1u));
            return new(Vector128.Create(a, b));

        }
    }
    public uint4 rggr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector64.Shuffle(this.vector, Vector64.Create(0u, 1u));
            var b = Vector64.Shuffle(this.vector, Vector64.Create(1u, 0u));
            return new(Vector128.Create(a, b));

        }
    }
    public uint4 rggg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector64.Shuffle(this.vector, Vector64.Create(0u, 1u));
            var b = Vector64.Shuffle(this.vector, Vector64.Create(1u, 1u));
            return new(Vector128.Create(a, b));

        }
    }
    public uint4 grrr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector64.Shuffle(this.vector, Vector64.Create(1u, 0u));
            var b = Vector64.Shuffle(this.vector, Vector64.Create(0u, 0u));
            return new(Vector128.Create(a, b));

        }
    }
    public uint4 grrg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector64.Shuffle(this.vector, Vector64.Create(1u, 0u));
            var b = Vector64.Shuffle(this.vector, Vector64.Create(0u, 1u));
            return new(Vector128.Create(a, b));

        }
    }
    public uint4 grgr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector64.Shuffle(this.vector, Vector64.Create(1u, 0u));
            var b = Vector64.Shuffle(this.vector, Vector64.Create(1u, 0u));
            return new(Vector128.Create(a, b));

        }
    }
    public uint4 grgg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector64.Shuffle(this.vector, Vector64.Create(1u, 0u));
            var b = Vector64.Shuffle(this.vector, Vector64.Create(1u, 1u));
            return new(Vector128.Create(a, b));

        }
    }
    public uint4 ggrr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector64.Shuffle(this.vector, Vector64.Create(1u, 1u));
            var b = Vector64.Shuffle(this.vector, Vector64.Create(0u, 0u));
            return new(Vector128.Create(a, b));

        }
    }
    public uint4 ggrg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector64.Shuffle(this.vector, Vector64.Create(1u, 1u));
            var b = Vector64.Shuffle(this.vector, Vector64.Create(0u, 1u));
            return new(Vector128.Create(a, b));

        }
    }
    public uint4 gggr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector64.Shuffle(this.vector, Vector64.Create(1u, 1u));
            var b = Vector64.Shuffle(this.vector, Vector64.Create(1u, 0u));
            return new(Vector128.Create(a, b));

        }
    }
    public uint4 gggg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector64.Shuffle(this.vector, Vector64.Create(1u, 1u));
            var b = Vector64.Shuffle(this.vector, Vector64.Create(1u, 1u));
            return new(Vector128.Create(a, b));

        }
    }


}
