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

[Serializable]
[JsonConverter(typeof(Bool4Converter))]
[StructLayout(LayoutKind.Explicit, Size = 4)]
public unsafe partial struct bool4 : 
    IEquatable<bool4>, IEqualityOperators<bool4, bool4, bool>, IEqualityOperators<bool4, bool4, bool4>,

    IVector, IVector4, IVector<bool>, IVector4<bool>
{

    [FieldOffset(0)]
    public bool x;

    [FieldOffset(1)]
    public bool y;

    [FieldOffset(2)]
    public bool z;

    [FieldOffset(3)]
    public bool w;

    [FieldOffset(0)]
    public bool r;

    [FieldOffset(1)]
    public bool g;

    [FieldOffset(2)]
    public bool b;

    [FieldOffset(3)]
    public bool a;


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

    public static bool4 Zero
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new bool4(false);
    }

    public static bool4 One
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new bool4(true);
    }


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
    public static implicit operator bool4(bool value) => new bool4(value);


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
    public int4 Hash() => new int4(this.x.GetHashCode(), this.y.GetHashCode(), this.z.GetHashCode(), this.w.GetHashCode());

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    static bool4 IEqualityOperators<bool4, bool4, bool4>.operator ==(bool4 left, bool4 right) => new bool4(left.x == right.x, left.y == right.y, left.z == right.z, left.w == right.w);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    static bool4 IEqualityOperators<bool4, bool4, bool4>.operator !=(bool4 left, bool4 right) => new bool4(left.x != right.x, left.y != right.y, left.z != right.z, left.w != right.w);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool4 VEq(bool4 other) => new bool4(this.x == other.x, this.y == other.y, this.z == other.z, this.w == other.w);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool4 VNe(bool4 other) => new bool4(this.x != other.x, this.y != other.y, this.z != other.z, this.w != other.w);





    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override string ToString() => $"bool4({this.x}, {this.y}, {this.z}, {this.w})";

}

public static unsafe partial class math
{

















}

public class Bool4Converter : JsonConverter<bool4>
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
