using System;
using System.Numerics;
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.X86;
using System.Runtime.Intrinsics.Arm;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Serialization;

#nullable enable
#pragma warning disable CS8981

namespace CCluster.Mathematics;

/// <summary>A 4 component vector of bool</summary>
[Serializable]
[JsonConverter(typeof(Bool4JsonConverter))]
[StructLayout(LayoutKind.Explicit, Size = 4)]
public unsafe partial struct bool4 : 
    IEquatable<bool4>, IEqualityOperators<bool4, bool4, bool>, IEqualityOperators<bool4, bool4, bool4>,

    IVector4<bool>, IVectorSelf<bool4>
{    
    //////////////////////////////////////////////////////////////////////////////////////////////////// Fields

    #region Fields

    /// <summary>X component of the vector</summary>
    [FieldOffset(0)]
    public bool x;

    /// <summary>Y component of the vector</summary>
    [FieldOffset(1)]
    public bool y;

    /// <summary>Z component of the vector</summary>
    [FieldOffset(2)]
    public bool z;

    /// <summary>W component of the vector</summary>
    [FieldOffset(3)]
    public bool w;


    /// <summary>R component of the vector</summary>
    [FieldOffset(0)]
    public bool r;

    /// <summary>G component of the vector</summary>
    [FieldOffset(1)]
    public bool g;

    /// <summary>B component of the vector</summary>
    [FieldOffset(2)]
    public bool b;

    /// <summary>A component of the vector</summary>
    [FieldOffset(3)]
    public bool a;

    #endregion

    //////////////////////////////////////////////////////////////////////////////////////////////////// Constants

    #region Constants

    public static int ByteSize 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => 4;
    }

    public static int BitSize 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => 32;
    }

    public static readonly bool4 zero = new(false);

    public static readonly bool4 one = new(true);

    static bool4 IVectorSelf<bool4>.Zero 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => zero;
    }

    static bool4 IVectorSelf<bool4>.One 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => one;
    }

    #endregion

    //////////////////////////////////////////////////////////////////////////////////////////////////// Ctor

    #region Ctor

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool4(bool value) : this(value, value, value, value) { }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool4(bool x, bool y, bool z, bool w)
    {
        this.x = x;

        this.y = y;

        this.z = z;

        this.w = w;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool4(bool2 xy, bool2 zw) : this(xy.x, xy.y, zw.x, zw.y) { }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool4(bool2 xy, bool z, bool w) : this(xy.x, xy.y, z, w) { }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool4(bool x, bool2 yz, bool w) : this(x, yz.x, yz.y, w) { }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool4(bool x, bool y, bool2 zw) : this(x, y, zw.x, zw.y) { }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool4(bool3 xyz, bool w) : this(xyz.x, xyz.y, xyz.z, w) { }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool4(bool x, bool3 yzw) : this(x, yzw.x, yzw.y, yzw.z) { }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator bool4(bool value) => new(value);

    #endregion

    //////////////////////////////////////////////////////////////////////////////////////////////////// Equals

    #region Equals


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool Equals(bool4 other) => this.x == other.x && this.y == other.y && this.z == other.z && this.w == other.w;


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override bool Equals(object? o) => o is bool4 other && Equals(other);



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator ==(bool4 left, bool4 right) => left.x == right.x && left.y == right.y && left.z == right.z && left.w == right.w;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator !=(bool4 left, bool4 right) => left.x != right.x || left.y != right.y || left.z != right.z || left.w != right.w;



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override int GetHashCode() => HashCode.Combine(this.x, this.y, this.z, this.w);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public int4 Hash() => new(this.x.GetHashCode(), this.y.GetHashCode(), this.z.GetHashCode(), this.w.GetHashCode());

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    static bool4 IEqualityOperators<bool4, bool4, bool4>.operator ==(bool4 left, bool4 right) => new(left.x == right.x, left.y == right.y, left.z == right.z, left.w == right.w);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    static bool4 IEqualityOperators<bool4, bool4, bool4>.operator !=(bool4 left, bool4 right) => new(left.x != right.x, left.y != right.y, left.z != right.z, left.w != right.w);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool4 VEq(bool4 other) => new(this.x == other.x, this.y == other.y, this.z == other.z, this.w == other.w);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool4 VNe(bool4 other) => new(this.x != other.x, this.y != other.y, this.z != other.z, this.w != other.w);

    #endregion




    //////////////////////////////////////////////////////////////////////////////////////////////////// ToString

    #region ToString

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override string ToString() => $"bool4({this.x}, {this.y}, {this.z}, {this.w})";

    #endregion
}

public static unsafe partial class math
{

















}

public class Bool4JsonConverter : JsonConverter<bool4>
{
    public override bool4 Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        Unsafe.SkipInit(out bool4 result);
        if (reader.TokenType is not JsonTokenType.StartArray) throw new JsonException();
        reader.Read();
        result.x = reader.GetBoolean();
        reader.Read();
        result.y = reader.GetBoolean();
        reader.Read();
        result.z = reader.GetBoolean();
        reader.Read();
        result.w = reader.GetBoolean();
        reader.Read();
        if (reader.TokenType is not JsonTokenType.EndArray) throw new JsonException();
        return result;
    }

    public override void Write(Utf8JsonWriter writer, bool4 value, JsonSerializerOptions options)
    {
        writer.WriteStartArray();
        writer.WriteBooleanValue(value.x);
        writer.WriteBooleanValue(value.y);
        writer.WriteBooleanValue(value.z);
        writer.WriteBooleanValue(value.w);
        writer.WriteEndArray();
    }
}
