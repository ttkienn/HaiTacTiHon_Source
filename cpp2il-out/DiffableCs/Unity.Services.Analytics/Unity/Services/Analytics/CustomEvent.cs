namespace Unity.Services.Analytics;

[DefaultMember("Item")]
public class CustomEvent : Event, IEnumerable
{
	[CompilerGenerated]
	private sealed class <GetEnumerator>d__4 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public CustomEvent <>4__this; //Field offset: 0x20
		private Enumerator<String, String> <>7__wrap1; //Field offset: 0x28
		private Enumerator<String, Int64> <>7__wrap2; //Field offset: 0x50
		private Enumerator<String, Double> <>7__wrap3; //Field offset: 0x78
		private Enumerator<String, Boolean> <>7__wrap4; //Field offset: 0xA0

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
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
		public <GetEnumerator>d__4(int <>1__state) { }

		private void <>m__Finally1() { }

		private void <>m__Finally2() { }

		private void <>m__Finally3() { }

		private void <>m__Finally4() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}


	public string Item
	{
		 set { } //Length: 8
	}

	public CustomEvent(string name) { }

	public void Add(string key, object value) { }

	[IteratorStateMachine(typeof(<GetEnumerator>d__4))]
	public override IEnumerator GetEnumerator() { }

	public void set_Item(string key, object value) { }

}

