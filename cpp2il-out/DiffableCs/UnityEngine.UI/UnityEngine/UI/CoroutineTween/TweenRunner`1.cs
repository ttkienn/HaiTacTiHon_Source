namespace UnityEngine.UI.CoroutineTween;

internal class TweenRunner
{
	[CompilerGenerated]
	private sealed class <Start>d__2 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x0
		private object <>2__current; //Field offset: 0x0
		public T tweenInfo; //Field offset: 0x0
		private float <elapsedTime>5__2; //Field offset: 0x0

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
		public <Start>d__2(int <>1__state) { }

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

	protected MonoBehaviour m_CoroutineContainer; //Field offset: 0x0
	protected IEnumerator m_Tween; //Field offset: 0x0

	public TweenRunner`1() { }

	public void Init(MonoBehaviour coroutineContainer) { }

	[IteratorStateMachine(typeof(<Start>d__2))]
	private static IEnumerator Start(T tweenInfo) { }

	public void StartTween(T info) { }

	public void StopTween() { }

}

