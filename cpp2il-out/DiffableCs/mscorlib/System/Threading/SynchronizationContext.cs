namespace System.Threading;

public class SynchronizationContext
{
	private static Type s_cachedPreparedType1; //Field offset: 0x0
	private static Type s_cachedPreparedType2; //Field offset: 0x8
	private static Type s_cachedPreparedType3; //Field offset: 0x10
	private static Type s_cachedPreparedType4; //Field offset: 0x18
	private static Type s_cachedPreparedType5; //Field offset: 0x20
	private SynchronizationContextProperties _props; //Field offset: 0x10

	public static SynchronizationContext Current
	{
		 get { } //Length: 137
	}

	internal static SynchronizationContext CurrentExplicit
	{
		internal get { } //Length: 7
	}

	internal static SynchronizationContext CurrentNoFlow
	{
		[FriendAccessAllowed]
		internal get { } //Length: 137
	}

	public SynchronizationContext() { }

	public override SynchronizationContext CreateCopy() { }

	public static SynchronizationContext get_Current() { }

	internal static SynchronizationContext get_CurrentExplicit() { }

	[FriendAccessAllowed]
	internal static SynchronizationContext get_CurrentNoFlow() { }

	private static SynchronizationContext GetThreadLocalContext() { }

	public bool IsWaitNotificationRequired() { }

	public override void OperationCompleted() { }

	public override void OperationStarted() { }

	public override void Post(SendOrPostCallback d, object state) { }

	public override void Send(SendOrPostCallback d, object state) { }

	public static void SetSynchronizationContext(SynchronizationContext syncContext) { }

	[CLSCompliant(False)]
	[PrePrepareMethod]
	public override int Wait(IntPtr[] waitHandles, bool waitAll, int millisecondsTimeout) { }

	[CLSCompliant(False)]
	[PrePrepareMethod]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::MayFail (1))]
	protected static int WaitHelper(IntPtr[] waitHandles, bool waitAll, int millisecondsTimeout) { }

}

