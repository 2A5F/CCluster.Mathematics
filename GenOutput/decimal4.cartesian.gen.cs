using System;
using System.Numerics;
using System.Runtime.CompilerServices;

#nullable enable
#pragma warning disable CS8981

namespace CCluster.Mathematics;

public partial struct decimal4 
{

    public decimal2 xx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal2(this.x, this.x);
    }
    public decimal2 xy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal2(this.x, this.y);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.x = value.x; this.y = value.y; }
    }
    public decimal2 xz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal2(this.x, this.z);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.x = value.x; this.z = value.y; }
    }
    public decimal2 xw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal2(this.x, this.w);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.x = value.x; this.w = value.y; }
    }
    public decimal2 yx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal2(this.y, this.x);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.y = value.x; this.x = value.y; }
    }
    public decimal2 yy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal2(this.y, this.y);
    }
    public decimal2 yz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal2(this.y, this.z);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.y = value.x; this.z = value.y; }
    }
    public decimal2 yw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal2(this.y, this.w);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.y = value.x; this.w = value.y; }
    }
    public decimal2 zx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal2(this.z, this.x);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.z = value.x; this.x = value.y; }
    }
    public decimal2 zy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal2(this.z, this.y);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.z = value.x; this.y = value.y; }
    }
    public decimal2 zz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal2(this.z, this.z);
    }
    public decimal2 zw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal2(this.z, this.w);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.z = value.x; this.w = value.y; }
    }
    public decimal2 wx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal2(this.w, this.x);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.w = value.x; this.x = value.y; }
    }
    public decimal2 wy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal2(this.w, this.y);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.w = value.x; this.y = value.y; }
    }
    public decimal2 wz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal2(this.w, this.z);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.w = value.x; this.z = value.y; }
    }
    public decimal2 ww
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal2(this.w, this.w);
    }
    public decimal2 rr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal2(this.r, this.r);
    }
    public decimal2 rg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal2(this.r, this.g);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.r = value.x; this.g = value.y; }
    }
    public decimal2 rb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal2(this.r, this.b);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.r = value.x; this.b = value.y; }
    }
    public decimal2 ra
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal2(this.r, this.a);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.r = value.x; this.a = value.y; }
    }
    public decimal2 gr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal2(this.g, this.r);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.g = value.x; this.r = value.y; }
    }
    public decimal2 gg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal2(this.g, this.g);
    }
    public decimal2 gb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal2(this.g, this.b);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.g = value.x; this.b = value.y; }
    }
    public decimal2 ga
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal2(this.g, this.a);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.g = value.x; this.a = value.y; }
    }
    public decimal2 br
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal2(this.b, this.r);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.b = value.x; this.r = value.y; }
    }
    public decimal2 bg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal2(this.b, this.g);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.b = value.x; this.g = value.y; }
    }
    public decimal2 bb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal2(this.b, this.b);
    }
    public decimal2 ba
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal2(this.b, this.a);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.b = value.x; this.a = value.y; }
    }
    public decimal2 ar
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal2(this.a, this.r);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.a = value.x; this.r = value.y; }
    }
    public decimal2 ag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal2(this.a, this.g);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.a = value.x; this.g = value.y; }
    }
    public decimal2 ab
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal2(this.a, this.b);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.a = value.x; this.b = value.y; }
    }
    public decimal2 aa
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal2(this.a, this.a);
    }
    public decimal3 xxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal3(this.x, this.x, this.x);
    }
    public decimal3 xxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal3(this.x, this.x, this.y);
    }
    public decimal3 xxz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal3(this.x, this.x, this.z);
    }
    public decimal3 xxw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal3(this.x, this.x, this.w);
    }
    public decimal3 xyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal3(this.x, this.y, this.x);
    }
    public decimal3 xyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal3(this.x, this.y, this.y);
    }
    public decimal3 xyz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal3(this.x, this.y, this.z);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.x = value.x; this.y = value.y; this.z = value.z; }
    }
    public decimal3 xyw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal3(this.x, this.y, this.w);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.x = value.x; this.y = value.y; this.w = value.z; }
    }
    public decimal3 xzx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal3(this.x, this.z, this.x);
    }
    public decimal3 xzy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal3(this.x, this.z, this.y);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.x = value.x; this.z = value.y; this.y = value.z; }
    }
    public decimal3 xzz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal3(this.x, this.z, this.z);
    }
    public decimal3 xzw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal3(this.x, this.z, this.w);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.x = value.x; this.z = value.y; this.w = value.z; }
    }
    public decimal3 xwx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal3(this.x, this.w, this.x);
    }
    public decimal3 xwy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal3(this.x, this.w, this.y);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.x = value.x; this.w = value.y; this.y = value.z; }
    }
    public decimal3 xwz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal3(this.x, this.w, this.z);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.x = value.x; this.w = value.y; this.z = value.z; }
    }
    public decimal3 xww
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal3(this.x, this.w, this.w);
    }
    public decimal3 yxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal3(this.y, this.x, this.x);
    }
    public decimal3 yxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal3(this.y, this.x, this.y);
    }
    public decimal3 yxz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal3(this.y, this.x, this.z);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.y = value.x; this.x = value.y; this.z = value.z; }
    }
    public decimal3 yxw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal3(this.y, this.x, this.w);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.y = value.x; this.x = value.y; this.w = value.z; }
    }
    public decimal3 yyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal3(this.y, this.y, this.x);
    }
    public decimal3 yyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal3(this.y, this.y, this.y);
    }
    public decimal3 yyz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal3(this.y, this.y, this.z);
    }
    public decimal3 yyw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal3(this.y, this.y, this.w);
    }
    public decimal3 yzx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal3(this.y, this.z, this.x);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.y = value.x; this.z = value.y; this.x = value.z; }
    }
    public decimal3 yzy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal3(this.y, this.z, this.y);
    }
    public decimal3 yzz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal3(this.y, this.z, this.z);
    }
    public decimal3 yzw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal3(this.y, this.z, this.w);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.y = value.x; this.z = value.y; this.w = value.z; }
    }
    public decimal3 ywx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal3(this.y, this.w, this.x);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.y = value.x; this.w = value.y; this.x = value.z; }
    }
    public decimal3 ywy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal3(this.y, this.w, this.y);
    }
    public decimal3 ywz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal3(this.y, this.w, this.z);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.y = value.x; this.w = value.y; this.z = value.z; }
    }
    public decimal3 yww
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal3(this.y, this.w, this.w);
    }
    public decimal3 zxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal3(this.z, this.x, this.x);
    }
    public decimal3 zxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal3(this.z, this.x, this.y);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.z = value.x; this.x = value.y; this.y = value.z; }
    }
    public decimal3 zxz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal3(this.z, this.x, this.z);
    }
    public decimal3 zxw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal3(this.z, this.x, this.w);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.z = value.x; this.x = value.y; this.w = value.z; }
    }
    public decimal3 zyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal3(this.z, this.y, this.x);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.z = value.x; this.y = value.y; this.x = value.z; }
    }
    public decimal3 zyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal3(this.z, this.y, this.y);
    }
    public decimal3 zyz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal3(this.z, this.y, this.z);
    }
    public decimal3 zyw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal3(this.z, this.y, this.w);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.z = value.x; this.y = value.y; this.w = value.z; }
    }
    public decimal3 zzx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal3(this.z, this.z, this.x);
    }
    public decimal3 zzy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal3(this.z, this.z, this.y);
    }
    public decimal3 zzz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal3(this.z, this.z, this.z);
    }
    public decimal3 zzw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal3(this.z, this.z, this.w);
    }
    public decimal3 zwx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal3(this.z, this.w, this.x);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.z = value.x; this.w = value.y; this.x = value.z; }
    }
    public decimal3 zwy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal3(this.z, this.w, this.y);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.z = value.x; this.w = value.y; this.y = value.z; }
    }
    public decimal3 zwz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal3(this.z, this.w, this.z);
    }
    public decimal3 zww
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal3(this.z, this.w, this.w);
    }
    public decimal3 wxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal3(this.w, this.x, this.x);
    }
    public decimal3 wxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal3(this.w, this.x, this.y);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.w = value.x; this.x = value.y; this.y = value.z; }
    }
    public decimal3 wxz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal3(this.w, this.x, this.z);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.w = value.x; this.x = value.y; this.z = value.z; }
    }
    public decimal3 wxw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal3(this.w, this.x, this.w);
    }
    public decimal3 wyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal3(this.w, this.y, this.x);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.w = value.x; this.y = value.y; this.x = value.z; }
    }
    public decimal3 wyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal3(this.w, this.y, this.y);
    }
    public decimal3 wyz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal3(this.w, this.y, this.z);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.w = value.x; this.y = value.y; this.z = value.z; }
    }
    public decimal3 wyw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal3(this.w, this.y, this.w);
    }
    public decimal3 wzx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal3(this.w, this.z, this.x);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.w = value.x; this.z = value.y; this.x = value.z; }
    }
    public decimal3 wzy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal3(this.w, this.z, this.y);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.w = value.x; this.z = value.y; this.y = value.z; }
    }
    public decimal3 wzz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal3(this.w, this.z, this.z);
    }
    public decimal3 wzw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal3(this.w, this.z, this.w);
    }
    public decimal3 wwx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal3(this.w, this.w, this.x);
    }
    public decimal3 wwy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal3(this.w, this.w, this.y);
    }
    public decimal3 wwz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal3(this.w, this.w, this.z);
    }
    public decimal3 www
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal3(this.w, this.w, this.w);
    }
    public decimal3 rrr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal3(this.r, this.r, this.r);
    }
    public decimal3 rrg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal3(this.r, this.r, this.g);
    }
    public decimal3 rrb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal3(this.r, this.r, this.b);
    }
    public decimal3 rra
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal3(this.r, this.r, this.a);
    }
    public decimal3 rgr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal3(this.r, this.g, this.r);
    }
    public decimal3 rgg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal3(this.r, this.g, this.g);
    }
    public decimal3 rgb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal3(this.r, this.g, this.b);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.r = value.x; this.g = value.y; this.b = value.z; }
    }
    public decimal3 rga
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal3(this.r, this.g, this.a);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.r = value.x; this.g = value.y; this.a = value.z; }
    }
    public decimal3 rbr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal3(this.r, this.b, this.r);
    }
    public decimal3 rbg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal3(this.r, this.b, this.g);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.r = value.x; this.b = value.y; this.g = value.z; }
    }
    public decimal3 rbb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal3(this.r, this.b, this.b);
    }
    public decimal3 rba
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal3(this.r, this.b, this.a);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.r = value.x; this.b = value.y; this.a = value.z; }
    }
    public decimal3 rar
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal3(this.r, this.a, this.r);
    }
    public decimal3 rag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal3(this.r, this.a, this.g);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.r = value.x; this.a = value.y; this.g = value.z; }
    }
    public decimal3 rab
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal3(this.r, this.a, this.b);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.r = value.x; this.a = value.y; this.b = value.z; }
    }
    public decimal3 raa
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal3(this.r, this.a, this.a);
    }
    public decimal3 grr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal3(this.g, this.r, this.r);
    }
    public decimal3 grg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal3(this.g, this.r, this.g);
    }
    public decimal3 grb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal3(this.g, this.r, this.b);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.g = value.x; this.r = value.y; this.b = value.z; }
    }
    public decimal3 gra
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal3(this.g, this.r, this.a);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.g = value.x; this.r = value.y; this.a = value.z; }
    }
    public decimal3 ggr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal3(this.g, this.g, this.r);
    }
    public decimal3 ggg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal3(this.g, this.g, this.g);
    }
    public decimal3 ggb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal3(this.g, this.g, this.b);
    }
    public decimal3 gga
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal3(this.g, this.g, this.a);
    }
    public decimal3 gbr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal3(this.g, this.b, this.r);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.g = value.x; this.b = value.y; this.r = value.z; }
    }
    public decimal3 gbg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal3(this.g, this.b, this.g);
    }
    public decimal3 gbb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal3(this.g, this.b, this.b);
    }
    public decimal3 gba
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal3(this.g, this.b, this.a);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.g = value.x; this.b = value.y; this.a = value.z; }
    }
    public decimal3 gar
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal3(this.g, this.a, this.r);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.g = value.x; this.a = value.y; this.r = value.z; }
    }
    public decimal3 gag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal3(this.g, this.a, this.g);
    }
    public decimal3 gab
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal3(this.g, this.a, this.b);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.g = value.x; this.a = value.y; this.b = value.z; }
    }
    public decimal3 gaa
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal3(this.g, this.a, this.a);
    }
    public decimal3 brr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal3(this.b, this.r, this.r);
    }
    public decimal3 brg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal3(this.b, this.r, this.g);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.b = value.x; this.r = value.y; this.g = value.z; }
    }
    public decimal3 brb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal3(this.b, this.r, this.b);
    }
    public decimal3 bra
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal3(this.b, this.r, this.a);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.b = value.x; this.r = value.y; this.a = value.z; }
    }
    public decimal3 bgr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal3(this.b, this.g, this.r);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.b = value.x; this.g = value.y; this.r = value.z; }
    }
    public decimal3 bgg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal3(this.b, this.g, this.g);
    }
    public decimal3 bgb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal3(this.b, this.g, this.b);
    }
    public decimal3 bga
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal3(this.b, this.g, this.a);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.b = value.x; this.g = value.y; this.a = value.z; }
    }
    public decimal3 bbr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal3(this.b, this.b, this.r);
    }
    public decimal3 bbg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal3(this.b, this.b, this.g);
    }
    public decimal3 bbb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal3(this.b, this.b, this.b);
    }
    public decimal3 bba
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal3(this.b, this.b, this.a);
    }
    public decimal3 bar
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal3(this.b, this.a, this.r);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.b = value.x; this.a = value.y; this.r = value.z; }
    }
    public decimal3 bag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal3(this.b, this.a, this.g);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.b = value.x; this.a = value.y; this.g = value.z; }
    }
    public decimal3 bab
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal3(this.b, this.a, this.b);
    }
    public decimal3 baa
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal3(this.b, this.a, this.a);
    }
    public decimal3 arr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal3(this.a, this.r, this.r);
    }
    public decimal3 arg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal3(this.a, this.r, this.g);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.a = value.x; this.r = value.y; this.g = value.z; }
    }
    public decimal3 arb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal3(this.a, this.r, this.b);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.a = value.x; this.r = value.y; this.b = value.z; }
    }
    public decimal3 ara
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal3(this.a, this.r, this.a);
    }
    public decimal3 agr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal3(this.a, this.g, this.r);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.a = value.x; this.g = value.y; this.r = value.z; }
    }
    public decimal3 agg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal3(this.a, this.g, this.g);
    }
    public decimal3 agb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal3(this.a, this.g, this.b);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.a = value.x; this.g = value.y; this.b = value.z; }
    }
    public decimal3 aga
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal3(this.a, this.g, this.a);
    }
    public decimal3 abr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal3(this.a, this.b, this.r);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.a = value.x; this.b = value.y; this.r = value.z; }
    }
    public decimal3 abg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal3(this.a, this.b, this.g);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.a = value.x; this.b = value.y; this.g = value.z; }
    }
    public decimal3 abb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal3(this.a, this.b, this.b);
    }
    public decimal3 aba
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal3(this.a, this.b, this.a);
    }
    public decimal3 aar
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal3(this.a, this.a, this.r);
    }
    public decimal3 aag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal3(this.a, this.a, this.g);
    }
    public decimal3 aab
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal3(this.a, this.a, this.b);
    }
    public decimal3 aaa
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal3(this.a, this.a, this.a);
    }
    public decimal4 xxxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.x, this.x, this.x, this.x);
    }
    public decimal4 xxxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.x, this.x, this.x, this.y);
    }
    public decimal4 xxxz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.x, this.x, this.x, this.z);
    }
    public decimal4 xxxw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.x, this.x, this.x, this.w);
    }
    public decimal4 xxyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.x, this.x, this.y, this.x);
    }
    public decimal4 xxyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.x, this.x, this.y, this.y);
    }
    public decimal4 xxyz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.x, this.x, this.y, this.z);
    }
    public decimal4 xxyw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.x, this.x, this.y, this.w);
    }
    public decimal4 xxzx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.x, this.x, this.z, this.x);
    }
    public decimal4 xxzy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.x, this.x, this.z, this.y);
    }
    public decimal4 xxzz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.x, this.x, this.z, this.z);
    }
    public decimal4 xxzw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.x, this.x, this.z, this.w);
    }
    public decimal4 xxwx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.x, this.x, this.w, this.x);
    }
    public decimal4 xxwy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.x, this.x, this.w, this.y);
    }
    public decimal4 xxwz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.x, this.x, this.w, this.z);
    }
    public decimal4 xxww
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.x, this.x, this.w, this.w);
    }
    public decimal4 xyxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.x, this.y, this.x, this.x);
    }
    public decimal4 xyxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.x, this.y, this.x, this.y);
    }
    public decimal4 xyxz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.x, this.y, this.x, this.z);
    }
    public decimal4 xyxw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.x, this.y, this.x, this.w);
    }
    public decimal4 xyyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.x, this.y, this.y, this.x);
    }
    public decimal4 xyyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.x, this.y, this.y, this.y);
    }
    public decimal4 xyyz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.x, this.y, this.y, this.z);
    }
    public decimal4 xyyw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.x, this.y, this.y, this.w);
    }
    public decimal4 xyzx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.x, this.y, this.z, this.x);
    }
    public decimal4 xyzy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.x, this.y, this.z, this.y);
    }
    public decimal4 xyzz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.x, this.y, this.z, this.z);
    }
    public decimal4 xyzw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.x, this.y, this.z, this.w);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.x = value.x; this.y = value.y; this.z = value.z; this.w = value.w; }
    }
    public decimal4 xywx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.x, this.y, this.w, this.x);
    }
    public decimal4 xywy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.x, this.y, this.w, this.y);
    }
    public decimal4 xywz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.x, this.y, this.w, this.z);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.x = value.x; this.y = value.y; this.w = value.z; this.z = value.w; }
    }
    public decimal4 xyww
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.x, this.y, this.w, this.w);
    }
    public decimal4 xzxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.x, this.z, this.x, this.x);
    }
    public decimal4 xzxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.x, this.z, this.x, this.y);
    }
    public decimal4 xzxz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.x, this.z, this.x, this.z);
    }
    public decimal4 xzxw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.x, this.z, this.x, this.w);
    }
    public decimal4 xzyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.x, this.z, this.y, this.x);
    }
    public decimal4 xzyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.x, this.z, this.y, this.y);
    }
    public decimal4 xzyz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.x, this.z, this.y, this.z);
    }
    public decimal4 xzyw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.x, this.z, this.y, this.w);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.x = value.x; this.z = value.y; this.y = value.z; this.w = value.w; }
    }
    public decimal4 xzzx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.x, this.z, this.z, this.x);
    }
    public decimal4 xzzy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.x, this.z, this.z, this.y);
    }
    public decimal4 xzzz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.x, this.z, this.z, this.z);
    }
    public decimal4 xzzw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.x, this.z, this.z, this.w);
    }
    public decimal4 xzwx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.x, this.z, this.w, this.x);
    }
    public decimal4 xzwy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.x, this.z, this.w, this.y);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.x = value.x; this.z = value.y; this.w = value.z; this.y = value.w; }
    }
    public decimal4 xzwz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.x, this.z, this.w, this.z);
    }
    public decimal4 xzww
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.x, this.z, this.w, this.w);
    }
    public decimal4 xwxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.x, this.w, this.x, this.x);
    }
    public decimal4 xwxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.x, this.w, this.x, this.y);
    }
    public decimal4 xwxz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.x, this.w, this.x, this.z);
    }
    public decimal4 xwxw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.x, this.w, this.x, this.w);
    }
    public decimal4 xwyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.x, this.w, this.y, this.x);
    }
    public decimal4 xwyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.x, this.w, this.y, this.y);
    }
    public decimal4 xwyz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.x, this.w, this.y, this.z);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.x = value.x; this.w = value.y; this.y = value.z; this.z = value.w; }
    }
    public decimal4 xwyw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.x, this.w, this.y, this.w);
    }
    public decimal4 xwzx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.x, this.w, this.z, this.x);
    }
    public decimal4 xwzy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.x, this.w, this.z, this.y);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.x = value.x; this.w = value.y; this.z = value.z; this.y = value.w; }
    }
    public decimal4 xwzz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.x, this.w, this.z, this.z);
    }
    public decimal4 xwzw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.x, this.w, this.z, this.w);
    }
    public decimal4 xwwx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.x, this.w, this.w, this.x);
    }
    public decimal4 xwwy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.x, this.w, this.w, this.y);
    }
    public decimal4 xwwz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.x, this.w, this.w, this.z);
    }
    public decimal4 xwww
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.x, this.w, this.w, this.w);
    }
    public decimal4 yxxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.y, this.x, this.x, this.x);
    }
    public decimal4 yxxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.y, this.x, this.x, this.y);
    }
    public decimal4 yxxz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.y, this.x, this.x, this.z);
    }
    public decimal4 yxxw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.y, this.x, this.x, this.w);
    }
    public decimal4 yxyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.y, this.x, this.y, this.x);
    }
    public decimal4 yxyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.y, this.x, this.y, this.y);
    }
    public decimal4 yxyz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.y, this.x, this.y, this.z);
    }
    public decimal4 yxyw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.y, this.x, this.y, this.w);
    }
    public decimal4 yxzx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.y, this.x, this.z, this.x);
    }
    public decimal4 yxzy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.y, this.x, this.z, this.y);
    }
    public decimal4 yxzz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.y, this.x, this.z, this.z);
    }
    public decimal4 yxzw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.y, this.x, this.z, this.w);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.y = value.x; this.x = value.y; this.z = value.z; this.w = value.w; }
    }
    public decimal4 yxwx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.y, this.x, this.w, this.x);
    }
    public decimal4 yxwy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.y, this.x, this.w, this.y);
    }
    public decimal4 yxwz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.y, this.x, this.w, this.z);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.y = value.x; this.x = value.y; this.w = value.z; this.z = value.w; }
    }
    public decimal4 yxww
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.y, this.x, this.w, this.w);
    }
    public decimal4 yyxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.y, this.y, this.x, this.x);
    }
    public decimal4 yyxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.y, this.y, this.x, this.y);
    }
    public decimal4 yyxz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.y, this.y, this.x, this.z);
    }
    public decimal4 yyxw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.y, this.y, this.x, this.w);
    }
    public decimal4 yyyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.y, this.y, this.y, this.x);
    }
    public decimal4 yyyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.y, this.y, this.y, this.y);
    }
    public decimal4 yyyz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.y, this.y, this.y, this.z);
    }
    public decimal4 yyyw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.y, this.y, this.y, this.w);
    }
    public decimal4 yyzx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.y, this.y, this.z, this.x);
    }
    public decimal4 yyzy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.y, this.y, this.z, this.y);
    }
    public decimal4 yyzz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.y, this.y, this.z, this.z);
    }
    public decimal4 yyzw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.y, this.y, this.z, this.w);
    }
    public decimal4 yywx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.y, this.y, this.w, this.x);
    }
    public decimal4 yywy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.y, this.y, this.w, this.y);
    }
    public decimal4 yywz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.y, this.y, this.w, this.z);
    }
    public decimal4 yyww
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.y, this.y, this.w, this.w);
    }
    public decimal4 yzxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.y, this.z, this.x, this.x);
    }
    public decimal4 yzxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.y, this.z, this.x, this.y);
    }
    public decimal4 yzxz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.y, this.z, this.x, this.z);
    }
    public decimal4 yzxw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.y, this.z, this.x, this.w);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.y = value.x; this.z = value.y; this.x = value.z; this.w = value.w; }
    }
    public decimal4 yzyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.y, this.z, this.y, this.x);
    }
    public decimal4 yzyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.y, this.z, this.y, this.y);
    }
    public decimal4 yzyz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.y, this.z, this.y, this.z);
    }
    public decimal4 yzyw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.y, this.z, this.y, this.w);
    }
    public decimal4 yzzx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.y, this.z, this.z, this.x);
    }
    public decimal4 yzzy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.y, this.z, this.z, this.y);
    }
    public decimal4 yzzz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.y, this.z, this.z, this.z);
    }
    public decimal4 yzzw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.y, this.z, this.z, this.w);
    }
    public decimal4 yzwx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.y, this.z, this.w, this.x);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.y = value.x; this.z = value.y; this.w = value.z; this.x = value.w; }
    }
    public decimal4 yzwy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.y, this.z, this.w, this.y);
    }
    public decimal4 yzwz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.y, this.z, this.w, this.z);
    }
    public decimal4 yzww
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.y, this.z, this.w, this.w);
    }
    public decimal4 ywxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.y, this.w, this.x, this.x);
    }
    public decimal4 ywxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.y, this.w, this.x, this.y);
    }
    public decimal4 ywxz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.y, this.w, this.x, this.z);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.y = value.x; this.w = value.y; this.x = value.z; this.z = value.w; }
    }
    public decimal4 ywxw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.y, this.w, this.x, this.w);
    }
    public decimal4 ywyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.y, this.w, this.y, this.x);
    }
    public decimal4 ywyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.y, this.w, this.y, this.y);
    }
    public decimal4 ywyz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.y, this.w, this.y, this.z);
    }
    public decimal4 ywyw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.y, this.w, this.y, this.w);
    }
    public decimal4 ywzx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.y, this.w, this.z, this.x);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.y = value.x; this.w = value.y; this.z = value.z; this.x = value.w; }
    }
    public decimal4 ywzy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.y, this.w, this.z, this.y);
    }
    public decimal4 ywzz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.y, this.w, this.z, this.z);
    }
    public decimal4 ywzw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.y, this.w, this.z, this.w);
    }
    public decimal4 ywwx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.y, this.w, this.w, this.x);
    }
    public decimal4 ywwy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.y, this.w, this.w, this.y);
    }
    public decimal4 ywwz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.y, this.w, this.w, this.z);
    }
    public decimal4 ywww
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.y, this.w, this.w, this.w);
    }
    public decimal4 zxxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.z, this.x, this.x, this.x);
    }
    public decimal4 zxxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.z, this.x, this.x, this.y);
    }
    public decimal4 zxxz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.z, this.x, this.x, this.z);
    }
    public decimal4 zxxw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.z, this.x, this.x, this.w);
    }
    public decimal4 zxyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.z, this.x, this.y, this.x);
    }
    public decimal4 zxyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.z, this.x, this.y, this.y);
    }
    public decimal4 zxyz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.z, this.x, this.y, this.z);
    }
    public decimal4 zxyw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.z, this.x, this.y, this.w);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.z = value.x; this.x = value.y; this.y = value.z; this.w = value.w; }
    }
    public decimal4 zxzx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.z, this.x, this.z, this.x);
    }
    public decimal4 zxzy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.z, this.x, this.z, this.y);
    }
    public decimal4 zxzz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.z, this.x, this.z, this.z);
    }
    public decimal4 zxzw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.z, this.x, this.z, this.w);
    }
    public decimal4 zxwx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.z, this.x, this.w, this.x);
    }
    public decimal4 zxwy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.z, this.x, this.w, this.y);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.z = value.x; this.x = value.y; this.w = value.z; this.y = value.w; }
    }
    public decimal4 zxwz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.z, this.x, this.w, this.z);
    }
    public decimal4 zxww
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.z, this.x, this.w, this.w);
    }
    public decimal4 zyxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.z, this.y, this.x, this.x);
    }
    public decimal4 zyxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.z, this.y, this.x, this.y);
    }
    public decimal4 zyxz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.z, this.y, this.x, this.z);
    }
    public decimal4 zyxw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.z, this.y, this.x, this.w);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.z = value.x; this.y = value.y; this.x = value.z; this.w = value.w; }
    }
    public decimal4 zyyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.z, this.y, this.y, this.x);
    }
    public decimal4 zyyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.z, this.y, this.y, this.y);
    }
    public decimal4 zyyz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.z, this.y, this.y, this.z);
    }
    public decimal4 zyyw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.z, this.y, this.y, this.w);
    }
    public decimal4 zyzx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.z, this.y, this.z, this.x);
    }
    public decimal4 zyzy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.z, this.y, this.z, this.y);
    }
    public decimal4 zyzz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.z, this.y, this.z, this.z);
    }
    public decimal4 zyzw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.z, this.y, this.z, this.w);
    }
    public decimal4 zywx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.z, this.y, this.w, this.x);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.z = value.x; this.y = value.y; this.w = value.z; this.x = value.w; }
    }
    public decimal4 zywy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.z, this.y, this.w, this.y);
    }
    public decimal4 zywz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.z, this.y, this.w, this.z);
    }
    public decimal4 zyww
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.z, this.y, this.w, this.w);
    }
    public decimal4 zzxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.z, this.z, this.x, this.x);
    }
    public decimal4 zzxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.z, this.z, this.x, this.y);
    }
    public decimal4 zzxz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.z, this.z, this.x, this.z);
    }
    public decimal4 zzxw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.z, this.z, this.x, this.w);
    }
    public decimal4 zzyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.z, this.z, this.y, this.x);
    }
    public decimal4 zzyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.z, this.z, this.y, this.y);
    }
    public decimal4 zzyz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.z, this.z, this.y, this.z);
    }
    public decimal4 zzyw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.z, this.z, this.y, this.w);
    }
    public decimal4 zzzx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.z, this.z, this.z, this.x);
    }
    public decimal4 zzzy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.z, this.z, this.z, this.y);
    }
    public decimal4 zzzz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.z, this.z, this.z, this.z);
    }
    public decimal4 zzzw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.z, this.z, this.z, this.w);
    }
    public decimal4 zzwx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.z, this.z, this.w, this.x);
    }
    public decimal4 zzwy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.z, this.z, this.w, this.y);
    }
    public decimal4 zzwz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.z, this.z, this.w, this.z);
    }
    public decimal4 zzww
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.z, this.z, this.w, this.w);
    }
    public decimal4 zwxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.z, this.w, this.x, this.x);
    }
    public decimal4 zwxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.z, this.w, this.x, this.y);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.z = value.x; this.w = value.y; this.x = value.z; this.y = value.w; }
    }
    public decimal4 zwxz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.z, this.w, this.x, this.z);
    }
    public decimal4 zwxw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.z, this.w, this.x, this.w);
    }
    public decimal4 zwyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.z, this.w, this.y, this.x);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.z = value.x; this.w = value.y; this.y = value.z; this.x = value.w; }
    }
    public decimal4 zwyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.z, this.w, this.y, this.y);
    }
    public decimal4 zwyz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.z, this.w, this.y, this.z);
    }
    public decimal4 zwyw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.z, this.w, this.y, this.w);
    }
    public decimal4 zwzx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.z, this.w, this.z, this.x);
    }
    public decimal4 zwzy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.z, this.w, this.z, this.y);
    }
    public decimal4 zwzz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.z, this.w, this.z, this.z);
    }
    public decimal4 zwzw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.z, this.w, this.z, this.w);
    }
    public decimal4 zwwx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.z, this.w, this.w, this.x);
    }
    public decimal4 zwwy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.z, this.w, this.w, this.y);
    }
    public decimal4 zwwz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.z, this.w, this.w, this.z);
    }
    public decimal4 zwww
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.z, this.w, this.w, this.w);
    }
    public decimal4 wxxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.w, this.x, this.x, this.x);
    }
    public decimal4 wxxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.w, this.x, this.x, this.y);
    }
    public decimal4 wxxz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.w, this.x, this.x, this.z);
    }
    public decimal4 wxxw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.w, this.x, this.x, this.w);
    }
    public decimal4 wxyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.w, this.x, this.y, this.x);
    }
    public decimal4 wxyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.w, this.x, this.y, this.y);
    }
    public decimal4 wxyz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.w, this.x, this.y, this.z);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.w = value.x; this.x = value.y; this.y = value.z; this.z = value.w; }
    }
    public decimal4 wxyw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.w, this.x, this.y, this.w);
    }
    public decimal4 wxzx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.w, this.x, this.z, this.x);
    }
    public decimal4 wxzy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.w, this.x, this.z, this.y);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.w = value.x; this.x = value.y; this.z = value.z; this.y = value.w; }
    }
    public decimal4 wxzz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.w, this.x, this.z, this.z);
    }
    public decimal4 wxzw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.w, this.x, this.z, this.w);
    }
    public decimal4 wxwx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.w, this.x, this.w, this.x);
    }
    public decimal4 wxwy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.w, this.x, this.w, this.y);
    }
    public decimal4 wxwz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.w, this.x, this.w, this.z);
    }
    public decimal4 wxww
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.w, this.x, this.w, this.w);
    }
    public decimal4 wyxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.w, this.y, this.x, this.x);
    }
    public decimal4 wyxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.w, this.y, this.x, this.y);
    }
    public decimal4 wyxz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.w, this.y, this.x, this.z);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.w = value.x; this.y = value.y; this.x = value.z; this.z = value.w; }
    }
    public decimal4 wyxw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.w, this.y, this.x, this.w);
    }
    public decimal4 wyyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.w, this.y, this.y, this.x);
    }
    public decimal4 wyyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.w, this.y, this.y, this.y);
    }
    public decimal4 wyyz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.w, this.y, this.y, this.z);
    }
    public decimal4 wyyw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.w, this.y, this.y, this.w);
    }
    public decimal4 wyzx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.w, this.y, this.z, this.x);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.w = value.x; this.y = value.y; this.z = value.z; this.x = value.w; }
    }
    public decimal4 wyzy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.w, this.y, this.z, this.y);
    }
    public decimal4 wyzz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.w, this.y, this.z, this.z);
    }
    public decimal4 wyzw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.w, this.y, this.z, this.w);
    }
    public decimal4 wywx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.w, this.y, this.w, this.x);
    }
    public decimal4 wywy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.w, this.y, this.w, this.y);
    }
    public decimal4 wywz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.w, this.y, this.w, this.z);
    }
    public decimal4 wyww
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.w, this.y, this.w, this.w);
    }
    public decimal4 wzxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.w, this.z, this.x, this.x);
    }
    public decimal4 wzxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.w, this.z, this.x, this.y);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.w = value.x; this.z = value.y; this.x = value.z; this.y = value.w; }
    }
    public decimal4 wzxz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.w, this.z, this.x, this.z);
    }
    public decimal4 wzxw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.w, this.z, this.x, this.w);
    }
    public decimal4 wzyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.w, this.z, this.y, this.x);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.w = value.x; this.z = value.y; this.y = value.z; this.x = value.w; }
    }
    public decimal4 wzyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.w, this.z, this.y, this.y);
    }
    public decimal4 wzyz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.w, this.z, this.y, this.z);
    }
    public decimal4 wzyw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.w, this.z, this.y, this.w);
    }
    public decimal4 wzzx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.w, this.z, this.z, this.x);
    }
    public decimal4 wzzy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.w, this.z, this.z, this.y);
    }
    public decimal4 wzzz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.w, this.z, this.z, this.z);
    }
    public decimal4 wzzw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.w, this.z, this.z, this.w);
    }
    public decimal4 wzwx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.w, this.z, this.w, this.x);
    }
    public decimal4 wzwy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.w, this.z, this.w, this.y);
    }
    public decimal4 wzwz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.w, this.z, this.w, this.z);
    }
    public decimal4 wzww
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.w, this.z, this.w, this.w);
    }
    public decimal4 wwxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.w, this.w, this.x, this.x);
    }
    public decimal4 wwxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.w, this.w, this.x, this.y);
    }
    public decimal4 wwxz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.w, this.w, this.x, this.z);
    }
    public decimal4 wwxw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.w, this.w, this.x, this.w);
    }
    public decimal4 wwyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.w, this.w, this.y, this.x);
    }
    public decimal4 wwyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.w, this.w, this.y, this.y);
    }
    public decimal4 wwyz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.w, this.w, this.y, this.z);
    }
    public decimal4 wwyw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.w, this.w, this.y, this.w);
    }
    public decimal4 wwzx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.w, this.w, this.z, this.x);
    }
    public decimal4 wwzy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.w, this.w, this.z, this.y);
    }
    public decimal4 wwzz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.w, this.w, this.z, this.z);
    }
    public decimal4 wwzw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.w, this.w, this.z, this.w);
    }
    public decimal4 wwwx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.w, this.w, this.w, this.x);
    }
    public decimal4 wwwy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.w, this.w, this.w, this.y);
    }
    public decimal4 wwwz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.w, this.w, this.w, this.z);
    }
    public decimal4 wwww
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.w, this.w, this.w, this.w);
    }
    public decimal4 rrrr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.r, this.r, this.r, this.r);
    }
    public decimal4 rrrg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.r, this.r, this.r, this.g);
    }
    public decimal4 rrrb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.r, this.r, this.r, this.b);
    }
    public decimal4 rrra
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.r, this.r, this.r, this.a);
    }
    public decimal4 rrgr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.r, this.r, this.g, this.r);
    }
    public decimal4 rrgg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.r, this.r, this.g, this.g);
    }
    public decimal4 rrgb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.r, this.r, this.g, this.b);
    }
    public decimal4 rrga
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.r, this.r, this.g, this.a);
    }
    public decimal4 rrbr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.r, this.r, this.b, this.r);
    }
    public decimal4 rrbg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.r, this.r, this.b, this.g);
    }
    public decimal4 rrbb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.r, this.r, this.b, this.b);
    }
    public decimal4 rrba
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.r, this.r, this.b, this.a);
    }
    public decimal4 rrar
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.r, this.r, this.a, this.r);
    }
    public decimal4 rrag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.r, this.r, this.a, this.g);
    }
    public decimal4 rrab
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.r, this.r, this.a, this.b);
    }
    public decimal4 rraa
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.r, this.r, this.a, this.a);
    }
    public decimal4 rgrr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.r, this.g, this.r, this.r);
    }
    public decimal4 rgrg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.r, this.g, this.r, this.g);
    }
    public decimal4 rgrb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.r, this.g, this.r, this.b);
    }
    public decimal4 rgra
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.r, this.g, this.r, this.a);
    }
    public decimal4 rggr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.r, this.g, this.g, this.r);
    }
    public decimal4 rggg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.r, this.g, this.g, this.g);
    }
    public decimal4 rggb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.r, this.g, this.g, this.b);
    }
    public decimal4 rgga
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.r, this.g, this.g, this.a);
    }
    public decimal4 rgbr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.r, this.g, this.b, this.r);
    }
    public decimal4 rgbg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.r, this.g, this.b, this.g);
    }
    public decimal4 rgbb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.r, this.g, this.b, this.b);
    }
    public decimal4 rgba
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.r, this.g, this.b, this.a);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.r = value.x; this.g = value.y; this.b = value.z; this.a = value.w; }
    }
    public decimal4 rgar
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.r, this.g, this.a, this.r);
    }
    public decimal4 rgag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.r, this.g, this.a, this.g);
    }
    public decimal4 rgab
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.r, this.g, this.a, this.b);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.r = value.x; this.g = value.y; this.a = value.z; this.b = value.w; }
    }
    public decimal4 rgaa
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.r, this.g, this.a, this.a);
    }
    public decimal4 rbrr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.r, this.b, this.r, this.r);
    }
    public decimal4 rbrg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.r, this.b, this.r, this.g);
    }
    public decimal4 rbrb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.r, this.b, this.r, this.b);
    }
    public decimal4 rbra
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.r, this.b, this.r, this.a);
    }
    public decimal4 rbgr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.r, this.b, this.g, this.r);
    }
    public decimal4 rbgg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.r, this.b, this.g, this.g);
    }
    public decimal4 rbgb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.r, this.b, this.g, this.b);
    }
    public decimal4 rbga
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.r, this.b, this.g, this.a);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.r = value.x; this.b = value.y; this.g = value.z; this.a = value.w; }
    }
    public decimal4 rbbr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.r, this.b, this.b, this.r);
    }
    public decimal4 rbbg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.r, this.b, this.b, this.g);
    }
    public decimal4 rbbb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.r, this.b, this.b, this.b);
    }
    public decimal4 rbba
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.r, this.b, this.b, this.a);
    }
    public decimal4 rbar
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.r, this.b, this.a, this.r);
    }
    public decimal4 rbag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.r, this.b, this.a, this.g);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.r = value.x; this.b = value.y; this.a = value.z; this.g = value.w; }
    }
    public decimal4 rbab
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.r, this.b, this.a, this.b);
    }
    public decimal4 rbaa
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.r, this.b, this.a, this.a);
    }
    public decimal4 rarr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.r, this.a, this.r, this.r);
    }
    public decimal4 rarg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.r, this.a, this.r, this.g);
    }
    public decimal4 rarb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.r, this.a, this.r, this.b);
    }
    public decimal4 rara
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.r, this.a, this.r, this.a);
    }
    public decimal4 ragr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.r, this.a, this.g, this.r);
    }
    public decimal4 ragg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.r, this.a, this.g, this.g);
    }
    public decimal4 ragb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.r, this.a, this.g, this.b);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.r = value.x; this.a = value.y; this.g = value.z; this.b = value.w; }
    }
    public decimal4 raga
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.r, this.a, this.g, this.a);
    }
    public decimal4 rabr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.r, this.a, this.b, this.r);
    }
    public decimal4 rabg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.r, this.a, this.b, this.g);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.r = value.x; this.a = value.y; this.b = value.z; this.g = value.w; }
    }
    public decimal4 rabb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.r, this.a, this.b, this.b);
    }
    public decimal4 raba
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.r, this.a, this.b, this.a);
    }
    public decimal4 raar
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.r, this.a, this.a, this.r);
    }
    public decimal4 raag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.r, this.a, this.a, this.g);
    }
    public decimal4 raab
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.r, this.a, this.a, this.b);
    }
    public decimal4 raaa
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.r, this.a, this.a, this.a);
    }
    public decimal4 grrr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.g, this.r, this.r, this.r);
    }
    public decimal4 grrg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.g, this.r, this.r, this.g);
    }
    public decimal4 grrb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.g, this.r, this.r, this.b);
    }
    public decimal4 grra
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.g, this.r, this.r, this.a);
    }
    public decimal4 grgr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.g, this.r, this.g, this.r);
    }
    public decimal4 grgg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.g, this.r, this.g, this.g);
    }
    public decimal4 grgb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.g, this.r, this.g, this.b);
    }
    public decimal4 grga
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.g, this.r, this.g, this.a);
    }
    public decimal4 grbr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.g, this.r, this.b, this.r);
    }
    public decimal4 grbg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.g, this.r, this.b, this.g);
    }
    public decimal4 grbb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.g, this.r, this.b, this.b);
    }
    public decimal4 grba
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.g, this.r, this.b, this.a);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.g = value.x; this.r = value.y; this.b = value.z; this.a = value.w; }
    }
    public decimal4 grar
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.g, this.r, this.a, this.r);
    }
    public decimal4 grag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.g, this.r, this.a, this.g);
    }
    public decimal4 grab
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.g, this.r, this.a, this.b);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.g = value.x; this.r = value.y; this.a = value.z; this.b = value.w; }
    }
    public decimal4 graa
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.g, this.r, this.a, this.a);
    }
    public decimal4 ggrr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.g, this.g, this.r, this.r);
    }
    public decimal4 ggrg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.g, this.g, this.r, this.g);
    }
    public decimal4 ggrb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.g, this.g, this.r, this.b);
    }
    public decimal4 ggra
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.g, this.g, this.r, this.a);
    }
    public decimal4 gggr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.g, this.g, this.g, this.r);
    }
    public decimal4 gggg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.g, this.g, this.g, this.g);
    }
    public decimal4 gggb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.g, this.g, this.g, this.b);
    }
    public decimal4 ggga
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.g, this.g, this.g, this.a);
    }
    public decimal4 ggbr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.g, this.g, this.b, this.r);
    }
    public decimal4 ggbg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.g, this.g, this.b, this.g);
    }
    public decimal4 ggbb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.g, this.g, this.b, this.b);
    }
    public decimal4 ggba
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.g, this.g, this.b, this.a);
    }
    public decimal4 ggar
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.g, this.g, this.a, this.r);
    }
    public decimal4 ggag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.g, this.g, this.a, this.g);
    }
    public decimal4 ggab
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.g, this.g, this.a, this.b);
    }
    public decimal4 ggaa
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.g, this.g, this.a, this.a);
    }
    public decimal4 gbrr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.g, this.b, this.r, this.r);
    }
    public decimal4 gbrg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.g, this.b, this.r, this.g);
    }
    public decimal4 gbrb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.g, this.b, this.r, this.b);
    }
    public decimal4 gbra
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.g, this.b, this.r, this.a);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.g = value.x; this.b = value.y; this.r = value.z; this.a = value.w; }
    }
    public decimal4 gbgr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.g, this.b, this.g, this.r);
    }
    public decimal4 gbgg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.g, this.b, this.g, this.g);
    }
    public decimal4 gbgb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.g, this.b, this.g, this.b);
    }
    public decimal4 gbga
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.g, this.b, this.g, this.a);
    }
    public decimal4 gbbr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.g, this.b, this.b, this.r);
    }
    public decimal4 gbbg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.g, this.b, this.b, this.g);
    }
    public decimal4 gbbb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.g, this.b, this.b, this.b);
    }
    public decimal4 gbba
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.g, this.b, this.b, this.a);
    }
    public decimal4 gbar
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.g, this.b, this.a, this.r);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.g = value.x; this.b = value.y; this.a = value.z; this.r = value.w; }
    }
    public decimal4 gbag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.g, this.b, this.a, this.g);
    }
    public decimal4 gbab
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.g, this.b, this.a, this.b);
    }
    public decimal4 gbaa
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.g, this.b, this.a, this.a);
    }
    public decimal4 garr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.g, this.a, this.r, this.r);
    }
    public decimal4 garg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.g, this.a, this.r, this.g);
    }
    public decimal4 garb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.g, this.a, this.r, this.b);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.g = value.x; this.a = value.y; this.r = value.z; this.b = value.w; }
    }
    public decimal4 gara
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.g, this.a, this.r, this.a);
    }
    public decimal4 gagr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.g, this.a, this.g, this.r);
    }
    public decimal4 gagg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.g, this.a, this.g, this.g);
    }
    public decimal4 gagb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.g, this.a, this.g, this.b);
    }
    public decimal4 gaga
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.g, this.a, this.g, this.a);
    }
    public decimal4 gabr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.g, this.a, this.b, this.r);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.g = value.x; this.a = value.y; this.b = value.z; this.r = value.w; }
    }
    public decimal4 gabg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.g, this.a, this.b, this.g);
    }
    public decimal4 gabb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.g, this.a, this.b, this.b);
    }
    public decimal4 gaba
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.g, this.a, this.b, this.a);
    }
    public decimal4 gaar
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.g, this.a, this.a, this.r);
    }
    public decimal4 gaag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.g, this.a, this.a, this.g);
    }
    public decimal4 gaab
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.g, this.a, this.a, this.b);
    }
    public decimal4 gaaa
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.g, this.a, this.a, this.a);
    }
    public decimal4 brrr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.b, this.r, this.r, this.r);
    }
    public decimal4 brrg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.b, this.r, this.r, this.g);
    }
    public decimal4 brrb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.b, this.r, this.r, this.b);
    }
    public decimal4 brra
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.b, this.r, this.r, this.a);
    }
    public decimal4 brgr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.b, this.r, this.g, this.r);
    }
    public decimal4 brgg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.b, this.r, this.g, this.g);
    }
    public decimal4 brgb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.b, this.r, this.g, this.b);
    }
    public decimal4 brga
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.b, this.r, this.g, this.a);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.b = value.x; this.r = value.y; this.g = value.z; this.a = value.w; }
    }
    public decimal4 brbr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.b, this.r, this.b, this.r);
    }
    public decimal4 brbg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.b, this.r, this.b, this.g);
    }
    public decimal4 brbb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.b, this.r, this.b, this.b);
    }
    public decimal4 brba
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.b, this.r, this.b, this.a);
    }
    public decimal4 brar
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.b, this.r, this.a, this.r);
    }
    public decimal4 brag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.b, this.r, this.a, this.g);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.b = value.x; this.r = value.y; this.a = value.z; this.g = value.w; }
    }
    public decimal4 brab
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.b, this.r, this.a, this.b);
    }
    public decimal4 braa
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.b, this.r, this.a, this.a);
    }
    public decimal4 bgrr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.b, this.g, this.r, this.r);
    }
    public decimal4 bgrg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.b, this.g, this.r, this.g);
    }
    public decimal4 bgrb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.b, this.g, this.r, this.b);
    }
    public decimal4 bgra
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.b, this.g, this.r, this.a);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.b = value.x; this.g = value.y; this.r = value.z; this.a = value.w; }
    }
    public decimal4 bggr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.b, this.g, this.g, this.r);
    }
    public decimal4 bggg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.b, this.g, this.g, this.g);
    }
    public decimal4 bggb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.b, this.g, this.g, this.b);
    }
    public decimal4 bgga
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.b, this.g, this.g, this.a);
    }
    public decimal4 bgbr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.b, this.g, this.b, this.r);
    }
    public decimal4 bgbg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.b, this.g, this.b, this.g);
    }
    public decimal4 bgbb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.b, this.g, this.b, this.b);
    }
    public decimal4 bgba
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.b, this.g, this.b, this.a);
    }
    public decimal4 bgar
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.b, this.g, this.a, this.r);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.b = value.x; this.g = value.y; this.a = value.z; this.r = value.w; }
    }
    public decimal4 bgag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.b, this.g, this.a, this.g);
    }
    public decimal4 bgab
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.b, this.g, this.a, this.b);
    }
    public decimal4 bgaa
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.b, this.g, this.a, this.a);
    }
    public decimal4 bbrr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.b, this.b, this.r, this.r);
    }
    public decimal4 bbrg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.b, this.b, this.r, this.g);
    }
    public decimal4 bbrb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.b, this.b, this.r, this.b);
    }
    public decimal4 bbra
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.b, this.b, this.r, this.a);
    }
    public decimal4 bbgr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.b, this.b, this.g, this.r);
    }
    public decimal4 bbgg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.b, this.b, this.g, this.g);
    }
    public decimal4 bbgb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.b, this.b, this.g, this.b);
    }
    public decimal4 bbga
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.b, this.b, this.g, this.a);
    }
    public decimal4 bbbr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.b, this.b, this.b, this.r);
    }
    public decimal4 bbbg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.b, this.b, this.b, this.g);
    }
    public decimal4 bbbb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.b, this.b, this.b, this.b);
    }
    public decimal4 bbba
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.b, this.b, this.b, this.a);
    }
    public decimal4 bbar
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.b, this.b, this.a, this.r);
    }
    public decimal4 bbag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.b, this.b, this.a, this.g);
    }
    public decimal4 bbab
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.b, this.b, this.a, this.b);
    }
    public decimal4 bbaa
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.b, this.b, this.a, this.a);
    }
    public decimal4 barr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.b, this.a, this.r, this.r);
    }
    public decimal4 barg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.b, this.a, this.r, this.g);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.b = value.x; this.a = value.y; this.r = value.z; this.g = value.w; }
    }
    public decimal4 barb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.b, this.a, this.r, this.b);
    }
    public decimal4 bara
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.b, this.a, this.r, this.a);
    }
    public decimal4 bagr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.b, this.a, this.g, this.r);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.b = value.x; this.a = value.y; this.g = value.z; this.r = value.w; }
    }
    public decimal4 bagg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.b, this.a, this.g, this.g);
    }
    public decimal4 bagb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.b, this.a, this.g, this.b);
    }
    public decimal4 baga
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.b, this.a, this.g, this.a);
    }
    public decimal4 babr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.b, this.a, this.b, this.r);
    }
    public decimal4 babg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.b, this.a, this.b, this.g);
    }
    public decimal4 babb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.b, this.a, this.b, this.b);
    }
    public decimal4 baba
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.b, this.a, this.b, this.a);
    }
    public decimal4 baar
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.b, this.a, this.a, this.r);
    }
    public decimal4 baag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.b, this.a, this.a, this.g);
    }
    public decimal4 baab
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.b, this.a, this.a, this.b);
    }
    public decimal4 baaa
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.b, this.a, this.a, this.a);
    }
    public decimal4 arrr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.a, this.r, this.r, this.r);
    }
    public decimal4 arrg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.a, this.r, this.r, this.g);
    }
    public decimal4 arrb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.a, this.r, this.r, this.b);
    }
    public decimal4 arra
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.a, this.r, this.r, this.a);
    }
    public decimal4 argr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.a, this.r, this.g, this.r);
    }
    public decimal4 argg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.a, this.r, this.g, this.g);
    }
    public decimal4 argb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.a, this.r, this.g, this.b);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.a = value.x; this.r = value.y; this.g = value.z; this.b = value.w; }
    }
    public decimal4 arga
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.a, this.r, this.g, this.a);
    }
    public decimal4 arbr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.a, this.r, this.b, this.r);
    }
    public decimal4 arbg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.a, this.r, this.b, this.g);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.a = value.x; this.r = value.y; this.b = value.z; this.g = value.w; }
    }
    public decimal4 arbb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.a, this.r, this.b, this.b);
    }
    public decimal4 arba
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.a, this.r, this.b, this.a);
    }
    public decimal4 arar
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.a, this.r, this.a, this.r);
    }
    public decimal4 arag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.a, this.r, this.a, this.g);
    }
    public decimal4 arab
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.a, this.r, this.a, this.b);
    }
    public decimal4 araa
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.a, this.r, this.a, this.a);
    }
    public decimal4 agrr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.a, this.g, this.r, this.r);
    }
    public decimal4 agrg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.a, this.g, this.r, this.g);
    }
    public decimal4 agrb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.a, this.g, this.r, this.b);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.a = value.x; this.g = value.y; this.r = value.z; this.b = value.w; }
    }
    public decimal4 agra
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.a, this.g, this.r, this.a);
    }
    public decimal4 aggr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.a, this.g, this.g, this.r);
    }
    public decimal4 aggg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.a, this.g, this.g, this.g);
    }
    public decimal4 aggb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.a, this.g, this.g, this.b);
    }
    public decimal4 agga
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.a, this.g, this.g, this.a);
    }
    public decimal4 agbr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.a, this.g, this.b, this.r);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.a = value.x; this.g = value.y; this.b = value.z; this.r = value.w; }
    }
    public decimal4 agbg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.a, this.g, this.b, this.g);
    }
    public decimal4 agbb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.a, this.g, this.b, this.b);
    }
    public decimal4 agba
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.a, this.g, this.b, this.a);
    }
    public decimal4 agar
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.a, this.g, this.a, this.r);
    }
    public decimal4 agag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.a, this.g, this.a, this.g);
    }
    public decimal4 agab
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.a, this.g, this.a, this.b);
    }
    public decimal4 agaa
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.a, this.g, this.a, this.a);
    }
    public decimal4 abrr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.a, this.b, this.r, this.r);
    }
    public decimal4 abrg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.a, this.b, this.r, this.g);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.a = value.x; this.b = value.y; this.r = value.z; this.g = value.w; }
    }
    public decimal4 abrb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.a, this.b, this.r, this.b);
    }
    public decimal4 abra
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.a, this.b, this.r, this.a);
    }
    public decimal4 abgr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.a, this.b, this.g, this.r);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.a = value.x; this.b = value.y; this.g = value.z; this.r = value.w; }
    }
    public decimal4 abgg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.a, this.b, this.g, this.g);
    }
    public decimal4 abgb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.a, this.b, this.g, this.b);
    }
    public decimal4 abga
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.a, this.b, this.g, this.a);
    }
    public decimal4 abbr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.a, this.b, this.b, this.r);
    }
    public decimal4 abbg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.a, this.b, this.b, this.g);
    }
    public decimal4 abbb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.a, this.b, this.b, this.b);
    }
    public decimal4 abba
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.a, this.b, this.b, this.a);
    }
    public decimal4 abar
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.a, this.b, this.a, this.r);
    }
    public decimal4 abag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.a, this.b, this.a, this.g);
    }
    public decimal4 abab
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.a, this.b, this.a, this.b);
    }
    public decimal4 abaa
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.a, this.b, this.a, this.a);
    }
    public decimal4 aarr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.a, this.a, this.r, this.r);
    }
    public decimal4 aarg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.a, this.a, this.r, this.g);
    }
    public decimal4 aarb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.a, this.a, this.r, this.b);
    }
    public decimal4 aara
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.a, this.a, this.r, this.a);
    }
    public decimal4 aagr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.a, this.a, this.g, this.r);
    }
    public decimal4 aagg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.a, this.a, this.g, this.g);
    }
    public decimal4 aagb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.a, this.a, this.g, this.b);
    }
    public decimal4 aaga
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.a, this.a, this.g, this.a);
    }
    public decimal4 aabr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.a, this.a, this.b, this.r);
    }
    public decimal4 aabg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.a, this.a, this.b, this.g);
    }
    public decimal4 aabb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.a, this.a, this.b, this.b);
    }
    public decimal4 aaba
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.a, this.a, this.b, this.a);
    }
    public decimal4 aaar
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.a, this.a, this.a, this.r);
    }
    public decimal4 aaag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.a, this.a, this.a, this.g);
    }
    public decimal4 aaab
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.a, this.a, this.a, this.b);
    }
    public decimal4 aaaa
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal4(this.a, this.a, this.a, this.a);
    }


}
