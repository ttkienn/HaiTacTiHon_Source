namespace System.Security.Cryptography;

[ComVisible(True)]
public abstract class RSA : AsymmetricAlgorithm
{

	protected RSA() { }

	public static RSA Create() { }

	public override Byte[] EncryptValue(Byte[] rgb) { }

	public abstract RSAParameters ExportParameters(bool includePrivateParameters) { }

	public virtual void FromXmlString(string xmlString) { }

	public abstract void ImportParameters(RSAParameters parameters) { }

	public virtual string ToXmlString(bool includePrivateParameters) { }

}

