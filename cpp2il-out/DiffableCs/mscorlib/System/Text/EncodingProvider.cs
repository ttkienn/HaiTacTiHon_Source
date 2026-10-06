namespace System.Text;

public abstract class EncodingProvider
{
	private static object s_InternalSyncObject; //Field offset: 0x0
	private static EncodingProvider[] s_providers; //Field offset: 0x8

	private static EncodingProvider() { }

	public abstract Encoding GetEncoding(string name) { }

	public abstract Encoding GetEncoding(int codepage) { }

	public override Encoding GetEncoding(int codepage, EncoderFallback encoderFallback, DecoderFallback decoderFallback) { }

	internal static Encoding GetEncodingFromProvider(int codepage) { }

	internal static Encoding GetEncodingFromProvider(string encodingName) { }

	internal static Encoding GetEncodingFromProvider(int codepage, EncoderFallback enc, DecoderFallback dec) { }

}

