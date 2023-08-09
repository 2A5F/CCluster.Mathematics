using System;
using System.Numerics;
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.X86;
using System.Runtime.Intrinsics.Arm;
using System.Runtime.CompilerServices;

#nullable enable
#pragma warning disable CS8981

namespace CCluster.Mathematics;

public partial struct int2 
{

    public int2 xx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {
            
            return new(this.x, this.x);
        }
    }
    public int2 xy
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
    public int2 yx
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
    public int2 yy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {
            
            return new(this.y, this.y);
        }
    }
    public int2 rr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {
            
            return new(this.r, this.r);
        }
    }
    public int2 rg
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
    public int2 gr
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
    public int2 gg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {
            
            return new(this.g, this.g);
        }
    }
    public int3 xxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {
            
            
            
            return new(this.x, this.x, this.x);
        }
    }
    public int3 xxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {
            
            
            
            return new(this.x, this.x, this.y);
        }
    }
    public int3 xyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {
            
            
            
            return new(this.x, this.y, this.x);
        }
    }
    public int3 xyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {
            
            
            
            return new(this.x, this.y, this.y);
        }
    }
    public int3 yxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {
            
            
            
            return new(this.y, this.x, this.x);
        }
    }
    public int3 yxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {
            
            
            
            return new(this.y, this.x, this.y);
        }
    }
    public int3 yyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {
            
            
            
            return new(this.y, this.y, this.x);
        }
    }
    public int3 yyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {
            
            
            
            return new(this.y, this.y, this.y);
        }
    }
    public int3 rrr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {
            
            
            
            return new(this.r, this.r, this.r);
        }
    }
    public int3 rrg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {
            
            
            
            return new(this.r, this.r, this.g);
        }
    }
    public int3 rgr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {
            
            
            
            return new(this.r, this.g, this.r);
        }
    }
    public int3 rgg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {
            
            
            
            return new(this.r, this.g, this.g);
        }
    }
    public int3 grr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {
            
            
            
            return new(this.g, this.r, this.r);
        }
    }
    public int3 grg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {
            
            
            
            return new(this.g, this.r, this.g);
        }
    }
    public int3 ggr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {
            
            
            
            return new(this.g, this.g, this.r);
        }
    }
    public int3 ggg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get 
        {
            
            
            
            return new(this.g, this.g, this.g);
        }
    }
    public int4 xxxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            
            
            
            return new(this.x, this.x, this.x, this.x);
        }
    }
    public int4 xxxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            
            
            
            return new(this.x, this.x, this.x, this.y);
        }
    }
    public int4 xxyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            
            
            
            return new(this.x, this.x, this.y, this.x);
        }
    }
    public int4 xxyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            
            
            
            return new(this.x, this.x, this.y, this.y);
        }
    }
    public int4 xyxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            
            
            
            return new(this.x, this.y, this.x, this.x);
        }
    }
    public int4 xyxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            
            
            
            return new(this.x, this.y, this.x, this.y);
        }
    }
    public int4 xyyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            
            
            
            return new(this.x, this.y, this.y, this.x);
        }
    }
    public int4 xyyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            
            
            
            return new(this.x, this.y, this.y, this.y);
        }
    }
    public int4 yxxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            
            
            
            return new(this.y, this.x, this.x, this.x);
        }
    }
    public int4 yxxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            
            
            
            return new(this.y, this.x, this.x, this.y);
        }
    }
    public int4 yxyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            
            
            
            return new(this.y, this.x, this.y, this.x);
        }
    }
    public int4 yxyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            
            
            
            return new(this.y, this.x, this.y, this.y);
        }
    }
    public int4 yyxx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            
            
            
            return new(this.y, this.y, this.x, this.x);
        }
    }
    public int4 yyxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            
            
            
            return new(this.y, this.y, this.x, this.y);
        }
    }
    public int4 yyyx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            
            
            
            return new(this.y, this.y, this.y, this.x);
        }
    }
    public int4 yyyy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            
            
            
            return new(this.y, this.y, this.y, this.y);
        }
    }
    public int4 rrrr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            
            
            
            return new(this.r, this.r, this.r, this.r);
        }
    }
    public int4 rrrg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            
            
            
            return new(this.r, this.r, this.r, this.g);
        }
    }
    public int4 rrgr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            
            
            
            return new(this.r, this.r, this.g, this.r);
        }
    }
    public int4 rrgg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            
            
            
            return new(this.r, this.r, this.g, this.g);
        }
    }
    public int4 rgrr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            
            
            
            return new(this.r, this.g, this.r, this.r);
        }
    }
    public int4 rgrg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            
            
            
            return new(this.r, this.g, this.r, this.g);
        }
    }
    public int4 rggr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            
            
            
            return new(this.r, this.g, this.g, this.r);
        }
    }
    public int4 rggg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            
            
            
            return new(this.r, this.g, this.g, this.g);
        }
    }
    public int4 grrr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            
            
            
            return new(this.g, this.r, this.r, this.r);
        }
    }
    public int4 grrg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            
            
            
            return new(this.g, this.r, this.r, this.g);
        }
    }
    public int4 grgr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            
            
            
            return new(this.g, this.r, this.g, this.r);
        }
    }
    public int4 grgg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            
            
            
            return new(this.g, this.r, this.g, this.g);
        }
    }
    public int4 ggrr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            
            
            
            return new(this.g, this.g, this.r, this.r);
        }
    }
    public int4 ggrg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            
            
            
            return new(this.g, this.g, this.r, this.g);
        }
    }
    public int4 gggr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            
            
            
            return new(this.g, this.g, this.g, this.r);
        }
    }
    public int4 gggg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            
            
            
            return new(this.g, this.g, this.g, this.g);
        }
    }


}
