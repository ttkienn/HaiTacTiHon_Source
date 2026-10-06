namespace UnityEngine.Purchasing;

[Extension]
[Nullable(0)]
[NullableContext(1)]
internal static class EnumerableExtensions
{
	[CompilerGenerated]
	private sealed class <>c__0
	{
		[Nullable(0)]
		public static readonly <>c__0<T> <>9; //Field offset: 0x0
		[Nullable(0)]
		public static Func<T, Boolean> <>9__0_0; //Field offset: 0x0

		private static <>c__0`1() { }

		public <>c__0`1() { }

		[NullableContext(0)]
		internal bool <NonNull>b__0_0(T obj) { }

	}

	[CompilerGenerated]
	private sealed class <IgnoreExceptions>d__1 : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x0
		[Nullable(0)]
		private T <>2__current; //Field offset: 0x0
		private int <>l__initialThreadId; //Field offset: 0x0
		[Nullable(0)]
		private IEnumerable<T> enumerable; //Field offset: 0x0
		[Nullable(0)]
		public IEnumerable<T> <>3__enumerable; //Field offset: 0x0
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1}])]
		private Action<TException> onException; //Field offset: 0x0
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1}])]
		public Action<TException> <>3__onException; //Field offset: 0x0
		[Nullable(0)]
		private IEnumerator<T> <enumerator>5__2; //Field offset: 0x0
		private bool <hasNext>5__3; //Field offset: 0x0

		private override T System.Collections.Generic.IEnumerator<T>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <IgnoreExceptions>d__1`2(int <>1__state) { }

		private void <>m__Finally1() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

		[DebuggerHidden]
		private override T System.Collections.Generic.IEnumerator<T>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}


	[Extension]
	[IteratorStateMachine(typeof(<IgnoreExceptions>d__1`2))]
	public static IEnumerable<T> IgnoreExceptions(IEnumerable<T> enumerable, Action<TException> onException = null) { }

	[Extension]
	public static IEnumerable<T> NonNull(IEnumerable<T> enumerable) { }

}

