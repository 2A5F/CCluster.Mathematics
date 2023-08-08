namespace CCluster.Mathematics;

public interface IMatrix { }

public interface IMatrixNx2 : IMatrix { }

public interface IMatrixNx3 : IMatrix { }

public interface IMatrixNx4 : IMatrix { }

public interface IMatrix2xM : IMatrix { }

public interface IMatrix3xM : IMatrix { }

public interface IMatrix4xM : IMatrix { }

public interface IMatrix2x2 : IMatrixNx2, IMatrix2xM { }

public interface IMatrix3x2 : IMatrixNx2, IMatrix3xM { }

public interface IMatrix4x2 : IMatrixNx2, IMatrix4xM { }

public interface IMatrix2x3 : IMatrixNx3, IMatrix2xM { }

public interface IMatrix3x3 : IMatrixNx3, IMatrix3xM { }

public interface IMatrix4x3 : IMatrixNx3, IMatrix4xM { }

public interface IMatrix2x4 : IMatrixNx4, IMatrix2xM { }

public interface IMatrix3x4 : IMatrixNx4, IMatrix3xM { }

public interface IMatrix4x4 : IMatrixNx4, IMatrix4xM { }

public interface IMatrix<T> : IMatrix { }

public interface IMatrixNx2<T> : IMatrix<T>, IMatrixNx2 { }

public interface IMatrixNx3<T> : IMatrix<T>, IMatrixNx3 { }

public interface IMatrixNx4<T> : IMatrix<T>, IMatrixNx4 { }

public interface IMatrix2xM<T> : IMatrix<T>, IMatrix2xM { }

public interface IMatrix3xM<T> : IMatrix<T>, IMatrix3xM { }

public interface IMatrix4xM<T> : IMatrix<T>, IMatrix4xM { }

public interface IMatrix2x2<T> : IMatrixNx2<T>, IMatrix2xM<T>, IMatrix2x2 { }

public interface IMatrix3x2<T> : IMatrixNx2<T>, IMatrix3xM<T>, IMatrix3x2 { }

public interface IMatrix4x2<T> : IMatrixNx2<T>, IMatrix4xM<T>, IMatrix4x2 { }

public interface IMatrix2x3<T> : IMatrixNx3<T>, IMatrix2xM<T>, IMatrix2x3 { }

public interface IMatrix3x3<T> : IMatrixNx3<T>, IMatrix3xM<T>, IMatrix3x3 { }

public interface IMatrix4x3<T> : IMatrixNx3<T>, IMatrix4xM<T>, IMatrix4x3 { }

public interface IMatrix2x4<T> : IMatrixNx4<T>, IMatrix2xM<T>, IMatrix2x4 { }

public interface IMatrix3x4<T> : IMatrixNx4<T>, IMatrix3xM<T>, IMatrix3x4 { }

public interface IMatrix4x4<T> : IMatrixNx4<T>, IMatrix4xM<T>, IMatrix4x4 { }

public interface IMatrixSelf<out S> : IMatrix where S : IMatrixSelf<S>
{
    public static abstract S Zero { get; }
    public static abstract S One { get; }
}

public interface IMatrixIdentity<out S> : IMatrix where S : IMatrixSelf<S>, IMatrixIdentity<S>
{
    public static abstract S Identity { get; }
}
