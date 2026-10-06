namespace System.Security.Cryptography;

[ComVisible(True)]
public class MACTripleDES : KeyedHashAlgorithm
{
	private ICryptoTransform m_encryptor; //Field offset: 0x30
	private CryptoStream _cs; //Field offset: 0x38
	private TailStream _ts; //Field offset: 0x40
	private int m_bytesPerBlock; //Field offset: 0x48
	private TripleDES des; //Field offset: 0x50

	public MACTripleDES() { }

	protected virtual void Dispose(bool disposing) { }

	protected virtual void HashCore(Byte[] rgbData, int ibStart, int cbSize) { }

	protected virtual Byte[] HashFinal() { }

	public virtual void Initialize() { }

}

