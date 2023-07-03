using System.Numerics;
using System.Runtime.CompilerServices;

namespace CCluster.Mathematics;

#pragma warning disable CS8981

public static partial class math
{
    
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Vector2 ToVector2(this float2 self) => new(self.x, self.y);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Vector3 ToVector3(this float3 self) => new(self.x, self.y, self.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Vector4 ToVector4(this float4 self) => new(self.x, self.y, self.z, self.w);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float2 ToFloat2(this Vector2 self) => new(self.X, self.Y);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float3 ToFloat3(this Vector3 self) => new(self.X, self.Y, self.Z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float4 ToFloat4(this Vector4 self) => new(self.X, self.Y, self.Z, self.W);
}
