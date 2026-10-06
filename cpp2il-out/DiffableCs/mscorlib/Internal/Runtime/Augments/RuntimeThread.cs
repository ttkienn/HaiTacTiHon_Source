namespace Internal.Runtime.Augments;

internal sealed class RuntimeThread
{
	internal static readonly int OptimalMaxSpinWaitsPerSpinIteration; //Field offset: 0x0
	private readonly Thread thread; //Field offset: 0x10

	public bool IsBackground
	{
		 set { } //Length: 30
	}

	private static RuntimeThread() { }

	private RuntimeThread(Thread t) { }

	public static RuntimeThread Create(ParameterizedThreadStart start, int maxStackSize) { }

	public static int GetCurrentProcessorId() { }

	public void set_IsBackground(bool value) { }

	public static void Sleep(int millisecondsTimeout) { }

	public static bool SpinWait(int iterations) { }

	public void Start(object state) { }

	public static bool Yield() { }

}

