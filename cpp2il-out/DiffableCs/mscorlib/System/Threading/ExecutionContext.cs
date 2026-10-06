namespace System.Threading;

public sealed class ExecutionContext : IDisposable, ISerializable
{
	[Flags]
	public enum CaptureOptions
	{
		None = 0,
		IgnoreSyncCtx = 1,
		OptimizeDefaultCase = 2,
	}

	private enum Flags
	{
		None = 0,
		IsNewCapture = 1,
		IsFlowSuppressed = 2,
		IsPreAllocatedDefault = 4,
	}

	public struct Reader
	{
		private ExecutionContext m_ec; //Field offset: 0x0

		public bool IsFlowSuppressed
		{
			 get { } //Length: 20
		}

		public bool IsNull
		{
			 get { } //Length: 8
		}

		public Reader LogicalCallContext
		{
			 get { } //Length: 52
		}

		public SynchronizationContext SynchronizationContext
		{
			 get { } //Length: 17
		}

		public SynchronizationContext SynchronizationContextNoFlow
		{
			 get { } //Length: 17
		}

		public Reader(ExecutionContext ec) { }

		public ExecutionContext DangerousGetRawExecutionContext() { }

		public bool get_IsFlowSuppressed() { }

		public bool get_IsNull() { }

		public Reader get_LogicalCallContext() { }

		public SynchronizationContext get_SynchronizationContext() { }

		public SynchronizationContext get_SynchronizationContextNoFlow() { }

		public bool HasSameLocalValues(ExecutionContext other) { }

		public bool IsDefaultFTContext(bool ignoreSyncCtx) { }

	}

	private static readonly ExecutionContext s_dummyDefaultEC; //Field offset: 0x0
	internal static readonly ExecutionContext Default; //Field offset: 0x8
	private SynchronizationContext _syncContext; //Field offset: 0x10
	private SynchronizationContext _syncContextNoFlow; //Field offset: 0x18
	private LogicalCallContext _logicalCallContext; //Field offset: 0x20
	private IllogicalCallContext _illogicalCallContext; //Field offset: 0x28
	private Flags _flags; //Field offset: 0x30
	private Dictionary<IAsyncLocal, Object> _localValues; //Field offset: 0x38
	private List<IAsyncLocal> _localChangeNotifications; //Field offset: 0x40

	internal IllogicalCallContext IllogicalCallContext
	{
		internal get { } //Length: 105
		internal set { } //Length: 13
	}

	internal bool isFlowSuppressed
	{
		internal get { } //Length: 8
		internal set { } //Length: 25
	}

	internal bool isNewCapture
	{
		internal get { } //Length: 8
		internal set { } //Length: 25
	}

	internal bool IsPreAllocatedDefault
	{
		internal get { } //Length: 9
	}

	internal LogicalCallContext LogicalCallContext
	{
		internal get { } //Length: 105
		internal set { } //Length: 13
	}

	internal SynchronizationContext SynchronizationContext
	{
		[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
		internal get { } //Length: 5
		[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
		internal set { } //Length: 13
	}

	internal SynchronizationContext SynchronizationContextNoFlow
	{
		[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
		internal get { } //Length: 5
		[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
		internal set { } //Length: 13
	}

	private static ExecutionContext() { }

	private ExecutionContext(SerializationInfo info, StreamingContext context) { }

	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	internal ExecutionContext() { }

	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	internal ExecutionContext(bool isPreAllocatedDefault) { }

	internal static ExecutionContext Capture(ref StackCrawlMark stackMark, CaptureOptions options) { }

	public static ExecutionContext Capture() { }

	public ExecutionContext CreateCopy() { }

	internal ExecutionContext CreateMutableCopy() { }

	public override void Dispose() { }

	internal static void EstablishCopyOnWriteScope(ref ExecutionContextSwitcher ecsw) { }

	private static void EstablishCopyOnWriteScope(Thread currentThread, bool knownNullWindowsIdentity, ref ExecutionContextSwitcher ecsw) { }

	[FriendAccessAllowed]
	internal static ExecutionContext FastCapture() { }

	internal IllogicalCallContext get_IllogicalCallContext() { }

	internal bool get_isFlowSuppressed() { }

	internal bool get_isNewCapture() { }

	internal bool get_IsPreAllocatedDefault() { }

	internal LogicalCallContext get_LogicalCallContext() { }

	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	internal SynchronizationContext get_SynchronizationContext() { }

	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	internal SynchronizationContext get_SynchronizationContextNoFlow() { }

	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	internal bool IsDefaultFTContext(bool ignoreSyncCtx) { }

	public static bool IsFlowSuppressed() { }

	[HandleProcessCorruptedStateExceptions]
	internal static void OnAsyncLocalContextChanged(ExecutionContext previous, ExecutionContext current) { }

	public static void Run(ExecutionContext executionContext, ContextCallback callback, object state) { }

	[FriendAccessAllowed]
	internal static void Run(ExecutionContext executionContext, ContextCallback callback, object state, bool preserveSyncCtx) { }

	internal static void RunInternal(ExecutionContext executionContext, ContextCallback callback, object state) { }

	[HandleProcessCorruptedStateExceptions]
	internal static void RunInternal(ExecutionContext executionContext, ContextCallback callback, object state, bool preserveSyncCtx) { }

	internal void set_IllogicalCallContext(IllogicalCallContext value) { }

	internal void set_isFlowSuppressed(bool value) { }

	internal void set_isNewCapture(bool value) { }

	internal void set_LogicalCallContext(LogicalCallContext value) { }

	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	internal void set_SynchronizationContext(SynchronizationContext value) { }

	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	internal void set_SynchronizationContextNoFlow(SynchronizationContext value) { }

	[HandleProcessCorruptedStateExceptions]
	internal static ExecutionContextSwitcher SetExecutionContext(ExecutionContext executionContext, bool preserveSyncCtx) { }

}

