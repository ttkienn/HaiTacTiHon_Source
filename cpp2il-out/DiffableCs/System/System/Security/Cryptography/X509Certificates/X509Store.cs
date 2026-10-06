namespace System.Security.Cryptography.X509Certificates;

public sealed class X509Store : IDisposable
{
	private string _name; //Field offset: 0x10
	private StoreLocation _location; //Field offset: 0x18
	private X509Certificate2Collection list; //Field offset: 0x20
	private OpenFlags _flags; //Field offset: 0x28
	private X509Store store; //Field offset: 0x30

	public X509Certificate2Collection Certificates
	{
		 get { } //Length: 133
	}

	private X509Stores Factory
	{
		private get { } //Length: 20
	}

	internal X509Store Store
	{
		internal get { } //Length: 5
	}

	public X509Store(StoreName storeName, StoreLocation storeLocation) { }

	public void Close() { }

	public override void Dispose() { }

	public X509Certificate2Collection get_Certificates() { }

	private X509Stores get_Factory() { }

	internal X509Store get_Store() { }

	public void Open(OpenFlags flags) { }

}

