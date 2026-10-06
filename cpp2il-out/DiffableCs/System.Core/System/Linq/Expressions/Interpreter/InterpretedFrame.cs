namespace System.Linq.Expressions.Interpreter;

internal sealed class InterpretedFrame
{
	[CompilerGenerated]
	private sealed class <GetStackTraceDebugInfo>d__29 : IEnumerable<InterpretedFrameInfo>, IEnumerable, IEnumerator<InterpretedFrameInfo>, IDisposable, IEnumerator
	{
		private int <>1__state; //Field offset: 0x10
		private InterpretedFrameInfo <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x28
		public InterpretedFrame <>4__this; //Field offset: 0x30
		private InterpretedFrame <frame>5__2; //Field offset: 0x38

		private override InterpretedFrameInfo System.Collections.Generic.IEnumerator<System.Linq.Expressions.Interpreter.InterpretedFrameInfo>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 11
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 69
		}

		[DebuggerHidden]
		public <GetStackTraceDebugInfo>d__29(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator<InterpretedFrameInfo> System.Collections.Generic.IEnumerable<System.Linq.Expressions.Interpreter.InterpretedFrameInfo>.GetEnumerator() { }

		[DebuggerHidden]
		private override InterpretedFrameInfo System.Collections.Generic.IEnumerator<System.Linq.Expressions.Interpreter.InterpretedFrameInfo>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[ThreadStatic]
	private static InterpretedFrame s_currentFrame; //Field offset: 0x80000000
	internal readonly Interpreter Interpreter; //Field offset: 0x10
	internal InterpretedFrame _parent; //Field offset: 0x18
	private readonly Int32[] _continuations; //Field offset: 0x20
	private int _continuationIndex; //Field offset: 0x28
	private int _pendingContinuation; //Field offset: 0x2C
	private object _pendingValue; //Field offset: 0x30
	public readonly Object[] Data; //Field offset: 0x38
	public readonly IStrongBox[] Closure; //Field offset: 0x40
	public int StackIndex; //Field offset: 0x48
	public int InstructionIndex; //Field offset: 0x4C

	public string Name
	{
		 get { } //Length: 27
	}

	public InterpretedFrame Parent
	{
		 get { } //Length: 5
	}

	internal InterpretedFrame(Interpreter interpreter, IStrongBox[] closure) { }

	public void Dup() { }

	internal InterpretedFrame Enter() { }

	public string get_Name() { }

	public InterpretedFrame get_Parent() { }

	public DebugInfo GetDebugInfo(int instructionIndex) { }

	[IteratorStateMachine(typeof(<GetStackTraceDebugInfo>d__29))]
	public IEnumerable<InterpretedFrameInfo> GetStackTraceDebugInfo() { }

	public int Goto(int labelIndex, object value, bool gotoExceptionHandler) { }

	internal bool IsJumpHappened() { }

	internal void Leave(InterpretedFrame prevFrame) { }

	public object Peek() { }

	public object Pop() { }

	internal void PopPendingContinuation() { }

	public void Push(short value) { }

	public void Push(sbyte value) { }

	public void Push(object value) { }

	public void Push(byte value) { }

	public void Push(ushort value) { }

	public void Push(bool value) { }

	public void Push(int value) { }

	public void PushContinuation(int continuation) { }

	internal void PushPendingContinuation() { }

	public void RemoveContinuation() { }

	internal void SaveTraceToException(Exception exception) { }

	internal void SetStackDepth(int depth) { }

	public int YieldToCurrentContinuation() { }

	public int YieldToPendingContinuation() { }

}

