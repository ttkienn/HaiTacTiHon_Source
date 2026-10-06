namespace System.Security.Cryptography;

[ComVisible(True)]
public class SignatureDescription
{
	private string _strKey; //Field offset: 0x10
	private string _strDigest; //Field offset: 0x18
	private string _strFormatter; //Field offset: 0x20
	private string _strDeformatter; //Field offset: 0x28

	public string DeformatterAlgorithm
	{
		 set { } //Length: 13
	}

	public string DigestAlgorithm
	{
		 set { } //Length: 13
	}

	public string FormatterAlgorithm
	{
		 set { } //Length: 13
	}

	public string KeyAlgorithm
	{
		 set { } //Length: 13
	}

	public SignatureDescription() { }

	public void set_DeformatterAlgorithm(string value) { }

	public void set_DigestAlgorithm(string value) { }

	public void set_FormatterAlgorithm(string value) { }

	public void set_KeyAlgorithm(string value) { }

}

