﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGen;

public class GenScalarNumbers : Base
{
    private record TypeMeta(string suffix, string Zero, string One, string Two)
    {
        public bool Half { get; set; }
        public bool Float { get; set; }
        public bool Decimal { get; set; }
        public bool Unsigned { get; set; }

        public int Size { get; set; }
    }

    private static Dictionary<string, TypeMeta> types = new()
    {
        {
            "Half",
            new("", "Half.Zero", "Half.One", "(Half.One + Half.One)")
            {
                Float = true, Half = true, Size = sizeof(ushort),
            }
        },
        {
            "float", new("f", "0f", "1f", "2f")
            {
                Float = true, Size = sizeof(float),
            }
        },
        {
            "double", new("d", "0d", "1d", "2d")
            {
                Float = true, Size = sizeof(double),
            }
        },
        {
            "decimal", new("m", "0m", "1m", "2m")
            {
                Decimal = true, Size = sizeof(decimal),
            }
        },
        {
            "int", new("", "0", "1", "2")
            {
                Size = sizeof(int),
            }
        },
        {
            "uint", new("u", "0u", "1u", "2u")
            {
                Unsigned = true, Size = sizeof(uint),
            }
        },
        {
            "long", new("L", "0L", "1L", "2L")
            {
                Size = sizeof(long),
            }
        },
        {
            "ulong", new("UL", "0UL", "1UL", "2UL")
            {
                Unsigned = true, Size = sizeof(ulong),
            }
        },
    };

    public override async Task Gen()
    {
        foreach (var tm in types)
        {
            var type = tm.Key;
            var meta = tm.Value;

            #region transmutes
            
            var transmutes = new StringBuilder();

            foreach (var ttm in types)
            {
                var t_type = ttm.Key;
                var t_meta = ttm.Value;
                
                if (t_meta.Size != meta.Size) continue;
                if (t_type == type) continue;

                transmutes.Append($@"
    /// <summary>transmute {type} memory to {t_type} memory</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {t_type} as_{t_type}(this {type} val) => val.Transmute<{type}, {t_type}>();

    /// <summary>transmute {type} memory to {t_type} memory</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {t_type} as{t_type}({type} val) => as_{t_type}(val);
");
            }
            
            #endregion

            var source = $@"using System;
using System.Numerics;
using System.Runtime.CompilerServices;

#nullable enable
#pragma warning disable CS8981

namespace CCluster.Mathematics;

public static partial class math
{{
{transmutes}

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type} min({type} x, {type} y) => {type}.Min(x, y);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type} max({type} x, {type} y) => {type}.Max(x, y);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type} min({type} x, {type} y, {type} z) => min(min(x, y), z);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type} max({type} x, {type} y, {type} z) => max(max(x, y), z);

{(meta.Float || meta.Decimal ? $@"

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type} lerp({type} s, {type} x, {type} y) => x + s * (y - x);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type} unlerp({type} x, {type} a, {type} b) => (x - a) / (b - a);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type} remap({type} x, {type} a, {type} b, {type} c, {type} d) => lerp(c, d, unlerp(a, b, x));

" : "" /* meta.Float || meta.Decimal */)}

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type} mad({type} a, {type} b, {type} c) => {(meta.Float ? $"{type}.FusedMultiplyAdd(a, b, c)" : "a * b + c")};

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type} clamp({type} x, {type} a, {type} b) => max(a, min(b, x));

{(meta.Float || meta.Decimal ? $@"

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type} saturate({type} x) => clamp(x, {meta.Zero}, {meta.One});

" : "" /* meta.Float || meta.Decimal */)}

{(meta.Unsigned ? $@"

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type} abs({type} x) => x;

" : $@"

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type} abs({type} x) => {type}.Abs(x);

" /* meta.Unsigned */)}

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type} dot({type} x, {type} y) => x * y;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type} mul({type} a, {type} b) => a * b;

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

" : "" /* meta.Float */)}

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

" : "" /* meta.Float || meta.Decimal */)}

{(meta.Unsigned ? "" : $@"

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type} sign({type} x) => (x > {meta.Zero} ? {meta.One} : {meta.Zero}) - (x < {meta.Zero} ? {meta.One} : {meta.Zero});

" /* meta.Unsigned */)}

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

    
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type} sqrt({type} x) => {type}.Sqrt(x);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type} rsqrt({type} x) => {meta.One} / sqrt(x);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type} normalize({type} x) => rsqrt(dot(x, x)) * x;

    // todo normalizesafe

" : "" /* meta.Float */)}

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type} length({type} x) => abs(x);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type} lengthsq({type} x) => x * x;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type} distance({type} x, {type} y) => abs(y - x);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type} distancesq({type} x, {type} y) => (y - x) * (y - x);

    
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type} select({type} a, {type} b, bool c) => c ? b : a;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type} step({type} y, {type} x) => select({meta.Zero}, {meta.One}, x >= y);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type} reflect({type} i, {type} n) => i - {meta.Two} * n * dot(i, n);

{(meta.Float ? $@"

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type} reflect({type} i, {type} n, {type} eta)
    {{
        var ni = dot(n, i);
        var k = {meta.One} - eta * eta * ({meta.One} - ni * ni);
        return select({meta.Zero}, eta * i - (eta * ni + sqrt(k)) * n, k >= {meta.Zero});
    }}

" : "" /* meta.Float */)}


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type} project({type} a, {type} b) => (dot(a, b) / dot(b, b)) * b;

    // todo projectsafe

{(meta.Float || meta.Decimal ? $@"
    
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type} radians({type} x) => x * {(meta.Half ? "(Half)" : "")}0.0174532925199432957692369076848861271344287188854172545609719144{meta.suffix};

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static {type} degrees({type} x) => x * {(meta.Half ? "(Half)" : "")}57.295779513082320876798154814105170332405472466564321549160243861{meta.suffix};


" : "" /* meta.Float || meta.Decimal */)}
   
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int pop_cnt({type} x) => x.PopCount();

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int count_bits({type} x) => pop_cnt(x);

}} // class math
";
            await SaveCode($"{type}.gen.cs", source);
        }
    }
}
