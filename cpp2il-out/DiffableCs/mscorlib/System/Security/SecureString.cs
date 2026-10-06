namespace System.Security;

[MonoTODO("work in progress - encryption is missing")]
public sealed class SecureString : IDisposable
{
	private int length; //Field offset: 0x10
	private bool disposed; //Field offset: 0x14
	private Byte[] data; //Field offset: 0x18

	public int Length
	{
		 get { } //Length: 100
	}

	public SecureString() { }

	[CLSCompliant(False)]
	public SecureString(Char* value, int length) { }

	private void Alloc(int length, bool realloc) { }

	private void Decrypt() { }

	public override void Dispose() { }

	private void Encrypt() { }

	public int get_Length() { }

	internal Byte[] GetBuffer() { }

}

