namespace System.Security.Cryptography;

[ComVisible(True)]
public sealed class RSACryptoServiceProvider : RSA
{
	private static CspProviderFlags s_UseMachineKeyStore; //Field offset: 0x0
	private KeyPairPersistence store; //Field offset: 0x20
	private bool persistKey; //Field offset: 0x28
	private bool persisted; //Field offset: 0x29
	private bool privateKeyExportable; //Field offset: 0x2A
	private bool m_disposed; //Field offset: 0x2B
	private RSAManaged rsa; //Field offset: 0x30

	public virtual int KeySize
	{
		 get { } //Length: 35
	}

	[ComVisible(False)]
	public bool PublicOnly
	{
		 get { } //Length: 29
	}

	public static bool UseMachineKeyStore
	{
		 get { } //Length: 67
	}

	public RSACryptoServiceProvider() { }

	public RSACryptoServiceProvider(CspParameters parameters) { }

	public RSACryptoServiceProvider(int dwKeySize) { }

	public RSACryptoServiceProvider(int dwKeySize, CspParameters parameters) { }

	private void Common(int dwKeySize, bool parameters) { }

	private void Common(CspParameters p) { }

	protected virtual void Dispose(bool disposing) { }

	public virtual Byte[] EncryptValue(Byte[] rgb) { }

	public virtual RSAParameters ExportParameters(bool includePrivateParameters) { }

	protected virtual void Finalize() { }

	public virtual int get_KeySize() { }

	public bool get_PublicOnly() { }

	public static bool get_UseMachineKeyStore() { }

	private string GetHashNameFromOID(string oid) { }

	public virtual void ImportParameters(RSAParameters parameters) { }

	private void OnKeyGenerated(object sender, EventArgs e) { }

	public bool VerifyHash(Byte[] rgbHash, string str, Byte[] rgbSignature) { }

}

