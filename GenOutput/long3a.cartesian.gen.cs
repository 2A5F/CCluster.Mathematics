using System;
using System.Numerics;
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.X86;
using System.Runtime.Intrinsics.Arm;
using System.Runtime.CompilerServices;

#nullable enable
#pragma warning disable CS8981

namespace CCluster.Mathematics;

public partial struct long3a 
{

    public long2 xx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.x);
    }
    public long2 xy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.y);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.x = value.x; this.y = value.y; }
    }
    public long2 xz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.z);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.x = value.x; this.z = value.y; }
    }
    public long2 yx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.x);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.y = value.x; this.x = value.y; }
    }
    public long2 yy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.y);
    }
    public long2 yz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.z);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.y = value.x; this.z = value.y; }
    }
    public long2 zx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.x);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.z = value.x; this.x = value.y; }
    }
    public long2 zy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.y);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.z = value.x; this.y = value.y; }
    }
    public long2 zz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.z);
    }
    public long2 rr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.r);
    }
    public long2 rg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.g);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.r = value.x; this.g = value.y; }
    }
    public long2 rb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.b);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.r = value.x; this.b = value.y; }
    }
    public long2 gr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.r);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.g = value.x; this.r = value.y; }
    }
    public long2 gg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.g);
    }
    public long2 gb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.b);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.g = value.x; this.b = value.y; }
    }
    public long2 br
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.r);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.b = value.x; this.r = value.y; }
    }
    public long2 bg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.g);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.b = value.x; this.g = value.y; }
    }
    public long2 bb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.b);
    }
    public long3a xxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.x, this.x);
    }
    public long3a xxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.x, this.y);
    }
    public long3a xxz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.x, this.z);
    }
    public long3a xyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.y, this.x);
    }
    public long3a xyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.y, this.y);
    }
    public long3a xyz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.y, this.z);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.x = value.x; this.y = value.y; this.z = value.z; }
    }
    public long3a xzx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.z, this.x);
    }
    public long3a xzy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.z, this.y);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.x = value.x; this.z = value.y; this.y = value.z; }
    }
    public long3a xzz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.z, this.z);
    }
    public long3a yxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.x, this.x);
    }
    public long3a yxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.x, this.y);
    }
    public long3a yxz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.x, this.z);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.y = value.x; this.x = value.y; this.z = value.z; }
    }
    public long3a yyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.y, this.x);
    }
    public long3a yyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.y, this.y);
    }
    public long3a yyz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.y, this.z);
    }
    public long3a yzx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.z, this.x);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.y = value.x; this.z = value.y; this.x = value.z; }
    }
    public long3a yzy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.z, this.y);
    }
    public long3a yzz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.z, this.z);
    }
    public long3a zxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.x, this.x);
    }
    public long3a zxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.x, this.y);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.z = value.x; this.x = value.y; this.y = value.z; }
    }
    public long3a zxz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.x, this.z);
    }
    public long3a zyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.y, this.x);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.z = value.x; this.y = value.y; this.x = value.z; }
    }
    public long3a zyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.y, this.y);
    }
    public long3a zyz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.y, this.z);
    }
    public long3a zzx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.z, this.x);
    }
    public long3a zzy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.z, this.y);
    }
    public long3a zzz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.z, this.z);
    }
    public long3a rrr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.r, this.r);
    }
    public long3a rrg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.r, this.g);
    }
    public long3a rrb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.r, this.b);
    }
    public long3a rgr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.g, this.r);
    }
    public long3a rgg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.g, this.g);
    }
    public long3a rgb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.g, this.b);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.r = value.x; this.g = value.y; this.b = value.z; }
    }
    public long3a rbr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.b, this.r);
    }
    public long3a rbg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.b, this.g);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.r = value.x; this.b = value.y; this.g = value.z; }
    }
    public long3a rbb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.b, this.b);
    }
    public long3a grr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.r, this.r);
    }
    public long3a grg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.r, this.g);
    }
    public long3a grb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.r, this.b);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.g = value.x; this.r = value.y; this.b = value.z; }
    }
    public long3a ggr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.g, this.r);
    }
    public long3a ggg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.g, this.g);
    }
    public long3a ggb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.g, this.b);
    }
    public long3a gbr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.b, this.r);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.g = value.x; this.b = value.y; this.r = value.z; }
    }
    public long3a gbg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.b, this.g);
    }
    public long3a gbb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.b, this.b);
    }
    public long3a brr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.r, this.r);
    }
    public long3a brg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.r, this.g);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.b = value.x; this.r = value.y; this.g = value.z; }
    }
    public long3a brb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.r, this.b);
    }
    public long3a bgr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.g, this.r);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.b = value.x; this.g = value.y; this.r = value.z; }
    }
    public long3a bgg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.g, this.g);
    }
    public long3a bgb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.g, this.b);
    }
    public long3a bbr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.b, this.r);
    }
    public long3a bbg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.b, this.g);
    }
    public long3a bbb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.b, this.b);
    }
    public long4 xxxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.x, this.x, this.x);
    }
    public long4 xxxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.x, this.x, this.y);
    }
    public long4 xxxz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.x, this.x, this.z);
    }
    public long4 xxyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.x, this.y, this.x);
    }
    public long4 xxyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.x, this.y, this.y);
    }
    public long4 xxyz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.x, this.y, this.z);
    }
    public long4 xxzx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.x, this.z, this.x);
    }
    public long4 xxzy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.x, this.z, this.y);
    }
    public long4 xxzz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.x, this.z, this.z);
    }
    public long4 xyxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.y, this.x, this.x);
    }
    public long4 xyxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.y, this.x, this.y);
    }
    public long4 xyxz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.y, this.x, this.z);
    }
    public long4 xyyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.y, this.y, this.x);
    }
    public long4 xyyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.y, this.y, this.y);
    }
    public long4 xyyz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.y, this.y, this.z);
    }
    public long4 xyzx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.y, this.z, this.x);
    }
    public long4 xyzy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.y, this.z, this.y);
    }
    public long4 xyzz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.y, this.z, this.z);
    }
    public long4 xzxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.z, this.x, this.x);
    }
    public long4 xzxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.z, this.x, this.y);
    }
    public long4 xzxz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.z, this.x, this.z);
    }
    public long4 xzyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.z, this.y, this.x);
    }
    public long4 xzyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.z, this.y, this.y);
    }
    public long4 xzyz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.z, this.y, this.z);
    }
    public long4 xzzx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.z, this.z, this.x);
    }
    public long4 xzzy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.z, this.z, this.y);
    }
    public long4 xzzz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.z, this.z, this.z);
    }
    public long4 yxxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.x, this.x, this.x);
    }
    public long4 yxxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.x, this.x, this.y);
    }
    public long4 yxxz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.x, this.x, this.z);
    }
    public long4 yxyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.x, this.y, this.x);
    }
    public long4 yxyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.x, this.y, this.y);
    }
    public long4 yxyz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.x, this.y, this.z);
    }
    public long4 yxzx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.x, this.z, this.x);
    }
    public long4 yxzy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.x, this.z, this.y);
    }
    public long4 yxzz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.x, this.z, this.z);
    }
    public long4 yyxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.y, this.x, this.x);
    }
    public long4 yyxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.y, this.x, this.y);
    }
    public long4 yyxz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.y, this.x, this.z);
    }
    public long4 yyyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.y, this.y, this.x);
    }
    public long4 yyyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.y, this.y, this.y);
    }
    public long4 yyyz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.y, this.y, this.z);
    }
    public long4 yyzx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.y, this.z, this.x);
    }
    public long4 yyzy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.y, this.z, this.y);
    }
    public long4 yyzz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.y, this.z, this.z);
    }
    public long4 yzxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.z, this.x, this.x);
    }
    public long4 yzxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.z, this.x, this.y);
    }
    public long4 yzxz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.z, this.x, this.z);
    }
    public long4 yzyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.z, this.y, this.x);
    }
    public long4 yzyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.z, this.y, this.y);
    }
    public long4 yzyz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.z, this.y, this.z);
    }
    public long4 yzzx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.z, this.z, this.x);
    }
    public long4 yzzy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.z, this.z, this.y);
    }
    public long4 yzzz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.z, this.z, this.z);
    }
    public long4 zxxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.x, this.x, this.x);
    }
    public long4 zxxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.x, this.x, this.y);
    }
    public long4 zxxz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.x, this.x, this.z);
    }
    public long4 zxyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.x, this.y, this.x);
    }
    public long4 zxyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.x, this.y, this.y);
    }
    public long4 zxyz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.x, this.y, this.z);
    }
    public long4 zxzx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.x, this.z, this.x);
    }
    public long4 zxzy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.x, this.z, this.y);
    }
    public long4 zxzz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.x, this.z, this.z);
    }
    public long4 zyxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.y, this.x, this.x);
    }
    public long4 zyxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.y, this.x, this.y);
    }
    public long4 zyxz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.y, this.x, this.z);
    }
    public long4 zyyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.y, this.y, this.x);
    }
    public long4 zyyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.y, this.y, this.y);
    }
    public long4 zyyz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.y, this.y, this.z);
    }
    public long4 zyzx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.y, this.z, this.x);
    }
    public long4 zyzy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.y, this.z, this.y);
    }
    public long4 zyzz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.y, this.z, this.z);
    }
    public long4 zzxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.z, this.x, this.x);
    }
    public long4 zzxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.z, this.x, this.y);
    }
    public long4 zzxz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.z, this.x, this.z);
    }
    public long4 zzyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.z, this.y, this.x);
    }
    public long4 zzyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.z, this.y, this.y);
    }
    public long4 zzyz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.z, this.y, this.z);
    }
    public long4 zzzx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.z, this.z, this.x);
    }
    public long4 zzzy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.z, this.z, this.y);
    }
    public long4 zzzz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.z, this.z, this.z);
    }
    public long4 rrrr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.r, this.r, this.r);
    }
    public long4 rrrg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.r, this.r, this.g);
    }
    public long4 rrrb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.r, this.r, this.b);
    }
    public long4 rrgr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.r, this.g, this.r);
    }
    public long4 rrgg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.r, this.g, this.g);
    }
    public long4 rrgb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.r, this.g, this.b);
    }
    public long4 rrbr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.r, this.b, this.r);
    }
    public long4 rrbg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.r, this.b, this.g);
    }
    public long4 rrbb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.r, this.b, this.b);
    }
    public long4 rgrr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.g, this.r, this.r);
    }
    public long4 rgrg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.g, this.r, this.g);
    }
    public long4 rgrb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.g, this.r, this.b);
    }
    public long4 rggr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.g, this.g, this.r);
    }
    public long4 rggg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.g, this.g, this.g);
    }
    public long4 rggb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.g, this.g, this.b);
    }
    public long4 rgbr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.g, this.b, this.r);
    }
    public long4 rgbg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.g, this.b, this.g);
    }
    public long4 rgbb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.g, this.b, this.b);
    }
    public long4 rbrr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.b, this.r, this.r);
    }
    public long4 rbrg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.b, this.r, this.g);
    }
    public long4 rbrb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.b, this.r, this.b);
    }
    public long4 rbgr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.b, this.g, this.r);
    }
    public long4 rbgg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.b, this.g, this.g);
    }
    public long4 rbgb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.b, this.g, this.b);
    }
    public long4 rbbr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.b, this.b, this.r);
    }
    public long4 rbbg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.b, this.b, this.g);
    }
    public long4 rbbb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.b, this.b, this.b);
    }
    public long4 grrr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.r, this.r, this.r);
    }
    public long4 grrg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.r, this.r, this.g);
    }
    public long4 grrb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.r, this.r, this.b);
    }
    public long4 grgr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.r, this.g, this.r);
    }
    public long4 grgg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.r, this.g, this.g);
    }
    public long4 grgb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.r, this.g, this.b);
    }
    public long4 grbr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.r, this.b, this.r);
    }
    public long4 grbg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.r, this.b, this.g);
    }
    public long4 grbb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.r, this.b, this.b);
    }
    public long4 ggrr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.g, this.r, this.r);
    }
    public long4 ggrg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.g, this.r, this.g);
    }
    public long4 ggrb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.g, this.r, this.b);
    }
    public long4 gggr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.g, this.g, this.r);
    }
    public long4 gggg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.g, this.g, this.g);
    }
    public long4 gggb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.g, this.g, this.b);
    }
    public long4 ggbr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.g, this.b, this.r);
    }
    public long4 ggbg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.g, this.b, this.g);
    }
    public long4 ggbb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.g, this.b, this.b);
    }
    public long4 gbrr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.b, this.r, this.r);
    }
    public long4 gbrg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.b, this.r, this.g);
    }
    public long4 gbrb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.b, this.r, this.b);
    }
    public long4 gbgr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.b, this.g, this.r);
    }
    public long4 gbgg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.b, this.g, this.g);
    }
    public long4 gbgb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.b, this.g, this.b);
    }
    public long4 gbbr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.b, this.b, this.r);
    }
    public long4 gbbg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.b, this.b, this.g);
    }
    public long4 gbbb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.b, this.b, this.b);
    }
    public long4 brrr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.r, this.r, this.r);
    }
    public long4 brrg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.r, this.r, this.g);
    }
    public long4 brrb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.r, this.r, this.b);
    }
    public long4 brgr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.r, this.g, this.r);
    }
    public long4 brgg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.r, this.g, this.g);
    }
    public long4 brgb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.r, this.g, this.b);
    }
    public long4 brbr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.r, this.b, this.r);
    }
    public long4 brbg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.r, this.b, this.g);
    }
    public long4 brbb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.r, this.b, this.b);
    }
    public long4 bgrr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.g, this.r, this.r);
    }
    public long4 bgrg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.g, this.r, this.g);
    }
    public long4 bgrb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.g, this.r, this.b);
    }
    public long4 bggr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.g, this.g, this.r);
    }
    public long4 bggg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.g, this.g, this.g);
    }
    public long4 bggb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.g, this.g, this.b);
    }
    public long4 bgbr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.g, this.b, this.r);
    }
    public long4 bgbg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.g, this.b, this.g);
    }
    public long4 bgbb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.g, this.b, this.b);
    }
    public long4 bbrr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.b, this.r, this.r);
    }
    public long4 bbrg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.b, this.r, this.g);
    }
    public long4 bbrb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.b, this.r, this.b);
    }
    public long4 bbgr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.b, this.g, this.r);
    }
    public long4 bbgg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.b, this.g, this.g);
    }
    public long4 bbgb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.b, this.g, this.b);
    }
    public long4 bbbr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.b, this.b, this.r);
    }
    public long4 bbbg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.b, this.b, this.g);
    }
    public long4 bbbb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.b, this.b, this.b);
    }


}
