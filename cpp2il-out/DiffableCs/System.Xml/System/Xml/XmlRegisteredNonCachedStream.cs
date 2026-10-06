namespace System.Xml;

internal class XmlRegisteredNonCachedStream : Stream
{
	protected Stream stream; //Field offset: 0x28
	private XmlDownloadManager downloadManager; //Field offset: 0x30
	private string host; //Field offset: 0x38

	public virtual bool CanRead
	{
		 get { } //Length: 42
	}

	public virtual bool CanSeek
	{
		 get { } //Length: 42
	}

	public virtual bool CanWrite
	{
		 get { } //Length: 42
	}

	public virtual long Length
	{
		 get { } //Length: 42
	}

	public virtual long Position
	{
		 get { } //Length: 42
		 set { } //Length: 42
	}

	internal XmlRegisteredNonCachedStream(Stream stream, XmlDownloadManager downloadManager, string host) { }

	public virtual IAsyncResult BeginRead(Byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	public virtual IAsyncResult BeginWrite(Byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	protected virtual void Dispose(bool disposing) { }

	public virtual int EndRead(IAsyncResult asyncResult) { }

	public virtual void EndWrite(IAsyncResult asyncResult) { }

	protected virtual void Finalize() { }

	public virtual void Flush() { }

	public virtual bool get_CanRead() { }

	public virtual bool get_CanSeek() { }

	public virtual bool get_CanWrite() { }

	public virtual long get_Length() { }

	public virtual long get_Position() { }

	public virtual int Read(Byte[] buffer, int offset, int count) { }

	public virtual int ReadByte() { }

	public virtual long Seek(long offset, SeekOrigin origin) { }

	public virtual void set_Position(long value) { }

	public virtual void SetLength(long value) { }

	public virtual void Write(Byte[] buffer, int offset, int count) { }

	public virtual void WriteByte(byte value) { }

}

