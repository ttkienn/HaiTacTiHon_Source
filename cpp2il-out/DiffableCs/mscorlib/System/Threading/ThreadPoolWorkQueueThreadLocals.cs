namespace System.Threading;

internal sealed class ThreadPoolWorkQueueThreadLocals
{
	[ThreadStatic]
	public static ThreadPoolWorkQueueThreadLocals threadLocals; //Field offset: 0x80000000
	public readonly ThreadPoolWorkQueue workQueue; //Field offset: 0x10
	public readonly WorkStealingQueue workStealingQueue; //Field offset: 0x18
	public readonly Random random; //Field offset: 0x20

	public ThreadPoolWorkQueueThreadLocals(ThreadPoolWorkQueue tpq) { }

	private void CleanUp() { }

	protected virtual void Finalize() { }

}

