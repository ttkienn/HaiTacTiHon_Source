namespace System.Security.Cryptography;

[ComVisible(True)]
public abstract class DSA : AsymmetricAlgorithm
{

	protected DSA() { }

	public static DSA Create() { }

	public abstract DSAParameters ExportParameters(bool includePrivateParameters) { }

	public virtual void FromXmlString(string xmlString) { }

	public abstract void ImportParameters(DSAParameters parameters) { }

	public virtual string ToXmlString(bool includePrivateParameters) { }

	public abstract bool VerifySignature(Byte[] rgbHash, Byte[] rgbSignature) { }

}

