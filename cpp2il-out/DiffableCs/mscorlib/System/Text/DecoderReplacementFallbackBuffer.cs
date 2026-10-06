namespace System.Text;

public sealed class DecoderReplacementFallbackBuffer : DecoderFallbackBuffer
{
	private string _strDefault; //Field offset: 0x20
	private int _fallbackCount; //Field offset: 0x28
	private int _fallbackIndex; //Field offset: 0x2C

	public virtual int Remaining
	{
		 get { } //Length: 13
	}

	public DecoderReplacementFallbackBuffer(DecoderReplacementFallback fallback) { }

	public virtual bool Fallback(Byte[] bytesUnknown, int index) { }

	public virtual int get_Remaining() { }

	public virtual char GetNextChar() { }

	internal virtual int InternalFallback(Byte[] bytes, Byte* pBytes) { }

	public virtual void Reset() { }

}

