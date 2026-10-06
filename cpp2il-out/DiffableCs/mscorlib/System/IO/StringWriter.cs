namespace System.IO;

[ComVisible(True)]
public class StringWriter : TextWriter
{
	private static UnicodeEncoding m_encoding; //Field offset: 0x0
	private StringBuilder _sb; //Field offset: 0x30
	private bool _isOpen; //Field offset: 0x38

	public virtual Encoding Encoding
	{
		 get { } //Length: 179
	}

	public StringWriter() { }

	public StringWriter(IFormatProvider formatProvider) { }

	public StringWriter(StringBuilder sb) { }

	public StringWriter(StringBuilder sb, IFormatProvider formatProvider) { }

	public virtual void Close() { }

	protected virtual void Dispose(bool disposing) { }

	[ComVisible(False)]
	public virtual Task FlushAsync() { }

	public virtual Encoding get_Encoding() { }

	public virtual string ToString() { }

	public virtual void Write(char value) { }

	public virtual void Write(Char[] buffer, int index, int count) { }

	public virtual void Write(string value) { }

	[ComVisible(False)]
	public virtual Task WriteAsync(char value) { }

	[ComVisible(False)]
	public virtual Task WriteAsync(string value) { }

	[ComVisible(False)]
	public virtual Task WriteAsync(Char[] buffer, int index, int count) { }

}

