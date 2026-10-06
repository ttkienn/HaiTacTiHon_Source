namespace System.Security.Cryptography;

internal abstract class RSAPKCS1SignatureDescription : SignatureDescription
{
	private string _hashAlgorithm; //Field offset: 0x30

	protected RSAPKCS1SignatureDescription(string hashAlgorithm, string digestAlgorithm) { }

}

