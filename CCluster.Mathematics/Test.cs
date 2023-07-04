// using System;
// using System.Drawing;
// using System.Numerics;
// using System.Runtime.CompilerServices;
// using System.Runtime.InteropServices;
// using System.Runtime.Intrinsics;
//
// namespace CCluster.Mathematics;
//
// internal class Test
// {
//     public void Foo(asd2 a)
//     {
//         var b = a.RefX;
//     }
// }
//
// [StructLayout(LayoutKind.Sequential, Size = 128)]
// public unsafe partial struct asd2
// {
//     public Vector64<float> vector;
//
//     public ref float RefX => ref Unsafe.Add(ref Unsafe.As<Vector64<float>, float>(ref Unsafe.AsRef(in vector)), 0);
//
//     public ref float RefY => ref Unsafe.Add(ref Unsafe.As<Vector64<float>, float>(ref Unsafe.AsRef(in vector)), 1);
//
//     public readonly ref readonly float RefRoX =>
//         ref Unsafe.Add(ref Unsafe.As<Vector64<float>, float>(ref Unsafe.AsRef(in vector)), 0);
//
//     public float x
//     {
//         readonly get => RefRoX;
//         set => RefX = value;
//     }
//
//     public readonly float x2 => RefRoX;
// }
//
// public static unsafe partial class asd3
// {
//     public static ref readonly float RefRoX(this in asd2 self)
//         => ref Unsafe.Add(ref Unsafe.As<Vector64<float>, float>(ref Unsafe.AsRef(in self.vector)), 0);
//
//     public static ref float RefX(this ref asd2 self)
//         => ref Unsafe.Add(ref Unsafe.As<Vector64<float>, float>(ref self.vector), 0);
//
//     public static unsafe ref float RefX(asd2* self)
//         => ref Unsafe.Add(ref Unsafe.As<Vector64<float>, float>(ref Unsafe.AsRef(in self->vector)), 0);
//
//     public static unsafe void Foo(Vector64<float> a)
//     {
//         var x = a.Equals(a);
//     }
// }
