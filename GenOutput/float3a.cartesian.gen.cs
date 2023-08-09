using System;
using System.Numerics;
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.X86;
using System.Runtime.Intrinsics.Arm;
using System.Runtime.CompilerServices;

#nullable enable
#pragma warning disable CS8981

namespace CCluster.Mathematics;

public partial struct float3a 
{

    public float2 xx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.x);
    }
    public float2 xy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.y);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.x = value.x; this.y = value.y; }
    }
    public float2 xz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.z);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.x = value.x; this.z = value.y; }
    }
    public float2 yx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.x);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.y = value.x; this.x = value.y; }
    }
    public float2 yy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.y);
    }
    public float2 yz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.z);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.y = value.x; this.z = value.y; }
    }
    public float2 zx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.x);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.z = value.x; this.x = value.y; }
    }
    public float2 zy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.y);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.z = value.x; this.y = value.y; }
    }
    public float2 zz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.z);
    }
    public float2 rr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.r);
    }
    public float2 rg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.g);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.r = value.x; this.g = value.y; }
    }
    public float2 rb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.b);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.r = value.x; this.b = value.y; }
    }
    public float2 gr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.r);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.g = value.x; this.r = value.y; }
    }
    public float2 gg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.g);
    }
    public float2 gb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.b);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.g = value.x; this.b = value.y; }
    }
    public float2 br
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.r);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.b = value.x; this.r = value.y; }
    }
    public float2 bg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.g);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.b = value.x; this.g = value.y; }
    }
    public float2 bb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.b);
    }
    public float3a xxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.x, this.x);
    }
    public float3a xxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.x, this.y);
    }
    public float3a xxz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.x, this.z);
    }
    public float3a xyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.y, this.x);
    }
    public float3a xyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.y, this.y);
    }
    public float3a xyz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.y, this.z);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.x = value.x; this.y = value.y; this.z = value.z; }
    }
    public float3a xzx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.z, this.x);
    }
    public float3a xzy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.z, this.y);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.x = value.x; this.z = value.y; this.y = value.z; }
    }
    public float3a xzz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.z, this.z);
    }
    public float3a yxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.x, this.x);
    }
    public float3a yxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.x, this.y);
    }
    public float3a yxz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.x, this.z);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.y = value.x; this.x = value.y; this.z = value.z; }
    }
    public float3a yyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.y, this.x);
    }
    public float3a yyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.y, this.y);
    }
    public float3a yyz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.y, this.z);
    }
    public float3a yzx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.z, this.x);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.y = value.x; this.z = value.y; this.x = value.z; }
    }
    public float3a yzy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.z, this.y);
    }
    public float3a yzz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.z, this.z);
    }
    public float3a zxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.x, this.x);
    }
    public float3a zxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.x, this.y);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.z = value.x; this.x = value.y; this.y = value.z; }
    }
    public float3a zxz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.x, this.z);
    }
    public float3a zyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.y, this.x);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.z = value.x; this.y = value.y; this.x = value.z; }
    }
    public float3a zyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.y, this.y);
    }
    public float3a zyz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.y, this.z);
    }
    public float3a zzx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.z, this.x);
    }
    public float3a zzy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.z, this.y);
    }
    public float3a zzz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.z, this.z);
    }
    public float3a rrr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.r, this.r);
    }
    public float3a rrg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.r, this.g);
    }
    public float3a rrb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.r, this.b);
    }
    public float3a rgr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.g, this.r);
    }
    public float3a rgg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.g, this.g);
    }
    public float3a rgb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.g, this.b);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.r = value.x; this.g = value.y; this.b = value.z; }
    }
    public float3a rbr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.b, this.r);
    }
    public float3a rbg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.b, this.g);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.r = value.x; this.b = value.y; this.g = value.z; }
    }
    public float3a rbb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.b, this.b);
    }
    public float3a grr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.r, this.r);
    }
    public float3a grg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.r, this.g);
    }
    public float3a grb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.r, this.b);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.g = value.x; this.r = value.y; this.b = value.z; }
    }
    public float3a ggr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.g, this.r);
    }
    public float3a ggg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.g, this.g);
    }
    public float3a ggb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.g, this.b);
    }
    public float3a gbr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.b, this.r);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.g = value.x; this.b = value.y; this.r = value.z; }
    }
    public float3a gbg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.b, this.g);
    }
    public float3a gbb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.b, this.b);
    }
    public float3a brr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.r, this.r);
    }
    public float3a brg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.r, this.g);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.b = value.x; this.r = value.y; this.g = value.z; }
    }
    public float3a brb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.r, this.b);
    }
    public float3a bgr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.g, this.r);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.b = value.x; this.g = value.y; this.r = value.z; }
    }
    public float3a bgg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.g, this.g);
    }
    public float3a bgb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.g, this.b);
    }
    public float3a bbr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.b, this.r);
    }
    public float3a bbg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.b, this.g);
    }
    public float3a bbb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.b, this.b);
    }
    public float4 xxxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.x, this.x, this.x);
    }
    public float4 xxxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.x, this.x, this.y);
    }
    public float4 xxxz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.x, this.x, this.z);
    }
    public float4 xxyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.x, this.y, this.x);
    }
    public float4 xxyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.x, this.y, this.y);
    }
    public float4 xxyz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.x, this.y, this.z);
    }
    public float4 xxzx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.x, this.z, this.x);
    }
    public float4 xxzy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.x, this.z, this.y);
    }
    public float4 xxzz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.x, this.z, this.z);
    }
    public float4 xyxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.y, this.x, this.x);
    }
    public float4 xyxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.y, this.x, this.y);
    }
    public float4 xyxz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.y, this.x, this.z);
    }
    public float4 xyyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.y, this.y, this.x);
    }
    public float4 xyyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.y, this.y, this.y);
    }
    public float4 xyyz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.y, this.y, this.z);
    }
    public float4 xyzx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.y, this.z, this.x);
    }
    public float4 xyzy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.y, this.z, this.y);
    }
    public float4 xyzz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.y, this.z, this.z);
    }
    public float4 xzxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.z, this.x, this.x);
    }
    public float4 xzxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.z, this.x, this.y);
    }
    public float4 xzxz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.z, this.x, this.z);
    }
    public float4 xzyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.z, this.y, this.x);
    }
    public float4 xzyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.z, this.y, this.y);
    }
    public float4 xzyz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.z, this.y, this.z);
    }
    public float4 xzzx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.z, this.z, this.x);
    }
    public float4 xzzy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.z, this.z, this.y);
    }
    public float4 xzzz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.z, this.z, this.z);
    }
    public float4 yxxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.x, this.x, this.x);
    }
    public float4 yxxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.x, this.x, this.y);
    }
    public float4 yxxz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.x, this.x, this.z);
    }
    public float4 yxyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.x, this.y, this.x);
    }
    public float4 yxyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.x, this.y, this.y);
    }
    public float4 yxyz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.x, this.y, this.z);
    }
    public float4 yxzx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.x, this.z, this.x);
    }
    public float4 yxzy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.x, this.z, this.y);
    }
    public float4 yxzz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.x, this.z, this.z);
    }
    public float4 yyxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.y, this.x, this.x);
    }
    public float4 yyxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.y, this.x, this.y);
    }
    public float4 yyxz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.y, this.x, this.z);
    }
    public float4 yyyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.y, this.y, this.x);
    }
    public float4 yyyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.y, this.y, this.y);
    }
    public float4 yyyz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.y, this.y, this.z);
    }
    public float4 yyzx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.y, this.z, this.x);
    }
    public float4 yyzy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.y, this.z, this.y);
    }
    public float4 yyzz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.y, this.z, this.z);
    }
    public float4 yzxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.z, this.x, this.x);
    }
    public float4 yzxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.z, this.x, this.y);
    }
    public float4 yzxz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.z, this.x, this.z);
    }
    public float4 yzyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.z, this.y, this.x);
    }
    public float4 yzyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.z, this.y, this.y);
    }
    public float4 yzyz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.z, this.y, this.z);
    }
    public float4 yzzx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.z, this.z, this.x);
    }
    public float4 yzzy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.z, this.z, this.y);
    }
    public float4 yzzz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.z, this.z, this.z);
    }
    public float4 zxxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.x, this.x, this.x);
    }
    public float4 zxxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.x, this.x, this.y);
    }
    public float4 zxxz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.x, this.x, this.z);
    }
    public float4 zxyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.x, this.y, this.x);
    }
    public float4 zxyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.x, this.y, this.y);
    }
    public float4 zxyz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.x, this.y, this.z);
    }
    public float4 zxzx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.x, this.z, this.x);
    }
    public float4 zxzy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.x, this.z, this.y);
    }
    public float4 zxzz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.x, this.z, this.z);
    }
    public float4 zyxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.y, this.x, this.x);
    }
    public float4 zyxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.y, this.x, this.y);
    }
    public float4 zyxz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.y, this.x, this.z);
    }
    public float4 zyyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.y, this.y, this.x);
    }
    public float4 zyyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.y, this.y, this.y);
    }
    public float4 zyyz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.y, this.y, this.z);
    }
    public float4 zyzx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.y, this.z, this.x);
    }
    public float4 zyzy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.y, this.z, this.y);
    }
    public float4 zyzz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.y, this.z, this.z);
    }
    public float4 zzxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.z, this.x, this.x);
    }
    public float4 zzxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.z, this.x, this.y);
    }
    public float4 zzxz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.z, this.x, this.z);
    }
    public float4 zzyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.z, this.y, this.x);
    }
    public float4 zzyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.z, this.y, this.y);
    }
    public float4 zzyz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.z, this.y, this.z);
    }
    public float4 zzzx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.z, this.z, this.x);
    }
    public float4 zzzy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.z, this.z, this.y);
    }
    public float4 zzzz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.z, this.z, this.z);
    }
    public float4 rrrr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.r, this.r, this.r);
    }
    public float4 rrrg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.r, this.r, this.g);
    }
    public float4 rrrb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.r, this.r, this.b);
    }
    public float4 rrgr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.r, this.g, this.r);
    }
    public float4 rrgg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.r, this.g, this.g);
    }
    public float4 rrgb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.r, this.g, this.b);
    }
    public float4 rrbr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.r, this.b, this.r);
    }
    public float4 rrbg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.r, this.b, this.g);
    }
    public float4 rrbb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.r, this.b, this.b);
    }
    public float4 rgrr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.g, this.r, this.r);
    }
    public float4 rgrg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.g, this.r, this.g);
    }
    public float4 rgrb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.g, this.r, this.b);
    }
    public float4 rggr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.g, this.g, this.r);
    }
    public float4 rggg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.g, this.g, this.g);
    }
    public float4 rggb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.g, this.g, this.b);
    }
    public float4 rgbr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.g, this.b, this.r);
    }
    public float4 rgbg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.g, this.b, this.g);
    }
    public float4 rgbb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.g, this.b, this.b);
    }
    public float4 rbrr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.b, this.r, this.r);
    }
    public float4 rbrg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.b, this.r, this.g);
    }
    public float4 rbrb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.b, this.r, this.b);
    }
    public float4 rbgr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.b, this.g, this.r);
    }
    public float4 rbgg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.b, this.g, this.g);
    }
    public float4 rbgb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.b, this.g, this.b);
    }
    public float4 rbbr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.b, this.b, this.r);
    }
    public float4 rbbg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.b, this.b, this.g);
    }
    public float4 rbbb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.b, this.b, this.b);
    }
    public float4 grrr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.r, this.r, this.r);
    }
    public float4 grrg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.r, this.r, this.g);
    }
    public float4 grrb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.r, this.r, this.b);
    }
    public float4 grgr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.r, this.g, this.r);
    }
    public float4 grgg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.r, this.g, this.g);
    }
    public float4 grgb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.r, this.g, this.b);
    }
    public float4 grbr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.r, this.b, this.r);
    }
    public float4 grbg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.r, this.b, this.g);
    }
    public float4 grbb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.r, this.b, this.b);
    }
    public float4 ggrr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.g, this.r, this.r);
    }
    public float4 ggrg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.g, this.r, this.g);
    }
    public float4 ggrb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.g, this.r, this.b);
    }
    public float4 gggr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.g, this.g, this.r);
    }
    public float4 gggg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.g, this.g, this.g);
    }
    public float4 gggb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.g, this.g, this.b);
    }
    public float4 ggbr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.g, this.b, this.r);
    }
    public float4 ggbg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.g, this.b, this.g);
    }
    public float4 ggbb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.g, this.b, this.b);
    }
    public float4 gbrr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.b, this.r, this.r);
    }
    public float4 gbrg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.b, this.r, this.g);
    }
    public float4 gbrb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.b, this.r, this.b);
    }
    public float4 gbgr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.b, this.g, this.r);
    }
    public float4 gbgg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.b, this.g, this.g);
    }
    public float4 gbgb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.b, this.g, this.b);
    }
    public float4 gbbr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.b, this.b, this.r);
    }
    public float4 gbbg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.b, this.b, this.g);
    }
    public float4 gbbb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.b, this.b, this.b);
    }
    public float4 brrr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.r, this.r, this.r);
    }
    public float4 brrg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.r, this.r, this.g);
    }
    public float4 brrb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.r, this.r, this.b);
    }
    public float4 brgr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.r, this.g, this.r);
    }
    public float4 brgg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.r, this.g, this.g);
    }
    public float4 brgb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.r, this.g, this.b);
    }
    public float4 brbr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.r, this.b, this.r);
    }
    public float4 brbg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.r, this.b, this.g);
    }
    public float4 brbb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.r, this.b, this.b);
    }
    public float4 bgrr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.g, this.r, this.r);
    }
    public float4 bgrg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.g, this.r, this.g);
    }
    public float4 bgrb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.g, this.r, this.b);
    }
    public float4 bggr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.g, this.g, this.r);
    }
    public float4 bggg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.g, this.g, this.g);
    }
    public float4 bggb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.g, this.g, this.b);
    }
    public float4 bgbr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.g, this.b, this.r);
    }
    public float4 bgbg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.g, this.b, this.g);
    }
    public float4 bgbb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.g, this.b, this.b);
    }
    public float4 bbrr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.b, this.r, this.r);
    }
    public float4 bbrg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.b, this.r, this.g);
    }
    public float4 bbrb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.b, this.r, this.b);
    }
    public float4 bbgr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.b, this.g, this.r);
    }
    public float4 bbgg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.b, this.g, this.g);
    }
    public float4 bbgb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.b, this.g, this.b);
    }
    public float4 bbbr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.b, this.b, this.r);
    }
    public float4 bbbg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.b, this.b, this.g);
    }
    public float4 bbbb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.b, this.b, this.b);
    }


}
