namespace System.Diagnostics;

internal class AsyncStreamReader
{
	private Stream stream; //Field offset: 0x10
	private Encoding encoding; //Field offset: 0x18
	private Decoder decoder; //Field offset: 0x20
	private Byte[] byteBuffer; //Field offset: 0x28
	private Char[] charBuffer; //Field offset: 0x30
	private bool cancelOperation; //Field offset: 0x38
	private ManualResetEvent eofEvent; //Field offset: 0x40
	private object syncObject; //Field offset: 0x48
	private IAsyncResult asyncReadResult; //Field offset: 0x50

	internal void CancelOperation() { }

	public override void Close() { }

	protected override void Dispose(bool disposing) { }

}

