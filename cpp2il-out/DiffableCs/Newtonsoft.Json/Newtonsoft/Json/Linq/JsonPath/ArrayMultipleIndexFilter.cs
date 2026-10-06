namespace Newtonsoft.Json.Linq.JsonPath;

[Nullable(0)]
[NullableContext(1)]
internal class ArrayMultipleIndexFilter : PathFilter
{
	[CompilerGenerated]
	private sealed class <ExecuteFilter>d__2 : IEnumerable<JToken>, IEnumerable, IEnumerator<JToken>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private JToken <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1}])]
		private IEnumerable<JToken> current; //Field offset: 0x28
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1}])]
		public IEnumerable<JToken> <>3__current; //Field offset: 0x30
		[Nullable(0)]
		public ArrayMultipleIndexFilter <>4__this; //Field offset: 0x38
		[Nullable(0)]
		private JsonSelectSettings settings; //Field offset: 0x40
		[Nullable(0)]
		public JsonSelectSettings <>3__settings; //Field offset: 0x48
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1}])]
		private IEnumerator<JToken> <>7__wrap1; //Field offset: 0x50
		[Nullable(0)]
		private JToken <t>5__3; //Field offset: 0x58
		[Nullable(0)]
		private Enumerator<Int32> <>7__wrap3; //Field offset: 0x60

		private override JToken System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken>.Current
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
		public <ExecuteFilter>d__2(int <>1__state) { }

		private void <>m__Finally1() { }

		private void <>m__Finally2() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator<JToken> System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>.GetEnumerator() { }

		[DebuggerHidden]
		private override JToken System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	internal List<Int32> Indexes; //Field offset: 0x10

	public ArrayMultipleIndexFilter(List<Int32> indexes) { }

	[IteratorStateMachine(typeof(<ExecuteFilter>d__2))]
	public virtual IEnumerable<JToken> ExecuteFilter(JToken root, IEnumerable<JToken> current, JsonSelectSettings settings) { }

}

