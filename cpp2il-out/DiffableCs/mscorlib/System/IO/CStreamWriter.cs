namespace System.IO;

internal class CStreamWriter : StreamWriter
{
	private TermInfoDriver driver; //Field offset: 0x70

	public CStreamWriter(Stream stream, Encoding encoding, bool leaveOpen) { }

	public void InternalWriteChar(char val) { }

	public void InternalWriteChars(Char[] buffer, int n) { }

	public void InternalWriteString(string val) { }

	public virtual void Write(Char[] buffer, int index, int count) { }

	public virtual void Write(char val) { }

	public virtual void Write(Char[] val) { }

	public virtual void Write(string val) { }

	public virtual void WriteLine(string val) { }

}

