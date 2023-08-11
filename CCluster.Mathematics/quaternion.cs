using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics;
using System.Text.Json;
using System.Text.Json.Serialization;
using CCluster.Mathematics.Json;
using static CCluster.Mathematics.math;
using static CCluster.Mathematics.vectors;

#pragma warning disable CS8981

namespace CCluster.Mathematics
{

    /// <summary>A quaternion type for representing rotations</summary>
    [Serializable]
    [JsonConverter(typeof(QuaternionConverter))]
    public struct quaternion : IEquatable<quaternion>, IEqualityOperators<quaternion, quaternion, bool>
    {
        /// <summary>The quaternion component values</summary>
        public float4 value;

        /// <summary>A quaternion representing the identity transform</summary>
        public static readonly quaternion identity = new(0.0f, 0.0f, 0.0f, 1.0f);

        public static readonly quaternion zero = new(new float4(0f));

        public static readonly quaternion one = new(new float4(1f));

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public quaternion(float x, float y, float z, float w)
        {
            this.value.vector = Vector128.Create(x, y, z, w);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public quaternion(float4 value)
        {
            this.value.vector = value.vector;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static implicit operator quaternion(float4 v) => new(v);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public unsafe quaternion(float3x3 m)
        {
            var u = m.c0.vector;
            var v = m.c1.vector;
            var w = m.c2.vector;

            var u_sign = ((uint*)&u)[0] & 0x80000000;
            var tmp1 = ((uint*)&w)[2] ^ u_sign;
            var t = v[1] + *(float*)&tmp1;
            var u_mask = Vector128.Create((uint)((int)u_sign >> 31));
            var t_mask = Vector128.Create((uint)(*(int*)&t >> 31));

            var tr = 1.0f + abs(u[0]);

            var sign_flips = Vector128.Create(0x00000000, 0x80000000, 0x80000000, 0x80000000)
                             ^ (u_mask & Vector128.Create(0x00000000, 0x80000000, 0x00000000, 0x80000000))
                             ^ (t_mask & Vector128.Create(0x80000000, 0x80000000, 0x80000000, 0x00000000));

            var value = Vector128.Create(tr, u[1], w[0], v[2]) +
                        (Vector128.Create(t, v[0], u[2], w[1]).As<float, uint>() ^ sign_flips).As<uint, float>();

            var zwxy = Vector128.Shuffle(value, Vector128.Create(2, 3, 0, 1));
            var wzyx = Vector128.Shuffle(value, Vector128.Create(3, 2, 1, 0));

            value = ((value.As<float, uint>() & ~u_mask) | (zwxy.As<float, uint>() & u_mask)).As<uint, float>();
            value = ((wzyx.As<float, uint>() & ~t_mask) | (value.As<float, uint>() & t_mask)).As<uint, float>();

            value = 1f / float.Sqrt(Vector128.Dot(value, value)) * value;

            this.value = new(value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public unsafe quaternion(float4x4 m)
        {
            var u = m.c0.vector;
            var v = m.c1.vector;
            var w = m.c2.vector;

            var u_sign = ((uint*)&u)[0] & 0x80000000;
            var tmp1 = ((uint*)&w)[2] ^ u_sign;
            var t = v[1] + *(float*)&tmp1;
            var u_mask = Vector128.Create((uint)((int)u_sign >> 31));
            var t_mask = Vector128.Create((uint)(*(int*)&t >> 31));

            var tr = 1.0f + abs(u[0]);

            var sign_flips = Vector128.Create(0x00000000, 0x80000000, 0x80000000, 0x80000000)
                             ^ (u_mask & Vector128.Create(0x00000000, 0x80000000, 0x00000000, 0x80000000))
                             ^ (t_mask & Vector128.Create(0x80000000, 0x80000000, 0x80000000, 0x00000000));

            var value = Vector128.Create(tr, u[1], w[0], v[2]) +
                        (Vector128.Create(t, v[0], u[2], w[1]).As<float, uint>() ^ sign_flips).As<uint, float>();

            var zwxy = Vector128.Shuffle(value, Vector128.Create(2, 3, 0, 1));
            var wzyx = Vector128.Shuffle(value, Vector128.Create(3, 2, 1, 0));

            value = ((value.As<float, uint>() & ~u_mask) | (zwxy.As<float, uint>() & u_mask)).As<uint, float>();
            value = ((wzyx.As<float, uint>() & ~t_mask) | (value.As<float, uint>() & t_mask)).As<uint, float>();

            value = 1f / float.Sqrt(Vector128.Dot(value, value)) * value;

            this.value = new(value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static quaternion AxisAngle(float3 axis, float angle)
        {
            sincos(0.5f * angle, out var sina, out var cosa);
            return new quaternion(float4(axis * sina, cosa));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public quaternion(float3 xyz) => this = Euler(xyz);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static quaternion Euler(float3 xyz)
        {
            // return mul(rotateZ(xyz.z), mul(rotateY(xyz.y), rotateX(xyz.x)));
            sincos(0.5f * xyz, out var s, out var c);
            return new quaternion(
                // s.x * c.y * c.z - s.y * s.z * c.x,
                // s.y * c.x * c.z + s.x * s.z * c.y,
                // s.z * c.x * c.y - s.x * s.y * c.z,
                // c.x * c.y * c.z + s.y * s.z * s.x
                float4(s.xyz, c.x) * c.yxxy * c.zzyz +
                s.yxxy * s.zzyz * float4(c.xyz, s.x) * float4(-1.0f, 1.0f, -1.0f, 1.0f)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static quaternion Euler(float x, float y, float z) => Euler(new float3(x, y, z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static quaternion RotateX(float angle)
        {
            sincos(0.5f * angle, out var sina, out var cosa);
            return quaternion(sina, 0.0f, 0.0f, cosa);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static quaternion RotateY(float angle)
        {
            sincos(0.5f * angle, out var sina, out var cosa);
            return quaternion(0.0f, sina, 0.0f, cosa);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static quaternion RotateZ(float angle)
        {
            sincos(0.5f * angle, out var sina, out var cosa);
            return quaternion(0.0f, 0.0f, sina, cosa);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static quaternion LookRotation(float3 forward, float3 up)
        {
            var t = normalize(cross(up, forward));
            return quaternion(float3x3(t, cross(forward, t), forward));
        }

        #region Equals

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(quaternion other) => value.Equals(other.value);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override bool Equals(object? obj) => obj is quaternion other && Equals(other);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override int GetHashCode() => value.GetHashCode();

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(quaternion left, quaternion right) => left.Equals(right);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(quaternion left, quaternion right) => !left.Equals(right);

        #endregion

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override string ToString() =>
            $"quaternion({this.value.x}f, {this.value.y}f, {this.value.z}f, {this.value.w}f)";
    }

    public partial struct float3x3
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public float3x3(quaternion q) => this = FromQuaternion(q.value.vector);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static float3x3 FromQuaternion(in Vector128<float> v)
        {
            var v2 = v + v;

            var npn = Vector128.Create(0x80000000, 0x00000000, 0x80000000, 0);
            var nnp = Vector128.Create(0x80000000, 0x80000000, 0x00000000, 0);
            var pnn = Vector128.Create(0x00000000, 0x80000000, 0x80000000, 0);

            var yxw = Vector128.Shuffle(v, Vector128.Create(1, 0, 3, 0));
            var zwx = Vector128.Shuffle(v, Vector128.Create(2, 3, 0, 0));
            var wzy = Vector128.Shuffle(v, Vector128.Create(3, 2, 1, 0));

            var c0 =
                v2[1] * (yxw.AsUInt32() ^ npn).AsSingle()
                - v2[2] * (zwx.AsUInt32() ^ pnn).AsSingle()
                + Vector128.Create(1f, 0, 0, 0);
            var c1 =
                v2[2] * (wzy.AsUInt32() ^ nnp).AsSingle()
                - v2[0] * (yxw.AsUInt32() ^ npn).AsSingle()
                + Vector128.Create(0f, 1, 0, 0);
            var c2 =
                v2[0] * (zwx.AsUInt32() ^ pnn).AsSingle()
                - v2[1] * (wzy.AsUInt32() ^ nnp).AsSingle()
                + Vector128.Create(0f, 0, 1, 0);

            Unsafe.SkipInit(out float3x3 self);
            self.c0.vector = c0;
            self.c1.vector = c1;
            self.c2.vector = c2;
            return self;
        }
    }

    public static partial class vectors
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static quaternion quaternion(float x, float y, float z, float w) => new quaternion(x, y, z, w);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static quaternion quaternion(float4 value) => new quaternion(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static quaternion quaternion(float3x3 m) => new quaternion(m);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static quaternion quaternion(float4x4 m) => new quaternion(m);
    }

    public static partial class math
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static float dot(quaternion a, quaternion b) => dot(a.value, b.value);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static float length(quaternion q) => sqrt(dot(q.value, q.value));

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static float lengthsq(quaternion q) => dot(q.value, q.value);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static quaternion normalize(quaternion q) => new(rsqrt(dot(q.value, q.value)) * q.value);


        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static quaternion mul(quaternion a, quaternion b)
        {
            return new(
                a.value.wwww * b.value +
                (a.value.xyzx * b.value.wwwx + a.value.yzxy * b.value.zxyy) *
                float4(1.0f, 1.0f, 1.0f, -1.0f) -
                a.value.zxyz * b.value.yzxz
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 mul(quaternion q, float3 v)
        {
            var t = 2 * cross(q.value.xyz, v);
            return v + q.value.w * t + cross(q.value.xyz, t);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 rotate(quaternion q, float3 v)
        {
            var t = 2 * cross(q.value.xyz, v);
            return v + q.value.w * t + cross(q.value.xyz, t);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static quaternion nlerp(quaternion q1, quaternion q2, float t)
        {
            var dt = dot(q1, q2);
            if (dt < 0.0f)
            {
                q2.value = -q2.value;
            }

            return normalize(quaternion(lerp(q1.value, q2.value, t)));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static quaternion slerp(quaternion q1, quaternion q2, float t)
        {
            float dt = dot(q1, q2);
            if (dt < 0.0f)
            {
                dt = -dt;
                q2.value = -q2.value;
            }

            if (dt < 0.9995f)
            {
                float angle = acos(dt);
                float s = rsqrt(1.0f - dt * dt); // 1.0f / sin(angle)
                float w1 = sin(angle * (1.0f - t)) * s;
                float w2 = sin(angle * t) * s;
                return quaternion(q1.value * w1 + q2.value * w2);
            }
            else
            {
                // if the angle is small, use linear interpolation
                return nlerp(q1, q2, t);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 forward(quaternion q) => mul(q, float3(0, 0, 1));
    }

    namespace Json
    {

        public class QuaternionConverter : JsonConverter<quaternion>
        {
            private static readonly Type v_type = typeof(float4);

            public override quaternion Read(ref Utf8JsonReader reader, Type typeToConvert,
                JsonSerializerOptions options)
            {
                Unsafe.SkipInit(out quaternion result);
                var conv = (JsonConverter<float4>)options.GetConverter(v_type);
                result.value = conv.Read(ref reader, v_type, options);
                return result;
            }

            public override void Write(Utf8JsonWriter writer, quaternion value, JsonSerializerOptions options)
            {
                var conv = (JsonConverter<float4>)options.GetConverter(v_type);
                conv.Write(writer, value.value, options);
            }
        }

    }

}
