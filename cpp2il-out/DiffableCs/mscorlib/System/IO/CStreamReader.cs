namespace System.IO;

internal class CStreamReader : StreamReader
{
	private TermInfoDriver driver; //Field offset: 0x60

	public CStreamReader(Stream stream, Encoding encoding) { }

	public virtual int Peek() { }

	public virtual int Read() { }

	public virtual int Read(out Char[] dest, int index, int count) { }

	public virtual string ReadLine() { }

	public virtual string ReadToEnd() { }

}

