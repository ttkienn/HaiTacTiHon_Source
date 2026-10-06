namespace Mono.Security.X509;

public class X509Stores
{
	private string _storePath; //Field offset: 0x10
	private bool _newFormat; //Field offset: 0x18
	private X509Store _trusted; //Field offset: 0x20

	public X509Store TrustedRoot
	{
		 get { } //Length: 227
	}

	internal X509Stores(string path, bool newFormat) { }

	public X509Store get_TrustedRoot() { }

	public X509Store Open(string storeName, bool create) { }

}

