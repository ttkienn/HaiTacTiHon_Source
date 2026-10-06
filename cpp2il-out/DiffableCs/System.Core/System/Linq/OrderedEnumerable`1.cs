namespace System.Linq;

internal abstract class OrderedEnumerable : IOrderedEnumerable<TElement>, IEnumerable<TElement>, IEnumerable
{
	[CompilerGenerated]
	private sealed class <GetEnumerator>d__1 : IEnumerator<TElement>, IDisposable, IEnumerator
	{
		private int <>1__state; //Field offset: 0x0
		private TElement <>2__current; //Field offset: 0x0
		public OrderedEnumerable<TElement> <>4__this; //Field offset: 0x0
		private Buffer<TElement> <buffer>5__2; //Field offset: 0x0
		private Int32[] <map>5__3; //Field offset: 0x0
		private int <i>5__4; //Field offset: 0x0

		private override TElement System.Collections.Generic.IEnumerator<TElement>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 35
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 70
		}

		[DebuggerHidden]
		public <GetEnumerator>d__1(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override TElement System.Collections.Generic.IEnumerator<TElement>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	internal IEnumerable<TElement> source; //Field offset: 0x0

	protected OrderedEnumerable`1() { }

	internal abstract EnumerableSorter<TElement> GetEnumerableSorter(EnumerableSorter<TElement> next) { }

	[IteratorStateMachine(typeof(<GetEnumerator>d__1))]
	public override IEnumerator<TElement> GetEnumerator() { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	private override IOrderedEnumerable<TElement> System.Linq.IOrderedEnumerable<TElement>.CreateOrderedEnumerable(Func<TElement, TKey> keySelector, IComparer<TKey> comparer, bool descending) { }

}

