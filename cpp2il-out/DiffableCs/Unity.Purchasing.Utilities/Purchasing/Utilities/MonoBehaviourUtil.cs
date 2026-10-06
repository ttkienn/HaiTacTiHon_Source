namespace Purchasing.Utilities;

[AddComponentMenu(null)]
[HideInInspector]
internal class MonoBehaviourUtil : MonoBehaviour, IMonoBehaviourUtil
{
	[CompilerGenerated]
	private sealed class <DelayedCoroutine>d__1 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public int delay; //Field offset: 0x20
		public MonoBehaviourUtil <>4__this; //Field offset: 0x28
		public IEnumerator coroutine; //Field offset: 0x30

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
		public <DelayedCoroutine>d__1(int <>1__state) { }

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


	public MonoBehaviourUtil() { }

	[IteratorStateMachine(typeof(<DelayedCoroutine>d__1))]
	public override IEnumerator DelayedCoroutine(IEnumerator coroutine, int delay) { }

	public override GameObject[] GetGameObjects() { }

	private override Coroutine Purchasing.Utilities.IMonoBehaviourUtil.StartCoroutine(IEnumerator start) { }

}

