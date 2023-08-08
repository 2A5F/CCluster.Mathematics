namespace CodeGen;

public record TypeMeta(int Size, string suffix, string Zero, string One, string Two)
{
    public bool Number { get; set; }
    public bool Half { get; set; }
    public bool Float { get; set; }
    public bool Decimal { get; set; }
    public bool Bool { get; set; }
    public bool Unsigned { get; set; }
    public bool Simd { get; set; }
    public string JsonRead { get; set; } = null!;
    public Func<string, string> JsonWrite { get; set; } = null!;
    
    public static readonly Dictionary<string, TypeMeta> types = new()
    {
        {
            "bool", new(sizeof(bool), "", "false", "true", "")
            {
                Bool = true, Unsigned = true,
                JsonRead = "reader.GetBoolean()", JsonWrite = n => $"writer.WriteBooleanValue({n})",
            }
        },
        {
            "Half",
            new(sizeof(short), "", "Half.Zero", "Half.One", "(Half.One + Half.One)")
            {
                Number = true, Float = true, Half = true,
                JsonRead = "(Half)reader.GetSingle()", JsonWrite = n => $"writer.WriteNumberValue((float){n})",
            }
        },
        {
            "float", new(sizeof(float), "f", "0f", "1f", "2f")
            {
                Number = true, Float = true, Simd = true,
                JsonRead = "reader.GetSingle()", JsonWrite = n => $"writer.WriteNumberValue({n})",
            }
        },
        {
            "double", new(sizeof(double), "d", "0d", "1d", "2d")
            {
                Number = true, Float = true, Simd = true,
                JsonRead = "reader.GetDouble()", JsonWrite = n => $"writer.WriteNumberValue({n})",
            }
        },
        {
            "decimal", new(sizeof(decimal), "m", "0m", "1m", "2m")
            {
                Number = true, Decimal = true,
                JsonRead = "reader.GetDecimal()", JsonWrite = n => $"writer.WriteNumberValue({n})",
            }
        },
        {
            "int", new(sizeof(int), "", "0", "1", "2")
            {
                Number = true, Simd = true,
                JsonRead = "reader.GetInt32()", JsonWrite = n => $"writer.WriteNumberValue({n})",
            }
        },
        {
            "uint", new(sizeof(uint), "u", "0u", "1u", "2u")
            {
                Number = true, Unsigned = true, Simd = true,
                JsonRead = "reader.GetUInt32()", JsonWrite = n => $"writer.WriteNumberValue({n})",
            }
        },
        {
            "long", new(sizeof(long), "L", "0L", "1L", "2L")
            {
                Number = true, Simd = true,
                JsonRead = "reader.GetInt64()", JsonWrite = n => $"writer.WriteNumberValue({n})",
            }
        },
        {
            "ulong", new(sizeof(ulong), "UL", "0UL", "1UL", "2UL")
            {
                Number = true, Unsigned = true, Simd = true,
                JsonRead = "reader.GetUInt64()", JsonWrite = n => $"writer.WriteNumberValue({n})",
            }
        },
    };
}
