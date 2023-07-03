namespace CodeGen;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine($"CurrentDirectory: {Environment.CurrentDirectory}");

        Task.WhenAll(
            new GenScalarNumbers().Gen(),
            new GenCartesian().Gen(),
            new GenVectors().Gen()
        ).Wait();
    }
}
