namespace System.IO;

public class StreamReader : TextReader
{
	[CompilerGenerated]
	private struct <ReadAsyncInternal>d__66 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncValueTaskMethodBuilder<Int32> <>t__builder; //Field offset: 0x8
		public StreamReader <>4__this; //Field offset: 0x28
		public Memory<Char> buffer; //Field offset: 0x30
		public CancellationToken cancellationToken; //Field offset: 0x40
		private int <charsRead>5__2; //Field offset: 0x48
		private bool <readToUserBuffer>5__3; //Field offset: 0x4C
		private Byte[] <tmpByteBuffer>5__4; //Field offset: 0x50
		private Stream <tmpStream>5__5; //Field offset: 0x58
		private int <count>5__6; //Field offset: 0x60
		private ConfiguredTaskAwaiter<Int32> <>u__1; //Field offset: 0x68
		private int <n>5__7; //Field offset: 0x78
		private ConfiguredValueTaskAwaiter<Int32> <>u__2; //Field offset: 0x80

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ReadBufferAsync>d__69 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Int32> <>t__builder; //Field offset: 0x8
		public StreamReader <>4__this; //Field offset: 0x20
		private Byte[] <tmpByteBuffer>5__2; //Field offset: 0x28
		private Stream <tmpStream>5__3; //Field offset: 0x30
		private ConfiguredValueTaskAwaiter<Int32> <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private class NullStreamReader : StreamReader
	{

		public virtual Stream BaseStream
		{
			 get { } //Length: 78
		}

		public virtual Encoding CurrentEncoding
		{
			 get { } //Length: 7
		}

		internal NullStreamReader() { }

		protected virtual void Dispose(bool disposing) { }

		public virtual Stream get_BaseStream() { }

		public virtual Encoding get_CurrentEncoding() { }

		public virtual int Peek() { }

		public virtual int Read() { }

		public virtual int Read(Char[] buffer, int index, int count) { }

		internal virtual int ReadBuffer() { }

		public virtual string ReadLine() { }

		public virtual string ReadToEnd() { }

	}

	public static readonly StreamReader Null; //Field offset: 0x0
	private Stream _stream; //Field offset: 0x18
	private Encoding _encoding; //Field offset: 0x20
	private Decoder _decoder; //Field offset: 0x28
	private Byte[] _byteBuffer; //Field offset: 0x30
	private Char[] _charBuffer; //Field offset: 0x38
	private int _charPos; //Field offset: 0x40
	private int _charLen; //Field offset: 0x44
	private int _byteLen; //Field offset: 0x48
	private int _bytePos; //Field offset: 0x4C
	private int _maxCharsPerBuffer; //Field offset: 0x50
	private bool _detectEncoding; //Field offset: 0x54
	private bool _checkPreamble; //Field offset: 0x55
	private bool _isBlocked; //Field offset: 0x56
	private bool _closable; //Field offset: 0x57
	private Task _asyncReadTask; //Field offset: 0x58

	public override Stream BaseStream
	{
		 get { } //Length: 5
	}

	public override Encoding CurrentEncoding
	{
		 get { } //Length: 5
	}

	internal bool LeaveOpen
	{
		internal get { } //Length: 8
	}

	private static StreamReader() { }

	public StreamReader(string path, Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize) { }

	internal StreamReader() { }

	public StreamReader(Stream stream, Encoding encoding) { }

	public StreamReader(Stream stream, Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize, bool leaveOpen) { }

	public StreamReader(string path) { }

	public StreamReader(string path, bool detectEncodingFromByteOrderMarks) { }

	public StreamReader(string path, Encoding encoding) { }

	public StreamReader(string path, Encoding encoding, bool detectEncodingFromByteOrderMarks) { }

	private void CheckAsyncTaskInProgress() { }

	public virtual void Close() { }

	private void CompressBuffer(int n) { }

	internal bool DataAvailable() { }

	private void DetectEncoding() { }

	protected virtual void Dispose(bool disposing) { }

	public override Stream get_BaseStream() { }

	public override Encoding get_CurrentEncoding() { }

	internal bool get_LeaveOpen() { }

	private void Init(Stream stream, Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize, bool leaveOpen) { }

	internal void Init(Stream stream) { }

	private bool IsPreamble() { }

	public virtual int Peek() { }

	public virtual int Read(Char[] buffer, int index, int count) { }

	public virtual int Read(Span<Char> buffer) { }

	public virtual int Read() { }

	public virtual Task<Int32> ReadAsync(Char[] buffer, int index, int count) { }

	[AsyncStateMachine(typeof(<ReadAsyncInternal>d__66))]
	internal virtual ValueTask<Int32> ReadAsyncInternal(Memory<Char> buffer, CancellationToken cancellationToken) { }

	internal override int ReadBuffer() { }

	private int ReadBuffer(Span<Char> userBuffer, out bool readToUserBuffer) { }

	[AsyncStateMachine(typeof(<ReadBufferAsync>d__69))]
	private Task<Int32> ReadBufferAsync() { }

	public virtual string ReadLine() { }

	private int ReadSpan(Span<Char> buffer) { }

	public virtual string ReadToEnd() { }

	private static void ThrowAsyncIOInProgress() { }

}

