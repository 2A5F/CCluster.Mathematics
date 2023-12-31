using System;
using System.Numerics;
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.X86;
using System.Runtime.Intrinsics.Arm;
using System.Runtime.CompilerServices;

#nullable enable
#pragma warning disable CS8981

namespace CCluster.Mathematics;

public partial struct float2 
{

    public float2 xx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector64.Shuffle(this.vector, Vector64.Create(0, 0)));

        }
    }
    public float2 xy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector64.Shuffle(this.vector, Vector64.Create(0, 1)));

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.x = value.x; this.y = value.y; 
        }
    }
    public float2 yx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector64.Shuffle(this.vector, Vector64.Create(1, 0)));

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

            return new(Vector64.Shuffle(this.vector, Vector64.Create(1, 1)));

        }
    }
    public float2 rr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector64.Shuffle(this.vector, Vector64.Create(0, 0)));

        }
    }
    public float2 rg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector64.Shuffle(this.vector, Vector64.Create(0, 1)));

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.r = value.x; this.g = value.y; 
        }
    }
    public float2 gr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            return new(Vector64.Shuffle(this.vector, Vector64.Create(1, 0)));

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

            return new(Vector64.Shuffle(this.vector, Vector64.Create(1, 1)));

        }
    }
    public float3 xxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            var a = Vector64.Shuffle(this.vector, Vector64.Create(0, 0));
            var b = Vector64.Shuffle(this.vector, Vector64.Create(0, 0));
            return new(Vector128.Create(a, b) & math.v3_iz_float128);

        }
    }
    public float3 xxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            var a = Vector64.Shuffle(this.vector, Vector64.Create(0, 0));
            var b = Vector64.Shuffle(this.vector, Vector64.Create(1, 0));
            return new(Vector128.Create(a, b) & math.v3_iz_float128);

        }
    }
    public float3 xyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            var a = Vector64.Shuffle(this.vector, Vector64.Create(0, 1));
            var b = Vector64.Shuffle(this.vector, Vector64.Create(0, 0));
            return new(Vector128.Create(a, b) & math.v3_iz_float128);

        }
    }
    public float3 xyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            var a = Vector64.Shuffle(this.vector, Vector64.Create(0, 1));
            var b = Vector64.Shuffle(this.vector, Vector64.Create(1, 0));
            return new(Vector128.Create(a, b) & math.v3_iz_float128);

        }
    }
    public float3 yxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            var a = Vector64.Shuffle(this.vector, Vector64.Create(1, 0));
            var b = Vector64.Shuffle(this.vector, Vector64.Create(0, 0));
            return new(Vector128.Create(a, b) & math.v3_iz_float128);

        }
    }
    public float3 yxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            var a = Vector64.Shuffle(this.vector, Vector64.Create(1, 0));
            var b = Vector64.Shuffle(this.vector, Vector64.Create(1, 0));
            return new(Vector128.Create(a, b) & math.v3_iz_float128);

        }
    }
    public float3 yyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            var a = Vector64.Shuffle(this.vector, Vector64.Create(1, 1));
            var b = Vector64.Shuffle(this.vector, Vector64.Create(0, 0));
            return new(Vector128.Create(a, b) & math.v3_iz_float128);

        }
    }
    public float3 yyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            var a = Vector64.Shuffle(this.vector, Vector64.Create(1, 1));
            var b = Vector64.Shuffle(this.vector, Vector64.Create(1, 0));
            return new(Vector128.Create(a, b) & math.v3_iz_float128);

        }
    }
    public float3 rrr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            var a = Vector64.Shuffle(this.vector, Vector64.Create(0, 0));
            var b = Vector64.Shuffle(this.vector, Vector64.Create(0, 0));
            return new(Vector128.Create(a, b) & math.v3_iz_float128);

        }
    }
    public float3 rrg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            var a = Vector64.Shuffle(this.vector, Vector64.Create(0, 0));
            var b = Vector64.Shuffle(this.vector, Vector64.Create(1, 0));
            return new(Vector128.Create(a, b) & math.v3_iz_float128);

        }
    }
    public float3 rgr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            var a = Vector64.Shuffle(this.vector, Vector64.Create(0, 1));
            var b = Vector64.Shuffle(this.vector, Vector64.Create(0, 0));
            return new(Vector128.Create(a, b) & math.v3_iz_float128);

        }
    }
    public float3 rgg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            var a = Vector64.Shuffle(this.vector, Vector64.Create(0, 1));
            var b = Vector64.Shuffle(this.vector, Vector64.Create(1, 0));
            return new(Vector128.Create(a, b) & math.v3_iz_float128);

        }
    }
    public float3 grr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            var a = Vector64.Shuffle(this.vector, Vector64.Create(1, 0));
            var b = Vector64.Shuffle(this.vector, Vector64.Create(0, 0));
            return new(Vector128.Create(a, b) & math.v3_iz_float128);

        }
    }
    public float3 grg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            var a = Vector64.Shuffle(this.vector, Vector64.Create(1, 0));
            var b = Vector64.Shuffle(this.vector, Vector64.Create(1, 0));
            return new(Vector128.Create(a, b) & math.v3_iz_float128);

        }
    }
    public float3 ggr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            var a = Vector64.Shuffle(this.vector, Vector64.Create(1, 1));
            var b = Vector64.Shuffle(this.vector, Vector64.Create(0, 0));
            return new(Vector128.Create(a, b) & math.v3_iz_float128);

        }
    }
    public float3 ggg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {

            var a = Vector64.Shuffle(this.vector, Vector64.Create(1, 1));
            var b = Vector64.Shuffle(this.vector, Vector64.Create(1, 0));
            return new(Vector128.Create(a, b) & math.v3_iz_float128);

        }
    }
    public float4 xxxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector64.Shuffle(this.vector, Vector64.Create(0, 0));
            var b = Vector64.Shuffle(this.vector, Vector64.Create(0, 0));
            return new(Vector128.Create(a, b));

        }
    }
    public float4 xxxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector64.Shuffle(this.vector, Vector64.Create(0, 0));
            var b = Vector64.Shuffle(this.vector, Vector64.Create(0, 1));
            return new(Vector128.Create(a, b));

        }
    }
    public float4 xxyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector64.Shuffle(this.vector, Vector64.Create(0, 0));
            var b = Vector64.Shuffle(this.vector, Vector64.Create(1, 0));
            return new(Vector128.Create(a, b));

        }
    }
    public float4 xxyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector64.Shuffle(this.vector, Vector64.Create(0, 0));
            var b = Vector64.Shuffle(this.vector, Vector64.Create(1, 1));
            return new(Vector128.Create(a, b));

        }
    }
    public float4 xyxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector64.Shuffle(this.vector, Vector64.Create(0, 1));
            var b = Vector64.Shuffle(this.vector, Vector64.Create(0, 0));
            return new(Vector128.Create(a, b));

        }
    }
    public float4 xyxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector64.Shuffle(this.vector, Vector64.Create(0, 1));
            var b = Vector64.Shuffle(this.vector, Vector64.Create(0, 1));
            return new(Vector128.Create(a, b));

        }
    }
    public float4 xyyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector64.Shuffle(this.vector, Vector64.Create(0, 1));
            var b = Vector64.Shuffle(this.vector, Vector64.Create(1, 0));
            return new(Vector128.Create(a, b));

        }
    }
    public float4 xyyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector64.Shuffle(this.vector, Vector64.Create(0, 1));
            var b = Vector64.Shuffle(this.vector, Vector64.Create(1, 1));
            return new(Vector128.Create(a, b));

        }
    }
    public float4 yxxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector64.Shuffle(this.vector, Vector64.Create(1, 0));
            var b = Vector64.Shuffle(this.vector, Vector64.Create(0, 0));
            return new(Vector128.Create(a, b));

        }
    }
    public float4 yxxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector64.Shuffle(this.vector, Vector64.Create(1, 0));
            var b = Vector64.Shuffle(this.vector, Vector64.Create(0, 1));
            return new(Vector128.Create(a, b));

        }
    }
    public float4 yxyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector64.Shuffle(this.vector, Vector64.Create(1, 0));
            var b = Vector64.Shuffle(this.vector, Vector64.Create(1, 0));
            return new(Vector128.Create(a, b));

        }
    }
    public float4 yxyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector64.Shuffle(this.vector, Vector64.Create(1, 0));
            var b = Vector64.Shuffle(this.vector, Vector64.Create(1, 1));
            return new(Vector128.Create(a, b));

        }
    }
    public float4 yyxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector64.Shuffle(this.vector, Vector64.Create(1, 1));
            var b = Vector64.Shuffle(this.vector, Vector64.Create(0, 0));
            return new(Vector128.Create(a, b));

        }
    }
    public float4 yyxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector64.Shuffle(this.vector, Vector64.Create(1, 1));
            var b = Vector64.Shuffle(this.vector, Vector64.Create(0, 1));
            return new(Vector128.Create(a, b));

        }
    }
    public float4 yyyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector64.Shuffle(this.vector, Vector64.Create(1, 1));
            var b = Vector64.Shuffle(this.vector, Vector64.Create(1, 0));
            return new(Vector128.Create(a, b));

        }
    }
    public float4 yyyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector64.Shuffle(this.vector, Vector64.Create(1, 1));
            var b = Vector64.Shuffle(this.vector, Vector64.Create(1, 1));
            return new(Vector128.Create(a, b));

        }
    }
    public float4 rrrr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector64.Shuffle(this.vector, Vector64.Create(0, 0));
            var b = Vector64.Shuffle(this.vector, Vector64.Create(0, 0));
            return new(Vector128.Create(a, b));

        }
    }
    public float4 rrrg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector64.Shuffle(this.vector, Vector64.Create(0, 0));
            var b = Vector64.Shuffle(this.vector, Vector64.Create(0, 1));
            return new(Vector128.Create(a, b));

        }
    }
    public float4 rrgr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector64.Shuffle(this.vector, Vector64.Create(0, 0));
            var b = Vector64.Shuffle(this.vector, Vector64.Create(1, 0));
            return new(Vector128.Create(a, b));

        }
    }
    public float4 rrgg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector64.Shuffle(this.vector, Vector64.Create(0, 0));
            var b = Vector64.Shuffle(this.vector, Vector64.Create(1, 1));
            return new(Vector128.Create(a, b));

        }
    }
    public float4 rgrr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector64.Shuffle(this.vector, Vector64.Create(0, 1));
            var b = Vector64.Shuffle(this.vector, Vector64.Create(0, 0));
            return new(Vector128.Create(a, b));

        }
    }
    public float4 rgrg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector64.Shuffle(this.vector, Vector64.Create(0, 1));
            var b = Vector64.Shuffle(this.vector, Vector64.Create(0, 1));
            return new(Vector128.Create(a, b));

        }
    }
    public float4 rggr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector64.Shuffle(this.vector, Vector64.Create(0, 1));
            var b = Vector64.Shuffle(this.vector, Vector64.Create(1, 0));
            return new(Vector128.Create(a, b));

        }
    }
    public float4 rggg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector64.Shuffle(this.vector, Vector64.Create(0, 1));
            var b = Vector64.Shuffle(this.vector, Vector64.Create(1, 1));
            return new(Vector128.Create(a, b));

        }
    }
    public float4 grrr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector64.Shuffle(this.vector, Vector64.Create(1, 0));
            var b = Vector64.Shuffle(this.vector, Vector64.Create(0, 0));
            return new(Vector128.Create(a, b));

        }
    }
    public float4 grrg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector64.Shuffle(this.vector, Vector64.Create(1, 0));
            var b = Vector64.Shuffle(this.vector, Vector64.Create(0, 1));
            return new(Vector128.Create(a, b));

        }
    }
    public float4 grgr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector64.Shuffle(this.vector, Vector64.Create(1, 0));
            var b = Vector64.Shuffle(this.vector, Vector64.Create(1, 0));
            return new(Vector128.Create(a, b));

        }
    }
    public float4 grgg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector64.Shuffle(this.vector, Vector64.Create(1, 0));
            var b = Vector64.Shuffle(this.vector, Vector64.Create(1, 1));
            return new(Vector128.Create(a, b));

        }
    }
    public float4 ggrr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector64.Shuffle(this.vector, Vector64.Create(1, 1));
            var b = Vector64.Shuffle(this.vector, Vector64.Create(0, 0));
            return new(Vector128.Create(a, b));

        }
    }
    public float4 ggrg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector64.Shuffle(this.vector, Vector64.Create(1, 1));
            var b = Vector64.Shuffle(this.vector, Vector64.Create(0, 1));
            return new(Vector128.Create(a, b));

        }
    }
    public float4 gggr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector64.Shuffle(this.vector, Vector64.Create(1, 1));
            var b = Vector64.Shuffle(this.vector, Vector64.Create(1, 0));
            return new(Vector128.Create(a, b));

        }
    }
    public float4 gggg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {

            var a = Vector64.Shuffle(this.vector, Vector64.Create(1, 1));
            var b = Vector64.Shuffle(this.vector, Vector64.Create(1, 1));
            return new(Vector128.Create(a, b));

        }
    }


}
