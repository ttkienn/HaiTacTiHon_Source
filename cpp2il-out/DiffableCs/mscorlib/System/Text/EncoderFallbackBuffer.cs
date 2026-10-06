namespace System.Text;

public abstract class EncoderFallbackBuffer
{
	internal Char* charStart; //Field offset: 0x10
	internal Char* charEnd; //Field offset: 0x18
	internal EncoderNLS encoder; //Field offset: 0x20
	internal bool setEncoder; //Field offset: 0x28
	internal bool bUsedEncoder; //Field offset: 0x29
	internal bool bFallingBack; //Field offset: 0x2A
	internal int iRecursionCount; //Field offset: 0x2C

	public abstract int Remaining
	{
		 get { } //Length: 0
	}

	protected EncoderFallbackBuffer() { }

	public abstract bool Fallback(char charUnknown, int index) { }

	public abstract bool Fallback(char charUnknownHigh, char charUnknownLow, int index) { }

	public abstract int get_Remaining() { }

	public abstract char GetNextChar() { }

	internal override bool InternalFallback(char ch, ref Char* chars) { }

	internal char InternalGetNextChar() { }

	internal void InternalInitialize(Char* charStart, Char* charEnd, EncoderNLS encoder, bool setEncoder) { }

	internal void InternalReset() { }

	public abstract bool MovePrevious() { }

	public override void Reset() { }

	internal void ThrowLastCharRecursive(int charRecursive) { }

}

