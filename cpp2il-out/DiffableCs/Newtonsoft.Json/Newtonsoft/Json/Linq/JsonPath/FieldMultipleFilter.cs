namespace Newtonsoft.Json.Linq.JsonPath;

[Nullable(0)]
[NullableContext(1)]
internal class FieldMultipleFilter : PathFilter
{
	[CompilerGenerated]
	private sealed class <>c
	{
		[Nullable(0)]
		public static readonly <>c <>9; //Field offset: 0x0
		[Nullable(0)]
		public static Func<String, String> <>9__2_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		[NullableContext(0)]
		internal string <ExecuteFilter>b__2_0(string n) { }

	}

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
		public FieldMultipleFilter <>4__this; //Field offset: 0x38
		[Nullable(0)]
		private JsonSelectSettings settings; //Field offset: 0x40
		[Nullable(0)]
		public JsonSelectSettings <>3__settings; //Field offset: 0x48
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1}])]
		private IEnumerator<JToken> <>7__wrap1; //Field offset: 0x50
		[Nullable(0)]
		private JObject <o>5__3; //Field offset: 0x58
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1}])]
		private Enumerator<String> <>7__wrap3; //Field offset: 0x60
		[Nullable(0)]
		private string <name>5__5; //Field offset: 0x78

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

	internal List<String> Names; //Field offset: 0x10

	public FieldMultipleFilter(List<String> names) { }

	[IteratorStateMachine(typeof(<ExecuteFilter>d__2))]
	public virtual IEnumerable<JToken> ExecuteFilter(JToken root, IEnumerable<JToken> current, JsonSelectSettings settings) { }

}

