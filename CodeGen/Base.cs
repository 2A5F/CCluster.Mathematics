using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGen;

public abstract partial class Base
{
    public static (char a, char b, bool u) GetXyzwCartesian2(int n, int i)
        => (xyzw_cartesian2[n, i, 0], xyzw_cartesian2[n, i, 1], xyzw_cartesian2[n, i, 2] != '\x0');

    public static (char a, char b, char c, bool u) GetXyzwCartesian3(int n, int i)
        => (xyzw_cartesian3[n, i, 0], xyzw_cartesian3[n, i, 1], xyzw_cartesian3[n, i, 2], xyzw_cartesian3[n, i, 3] != '\x0');

    public static (char a, char b, char c, char d, bool u) GetXyzwCartesian4(int n, int i)
        => (xyzw_cartesian4[n, i, 0], xyzw_cartesian4[n, i, 1], xyzw_cartesian4[n, i, 2], xyzw_cartesian4[n, i, 3], xyzw_cartesian4[n, i, 4] != '\x0');

    public static (char a, char b, bool u) GetRgbaCartesian2(int n, int i)
        => (rgba_cartesian2[n, i, 0], rgba_cartesian2[n, i, 1], rgba_cartesian2[n, i, 2] != '\x0');

    public static (char a, char b, char c, bool u) GetRgbaCartesian3(int n, int i)
        => (rgba_cartesian3[n, i, 0], rgba_cartesian3[n, i, 1], rgba_cartesian3[n, i, 2], rgba_cartesian3[n, i, 3] != '\x0');

    public static (char a, char b, char c, char d, bool u) GetRgbaCartesian4(int n, int i)
        => (rgba_cartesian4[n, i, 0], rgba_cartesian4[n, i, 1], rgba_cartesian4[n, i, 2], rgba_cartesian4[n, i, 3], rgba_cartesian4[n, i, 4] != '\x0');

    
    public abstract Task Gen();

    public async Task SaveCode(string path, string code)
    {
        await using var file = File.Open(Path.Combine(Environment.CurrentDirectory, path), FileMode.Create);
        var bytes = Encoding.UTF8.GetBytes(code);
        await file.WriteAsync(bytes);
    }
}
