namespace System.Text;

public sealed class EncoderExceptionFallbackBuffer : EncoderFallbackBuffer
{

	public virtual int Remaining
	{
		 get { } //Length: 3
	}

	public EncoderExceptionFallbackBuffer() { }

	public virtual bool Fallback(char charUnknown, int index) { }

	public virtual bool Fallback(char charUnknownHigh, char charUnknownLow, int index) { }

	public virtual int get_Remaining() { }

	public virtual char GetNextChar() { }

	public virtual bool MovePrevious() { }

}

