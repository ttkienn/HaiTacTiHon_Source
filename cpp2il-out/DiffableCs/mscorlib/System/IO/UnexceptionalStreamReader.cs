namespace System.IO;

internal class UnexceptionalStreamReader : StreamReader
{
	private static Boolean[] newline; //Field offset: 0x0
	private static char newlineChar; //Field offset: 0x8

	private static UnexceptionalStreamReader() { }

	public UnexceptionalStreamReader(Stream stream, Encoding encoding) { }

	private bool CheckEOL(char current) { }

	public virtual int Peek() { }

	public virtual int Read() { }

	public virtual int Read(out Char[] dest_buffer, int index, int count) { }

	public virtual string ReadLine() { }

	public virtual string ReadToEnd() { }

}

