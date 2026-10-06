namespace System.Security.Cryptography.X509Certificates;

[DefaultMember("Item")]
internal class X509CertificateImplCollection : IDisposable
{
	private List<X509CertificateImpl> list; //Field offset: 0x10

	public int Count
	{
		 get { } //Length: 60
	}

	public X509CertificateImpl Item
	{
		 get { } //Length: 81
	}

	public X509CertificateImplCollection() { }

	private X509CertificateImplCollection(X509CertificateImplCollection other) { }

	public void Add(X509CertificateImpl impl, bool takeOwnership) { }

	public X509CertificateImplCollection Clone() { }

	public override void Dispose() { }

	protected override void Dispose(bool disposing) { }

	protected virtual void Finalize() { }

	public int get_Count() { }

	public X509CertificateImpl get_Item(int index) { }

}

