namespace System.Threading;

public class CancellationTokenSource : IDisposable
{
	private sealed class Linked1CancellationTokenSource : CancellationTokenSource
	{
		private readonly CancellationTokenRegistration _reg1; //Field offset: 0x40

		internal Linked1CancellationTokenSource(CancellationToken token1) { }

		protected virtual void Dispose(bool disposing) { }

	}

	private sealed class Linked2CancellationTokenSource : CancellationTokenSource
	{
		private readonly CancellationTokenRegistration _reg1; //Field offset: 0x40
		private readonly CancellationTokenRegistration _reg2; //Field offset: 0x58

		internal Linked2CancellationTokenSource(CancellationToken token1, CancellationToken token2) { }

		protected virtual void Dispose(bool disposing) { }

	}

	private sealed class LinkedNCancellationTokenSource : CancellationTokenSource
	{
		[CompilerGenerated]
		private sealed class <>c
		{
			public static readonly <>c <>9; //Field offset: 0x0

			private static <>c() { }

			public <>c() { }

			internal void <.cctor>b__4_0(object s) { }

		}

		internal static readonly Action<Object> s_linkedTokenCancelDelegate; //Field offset: 0x0

		private static LinkedNCancellationTokenSource() { }

	}

	internal static readonly CancellationTokenSource s_canceledSource; //Field offset: 0x0
	private const int CannotBeCanceled = 0; //Field offset: 0x0
	private const int NotCanceledState = 1; //Field offset: 0x0
	private const int NotifyingState = 2; //Field offset: 0x0
	private const int NotifyingCompleteState = 3; //Field offset: 0x0
	internal static readonly CancellationTokenSource s_neverCanceledSource; //Field offset: 0x8
	private static readonly int s_nLists; //Field offset: 0x10
	private static readonly TimerCallback s_timerCallback; //Field offset: 0x18
	private ManualResetEvent _kernelEvent; //Field offset: 0x10
	private SparselyPopulatedArray<CancellationCallbackInfo>[] _registeredCallbacksLists; //Field offset: 0x18
	private int _state; //Field offset: 0x20
	private int _threadIDExecutingCallbacks; //Field offset: 0x24
	private bool _disposed; //Field offset: 0x28
	private CancellationCallbackInfo _executingCallback; //Field offset: 0x30
	private Timer _timer; //Field offset: 0x38

	internal CancellationCallbackInfo ExecutingCallback
	{
		internal get { } //Length: 24
	}

	internal bool IsCancellationCompleted
	{
		internal get { } //Length: 26
	}

	public bool IsCancellationRequested
	{
		 get { } //Length: 26
	}

	internal bool IsDisposed
	{
		internal get { } //Length: 5
	}

	internal int ThreadIDExecutingCallbacks
	{
		internal get { } //Length: 22
		internal set { } //Length: 34
	}

	public CancellationToken Token
	{
		 get { } //Length: 91
	}

	private static CancellationTokenSource() { }

	public CancellationTokenSource() { }

	public void Cancel() { }

	public void Cancel(bool throwOnFirstException) { }

	public void CancelAfter(int millisecondsDelay) { }

	private void CancellationCallbackCoreWork(CancellationCallbackCoreWorkArguments args) { }

	private void CancellationCallbackCoreWork_OnSyncContext(object obj) { }

	internal static CancellationTokenSource CreateLinkedTokenSource(CancellationToken token) { }

	public static CancellationTokenSource CreateLinkedTokenSource(CancellationToken token1, CancellationToken token2) { }

	protected override void Dispose(bool disposing) { }

	public override void Dispose() { }

	private void ExecuteCallbackHandlers(bool throwOnFirstException) { }

	internal CancellationCallbackInfo get_ExecutingCallback() { }

	internal bool get_IsCancellationCompleted() { }

	public bool get_IsCancellationRequested() { }

	internal bool get_IsDisposed() { }

	internal int get_ThreadIDExecutingCallbacks() { }

	public CancellationToken get_Token() { }

	internal CancellationTokenRegistration InternalRegister(Action<Object> callback, object stateForCallback, SynchronizationContext targetSyncContext, ExecutionContext executionContext) { }

	private void NotifyCancellation(bool throwOnFirstException) { }

	internal void set_ThreadIDExecutingCallbacks(int value) { }

	internal void ThrowIfDisposed() { }

	private static void ThrowObjectDisposedException() { }

	private static void TimerCallbackLogic(object obj) { }

	internal void WaitForCallbackToComplete(CancellationCallbackInfo callbackInfo) { }

}

