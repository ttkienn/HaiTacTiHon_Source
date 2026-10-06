namespace System.Security.Cryptography;

public class CryptoStream : Stream, IDisposable
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<SemaphoreSlim> <>9__54_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal SemaphoreSlim <get_AsyncActiveSemaphore>b__54_0() { }

	}

	[CompilerGenerated]
	private struct <ReadAsyncCore>d__42 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Int32> <>t__builder; //Field offset: 0x8
		public int count; //Field offset: 0x20
		public int offset; //Field offset: 0x24
		public CryptoStream <>4__this; //Field offset: 0x28
		public Byte[] buffer; //Field offset: 0x30
		public bool useAsync; //Field offset: 0x38
		public CancellationToken cancellationToken; //Field offset: 0x40
		private int <bytesToDeliver>5__2; //Field offset: 0x48
		private int <currentOutputIndex>5__3; //Field offset: 0x4C
		private int <numWholeBlocksInBytes>5__4; //Field offset: 0x50
		private Byte[] <tempInputBuffer>5__5; //Field offset: 0x58
		private Byte[] <tempOutputBuffer>5__6; //Field offset: 0x60
		private ValueTaskAwaiter<Int32> <>u__1; //Field offset: 0x68

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ReadAsyncInternal>d__37 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Int32> <>t__builder; //Field offset: 0x8
		public CryptoStream <>4__this; //Field offset: 0x20
		public Byte[] buffer; //Field offset: 0x28
		public int offset; //Field offset: 0x30
		public int count; //Field offset: 0x34
		public CancellationToken cancellationToken; //Field offset: 0x38
		private SemaphoreSlim <semaphore>5__2; //Field offset: 0x40
		private ForceAsyncAwaiter <>u__1; //Field offset: 0x48
		private TaskAwaiter<Int32> <>u__2; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <WriteAsyncCore>d__49 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public int count; //Field offset: 0x20
		public int offset; //Field offset: 0x24
		public CryptoStream <>4__this; //Field offset: 0x28
		public Byte[] buffer; //Field offset: 0x30
		public bool useAsync; //Field offset: 0x38
		public CancellationToken cancellationToken; //Field offset: 0x40
		private int <bytesToWrite>5__2; //Field offset: 0x48
		private int <currentInputIndex>5__3; //Field offset: 0x4C
		private int <numOutputBytes>5__4; //Field offset: 0x50
		private ValueTaskAwaiter <>u__1; //Field offset: 0x58
		private int <numWholeBlocksInBytes>5__5; //Field offset: 0x68
		private Byte[] <tempOutputBuffer>5__6; //Field offset: 0x70

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <WriteAsyncInternal>d__46 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public CryptoStream <>4__this; //Field offset: 0x20
		public Byte[] buffer; //Field offset: 0x28
		public int offset; //Field offset: 0x30
		public int count; //Field offset: 0x34
		public CancellationToken cancellationToken; //Field offset: 0x38
		private SemaphoreSlim <semaphore>5__2; //Field offset: 0x40
		private ForceAsyncAwaiter <>u__1; //Field offset: 0x48
		private TaskAwaiter <>u__2; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private readonly Stream _stream; //Field offset: 0x28
	private readonly ICryptoTransform _transform; //Field offset: 0x30
	private readonly CryptoStreamMode _transformMode; //Field offset: 0x38
	private Byte[] _inputBuffer; //Field offset: 0x40
	private int _inputBufferIndex; //Field offset: 0x48
	private int _inputBlockSize; //Field offset: 0x4C
	private Byte[] _outputBuffer; //Field offset: 0x50
	private int _outputBufferIndex; //Field offset: 0x58
	private int _outputBlockSize; //Field offset: 0x5C
	private bool _canRead; //Field offset: 0x60
	private bool _canWrite; //Field offset: 0x61
	private bool _finalBlockTransformed; //Field offset: 0x62
	private SemaphoreSlim _lazyAsyncActiveSemaphore; //Field offset: 0x68
	private readonly bool _leaveOpen; //Field offset: 0x70

	private SemaphoreSlim AsyncActiveSemaphore
	{
		private get { } //Length: 270
	}

	public virtual bool CanRead
	{
		 get { } //Length: 5
	}

	public virtual bool CanSeek
	{
		 get { } //Length: 3
	}

	public virtual bool CanWrite
	{
		 get { } //Length: 5
	}

	public bool HasFlushedFinalBlock
	{
		 get { } //Length: 5
	}

	public virtual long Length
	{
		 get { } //Length: 78
	}

	public virtual long Position
	{
		 get { } //Length: 78
		 set { } //Length: 78
	}

	public CryptoStream(Stream stream, ICryptoTransform transform, CryptoStreamMode mode) { }

	public CryptoStream(Stream stream, ICryptoTransform transform, CryptoStreamMode mode, bool leaveOpen) { }

	public virtual IAsyncResult BeginRead(Byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	public virtual IAsyncResult BeginWrite(Byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	private void CheckReadArguments(Byte[] buffer, int offset, int count) { }

	private void CheckWriteArguments(Byte[] buffer, int offset, int count) { }

	public void Clear() { }

	protected virtual void Dispose(bool disposing) { }

	public virtual int EndRead(IAsyncResult asyncResult) { }

	public virtual void EndWrite(IAsyncResult asyncResult) { }

	public virtual void Flush() { }

	public virtual Task FlushAsync(CancellationToken cancellationToken) { }

	public void FlushFinalBlock() { }

	private SemaphoreSlim get_AsyncActiveSemaphore() { }

	public virtual bool get_CanRead() { }

	public virtual bool get_CanSeek() { }

	public virtual bool get_CanWrite() { }

	public bool get_HasFlushedFinalBlock() { }

	public virtual long get_Length() { }

	public virtual long get_Position() { }

	private void InitializeBuffer() { }

	public virtual int Read(Byte[] buffer, int offset, int count) { }

	public virtual Task<Int32> ReadAsync(Byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(<ReadAsyncCore>d__42))]
	private Task<Int32> ReadAsyncCore(Byte[] buffer, int offset, int count, CancellationToken cancellationToken, bool useAsync) { }

	[AsyncStateMachine(typeof(<ReadAsyncInternal>d__37))]
	private Task<Int32> ReadAsyncInternal(Byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	public virtual int ReadByte() { }

	public virtual long Seek(long offset, SeekOrigin origin) { }

	public virtual void set_Position(long value) { }

	public virtual void SetLength(long value) { }

	public virtual void Write(Byte[] buffer, int offset, int count) { }

	public virtual Task WriteAsync(Byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(<WriteAsyncCore>d__49))]
	private Task WriteAsyncCore(Byte[] buffer, int offset, int count, CancellationToken cancellationToken, bool useAsync) { }

	[AsyncStateMachine(typeof(<WriteAsyncInternal>d__46))]
	private Task WriteAsyncInternal(Byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	public virtual void WriteByte(byte value) { }

}

