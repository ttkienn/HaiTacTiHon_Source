namespace UnityEngine.Pool;

public struct PooledObject : IDisposable
{
	private readonly T m_ToReturn; //Field offset: 0x0
	private readonly IObjectPool<T> m_Pool; //Field offset: 0x0

	public PooledObject`1(T value, IObjectPool<T> pool) { }

	private override void System.IDisposable.Dispose() { }

}

