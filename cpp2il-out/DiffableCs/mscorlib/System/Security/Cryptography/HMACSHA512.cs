namespace System.Security.Cryptography;

[ComVisible(True)]
public class HMACSHA512 : HMAC
{
	private bool m_useLegacyBlockSize; //Field offset: 0x68

	private int BlockSize
	{
		private get { } //Length: 18
	}

	public HMACSHA512() { }

	public HMACSHA512(Byte[] key) { }

	private int get_BlockSize() { }

}

