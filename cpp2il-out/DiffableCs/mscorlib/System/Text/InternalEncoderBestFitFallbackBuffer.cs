namespace System.Text;

internal sealed class InternalEncoderBestFitFallbackBuffer : EncoderFallbackBuffer
{
	private static object s_InternalSyncObject; //Field offset: 0x0
	private char _cBestFit; //Field offset: 0x30
	private InternalEncoderBestFitFallback _oFallback; //Field offset: 0x38
	private int _iCount; //Field offset: 0x40
	private int _iSize; //Field offset: 0x44

	private static object InternalSyncObject
	{
		private get { } //Length: 146
	}

	public virtual int Remaining
	{
		 get { } //Length: 13
	}

	public InternalEncoderBestFitFallbackBuffer(InternalEncoderBestFitFallback fallback) { }

	public virtual bool Fallback(char charUnknown, int index) { }

	public virtual bool Fallback(char charUnknownHigh, char charUnknownLow, int index) { }

	private static object get_InternalSyncObject() { }

	public virtual int get_Remaining() { }

	public virtual char GetNextChar() { }

	public virtual bool MovePrevious() { }

	public virtual void Reset() { }

	private char TryBestFit(char cUnknown) { }

}

