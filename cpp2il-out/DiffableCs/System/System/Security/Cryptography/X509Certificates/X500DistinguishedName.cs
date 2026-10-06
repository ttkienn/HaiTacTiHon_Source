namespace System.Security.Cryptography.X509Certificates;

[MonoTODO("Some X500DistinguishedNameFlags options aren't supported, like DoNotUsePlusSign, DoNotUseQuotes and ForceUTF8Encoding")]
public sealed class X500DistinguishedName : AsnEncodedData
{
	private string name; //Field offset: 0x20
	private Byte[] canonEncoding; //Field offset: 0x28

	public string Name
	{
		 get { } //Length: 5
	}

	public X500DistinguishedName(Byte[] encodedDistinguishedName) { }

	public X500DistinguishedName(string distinguishedName) { }

	public X500DistinguishedName(string distinguishedName, X500DistinguishedNameFlags flag) { }

	internal static bool AreEqual(X500DistinguishedName name1, X500DistinguishedName name2) { }

	private static string Canonize(string s) { }

	public string Decode(X500DistinguishedNameFlags flag) { }

	private void DecodeRawData() { }

	public virtual string Format(bool multiLine) { }

	public string get_Name() { }

	private static string GetSeparator(X500DistinguishedNameFlags flag) { }

}

