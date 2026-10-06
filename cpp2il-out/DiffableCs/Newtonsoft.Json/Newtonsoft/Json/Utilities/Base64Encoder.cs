namespace Newtonsoft.Json.Utilities;

[Nullable(0)]
[NullableContext(1)]
internal class Base64Encoder
{
	[CompilerGenerated]
	private struct <EncodeAsync>d__13 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public Base64Encoder <>4__this; //Field offset: 0x20
		[Nullable(0)]
		public Byte[] buffer; //Field offset: 0x28
		public int index; //Field offset: 0x30
		public int count; //Field offset: 0x34
		public CancellationToken cancellationToken; //Field offset: 0x38
		private int <num4>5__2; //Field offset: 0x40
		private int <length>5__3; //Field offset: 0x44
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private const int Base64LineSize = 76; //Field offset: 0x0
	private const int LineSizeInBytes = 57; //Field offset: 0x0
	private readonly Char[] _charsLine; //Field offset: 0x10
	private readonly TextWriter _writer; //Field offset: 0x18
	[Nullable(2)]
	private Byte[] _leftOverBytes; //Field offset: 0x20
	private int _leftOverBytesCount; //Field offset: 0x28

	public Base64Encoder(TextWriter writer) { }

	public void Encode(Byte[] buffer, int index, int count) { }

	[AsyncStateMachine(typeof(<EncodeAsync>d__13))]
	public Task EncodeAsync(Byte[] buffer, int index, int count, CancellationToken cancellationToken) { }

	public void Flush() { }

	public Task FlushAsync(CancellationToken cancellationToken) { }

	private bool FulfillFromLeftover(Byte[] buffer, int index, ref int count) { }

	private void StoreLeftOverBytes(Byte[] buffer, int index, ref int count) { }

	private void ValidateEncode(Byte[] buffer, int index, int count) { }

	private void WriteChars(Char[] chars, int index, int count) { }

	private Task WriteCharsAsync(Char[] chars, int index, int count, CancellationToken cancellationToken) { }

}

