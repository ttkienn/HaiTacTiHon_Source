namespace System.Net;

internal class FixedSizeReadStream : WebReadStream
{
	[CompilerGenerated]
	private struct <ProcessReadAsync>d__5 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Int32> <>t__builder; //Field offset: 0x8
		public CancellationToken cancellationToken; //Field offset: 0x20
		public FixedSizeReadStream <>4__this; //Field offset: 0x28
		public int size; //Field offset: 0x30
		public Byte[] buffer; //Field offset: 0x38
		public int offset; //Field offset: 0x40
		private ConfiguredTaskAwaiter<Int32> <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private readonly long <ContentLength>k__BackingField; //Field offset: 0x40
	private long position; //Field offset: 0x48

	public long ContentLength
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public FixedSizeReadStream(WebOperation operation, Stream innerStream, long contentLength) { }

	[CompilerGenerated]
	public long get_ContentLength() { }

	[AsyncStateMachine(typeof(<ProcessReadAsync>d__5))]
	protected virtual Task<Int32> ProcessReadAsync(Byte[] buffer, int offset, int size, CancellationToken cancellationToken) { }

}

