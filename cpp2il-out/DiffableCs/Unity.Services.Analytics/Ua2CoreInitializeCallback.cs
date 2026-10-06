//Type is in global namespace

internal class Ua2CoreInitializeCallback : IInitializablePackage
{
	[CompilerGenerated]
	private struct <Initialize>d__1 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public CoreRegistry registry; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}


	public Ua2CoreInitializeCallback() { }

	[AsyncStateMachine(typeof(<Initialize>d__1))]
	public override Task Initialize(CoreRegistry registry) { }

	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType::BeforeSceneLoad (1))]
	private static void Register() { }

}

