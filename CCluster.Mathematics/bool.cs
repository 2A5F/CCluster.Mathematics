using System.Runtime.CompilerServices;

namespace CCluster.Mathematics;

public partial struct bool2
{
    public bool AllTrue
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => this.x && this.y;
    }
    
    public bool AllFalse
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => !this.x && !this.y;
    }
    
    public bool AnyTrue
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => this.x || this.y;
    }
    
    public bool AnyFalse
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => !this.x || !this.y;
    }
}

public partial struct bool3
{
    public bool AllTrue
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => this.x && this.y && this.z;
    }
    
    public bool AllFalse
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => !this.x && !this.y && !this.z;
    }
    
    public bool AnyTrue
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => this.x || this.y || this.z;
    }
    
    public bool AnyFalse
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => !this.x || !this.y || !this.z;
    }
}

public partial struct bool4
{
    public bool AllTrue
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => this.x && this.y && this.z && this.w;
    }
    
    public bool AllFalse
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => !this.x && !this.y && !this.z && !this.z;
    }
    
    public bool AnyTrue
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => this.x || this.y || this.z || this.w;
    }
    
    public bool AnyFalse
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => !this.x || !this.y || !this.z || !this.z;
    }
}
