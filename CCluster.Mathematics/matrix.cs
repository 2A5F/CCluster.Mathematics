using System.Runtime.CompilerServices;
using static CCluster.Mathematics.math;
using static CCluster.Mathematics.vectors;

namespace CCluster.Mathematics;

public partial struct float3x3
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float3x3 Euler(float3 xyz)
    {
        sincos(xyz, out var s, out var c);
        return float3x3(
            c.y * c.z, c.z * s.x * s.y - c.x * s.z, c.x * c.z * s.y + s.x * s.z,
            c.y * s.z, c.x * c.z + s.x * s.y * s.z, c.x * s.y * s.z - c.z * s.x,
            -s.y, c.y * s.x, c.x * c.y
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float3x3 Euler(float x, float y, float z) => Euler(new float3(x, y, z));

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float3x3 RotateX(float angle)
    {
        // {{1, 0, 0}, {0, c_0, -s_0}, {0, s_0, c_0}}
        sincos(angle, out var s, out var c);
        return float3x3(
            1.0f, 0.0f, 0.0f,
            0.0f, c, -s,
            0.0f, s, c
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float3x3 RotateY(float angle)
    {
        // {{c_1, 0, s_1}, {0, 1, 0}, {-s_1, 0, c_1}}
        sincos(angle, out var s, out var c);
        return float3x3(
            c, 0.0f, s,
            0.0f, 1.0f, 0.0f,
            -s, 0.0f, c
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float3x3 RotateZ(float angle)
    {
        // {{c_2, -s_2, 0}, {s_2, c_2, 0}, {0, 0, 1}}
        sincos(angle, out var s, out var c);
        return float3x3(
            c, -s, 0.0f,
            s, c, 0.0f,
            0.0f, 0.0f, 1.0f
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float3x3 Scale(float s) => float3x3(
        s, 0.0f, 0.0f,
        0.0f, s, 0.0f,
        0.0f, 0.0f, s
    );

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float3x3 Scale(float x, float y, float z) => float3x3(
        x, 0.0f, 0.0f,
        0.0f, y, 0.0f,
        0.0f, 0.0f, z
    );

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float3x3 Scale(float3 v) => float3x3(
        v.x, 0.0f, 0.0f,
        0.0f, v.y, 0.0f,
        0.0f, 0.0f, v.z
    );

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float3x3 LookRotation(float3 forward, float3 up)
    {
        var t = normalize(cross(up, forward));
        return float3x3(t, cross(forward, t), forward);
    }
}
