namespace System.Xml;

internal class CharEntityEncoderFallback : EncoderFallback
{
	private CharEntityEncoderFallbackBuffer fallbackBuffer; //Field offset: 0x10
	private Int32[] textContentMarks; //Field offset: 0x18
	private int endMarkPos; //Field offset: 0x20
	private int curMarkPos; //Field offset: 0x24
	private int startOffset; //Field offset: 0x28

	public virtual int MaxCharCount
	{
		 get { } //Length: 6
	}

	internal int StartOffset
	{
		internal set { } //Length: 4
	}

	internal CharEntityEncoderFallback() { }

	internal bool CanReplaceAt(int index) { }

	public virtual EncoderFallbackBuffer CreateFallbackBuffer() { }

	public virtual int get_MaxCharCount() { }

	internal void Reset(Int32[] textContentMarks, int endMarkPos) { }

	internal void set_StartOffset(int value) { }

}

