using System.Runtime.CompilerServices;
using CCluster.Mathematics;

namespace Tests;

public class TestQuaternion
{
    [SetUp]
    public void Setup() { }

    [Test]
    [MethodImpl(MethodImplOptions.AggressiveOptimization)]
    public void Test1()
    {
        var m = new float3x3(
            1, 2, 3,
            4, 5, 6,
            7, 8, 9
        );
        var a = new quaternion(m);
        Console.WriteLine($"{a}");
        var t = new quaternion(-0.1195229f, 0.2390457f, -0.1195229f, 0.9561829f);
        var r = math.abs(a.value - t.value);
        var c = (r < new float4(0.0001f)).AllTrue;
        Assert.That(c, Is.True);
    }

    [Test]
    [MethodImpl(MethodImplOptions.AggressiveOptimization)]
    public void Test2()
    {
        var a = quaternion.Euler(10, 20, 30);
        Console.WriteLine($"{a}");
        var t = new quaternion(-0.5108982f, 0.6404592f, 0.2415333f, 0.5200545f);
        var r = math.abs(a.value - t.value);
        var c = (r < new float4(0.0001f)).AllTrue;
        Assert.That(c, Is.True);
    }

    [Test]
    [MethodImpl(MethodImplOptions.AggressiveOptimization)]
    public void Test3()
    {
        var a = quaternion.Euler(10, 20, 30);
        var b = new float3x3(a);
        Console.WriteLine($"{b}");
        var t = float3x3.RowMajor(
            0.06294721f, -0.90564f, 0.4193495f,
            -0.403198f, 0.3612893f, 0.8407743f,
            -0.9129453f, -0.2220053f, -0.3424101f
        );
        var r = math.abs(b - t);
        var c = (r < new float3x3(0.0001f)).AllTrue;
        Assert.That(c, Is.True);
    }
}
