namespace System.IO;

internal class UnexceptionalStreamWriter : StreamWriter
{

	public UnexceptionalStreamWriter(Stream stream, Encoding encoding) { }

	public virtual void Flush() { }

	public virtual void Write(Char[] buffer, int index, int count) { }

	public virtual void Write(char value) { }

	public virtual void Write(Char[] value) { }

	public virtual void Write(string value) { }

}

