namespace System.Security.Cryptography;

internal sealed class TailStream : Stream
{
	private Byte[] _Buffer; //Field offset: 0x28
	private int _BufferSize; //Field offset: 0x30
	private int _BufferIndex; //Field offset: 0x34
	private bool _BufferFull; //Field offset: 0x38

	public Byte[] Buffer
	{
		 get { } //Length: 119
	}

	public virtual bool CanRead
	{
		 get { } //Length: 3
	}

	public virtual bool CanSeek
	{
		 get { } //Length: 3
	}

	public virtual bool CanWrite
	{
		 get { } //Length: 9
	}

	public virtual long Length
	{
		 get { } //Length: 95
	}

	public virtual long Position
	{
		 get { } //Length: 95
		 set { } //Length: 95
	}

	public TailStream(int bufferSize) { }

	public void Clear() { }

	protected virtual void Dispose(bool disposing) { }

	public virtual void Flush() { }

	public Byte[] get_Buffer() { }

	public virtual bool get_CanRead() { }

	public virtual bool get_CanSeek() { }

	public virtual bool get_CanWrite() { }

	public virtual long get_Length() { }

	public virtual long get_Position() { }

	public virtual int Read(Byte[] buffer, int offset, int count) { }

	public virtual long Seek(long offset, SeekOrigin origin) { }

	public virtual void set_Position(long value) { }

	public virtual void SetLength(long value) { }

	public virtual void Write(Byte[] buffer, int offset, int count) { }

}

