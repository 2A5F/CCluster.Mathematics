namespace CCluster.Mathematics;

public interface IVector { }

public interface IVector2 : IVector { }

public interface IVector3 : IVector { }

public interface IVector4 : IVector { }

public interface IVector<T> : IVector { }

public interface IVector2<T> : IVector<T>, IVector2 { }

public interface IVector3<T> : IVector<T>, IVector3 { }

public interface IVector4<T> : IVector<T>, IVector4 { }
