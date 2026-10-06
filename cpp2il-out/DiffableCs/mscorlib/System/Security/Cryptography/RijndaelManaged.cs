namespace System.Security.Cryptography;

[ComVisible(True)]
public sealed class RijndaelManaged : Rijndael
{

	public RijndaelManaged() { }

	public virtual ICryptoTransform CreateDecryptor(Byte[] rgbKey, Byte[] rgbIV) { }

	public virtual ICryptoTransform CreateEncryptor(Byte[] rgbKey, Byte[] rgbIV) { }

	public virtual void GenerateIV() { }

	public virtual void GenerateKey() { }

	private ICryptoTransform NewEncryptor(Byte[] rgbKey, CipherMode mode, Byte[] rgbIV, int feedbackSize, RijndaelManagedTransformMode encryptMode) { }

}

