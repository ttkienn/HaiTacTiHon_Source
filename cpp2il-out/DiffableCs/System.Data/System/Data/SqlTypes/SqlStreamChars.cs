namespace System.Data.SqlTypes;

internal abstract class SqlStreamChars
{

	public abstract long Length
	{
		 get { } //Length: 0
	}

	public abstract long Position
	{
		 get { } //Length: 0
	}

	public abstract long get_Length() { }

	public abstract long get_Position() { }

	public abstract int Read(Char[] buffer, int offset, int count) { }

	public abstract long Seek(long offset, SeekOrigin origin) { }

}

