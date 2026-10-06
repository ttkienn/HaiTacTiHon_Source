namespace System.Security.Cryptography.X509Certificates;

[DefaultMember("Item")]
public class X509Certificate2Collection : X509CertificateCollection
{
	private static String[] newline_split; //Field offset: 0x0

	public X509Certificate2 Item
	{
		 get { } //Length: 350
	}

	private static X509Certificate2Collection() { }

	public X509Certificate2Collection() { }

	public X509Certificate2Collection(X509Certificate2Collection certificates) { }

	public int Add(X509Certificate2 certificate) { }

	[MonoTODO("Method isn't transactional (like documented)")]
	public void AddRange(X509Certificate2Collection certificates) { }

	public bool Contains(X509Certificate2 certificate) { }

	[MonoTODO("Does not support X509FindType.FindByTemplateName, FindByApplicationPolicy and FindByCertificatePolicy")]
	public X509Certificate2Collection Find(X509FindType findType, object findValue, bool validOnly) { }

	public X509Certificate2 get_Item(int index) { }

	public X509Certificate2Enumerator GetEnumerator() { }

	private string GetKeyIdentifier(X509Certificate2 x) { }

}

