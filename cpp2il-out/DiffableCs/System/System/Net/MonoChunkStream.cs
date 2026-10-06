namespace System.Net;

internal class MonoChunkStream : WebReadStream
{
	[CompilerGenerated]
	private struct <FinishReading>d__8 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public MonoChunkStream <>4__this; //Field offset: 0x20
		public CancellationToken cancellationToken; //Field offset: 0x28
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x30
		private Byte[] <buffer>5__2; //Field offset: 0x40
		private ConfiguredTaskAwaiter<Int32> <>u__2; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ProcessReadAsync>d__7 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Int32> <>t__builder; //Field offset: 0x8
		public CancellationToken cancellationToken; //Field offset: 0x20
		public MonoChunkStream <>4__this; //Field offset: 0x28
		public Byte[] buffer; //Field offset: 0x30
		public int offset; //Field offset: 0x38
		public int size; //Field offset: 0x3C
		private Byte[] <moreBytes>5__2; //Field offset: 0x40
		private ConfiguredTaskAwaiter<Int32> <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private readonly WebHeaderCollection <Headers>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	private readonly MonoChunkParser <Decoder>k__BackingField; //Field offset: 0x48

	protected MonoChunkParser Decoder
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public MonoChunkStream(WebOperation operation, Stream innerStream, WebHeaderCollection headers) { }

	[CompilerGenerated]
	[DebuggerHidden]
	private Task <>n__0(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(<FinishReading>d__8))]
	internal virtual Task FinishReading(CancellationToken cancellationToken) { }

	[CompilerGenerated]
	protected MonoChunkParser get_Decoder() { }

	[AsyncStateMachine(typeof(<ProcessReadAsync>d__7))]
	protected virtual Task<Int32> ProcessReadAsync(Byte[] buffer, int offset, int size, CancellationToken cancellationToken) { }

	private static void ThrowExpectingChunkTrailer() { }

}

