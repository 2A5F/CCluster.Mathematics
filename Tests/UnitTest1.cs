using CCluster.Mathematics;
using System.Drawing;
using System.Runtime.InteropServices;

namespace Tests;

public class Tests
{
    [SetUp]
    public void Setup() { }

    [StructLayout(LayoutKind.Sequential, Size = 3 * 16)]
    record struct Foo1
    {
        public float4 a;
        public float3 b;
        public float2 c;
        public float d;
    }

    [Test]
    public unsafe void Test1()
    {
        var foo = new Foo1()
        {
            a = new(1, 1, 1, 1),
            b = new(2, 2, 2),
            c = new(3, 3),
            d = 4,
        };
        Console.WriteLine($"{foo}");
        Assert.That(sizeof(Foo1), Is.EqualTo(3 * 16));
        var span = new Span<float>(&foo, 12);
        var arr = span.ToArray();
        Assert.That(arr, Is.EquivalentTo(new float[] {
            1, 1, 1, 1,
            2, 2, 2, 0,
            3, 3, 4, 0,
        }));
    }

    /// <summary>
    /// C# is not yet able to mark alignment
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 3 * 16)]
    record struct Foo2
    {
        [FieldOffset(0)]
        public float2 a;
        [FieldOffset(16)]       // HLSL is aligned to 16
        public float4 b;
        [FieldOffset(32)]
        public float2 c;
    }

    [Test]
    public unsafe void Test2()
    {
        var foo = new Foo2()
        {
            a = new(1, 1),
            b = new(2, 2, 2, 2),
            c = new(3, 3),
        };
        Console.WriteLine($"{foo}");
        Assert.That(sizeof(Foo2), Is.EqualTo(3 * 16));
        var span = new Span<float>(&foo, 12);
        var arr = span.ToArray();
        Assert.That(arr, Is.EquivalentTo(new float[] {
            1, 1, 0, 0,
            2, 2, 2, 2,
            3, 3, 0, 0,
        }));
    }
}
