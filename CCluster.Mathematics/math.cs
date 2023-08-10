using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.Arm;

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

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    internal static int PopCount(this Half val) => BitOperations.PopCount(val.AsInt());

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    internal static int PopCount(this float val) => BitOperations.PopCount(val.AsInt());

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    internal static int PopCount(this double val) => BitOperations.PopCount(val.AsInt());

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    internal static int PopCount(this decimal val)
    {
        if (AdvSimd.Arm64.IsSupported)
            return AdvSimd.Arm64.AddAcross(AdvSimd.PopCount(val.Transmute<decimal, Vector128<byte>>())).ToScalar();
        return (int)UInt128.PopCount(val.AsInt());
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    internal static int PopCount(this int val) => BitOperations.PopCount((uint)val);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    internal static int PopCount(this uint val) => BitOperations.PopCount(val);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    internal static int PopCount(this long val) => BitOperations.PopCount((ulong)val);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    internal static int PopCount(this ulong val) => BitOperations.PopCount(val);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    internal static int PopCount(this bool val) => val ? 1 : 0;
    
    
   
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int pop_cnt(bool x) => x.PopCount();

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int count_bits(bool x) => pop_cnt(x);
}
