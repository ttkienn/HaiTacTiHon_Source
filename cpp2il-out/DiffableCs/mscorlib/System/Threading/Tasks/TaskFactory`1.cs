namespace System.Threading.Tasks;

public class TaskFactory
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass35_0
	{
		public Func<IAsyncResult, TResult> endFunction; //Field offset: 0x0
		public Action<IAsyncResult> endAction; //Field offset: 0x0
		public Task<TResult> promise; //Field offset: 0x0

		public <>c__DisplayClass35_0() { }

		internal void <FromAsyncImpl>b__0(IAsyncResult iar) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass38_0
	{
		public Func<IAsyncResult, TResult> endFunction; //Field offset: 0x0
		public Action<IAsyncResult> endAction; //Field offset: 0x0
		public Task<TResult> promise; //Field offset: 0x0

		public <>c__DisplayClass38_0`1() { }

		internal void <FromAsyncImpl>b__0(IAsyncResult iar) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass41_0
	{
		public Func<IAsyncResult, TResult> endFunction; //Field offset: 0x0
		public Action<IAsyncResult> endAction; //Field offset: 0x0
		public Task<TResult> promise; //Field offset: 0x0

		public <>c__DisplayClass41_0`2() { }

		internal void <FromAsyncImpl>b__0(IAsyncResult iar) { }

	}

	private sealed class FromAsyncTrimPromise : Task<TResult>
	{
		internal static readonly AsyncCallback s_completeFromAsyncResult; //Field offset: 0x0
		private TInstance m_thisRef; //Field offset: 0x0
		private Func<TInstance, IAsyncResult, TResult> m_endMethod; //Field offset: 0x0

		private static FromAsyncTrimPromise`1() { }

		internal FromAsyncTrimPromise`1(TInstance thisRef, Func<TInstance, IAsyncResult, TResult> endMethod) { }

		internal void Complete(TInstance thisRef, Func<TInstance, IAsyncResult, TResult> endMethod, IAsyncResult asyncResult, bool requiresSynchronization) { }

		internal static void CompleteFromAsyncResult(IAsyncResult asyncResult) { }

	}

	private CancellationToken m_defaultCancellationToken; //Field offset: 0x0
	private TaskScheduler m_defaultScheduler; //Field offset: 0x0
	private TaskCreationOptions m_defaultCreationOptions; //Field offset: 0x0
	private TaskContinuationOptions m_defaultContinuationOptions; //Field offset: 0x0

	public TaskFactory`1() { }

	public TaskFactory`1(CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskContinuationOptions continuationOptions, TaskScheduler scheduler) { }

	public Task<TResult> FromAsync(Func<AsyncCallback, Object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endMethod, object state) { }

	public Task<TResult> FromAsync(Func<TArg1, AsyncCallback, Object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endMethod, TArg1 arg1, object state) { }

	private static void FromAsyncCoreLogic(IAsyncResult iar, Func<IAsyncResult, TResult> endFunction, Action<IAsyncResult> endAction, Task<TResult> promise, bool requiresSynchronization) { }

	internal static Task<TResult> FromAsyncImpl(Func<AsyncCallback, Object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endFunction, Action<IAsyncResult> endAction, object state, TaskCreationOptions creationOptions) { }

	internal static Task<TResult> FromAsyncImpl(Func<TArg1, AsyncCallback, Object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endFunction, Action<IAsyncResult> endAction, TArg1 arg1, object state, TaskCreationOptions creationOptions) { }

	internal static Task<TResult> FromAsyncImpl(Func<TArg1, TArg2, AsyncCallback, Object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endFunction, Action<IAsyncResult> endAction, TArg1 arg1, TArg2 arg2, object state, TaskCreationOptions creationOptions) { }

	internal static Task<TResult> FromAsyncTrim(TInstance thisRef, TArgs args, Func<TInstance, TArgs, AsyncCallback, Object, IAsyncResult> beginMethod, Func<TInstance, IAsyncResult, TResult> endMethod) { }

	public Task<TResult> StartNew(Func<TResult> function, CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskScheduler scheduler) { }

	public Task<TResult> StartNew(Func<Object, TResult> function, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskScheduler scheduler) { }

}

