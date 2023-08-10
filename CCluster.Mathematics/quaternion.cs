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
        public quaternion(float3x3 m)
        {
            var u = m.c0;
            var v = m.c1;
            var w = m.c2;

            var u_sign = asuint(u.x) & 0x80000000;
            var t = v.y + asfloat(asuint(w.z) ^ u_sign);
            var u_mask = uint4((uint)((int)u_sign >> 31));
            var t_mask = uint4((uint)(asint(t) >> 31));

            var tr = 1.0f + abs(u.x);

            var sign_flips = uint4(0x00000000, 0x80000000, 0x80000000, 0x80000000)
                             ^ (u_mask & uint4(0x00000000, 0x80000000, 0x00000000, 0x80000000))
                             ^ (t_mask & uint4(0x80000000, 0x80000000, 0x80000000, 0x00000000));

            value = float4(tr, u.y, w.x, v.z) + asfloat(asuint(float4(t, v.x, u.z, w.y)) ^ sign_flips);

            value = asfloat((asuint(value) & ~u_mask) | (asuint(value.zwxy) & u_mask));
            value = asfloat((asuint(value.wzyx) & ~t_mask) | (asuint(value) & t_mask));
            value = normalize(value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override string ToString() =>
            $"quaternion({this.value.x}f, {this.value.y}f, {this.value.z}f, {this.value.w}f)";

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
