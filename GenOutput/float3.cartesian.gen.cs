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
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 0) & math.v3_iz_float128);
            
            
            return new(this.x, this.x, this.x);
        }
    }
    public float3 xxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 16) & math.v3_iz_float128);
            
            
            return new(this.x, this.x, this.y);
        }
    }
    public float3 xxz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 32) & math.v3_iz_float128);
            
            
            return new(this.x, this.x, this.z);
        }
    }
    public float3 xyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 4) & math.v3_iz_float128);
            
            
            return new(this.x, this.y, this.x);
        }
    }
    public float3 xyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 20) & math.v3_iz_float128);
            
            
            return new(this.x, this.y, this.y);
        }
    }
    public float3 xyz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 36) & math.v3_iz_float128);
            
            
            return new(this.x, this.y, this.z);
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
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 8) & math.v3_iz_float128);
            
            
            return new(this.x, this.z, this.x);
        }
    }
    public float3 xzy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 24) & math.v3_iz_float128);
            
            
            return new(this.x, this.z, this.y);
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
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 40) & math.v3_iz_float128);
            
            
            return new(this.x, this.z, this.z);
        }
    }
    public float3 yxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 1) & math.v3_iz_float128);
            
            
            return new(this.y, this.x, this.x);
        }
    }
    public float3 yxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 17) & math.v3_iz_float128);
            
            
            return new(this.y, this.x, this.y);
        }
    }
    public float3 yxz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 33) & math.v3_iz_float128);
            
            
            return new(this.y, this.x, this.z);
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
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 5) & math.v3_iz_float128);
            
            
            return new(this.y, this.y, this.x);
        }
    }
    public float3 yyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 21) & math.v3_iz_float128);
            
            
            return new(this.y, this.y, this.y);
        }
    }
    public float3 yyz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 37) & math.v3_iz_float128);
            
            
            return new(this.y, this.y, this.z);
        }
    }
    public float3 yzx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 9) & math.v3_iz_float128);
            
            
            return new(this.y, this.z, this.x);
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
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 25) & math.v3_iz_float128);
            
            
            return new(this.y, this.z, this.y);
        }
    }
    public float3 yzz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 41) & math.v3_iz_float128);
            
            
            return new(this.y, this.z, this.z);
        }
    }
    public float3 zxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 2) & math.v3_iz_float128);
            
            
            return new(this.z, this.x, this.x);
        }
    }
    public float3 zxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 18) & math.v3_iz_float128);
            
            
            return new(this.z, this.x, this.y);
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
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 34) & math.v3_iz_float128);
            
            
            return new(this.z, this.x, this.z);
        }
    }
    public float3 zyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 6) & math.v3_iz_float128);
            
            
            return new(this.z, this.y, this.x);
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
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 22) & math.v3_iz_float128);
            
            
            return new(this.z, this.y, this.y);
        }
    }
    public float3 zyz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 38) & math.v3_iz_float128);
            
            
            return new(this.z, this.y, this.z);
        }
    }
    public float3 zzx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 10) & math.v3_iz_float128);
            
            
            return new(this.z, this.z, this.x);
        }
    }
    public float3 zzy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 26) & math.v3_iz_float128);
            
            
            return new(this.z, this.z, this.y);
        }
    }
    public float3 zzz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 42) & math.v3_iz_float128);
            
            
            return new(this.z, this.z, this.z);
        }
    }
    public float3 rrr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 0) & math.v3_iz_float128);
            
            
            return new(this.r, this.r, this.r);
        }
    }
    public float3 rrg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 16) & math.v3_iz_float128);
            
            
            return new(this.r, this.r, this.g);
        }
    }
    public float3 rrb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 32) & math.v3_iz_float128);
            
            
            return new(this.r, this.r, this.b);
        }
    }
    public float3 rgr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 4) & math.v3_iz_float128);
            
            
            return new(this.r, this.g, this.r);
        }
    }
    public float3 rgg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 20) & math.v3_iz_float128);
            
            
            return new(this.r, this.g, this.g);
        }
    }
    public float3 rgb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 36) & math.v3_iz_float128);
            
            
            return new(this.r, this.g, this.b);
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
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 8) & math.v3_iz_float128);
            
            
            return new(this.r, this.b, this.r);
        }
    }
    public float3 rbg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 24) & math.v3_iz_float128);
            
            
            return new(this.r, this.b, this.g);
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
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 40) & math.v3_iz_float128);
            
            
            return new(this.r, this.b, this.b);
        }
    }
    public float3 grr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 1) & math.v3_iz_float128);
            
            
            return new(this.g, this.r, this.r);
        }
    }
    public float3 grg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 17) & math.v3_iz_float128);
            
            
            return new(this.g, this.r, this.g);
        }
    }
    public float3 grb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 33) & math.v3_iz_float128);
            
            
            return new(this.g, this.r, this.b);
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
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 5) & math.v3_iz_float128);
            
            
            return new(this.g, this.g, this.r);
        }
    }
    public float3 ggg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 21) & math.v3_iz_float128);
            
            
            return new(this.g, this.g, this.g);
        }
    }
    public float3 ggb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 37) & math.v3_iz_float128);
            
            
            return new(this.g, this.g, this.b);
        }
    }
    public float3 gbr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 9) & math.v3_iz_float128);
            
            
            return new(this.g, this.b, this.r);
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
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 25) & math.v3_iz_float128);
            
            
            return new(this.g, this.b, this.g);
        }
    }
    public float3 gbb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 41) & math.v3_iz_float128);
            
            
            return new(this.g, this.b, this.b);
        }
    }
    public float3 brr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 2) & math.v3_iz_float128);
            
            
            return new(this.b, this.r, this.r);
        }
    }
    public float3 brg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 18) & math.v3_iz_float128);
            
            
            return new(this.b, this.r, this.g);
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
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 34) & math.v3_iz_float128);
            
            
            return new(this.b, this.r, this.b);
        }
    }
    public float3 bgr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 6) & math.v3_iz_float128);
            
            
            return new(this.b, this.g, this.r);
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
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 22) & math.v3_iz_float128);
            
            
            return new(this.b, this.g, this.g);
        }
    }
    public float3 bgb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 38) & math.v3_iz_float128);
            
            
            return new(this.b, this.g, this.b);
        }
    }
    public float3 bbr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 10) & math.v3_iz_float128);
            
            
            return new(this.b, this.b, this.r);
        }
    }
    public float3 bbg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 26) & math.v3_iz_float128);
            
            
            return new(this.b, this.b, this.g);
        }
    }
    public float3 bbb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 42) & math.v3_iz_float128);
            
            
            return new(this.b, this.b, this.b);
        }
    }
    public float4 xxxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 0));
            
            
            return new(this.x, this.x, this.x, this.x);
        }
    }
    public float4 xxxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 64));
            
            
            return new(this.x, this.x, this.x, this.y);
        }
    }
    public float4 xxxz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 128));
            
            
            return new(this.x, this.x, this.x, this.z);
        }
    }
    public float4 xxyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 16));
            
            
            return new(this.x, this.x, this.y, this.x);
        }
    }
    public float4 xxyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 80));
            
            
            return new(this.x, this.x, this.y, this.y);
        }
    }
    public float4 xxyz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 144));
            
            
            return new(this.x, this.x, this.y, this.z);
        }
    }
    public float4 xxzx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 32));
            
            
            return new(this.x, this.x, this.z, this.x);
        }
    }
    public float4 xxzy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 96));
            
            
            return new(this.x, this.x, this.z, this.y);
        }
    }
    public float4 xxzz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 160));
            
            
            return new(this.x, this.x, this.z, this.z);
        }
    }
    public float4 xyxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 4));
            
            
            return new(this.x, this.y, this.x, this.x);
        }
    }
    public float4 xyxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 68));
            
            
            return new(this.x, this.y, this.x, this.y);
        }
    }
    public float4 xyxz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 132));
            
            
            return new(this.x, this.y, this.x, this.z);
        }
    }
    public float4 xyyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 20));
            
            
            return new(this.x, this.y, this.y, this.x);
        }
    }
    public float4 xyyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 84));
            
            
            return new(this.x, this.y, this.y, this.y);
        }
    }
    public float4 xyyz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 148));
            
            
            return new(this.x, this.y, this.y, this.z);
        }
    }
    public float4 xyzx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 36));
            
            
            return new(this.x, this.y, this.z, this.x);
        }
    }
    public float4 xyzy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 100));
            
            
            return new(this.x, this.y, this.z, this.y);
        }
    }
    public float4 xyzz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 164));
            
            
            return new(this.x, this.y, this.z, this.z);
        }
    }
    public float4 xzxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 8));
            
            
            return new(this.x, this.z, this.x, this.x);
        }
    }
    public float4 xzxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 72));
            
            
            return new(this.x, this.z, this.x, this.y);
        }
    }
    public float4 xzxz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 136));
            
            
            return new(this.x, this.z, this.x, this.z);
        }
    }
    public float4 xzyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 24));
            
            
            return new(this.x, this.z, this.y, this.x);
        }
    }
    public float4 xzyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 88));
            
            
            return new(this.x, this.z, this.y, this.y);
        }
    }
    public float4 xzyz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 152));
            
            
            return new(this.x, this.z, this.y, this.z);
        }
    }
    public float4 xzzx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 40));
            
            
            return new(this.x, this.z, this.z, this.x);
        }
    }
    public float4 xzzy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 104));
            
            
            return new(this.x, this.z, this.z, this.y);
        }
    }
    public float4 xzzz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 168));
            
            
            return new(this.x, this.z, this.z, this.z);
        }
    }
    public float4 yxxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 1));
            
            
            return new(this.y, this.x, this.x, this.x);
        }
    }
    public float4 yxxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 65));
            
            
            return new(this.y, this.x, this.x, this.y);
        }
    }
    public float4 yxxz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 129));
            
            
            return new(this.y, this.x, this.x, this.z);
        }
    }
    public float4 yxyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 17));
            
            
            return new(this.y, this.x, this.y, this.x);
        }
    }
    public float4 yxyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 81));
            
            
            return new(this.y, this.x, this.y, this.y);
        }
    }
    public float4 yxyz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 145));
            
            
            return new(this.y, this.x, this.y, this.z);
        }
    }
    public float4 yxzx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 33));
            
            
            return new(this.y, this.x, this.z, this.x);
        }
    }
    public float4 yxzy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 97));
            
            
            return new(this.y, this.x, this.z, this.y);
        }
    }
    public float4 yxzz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 161));
            
            
            return new(this.y, this.x, this.z, this.z);
        }
    }
    public float4 yyxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 5));
            
            
            return new(this.y, this.y, this.x, this.x);
        }
    }
    public float4 yyxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 69));
            
            
            return new(this.y, this.y, this.x, this.y);
        }
    }
    public float4 yyxz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 133));
            
            
            return new(this.y, this.y, this.x, this.z);
        }
    }
    public float4 yyyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 21));
            
            
            return new(this.y, this.y, this.y, this.x);
        }
    }
    public float4 yyyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 85));
            
            
            return new(this.y, this.y, this.y, this.y);
        }
    }
    public float4 yyyz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 149));
            
            
            return new(this.y, this.y, this.y, this.z);
        }
    }
    public float4 yyzx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 37));
            
            
            return new(this.y, this.y, this.z, this.x);
        }
    }
    public float4 yyzy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 101));
            
            
            return new(this.y, this.y, this.z, this.y);
        }
    }
    public float4 yyzz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 165));
            
            
            return new(this.y, this.y, this.z, this.z);
        }
    }
    public float4 yzxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 9));
            
            
            return new(this.y, this.z, this.x, this.x);
        }
    }
    public float4 yzxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 73));
            
            
            return new(this.y, this.z, this.x, this.y);
        }
    }
    public float4 yzxz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 137));
            
            
            return new(this.y, this.z, this.x, this.z);
        }
    }
    public float4 yzyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 25));
            
            
            return new(this.y, this.z, this.y, this.x);
        }
    }
    public float4 yzyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 89));
            
            
            return new(this.y, this.z, this.y, this.y);
        }
    }
    public float4 yzyz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 153));
            
            
            return new(this.y, this.z, this.y, this.z);
        }
    }
    public float4 yzzx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 41));
            
            
            return new(this.y, this.z, this.z, this.x);
        }
    }
    public float4 yzzy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 105));
            
            
            return new(this.y, this.z, this.z, this.y);
        }
    }
    public float4 yzzz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 169));
            
            
            return new(this.y, this.z, this.z, this.z);
        }
    }
    public float4 zxxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 2));
            
            
            return new(this.z, this.x, this.x, this.x);
        }
    }
    public float4 zxxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 66));
            
            
            return new(this.z, this.x, this.x, this.y);
        }
    }
    public float4 zxxz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 130));
            
            
            return new(this.z, this.x, this.x, this.z);
        }
    }
    public float4 zxyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 18));
            
            
            return new(this.z, this.x, this.y, this.x);
        }
    }
    public float4 zxyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 82));
            
            
            return new(this.z, this.x, this.y, this.y);
        }
    }
    public float4 zxyz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 146));
            
            
            return new(this.z, this.x, this.y, this.z);
        }
    }
    public float4 zxzx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 34));
            
            
            return new(this.z, this.x, this.z, this.x);
        }
    }
    public float4 zxzy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 98));
            
            
            return new(this.z, this.x, this.z, this.y);
        }
    }
    public float4 zxzz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 162));
            
            
            return new(this.z, this.x, this.z, this.z);
        }
    }
    public float4 zyxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 6));
            
            
            return new(this.z, this.y, this.x, this.x);
        }
    }
    public float4 zyxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 70));
            
            
            return new(this.z, this.y, this.x, this.y);
        }
    }
    public float4 zyxz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 134));
            
            
            return new(this.z, this.y, this.x, this.z);
        }
    }
    public float4 zyyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 22));
            
            
            return new(this.z, this.y, this.y, this.x);
        }
    }
    public float4 zyyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 86));
            
            
            return new(this.z, this.y, this.y, this.y);
        }
    }
    public float4 zyyz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 150));
            
            
            return new(this.z, this.y, this.y, this.z);
        }
    }
    public float4 zyzx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 38));
            
            
            return new(this.z, this.y, this.z, this.x);
        }
    }
    public float4 zyzy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 102));
            
            
            return new(this.z, this.y, this.z, this.y);
        }
    }
    public float4 zyzz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 166));
            
            
            return new(this.z, this.y, this.z, this.z);
        }
    }
    public float4 zzxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 10));
            
            
            return new(this.z, this.z, this.x, this.x);
        }
    }
    public float4 zzxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 74));
            
            
            return new(this.z, this.z, this.x, this.y);
        }
    }
    public float4 zzxz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 138));
            
            
            return new(this.z, this.z, this.x, this.z);
        }
    }
    public float4 zzyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 26));
            
            
            return new(this.z, this.z, this.y, this.x);
        }
    }
    public float4 zzyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 90));
            
            
            return new(this.z, this.z, this.y, this.y);
        }
    }
    public float4 zzyz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 154));
            
            
            return new(this.z, this.z, this.y, this.z);
        }
    }
    public float4 zzzx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 42));
            
            
            return new(this.z, this.z, this.z, this.x);
        }
    }
    public float4 zzzy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 106));
            
            
            return new(this.z, this.z, this.z, this.y);
        }
    }
    public float4 zzzz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 170));
            
            
            return new(this.z, this.z, this.z, this.z);
        }
    }
    public float4 rrrr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 0));
            
            
            return new(this.r, this.r, this.r, this.r);
        }
    }
    public float4 rrrg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 64));
            
            
            return new(this.r, this.r, this.r, this.g);
        }
    }
    public float4 rrrb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 128));
            
            
            return new(this.r, this.r, this.r, this.b);
        }
    }
    public float4 rrgr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 16));
            
            
            return new(this.r, this.r, this.g, this.r);
        }
    }
    public float4 rrgg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 80));
            
            
            return new(this.r, this.r, this.g, this.g);
        }
    }
    public float4 rrgb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 144));
            
            
            return new(this.r, this.r, this.g, this.b);
        }
    }
    public float4 rrbr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 32));
            
            
            return new(this.r, this.r, this.b, this.r);
        }
    }
    public float4 rrbg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 96));
            
            
            return new(this.r, this.r, this.b, this.g);
        }
    }
    public float4 rrbb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 160));
            
            
            return new(this.r, this.r, this.b, this.b);
        }
    }
    public float4 rgrr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 4));
            
            
            return new(this.r, this.g, this.r, this.r);
        }
    }
    public float4 rgrg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 68));
            
            
            return new(this.r, this.g, this.r, this.g);
        }
    }
    public float4 rgrb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 132));
            
            
            return new(this.r, this.g, this.r, this.b);
        }
    }
    public float4 rggr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 20));
            
            
            return new(this.r, this.g, this.g, this.r);
        }
    }
    public float4 rggg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 84));
            
            
            return new(this.r, this.g, this.g, this.g);
        }
    }
    public float4 rggb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 148));
            
            
            return new(this.r, this.g, this.g, this.b);
        }
    }
    public float4 rgbr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 36));
            
            
            return new(this.r, this.g, this.b, this.r);
        }
    }
    public float4 rgbg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 100));
            
            
            return new(this.r, this.g, this.b, this.g);
        }
    }
    public float4 rgbb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 164));
            
            
            return new(this.r, this.g, this.b, this.b);
        }
    }
    public float4 rbrr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 8));
            
            
            return new(this.r, this.b, this.r, this.r);
        }
    }
    public float4 rbrg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 72));
            
            
            return new(this.r, this.b, this.r, this.g);
        }
    }
    public float4 rbrb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 136));
            
            
            return new(this.r, this.b, this.r, this.b);
        }
    }
    public float4 rbgr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 24));
            
            
            return new(this.r, this.b, this.g, this.r);
        }
    }
    public float4 rbgg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 88));
            
            
            return new(this.r, this.b, this.g, this.g);
        }
    }
    public float4 rbgb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 152));
            
            
            return new(this.r, this.b, this.g, this.b);
        }
    }
    public float4 rbbr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 40));
            
            
            return new(this.r, this.b, this.b, this.r);
        }
    }
    public float4 rbbg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 104));
            
            
            return new(this.r, this.b, this.b, this.g);
        }
    }
    public float4 rbbb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 168));
            
            
            return new(this.r, this.b, this.b, this.b);
        }
    }
    public float4 grrr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 1));
            
            
            return new(this.g, this.r, this.r, this.r);
        }
    }
    public float4 grrg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 65));
            
            
            return new(this.g, this.r, this.r, this.g);
        }
    }
    public float4 grrb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 129));
            
            
            return new(this.g, this.r, this.r, this.b);
        }
    }
    public float4 grgr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 17));
            
            
            return new(this.g, this.r, this.g, this.r);
        }
    }
    public float4 grgg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 81));
            
            
            return new(this.g, this.r, this.g, this.g);
        }
    }
    public float4 grgb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 145));
            
            
            return new(this.g, this.r, this.g, this.b);
        }
    }
    public float4 grbr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 33));
            
            
            return new(this.g, this.r, this.b, this.r);
        }
    }
    public float4 grbg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 97));
            
            
            return new(this.g, this.r, this.b, this.g);
        }
    }
    public float4 grbb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 161));
            
            
            return new(this.g, this.r, this.b, this.b);
        }
    }
    public float4 ggrr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 5));
            
            
            return new(this.g, this.g, this.r, this.r);
        }
    }
    public float4 ggrg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 69));
            
            
            return new(this.g, this.g, this.r, this.g);
        }
    }
    public float4 ggrb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 133));
            
            
            return new(this.g, this.g, this.r, this.b);
        }
    }
    public float4 gggr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 21));
            
            
            return new(this.g, this.g, this.g, this.r);
        }
    }
    public float4 gggg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 85));
            
            
            return new(this.g, this.g, this.g, this.g);
        }
    }
    public float4 gggb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 149));
            
            
            return new(this.g, this.g, this.g, this.b);
        }
    }
    public float4 ggbr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 37));
            
            
            return new(this.g, this.g, this.b, this.r);
        }
    }
    public float4 ggbg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 101));
            
            
            return new(this.g, this.g, this.b, this.g);
        }
    }
    public float4 ggbb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 165));
            
            
            return new(this.g, this.g, this.b, this.b);
        }
    }
    public float4 gbrr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 9));
            
            
            return new(this.g, this.b, this.r, this.r);
        }
    }
    public float4 gbrg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 73));
            
            
            return new(this.g, this.b, this.r, this.g);
        }
    }
    public float4 gbrb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 137));
            
            
            return new(this.g, this.b, this.r, this.b);
        }
    }
    public float4 gbgr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 25));
            
            
            return new(this.g, this.b, this.g, this.r);
        }
    }
    public float4 gbgg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 89));
            
            
            return new(this.g, this.b, this.g, this.g);
        }
    }
    public float4 gbgb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 153));
            
            
            return new(this.g, this.b, this.g, this.b);
        }
    }
    public float4 gbbr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 41));
            
            
            return new(this.g, this.b, this.b, this.r);
        }
    }
    public float4 gbbg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 105));
            
            
            return new(this.g, this.b, this.b, this.g);
        }
    }
    public float4 gbbb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 169));
            
            
            return new(this.g, this.b, this.b, this.b);
        }
    }
    public float4 brrr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 2));
            
            
            return new(this.b, this.r, this.r, this.r);
        }
    }
    public float4 brrg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 66));
            
            
            return new(this.b, this.r, this.r, this.g);
        }
    }
    public float4 brrb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 130));
            
            
            return new(this.b, this.r, this.r, this.b);
        }
    }
    public float4 brgr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 18));
            
            
            return new(this.b, this.r, this.g, this.r);
        }
    }
    public float4 brgg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 82));
            
            
            return new(this.b, this.r, this.g, this.g);
        }
    }
    public float4 brgb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 146));
            
            
            return new(this.b, this.r, this.g, this.b);
        }
    }
    public float4 brbr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 34));
            
            
            return new(this.b, this.r, this.b, this.r);
        }
    }
    public float4 brbg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 98));
            
            
            return new(this.b, this.r, this.b, this.g);
        }
    }
    public float4 brbb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 162));
            
            
            return new(this.b, this.r, this.b, this.b);
        }
    }
    public float4 bgrr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 6));
            
            
            return new(this.b, this.g, this.r, this.r);
        }
    }
    public float4 bgrg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 70));
            
            
            return new(this.b, this.g, this.r, this.g);
        }
    }
    public float4 bgrb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 134));
            
            
            return new(this.b, this.g, this.r, this.b);
        }
    }
    public float4 bggr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 22));
            
            
            return new(this.b, this.g, this.g, this.r);
        }
    }
    public float4 bggg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 86));
            
            
            return new(this.b, this.g, this.g, this.g);
        }
    }
    public float4 bggb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 150));
            
            
            return new(this.b, this.g, this.g, this.b);
        }
    }
    public float4 bgbr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 38));
            
            
            return new(this.b, this.g, this.b, this.r);
        }
    }
    public float4 bgbg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 102));
            
            
            return new(this.b, this.g, this.b, this.g);
        }
    }
    public float4 bgbb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 166));
            
            
            return new(this.b, this.g, this.b, this.b);
        }
    }
    public float4 bbrr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 10));
            
            
            return new(this.b, this.b, this.r, this.r);
        }
    }
    public float4 bbrg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 74));
            
            
            return new(this.b, this.b, this.r, this.g);
        }
    }
    public float4 bbrb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 138));
            
            
            return new(this.b, this.b, this.r, this.b);
        }
    }
    public float4 bbgr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 26));
            
            
            return new(this.b, this.b, this.g, this.r);
        }
    }
    public float4 bbgg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 90));
            
            
            return new(this.b, this.b, this.g, this.g);
        }
    }
    public float4 bbgb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 154));
            
            
            return new(this.b, this.b, this.g, this.b);
        }
    }
    public float4 bbbr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 42));
            
            
            return new(this.b, this.b, this.b, this.r);
        }
    }
    public float4 bbbg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 106));
            
            
            return new(this.b, this.b, this.b, this.g);
        }
    }
    public float4 bbbb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 170));
            
            
            return new(this.b, this.b, this.b, this.b);
        }
    }


}
