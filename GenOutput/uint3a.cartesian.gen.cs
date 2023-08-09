using System;
using System.Numerics;
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.X86;
using System.Runtime.Intrinsics.Arm;
using System.Runtime.CompilerServices;

#nullable enable
#pragma warning disable CS8981

namespace CCluster.Mathematics;

public partial struct uint3a 
{

    public uint2 xx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.x);
    }
    public uint2 xy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.y);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.x = value.x; this.y = value.y; }
    }
    public uint2 xz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.z);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.x = value.x; this.z = value.y; }
    }
    public uint2 yx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.x);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.y = value.x; this.x = value.y; }
    }
    public uint2 yy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.y);
    }
    public uint2 yz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.z);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.y = value.x; this.z = value.y; }
    }
    public uint2 zx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.x);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.z = value.x; this.x = value.y; }
    }
    public uint2 zy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.y);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.z = value.x; this.y = value.y; }
    }
    public uint2 zz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.z);
    }
    public uint2 rr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.r);
    }
    public uint2 rg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.g);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.r = value.x; this.g = value.y; }
    }
    public uint2 rb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.b);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.r = value.x; this.b = value.y; }
    }
    public uint2 gr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.r);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.g = value.x; this.r = value.y; }
    }
    public uint2 gg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.g);
    }
    public uint2 gb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.b);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.g = value.x; this.b = value.y; }
    }
    public uint2 br
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.r);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.b = value.x; this.r = value.y; }
    }
    public uint2 bg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.g);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.b = value.x; this.g = value.y; }
    }
    public uint2 bb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.b);
    }
    public uint3a xxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.x, this.x);
    }
    public uint3a xxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.x, this.y);
    }
    public uint3a xxz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.x, this.z);
    }
    public uint3a xyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.y, this.x);
    }
    public uint3a xyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.y, this.y);
    }
    public uint3a xyz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.y, this.z);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.x = value.x; this.y = value.y; this.z = value.z; }
    }
    public uint3a xzx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.z, this.x);
    }
    public uint3a xzy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.z, this.y);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.x = value.x; this.z = value.y; this.y = value.z; }
    }
    public uint3a xzz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.z, this.z);
    }
    public uint3a yxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.x, this.x);
    }
    public uint3a yxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.x, this.y);
    }
    public uint3a yxz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.x, this.z);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.y = value.x; this.x = value.y; this.z = value.z; }
    }
    public uint3a yyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.y, this.x);
    }
    public uint3a yyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.y, this.y);
    }
    public uint3a yyz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.y, this.z);
    }
    public uint3a yzx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.z, this.x);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.y = value.x; this.z = value.y; this.x = value.z; }
    }
    public uint3a yzy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.z, this.y);
    }
    public uint3a yzz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.z, this.z);
    }
    public uint3a zxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.x, this.x);
    }
    public uint3a zxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.x, this.y);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.z = value.x; this.x = value.y; this.y = value.z; }
    }
    public uint3a zxz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.x, this.z);
    }
    public uint3a zyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.y, this.x);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.z = value.x; this.y = value.y; this.x = value.z; }
    }
    public uint3a zyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.y, this.y);
    }
    public uint3a zyz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.y, this.z);
    }
    public uint3a zzx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.z, this.x);
    }
    public uint3a zzy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.z, this.y);
    }
    public uint3a zzz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.z, this.z);
    }
    public uint3a rrr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.r, this.r);
    }
    public uint3a rrg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.r, this.g);
    }
    public uint3a rrb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.r, this.b);
    }
    public uint3a rgr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.g, this.r);
    }
    public uint3a rgg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.g, this.g);
    }
    public uint3a rgb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.g, this.b);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.r = value.x; this.g = value.y; this.b = value.z; }
    }
    public uint3a rbr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.b, this.r);
    }
    public uint3a rbg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.b, this.g);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.r = value.x; this.b = value.y; this.g = value.z; }
    }
    public uint3a rbb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.b, this.b);
    }
    public uint3a grr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.r, this.r);
    }
    public uint3a grg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.r, this.g);
    }
    public uint3a grb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.r, this.b);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.g = value.x; this.r = value.y; this.b = value.z; }
    }
    public uint3a ggr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.g, this.r);
    }
    public uint3a ggg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.g, this.g);
    }
    public uint3a ggb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.g, this.b);
    }
    public uint3a gbr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.b, this.r);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.g = value.x; this.b = value.y; this.r = value.z; }
    }
    public uint3a gbg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.b, this.g);
    }
    public uint3a gbb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.b, this.b);
    }
    public uint3a brr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.r, this.r);
    }
    public uint3a brg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.r, this.g);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.b = value.x; this.r = value.y; this.g = value.z; }
    }
    public uint3a brb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.r, this.b);
    }
    public uint3a bgr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.g, this.r);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.b = value.x; this.g = value.y; this.r = value.z; }
    }
    public uint3a bgg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.g, this.g);
    }
    public uint3a bgb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.g, this.b);
    }
    public uint3a bbr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.b, this.r);
    }
    public uint3a bbg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.b, this.g);
    }
    public uint3a bbb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.b, this.b);
    }
    public uint4 xxxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.x, this.x, this.x);
    }
    public uint4 xxxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.x, this.x, this.y);
    }
    public uint4 xxxz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.x, this.x, this.z);
    }
    public uint4 xxyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.x, this.y, this.x);
    }
    public uint4 xxyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.x, this.y, this.y);
    }
    public uint4 xxyz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.x, this.y, this.z);
    }
    public uint4 xxzx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.x, this.z, this.x);
    }
    public uint4 xxzy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.x, this.z, this.y);
    }
    public uint4 xxzz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.x, this.z, this.z);
    }
    public uint4 xyxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.y, this.x, this.x);
    }
    public uint4 xyxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.y, this.x, this.y);
    }
    public uint4 xyxz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.y, this.x, this.z);
    }
    public uint4 xyyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.y, this.y, this.x);
    }
    public uint4 xyyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.y, this.y, this.y);
    }
    public uint4 xyyz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.y, this.y, this.z);
    }
    public uint4 xyzx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.y, this.z, this.x);
    }
    public uint4 xyzy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.y, this.z, this.y);
    }
    public uint4 xyzz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.y, this.z, this.z);
    }
    public uint4 xzxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.z, this.x, this.x);
    }
    public uint4 xzxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.z, this.x, this.y);
    }
    public uint4 xzxz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.z, this.x, this.z);
    }
    public uint4 xzyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.z, this.y, this.x);
    }
    public uint4 xzyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.z, this.y, this.y);
    }
    public uint4 xzyz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.z, this.y, this.z);
    }
    public uint4 xzzx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.z, this.z, this.x);
    }
    public uint4 xzzy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.z, this.z, this.y);
    }
    public uint4 xzzz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.z, this.z, this.z);
    }
    public uint4 yxxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.x, this.x, this.x);
    }
    public uint4 yxxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.x, this.x, this.y);
    }
    public uint4 yxxz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.x, this.x, this.z);
    }
    public uint4 yxyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.x, this.y, this.x);
    }
    public uint4 yxyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.x, this.y, this.y);
    }
    public uint4 yxyz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.x, this.y, this.z);
    }
    public uint4 yxzx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.x, this.z, this.x);
    }
    public uint4 yxzy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.x, this.z, this.y);
    }
    public uint4 yxzz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.x, this.z, this.z);
    }
    public uint4 yyxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.y, this.x, this.x);
    }
    public uint4 yyxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.y, this.x, this.y);
    }
    public uint4 yyxz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.y, this.x, this.z);
    }
    public uint4 yyyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.y, this.y, this.x);
    }
    public uint4 yyyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.y, this.y, this.y);
    }
    public uint4 yyyz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.y, this.y, this.z);
    }
    public uint4 yyzx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.y, this.z, this.x);
    }
    public uint4 yyzy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.y, this.z, this.y);
    }
    public uint4 yyzz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.y, this.z, this.z);
    }
    public uint4 yzxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.z, this.x, this.x);
    }
    public uint4 yzxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.z, this.x, this.y);
    }
    public uint4 yzxz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.z, this.x, this.z);
    }
    public uint4 yzyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.z, this.y, this.x);
    }
    public uint4 yzyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.z, this.y, this.y);
    }
    public uint4 yzyz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.z, this.y, this.z);
    }
    public uint4 yzzx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.z, this.z, this.x);
    }
    public uint4 yzzy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.z, this.z, this.y);
    }
    public uint4 yzzz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.z, this.z, this.z);
    }
    public uint4 zxxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.x, this.x, this.x);
    }
    public uint4 zxxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.x, this.x, this.y);
    }
    public uint4 zxxz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.x, this.x, this.z);
    }
    public uint4 zxyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.x, this.y, this.x);
    }
    public uint4 zxyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.x, this.y, this.y);
    }
    public uint4 zxyz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.x, this.y, this.z);
    }
    public uint4 zxzx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.x, this.z, this.x);
    }
    public uint4 zxzy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.x, this.z, this.y);
    }
    public uint4 zxzz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.x, this.z, this.z);
    }
    public uint4 zyxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.y, this.x, this.x);
    }
    public uint4 zyxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.y, this.x, this.y);
    }
    public uint4 zyxz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.y, this.x, this.z);
    }
    public uint4 zyyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.y, this.y, this.x);
    }
    public uint4 zyyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.y, this.y, this.y);
    }
    public uint4 zyyz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.y, this.y, this.z);
    }
    public uint4 zyzx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.y, this.z, this.x);
    }
    public uint4 zyzy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.y, this.z, this.y);
    }
    public uint4 zyzz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.y, this.z, this.z);
    }
    public uint4 zzxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.z, this.x, this.x);
    }
    public uint4 zzxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.z, this.x, this.y);
    }
    public uint4 zzxz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.z, this.x, this.z);
    }
    public uint4 zzyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.z, this.y, this.x);
    }
    public uint4 zzyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.z, this.y, this.y);
    }
    public uint4 zzyz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.z, this.y, this.z);
    }
    public uint4 zzzx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.z, this.z, this.x);
    }
    public uint4 zzzy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.z, this.z, this.y);
    }
    public uint4 zzzz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.z, this.z, this.z);
    }
    public uint4 rrrr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.r, this.r, this.r);
    }
    public uint4 rrrg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.r, this.r, this.g);
    }
    public uint4 rrrb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.r, this.r, this.b);
    }
    public uint4 rrgr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.r, this.g, this.r);
    }
    public uint4 rrgg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.r, this.g, this.g);
    }
    public uint4 rrgb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.r, this.g, this.b);
    }
    public uint4 rrbr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.r, this.b, this.r);
    }
    public uint4 rrbg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.r, this.b, this.g);
    }
    public uint4 rrbb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.r, this.b, this.b);
    }
    public uint4 rgrr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.g, this.r, this.r);
    }
    public uint4 rgrg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.g, this.r, this.g);
    }
    public uint4 rgrb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.g, this.r, this.b);
    }
    public uint4 rggr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.g, this.g, this.r);
    }
    public uint4 rggg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.g, this.g, this.g);
    }
    public uint4 rggb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.g, this.g, this.b);
    }
    public uint4 rgbr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.g, this.b, this.r);
    }
    public uint4 rgbg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.g, this.b, this.g);
    }
    public uint4 rgbb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.g, this.b, this.b);
    }
    public uint4 rbrr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.b, this.r, this.r);
    }
    public uint4 rbrg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.b, this.r, this.g);
    }
    public uint4 rbrb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.b, this.r, this.b);
    }
    public uint4 rbgr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.b, this.g, this.r);
    }
    public uint4 rbgg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.b, this.g, this.g);
    }
    public uint4 rbgb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.b, this.g, this.b);
    }
    public uint4 rbbr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.b, this.b, this.r);
    }
    public uint4 rbbg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.b, this.b, this.g);
    }
    public uint4 rbbb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.b, this.b, this.b);
    }
    public uint4 grrr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.r, this.r, this.r);
    }
    public uint4 grrg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.r, this.r, this.g);
    }
    public uint4 grrb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.r, this.r, this.b);
    }
    public uint4 grgr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.r, this.g, this.r);
    }
    public uint4 grgg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.r, this.g, this.g);
    }
    public uint4 grgb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.r, this.g, this.b);
    }
    public uint4 grbr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.r, this.b, this.r);
    }
    public uint4 grbg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.r, this.b, this.g);
    }
    public uint4 grbb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.r, this.b, this.b);
    }
    public uint4 ggrr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.g, this.r, this.r);
    }
    public uint4 ggrg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.g, this.r, this.g);
    }
    public uint4 ggrb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.g, this.r, this.b);
    }
    public uint4 gggr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.g, this.g, this.r);
    }
    public uint4 gggg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.g, this.g, this.g);
    }
    public uint4 gggb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.g, this.g, this.b);
    }
    public uint4 ggbr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.g, this.b, this.r);
    }
    public uint4 ggbg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.g, this.b, this.g);
    }
    public uint4 ggbb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.g, this.b, this.b);
    }
    public uint4 gbrr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.b, this.r, this.r);
    }
    public uint4 gbrg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.b, this.r, this.g);
    }
    public uint4 gbrb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.b, this.r, this.b);
    }
    public uint4 gbgr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.b, this.g, this.r);
    }
    public uint4 gbgg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.b, this.g, this.g);
    }
    public uint4 gbgb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.b, this.g, this.b);
    }
    public uint4 gbbr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.b, this.b, this.r);
    }
    public uint4 gbbg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.b, this.b, this.g);
    }
    public uint4 gbbb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.b, this.b, this.b);
    }
    public uint4 brrr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.r, this.r, this.r);
    }
    public uint4 brrg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.r, this.r, this.g);
    }
    public uint4 brrb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.r, this.r, this.b);
    }
    public uint4 brgr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.r, this.g, this.r);
    }
    public uint4 brgg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.r, this.g, this.g);
    }
    public uint4 brgb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.r, this.g, this.b);
    }
    public uint4 brbr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.r, this.b, this.r);
    }
    public uint4 brbg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.r, this.b, this.g);
    }
    public uint4 brbb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.r, this.b, this.b);
    }
    public uint4 bgrr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.g, this.r, this.r);
    }
    public uint4 bgrg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.g, this.r, this.g);
    }
    public uint4 bgrb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.g, this.r, this.b);
    }
    public uint4 bggr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.g, this.g, this.r);
    }
    public uint4 bggg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.g, this.g, this.g);
    }
    public uint4 bggb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.g, this.g, this.b);
    }
    public uint4 bgbr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.g, this.b, this.r);
    }
    public uint4 bgbg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.g, this.b, this.g);
    }
    public uint4 bgbb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.g, this.b, this.b);
    }
    public uint4 bbrr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.b, this.r, this.r);
    }
    public uint4 bbrg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.b, this.r, this.g);
    }
    public uint4 bbrb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.b, this.r, this.b);
    }
    public uint4 bbgr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.b, this.g, this.r);
    }
    public uint4 bbgg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.b, this.g, this.g);
    }
    public uint4 bbgb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.b, this.g, this.b);
    }
    public uint4 bbbr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.b, this.b, this.r);
    }
    public uint4 bbbg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.b, this.b, this.g);
    }
    public uint4 bbbb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.b, this.b, this.b);
    }


}
