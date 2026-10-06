namespace System.Text;

internal abstract class EncodingNLS : Encoding
{

	protected EncodingNLS(int codePage) { }

	public virtual int GetByteCount(Char[] chars, int index, int count) { }

	public virtual int GetByteCount(string s) { }

	public virtual int GetByteCount(Char* chars, int count) { }

	public virtual int GetBytes(string s, int charIndex, int charCount, Byte[] bytes, int byteIndex) { }

	public virtual int GetBytes(Char[] chars, int charIndex, int charCount, Byte[] bytes, int byteIndex) { }

	public virtual int GetBytes(Char* chars, int charCount, Byte* bytes, int byteCount) { }

	public virtual int GetCharCount(Byte[] bytes, int index, int count) { }

	public virtual int GetCharCount(Byte* bytes, int count) { }

	public virtual int GetChars(Byte[] bytes, int byteIndex, int byteCount, Char[] chars, int charIndex) { }

	public virtual int GetChars(Byte* bytes, int byteCount, Char* chars, int charCount) { }

	public virtual Decoder GetDecoder() { }

	public virtual Encoder GetEncoder() { }

	public virtual string GetString(Byte[] bytes, int index, int count) { }

}

