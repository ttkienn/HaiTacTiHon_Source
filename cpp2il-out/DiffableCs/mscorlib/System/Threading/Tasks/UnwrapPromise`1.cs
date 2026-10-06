namespace System.Threading.Tasks;

internal sealed class UnwrapPromise : Task<TResult>, ITaskCompletionAction
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c<TResult> <>9; //Field offset: 0x0
		public static WaitCallback <>9__8_0; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal void <InvokeCoreAsync>b__8_0(object state) { }

	}

	private byte _state; //Field offset: 0x0
	private readonly bool _lookForOce; //Field offset: 0x0

	public override bool InvokeMayRunArbitraryCode
	{
		 get { } //Length: 3
	}

	public UnwrapPromise`1(Task outerTask, bool lookForOce) { }

	public override bool get_InvokeMayRunArbitraryCode() { }

	public override void Invoke(Task completingTask) { }

	private void InvokeCore(Task completingTask) { }

	private void InvokeCoreAsync(Task completingTask) { }

	private void ProcessCompletedOuterTask(Task task) { }

	private void ProcessInnerTask(Task task) { }

	private bool TrySetFromTask(Task task, bool lookForOce) { }

}

