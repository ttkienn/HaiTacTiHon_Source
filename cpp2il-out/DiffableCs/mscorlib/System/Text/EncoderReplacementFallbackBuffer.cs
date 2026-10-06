namespace System.Text;

public sealed class EncoderReplacementFallbackBuffer : EncoderFallbackBuffer
{
	private string _strDefault; //Field offset: 0x30
	private int _fallbackCount; //Field offset: 0x38
	private int _fallbackIndex; //Field offset: 0x3C

	public virtual int Remaining
	{
		 get { } //Length: 13
	}

	public EncoderReplacementFallbackBuffer(EncoderReplacementFallback fallback) { }

	public virtual bool Fallback(char charUnknown, int index) { }

	public virtual bool Fallback(char charUnknownHigh, char charUnknownLow, int index) { }

	public virtual int get_Remaining() { }

	public virtual char GetNextChar() { }

	public virtual bool MovePrevious() { }

	public virtual void Reset() { }

}

