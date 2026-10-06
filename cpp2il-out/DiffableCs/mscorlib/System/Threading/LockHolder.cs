namespace System.Threading;

[ReflectionBlocked]
public struct LockHolder : IDisposable
{
	private Lock _lock; //Field offset: 0x0

	public override void Dispose() { }

	public static LockHolder Hold(Lock l) { }

}

