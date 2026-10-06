namespace System.Threading;

public sealed class Thread : CriticalFinalizerObject
{
	[ThreadStatic]
	private static LocalDataStoreHolder s_LocalDataStore; //Field offset: 0x80000000
	[ThreadStatic]
	internal static CultureInfo m_CurrentCulture; //Field offset: 0x80000008
	[ThreadStatic]
	internal static CultureInfo m_CurrentUICulture; //Field offset: 0x80000010
	[ThreadStatic]
	private static Thread current_thread; //Field offset: 0x80000018
	private static LocalDataStoreMgr s_LocalDataStoreMgr; //Field offset: 0x0
	private static AsyncLocal<CultureInfo> s_asyncLocalCurrentCulture; //Field offset: 0x8
	private static AsyncLocal<CultureInfo> s_asyncLocalCurrentUICulture; //Field offset: 0x10
	private InternalThread internal_thread; //Field offset: 0x10
	private object m_ThreadStartArg; //Field offset: 0x18
	private object pending_exception; //Field offset: 0x20
	private MulticastDelegate m_Delegate; //Field offset: 0x28
	private ExecutionContext m_ExecutionContext; //Field offset: 0x30
	private bool m_ExecutionContextBelongsToOuterScope; //Field offset: 0x38
	private IPrincipal principal; //Field offset: 0x40
	private int principal_version; //Field offset: 0x48

	public static Context CurrentContext
	{
		 get { } //Length: 7
	}

	public CultureInfo CurrentCulture
	{
		 get { } //Length: 52
	}

	public static Thread CurrentThread
	{
		[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::MayFail (1))]
		 get { } //Length: 78
	}

	internal static int CurrentThreadId
	{
		internal get { } //Length: 100
	}

	public CultureInfo CurrentUICulture
	{
		 get { } //Length: 52
	}

	internal bool ExecutionContextBelongsToCurrentScope
	{
		internal get { } //Length: 8
		internal set { } //Length: 7
	}

	private InternalThread Internal
	{
		private get { } //Length: 41
	}

	public bool IsBackground
	{
		 set { } //Length: 196
	}

	public bool IsThreadPoolThread
	{
		 get { } //Length: 48
	}

	internal bool IsThreadPoolThreadInternal
	{
		internal get { } //Length: 48
	}

	public int ManagedThreadId
	{
		[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
		 get { } //Length: 47
	}

	public string Name
	{
		 get { } //Length: 35
		 set { } //Length: 96
	}

	public ThreadPriority Priority
	{
		 set { } //Length: 5
	}

	public Thread(ThreadStart start) { }

	public Thread(ParameterizedThreadStart start, int maxStackSize) { }

	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::MayFail (1))]
	public static void BeginCriticalRegion() { }

	private static void ClrState(InternalThread thread, ThreadState clr) { }

	private void ConstructInternalThread() { }

	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	public static void EndCriticalRegion() { }

	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	protected virtual void Finalize() { }

	public static Context get_CurrentContext() { }

	public CultureInfo get_CurrentCulture() { }

	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::MayFail (1))]
	public static Thread get_CurrentThread() { }

	internal static int get_CurrentThreadId() { }

	public CultureInfo get_CurrentUICulture() { }

	internal bool get_ExecutionContextBelongsToCurrentScope() { }

	private InternalThread get_Internal() { }

	public bool get_IsThreadPoolThread() { }

	internal bool get_IsThreadPoolThreadInternal() { }

	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	public int get_ManagedThreadId() { }

	public string get_Name() { }

	private CultureInfo GetCurrentCultureNoAppX() { }

	private static Thread GetCurrentThread() { }

	private static void GetCurrentThread_icall(ref Thread thread) { }

	internal CultureInfo GetCurrentUICultureNoAppX() { }

	public static int GetDomainID() { }

	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	internal Reader GetExecutionContextReader() { }

	[ComVisible(False)]
	public virtual int GetHashCode() { }

	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::MayFail (1))]
	internal ExecutionContext GetMutableExecutionContext() { }

	private static string GetName_internal(InternalThread thread) { }

	private static int GetProcessDefaultStackSize(int maxStackSize) { }

	private static ThreadState GetState(InternalThread thread) { }

	public static void MemoryBarrier() { }

	internal void set_ExecutionContextBelongsToCurrentScope(bool value) { }

	public void set_IsBackground(bool value) { }

	public void set_Name(string value) { }

	public void set_Priority(ThreadPriority value) { }

	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	internal void SetExecutionContext(Reader value, bool belongsToCurrentScope) { }

	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	internal void SetExecutionContext(ExecutionContext value, bool belongsToCurrentScope) { }

	private static void SetName_icall(InternalThread thread, Char* name, int nameLength) { }

	private static void SetName_internal(InternalThread thread, string name) { }

	private void SetPriorityNative(int priority) { }

	private void SetStart(MulticastDelegate start, int maxStackSize) { }

	private void SetStartHelper(Delegate start, int maxStackSize) { }

	private static void SetState(InternalThread thread, ThreadState set) { }

	public static void Sleep(int millisecondsTimeout) { }

	private static void SleepInternal(int millisecondsTimeout) { }

	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	public static void SpinWait(int iterations) { }

	private static void SpinWait_nop() { }

	private void Start(ref StackCrawlMark stackMark) { }

	public void Start(object parameter) { }

	public void Start() { }

	private void StartInternal(object principal, ref StackCrawlMark stackMark) { }

	private static int SystemMaxStackStize() { }

	private bool Thread_internal(MulticastDelegate start) { }

	private ThreadState ValidateThreadState() { }

	public static bool Yield() { }

	private static bool YieldInternal() { }

}

