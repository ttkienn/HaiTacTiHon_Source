namespace System.Threading;

[ComVisible(True)]
public abstract class WaitHandle : MarshalByRefObject, IDisposable
{
	public const int WaitTimeout = 258; //Field offset: 0x0
	private const int MAX_WAITHANDLES = 64; //Field offset: 0x0
	private const int WAIT_OBJECT_0 = 0; //Field offset: 0x0
	private const int WAIT_ABANDONED = 128; //Field offset: 0x0
	private const int WAIT_FAILED = 2147483647; //Field offset: 0x0
	private const int ERROR_TOO_MANY_POSTS = 298; //Field offset: 0x0
	private const int ERROR_NOT_OWNED_BY_CALLER = 299; //Field offset: 0x0
	protected static readonly IntPtr InvalidHandle; //Field offset: 0x0
	internal const int MaxWaitHandles = 64; //Field offset: 0x0
	private IntPtr waitHandle; //Field offset: 0x18
	internal SafeWaitHandle safeWaitHandle; //Field offset: 0x20
	internal bool hasThreadAffinity; //Field offset: 0x28

	[Obsolete("Use the SafeWaitHandle property instead.")]
	public override IntPtr Handle
	{
		 set { } //Length: 254
	}

	public SafeWaitHandle SafeWaitHandle
	{
		[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::MayFail (1))]
		 get { } //Length: 193
	}

	private static WaitHandle() { }

	protected WaitHandle() { }

	public override void Close() { }

	public override void Dispose() { }

	protected override void Dispose(bool explicitDisposing) { }

	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::MayFail (1))]
	public SafeWaitHandle get_SafeWaitHandle() { }

	private void Init() { }

	internal static bool InternalWaitOne(SafeHandle waitableSafeHandle, long millisecondsTimeout, bool hasThreadAffinity, bool exitContext) { }

	public override void set_Handle(IntPtr value) { }

	internal void SetHandleInternal(SafeWaitHandle handle) { }

	private static void ThrowAbandonedMutexException(int location, WaitHandle handle) { }

	private static void ThrowAbandonedMutexException() { }

	internal static int Wait_internal(IntPtr* handles, int numHandles, bool waitAll, int ms) { }

	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::MayFail (1))]
	public static int WaitAny(WaitHandle[] waitHandles, TimeSpan timeout, bool exitContext) { }

	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::MayFail (1))]
	public static int WaitAny(WaitHandle[] waitHandles, int millisecondsTimeout, bool exitContext) { }

	private static int WaitMultiple(WaitHandle[] waitHandles, int millisecondsTimeout, bool exitContext, bool WaitAll) { }

	public override bool WaitOne(int millisecondsTimeout) { }

	public override bool WaitOne() { }

	public override bool WaitOne(int millisecondsTimeout, bool exitContext) { }

	private bool WaitOne(long timeout, bool exitContext) { }

	private static int WaitOneNative(SafeHandle waitableSafeHandle, uint millisecondsTimeout, bool hasThreadAffinity, bool exitContext) { }

}

