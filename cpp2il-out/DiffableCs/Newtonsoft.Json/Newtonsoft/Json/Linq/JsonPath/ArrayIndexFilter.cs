namespace Newtonsoft.Json.Linq.JsonPath;

internal class ArrayIndexFilter : PathFilter
{
	[CompilerGenerated]
	private sealed class <ExecuteFilter>d__4 : IEnumerable<JToken>, IEnumerable, IEnumerator<JToken>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		[Nullable(1)]
		private JToken <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1}])]
		private IEnumerable<JToken> current; //Field offset: 0x28
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1}])]
		public IEnumerable<JToken> <>3__current; //Field offset: 0x30
		public ArrayIndexFilter <>4__this; //Field offset: 0x38
		private JsonSelectSettings settings; //Field offset: 0x40
		public JsonSelectSettings <>3__settings; //Field offset: 0x48
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1}])]
		private IEnumerator<JToken> <>7__wrap1; //Field offset: 0x50
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1}])]
		private IEnumerator<JToken> <>7__wrap2; //Field offset: 0x58

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
		public <ExecuteFilter>d__4(int <>1__state) { }

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

	[CompilerGenerated]
	private Nullable<Int32> <Index>k__BackingField; //Field offset: 0x10

	public Nullable<Int32> Index
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public ArrayIndexFilter() { }

	[IteratorStateMachine(typeof(<ExecuteFilter>d__4))]
	[NullableContext(1)]
	public virtual IEnumerable<JToken> ExecuteFilter(JToken root, IEnumerable<JToken> current, JsonSelectSettings settings) { }

	[CompilerGenerated]
	public Nullable<Int32> get_Index() { }

	[CompilerGenerated]
	public void set_Index(Nullable<Int32> value) { }

}

