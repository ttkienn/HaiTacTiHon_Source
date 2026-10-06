namespace System.Text;

public abstract class DecoderFallbackBuffer
{
	internal Byte* byteStart; //Field offset: 0x10
	internal Char* charEnd; //Field offset: 0x18

	public abstract int Remaining
	{
		 get { } //Length: 0
	}

	protected DecoderFallbackBuffer() { }

	public abstract bool Fallback(Byte[] bytesUnknown, int index) { }

	public abstract int get_Remaining() { }

	public abstract char GetNextChar() { }

	internal override bool InternalFallback(Byte[] bytes, Byte* pBytes, ref Char* chars) { }

	internal override int InternalFallback(Byte[] bytes, Byte* pBytes) { }

	internal void InternalInitialize(Byte* byteStart, Char* charEnd) { }

	internal void InternalReset() { }

	public override void Reset() { }

	internal void ThrowLastBytesRecursive(Byte[] bytesUnknown) { }

}

