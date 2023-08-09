using System;
using System.Numerics;
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.X86;
using System.Runtime.Intrinsics.Arm;
using System.Runtime.CompilerServices;

#nullable enable
#pragma warning disable CS8981

namespace CCluster.Mathematics;

public partial struct Half4 
{

    public Half2 xx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.x);
    }
    public Half2 xy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.y);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.x = value.x; this.y = value.y; }
    }
    public Half2 xz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.z);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.x = value.x; this.z = value.y; }
    }
    public Half2 xw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.w);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.x = value.x; this.w = value.y; }
    }
    public Half2 yx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.x);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.y = value.x; this.x = value.y; }
    }
    public Half2 yy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.y);
    }
    public Half2 yz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.z);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.y = value.x; this.z = value.y; }
    }
    public Half2 yw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.w);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.y = value.x; this.w = value.y; }
    }
    public Half2 zx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.x);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.z = value.x; this.x = value.y; }
    }
    public Half2 zy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.y);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.z = value.x; this.y = value.y; }
    }
    public Half2 zz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.z);
    }
    public Half2 zw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.w);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.z = value.x; this.w = value.y; }
    }
    public Half2 wx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.w, this.x);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.w = value.x; this.x = value.y; }
    }
    public Half2 wy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.w, this.y);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.w = value.x; this.y = value.y; }
    }
    public Half2 wz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.w, this.z);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.w = value.x; this.z = value.y; }
    }
    public Half2 ww
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.w, this.w);
    }
    public Half2 rr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.r);
    }
    public Half2 rg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.g);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.r = value.x; this.g = value.y; }
    }
    public Half2 rb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.b);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.r = value.x; this.b = value.y; }
    }
    public Half2 ra
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.a);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.r = value.x; this.a = value.y; }
    }
    public Half2 gr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.r);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.g = value.x; this.r = value.y; }
    }
    public Half2 gg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.g);
    }
    public Half2 gb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.b);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.g = value.x; this.b = value.y; }
    }
    public Half2 ga
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.a);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.g = value.x; this.a = value.y; }
    }
    public Half2 br
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.r);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.b = value.x; this.r = value.y; }
    }
    public Half2 bg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.g);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.b = value.x; this.g = value.y; }
    }
    public Half2 bb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.b);
    }
    public Half2 ba
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.a);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.b = value.x; this.a = value.y; }
    }
    public Half2 ar
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.a, this.r);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.a = value.x; this.r = value.y; }
    }
    public Half2 ag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.a, this.g);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.a = value.x; this.g = value.y; }
    }
    public Half2 ab
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.a, this.b);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.a = value.x; this.b = value.y; }
    }
    public Half2 aa
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.a, this.a);
    }
    public Half3 xxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.x, this.x);
    }
    public Half3 xxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.x, this.y);
    }
    public Half3 xxz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.x, this.z);
    }
    public Half3 xxw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.x, this.w);
    }
    public Half3 xyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.y, this.x);
    }
    public Half3 xyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.y, this.y);
    }
    public Half3 xyz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.y, this.z);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.x = value.x; this.y = value.y; this.z = value.z; }
    }
    public Half3 xyw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.y, this.w);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.x = value.x; this.y = value.y; this.w = value.z; }
    }
    public Half3 xzx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.z, this.x);
    }
    public Half3 xzy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.z, this.y);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.x = value.x; this.z = value.y; this.y = value.z; }
    }
    public Half3 xzz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.z, this.z);
    }
    public Half3 xzw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.z, this.w);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.x = value.x; this.z = value.y; this.w = value.z; }
    }
    public Half3 xwx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.w, this.x);
    }
    public Half3 xwy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.w, this.y);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.x = value.x; this.w = value.y; this.y = value.z; }
    }
    public Half3 xwz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.w, this.z);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.x = value.x; this.w = value.y; this.z = value.z; }
    }
    public Half3 xww
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.w, this.w);
    }
    public Half3 yxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.x, this.x);
    }
    public Half3 yxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.x, this.y);
    }
    public Half3 yxz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.x, this.z);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.y = value.x; this.x = value.y; this.z = value.z; }
    }
    public Half3 yxw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.x, this.w);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.y = value.x; this.x = value.y; this.w = value.z; }
    }
    public Half3 yyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.y, this.x);
    }
    public Half3 yyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.y, this.y);
    }
    public Half3 yyz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.y, this.z);
    }
    public Half3 yyw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.y, this.w);
    }
    public Half3 yzx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.z, this.x);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.y = value.x; this.z = value.y; this.x = value.z; }
    }
    public Half3 yzy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.z, this.y);
    }
    public Half3 yzz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.z, this.z);
    }
    public Half3 yzw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.z, this.w);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.y = value.x; this.z = value.y; this.w = value.z; }
    }
    public Half3 ywx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.w, this.x);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.y = value.x; this.w = value.y; this.x = value.z; }
    }
    public Half3 ywy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.w, this.y);
    }
    public Half3 ywz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.w, this.z);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.y = value.x; this.w = value.y; this.z = value.z; }
    }
    public Half3 yww
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.w, this.w);
    }
    public Half3 zxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.x, this.x);
    }
    public Half3 zxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.x, this.y);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.z = value.x; this.x = value.y; this.y = value.z; }
    }
    public Half3 zxz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.x, this.z);
    }
    public Half3 zxw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.x, this.w);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.z = value.x; this.x = value.y; this.w = value.z; }
    }
    public Half3 zyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.y, this.x);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.z = value.x; this.y = value.y; this.x = value.z; }
    }
    public Half3 zyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.y, this.y);
    }
    public Half3 zyz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.y, this.z);
    }
    public Half3 zyw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.y, this.w);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.z = value.x; this.y = value.y; this.w = value.z; }
    }
    public Half3 zzx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.z, this.x);
    }
    public Half3 zzy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.z, this.y);
    }
    public Half3 zzz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.z, this.z);
    }
    public Half3 zzw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.z, this.w);
    }
    public Half3 zwx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.w, this.x);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.z = value.x; this.w = value.y; this.x = value.z; }
    }
    public Half3 zwy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.w, this.y);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.z = value.x; this.w = value.y; this.y = value.z; }
    }
    public Half3 zwz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.w, this.z);
    }
    public Half3 zww
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.w, this.w);
    }
    public Half3 wxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.w, this.x, this.x);
    }
    public Half3 wxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.w, this.x, this.y);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.w = value.x; this.x = value.y; this.y = value.z; }
    }
    public Half3 wxz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.w, this.x, this.z);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.w = value.x; this.x = value.y; this.z = value.z; }
    }
    public Half3 wxw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.w, this.x, this.w);
    }
    public Half3 wyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.w, this.y, this.x);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.w = value.x; this.y = value.y; this.x = value.z; }
    }
    public Half3 wyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.w, this.y, this.y);
    }
    public Half3 wyz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.w, this.y, this.z);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.w = value.x; this.y = value.y; this.z = value.z; }
    }
    public Half3 wyw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.w, this.y, this.w);
    }
    public Half3 wzx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.w, this.z, this.x);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.w = value.x; this.z = value.y; this.x = value.z; }
    }
    public Half3 wzy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.w, this.z, this.y);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.w = value.x; this.z = value.y; this.y = value.z; }
    }
    public Half3 wzz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.w, this.z, this.z);
    }
    public Half3 wzw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.w, this.z, this.w);
    }
    public Half3 wwx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.w, this.w, this.x);
    }
    public Half3 wwy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.w, this.w, this.y);
    }
    public Half3 wwz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.w, this.w, this.z);
    }
    public Half3 www
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.w, this.w, this.w);
    }
    public Half3 rrr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.r, this.r);
    }
    public Half3 rrg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.r, this.g);
    }
    public Half3 rrb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.r, this.b);
    }
    public Half3 rra
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.r, this.a);
    }
    public Half3 rgr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.g, this.r);
    }
    public Half3 rgg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.g, this.g);
    }
    public Half3 rgb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.g, this.b);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.r = value.x; this.g = value.y; this.b = value.z; }
    }
    public Half3 rga
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.g, this.a);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.r = value.x; this.g = value.y; this.a = value.z; }
    }
    public Half3 rbr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.b, this.r);
    }
    public Half3 rbg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.b, this.g);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.r = value.x; this.b = value.y; this.g = value.z; }
    }
    public Half3 rbb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.b, this.b);
    }
    public Half3 rba
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.b, this.a);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.r = value.x; this.b = value.y; this.a = value.z; }
    }
    public Half3 rar
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.a, this.r);
    }
    public Half3 rag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.a, this.g);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.r = value.x; this.a = value.y; this.g = value.z; }
    }
    public Half3 rab
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.a, this.b);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.r = value.x; this.a = value.y; this.b = value.z; }
    }
    public Half3 raa
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.a, this.a);
    }
    public Half3 grr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.r, this.r);
    }
    public Half3 grg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.r, this.g);
    }
    public Half3 grb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.r, this.b);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.g = value.x; this.r = value.y; this.b = value.z; }
    }
    public Half3 gra
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.r, this.a);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.g = value.x; this.r = value.y; this.a = value.z; }
    }
    public Half3 ggr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.g, this.r);
    }
    public Half3 ggg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.g, this.g);
    }
    public Half3 ggb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.g, this.b);
    }
    public Half3 gga
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.g, this.a);
    }
    public Half3 gbr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.b, this.r);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.g = value.x; this.b = value.y; this.r = value.z; }
    }
    public Half3 gbg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.b, this.g);
    }
    public Half3 gbb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.b, this.b);
    }
    public Half3 gba
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.b, this.a);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.g = value.x; this.b = value.y; this.a = value.z; }
    }
    public Half3 gar
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.a, this.r);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.g = value.x; this.a = value.y; this.r = value.z; }
    }
    public Half3 gag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.a, this.g);
    }
    public Half3 gab
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.a, this.b);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.g = value.x; this.a = value.y; this.b = value.z; }
    }
    public Half3 gaa
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.a, this.a);
    }
    public Half3 brr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.r, this.r);
    }
    public Half3 brg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.r, this.g);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.b = value.x; this.r = value.y; this.g = value.z; }
    }
    public Half3 brb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.r, this.b);
    }
    public Half3 bra
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.r, this.a);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.b = value.x; this.r = value.y; this.a = value.z; }
    }
    public Half3 bgr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.g, this.r);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.b = value.x; this.g = value.y; this.r = value.z; }
    }
    public Half3 bgg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.g, this.g);
    }
    public Half3 bgb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.g, this.b);
    }
    public Half3 bga
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.g, this.a);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.b = value.x; this.g = value.y; this.a = value.z; }
    }
    public Half3 bbr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.b, this.r);
    }
    public Half3 bbg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.b, this.g);
    }
    public Half3 bbb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.b, this.b);
    }
    public Half3 bba
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.b, this.a);
    }
    public Half3 bar
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.a, this.r);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.b = value.x; this.a = value.y; this.r = value.z; }
    }
    public Half3 bag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.a, this.g);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.b = value.x; this.a = value.y; this.g = value.z; }
    }
    public Half3 bab
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.a, this.b);
    }
    public Half3 baa
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.a, this.a);
    }
    public Half3 arr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.a, this.r, this.r);
    }
    public Half3 arg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.a, this.r, this.g);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.a = value.x; this.r = value.y; this.g = value.z; }
    }
    public Half3 arb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.a, this.r, this.b);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.a = value.x; this.r = value.y; this.b = value.z; }
    }
    public Half3 ara
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.a, this.r, this.a);
    }
    public Half3 agr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.a, this.g, this.r);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.a = value.x; this.g = value.y; this.r = value.z; }
    }
    public Half3 agg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.a, this.g, this.g);
    }
    public Half3 agb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.a, this.g, this.b);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.a = value.x; this.g = value.y; this.b = value.z; }
    }
    public Half3 aga
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.a, this.g, this.a);
    }
    public Half3 abr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.a, this.b, this.r);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.a = value.x; this.b = value.y; this.r = value.z; }
    }
    public Half3 abg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.a, this.b, this.g);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.a = value.x; this.b = value.y; this.g = value.z; }
    }
    public Half3 abb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.a, this.b, this.b);
    }
    public Half3 aba
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.a, this.b, this.a);
    }
    public Half3 aar
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.a, this.a, this.r);
    }
    public Half3 aag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.a, this.a, this.g);
    }
    public Half3 aab
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.a, this.a, this.b);
    }
    public Half3 aaa
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.a, this.a, this.a);
    }
    public Half4 xxxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.x, this.x, this.x);
    }
    public Half4 xxxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.x, this.x, this.y);
    }
    public Half4 xxxz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.x, this.x, this.z);
    }
    public Half4 xxxw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.x, this.x, this.w);
    }
    public Half4 xxyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.x, this.y, this.x);
    }
    public Half4 xxyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.x, this.y, this.y);
    }
    public Half4 xxyz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.x, this.y, this.z);
    }
    public Half4 xxyw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.x, this.y, this.w);
    }
    public Half4 xxzx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.x, this.z, this.x);
    }
    public Half4 xxzy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.x, this.z, this.y);
    }
    public Half4 xxzz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.x, this.z, this.z);
    }
    public Half4 xxzw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.x, this.z, this.w);
    }
    public Half4 xxwx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.x, this.w, this.x);
    }
    public Half4 xxwy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.x, this.w, this.y);
    }
    public Half4 xxwz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.x, this.w, this.z);
    }
    public Half4 xxww
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.x, this.w, this.w);
    }
    public Half4 xyxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.y, this.x, this.x);
    }
    public Half4 xyxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.y, this.x, this.y);
    }
    public Half4 xyxz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.y, this.x, this.z);
    }
    public Half4 xyxw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.y, this.x, this.w);
    }
    public Half4 xyyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.y, this.y, this.x);
    }
    public Half4 xyyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.y, this.y, this.y);
    }
    public Half4 xyyz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.y, this.y, this.z);
    }
    public Half4 xyyw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.y, this.y, this.w);
    }
    public Half4 xyzx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.y, this.z, this.x);
    }
    public Half4 xyzy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.y, this.z, this.y);
    }
    public Half4 xyzz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.y, this.z, this.z);
    }
    public Half4 xyzw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.y, this.z, this.w);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.x = value.x; this.y = value.y; this.z = value.z; this.w = value.w; }
    }
    public Half4 xywx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.y, this.w, this.x);
    }
    public Half4 xywy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.y, this.w, this.y);
    }
    public Half4 xywz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.y, this.w, this.z);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.x = value.x; this.y = value.y; this.w = value.z; this.z = value.w; }
    }
    public Half4 xyww
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.y, this.w, this.w);
    }
    public Half4 xzxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.z, this.x, this.x);
    }
    public Half4 xzxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.z, this.x, this.y);
    }
    public Half4 xzxz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.z, this.x, this.z);
    }
    public Half4 xzxw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.z, this.x, this.w);
    }
    public Half4 xzyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.z, this.y, this.x);
    }
    public Half4 xzyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.z, this.y, this.y);
    }
    public Half4 xzyz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.z, this.y, this.z);
    }
    public Half4 xzyw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.z, this.y, this.w);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.x = value.x; this.z = value.y; this.y = value.z; this.w = value.w; }
    }
    public Half4 xzzx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.z, this.z, this.x);
    }
    public Half4 xzzy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.z, this.z, this.y);
    }
    public Half4 xzzz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.z, this.z, this.z);
    }
    public Half4 xzzw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.z, this.z, this.w);
    }
    public Half4 xzwx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.z, this.w, this.x);
    }
    public Half4 xzwy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.z, this.w, this.y);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.x = value.x; this.z = value.y; this.w = value.z; this.y = value.w; }
    }
    public Half4 xzwz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.z, this.w, this.z);
    }
    public Half4 xzww
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.z, this.w, this.w);
    }
    public Half4 xwxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.w, this.x, this.x);
    }
    public Half4 xwxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.w, this.x, this.y);
    }
    public Half4 xwxz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.w, this.x, this.z);
    }
    public Half4 xwxw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.w, this.x, this.w);
    }
    public Half4 xwyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.w, this.y, this.x);
    }
    public Half4 xwyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.w, this.y, this.y);
    }
    public Half4 xwyz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.w, this.y, this.z);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.x = value.x; this.w = value.y; this.y = value.z; this.z = value.w; }
    }
    public Half4 xwyw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.w, this.y, this.w);
    }
    public Half4 xwzx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.w, this.z, this.x);
    }
    public Half4 xwzy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.w, this.z, this.y);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.x = value.x; this.w = value.y; this.z = value.z; this.y = value.w; }
    }
    public Half4 xwzz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.w, this.z, this.z);
    }
    public Half4 xwzw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.w, this.z, this.w);
    }
    public Half4 xwwx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.w, this.w, this.x);
    }
    public Half4 xwwy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.w, this.w, this.y);
    }
    public Half4 xwwz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.w, this.w, this.z);
    }
    public Half4 xwww
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.x, this.w, this.w, this.w);
    }
    public Half4 yxxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.x, this.x, this.x);
    }
    public Half4 yxxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.x, this.x, this.y);
    }
    public Half4 yxxz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.x, this.x, this.z);
    }
    public Half4 yxxw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.x, this.x, this.w);
    }
    public Half4 yxyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.x, this.y, this.x);
    }
    public Half4 yxyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.x, this.y, this.y);
    }
    public Half4 yxyz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.x, this.y, this.z);
    }
    public Half4 yxyw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.x, this.y, this.w);
    }
    public Half4 yxzx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.x, this.z, this.x);
    }
    public Half4 yxzy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.x, this.z, this.y);
    }
    public Half4 yxzz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.x, this.z, this.z);
    }
    public Half4 yxzw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.x, this.z, this.w);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.y = value.x; this.x = value.y; this.z = value.z; this.w = value.w; }
    }
    public Half4 yxwx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.x, this.w, this.x);
    }
    public Half4 yxwy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.x, this.w, this.y);
    }
    public Half4 yxwz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.x, this.w, this.z);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.y = value.x; this.x = value.y; this.w = value.z; this.z = value.w; }
    }
    public Half4 yxww
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.x, this.w, this.w);
    }
    public Half4 yyxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.y, this.x, this.x);
    }
    public Half4 yyxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.y, this.x, this.y);
    }
    public Half4 yyxz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.y, this.x, this.z);
    }
    public Half4 yyxw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.y, this.x, this.w);
    }
    public Half4 yyyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.y, this.y, this.x);
    }
    public Half4 yyyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.y, this.y, this.y);
    }
    public Half4 yyyz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.y, this.y, this.z);
    }
    public Half4 yyyw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.y, this.y, this.w);
    }
    public Half4 yyzx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.y, this.z, this.x);
    }
    public Half4 yyzy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.y, this.z, this.y);
    }
    public Half4 yyzz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.y, this.z, this.z);
    }
    public Half4 yyzw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.y, this.z, this.w);
    }
    public Half4 yywx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.y, this.w, this.x);
    }
    public Half4 yywy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.y, this.w, this.y);
    }
    public Half4 yywz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.y, this.w, this.z);
    }
    public Half4 yyww
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.y, this.w, this.w);
    }
    public Half4 yzxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.z, this.x, this.x);
    }
    public Half4 yzxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.z, this.x, this.y);
    }
    public Half4 yzxz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.z, this.x, this.z);
    }
    public Half4 yzxw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.z, this.x, this.w);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.y = value.x; this.z = value.y; this.x = value.z; this.w = value.w; }
    }
    public Half4 yzyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.z, this.y, this.x);
    }
    public Half4 yzyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.z, this.y, this.y);
    }
    public Half4 yzyz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.z, this.y, this.z);
    }
    public Half4 yzyw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.z, this.y, this.w);
    }
    public Half4 yzzx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.z, this.z, this.x);
    }
    public Half4 yzzy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.z, this.z, this.y);
    }
    public Half4 yzzz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.z, this.z, this.z);
    }
    public Half4 yzzw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.z, this.z, this.w);
    }
    public Half4 yzwx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.z, this.w, this.x);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.y = value.x; this.z = value.y; this.w = value.z; this.x = value.w; }
    }
    public Half4 yzwy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.z, this.w, this.y);
    }
    public Half4 yzwz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.z, this.w, this.z);
    }
    public Half4 yzww
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.z, this.w, this.w);
    }
    public Half4 ywxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.w, this.x, this.x);
    }
    public Half4 ywxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.w, this.x, this.y);
    }
    public Half4 ywxz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.w, this.x, this.z);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.y = value.x; this.w = value.y; this.x = value.z; this.z = value.w; }
    }
    public Half4 ywxw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.w, this.x, this.w);
    }
    public Half4 ywyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.w, this.y, this.x);
    }
    public Half4 ywyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.w, this.y, this.y);
    }
    public Half4 ywyz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.w, this.y, this.z);
    }
    public Half4 ywyw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.w, this.y, this.w);
    }
    public Half4 ywzx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.w, this.z, this.x);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.y = value.x; this.w = value.y; this.z = value.z; this.x = value.w; }
    }
    public Half4 ywzy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.w, this.z, this.y);
    }
    public Half4 ywzz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.w, this.z, this.z);
    }
    public Half4 ywzw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.w, this.z, this.w);
    }
    public Half4 ywwx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.w, this.w, this.x);
    }
    public Half4 ywwy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.w, this.w, this.y);
    }
    public Half4 ywwz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.w, this.w, this.z);
    }
    public Half4 ywww
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.y, this.w, this.w, this.w);
    }
    public Half4 zxxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.x, this.x, this.x);
    }
    public Half4 zxxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.x, this.x, this.y);
    }
    public Half4 zxxz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.x, this.x, this.z);
    }
    public Half4 zxxw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.x, this.x, this.w);
    }
    public Half4 zxyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.x, this.y, this.x);
    }
    public Half4 zxyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.x, this.y, this.y);
    }
    public Half4 zxyz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.x, this.y, this.z);
    }
    public Half4 zxyw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.x, this.y, this.w);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.z = value.x; this.x = value.y; this.y = value.z; this.w = value.w; }
    }
    public Half4 zxzx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.x, this.z, this.x);
    }
    public Half4 zxzy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.x, this.z, this.y);
    }
    public Half4 zxzz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.x, this.z, this.z);
    }
    public Half4 zxzw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.x, this.z, this.w);
    }
    public Half4 zxwx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.x, this.w, this.x);
    }
    public Half4 zxwy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.x, this.w, this.y);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.z = value.x; this.x = value.y; this.w = value.z; this.y = value.w; }
    }
    public Half4 zxwz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.x, this.w, this.z);
    }
    public Half4 zxww
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.x, this.w, this.w);
    }
    public Half4 zyxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.y, this.x, this.x);
    }
    public Half4 zyxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.y, this.x, this.y);
    }
    public Half4 zyxz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.y, this.x, this.z);
    }
    public Half4 zyxw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.y, this.x, this.w);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.z = value.x; this.y = value.y; this.x = value.z; this.w = value.w; }
    }
    public Half4 zyyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.y, this.y, this.x);
    }
    public Half4 zyyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.y, this.y, this.y);
    }
    public Half4 zyyz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.y, this.y, this.z);
    }
    public Half4 zyyw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.y, this.y, this.w);
    }
    public Half4 zyzx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.y, this.z, this.x);
    }
    public Half4 zyzy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.y, this.z, this.y);
    }
    public Half4 zyzz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.y, this.z, this.z);
    }
    public Half4 zyzw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.y, this.z, this.w);
    }
    public Half4 zywx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.y, this.w, this.x);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.z = value.x; this.y = value.y; this.w = value.z; this.x = value.w; }
    }
    public Half4 zywy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.y, this.w, this.y);
    }
    public Half4 zywz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.y, this.w, this.z);
    }
    public Half4 zyww
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.y, this.w, this.w);
    }
    public Half4 zzxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.z, this.x, this.x);
    }
    public Half4 zzxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.z, this.x, this.y);
    }
    public Half4 zzxz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.z, this.x, this.z);
    }
    public Half4 zzxw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.z, this.x, this.w);
    }
    public Half4 zzyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.z, this.y, this.x);
    }
    public Half4 zzyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.z, this.y, this.y);
    }
    public Half4 zzyz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.z, this.y, this.z);
    }
    public Half4 zzyw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.z, this.y, this.w);
    }
    public Half4 zzzx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.z, this.z, this.x);
    }
    public Half4 zzzy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.z, this.z, this.y);
    }
    public Half4 zzzz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.z, this.z, this.z);
    }
    public Half4 zzzw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.z, this.z, this.w);
    }
    public Half4 zzwx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.z, this.w, this.x);
    }
    public Half4 zzwy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.z, this.w, this.y);
    }
    public Half4 zzwz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.z, this.w, this.z);
    }
    public Half4 zzww
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.z, this.w, this.w);
    }
    public Half4 zwxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.w, this.x, this.x);
    }
    public Half4 zwxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.w, this.x, this.y);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.z = value.x; this.w = value.y; this.x = value.z; this.y = value.w; }
    }
    public Half4 zwxz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.w, this.x, this.z);
    }
    public Half4 zwxw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.w, this.x, this.w);
    }
    public Half4 zwyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.w, this.y, this.x);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.z = value.x; this.w = value.y; this.y = value.z; this.x = value.w; }
    }
    public Half4 zwyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.w, this.y, this.y);
    }
    public Half4 zwyz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.w, this.y, this.z);
    }
    public Half4 zwyw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.w, this.y, this.w);
    }
    public Half4 zwzx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.w, this.z, this.x);
    }
    public Half4 zwzy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.w, this.z, this.y);
    }
    public Half4 zwzz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.w, this.z, this.z);
    }
    public Half4 zwzw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.w, this.z, this.w);
    }
    public Half4 zwwx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.w, this.w, this.x);
    }
    public Half4 zwwy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.w, this.w, this.y);
    }
    public Half4 zwwz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.w, this.w, this.z);
    }
    public Half4 zwww
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.z, this.w, this.w, this.w);
    }
    public Half4 wxxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.w, this.x, this.x, this.x);
    }
    public Half4 wxxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.w, this.x, this.x, this.y);
    }
    public Half4 wxxz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.w, this.x, this.x, this.z);
    }
    public Half4 wxxw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.w, this.x, this.x, this.w);
    }
    public Half4 wxyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.w, this.x, this.y, this.x);
    }
    public Half4 wxyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.w, this.x, this.y, this.y);
    }
    public Half4 wxyz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.w, this.x, this.y, this.z);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.w = value.x; this.x = value.y; this.y = value.z; this.z = value.w; }
    }
    public Half4 wxyw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.w, this.x, this.y, this.w);
    }
    public Half4 wxzx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.w, this.x, this.z, this.x);
    }
    public Half4 wxzy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.w, this.x, this.z, this.y);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.w = value.x; this.x = value.y; this.z = value.z; this.y = value.w; }
    }
    public Half4 wxzz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.w, this.x, this.z, this.z);
    }
    public Half4 wxzw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.w, this.x, this.z, this.w);
    }
    public Half4 wxwx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.w, this.x, this.w, this.x);
    }
    public Half4 wxwy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.w, this.x, this.w, this.y);
    }
    public Half4 wxwz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.w, this.x, this.w, this.z);
    }
    public Half4 wxww
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.w, this.x, this.w, this.w);
    }
    public Half4 wyxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.w, this.y, this.x, this.x);
    }
    public Half4 wyxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.w, this.y, this.x, this.y);
    }
    public Half4 wyxz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.w, this.y, this.x, this.z);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.w = value.x; this.y = value.y; this.x = value.z; this.z = value.w; }
    }
    public Half4 wyxw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.w, this.y, this.x, this.w);
    }
    public Half4 wyyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.w, this.y, this.y, this.x);
    }
    public Half4 wyyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.w, this.y, this.y, this.y);
    }
    public Half4 wyyz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.w, this.y, this.y, this.z);
    }
    public Half4 wyyw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.w, this.y, this.y, this.w);
    }
    public Half4 wyzx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.w, this.y, this.z, this.x);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.w = value.x; this.y = value.y; this.z = value.z; this.x = value.w; }
    }
    public Half4 wyzy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.w, this.y, this.z, this.y);
    }
    public Half4 wyzz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.w, this.y, this.z, this.z);
    }
    public Half4 wyzw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.w, this.y, this.z, this.w);
    }
    public Half4 wywx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.w, this.y, this.w, this.x);
    }
    public Half4 wywy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.w, this.y, this.w, this.y);
    }
    public Half4 wywz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.w, this.y, this.w, this.z);
    }
    public Half4 wyww
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.w, this.y, this.w, this.w);
    }
    public Half4 wzxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.w, this.z, this.x, this.x);
    }
    public Half4 wzxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.w, this.z, this.x, this.y);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.w = value.x; this.z = value.y; this.x = value.z; this.y = value.w; }
    }
    public Half4 wzxz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.w, this.z, this.x, this.z);
    }
    public Half4 wzxw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.w, this.z, this.x, this.w);
    }
    public Half4 wzyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.w, this.z, this.y, this.x);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.w = value.x; this.z = value.y; this.y = value.z; this.x = value.w; }
    }
    public Half4 wzyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.w, this.z, this.y, this.y);
    }
    public Half4 wzyz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.w, this.z, this.y, this.z);
    }
    public Half4 wzyw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.w, this.z, this.y, this.w);
    }
    public Half4 wzzx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.w, this.z, this.z, this.x);
    }
    public Half4 wzzy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.w, this.z, this.z, this.y);
    }
    public Half4 wzzz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.w, this.z, this.z, this.z);
    }
    public Half4 wzzw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.w, this.z, this.z, this.w);
    }
    public Half4 wzwx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.w, this.z, this.w, this.x);
    }
    public Half4 wzwy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.w, this.z, this.w, this.y);
    }
    public Half4 wzwz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.w, this.z, this.w, this.z);
    }
    public Half4 wzww
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.w, this.z, this.w, this.w);
    }
    public Half4 wwxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.w, this.w, this.x, this.x);
    }
    public Half4 wwxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.w, this.w, this.x, this.y);
    }
    public Half4 wwxz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.w, this.w, this.x, this.z);
    }
    public Half4 wwxw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.w, this.w, this.x, this.w);
    }
    public Half4 wwyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.w, this.w, this.y, this.x);
    }
    public Half4 wwyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.w, this.w, this.y, this.y);
    }
    public Half4 wwyz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.w, this.w, this.y, this.z);
    }
    public Half4 wwyw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.w, this.w, this.y, this.w);
    }
    public Half4 wwzx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.w, this.w, this.z, this.x);
    }
    public Half4 wwzy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.w, this.w, this.z, this.y);
    }
    public Half4 wwzz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.w, this.w, this.z, this.z);
    }
    public Half4 wwzw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.w, this.w, this.z, this.w);
    }
    public Half4 wwwx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.w, this.w, this.w, this.x);
    }
    public Half4 wwwy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.w, this.w, this.w, this.y);
    }
    public Half4 wwwz
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.w, this.w, this.w, this.z);
    }
    public Half4 wwww
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.w, this.w, this.w, this.w);
    }
    public Half4 rrrr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.r, this.r, this.r);
    }
    public Half4 rrrg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.r, this.r, this.g);
    }
    public Half4 rrrb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.r, this.r, this.b);
    }
    public Half4 rrra
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.r, this.r, this.a);
    }
    public Half4 rrgr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.r, this.g, this.r);
    }
    public Half4 rrgg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.r, this.g, this.g);
    }
    public Half4 rrgb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.r, this.g, this.b);
    }
    public Half4 rrga
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.r, this.g, this.a);
    }
    public Half4 rrbr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.r, this.b, this.r);
    }
    public Half4 rrbg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.r, this.b, this.g);
    }
    public Half4 rrbb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.r, this.b, this.b);
    }
    public Half4 rrba
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.r, this.b, this.a);
    }
    public Half4 rrar
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.r, this.a, this.r);
    }
    public Half4 rrag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.r, this.a, this.g);
    }
    public Half4 rrab
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.r, this.a, this.b);
    }
    public Half4 rraa
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.r, this.a, this.a);
    }
    public Half4 rgrr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.g, this.r, this.r);
    }
    public Half4 rgrg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.g, this.r, this.g);
    }
    public Half4 rgrb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.g, this.r, this.b);
    }
    public Half4 rgra
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.g, this.r, this.a);
    }
    public Half4 rggr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.g, this.g, this.r);
    }
    public Half4 rggg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.g, this.g, this.g);
    }
    public Half4 rggb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.g, this.g, this.b);
    }
    public Half4 rgga
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.g, this.g, this.a);
    }
    public Half4 rgbr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.g, this.b, this.r);
    }
    public Half4 rgbg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.g, this.b, this.g);
    }
    public Half4 rgbb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.g, this.b, this.b);
    }
    public Half4 rgba
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.g, this.b, this.a);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.r = value.x; this.g = value.y; this.b = value.z; this.a = value.w; }
    }
    public Half4 rgar
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.g, this.a, this.r);
    }
    public Half4 rgag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.g, this.a, this.g);
    }
    public Half4 rgab
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.g, this.a, this.b);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.r = value.x; this.g = value.y; this.a = value.z; this.b = value.w; }
    }
    public Half4 rgaa
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.g, this.a, this.a);
    }
    public Half4 rbrr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.b, this.r, this.r);
    }
    public Half4 rbrg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.b, this.r, this.g);
    }
    public Half4 rbrb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.b, this.r, this.b);
    }
    public Half4 rbra
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.b, this.r, this.a);
    }
    public Half4 rbgr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.b, this.g, this.r);
    }
    public Half4 rbgg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.b, this.g, this.g);
    }
    public Half4 rbgb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.b, this.g, this.b);
    }
    public Half4 rbga
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.b, this.g, this.a);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.r = value.x; this.b = value.y; this.g = value.z; this.a = value.w; }
    }
    public Half4 rbbr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.b, this.b, this.r);
    }
    public Half4 rbbg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.b, this.b, this.g);
    }
    public Half4 rbbb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.b, this.b, this.b);
    }
    public Half4 rbba
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.b, this.b, this.a);
    }
    public Half4 rbar
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.b, this.a, this.r);
    }
    public Half4 rbag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.b, this.a, this.g);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.r = value.x; this.b = value.y; this.a = value.z; this.g = value.w; }
    }
    public Half4 rbab
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.b, this.a, this.b);
    }
    public Half4 rbaa
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.b, this.a, this.a);
    }
    public Half4 rarr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.a, this.r, this.r);
    }
    public Half4 rarg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.a, this.r, this.g);
    }
    public Half4 rarb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.a, this.r, this.b);
    }
    public Half4 rara
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.a, this.r, this.a);
    }
    public Half4 ragr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.a, this.g, this.r);
    }
    public Half4 ragg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.a, this.g, this.g);
    }
    public Half4 ragb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.a, this.g, this.b);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.r = value.x; this.a = value.y; this.g = value.z; this.b = value.w; }
    }
    public Half4 raga
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.a, this.g, this.a);
    }
    public Half4 rabr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.a, this.b, this.r);
    }
    public Half4 rabg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.a, this.b, this.g);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.r = value.x; this.a = value.y; this.b = value.z; this.g = value.w; }
    }
    public Half4 rabb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.a, this.b, this.b);
    }
    public Half4 raba
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.a, this.b, this.a);
    }
    public Half4 raar
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.a, this.a, this.r);
    }
    public Half4 raag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.a, this.a, this.g);
    }
    public Half4 raab
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.a, this.a, this.b);
    }
    public Half4 raaa
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.r, this.a, this.a, this.a);
    }
    public Half4 grrr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.r, this.r, this.r);
    }
    public Half4 grrg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.r, this.r, this.g);
    }
    public Half4 grrb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.r, this.r, this.b);
    }
    public Half4 grra
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.r, this.r, this.a);
    }
    public Half4 grgr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.r, this.g, this.r);
    }
    public Half4 grgg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.r, this.g, this.g);
    }
    public Half4 grgb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.r, this.g, this.b);
    }
    public Half4 grga
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.r, this.g, this.a);
    }
    public Half4 grbr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.r, this.b, this.r);
    }
    public Half4 grbg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.r, this.b, this.g);
    }
    public Half4 grbb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.r, this.b, this.b);
    }
    public Half4 grba
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.r, this.b, this.a);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.g = value.x; this.r = value.y; this.b = value.z; this.a = value.w; }
    }
    public Half4 grar
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.r, this.a, this.r);
    }
    public Half4 grag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.r, this.a, this.g);
    }
    public Half4 grab
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.r, this.a, this.b);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.g = value.x; this.r = value.y; this.a = value.z; this.b = value.w; }
    }
    public Half4 graa
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.r, this.a, this.a);
    }
    public Half4 ggrr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.g, this.r, this.r);
    }
    public Half4 ggrg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.g, this.r, this.g);
    }
    public Half4 ggrb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.g, this.r, this.b);
    }
    public Half4 ggra
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.g, this.r, this.a);
    }
    public Half4 gggr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.g, this.g, this.r);
    }
    public Half4 gggg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.g, this.g, this.g);
    }
    public Half4 gggb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.g, this.g, this.b);
    }
    public Half4 ggga
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.g, this.g, this.a);
    }
    public Half4 ggbr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.g, this.b, this.r);
    }
    public Half4 ggbg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.g, this.b, this.g);
    }
    public Half4 ggbb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.g, this.b, this.b);
    }
    public Half4 ggba
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.g, this.b, this.a);
    }
    public Half4 ggar
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.g, this.a, this.r);
    }
    public Half4 ggag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.g, this.a, this.g);
    }
    public Half4 ggab
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.g, this.a, this.b);
    }
    public Half4 ggaa
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.g, this.a, this.a);
    }
    public Half4 gbrr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.b, this.r, this.r);
    }
    public Half4 gbrg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.b, this.r, this.g);
    }
    public Half4 gbrb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.b, this.r, this.b);
    }
    public Half4 gbra
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.b, this.r, this.a);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.g = value.x; this.b = value.y; this.r = value.z; this.a = value.w; }
    }
    public Half4 gbgr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.b, this.g, this.r);
    }
    public Half4 gbgg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.b, this.g, this.g);
    }
    public Half4 gbgb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.b, this.g, this.b);
    }
    public Half4 gbga
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.b, this.g, this.a);
    }
    public Half4 gbbr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.b, this.b, this.r);
    }
    public Half4 gbbg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.b, this.b, this.g);
    }
    public Half4 gbbb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.b, this.b, this.b);
    }
    public Half4 gbba
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.b, this.b, this.a);
    }
    public Half4 gbar
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.b, this.a, this.r);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.g = value.x; this.b = value.y; this.a = value.z; this.r = value.w; }
    }
    public Half4 gbag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.b, this.a, this.g);
    }
    public Half4 gbab
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.b, this.a, this.b);
    }
    public Half4 gbaa
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.b, this.a, this.a);
    }
    public Half4 garr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.a, this.r, this.r);
    }
    public Half4 garg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.a, this.r, this.g);
    }
    public Half4 garb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.a, this.r, this.b);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.g = value.x; this.a = value.y; this.r = value.z; this.b = value.w; }
    }
    public Half4 gara
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.a, this.r, this.a);
    }
    public Half4 gagr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.a, this.g, this.r);
    }
    public Half4 gagg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.a, this.g, this.g);
    }
    public Half4 gagb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.a, this.g, this.b);
    }
    public Half4 gaga
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.a, this.g, this.a);
    }
    public Half4 gabr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.a, this.b, this.r);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.g = value.x; this.a = value.y; this.b = value.z; this.r = value.w; }
    }
    public Half4 gabg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.a, this.b, this.g);
    }
    public Half4 gabb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.a, this.b, this.b);
    }
    public Half4 gaba
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.a, this.b, this.a);
    }
    public Half4 gaar
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.a, this.a, this.r);
    }
    public Half4 gaag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.a, this.a, this.g);
    }
    public Half4 gaab
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.a, this.a, this.b);
    }
    public Half4 gaaa
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.g, this.a, this.a, this.a);
    }
    public Half4 brrr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.r, this.r, this.r);
    }
    public Half4 brrg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.r, this.r, this.g);
    }
    public Half4 brrb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.r, this.r, this.b);
    }
    public Half4 brra
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.r, this.r, this.a);
    }
    public Half4 brgr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.r, this.g, this.r);
    }
    public Half4 brgg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.r, this.g, this.g);
    }
    public Half4 brgb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.r, this.g, this.b);
    }
    public Half4 brga
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.r, this.g, this.a);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.b = value.x; this.r = value.y; this.g = value.z; this.a = value.w; }
    }
    public Half4 brbr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.r, this.b, this.r);
    }
    public Half4 brbg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.r, this.b, this.g);
    }
    public Half4 brbb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.r, this.b, this.b);
    }
    public Half4 brba
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.r, this.b, this.a);
    }
    public Half4 brar
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.r, this.a, this.r);
    }
    public Half4 brag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.r, this.a, this.g);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.b = value.x; this.r = value.y; this.a = value.z; this.g = value.w; }
    }
    public Half4 brab
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.r, this.a, this.b);
    }
    public Half4 braa
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.r, this.a, this.a);
    }
    public Half4 bgrr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.g, this.r, this.r);
    }
    public Half4 bgrg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.g, this.r, this.g);
    }
    public Half4 bgrb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.g, this.r, this.b);
    }
    public Half4 bgra
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.g, this.r, this.a);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.b = value.x; this.g = value.y; this.r = value.z; this.a = value.w; }
    }
    public Half4 bggr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.g, this.g, this.r);
    }
    public Half4 bggg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.g, this.g, this.g);
    }
    public Half4 bggb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.g, this.g, this.b);
    }
    public Half4 bgga
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.g, this.g, this.a);
    }
    public Half4 bgbr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.g, this.b, this.r);
    }
    public Half4 bgbg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.g, this.b, this.g);
    }
    public Half4 bgbb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.g, this.b, this.b);
    }
    public Half4 bgba
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.g, this.b, this.a);
    }
    public Half4 bgar
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.g, this.a, this.r);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.b = value.x; this.g = value.y; this.a = value.z; this.r = value.w; }
    }
    public Half4 bgag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.g, this.a, this.g);
    }
    public Half4 bgab
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.g, this.a, this.b);
    }
    public Half4 bgaa
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.g, this.a, this.a);
    }
    public Half4 bbrr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.b, this.r, this.r);
    }
    public Half4 bbrg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.b, this.r, this.g);
    }
    public Half4 bbrb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.b, this.r, this.b);
    }
    public Half4 bbra
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.b, this.r, this.a);
    }
    public Half4 bbgr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.b, this.g, this.r);
    }
    public Half4 bbgg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.b, this.g, this.g);
    }
    public Half4 bbgb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.b, this.g, this.b);
    }
    public Half4 bbga
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.b, this.g, this.a);
    }
    public Half4 bbbr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.b, this.b, this.r);
    }
    public Half4 bbbg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.b, this.b, this.g);
    }
    public Half4 bbbb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.b, this.b, this.b);
    }
    public Half4 bbba
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.b, this.b, this.a);
    }
    public Half4 bbar
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.b, this.a, this.r);
    }
    public Half4 bbag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.b, this.a, this.g);
    }
    public Half4 bbab
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.b, this.a, this.b);
    }
    public Half4 bbaa
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.b, this.a, this.a);
    }
    public Half4 barr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.a, this.r, this.r);
    }
    public Half4 barg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.a, this.r, this.g);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.b = value.x; this.a = value.y; this.r = value.z; this.g = value.w; }
    }
    public Half4 barb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.a, this.r, this.b);
    }
    public Half4 bara
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.a, this.r, this.a);
    }
    public Half4 bagr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.a, this.g, this.r);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.b = value.x; this.a = value.y; this.g = value.z; this.r = value.w; }
    }
    public Half4 bagg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.a, this.g, this.g);
    }
    public Half4 bagb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.a, this.g, this.b);
    }
    public Half4 baga
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.a, this.g, this.a);
    }
    public Half4 babr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.a, this.b, this.r);
    }
    public Half4 babg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.a, this.b, this.g);
    }
    public Half4 babb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.a, this.b, this.b);
    }
    public Half4 baba
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.a, this.b, this.a);
    }
    public Half4 baar
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.a, this.a, this.r);
    }
    public Half4 baag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.a, this.a, this.g);
    }
    public Half4 baab
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.a, this.a, this.b);
    }
    public Half4 baaa
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.b, this.a, this.a, this.a);
    }
    public Half4 arrr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.a, this.r, this.r, this.r);
    }
    public Half4 arrg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.a, this.r, this.r, this.g);
    }
    public Half4 arrb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.a, this.r, this.r, this.b);
    }
    public Half4 arra
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.a, this.r, this.r, this.a);
    }
    public Half4 argr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.a, this.r, this.g, this.r);
    }
    public Half4 argg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.a, this.r, this.g, this.g);
    }
    public Half4 argb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.a, this.r, this.g, this.b);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.a = value.x; this.r = value.y; this.g = value.z; this.b = value.w; }
    }
    public Half4 arga
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.a, this.r, this.g, this.a);
    }
    public Half4 arbr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.a, this.r, this.b, this.r);
    }
    public Half4 arbg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.a, this.r, this.b, this.g);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.a = value.x; this.r = value.y; this.b = value.z; this.g = value.w; }
    }
    public Half4 arbb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.a, this.r, this.b, this.b);
    }
    public Half4 arba
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.a, this.r, this.b, this.a);
    }
    public Half4 arar
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.a, this.r, this.a, this.r);
    }
    public Half4 arag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.a, this.r, this.a, this.g);
    }
    public Half4 arab
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.a, this.r, this.a, this.b);
    }
    public Half4 araa
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.a, this.r, this.a, this.a);
    }
    public Half4 agrr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.a, this.g, this.r, this.r);
    }
    public Half4 agrg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.a, this.g, this.r, this.g);
    }
    public Half4 agrb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.a, this.g, this.r, this.b);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.a = value.x; this.g = value.y; this.r = value.z; this.b = value.w; }
    }
    public Half4 agra
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.a, this.g, this.r, this.a);
    }
    public Half4 aggr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.a, this.g, this.g, this.r);
    }
    public Half4 aggg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.a, this.g, this.g, this.g);
    }
    public Half4 aggb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.a, this.g, this.g, this.b);
    }
    public Half4 agga
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.a, this.g, this.g, this.a);
    }
    public Half4 agbr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.a, this.g, this.b, this.r);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.a = value.x; this.g = value.y; this.b = value.z; this.r = value.w; }
    }
    public Half4 agbg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.a, this.g, this.b, this.g);
    }
    public Half4 agbb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.a, this.g, this.b, this.b);
    }
    public Half4 agba
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.a, this.g, this.b, this.a);
    }
    public Half4 agar
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.a, this.g, this.a, this.r);
    }
    public Half4 agag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.a, this.g, this.a, this.g);
    }
    public Half4 agab
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.a, this.g, this.a, this.b);
    }
    public Half4 agaa
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.a, this.g, this.a, this.a);
    }
    public Half4 abrr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.a, this.b, this.r, this.r);
    }
    public Half4 abrg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.a, this.b, this.r, this.g);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.a = value.x; this.b = value.y; this.r = value.z; this.g = value.w; }
    }
    public Half4 abrb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.a, this.b, this.r, this.b);
    }
    public Half4 abra
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.a, this.b, this.r, this.a);
    }
    public Half4 abgr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.a, this.b, this.g, this.r);
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { this.a = value.x; this.b = value.y; this.g = value.z; this.r = value.w; }
    }
    public Half4 abgg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.a, this.b, this.g, this.g);
    }
    public Half4 abgb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.a, this.b, this.g, this.b);
    }
    public Half4 abga
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.a, this.b, this.g, this.a);
    }
    public Half4 abbr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.a, this.b, this.b, this.r);
    }
    public Half4 abbg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.a, this.b, this.b, this.g);
    }
    public Half4 abbb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.a, this.b, this.b, this.b);
    }
    public Half4 abba
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.a, this.b, this.b, this.a);
    }
    public Half4 abar
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.a, this.b, this.a, this.r);
    }
    public Half4 abag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.a, this.b, this.a, this.g);
    }
    public Half4 abab
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.a, this.b, this.a, this.b);
    }
    public Half4 abaa
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.a, this.b, this.a, this.a);
    }
    public Half4 aarr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.a, this.a, this.r, this.r);
    }
    public Half4 aarg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.a, this.a, this.r, this.g);
    }
    public Half4 aarb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.a, this.a, this.r, this.b);
    }
    public Half4 aara
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.a, this.a, this.r, this.a);
    }
    public Half4 aagr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.a, this.a, this.g, this.r);
    }
    public Half4 aagg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.a, this.a, this.g, this.g);
    }
    public Half4 aagb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.a, this.a, this.g, this.b);
    }
    public Half4 aaga
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.a, this.a, this.g, this.a);
    }
    public Half4 aabr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.a, this.a, this.b, this.r);
    }
    public Half4 aabg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.a, this.a, this.b, this.g);
    }
    public Half4 aabb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.a, this.a, this.b, this.b);
    }
    public Half4 aaba
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.a, this.a, this.b, this.a);
    }
    public Half4 aaar
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.a, this.a, this.a, this.r);
    }
    public Half4 aaag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.a, this.a, this.a, this.g);
    }
    public Half4 aaab
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.a, this.a, this.a, this.b);
    }
    public Half4 aaaa
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(this.a, this.a, this.a, this.a);
    }


}
