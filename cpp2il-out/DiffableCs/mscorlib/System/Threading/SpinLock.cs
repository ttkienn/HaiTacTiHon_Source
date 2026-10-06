namespace System.Threading;

[ComVisible(False)]
[DebuggerDisplay("IsHeld = {IsHeld}")]
[DebuggerTypeProxy(typeof(SystemThreading_SpinLockDebugView))]
public struct SpinLock
{
	public class SystemThreading_SpinLockDebugView
	{

	}

	private static int MAXIMUM_WAITERS; //Field offset: 0x0
	private int m_owner; //Field offset: 0x0

	public bool IsHeldByCurrentThread
	{
		[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
		 get { } //Length: 301
	}

	public bool IsThreadOwnerTrackingEnabled
	{
		[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
		 get { } //Length: 28
	}

	private static SpinLock() { }

	public SpinLock(bool enableThreadOwnerTracking) { }

	private void ContinueTryEnter(int millisecondsTimeout, ref bool lockTaken) { }

	private void ContinueTryEnterWithThreadTracking(int millisecondsTimeout, uint startTime, ref bool lockTaken) { }

	private void DecrementWaiters() { }

	public void Enter(ref bool lockTaken) { }

	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	public void Exit(bool useMemoryBarrier) { }

	private void ExitSlowPath(bool useMemoryBarrier) { }

	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	public bool get_IsHeldByCurrentThread() { }

	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	public bool get_IsThreadOwnerTrackingEnabled() { }

	public void TryEnter(int millisecondsTimeout, ref bool lockTaken) { }

}

