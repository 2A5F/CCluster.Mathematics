using System;
using System.Numerics;
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.X86;
using System.Runtime.Intrinsics.Arm;
using System.Runtime.CompilerServices;

#nullable enable
#pragma warning disable CS8981

namespace CCluster.Mathematics;

public partial struct float4 
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
    public float2 xw
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
    public float2 yw
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
    public float2 zw
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
    public float2 wx
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
    public float2 wy
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
    public float2 wz
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
    public float2 ww
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {
            
            return new(this.w, this.w);
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
    public float2 ra
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
    public float2 ga
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
    public float2 ba
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
    public float2 ar
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
    public float2 ag
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
    public float2 ab
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
    public float2 aa
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {
            
            return new(this.a, this.a);
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
    public float3 xxw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 48) & math.v3_iz_float128);
            
            
            return new(this.x, this.x, this.w);
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
    public float3 xyw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 52) & math.v3_iz_float128);
            
            
            return new(this.x, this.y, this.w);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.x = value.x; this.y = value.y; this.w = value.z; 
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
    public float3 xzw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 56) & math.v3_iz_float128);
            
            
            return new(this.x, this.z, this.w);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.x = value.x; this.z = value.y; this.w = value.z; 
        }
    }
    public float3 xwx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 12) & math.v3_iz_float128);
            
            
            return new(this.x, this.w, this.x);
        }
    }
    public float3 xwy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 28) & math.v3_iz_float128);
            
            
            return new(this.x, this.w, this.y);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.x = value.x; this.w = value.y; this.y = value.z; 
        }
    }
    public float3 xwz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 44) & math.v3_iz_float128);
            
            
            return new(this.x, this.w, this.z);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.x = value.x; this.w = value.y; this.z = value.z; 
        }
    }
    public float3 xww
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 60) & math.v3_iz_float128);
            
            
            return new(this.x, this.w, this.w);
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
    public float3 yxw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 49) & math.v3_iz_float128);
            
            
            return new(this.y, this.x, this.w);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.y = value.x; this.x = value.y; this.w = value.z; 
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
    public float3 yyw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 53) & math.v3_iz_float128);
            
            
            return new(this.y, this.y, this.w);
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
    public float3 yzw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 57) & math.v3_iz_float128);
            
            
            return new(this.y, this.z, this.w);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.y = value.x; this.z = value.y; this.w = value.z; 
        }
    }
    public float3 ywx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 13) & math.v3_iz_float128);
            
            
            return new(this.y, this.w, this.x);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.y = value.x; this.w = value.y; this.x = value.z; 
        }
    }
    public float3 ywy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 29) & math.v3_iz_float128);
            
            
            return new(this.y, this.w, this.y);
        }
    }
    public float3 ywz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 45) & math.v3_iz_float128);
            
            
            return new(this.y, this.w, this.z);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.y = value.x; this.w = value.y; this.z = value.z; 
        }
    }
    public float3 yww
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 61) & math.v3_iz_float128);
            
            
            return new(this.y, this.w, this.w);
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
    public float3 zxw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 50) & math.v3_iz_float128);
            
            
            return new(this.z, this.x, this.w);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.z = value.x; this.x = value.y; this.w = value.z; 
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
    public float3 zyw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 54) & math.v3_iz_float128);
            
            
            return new(this.z, this.y, this.w);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.z = value.x; this.y = value.y; this.w = value.z; 
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
    public float3 zzw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 58) & math.v3_iz_float128);
            
            
            return new(this.z, this.z, this.w);
        }
    }
    public float3 zwx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 14) & math.v3_iz_float128);
            
            
            return new(this.z, this.w, this.x);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.z = value.x; this.w = value.y; this.x = value.z; 
        }
    }
    public float3 zwy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 30) & math.v3_iz_float128);
            
            
            return new(this.z, this.w, this.y);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.z = value.x; this.w = value.y; this.y = value.z; 
        }
    }
    public float3 zwz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 46) & math.v3_iz_float128);
            
            
            return new(this.z, this.w, this.z);
        }
    }
    public float3 zww
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 62) & math.v3_iz_float128);
            
            
            return new(this.z, this.w, this.w);
        }
    }
    public float3 wxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 3) & math.v3_iz_float128);
            
            
            return new(this.w, this.x, this.x);
        }
    }
    public float3 wxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 19) & math.v3_iz_float128);
            
            
            return new(this.w, this.x, this.y);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.w = value.x; this.x = value.y; this.y = value.z; 
        }
    }
    public float3 wxz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 35) & math.v3_iz_float128);
            
            
            return new(this.w, this.x, this.z);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.w = value.x; this.x = value.y; this.z = value.z; 
        }
    }
    public float3 wxw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 51) & math.v3_iz_float128);
            
            
            return new(this.w, this.x, this.w);
        }
    }
    public float3 wyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 7) & math.v3_iz_float128);
            
            
            return new(this.w, this.y, this.x);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.w = value.x; this.y = value.y; this.x = value.z; 
        }
    }
    public float3 wyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 23) & math.v3_iz_float128);
            
            
            return new(this.w, this.y, this.y);
        }
    }
    public float3 wyz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 39) & math.v3_iz_float128);
            
            
            return new(this.w, this.y, this.z);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.w = value.x; this.y = value.y; this.z = value.z; 
        }
    }
    public float3 wyw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 55) & math.v3_iz_float128);
            
            
            return new(this.w, this.y, this.w);
        }
    }
    public float3 wzx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 11) & math.v3_iz_float128);
            
            
            return new(this.w, this.z, this.x);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.w = value.x; this.z = value.y; this.x = value.z; 
        }
    }
    public float3 wzy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 27) & math.v3_iz_float128);
            
            
            return new(this.w, this.z, this.y);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.w = value.x; this.z = value.y; this.y = value.z; 
        }
    }
    public float3 wzz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 43) & math.v3_iz_float128);
            
            
            return new(this.w, this.z, this.z);
        }
    }
    public float3 wzw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 59) & math.v3_iz_float128);
            
            
            return new(this.w, this.z, this.w);
        }
    }
    public float3 wwx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 15) & math.v3_iz_float128);
            
            
            return new(this.w, this.w, this.x);
        }
    }
    public float3 wwy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 31) & math.v3_iz_float128);
            
            
            return new(this.w, this.w, this.y);
        }
    }
    public float3 wwz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 47) & math.v3_iz_float128);
            
            
            return new(this.w, this.w, this.z);
        }
    }
    public float3 www
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 63) & math.v3_iz_float128);
            
            
            return new(this.w, this.w, this.w);
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
    public float3 rra
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 48) & math.v3_iz_float128);
            
            
            return new(this.r, this.r, this.a);
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
    public float3 rga
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 52) & math.v3_iz_float128);
            
            
            return new(this.r, this.g, this.a);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.r = value.x; this.g = value.y; this.a = value.z; 
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
    public float3 rba
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 56) & math.v3_iz_float128);
            
            
            return new(this.r, this.b, this.a);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.r = value.x; this.b = value.y; this.a = value.z; 
        }
    }
    public float3 rar
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 12) & math.v3_iz_float128);
            
            
            return new(this.r, this.a, this.r);
        }
    }
    public float3 rag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 28) & math.v3_iz_float128);
            
            
            return new(this.r, this.a, this.g);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.r = value.x; this.a = value.y; this.g = value.z; 
        }
    }
    public float3 rab
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 44) & math.v3_iz_float128);
            
            
            return new(this.r, this.a, this.b);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.r = value.x; this.a = value.y; this.b = value.z; 
        }
    }
    public float3 raa
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 60) & math.v3_iz_float128);
            
            
            return new(this.r, this.a, this.a);
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
    public float3 gra
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 49) & math.v3_iz_float128);
            
            
            return new(this.g, this.r, this.a);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.g = value.x; this.r = value.y; this.a = value.z; 
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
    public float3 gga
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 53) & math.v3_iz_float128);
            
            
            return new(this.g, this.g, this.a);
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
    public float3 gba
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 57) & math.v3_iz_float128);
            
            
            return new(this.g, this.b, this.a);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.g = value.x; this.b = value.y; this.a = value.z; 
        }
    }
    public float3 gar
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 13) & math.v3_iz_float128);
            
            
            return new(this.g, this.a, this.r);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.g = value.x; this.a = value.y; this.r = value.z; 
        }
    }
    public float3 gag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 29) & math.v3_iz_float128);
            
            
            return new(this.g, this.a, this.g);
        }
    }
    public float3 gab
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 45) & math.v3_iz_float128);
            
            
            return new(this.g, this.a, this.b);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.g = value.x; this.a = value.y; this.b = value.z; 
        }
    }
    public float3 gaa
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 61) & math.v3_iz_float128);
            
            
            return new(this.g, this.a, this.a);
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
    public float3 bra
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 50) & math.v3_iz_float128);
            
            
            return new(this.b, this.r, this.a);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.b = value.x; this.r = value.y; this.a = value.z; 
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
    public float3 bga
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 54) & math.v3_iz_float128);
            
            
            return new(this.b, this.g, this.a);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.b = value.x; this.g = value.y; this.a = value.z; 
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
    public float3 bba
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 58) & math.v3_iz_float128);
            
            
            return new(this.b, this.b, this.a);
        }
    }
    public float3 bar
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 14) & math.v3_iz_float128);
            
            
            return new(this.b, this.a, this.r);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.b = value.x; this.a = value.y; this.r = value.z; 
        }
    }
    public float3 bag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 30) & math.v3_iz_float128);
            
            
            return new(this.b, this.a, this.g);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.b = value.x; this.a = value.y; this.g = value.z; 
        }
    }
    public float3 bab
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 46) & math.v3_iz_float128);
            
            
            return new(this.b, this.a, this.b);
        }
    }
    public float3 baa
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 62) & math.v3_iz_float128);
            
            
            return new(this.b, this.a, this.a);
        }
    }
    public float3 arr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 3) & math.v3_iz_float128);
            
            
            return new(this.a, this.r, this.r);
        }
    }
    public float3 arg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 19) & math.v3_iz_float128);
            
            
            return new(this.a, this.r, this.g);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.a = value.x; this.r = value.y; this.g = value.z; 
        }
    }
    public float3 arb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 35) & math.v3_iz_float128);
            
            
            return new(this.a, this.r, this.b);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.a = value.x; this.r = value.y; this.b = value.z; 
        }
    }
    public float3 ara
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 51) & math.v3_iz_float128);
            
            
            return new(this.a, this.r, this.a);
        }
    }
    public float3 agr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 7) & math.v3_iz_float128);
            
            
            return new(this.a, this.g, this.r);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.a = value.x; this.g = value.y; this.r = value.z; 
        }
    }
    public float3 agg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 23) & math.v3_iz_float128);
            
            
            return new(this.a, this.g, this.g);
        }
    }
    public float3 agb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 39) & math.v3_iz_float128);
            
            
            return new(this.a, this.g, this.b);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.a = value.x; this.g = value.y; this.b = value.z; 
        }
    }
    public float3 aga
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 55) & math.v3_iz_float128);
            
            
            return new(this.a, this.g, this.a);
        }
    }
    public float3 abr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 11) & math.v3_iz_float128);
            
            
            return new(this.a, this.b, this.r);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.a = value.x; this.b = value.y; this.r = value.z; 
        }
    }
    public float3 abg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 27) & math.v3_iz_float128);
            
            
            return new(this.a, this.b, this.g);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        { 
            this.a = value.x; this.b = value.y; this.g = value.z; 
        }
    }
    public float3 abb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 43) & math.v3_iz_float128);
            
            
            return new(this.a, this.b, this.b);
        }
    }
    public float3 aba
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 59) & math.v3_iz_float128);
            
            
            return new(this.a, this.b, this.a);
        }
    }
    public float3 aar
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 15) & math.v3_iz_float128);
            
            
            return new(this.a, this.a, this.r);
        }
    }
    public float3 aag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 31) & math.v3_iz_float128);
            
            
            return new(this.a, this.a, this.g);
        }
    }
    public float3 aab
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 47) & math.v3_iz_float128);
            
            
            return new(this.a, this.a, this.b);
        }
    }
    public float3 aaa
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 63) & math.v3_iz_float128);
            
            
            return new(this.a, this.a, this.a);
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
    public float4 xxxw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 192));
            
            
            return new(this.x, this.x, this.x, this.w);
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
    public float4 xxyw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 208));
            
            
            return new(this.x, this.x, this.y, this.w);
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
    public float4 xxzw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 224));
            
            
            return new(this.x, this.x, this.z, this.w);
        }
    }
    public float4 xxwx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 48));
            
            
            return new(this.x, this.x, this.w, this.x);
        }
    }
    public float4 xxwy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 112));
            
            
            return new(this.x, this.x, this.w, this.y);
        }
    }
    public float4 xxwz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 176));
            
            
            return new(this.x, this.x, this.w, this.z);
        }
    }
    public float4 xxww
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 240));
            
            
            return new(this.x, this.x, this.w, this.w);
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
    public float4 xyxw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 196));
            
            
            return new(this.x, this.y, this.x, this.w);
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
    public float4 xyyw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 212));
            
            
            return new(this.x, this.y, this.y, this.w);
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
    public float4 xyzw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 228));
            
            
            return new(this.x, this.y, this.z, this.w);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        {
            this.x = value.x; this.y = value.y; this.z = value.z; this.w = value.w; 
        }
    }
    public float4 xywx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 52));
            
            
            return new(this.x, this.y, this.w, this.x);
        }
    }
    public float4 xywy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 116));
            
            
            return new(this.x, this.y, this.w, this.y);
        }
    }
    public float4 xywz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 180));
            
            
            return new(this.x, this.y, this.w, this.z);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        {
            this.x = value.x; this.y = value.y; this.w = value.z; this.z = value.w; 
        }
    }
    public float4 xyww
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 244));
            
            
            return new(this.x, this.y, this.w, this.w);
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
    public float4 xzxw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 200));
            
            
            return new(this.x, this.z, this.x, this.w);
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
    public float4 xzyw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 216));
            
            
            return new(this.x, this.z, this.y, this.w);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        {
            this.x = value.x; this.z = value.y; this.y = value.z; this.w = value.w; 
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
    public float4 xzzw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 232));
            
            
            return new(this.x, this.z, this.z, this.w);
        }
    }
    public float4 xzwx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 56));
            
            
            return new(this.x, this.z, this.w, this.x);
        }
    }
    public float4 xzwy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 120));
            
            
            return new(this.x, this.z, this.w, this.y);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        {
            this.x = value.x; this.z = value.y; this.w = value.z; this.y = value.w; 
        }
    }
    public float4 xzwz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 184));
            
            
            return new(this.x, this.z, this.w, this.z);
        }
    }
    public float4 xzww
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 248));
            
            
            return new(this.x, this.z, this.w, this.w);
        }
    }
    public float4 xwxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 12));
            
            
            return new(this.x, this.w, this.x, this.x);
        }
    }
    public float4 xwxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 76));
            
            
            return new(this.x, this.w, this.x, this.y);
        }
    }
    public float4 xwxz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 140));
            
            
            return new(this.x, this.w, this.x, this.z);
        }
    }
    public float4 xwxw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 204));
            
            
            return new(this.x, this.w, this.x, this.w);
        }
    }
    public float4 xwyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 28));
            
            
            return new(this.x, this.w, this.y, this.x);
        }
    }
    public float4 xwyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 92));
            
            
            return new(this.x, this.w, this.y, this.y);
        }
    }
    public float4 xwyz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 156));
            
            
            return new(this.x, this.w, this.y, this.z);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        {
            this.x = value.x; this.w = value.y; this.y = value.z; this.z = value.w; 
        }
    }
    public float4 xwyw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 220));
            
            
            return new(this.x, this.w, this.y, this.w);
        }
    }
    public float4 xwzx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 44));
            
            
            return new(this.x, this.w, this.z, this.x);
        }
    }
    public float4 xwzy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 108));
            
            
            return new(this.x, this.w, this.z, this.y);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        {
            this.x = value.x; this.w = value.y; this.z = value.z; this.y = value.w; 
        }
    }
    public float4 xwzz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 172));
            
            
            return new(this.x, this.w, this.z, this.z);
        }
    }
    public float4 xwzw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 236));
            
            
            return new(this.x, this.w, this.z, this.w);
        }
    }
    public float4 xwwx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 60));
            
            
            return new(this.x, this.w, this.w, this.x);
        }
    }
    public float4 xwwy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 124));
            
            
            return new(this.x, this.w, this.w, this.y);
        }
    }
    public float4 xwwz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 188));
            
            
            return new(this.x, this.w, this.w, this.z);
        }
    }
    public float4 xwww
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 252));
            
            
            return new(this.x, this.w, this.w, this.w);
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
    public float4 yxxw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 193));
            
            
            return new(this.y, this.x, this.x, this.w);
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
    public float4 yxyw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 209));
            
            
            return new(this.y, this.x, this.y, this.w);
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
    public float4 yxzw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 225));
            
            
            return new(this.y, this.x, this.z, this.w);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        {
            this.y = value.x; this.x = value.y; this.z = value.z; this.w = value.w; 
        }
    }
    public float4 yxwx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 49));
            
            
            return new(this.y, this.x, this.w, this.x);
        }
    }
    public float4 yxwy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 113));
            
            
            return new(this.y, this.x, this.w, this.y);
        }
    }
    public float4 yxwz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 177));
            
            
            return new(this.y, this.x, this.w, this.z);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        {
            this.y = value.x; this.x = value.y; this.w = value.z; this.z = value.w; 
        }
    }
    public float4 yxww
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 241));
            
            
            return new(this.y, this.x, this.w, this.w);
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
    public float4 yyxw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 197));
            
            
            return new(this.y, this.y, this.x, this.w);
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
    public float4 yyyw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 213));
            
            
            return new(this.y, this.y, this.y, this.w);
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
    public float4 yyzw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 229));
            
            
            return new(this.y, this.y, this.z, this.w);
        }
    }
    public float4 yywx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 53));
            
            
            return new(this.y, this.y, this.w, this.x);
        }
    }
    public float4 yywy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 117));
            
            
            return new(this.y, this.y, this.w, this.y);
        }
    }
    public float4 yywz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 181));
            
            
            return new(this.y, this.y, this.w, this.z);
        }
    }
    public float4 yyww
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 245));
            
            
            return new(this.y, this.y, this.w, this.w);
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
    public float4 yzxw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 201));
            
            
            return new(this.y, this.z, this.x, this.w);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        {
            this.y = value.x; this.z = value.y; this.x = value.z; this.w = value.w; 
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
    public float4 yzyw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 217));
            
            
            return new(this.y, this.z, this.y, this.w);
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
    public float4 yzzw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 233));
            
            
            return new(this.y, this.z, this.z, this.w);
        }
    }
    public float4 yzwx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 57));
            
            
            return new(this.y, this.z, this.w, this.x);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        {
            this.y = value.x; this.z = value.y; this.w = value.z; this.x = value.w; 
        }
    }
    public float4 yzwy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 121));
            
            
            return new(this.y, this.z, this.w, this.y);
        }
    }
    public float4 yzwz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 185));
            
            
            return new(this.y, this.z, this.w, this.z);
        }
    }
    public float4 yzww
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 249));
            
            
            return new(this.y, this.z, this.w, this.w);
        }
    }
    public float4 ywxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 13));
            
            
            return new(this.y, this.w, this.x, this.x);
        }
    }
    public float4 ywxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 77));
            
            
            return new(this.y, this.w, this.x, this.y);
        }
    }
    public float4 ywxz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 141));
            
            
            return new(this.y, this.w, this.x, this.z);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        {
            this.y = value.x; this.w = value.y; this.x = value.z; this.z = value.w; 
        }
    }
    public float4 ywxw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 205));
            
            
            return new(this.y, this.w, this.x, this.w);
        }
    }
    public float4 ywyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 29));
            
            
            return new(this.y, this.w, this.y, this.x);
        }
    }
    public float4 ywyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 93));
            
            
            return new(this.y, this.w, this.y, this.y);
        }
    }
    public float4 ywyz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 157));
            
            
            return new(this.y, this.w, this.y, this.z);
        }
    }
    public float4 ywyw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 221));
            
            
            return new(this.y, this.w, this.y, this.w);
        }
    }
    public float4 ywzx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 45));
            
            
            return new(this.y, this.w, this.z, this.x);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        {
            this.y = value.x; this.w = value.y; this.z = value.z; this.x = value.w; 
        }
    }
    public float4 ywzy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 109));
            
            
            return new(this.y, this.w, this.z, this.y);
        }
    }
    public float4 ywzz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 173));
            
            
            return new(this.y, this.w, this.z, this.z);
        }
    }
    public float4 ywzw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 237));
            
            
            return new(this.y, this.w, this.z, this.w);
        }
    }
    public float4 ywwx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 61));
            
            
            return new(this.y, this.w, this.w, this.x);
        }
    }
    public float4 ywwy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 125));
            
            
            return new(this.y, this.w, this.w, this.y);
        }
    }
    public float4 ywwz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 189));
            
            
            return new(this.y, this.w, this.w, this.z);
        }
    }
    public float4 ywww
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 253));
            
            
            return new(this.y, this.w, this.w, this.w);
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
    public float4 zxxw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 194));
            
            
            return new(this.z, this.x, this.x, this.w);
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
    public float4 zxyw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 210));
            
            
            return new(this.z, this.x, this.y, this.w);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        {
            this.z = value.x; this.x = value.y; this.y = value.z; this.w = value.w; 
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
    public float4 zxzw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 226));
            
            
            return new(this.z, this.x, this.z, this.w);
        }
    }
    public float4 zxwx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 50));
            
            
            return new(this.z, this.x, this.w, this.x);
        }
    }
    public float4 zxwy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 114));
            
            
            return new(this.z, this.x, this.w, this.y);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        {
            this.z = value.x; this.x = value.y; this.w = value.z; this.y = value.w; 
        }
    }
    public float4 zxwz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 178));
            
            
            return new(this.z, this.x, this.w, this.z);
        }
    }
    public float4 zxww
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 242));
            
            
            return new(this.z, this.x, this.w, this.w);
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
    public float4 zyxw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 198));
            
            
            return new(this.z, this.y, this.x, this.w);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        {
            this.z = value.x; this.y = value.y; this.x = value.z; this.w = value.w; 
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
    public float4 zyyw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 214));
            
            
            return new(this.z, this.y, this.y, this.w);
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
    public float4 zyzw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 230));
            
            
            return new(this.z, this.y, this.z, this.w);
        }
    }
    public float4 zywx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 54));
            
            
            return new(this.z, this.y, this.w, this.x);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        {
            this.z = value.x; this.y = value.y; this.w = value.z; this.x = value.w; 
        }
    }
    public float4 zywy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 118));
            
            
            return new(this.z, this.y, this.w, this.y);
        }
    }
    public float4 zywz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 182));
            
            
            return new(this.z, this.y, this.w, this.z);
        }
    }
    public float4 zyww
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 246));
            
            
            return new(this.z, this.y, this.w, this.w);
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
    public float4 zzxw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 202));
            
            
            return new(this.z, this.z, this.x, this.w);
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
    public float4 zzyw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 218));
            
            
            return new(this.z, this.z, this.y, this.w);
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
    public float4 zzzw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 234));
            
            
            return new(this.z, this.z, this.z, this.w);
        }
    }
    public float4 zzwx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 58));
            
            
            return new(this.z, this.z, this.w, this.x);
        }
    }
    public float4 zzwy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 122));
            
            
            return new(this.z, this.z, this.w, this.y);
        }
    }
    public float4 zzwz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 186));
            
            
            return new(this.z, this.z, this.w, this.z);
        }
    }
    public float4 zzww
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 250));
            
            
            return new(this.z, this.z, this.w, this.w);
        }
    }
    public float4 zwxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 14));
            
            
            return new(this.z, this.w, this.x, this.x);
        }
    }
    public float4 zwxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 78));
            
            
            return new(this.z, this.w, this.x, this.y);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        {
            this.z = value.x; this.w = value.y; this.x = value.z; this.y = value.w; 
        }
    }
    public float4 zwxz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 142));
            
            
            return new(this.z, this.w, this.x, this.z);
        }
    }
    public float4 zwxw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 206));
            
            
            return new(this.z, this.w, this.x, this.w);
        }
    }
    public float4 zwyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 30));
            
            
            return new(this.z, this.w, this.y, this.x);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        {
            this.z = value.x; this.w = value.y; this.y = value.z; this.x = value.w; 
        }
    }
    public float4 zwyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 94));
            
            
            return new(this.z, this.w, this.y, this.y);
        }
    }
    public float4 zwyz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 158));
            
            
            return new(this.z, this.w, this.y, this.z);
        }
    }
    public float4 zwyw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 222));
            
            
            return new(this.z, this.w, this.y, this.w);
        }
    }
    public float4 zwzx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 46));
            
            
            return new(this.z, this.w, this.z, this.x);
        }
    }
    public float4 zwzy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 110));
            
            
            return new(this.z, this.w, this.z, this.y);
        }
    }
    public float4 zwzz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 174));
            
            
            return new(this.z, this.w, this.z, this.z);
        }
    }
    public float4 zwzw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 238));
            
            
            return new(this.z, this.w, this.z, this.w);
        }
    }
    public float4 zwwx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 62));
            
            
            return new(this.z, this.w, this.w, this.x);
        }
    }
    public float4 zwwy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 126));
            
            
            return new(this.z, this.w, this.w, this.y);
        }
    }
    public float4 zwwz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 190));
            
            
            return new(this.z, this.w, this.w, this.z);
        }
    }
    public float4 zwww
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 254));
            
            
            return new(this.z, this.w, this.w, this.w);
        }
    }
    public float4 wxxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 3));
            
            
            return new(this.w, this.x, this.x, this.x);
        }
    }
    public float4 wxxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 67));
            
            
            return new(this.w, this.x, this.x, this.y);
        }
    }
    public float4 wxxz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 131));
            
            
            return new(this.w, this.x, this.x, this.z);
        }
    }
    public float4 wxxw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 195));
            
            
            return new(this.w, this.x, this.x, this.w);
        }
    }
    public float4 wxyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 19));
            
            
            return new(this.w, this.x, this.y, this.x);
        }
    }
    public float4 wxyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 83));
            
            
            return new(this.w, this.x, this.y, this.y);
        }
    }
    public float4 wxyz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 147));
            
            
            return new(this.w, this.x, this.y, this.z);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        {
            this.w = value.x; this.x = value.y; this.y = value.z; this.z = value.w; 
        }
    }
    public float4 wxyw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 211));
            
            
            return new(this.w, this.x, this.y, this.w);
        }
    }
    public float4 wxzx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 35));
            
            
            return new(this.w, this.x, this.z, this.x);
        }
    }
    public float4 wxzy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 99));
            
            
            return new(this.w, this.x, this.z, this.y);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        {
            this.w = value.x; this.x = value.y; this.z = value.z; this.y = value.w; 
        }
    }
    public float4 wxzz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 163));
            
            
            return new(this.w, this.x, this.z, this.z);
        }
    }
    public float4 wxzw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 227));
            
            
            return new(this.w, this.x, this.z, this.w);
        }
    }
    public float4 wxwx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 51));
            
            
            return new(this.w, this.x, this.w, this.x);
        }
    }
    public float4 wxwy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 115));
            
            
            return new(this.w, this.x, this.w, this.y);
        }
    }
    public float4 wxwz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 179));
            
            
            return new(this.w, this.x, this.w, this.z);
        }
    }
    public float4 wxww
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 243));
            
            
            return new(this.w, this.x, this.w, this.w);
        }
    }
    public float4 wyxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 7));
            
            
            return new(this.w, this.y, this.x, this.x);
        }
    }
    public float4 wyxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 71));
            
            
            return new(this.w, this.y, this.x, this.y);
        }
    }
    public float4 wyxz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 135));
            
            
            return new(this.w, this.y, this.x, this.z);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        {
            this.w = value.x; this.y = value.y; this.x = value.z; this.z = value.w; 
        }
    }
    public float4 wyxw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 199));
            
            
            return new(this.w, this.y, this.x, this.w);
        }
    }
    public float4 wyyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 23));
            
            
            return new(this.w, this.y, this.y, this.x);
        }
    }
    public float4 wyyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 87));
            
            
            return new(this.w, this.y, this.y, this.y);
        }
    }
    public float4 wyyz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 151));
            
            
            return new(this.w, this.y, this.y, this.z);
        }
    }
    public float4 wyyw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 215));
            
            
            return new(this.w, this.y, this.y, this.w);
        }
    }
    public float4 wyzx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 39));
            
            
            return new(this.w, this.y, this.z, this.x);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        {
            this.w = value.x; this.y = value.y; this.z = value.z; this.x = value.w; 
        }
    }
    public float4 wyzy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 103));
            
            
            return new(this.w, this.y, this.z, this.y);
        }
    }
    public float4 wyzz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 167));
            
            
            return new(this.w, this.y, this.z, this.z);
        }
    }
    public float4 wyzw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 231));
            
            
            return new(this.w, this.y, this.z, this.w);
        }
    }
    public float4 wywx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 55));
            
            
            return new(this.w, this.y, this.w, this.x);
        }
    }
    public float4 wywy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 119));
            
            
            return new(this.w, this.y, this.w, this.y);
        }
    }
    public float4 wywz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 183));
            
            
            return new(this.w, this.y, this.w, this.z);
        }
    }
    public float4 wyww
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 247));
            
            
            return new(this.w, this.y, this.w, this.w);
        }
    }
    public float4 wzxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 11));
            
            
            return new(this.w, this.z, this.x, this.x);
        }
    }
    public float4 wzxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 75));
            
            
            return new(this.w, this.z, this.x, this.y);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        {
            this.w = value.x; this.z = value.y; this.x = value.z; this.y = value.w; 
        }
    }
    public float4 wzxz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 139));
            
            
            return new(this.w, this.z, this.x, this.z);
        }
    }
    public float4 wzxw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 203));
            
            
            return new(this.w, this.z, this.x, this.w);
        }
    }
    public float4 wzyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 27));
            
            
            return new(this.w, this.z, this.y, this.x);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        {
            this.w = value.x; this.z = value.y; this.y = value.z; this.x = value.w; 
        }
    }
    public float4 wzyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 91));
            
            
            return new(this.w, this.z, this.y, this.y);
        }
    }
    public float4 wzyz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 155));
            
            
            return new(this.w, this.z, this.y, this.z);
        }
    }
    public float4 wzyw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 219));
            
            
            return new(this.w, this.z, this.y, this.w);
        }
    }
    public float4 wzzx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 43));
            
            
            return new(this.w, this.z, this.z, this.x);
        }
    }
    public float4 wzzy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 107));
            
            
            return new(this.w, this.z, this.z, this.y);
        }
    }
    public float4 wzzz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 171));
            
            
            return new(this.w, this.z, this.z, this.z);
        }
    }
    public float4 wzzw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 235));
            
            
            return new(this.w, this.z, this.z, this.w);
        }
    }
    public float4 wzwx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 59));
            
            
            return new(this.w, this.z, this.w, this.x);
        }
    }
    public float4 wzwy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 123));
            
            
            return new(this.w, this.z, this.w, this.y);
        }
    }
    public float4 wzwz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 187));
            
            
            return new(this.w, this.z, this.w, this.z);
        }
    }
    public float4 wzww
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 251));
            
            
            return new(this.w, this.z, this.w, this.w);
        }
    }
    public float4 wwxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 15));
            
            
            return new(this.w, this.w, this.x, this.x);
        }
    }
    public float4 wwxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 79));
            
            
            return new(this.w, this.w, this.x, this.y);
        }
    }
    public float4 wwxz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 143));
            
            
            return new(this.w, this.w, this.x, this.z);
        }
    }
    public float4 wwxw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 207));
            
            
            return new(this.w, this.w, this.x, this.w);
        }
    }
    public float4 wwyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 31));
            
            
            return new(this.w, this.w, this.y, this.x);
        }
    }
    public float4 wwyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 95));
            
            
            return new(this.w, this.w, this.y, this.y);
        }
    }
    public float4 wwyz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 159));
            
            
            return new(this.w, this.w, this.y, this.z);
        }
    }
    public float4 wwyw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 223));
            
            
            return new(this.w, this.w, this.y, this.w);
        }
    }
    public float4 wwzx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 47));
            
            
            return new(this.w, this.w, this.z, this.x);
        }
    }
    public float4 wwzy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 111));
            
            
            return new(this.w, this.w, this.z, this.y);
        }
    }
    public float4 wwzz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 175));
            
            
            return new(this.w, this.w, this.z, this.z);
        }
    }
    public float4 wwzw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 239));
            
            
            return new(this.w, this.w, this.z, this.w);
        }
    }
    public float4 wwwx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 63));
            
            
            return new(this.w, this.w, this.w, this.x);
        }
    }
    public float4 wwwy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 127));
            
            
            return new(this.w, this.w, this.w, this.y);
        }
    }
    public float4 wwwz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 191));
            
            
            return new(this.w, this.w, this.w, this.z);
        }
    }
    public float4 wwww
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 255));
            
            
            return new(this.w, this.w, this.w, this.w);
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
    public float4 rrra
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 192));
            
            
            return new(this.r, this.r, this.r, this.a);
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
    public float4 rrga
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 208));
            
            
            return new(this.r, this.r, this.g, this.a);
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
    public float4 rrba
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 224));
            
            
            return new(this.r, this.r, this.b, this.a);
        }
    }
    public float4 rrar
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 48));
            
            
            return new(this.r, this.r, this.a, this.r);
        }
    }
    public float4 rrag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 112));
            
            
            return new(this.r, this.r, this.a, this.g);
        }
    }
    public float4 rrab
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 176));
            
            
            return new(this.r, this.r, this.a, this.b);
        }
    }
    public float4 rraa
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 240));
            
            
            return new(this.r, this.r, this.a, this.a);
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
    public float4 rgra
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 196));
            
            
            return new(this.r, this.g, this.r, this.a);
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
    public float4 rgga
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 212));
            
            
            return new(this.r, this.g, this.g, this.a);
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
    public float4 rgba
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 228));
            
            
            return new(this.r, this.g, this.b, this.a);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        {
            this.r = value.x; this.g = value.y; this.b = value.z; this.a = value.w; 
        }
    }
    public float4 rgar
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 52));
            
            
            return new(this.r, this.g, this.a, this.r);
        }
    }
    public float4 rgag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 116));
            
            
            return new(this.r, this.g, this.a, this.g);
        }
    }
    public float4 rgab
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 180));
            
            
            return new(this.r, this.g, this.a, this.b);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        {
            this.r = value.x; this.g = value.y; this.a = value.z; this.b = value.w; 
        }
    }
    public float4 rgaa
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 244));
            
            
            return new(this.r, this.g, this.a, this.a);
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
    public float4 rbra
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 200));
            
            
            return new(this.r, this.b, this.r, this.a);
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
    public float4 rbga
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 216));
            
            
            return new(this.r, this.b, this.g, this.a);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        {
            this.r = value.x; this.b = value.y; this.g = value.z; this.a = value.w; 
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
    public float4 rbba
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 232));
            
            
            return new(this.r, this.b, this.b, this.a);
        }
    }
    public float4 rbar
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 56));
            
            
            return new(this.r, this.b, this.a, this.r);
        }
    }
    public float4 rbag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 120));
            
            
            return new(this.r, this.b, this.a, this.g);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        {
            this.r = value.x; this.b = value.y; this.a = value.z; this.g = value.w; 
        }
    }
    public float4 rbab
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 184));
            
            
            return new(this.r, this.b, this.a, this.b);
        }
    }
    public float4 rbaa
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 248));
            
            
            return new(this.r, this.b, this.a, this.a);
        }
    }
    public float4 rarr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 12));
            
            
            return new(this.r, this.a, this.r, this.r);
        }
    }
    public float4 rarg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 76));
            
            
            return new(this.r, this.a, this.r, this.g);
        }
    }
    public float4 rarb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 140));
            
            
            return new(this.r, this.a, this.r, this.b);
        }
    }
    public float4 rara
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 204));
            
            
            return new(this.r, this.a, this.r, this.a);
        }
    }
    public float4 ragr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 28));
            
            
            return new(this.r, this.a, this.g, this.r);
        }
    }
    public float4 ragg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 92));
            
            
            return new(this.r, this.a, this.g, this.g);
        }
    }
    public float4 ragb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 156));
            
            
            return new(this.r, this.a, this.g, this.b);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        {
            this.r = value.x; this.a = value.y; this.g = value.z; this.b = value.w; 
        }
    }
    public float4 raga
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 220));
            
            
            return new(this.r, this.a, this.g, this.a);
        }
    }
    public float4 rabr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 44));
            
            
            return new(this.r, this.a, this.b, this.r);
        }
    }
    public float4 rabg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 108));
            
            
            return new(this.r, this.a, this.b, this.g);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        {
            this.r = value.x; this.a = value.y; this.b = value.z; this.g = value.w; 
        }
    }
    public float4 rabb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 172));
            
            
            return new(this.r, this.a, this.b, this.b);
        }
    }
    public float4 raba
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 236));
            
            
            return new(this.r, this.a, this.b, this.a);
        }
    }
    public float4 raar
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 60));
            
            
            return new(this.r, this.a, this.a, this.r);
        }
    }
    public float4 raag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 124));
            
            
            return new(this.r, this.a, this.a, this.g);
        }
    }
    public float4 raab
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 188));
            
            
            return new(this.r, this.a, this.a, this.b);
        }
    }
    public float4 raaa
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 252));
            
            
            return new(this.r, this.a, this.a, this.a);
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
    public float4 grra
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 193));
            
            
            return new(this.g, this.r, this.r, this.a);
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
    public float4 grga
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 209));
            
            
            return new(this.g, this.r, this.g, this.a);
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
    public float4 grba
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 225));
            
            
            return new(this.g, this.r, this.b, this.a);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        {
            this.g = value.x; this.r = value.y; this.b = value.z; this.a = value.w; 
        }
    }
    public float4 grar
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 49));
            
            
            return new(this.g, this.r, this.a, this.r);
        }
    }
    public float4 grag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 113));
            
            
            return new(this.g, this.r, this.a, this.g);
        }
    }
    public float4 grab
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 177));
            
            
            return new(this.g, this.r, this.a, this.b);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        {
            this.g = value.x; this.r = value.y; this.a = value.z; this.b = value.w; 
        }
    }
    public float4 graa
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 241));
            
            
            return new(this.g, this.r, this.a, this.a);
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
    public float4 ggra
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 197));
            
            
            return new(this.g, this.g, this.r, this.a);
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
    public float4 ggga
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 213));
            
            
            return new(this.g, this.g, this.g, this.a);
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
    public float4 ggba
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 229));
            
            
            return new(this.g, this.g, this.b, this.a);
        }
    }
    public float4 ggar
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 53));
            
            
            return new(this.g, this.g, this.a, this.r);
        }
    }
    public float4 ggag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 117));
            
            
            return new(this.g, this.g, this.a, this.g);
        }
    }
    public float4 ggab
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 181));
            
            
            return new(this.g, this.g, this.a, this.b);
        }
    }
    public float4 ggaa
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 245));
            
            
            return new(this.g, this.g, this.a, this.a);
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
    public float4 gbra
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 201));
            
            
            return new(this.g, this.b, this.r, this.a);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        {
            this.g = value.x; this.b = value.y; this.r = value.z; this.a = value.w; 
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
    public float4 gbga
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 217));
            
            
            return new(this.g, this.b, this.g, this.a);
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
    public float4 gbba
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 233));
            
            
            return new(this.g, this.b, this.b, this.a);
        }
    }
    public float4 gbar
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 57));
            
            
            return new(this.g, this.b, this.a, this.r);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        {
            this.g = value.x; this.b = value.y; this.a = value.z; this.r = value.w; 
        }
    }
    public float4 gbag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 121));
            
            
            return new(this.g, this.b, this.a, this.g);
        }
    }
    public float4 gbab
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 185));
            
            
            return new(this.g, this.b, this.a, this.b);
        }
    }
    public float4 gbaa
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 249));
            
            
            return new(this.g, this.b, this.a, this.a);
        }
    }
    public float4 garr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 13));
            
            
            return new(this.g, this.a, this.r, this.r);
        }
    }
    public float4 garg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 77));
            
            
            return new(this.g, this.a, this.r, this.g);
        }
    }
    public float4 garb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 141));
            
            
            return new(this.g, this.a, this.r, this.b);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        {
            this.g = value.x; this.a = value.y; this.r = value.z; this.b = value.w; 
        }
    }
    public float4 gara
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 205));
            
            
            return new(this.g, this.a, this.r, this.a);
        }
    }
    public float4 gagr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 29));
            
            
            return new(this.g, this.a, this.g, this.r);
        }
    }
    public float4 gagg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 93));
            
            
            return new(this.g, this.a, this.g, this.g);
        }
    }
    public float4 gagb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 157));
            
            
            return new(this.g, this.a, this.g, this.b);
        }
    }
    public float4 gaga
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 221));
            
            
            return new(this.g, this.a, this.g, this.a);
        }
    }
    public float4 gabr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 45));
            
            
            return new(this.g, this.a, this.b, this.r);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        {
            this.g = value.x; this.a = value.y; this.b = value.z; this.r = value.w; 
        }
    }
    public float4 gabg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 109));
            
            
            return new(this.g, this.a, this.b, this.g);
        }
    }
    public float4 gabb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 173));
            
            
            return new(this.g, this.a, this.b, this.b);
        }
    }
    public float4 gaba
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 237));
            
            
            return new(this.g, this.a, this.b, this.a);
        }
    }
    public float4 gaar
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 61));
            
            
            return new(this.g, this.a, this.a, this.r);
        }
    }
    public float4 gaag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 125));
            
            
            return new(this.g, this.a, this.a, this.g);
        }
    }
    public float4 gaab
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 189));
            
            
            return new(this.g, this.a, this.a, this.b);
        }
    }
    public float4 gaaa
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 253));
            
            
            return new(this.g, this.a, this.a, this.a);
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
    public float4 brra
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 194));
            
            
            return new(this.b, this.r, this.r, this.a);
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
    public float4 brga
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 210));
            
            
            return new(this.b, this.r, this.g, this.a);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        {
            this.b = value.x; this.r = value.y; this.g = value.z; this.a = value.w; 
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
    public float4 brba
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 226));
            
            
            return new(this.b, this.r, this.b, this.a);
        }
    }
    public float4 brar
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 50));
            
            
            return new(this.b, this.r, this.a, this.r);
        }
    }
    public float4 brag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 114));
            
            
            return new(this.b, this.r, this.a, this.g);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        {
            this.b = value.x; this.r = value.y; this.a = value.z; this.g = value.w; 
        }
    }
    public float4 brab
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 178));
            
            
            return new(this.b, this.r, this.a, this.b);
        }
    }
    public float4 braa
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 242));
            
            
            return new(this.b, this.r, this.a, this.a);
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
    public float4 bgra
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 198));
            
            
            return new(this.b, this.g, this.r, this.a);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        {
            this.b = value.x; this.g = value.y; this.r = value.z; this.a = value.w; 
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
    public float4 bgga
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 214));
            
            
            return new(this.b, this.g, this.g, this.a);
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
    public float4 bgba
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 230));
            
            
            return new(this.b, this.g, this.b, this.a);
        }
    }
    public float4 bgar
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 54));
            
            
            return new(this.b, this.g, this.a, this.r);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        {
            this.b = value.x; this.g = value.y; this.a = value.z; this.r = value.w; 
        }
    }
    public float4 bgag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 118));
            
            
            return new(this.b, this.g, this.a, this.g);
        }
    }
    public float4 bgab
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 182));
            
            
            return new(this.b, this.g, this.a, this.b);
        }
    }
    public float4 bgaa
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 246));
            
            
            return new(this.b, this.g, this.a, this.a);
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
    public float4 bbra
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 202));
            
            
            return new(this.b, this.b, this.r, this.a);
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
    public float4 bbga
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 218));
            
            
            return new(this.b, this.b, this.g, this.a);
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
    public float4 bbba
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 234));
            
            
            return new(this.b, this.b, this.b, this.a);
        }
    }
    public float4 bbar
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 58));
            
            
            return new(this.b, this.b, this.a, this.r);
        }
    }
    public float4 bbag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 122));
            
            
            return new(this.b, this.b, this.a, this.g);
        }
    }
    public float4 bbab
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 186));
            
            
            return new(this.b, this.b, this.a, this.b);
        }
    }
    public float4 bbaa
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 250));
            
            
            return new(this.b, this.b, this.a, this.a);
        }
    }
    public float4 barr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 14));
            
            
            return new(this.b, this.a, this.r, this.r);
        }
    }
    public float4 barg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 78));
            
            
            return new(this.b, this.a, this.r, this.g);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        {
            this.b = value.x; this.a = value.y; this.r = value.z; this.g = value.w; 
        }
    }
    public float4 barb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 142));
            
            
            return new(this.b, this.a, this.r, this.b);
        }
    }
    public float4 bara
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 206));
            
            
            return new(this.b, this.a, this.r, this.a);
        }
    }
    public float4 bagr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 30));
            
            
            return new(this.b, this.a, this.g, this.r);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        {
            this.b = value.x; this.a = value.y; this.g = value.z; this.r = value.w; 
        }
    }
    public float4 bagg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 94));
            
            
            return new(this.b, this.a, this.g, this.g);
        }
    }
    public float4 bagb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 158));
            
            
            return new(this.b, this.a, this.g, this.b);
        }
    }
    public float4 baga
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 222));
            
            
            return new(this.b, this.a, this.g, this.a);
        }
    }
    public float4 babr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 46));
            
            
            return new(this.b, this.a, this.b, this.r);
        }
    }
    public float4 babg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 110));
            
            
            return new(this.b, this.a, this.b, this.g);
        }
    }
    public float4 babb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 174));
            
            
            return new(this.b, this.a, this.b, this.b);
        }
    }
    public float4 baba
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 238));
            
            
            return new(this.b, this.a, this.b, this.a);
        }
    }
    public float4 baar
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 62));
            
            
            return new(this.b, this.a, this.a, this.r);
        }
    }
    public float4 baag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 126));
            
            
            return new(this.b, this.a, this.a, this.g);
        }
    }
    public float4 baab
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 190));
            
            
            return new(this.b, this.a, this.a, this.b);
        }
    }
    public float4 baaa
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 254));
            
            
            return new(this.b, this.a, this.a, this.a);
        }
    }
    public float4 arrr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 3));
            
            
            return new(this.a, this.r, this.r, this.r);
        }
    }
    public float4 arrg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 67));
            
            
            return new(this.a, this.r, this.r, this.g);
        }
    }
    public float4 arrb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 131));
            
            
            return new(this.a, this.r, this.r, this.b);
        }
    }
    public float4 arra
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 195));
            
            
            return new(this.a, this.r, this.r, this.a);
        }
    }
    public float4 argr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 19));
            
            
            return new(this.a, this.r, this.g, this.r);
        }
    }
    public float4 argg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 83));
            
            
            return new(this.a, this.r, this.g, this.g);
        }
    }
    public float4 argb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 147));
            
            
            return new(this.a, this.r, this.g, this.b);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        {
            this.a = value.x; this.r = value.y; this.g = value.z; this.b = value.w; 
        }
    }
    public float4 arga
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 211));
            
            
            return new(this.a, this.r, this.g, this.a);
        }
    }
    public float4 arbr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 35));
            
            
            return new(this.a, this.r, this.b, this.r);
        }
    }
    public float4 arbg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 99));
            
            
            return new(this.a, this.r, this.b, this.g);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        {
            this.a = value.x; this.r = value.y; this.b = value.z; this.g = value.w; 
        }
    }
    public float4 arbb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 163));
            
            
            return new(this.a, this.r, this.b, this.b);
        }
    }
    public float4 arba
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 227));
            
            
            return new(this.a, this.r, this.b, this.a);
        }
    }
    public float4 arar
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 51));
            
            
            return new(this.a, this.r, this.a, this.r);
        }
    }
    public float4 arag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 115));
            
            
            return new(this.a, this.r, this.a, this.g);
        }
    }
    public float4 arab
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 179));
            
            
            return new(this.a, this.r, this.a, this.b);
        }
    }
    public float4 araa
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 243));
            
            
            return new(this.a, this.r, this.a, this.a);
        }
    }
    public float4 agrr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 7));
            
            
            return new(this.a, this.g, this.r, this.r);
        }
    }
    public float4 agrg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 71));
            
            
            return new(this.a, this.g, this.r, this.g);
        }
    }
    public float4 agrb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 135));
            
            
            return new(this.a, this.g, this.r, this.b);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        {
            this.a = value.x; this.g = value.y; this.r = value.z; this.b = value.w; 
        }
    }
    public float4 agra
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 199));
            
            
            return new(this.a, this.g, this.r, this.a);
        }
    }
    public float4 aggr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 23));
            
            
            return new(this.a, this.g, this.g, this.r);
        }
    }
    public float4 aggg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 87));
            
            
            return new(this.a, this.g, this.g, this.g);
        }
    }
    public float4 aggb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 151));
            
            
            return new(this.a, this.g, this.g, this.b);
        }
    }
    public float4 agga
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 215));
            
            
            return new(this.a, this.g, this.g, this.a);
        }
    }
    public float4 agbr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 39));
            
            
            return new(this.a, this.g, this.b, this.r);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        {
            this.a = value.x; this.g = value.y; this.b = value.z; this.r = value.w; 
        }
    }
    public float4 agbg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 103));
            
            
            return new(this.a, this.g, this.b, this.g);
        }
    }
    public float4 agbb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 167));
            
            
            return new(this.a, this.g, this.b, this.b);
        }
    }
    public float4 agba
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 231));
            
            
            return new(this.a, this.g, this.b, this.a);
        }
    }
    public float4 agar
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 55));
            
            
            return new(this.a, this.g, this.a, this.r);
        }
    }
    public float4 agag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 119));
            
            
            return new(this.a, this.g, this.a, this.g);
        }
    }
    public float4 agab
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 183));
            
            
            return new(this.a, this.g, this.a, this.b);
        }
    }
    public float4 agaa
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 247));
            
            
            return new(this.a, this.g, this.a, this.a);
        }
    }
    public float4 abrr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 11));
            
            
            return new(this.a, this.b, this.r, this.r);
        }
    }
    public float4 abrg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 75));
            
            
            return new(this.a, this.b, this.r, this.g);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        {
            this.a = value.x; this.b = value.y; this.r = value.z; this.g = value.w; 
        }
    }
    public float4 abrb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 139));
            
            
            return new(this.a, this.b, this.r, this.b);
        }
    }
    public float4 abra
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 203));
            
            
            return new(this.a, this.b, this.r, this.a);
        }
    }
    public float4 abgr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 27));
            
            
            return new(this.a, this.b, this.g, this.r);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set 
        {
            this.a = value.x; this.b = value.y; this.g = value.z; this.r = value.w; 
        }
    }
    public float4 abgg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 91));
            
            
            return new(this.a, this.b, this.g, this.g);
        }
    }
    public float4 abgb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 155));
            
            
            return new(this.a, this.b, this.g, this.b);
        }
    }
    public float4 abga
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 219));
            
            
            return new(this.a, this.b, this.g, this.a);
        }
    }
    public float4 abbr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 43));
            
            
            return new(this.a, this.b, this.b, this.r);
        }
    }
    public float4 abbg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 107));
            
            
            return new(this.a, this.b, this.b, this.g);
        }
    }
    public float4 abbb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 171));
            
            
            return new(this.a, this.b, this.b, this.b);
        }
    }
    public float4 abba
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 235));
            
            
            return new(this.a, this.b, this.b, this.a);
        }
    }
    public float4 abar
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 59));
            
            
            return new(this.a, this.b, this.a, this.r);
        }
    }
    public float4 abag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 123));
            
            
            return new(this.a, this.b, this.a, this.g);
        }
    }
    public float4 abab
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 187));
            
            
            return new(this.a, this.b, this.a, this.b);
        }
    }
    public float4 abaa
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 251));
            
            
            return new(this.a, this.b, this.a, this.a);
        }
    }
    public float4 aarr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 15));
            
            
            return new(this.a, this.a, this.r, this.r);
        }
    }
    public float4 aarg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 79));
            
            
            return new(this.a, this.a, this.r, this.g);
        }
    }
    public float4 aarb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 143));
            
            
            return new(this.a, this.a, this.r, this.b);
        }
    }
    public float4 aara
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 207));
            
            
            return new(this.a, this.a, this.r, this.a);
        }
    }
    public float4 aagr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 31));
            
            
            return new(this.a, this.a, this.g, this.r);
        }
    }
    public float4 aagg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 95));
            
            
            return new(this.a, this.a, this.g, this.g);
        }
    }
    public float4 aagb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 159));
            
            
            return new(this.a, this.a, this.g, this.b);
        }
    }
    public float4 aaga
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 223));
            
            
            return new(this.a, this.a, this.g, this.a);
        }
    }
    public float4 aabr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 47));
            
            
            return new(this.a, this.a, this.b, this.r);
        }
    }
    public float4 aabg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 111));
            
            
            return new(this.a, this.a, this.b, this.g);
        }
    }
    public float4 aabb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 175));
            
            
            return new(this.a, this.a, this.b, this.b);
        }
    }
    public float4 aaba
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 239));
            
            
            return new(this.a, this.a, this.b, this.a);
        }
    }
    public float4 aaar
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 63));
            
            
            return new(this.a, this.a, this.a, this.r);
        }
    }
    public float4 aaag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 127));
            
            
            return new(this.a, this.a, this.a, this.g);
        }
    }
    public float4 aaab
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 191));
            
            
            return new(this.a, this.a, this.a, this.b);
        }
    }
    public float4 aaaa
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            if (Sse.IsSupported) return new(Sse.Shuffle(this.vector, this.vector, 255));
            
            
            return new(this.a, this.a, this.a, this.a);
        }
    }


}
