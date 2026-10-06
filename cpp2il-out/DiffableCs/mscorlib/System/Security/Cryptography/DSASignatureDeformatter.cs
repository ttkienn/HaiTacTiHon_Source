namespace System.Security.Cryptography;

[ComVisible(True)]
public class DSASignatureDeformatter : AsymmetricSignatureDeformatter
{
	private DSA _dsaKey; //Field offset: 0x10
	private string _oid; //Field offset: 0x18

	public DSASignatureDeformatter() { }

	public DSASignatureDeformatter(AsymmetricAlgorithm key) { }

	public virtual void SetHashAlgorithm(string strName) { }

	public virtual void SetKey(AsymmetricAlgorithm key) { }

	public virtual bool VerifySignature(Byte[] rgbHash, Byte[] rgbSignature) { }

}

