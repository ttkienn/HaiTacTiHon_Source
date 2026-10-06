namespace System.Linq.Expressions.Interpreter;

[DefaultMember("Item")]
internal class HybridReferenceDictionary
{
	[CompilerGenerated]
	private sealed class <GetEnumeratorWorker>d__7 : IEnumerator<KeyValuePair`2<TKey, TValue>>, IDisposable, IEnumerator
	{
		private int <>1__state; //Field offset: 0x0
		private KeyValuePair<TKey, TValue> <>2__current; //Field offset: 0x0
		public HybridReferenceDictionary<TKey, TValue> <>4__this; //Field offset: 0x0
		private int <i>5__2; //Field offset: 0x0

		private override KeyValuePair<TKey, TValue> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 11
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 43
		}

		[DebuggerHidden]
		public <GetEnumeratorWorker>d__7(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override KeyValuePair<TKey, TValue> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	private KeyValuePair<TKey, TValue>[] _keysAndValues; //Field offset: 0x0
	private Dictionary<TKey, TValue> _dict; //Field offset: 0x0

	public TValue Item
	{
		 get { } //Length: 309
		 set { } //Length: 784
	}

	public HybridReferenceDictionary`2() { }

	public bool ContainsKey(TKey key) { }

	public TValue get_Item(TKey key) { }

	public IEnumerator<KeyValuePair`2<TKey, TValue>> GetEnumerator() { }

	[IteratorStateMachine(typeof(<GetEnumeratorWorker>d__7))]
	private IEnumerator<KeyValuePair`2<TKey, TValue>> GetEnumeratorWorker() { }

	public void Remove(TKey key) { }

	public void set_Item(TKey key, TValue value) { }

	public bool TryGetValue(TKey key, out TValue value) { }

}

