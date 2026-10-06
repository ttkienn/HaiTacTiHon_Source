namespace System.Text;

public class ASCIIEncoding : Encoding
{
	public sealed class ASCIIEncodingSealed : ASCIIEncoding
	{

		public ASCIIEncodingSealed() { }

	}

	internal static readonly ASCIIEncodingSealed s_default; //Field offset: 0x0

	private static ASCIIEncoding() { }

	public ASCIIEncoding() { }

	public virtual int GetByteCount(Char[] chars, int index, int count) { }

	public virtual int GetByteCount(string chars) { }

	[CLSCompliant(False)]
	public virtual int GetByteCount(Char* chars, int count) { }

	internal virtual int GetByteCount(Char* chars, int charCount, EncoderNLS encoder) { }

	public virtual int GetBytes(string chars, int charIndex, int charCount, Byte[] bytes, int byteIndex) { }

	public virtual int GetBytes(Char[] chars, int charIndex, int charCount, Byte[] bytes, int byteIndex) { }

	[CLSCompliant(False)]
	public virtual int GetBytes(Char* chars, int charCount, Byte* bytes, int byteCount) { }

	internal virtual int GetBytes(Char* chars, int charCount, Byte* bytes, int byteCount, EncoderNLS encoder) { }

	public virtual int GetCharCount(Byte[] bytes, int index, int count) { }

	[CLSCompliant(False)]
	public virtual int GetCharCount(Byte* bytes, int count) { }

	internal virtual int GetCharCount(Byte* bytes, int count, DecoderNLS decoder) { }

	internal virtual int GetChars(Byte* bytes, int byteCount, Char* chars, int charCount, DecoderNLS decoder) { }

	[CLSCompliant(False)]
	public virtual int GetChars(Byte* bytes, int byteCount, Char* chars, int charCount) { }

	public virtual int GetChars(Byte[] bytes, int byteIndex, int byteCount, Char[] chars, int charIndex) { }

	public virtual Decoder GetDecoder() { }

	public virtual Encoder GetEncoder() { }

	public virtual int GetMaxByteCount(int charCount) { }

	public virtual int GetMaxCharCount(int byteCount) { }

	public virtual string GetString(Byte[] bytes, int byteIndex, int byteCount) { }

	internal virtual void SetDefaultFallbacks() { }

}

