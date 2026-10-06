namespace System.Threading;

[DebuggerDisplay("IsCancellationRequested = {IsCancellationRequested}")]
[IsReadOnly]
public struct CancellationToken
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal void <.cctor>b__26_0(object obj) { }

	}

	private static readonly Action<Object> s_actionToActionObjShunt; //Field offset: 0x0
	private readonly CancellationTokenSource _source; //Field offset: 0x0

	public bool CanBeCanceled
	{
		 get { } //Length: 8
	}

	public bool IsCancellationRequested
	{
		 get { } //Length: 49
	}

	public static CancellationToken None
	{
		 get { } //Length: 3
	}

	private static CancellationToken() { }

	internal CancellationToken(CancellationTokenSource source) { }

	public CancellationToken(bool canceled) { }

	public bool Equals(CancellationToken other) { }

	public virtual bool Equals(object other) { }

	public bool get_CanBeCanceled() { }

	public bool get_IsCancellationRequested() { }

	public static CancellationToken get_None() { }

	public virtual int GetHashCode() { }

	internal CancellationTokenRegistration InternalRegisterWithoutEC(Action<Object> callback, object state) { }

	public static bool op_Equality(CancellationToken left, CancellationToken right) { }

	public static bool op_Inequality(CancellationToken left, CancellationToken right) { }

	public CancellationTokenRegistration Register(Action callback) { }

	public CancellationTokenRegistration Register(Action<Object> callback, object state, bool useSynchronizationContext, bool useExecutionContext) { }

	public void ThrowIfCancellationRequested() { }

	private void ThrowOperationCanceledException() { }

}

