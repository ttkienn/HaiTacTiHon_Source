namespace System.Xml;

internal class CharEntityEncoderFallbackBuffer : EncoderFallbackBuffer
{
	private CharEntityEncoderFallback parent; //Field offset: 0x30
	private string charEntity; //Field offset: 0x38
	private int charEntityIndex; //Field offset: 0x40

	public virtual int Remaining
	{
		 get { } //Length: 42
	}

	internal CharEntityEncoderFallbackBuffer(CharEntityEncoderFallback parent) { }

	public virtual bool Fallback(char charUnknown, int index) { }

	public virtual bool Fallback(char charUnknownHigh, char charUnknownLow, int index) { }

	public virtual int get_Remaining() { }

	public virtual char GetNextChar() { }

	public virtual bool MovePrevious() { }

	public virtual void Reset() { }

	private int SurrogateCharToUtf32(char highSurrogate, char lowSurrogate) { }

}

