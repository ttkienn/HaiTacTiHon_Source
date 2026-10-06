namespace System.Linq.Expressions;

internal sealed class StackGuard
{
	[CompilerGenerated]
	private sealed class <>c__3
	{
		public static readonly <>c__3<T1, T2> <>9; //Field offset: 0x0
		public static Func<Object, Object> <>9__3_0; //Field offset: 0x0

		private static <>c__3`2() { }

		public <>c__3`2() { }

		internal object <RunOnEmptyStack>b__3_0(object s) { }

	}

	private int _executionStackCount; //Field offset: 0x10

	public StackGuard() { }

	public void RunOnEmptyStack(Action<T1, T2> action, T1 arg1, T2 arg2) { }

	private R RunOnEmptyStackCore(Func<Object, R> action, object state) { }

	public bool TryEnterOnCurrentStack() { }

}

