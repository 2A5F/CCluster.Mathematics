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

/// <summary>A 3 component vector of int, with no aligned</summary>
[Serializable]
[JsonConverter(typeof(Int3AJsonConverter))]
[StructLayout(LayoutKind.Explicit, Size = 12)]
public unsafe partial struct int3a : 
    IEquatable<int3a>, IEqualityOperators<int3a, int3a, bool>, IEqualityOperators<int3a, int3a, bool3a>,

    IAdditionOperators<int3a, int3a, int3a>, IAdditiveIdentity<int3a, int3a>, IUnaryPlusOperators<int3a, int3a>,
    ISubtractionOperators<int3a, int3a, int3a>, IUnaryNegationOperators<int3a, int3a>,
    IMultiplyOperators<int3a, int3a, int3a>, IMultiplicativeIdentity<int3a, int3a>,
    IDivisionOperators<int3a, int3a, int3a>,
    IModulusOperators<int3a, int3a, int3a>,

    IVector3<int>, IVectorSelf<int3a>
{

    /// <summary>X component of the vector</summary>
    [FieldOffset(0)]
    public int x;

    /// <summary>Y component of the vector</summary>
    [FieldOffset(4)]
    public int y;

    /// <summary>Z component of the vector</summary>
    [FieldOffset(8)]
    public int z;


    /// <summary>R component of the vector</summary>
    [FieldOffset(0)]
    public int r;

    /// <summary>G component of the vector</summary>
    [FieldOffset(4)]
    public int g;

    /// <summary>B component of the vector</summary>
    [FieldOffset(8)]
    public int b;


    public static int ByteSize 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => 12;
    }

    public static int BitSize 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => 96;
    }

    public static readonly int3a zero = new(0);

    public static readonly int3a one = new(1);

    static int3a IVectorSelf<int3a>.Zero 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => zero;
    }

    static int3a IVectorSelf<int3a>.One 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => one;
    }


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public int3a(int value) : this(value, value, value) { }


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public int3a(int x, int y, int z)
    {

        this.x = x;

        this.y = y;

        this.z = z;

    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator int3a(int value) => new(value);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool Equals(int3a other) => this.x == other.x && this.y == other.y && this.z == other.z;


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override bool Equals(object? o) => o is int3a other && Equals(other);



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator ==(int3a left, int3a right) => left.x == right.x && left.y == right.y && left.z == right.z;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator !=(int3a left, int3a right) => left.x != right.x || left.y != right.y || left.z != right.z;



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override int GetHashCode() => HashCode.Combine(this.x, this.y, this.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public int3a Hash() => new(this.x.GetHashCode(), this.y.GetHashCode(), this.z.GetHashCode());

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    static bool3a IEqualityOperators<int3a, int3a, bool3a>.operator ==(int3a left, int3a right) => new(left.x == right.x, left.y == right.y, left.z == right.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    static bool3a IEqualityOperators<int3a, int3a, bool3a>.operator !=(int3a left, int3a right) => new(left.x != right.x, left.y != right.y, left.z != right.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool3a VEq(int3a other) => new(this.x == other.x, this.y == other.y, this.z == other.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool3a VNe(int3a other) => new(this.x != other.x, this.y != other.y, this.z != other.z);



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool3a operator >(int3a left, int3a right) => new(left.x > right.x, left.y > right.y, left.z > right.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool3a operator <(int3a left, int3a right) => new(left.x < right.x, left.y < right.y, left.z < right.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool3a operator >=(int3a left, int3a right) => new(left.x >= right.x, left.y >= right.y, left.z >= right.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool3a operator <=(int3a left, int3a right) => new(left.x <= right.x, left.y <= right.y, left.z <= right.z);




    public static int3a AdditiveIdentity 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(0);
    }

    public static int3a MultiplicativeIdentity 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new(1);
    }



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int3a operator +(int3a left, int3a right) => new(left.x + right.x, left.y + right.y, left.z + right.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int3a operator -(int3a left, int3a right) => new(left.x - right.x, left.y - right.y, left.z - right.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int3a operator *(int3a left, int3a right) => new(left.x * right.x, left.y * right.y, left.z * right.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int3a operator /(int3a left, int3a right) => new(left.x / right.x, left.y / right.y, left.z / right.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int3a operator %(int3a left, int3a right) => new(left.x % right.x, left.y % right.y, left.z % right.z);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int3a operator +(int3a left, int right) => new(left.x + right, left.y + right, left.z + right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int3a operator -(int3a left, int right) => new(left.x - right, left.y - right, left.z - right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int3a operator *(int3a left, int right) => new(left.x * right, left.y * right, left.z * right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int3a operator /(int3a left, int right) => new(left.x / right, left.y / right, left.z / right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int3a operator %(int3a left, int right) => new(left.x % right, left.y % right, left.z % right);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int3a operator +(int left, int3a right) => new(left + right.x, left + right.y, left + right.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int3a operator -(int left, int3a right) => new(left - right.x, left - right.y, left - right.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int3a operator *(int left, int3a right) => new(left * right.x, left * right.y, left * right.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int3a operator /(int left, int3a right) => new(left / right.x, left / right.y, left / right.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int3a operator %(int left, int3a right) => new(left % right.x, left % right.y, left % right.z);


    
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int3a operator -(int3a self) => new(-self.x, -self.y, -self.z);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int3a operator +(int3a self) => new(+self.x, +self.y, +self.z);





    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override string ToString() => $"int3a({this.x}, {this.y}, {this.z})";

}

public static unsafe partial class math
{



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int3a min(int3a x, int3a y) => new(min(x.x, y.x), min(x.y, y.y), min(x.z, y.z));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int3a max(int3a x, int3a y) => new(max(x.x, y.x), max(x.y, y.y), max(x.z, y.z));



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int3a mad(int3a a, int3a b, int3a c) => a * b + c;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int3a clamp(int3a x, int3a a, int3a b) => max(a, min(b, x));





    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int3a abs(int3a x) => new(abs(x.x), abs(x.y), abs(x.z));




    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int3a cross(int3a x, int3a y) => (x * y.yzx - x.yzx * y).yzx;




    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int dot(int3a x, int3a y) => x.x * y.x + x.y * y.y + x.z * y.z;










    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int3a sign(int3a x) => new(sign(x.x), sign(x.y), sign(x.z));







    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int3a lengthsq(int3a x) => dot(x, x);







    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int3a distancesq(int3a x, int3a y) => lengthsq(y - x);

    
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int3a select(int3a a, int3a b, bool c) => c ? b : a;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int3a select(int3a a, int3a b, bool3a c) => new(c.x ? b.x : a.x, c.y ? b.y : a.y, c.z ? b.z : a.z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int3a step(int3a y, int3a x) => select(new int3a(0), new int3a(1), x >= y);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int3a reflect(int3a i, int3a n) => i - 2 * n * dot(i, n);




    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int3a project(int3a a, int3a b) => (dot(a, b) / dot(b, b)) * b;

    // todo projectsafe




    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int3a faceforward(int3a n, int3a i, int3a ng) => select(n, -n, dot(ng, i) >= 0);







}

public class Int3AJsonConverter : JsonConverter<int3a>
{
    public override int3a Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        Unsafe.SkipInit(out int3a result);
        if (reader.TokenType is not JsonTokenType.StartArray) throw new JsonException();
        reader.Read();
        result.x = reader.GetInt32();
        reader.Read();
        result.y = reader.GetInt32();
        reader.Read();
        result.z = reader.GetInt32();
        reader.Read();
        if (reader.TokenType is not JsonTokenType.EndArray) throw new JsonException();
        return result;
    }

    public override void Write(Utf8JsonWriter writer, int3a value, JsonSerializerOptions options)
    {
        writer.WriteStartArray();
        writer.WriteNumberValue(value.x);
        writer.WriteNumberValue(value.y);
        writer.WriteNumberValue(value.z);
        writer.WriteEndArray();
    }
}
