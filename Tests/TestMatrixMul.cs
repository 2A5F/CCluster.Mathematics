using CCluster.Mathematics;

namespace Tests;

public class TestMatrixMul
{
    [SetUp]
    public void Setup() { }

    [Test]
    public void Test1()
    {
        var a = new float3x3(
            1, 2, 3,
            4, 5, 6,
            7, 8, 9
        );
        var b = new float3x3(
            5, 7, 8,
            6, 9, 3,
            2, 4, 1
        );
        var r = math.mul(a, b);
        Console.WriteLine($"{r}");
        Assert.That(r, Is.EqualTo(new float3x3(
            89, 109, 129,
            63, 81, 99,
            25, 32, 39
        )));
    }

    [Test]
    public void Test2()
    {
        var a = new float3x2(
            1, 2, 3,
            4, 5, 6
        );
        var b = new float2x4(
            5, 7,
            8, 6,
            9, 3,
            2, 4
        );
        var r = math.mul(a, b);
        Console.WriteLine($"{r}");
        Assert.That(r, Is.EqualTo(new float3x4(
            33, 45, 57,
            32, 46, 60,
            21, 33, 45,
            18, 24, 30
        )));
    }

    [Test]
    public void Test3()
    {
        var a = new float2x4(
            1, 2,
            3, 4,
            5, 6,
            7, 8
        );
        var b = new float4x3(
            5, 7, 8, 6,
            9, 3, 2, 4,
            1, 6, 8, 3
        );
        var r = math.mul(a, b);
        Console.WriteLine($"{r}");
        Assert.That(r, Is.EqualTo(new float2x3(
            108, 134,
            56, 74,
            80, 98
        )));
    }
}
