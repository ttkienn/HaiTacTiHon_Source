namespace System.Text;

internal sealed class InternalDecoderBestFitFallbackBuffer : DecoderFallbackBuffer
{
	private static object s_InternalSyncObject; //Field offset: 0x0
	private char _cBestFit; //Field offset: 0x20
	private int _iCount; //Field offset: 0x24
	private int _iSize; //Field offset: 0x28
	private InternalDecoderBestFitFallback _oFallback; //Field offset: 0x30

	private static object InternalSyncObject
	{
		private get { } //Length: 146
	}

	public virtual int Remaining
	{
		 get { } //Length: 13
	}

	public InternalDecoderBestFitFallbackBuffer(InternalDecoderBestFitFallback fallback) { }

	public virtual bool Fallback(Byte[] bytesUnknown, int index) { }

	private static object get_InternalSyncObject() { }

	public virtual int get_Remaining() { }

	public virtual char GetNextChar() { }

	internal virtual int InternalFallback(Byte[] bytes, Byte* pBytes) { }

	public virtual void Reset() { }

	private char TryBestFit(Byte[] bytesCheck) { }

}

