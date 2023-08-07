using System;
using System.Numerics;
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.X86;
using System.Runtime.Intrinsics.Arm;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

#nullable enable
#pragma warning disable CS8981

namespace CCluster.Mathematics;

[Serializable]
[StructLayout(LayoutKind.Explicit, Size = 32)]
public unsafe partial struct decimal2a : 
    IEquatable<decimal2a>, IEqualityOperators<decimal2a, decimal2a, bool>, IEqualityOperators<decimal2a, decimal2a, bool2>,

    IAdditionOperators<decimal2a, decimal2a, decimal2a>, IAdditiveIdentity<decimal2a, decimal2a>, IUnaryPlusOperators<decimal2a, decimal2a>,
    ISubtractionOperators<decimal2a, decimal2a, decimal2a>, IUnaryNegationOperators<decimal2a, decimal2a>,
    IMultiplyOperators<decimal2a, decimal2a, decimal2a>, IMultiplicativeIdentity<decimal2a, decimal2a>,
    IDivisionOperators<decimal2a, decimal2a, decimal2a>,
    IModulusOperators<decimal2a, decimal2a, decimal2a>,

    IVector, IVector2, IVector<decimal>, IVector2<decimal>
{

    [FieldOffset(0)]
    public decimal x;

    [FieldOffset(16)]
    public decimal y;

    [FieldOffset(0)]
    public decimal r;

    [FieldOffset(16)]
    public decimal g;


    public static int ByteSize 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => 32;
    }

    public static int BitSize 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => 256;
    }

    public static decimal2a Zero
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal2a(0m);
    }

    public static decimal2a One
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal2a(1m);
    }


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public decimal2a(decimal value) : this(value, value) { }


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public decimal2a(decimal x, decimal y)
    {

        this.x = x;

        this.y = y;

    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator decimal2a(decimal value) => new decimal2a(value);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool Equals(decimal2a other) => this.x == other.x && this.y == other.y;


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override bool Equals(object? o) => o is decimal2a other && Equals(other);



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator ==(decimal2a left, decimal2a right) => left.x == right.x && left.y == right.y;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator !=(decimal2a left, decimal2a right) => left.x != right.x || left.y != right.y;



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override int GetHashCode() => HashCode.Combine(this.x, this.y);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public int2 Hash() => new int2(this.x.GetHashCode(), this.y.GetHashCode());

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    static bool2 IEqualityOperators<decimal2a, decimal2a, bool2>.operator ==(decimal2a left, decimal2a right) => new bool2(left.x == right.x, left.y == right.y);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    static bool2 IEqualityOperators<decimal2a, decimal2a, bool2>.operator !=(decimal2a left, decimal2a right) => new bool2(left.x != right.x, left.y != right.y);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool2 VEq(decimal2a other) => new bool2(this.x == other.x, this.y == other.y);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool2 VNe(decimal2a other) => new bool2(this.x != other.x, this.y != other.y);



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool2 operator >(decimal2a left, decimal2a right) => new bool2(left.x > right.x, left.y > right.y);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool2 operator <(decimal2a left, decimal2a right) => new bool2(left.x < right.x, left.y < right.y);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool2 operator >=(decimal2a left, decimal2a right) => new bool2(left.x >= right.x, left.y >= right.y);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool2 operator <=(decimal2a left, decimal2a right) => new bool2(left.x <= right.x, left.y <= right.y);




    public static decimal2a AdditiveIdentity 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal2a(0m);
    }

    public static decimal2a MultiplicativeIdentity 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => new decimal2a(1m);
    }



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal2a operator +(decimal2a left, decimal2a right) => new decimal2a(left.x + right.x, left.y + right.y);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal2a operator -(decimal2a left, decimal2a right) => new decimal2a(left.x - right.x, left.y - right.y);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal2a operator *(decimal2a left, decimal2a right) => new decimal2a(left.x * right.x, left.y * right.y);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal2a operator /(decimal2a left, decimal2a right) => new decimal2a(left.x / right.x, left.y / right.y);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal2a operator %(decimal2a left, decimal2a right) => new decimal2a(left.x % right.x, left.y % right.y);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal2a operator +(decimal2a left, decimal right) => new decimal2a(left.x + right, left.y + right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal2a operator -(decimal2a left, decimal right) => new decimal2a(left.x - right, left.y - right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal2a operator *(decimal2a left, decimal right) => new decimal2a(left.x * right, left.y * right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal2a operator /(decimal2a left, decimal right) => new decimal2a(left.x / right, left.y / right);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal2a operator %(decimal2a left, decimal right) => new decimal2a(left.x % right, left.y % right);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal2a operator +(decimal left, decimal2a right) => new decimal2a(left + right.x, left + right.y);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal2a operator -(decimal left, decimal2a right) => new decimal2a(left - right.x, left - right.y);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal2a operator *(decimal left, decimal2a right) => new decimal2a(left * right.x, left * right.y);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal2a operator /(decimal left, decimal2a right) => new decimal2a(left / right.x, left / right.y);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal2a operator %(decimal left, decimal2a right) => new decimal2a(left % right.x, left % right.y);


    
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal2a operator -(decimal2a self) => new decimal2a(-self.x, -self.y);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal2a operator +(decimal2a self) => new decimal2a(+self.x, +self.y);





    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override string ToString() => $"decimal2a({this.x}, {this.y})";

}

public static unsafe partial class math
{



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal2a min(decimal2a x, decimal2a y) => new decimal2a(min(x.x, y.x), min(x.y, y.y));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal2a max(decimal2a x, decimal2a y) => new decimal2a(max(x.x, y.x), max(x.y, y.y));



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal2a lerp(decimal2a s, decimal2a x, decimal2a y) => x + s * (y - x);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal2a unlerp(decimal2a x, decimal2a a, decimal2a b) => (x - a) / (b - a);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal2a remap(decimal2a x, decimal2a a, decimal2a b, decimal2a c, decimal2a d) => lerp(c, d, unlerp(a, b, x));



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal2a mad(decimal2a a, decimal2a b, decimal2a c) => a * b + c;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal2a clamp(decimal2a x, decimal2a a, decimal2a b) => max(a, min(b, x));



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal2a saturate(decimal2a x) => clamp(x, decimal2a.Zero, decimal2a.One);





    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal2a abs(decimal2a x) => new decimal2a(abs(x.x), abs(x.y));







    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal dot(decimal2a x, decimal2a y) => x.x * y.x + x.y * y.y;










    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal2a floor(decimal2a x) => new decimal2a(floor(x.x), floor(x.y));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal2a ceil(decimal2a x) => new decimal2a(ceil(x.x), ceil(x.y));



    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal2a round(decimal2a x) => new decimal2a(round(x.x), round(x.y));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal2a trunc(decimal2a x) => new decimal2a(trunc(x.x), trunc(x.y));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal2a frac(decimal2a x) => x - floor(x);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal2a rcp(decimal2a x) => 1m / x;





    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal2a sign(decimal2a x) => new decimal2a(sign(x.x), sign(x.y));







    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal2a lengthsq(decimal2a x) => dot(x, x);







    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal2a distancesq(decimal2a x, decimal2a y) => lengthsq(y - x);

    
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal2a select(decimal2a a, decimal2a b, bool c) => c ? b : a;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal2a select(decimal2a a, decimal2a b, bool2 c) => new decimal2a(c.x ? b.x : a.x, c.y ? b.y : a.y);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal2a step(decimal2a y, decimal2a x) => select(new decimal2a(0m), new decimal2a(1m), x >= y);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal2a reflect(decimal2a i, decimal2a n) => i - 2m * n * dot(i, n);




    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal2a project(decimal2a a, decimal2a b) => (dot(a, b) / dot(b, b)) * b;

    // todo projectsafe




    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal2a faceforward(decimal2a n, decimal2a i, decimal2a ng) => select(n, -n, dot(ng, i) >= 0m);




    
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal2a radians(decimal2a x) => x * 0.0174532925199432957692369076848861271344287188854172545609719144m;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static decimal2a degrees(decimal2a x) => x * 57.295779513082320876798154814105170332405472466564321549160243861m;






}
