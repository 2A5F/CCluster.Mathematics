using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGen;

public class GenScalarNumbers : Base
{
    private record TypeMeta(string Zero, string One)
    {
        public bool Float { get; set; }
        public bool Decimal { get; set; }
        public bool Unsigned { get; set; }
    }

    private static Dictionary<string, TypeMeta> types = new()
    {
        { "Half", new("Half.Zero", "Half.One") { Float = true, } },
        { "float", new("0f", "1f") { Float = true, } },
        { "double", new("0d", "1d") { Float = true, } },
        { "decimal", new("0m", "1m") { Decimal = true, } },
        { "int", new("0", "1") { } },
        { "uint", new("0u", "1u") { Unsigned = true, } },
        { "long", new("0L", "1L") { } },
        { "ulong", new("0UL", "1UL") { Unsigned = true, } },
    };

    public override async Task Gen()
    {
        foreach (var tm in types)
        {
            var type = tm.Key;
            var meta = tm.Value;

            var source = $@"using System;
using System.Numerics;
using System.Runtime.CompilerServices;

#nullable enable
#pragma warning disable CS8981

namespace CCluster.Mathematics;

public static partial class math
{{
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type} min({type} x, {type} y) => {type}.Min(x, y);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type} max({type} x, {type} y) => {type}.Max(x, y);

{(meta.Float || meta.Decimal ? $@"

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type} lerp({type} s, {type} x, {type} y) => x + s * (y - x);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type} unlerp({type} x, {type} a, {type} b) => (x - a) / (b - a);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type} remap({type} x, {type} a, {type} b, {type} c, {type} d) => lerp(c, d, unlerp(a, b, x));

" : "")}

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type} mad({type} a, {type} b, {type} c) => a * b + c;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type} clamp({type} x, {type} a, {type} b) => max(a, min(b, x));

{(meta.Float || meta.Decimal ? $@"

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type} saturate({type} x) => clamp(x, {meta.Zero}, {meta.One});

" : "")}

{(meta.Unsigned ? "" : $@"

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type} abs({type} x) => {type}.Abs(x);

")}

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type} dot({type} x, {type} y) => x * y;

{(meta.Float ? $@"

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type} tan({type} x) => {type}.Tan(x);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type} tanh({type} x) => {type}.Tanh(x);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type} atan({type} x) => {type}.Atan(x);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type} atanh({type} x) => {type}.Atanh(x);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type} atan2({type} y, {type} x) => {type}.Atan2(y, x);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type} tanPi({type} x) => {type}.TanPi(x);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type} atanPi({type} x) => {type}.AtanPi(x);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type} atan2Pi({type} y, {type} x) => {type}.Atan2Pi(y, x);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type} cos({type} x) => {type}.Cos(x);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type} cosh({type} x) => {type}.Cosh(x);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type} acos({type} x) => {type}.Acos(x);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type} acosh({type} x) => {type}.Acosh(x);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type} cosPi({type} x) => {type}.CosPi(x);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type} acosPi({type} x) => {type}.AcosPi(x);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type} sin({type} x) => {type}.Sin(x);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type} sinh({type} x) => {type}.Sinh(x);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type} asin({type} x) => {type}.Asin(x);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type} asinh({type} x) => {type}.Asinh(x);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type} sinPi({type} x) => {type}.SinPi(x);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type} asinPi({type} x) => {type}.AsinPi(x);

    
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void sincos({type} x, out {type} sin, out {type} cos) => (sin, cos) = {type}.SinCos(x);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static ({type} sin, {type} cos) sincos({type} x) => {type}.SinCos(x);

" : "")}

{(meta.Float || meta.Decimal ? $@"

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type} floor({type} x) => {type}.Floor(x);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type} ceil({type} x) => {type}.Ceiling(x);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type} round({type} x) => {type}.Round(x);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type} trunc({type} x) => {type}.Truncate(x);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type} frac({type} x) => x - floor(x);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type} rcp({type} x) => {meta.One} / x;

" : "")}

{(meta.Unsigned ? "" : $@"

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type} sign({type} x) => (x > {meta.Zero} ? {meta.One} : {meta.Zero}) - (x < {meta.Zero} ? {meta.One} : {meta.Zero});

")}

{(meta.Float ? $@"

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type} pow({type} x, {type} y) => {type}.Pow(x, y);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type} exp({type} x) => {type}.Exp(x);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type} exp2({type} x) => {type}.Exp2(x);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type} exp10({type} x) => {type}.Exp10(x);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type} expM1({type} x) => {type}.ExpM1(x);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type} exp2M1({type} x) => {type}.Exp2M1(x);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type} exp10M1({type} x) => {type}.Exp10M1(x);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type} log({type} x) => {type}.Log(x);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type} log2({type} x) => {type}.Log2(x);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type} log10({type} x) => {type}.Log10(x);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type} logP1({type} x) => {type}.LogP1(x);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type} log2P1({type} x) => {type}.Log2P1(x);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type} log10P1({type} x) => {type}.Log10P1(x);

    
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type} modf({type} x, out {type} i) 
    {{ 
        i = trunc(x);
        return x - i;
    }}

" : "")}

}}
";
            await SaveCode($"{type}.gen.cs", source);
        }
    }
}
