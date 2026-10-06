namespace Unity.Services.Core.Internal;

internal class UnityServicesInternal : IUnityServices
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass33_0
	{
		private struct <<InitializeServicesAsync>g__InitializePackagesAsync|1>d : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
			public <>c__DisplayClass33_0 <>4__this; //Field offset: 0x20
			private TaskAwaiter<List`1<PackageInitializationInfo>> <>u__1; //Field offset: 0x28

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		public DependencyTree dependencyTree; //Field offset: 0x10
		public List<Int32> sortedPackageTypeHashes; //Field offset: 0x18
		public UnityServicesInternal <>4__this; //Field offset: 0x20
		public Stopwatch initStopwatch; //Field offset: 0x28

		public <>c__DisplayClass33_0() { }

		internal void <InitializeServicesAsync>g__FailServicesInitialization|2(Exception reason) { }

		[AsyncStateMachine(typeof(<<InitializeServicesAsync>g__InitializePackagesAsync|1>d))]
		internal Task <InitializeServicesAsync>g__InitializePackagesAsync|1() { }

		internal void <InitializeServicesAsync>g__SortPackages|0() { }

		internal void <InitializeServicesAsync>g__SucceedServicesInitialization|3() { }

	}

	[CompilerGenerated]
	private struct <EnableInitializationAsync>d__36 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public UnityServicesInternal <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <InitializeAsync>d__27 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public InitializationOptions options; //Field offset: 0x20
		public UnityServicesInternal <>4__this; //Field offset: 0x28
		private TaskAwaiter<Object> <>u__1; //Field offset: 0x30
		private TaskAwaiter <>u__2; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <InitializeServicesAsync>d__33 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public UnityServicesInternal <>4__this; //Field offset: 0x20
		private <>c__DisplayClass33_0 <>8__1; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal const string InitSuccessEventInvocationError = "Exception in services initialization success event handler: "; //Field offset: 0x0
	internal const string InitFailureEventInvocationError = "Exception in services initialization failure event handler: "; //Field offset: 0x0
	[CompilerGenerated]
	private Action Initialized; //Field offset: 0x10
	[CompilerGenerated]
	private Action<Exception> InitializeFailed; //Field offset: 0x18
	[CompilerGenerated]
	private ServicesInitializationState <State>k__BackingField; //Field offset: 0x20
	internal bool CanInitialize; //Field offset: 0x24
	private TaskCompletionSource<Object> m_Initialization; //Field offset: 0x28
	[CompilerGenerated]
	private readonly CoreRegistry <Registry>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private readonly CoreMetrics <Metrics>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private readonly CoreDiagnostics <Diagnostics>k__BackingField; //Field offset: 0x40

	public override event Action Initialized
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public override event Action<Exception> InitializeFailed
	{
		[CompilerGenerated]
		 add { } //Length: 172
		[CompilerGenerated]
		 remove { } //Length: 172
	}

	[NotNull]
	internal CoreDiagnostics Diagnostics
	{
		[CompilerGenerated]
		internal get { } //Length: 5
	}

	[NotNull]
	internal CoreMetrics Metrics
	{
		[CompilerGenerated]
		internal get { } //Length: 5
	}

	public internal InitializationOptions Options
	{
		 get { } //Length: 27
		internal set { } //Length: 35
	}

	[NotNull]
	internal CoreRegistry Registry
	{
		[CompilerGenerated]
		internal get { } //Length: 5
	}

	public private override ServicesInitializationState State
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public UnityServicesInternal(CoreRegistry registry, CoreMetrics coreMetrics, CoreDiagnostics coreDiagnostics) { }

	[CompilerGenerated]
	private bool <InitializeAsync>g__HasInitializationFailed|27_0() { }

	[CompilerGenerated]
	public override void add_Initialized(Action value) { }

	[CompilerGenerated]
	public override void add_InitializeFailed(Action<Exception> value) { }

	internal void EnableInitialization() { }

	[AsyncStateMachine(typeof(<EnableInitializationAsync>d__36))]
	internal Task EnableInitializationAsync() { }

	[CompilerGenerated]
	internal CoreDiagnostics get_Diagnostics() { }

	[CompilerGenerated]
	internal CoreMetrics get_Metrics() { }

	public InitializationOptions get_Options() { }

	[CompilerGenerated]
	internal CoreRegistry get_Registry() { }

	[CompilerGenerated]
	public override ServicesInitializationState get_State() { }

	public override string GetIdentifier() { }

	public override T GetService() { }

	private bool HasRequestedInitialization() { }

	[AsyncStateMachine(typeof(<InitializeAsync>d__27))]
	public override Task InitializeAsync(InitializationOptions options) { }

	[AsyncStateMachine(typeof(<InitializeServicesAsync>d__33))]
	private Task InitializeServicesAsync() { }

	[CompilerGenerated]
	public override void remove_Initialized(Action value) { }

	[CompilerGenerated]
	public override void remove_InitializeFailed(Action<Exception> value) { }

	internal void SendInitializationMetrics(List<PackageInitializationInfo> packageInitInfos) { }

	internal void set_Options(InitializationOptions value) { }

	[CompilerGenerated]
	private void set_State(ServicesInitializationState value) { }

	private void TriggerInitializeFailed(Exception initException) { }

	private void TriggerInitializeSuccess() { }

}

