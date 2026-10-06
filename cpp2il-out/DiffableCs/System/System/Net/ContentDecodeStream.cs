namespace System.Net;

internal class ContentDecodeStream : WebReadStream
{
	public enum Mode
	{
		GZip = 0,
		Deflate = 1,
	}

	[CompilerGenerated]
	private readonly Stream <OriginalInnerStream>k__BackingField; //Field offset: 0x40

	private Stream OriginalInnerStream
	{
		[CompilerGenerated]
		private get { } //Length: 5
	}

	private ContentDecodeStream(WebOperation operation, Stream decodeStream, Stream originalInnerStream) { }

	public static ContentDecodeStream Create(WebOperation operation, Stream innerStream, Mode mode) { }

	internal virtual Task FinishReading(CancellationToken cancellationToken) { }

	[CompilerGenerated]
	private Stream get_OriginalInnerStream() { }

	protected virtual Task<Int32> ProcessReadAsync(Byte[] buffer, int offset, int size, CancellationToken cancellationToken) { }

}

