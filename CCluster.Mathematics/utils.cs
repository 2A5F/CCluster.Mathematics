using System;
using System.Runtime.CompilerServices;

namespace CCluster.Mathematics;

internal static partial class Utils
{
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    internal static unsafe R Transmute<T, R>(this T val) where T : unmanaged where R : unmanaged
    {
        if (sizeof(T) != sizeof(R)) throw new InvalidOperationException();
        return Unsafe.As<T, R>(ref val);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    internal static ushort AsInt(this Half val) => Transmute<Half, ushort>(val);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    internal static uint AsInt(this float val) => Transmute<float, uint>(val);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    internal static ulong AsInt(this double val) => Transmute<double, ulong>(val);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    internal static UInt128 AsInt(this decimal val) => Transmute<decimal, UInt128>(val);
}
