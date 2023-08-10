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
        var t = new quaternion(-0.11952286f, 0.23904572f, -0.11952286f, 0.9561829f);
        var r = math.abs(a.value - t.value);
        var c = (r < new float4(0.01f)).AllTrue;
        Assert.True(c);
    }
}
