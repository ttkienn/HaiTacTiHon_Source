namespace System.Runtime.CompilerServices;

internal struct AsyncMethodBuilderCore
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static SendOrPostCallback <>9__7_0; //Field offset: 0x8
		public static WaitCallback <>9__7_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal void <ThrowAsync>b__7_0(object state) { }

		internal void <ThrowAsync>b__7_1(object state) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass5_0
	{
		public Task innerTask; //Field offset: 0x10
		public Action continuation; //Field offset: 0x18

		public <>c__DisplayClass5_0() { }

		internal void <OutputAsyncCausalityEvents>b__0() { }

	}

	private class ContinuationWrapper
	{
		internal readonly Action m_continuation; //Field offset: 0x10
		private readonly Action m_invokeAction; //Field offset: 0x18
		internal readonly Task m_innerTask; //Field offset: 0x20

		internal ContinuationWrapper(Action continuation, Action invokeAction, Task innerTask) { }

		internal void Invoke() { }

	}

	public sealed class MoveNextRunner
	{
		private static ContextCallback s_invokeMoveNext; //Field offset: 0x0
		private readonly ExecutionContext m_context; //Field offset: 0x10
		internal IAsyncStateMachine m_stateMachine; //Field offset: 0x18

		internal MoveNextRunner(ExecutionContext context, IAsyncStateMachine stateMachine) { }

		private static void InvokeMoveNext(object stateMachine) { }

		internal void Run() { }

	}

	internal IAsyncStateMachine m_stateMachine; //Field offset: 0x0
	internal Action m_defaultContextAction; //Field offset: 0x8

	internal static Action CreateContinuationWrapper(Action continuation, Action invokeAction, Task innerTask = null) { }

	internal Action GetCompletionAction(Task taskForTracing, ref MoveNextRunner runnerToInitialize) { }

	private Action OutputAsyncCausalityEvents(Task innerTask, Action continuation) { }

	internal void PostBoxInitialization(IAsyncStateMachine stateMachine, MoveNextRunner runner, Task builtTask) { }

	public void SetStateMachine(IAsyncStateMachine stateMachine) { }

	internal static void ThrowAsync(Exception exception, SynchronizationContext targetContext) { }

	internal static Task TryGetContinuationTask(Action action) { }

}

