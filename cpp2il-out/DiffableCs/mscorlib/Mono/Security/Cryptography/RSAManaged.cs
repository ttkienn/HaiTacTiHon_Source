namespace Mono.Security.Cryptography;

internal class RSAManaged : RSA
{
	internal sealed class KeyGeneratedEventHandler : MulticastDelegate
	{

		public KeyGeneratedEventHandler(object object, IntPtr method) { }

		public override void Invoke(object sender, EventArgs e) { }

	}

	private bool isCRTpossible; //Field offset: 0x20
	private bool keyBlinding; //Field offset: 0x21
	private bool keypairGenerated; //Field offset: 0x22
	private bool m_disposed; //Field offset: 0x23
	private BigInteger d; //Field offset: 0x28
	private BigInteger p; //Field offset: 0x30
	private BigInteger q; //Field offset: 0x38
	private BigInteger dp; //Field offset: 0x40
	private BigInteger dq; //Field offset: 0x48
	private BigInteger qInv; //Field offset: 0x50
	private BigInteger n; //Field offset: 0x58
	private BigInteger e; //Field offset: 0x60
	[CompilerGenerated]
	private KeyGeneratedEventHandler KeyGenerated; //Field offset: 0x68

	public event KeyGeneratedEventHandler KeyGenerated
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public virtual int KeySize
	{
		 get { } //Length: 165
	}

	public bool PublicOnly
	{
		 get { } //Length: 154
	}

	public RSAManaged(int keySize) { }

	[CompilerGenerated]
	public void add_KeyGenerated(KeyGeneratedEventHandler value) { }

	protected virtual void Dispose(bool disposing) { }

	public virtual Byte[] EncryptValue(Byte[] rgb) { }

	public virtual RSAParameters ExportParameters(bool includePrivateParameters) { }

	protected virtual void Finalize() { }

	private void GenerateKeyPair() { }

	public virtual int get_KeySize() { }

	public bool get_PublicOnly() { }

	private Byte[] GetPaddedValue(BigInteger value, int length) { }

	public virtual void ImportParameters(RSAParameters parameters) { }

	[CompilerGenerated]
	public void remove_KeyGenerated(KeyGeneratedEventHandler value) { }

	public virtual string ToXmlString(bool includePrivateParameters) { }

}

