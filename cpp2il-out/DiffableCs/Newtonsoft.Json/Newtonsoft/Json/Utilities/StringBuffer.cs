namespace Newtonsoft.Json.Utilities;

[Nullable(0)]
[NullableContext(2)]
internal struct StringBuffer
{
	private Char[] _buffer; //Field offset: 0x0
	private int _position; //Field offset: 0x8

	public Char[] InternalBuffer
	{
		 get { } //Length: 4
	}

	public bool IsEmpty
	{
		 get { } //Length: 8
	}

	public int Position
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public StringBuffer(IArrayPool<Char> bufferPool, int initalSize) { }

	[NullableContext(1)]
	private StringBuffer(Char[] buffer) { }

	public void Append(IArrayPool<Char> bufferPool, char value) { }

	[NullableContext(1)]
	public void Append(IArrayPool<Char> bufferPool, Char[] buffer, int startIndex, int count) { }

	public void Clear(IArrayPool<Char> bufferPool) { }

	private void EnsureSize(IArrayPool<Char> bufferPool, int appendLength) { }

	public Char[] get_InternalBuffer() { }

	public bool get_IsEmpty() { }

	public int get_Position() { }

	public void set_Position(int value) { }

	[NullableContext(1)]
	public virtual string ToString() { }

	[NullableContext(1)]
	public string ToString(int start, int length) { }

}

