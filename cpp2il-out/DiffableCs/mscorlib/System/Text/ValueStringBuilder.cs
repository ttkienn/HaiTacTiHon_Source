namespace System.Text;

[DefaultMember("Item")]
[IsByRefLike]
[Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
internal struct ValueStringBuilder
{
	private Char[] _arrayToReturnToPool; //Field offset: 0x0
	private Span<Char> _chars; //Field offset: 0x8
	private int _pos; //Field offset: 0x18

	public char Item
	{
		 get { } //Length: 30
	}

	public int Length
	{
		 get { } //Length: 4
	}

	public ValueStringBuilder(Span<Char> initialBuffer) { }

	public void Append(char c) { }

	public void Append(string s) { }

	public void Append(char c, int count) { }

	public void Append(Char* value, int length) { }

	private void AppendSlow(string s) { }

	public Span<Char> AppendSpan(int length) { }

	public void Dispose() { }

	public char get_Item(int index) { }

	public int get_Length() { }

	private void Grow(int requiredAdditionalCapacity) { }

	private void GrowAndAppend(char c) { }

	public virtual string ToString() { }

	public bool TryCopyTo(Span<Char> destination, out int charsWritten) { }

}

