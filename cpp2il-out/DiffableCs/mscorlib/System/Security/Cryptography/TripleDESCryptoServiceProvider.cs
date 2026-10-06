namespace System.Security.Cryptography;

[ComVisible(True)]
public sealed class TripleDESCryptoServiceProvider : TripleDES
{

	public TripleDESCryptoServiceProvider() { }

	public virtual ICryptoTransform CreateDecryptor(Byte[] rgbKey, Byte[] rgbIV) { }

	public virtual ICryptoTransform CreateEncryptor(Byte[] rgbKey, Byte[] rgbIV) { }

	public virtual void GenerateIV() { }

	public virtual void GenerateKey() { }

}

