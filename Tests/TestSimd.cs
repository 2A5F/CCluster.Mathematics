using CCluster.Mathematics;

namespace Tests;

public class TestSimd
{
    [SetUp]
    public void Setup() { }

    [Test]
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
}
