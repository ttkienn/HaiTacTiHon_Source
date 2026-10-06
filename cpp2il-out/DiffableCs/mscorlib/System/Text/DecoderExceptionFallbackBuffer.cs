namespace System.Text;

public sealed class DecoderExceptionFallbackBuffer : DecoderFallbackBuffer
{

	public virtual int Remaining
	{
		 get { } //Length: 3
	}

	public DecoderExceptionFallbackBuffer() { }

	public virtual bool Fallback(Byte[] bytesUnknown, int index) { }

	public virtual int get_Remaining() { }

	public virtual char GetNextChar() { }

	private void Throw(Byte[] bytesUnknown, int index) { }

}

