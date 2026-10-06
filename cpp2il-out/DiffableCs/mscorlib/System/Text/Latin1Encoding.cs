namespace System.Text;

internal class Latin1Encoding : EncodingNLS, ISerializable
{
	internal static readonly Latin1Encoding s_default; //Field offset: 0x0
	private static readonly Char[] arrayCharBestFit; //Field offset: 0x8

	private static Latin1Encoding() { }

	public Latin1Encoding() { }

	internal Latin1Encoding(SerializationInfo info, StreamingContext context) { }

	internal virtual Char[] GetBestFitUnicodeToBytesData() { }

	internal virtual int GetByteCount(Char* chars, int charCount, EncoderNLS encoder) { }

	internal virtual int GetBytes(Char* chars, int charCount, Byte* bytes, int byteCount, EncoderNLS encoder) { }

	internal virtual int GetCharCount(Byte* bytes, int count, DecoderNLS decoder) { }

	internal virtual int GetChars(Byte* bytes, int byteCount, Char* chars, int charCount, DecoderNLS decoder) { }

	public virtual int GetMaxByteCount(int charCount) { }

	public virtual int GetMaxCharCount(int byteCount) { }

	private override void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

}

