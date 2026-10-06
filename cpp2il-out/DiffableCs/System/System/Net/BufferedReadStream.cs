namespace System.Net;

internal class BufferedReadStream : WebReadStream
{
	[CompilerGenerated]
	private struct <ProcessReadAsync>d__2 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Int32> <>t__builder; //Field offset: 0x8
		public CancellationToken cancellationToken; //Field offset: 0x20
		public BufferedReadStream <>4__this; //Field offset: 0x28
		public int size; //Field offset: 0x30
		public Byte[] buffer; //Field offset: 0x38
		public int offset; //Field offset: 0x40
		private ConfiguredTaskAwaiter<Int32> <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private readonly BufferOffsetSize readBuffer; //Field offset: 0x40

	public BufferedReadStream(WebOperation operation, Stream innerStream, BufferOffsetSize readBuffer) { }

	[AsyncStateMachine(typeof(<ProcessReadAsync>d__2))]
	protected virtual Task<Int32> ProcessReadAsync(Byte[] buffer, int offset, int size, CancellationToken cancellationToken) { }

	internal bool TryReadFromBuffer(Byte[] buffer, int offset, int size, out int result) { }

}

