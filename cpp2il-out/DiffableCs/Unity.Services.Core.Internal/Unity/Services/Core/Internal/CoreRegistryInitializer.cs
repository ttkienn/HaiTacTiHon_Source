namespace Unity.Services.Core.Internal;

internal class CoreRegistryInitializer
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass3_0
	{
		private struct <<InitializeRegistryAsync>g__InitializePackageAsync|2>d : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
			public <>c__DisplayClass3_0 <>4__this; //Field offset: 0x20
			public IInitializablePackage package; //Field offset: 0x28
			private TaskAwaiter <>u__1; //Field offset: 0x30

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		private struct <<InitializeRegistryAsync>g__TryInitializePackageAsync|0>d : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
			public <>c__DisplayClass3_0 <>4__this; //Field offset: 0x20
			public IInitializablePackage package; //Field offset: 0x28
			private TaskAwaiter <>u__1; //Field offset: 0x30

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		public Stopwatch stopwatch; //Field offset: 0x10
		public List<PackageInitializationInfo> packagesInitInfos; //Field offset: 0x18
		public List<Exception> failureReasons; //Field offset: 0x20
		public CoreRegistryInitializer <>4__this; //Field offset: 0x28
		public DependencyTree dependencyTree; //Field offset: 0x30

		public <>c__DisplayClass3_0() { }

		internal void <InitializeRegistryAsync>g__Fail|3() { }

		internal IInitializablePackage <InitializeRegistryAsync>g__GetPackageAt|1(int index) { }

		[AsyncStateMachine(typeof(<<InitializeRegistryAsync>g__InitializePackageAsync|2>d))]
		internal Task <InitializeRegistryAsync>g__InitializePackageAsync|2(IInitializablePackage package) { }

		[AsyncStateMachine(typeof(<<InitializeRegistryAsync>g__TryInitializePackageAsync|0>d))]
		internal Task <InitializeRegistryAsync>g__TryInitializePackageAsync|0(IInitializablePackage package) { }

	}

	[CompilerGenerated]
	private struct <InitializeRegistryAsync>d__3 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<List`1<PackageInitializationInfo>> <>t__builder; //Field offset: 0x8
		public CoreRegistryInitializer <>4__this; //Field offset: 0x20
		private <>c__DisplayClass3_0 <>8__1; //Field offset: 0x28
		private int <i>5__2; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[NotNull]
	private readonly CoreRegistry m_Registry; //Field offset: 0x10
	[NotNull]
	private readonly List<Int32> m_SortedPackageTypeHashes; //Field offset: 0x18

	public CoreRegistryInitializer(CoreRegistry registry, List<Int32> sortedPackageTypeHashes) { }

	[AsyncStateMachine(typeof(<InitializeRegistryAsync>d__3))]
	public Task<List`1<PackageInitializationInfo>> InitializeRegistryAsync() { }

}

