namespace System.IO;

[ComVisible(True)]
public class FileStream : Stream
{
	private sealed class ReadDelegate : MulticastDelegate
	{

		public ReadDelegate(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(Byte[] buffer, int offset, int count, AsyncCallback callback, object object) { }

		public override int EndInvoke(IAsyncResult result) { }

		public override int Invoke(Byte[] buffer, int offset, int count) { }

	}

	private sealed class WriteDelegate : MulticastDelegate
	{

		public WriteDelegate(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(Byte[] buffer, int offset, int count, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(Byte[] buffer, int offset, int count) { }

	}

	private static Byte[] buf_recycle; //Field offset: 0x0
	private static readonly object buf_recycle_lock; //Field offset: 0x8
	private Byte[] buf; //Field offset: 0x28
	private string name; //Field offset: 0x30
	private SafeFileHandle safeHandle; //Field offset: 0x38
	private bool isExposed; //Field offset: 0x40
	private long append_startpos; //Field offset: 0x48
	private FileAccess access; //Field offset: 0x50
	private bool owner; //Field offset: 0x54
	private bool async; //Field offset: 0x55
	private bool canseek; //Field offset: 0x56
	private bool anonymous; //Field offset: 0x57
	private bool buf_dirty; //Field offset: 0x58
	private int buf_size; //Field offset: 0x5C
	private int buf_length; //Field offset: 0x60
	private int buf_offset; //Field offset: 0x64
	private long buf_start; //Field offset: 0x68

	public virtual bool CanRead
	{
		 get { } //Length: 17
	}

	public virtual bool CanSeek
	{
		 get { } //Length: 5
	}

	public virtual bool CanWrite
	{
		 get { } //Length: 17
	}

	public virtual long Length
	{
		 get { } //Length: 416
	}

	public override string Name
	{
		 get { } //Length: 5
	}

	public virtual long Position
	{
		 get { } //Length: 436
		 set { } //Length: 156
	}

	public override SafeFileHandle SafeFileHandle
	{
		 get { } //Length: 62
	}

	private static FileStream() { }

	internal FileStream(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize, bool anonymous, FileOptions options) { }

	public FileStream(SafeFileHandle handle, FileAccess access, int bufferSize, bool isAsync) { }

	public FileStream(SafeFileHandle handle, FileAccess access) { }

	public FileStream(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize, FileOptions options) { }

	internal FileStream(IntPtr handle, FileAccess access, bool ownsHandle, int bufferSize, bool isAsync, bool isConsoleWrapper) { }

	public FileStream(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize) { }

	public FileStream(string path, FileMode mode, FileAccess access, FileShare share) { }

	public FileStream(string path, FileMode mode) { }

	public FileStream(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize, bool useAsync) { }

	public virtual IAsyncResult BeginRead(Byte[] array, int offset, int numBytes, AsyncCallback userCallback, object stateObject) { }

	public virtual IAsyncResult BeginWrite(Byte[] array, int offset, int numBytes, AsyncCallback userCallback, object stateObject) { }

	protected virtual void Dispose(bool disposing) { }

	public virtual int EndRead(IAsyncResult asyncResult) { }

	public virtual void EndWrite(IAsyncResult asyncResult) { }

	private void ExposeHandle() { }

	protected virtual void Finalize() { }

	public virtual void Flush() { }

	public virtual Task FlushAsync(CancellationToken cancellationToken) { }

	private void FlushBuffer() { }

	private void FlushBufferIfDirty() { }

	public virtual bool get_CanRead() { }

	public virtual bool get_CanSeek() { }

	public virtual bool get_CanWrite() { }

	public virtual long get_Length() { }

	public override string get_Name() { }

	public virtual long get_Position() { }

	public override SafeFileHandle get_SafeFileHandle() { }

	private string GetSecureFileName(string filename) { }

	private string GetSecureFileName(string filename, bool full) { }

	private void Init(SafeFileHandle safeHandle, FileAccess access, bool ownsHandle, int bufferSize, bool isAsync, bool isConsoleWrapper) { }

	private void InitBuffer(int size, bool isZeroSize) { }

	public virtual int Read(out Byte[] array, int offset, int count) { }

	public virtual Task<Int32> ReadAsync(Byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	public virtual int ReadByte() { }

	private int ReadData(SafeHandle safeHandle, Byte[] buf, int offset, int count) { }

	private int ReadInternal(Byte[] dest, int offset, int count) { }

	private int ReadSegment(Byte[] dest, int dest_offset, int count) { }

	private void RefillBuffer() { }

	public virtual long Seek(long offset, SeekOrigin origin) { }

	public virtual void set_Position(long value) { }

	public virtual void SetLength(long value) { }

	public virtual void Write(Byte[] array, int offset, int count) { }

	public virtual Task WriteAsync(Byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	public virtual void WriteByte(byte value) { }

	private void WriteInternal(Byte[] src, int offset, int count) { }

	private int WriteSegment(Byte[] src, int src_offset, int count) { }

}

