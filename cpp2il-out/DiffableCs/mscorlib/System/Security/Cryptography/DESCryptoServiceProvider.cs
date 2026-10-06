namespace System.Security.Cryptography;

[ComVisible(True)]
public sealed class DESCryptoServiceProvider : DES
{

	public DESCryptoServiceProvider() { }

	public virtual ICryptoTransform CreateDecryptor(Byte[] rgbKey, Byte[] rgbIV) { }

	public virtual ICryptoTransform CreateEncryptor(Byte[] rgbKey, Byte[] rgbIV) { }

	public virtual void GenerateIV() { }

	public virtual void GenerateKey() { }

}

