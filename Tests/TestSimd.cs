using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.X86;
using CCluster.Mathematics;

namespace Tests;

public class TestSimd
{
    [SetUp]
    public void Setup() { }

    [Test]
    [MethodImpl(MethodImplOptions.AggressiveOptimization)]
    public void TestMAD()
    {
        {
            var a = new float3(3, 3, 3);
            var b = new float3(2, 2, 2);
            var c = new float3(4, 4, 4);
            var r = math.mad(a, b, c);
            Console.WriteLine($"{r}");
            Assert.That(r, Is.EqualTo(new float3(10, 10, 10)));
        }
        {
            var a = new double3(3, 3, 3);
            var b = new double3(2, 2, 2);
            var c = new double3(4, 4, 4);
            var r = math.mad(a, b, c);
            Console.WriteLine($"{r}");
            Assert.That(r, Is.EqualTo(new double3(10, 10, 10)));
        }
        {
            var a = new float2(3, 3);
            var b = new float2(2, 2);
            var c = new float2(4, 4);
            var r = math.mad(a, b, c);
            Console.WriteLine($"{r}");
            Assert.That(r, Is.EqualTo(new float2(10, 10)));
        }
        {
            var a = new double2(3, 3);
            var b = new double2(2, 2);
            var c = new double2(4, 4);
            var r = math.mad(a, b, c);
            Console.WriteLine($"{r}");
            Assert.That(r, Is.EqualTo(new double2(10, 10)));
        }
        {
            var a = 3f;
            var b = 2f;
            var c = 4f;
            var r = math.mad(a, b, c);
            Console.WriteLine($"{r}");
            Assert.That(r, Is.EqualTo(10f));
        }
    }

    [Test]
    [MethodImpl(MethodImplOptions.AggressiveOptimization)]
    public void TestDot1()
    {
        var a = new float3(Vector128.Create(1f, 2, 3, 9));
        var b = new float3(Vector128.Create(4f, 5, 6, 9));
        var r = math.dot(a, b);
        Console.WriteLine($"{r}");
        Assert.That(r, Is.EqualTo(32));
    }

    [Test]
    [MethodImpl(MethodImplOptions.AggressiveOptimization)]
    public void TestDot2()
    {
        var a = new float4(Vector128.Create(1f, 2, 3, 4));
        var b = new float4(Vector128.Create(4f, 5, 6, 7));
        var r = math.dot(a, b);
        Console.WriteLine($"{r}");
        Assert.That(r, Is.EqualTo(60));
    }
    
    [Test]
    [MethodImpl(MethodImplOptions.AggressiveOptimization)]
    public void TestDot3()
    {
        var a = new double3(Vector256.Create(1d, 2, 3, 9));
        var b = new double3(Vector256.Create(4d, 5, 6, 9));
        var r = math.dot(a, b);
        Console.WriteLine($"{r}");
        Assert.That(r, Is.EqualTo(32));
    }

    [Test]
    [MethodImpl(MethodImplOptions.AggressiveOptimization)]
    public void TestDot4()
    {
        var a = new double4(Vector256.Create(1d, 2, 3, 4));
        var b = new double4(Vector256.Create(4d, 5, 6, 7));
        var r = math.dot(a, b);
        Console.WriteLine($"{r}");
        Assert.That(r, Is.EqualTo(60));
    }

    [Test]
    [MethodImpl(MethodImplOptions.AggressiveOptimization)]
    public void TestShuffle()
    {
        var a = new float4(1, 2, 3, 4);
        var xyzw = a.xyzw;
        var yzwx = a.yzwx;
        var wzyx = a.wzyx;
        var wyz = a.wyz;
        var yzx = a.yzx;

        Console.WriteLine($"{xyzw}");
        Console.WriteLine($"{yzwx}");
        Console.WriteLine($"{wzyx}");
        Console.WriteLine($"{wyz}");
        Console.WriteLine($"{yzx}");

        Assert.That(xyzw, Is.EqualTo(new float4(1, 2, 3, 4)));
        Assert.That(yzwx, Is.EqualTo(new float4(2, 3, 4, 1)));
        Assert.That(wzyx, Is.EqualTo(new float4(4, 3, 2, 1)));
        Assert.That(wyz, Is.EqualTo(new float3(4, 2, 3)));
        Assert.That(yzx, Is.EqualTo(new float3(2, 3, 1)));
    }

    [Test]
    [MethodImpl(MethodImplOptions.AggressiveOptimization)]
    public void TestShuffle2()
    {
        var a = new double2(1, 2);
        var xy = a.xy;
        var yx = a.yx;
        var xx = a.xx;
        var yy = a.yy;

        Console.WriteLine($"{xy}");
        Console.WriteLine($"{yx}");
        Console.WriteLine($"{xx}");
        Console.WriteLine($"{yy}");

        Assert.That(xy, Is.EqualTo(new double2(1, 2)));
        Assert.That(yx, Is.EqualTo(new double2(2, 1)));
        Assert.That(xx, Is.EqualTo(new double2(1, 1)));
        Assert.That(yy, Is.EqualTo(new double2(2, 2)));
    }

    [Test]
    [MethodImpl(MethodImplOptions.AggressiveOptimization)]
    public void TestShuffle3()
    {
        var a = new int4(1, 2, 3, 4);
        var xyzw = a.xyzw;
        var yzwx = a.yzwx;
        var wzyx = a.wzyx;
        var wyz = a.wyz;
        var yzx = a.yzx;

        Console.WriteLine($"{xyzw}");
        Console.WriteLine($"{yzwx}");
        Console.WriteLine($"{wzyx}");
        Console.WriteLine($"{wyz}");
        Console.WriteLine($"{yzx}");

        Assert.That(xyzw, Is.EqualTo(new int4(1, 2, 3, 4)));
        Assert.That(yzwx, Is.EqualTo(new int4(2, 3, 4, 1)));
        Assert.That(wzyx, Is.EqualTo(new int4(4, 3, 2, 1)));
        Assert.That(wyz, Is.EqualTo(new int3(4, 2, 3)));
        Assert.That(yzx, Is.EqualTo(new int3(2, 3, 1)));
    }

    [Test]
    [MethodImpl(MethodImplOptions.AggressiveOptimization)]
    public void TestShuffle4()
    {
        var a = new double4(1, 2, 3, 4);
        var xyzw = a.xyzw;
        var yzwx = a.yzwx;
        var wzyx = a.wzyx;
        var wyz = a.wyz;
        var yzx = a.yzx;

        Console.WriteLine($"{xyzw}");
        Console.WriteLine($"{yzwx}");
        Console.WriteLine($"{wzyx}");
        Console.WriteLine($"{wyz}");
        Console.WriteLine($"{yzx}");

        Assert.That(xyzw, Is.EqualTo(new double4(1, 2, 3, 4)));
        Assert.That(yzwx, Is.EqualTo(new double4(2, 3, 4, 1)));
        Assert.That(wzyx, Is.EqualTo(new double4(4, 3, 2, 1)));
        Assert.That(wyz, Is.EqualTo(new double3(4, 2, 3)));
        Assert.That(yzx, Is.EqualTo(new double3(2, 3, 1)));
    }

    [Test]
    [MethodImpl(MethodImplOptions.AggressiveOptimization)]
    public void TestShuffle5()
    {
        var a = new long4(1, 2, 3, 4);
        var xyzw = a.xyzw;
        var yzwx = a.yzwx;
        var wyz = a.wyz;
        var yzx = a.yzx;
        var wzyx = a.wzyx;

        Console.WriteLine($"{xyzw}");
        Console.WriteLine($"{yzwx}");
        Console.WriteLine($"{wzyx}");
        Console.WriteLine($"{wyz}");
        Console.WriteLine($"{yzx}");

        Assert.That(xyzw, Is.EqualTo(new long4(1, 2, 3, 4)));
        Assert.That(yzwx, Is.EqualTo(new long4(2, 3, 4, 1)));
        Assert.That(wzyx, Is.EqualTo(new long4(4, 3, 2, 1)));
        Assert.That(wyz, Is.EqualTo(new long3(4, 2, 3)));
        Assert.That(yzx, Is.EqualTo(new long3(2, 3, 1)));
    }

    [Test]
    [MethodImpl(MethodImplOptions.AggressiveOptimization)]
    public void TestCSum1()
    {
        Console.WriteLine($"Ssse3.IsSupported = {Ssse3.IsSupported}");
        var a = new int4(1, 2, 3, 4);
        var r = math.csum(a);
        Console.WriteLine(r);
        Assert.That(r, Is.EqualTo(1 + 2 + 3 + 4));
    }
    
    [Test]
    [MethodImpl(MethodImplOptions.AggressiveOptimization)]
    public void TestCSum2()
    {
        Console.WriteLine($"Ssse3.IsSupported = {Ssse3.IsSupported}");
        var a = new int3(1, 2, 3);
        var r = math.csum(a);
        Console.WriteLine(r);
        Assert.That(r, Is.EqualTo(1 + 2 + 3));
    }
    
    [Test]
    [MethodImpl(MethodImplOptions.AggressiveOptimization)]
    public void TestCSum3()
    {
        Console.WriteLine($"Sse3.IsSupported = {Sse3.IsSupported}");
        var a = new float3(1, 2, 3);
        var r = math.csum(a);
        Console.WriteLine(r);
        Assert.That(r, Is.EqualTo(1f + 2 + 3));
    }
    
    [Test]
    [MethodImpl(MethodImplOptions.AggressiveOptimization)]
    public void TestCSum4()
    {
        Console.WriteLine($"Sse3.IsSupported = {Sse3.IsSupported}");
        var a = new float4(1, 2, 3, 4);
        var r = math.csum(a);
        Console.WriteLine(r);
        Assert.That(r, Is.EqualTo(1f + 2 + 3 + 4));
    }
    
    [Test]
    [MethodImpl(MethodImplOptions.AggressiveOptimization)]
    public void TestCSum5()
    {
        var a = new long4(1, 2, 3, 4);
        var r = math.csum(a);
        Console.WriteLine(r);
        Assert.That(r, Is.EqualTo(1 + 2 + 3 + 4));
    }
    
    [Test]
    [MethodImpl(MethodImplOptions.AggressiveOptimization)]
    public void TestMinMax1()
    {
        var a = new float3(1, 2, 3);
        var b = new float3(3, 2, 1);
        var r1 = math.min(a, b);
        var r2 = math.max(a, b);
        Console.WriteLine($"{r1} ; {r2}");
        Assert.That(r1, Is.EqualTo(new float3(1, 2, 1)));
        Assert.That(r2, Is.EqualTo(new float3(3, 2, 3)));
    }
}
