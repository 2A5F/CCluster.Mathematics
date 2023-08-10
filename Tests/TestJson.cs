using System.Text.Json;
using CCluster.Mathematics;

namespace Tests;

public class TestJson
{
    [SetUp]
    public void Setup() { }

    [Test]
    public void Test1()
    {
        var a = new float3(1, 2, 3);
        Console.WriteLine(a);
        var json = JsonSerializer.Serialize(a);
        Console.WriteLine(json);
        Assert.That(json, Is.EqualTo("[1,2,3]"));
        var b = JsonSerializer.Deserialize<float3>(json);
        Console.WriteLine(b);
        Assert.That(b, Is.EqualTo(new float3(1, 2, 3)));
    }
    
    [Test]
    public void Test2()
    {
        var a = new float3x3(1, 2, 3);
        Console.WriteLine(a);
        var json = JsonSerializer.Serialize(a);
        Console.WriteLine(json);
        Assert.That(json, Is.EqualTo("[[1,1,1],[2,2,2],[3,3,3]]"));
        var b = JsonSerializer.Deserialize<float3x3>(json);
        Console.WriteLine(b);
        Assert.That(b, Is.EqualTo(new float3x3(1, 2, 3)));
    }
}
