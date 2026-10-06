namespace System.Text;

public abstract class DecoderFallback
{
	private static DecoderFallback s_replacementFallback; //Field offset: 0x0
	private static DecoderFallback s_exceptionFallback; //Field offset: 0x8

	public static DecoderFallback ExceptionFallback
	{
		 get { } //Length: 159
	}

	public abstract int MaxCharCount
	{
		 get { } //Length: 0
	}

	public static DecoderFallback ReplacementFallback
	{
		 get { } //Length: 189
	}

	protected DecoderFallback() { }

	public abstract DecoderFallbackBuffer CreateFallbackBuffer() { }

	public static DecoderFallback get_ExceptionFallback() { }

	public abstract int get_MaxCharCount() { }

	public static DecoderFallback get_ReplacementFallback() { }

}

