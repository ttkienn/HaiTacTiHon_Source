namespace Unity.Services.Core.Internal;

internal static class UnityServicesInitializer
{
	[CompilerGenerated]
	private struct <EnableServicesInitializationAsync>d__1 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}


	internal static IUnityServices CreateInstance(string servicesId) { }

	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType::AfterAssembliesLoaded (2))]
	private static void CreateStaticInstance() { }

	[AsyncStateMachine(typeof(<EnableServicesInitializationAsync>d__1))]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType::AfterSceneLoad (0))]
	private static void EnableServicesInitializationAsync() { }

}

