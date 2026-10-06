namespace Mono.Security.X509;

public class X509Chain
{
	private X509CertificateCollection roots; //Field offset: 0x10
	private X509CertificateCollection certs; //Field offset: 0x18
	private X509Certificate _root; //Field offset: 0x20
	private X509CertificateCollection _chain; //Field offset: 0x28
	private X509ChainStatusFlags _status; //Field offset: 0x30

	public X509CertificateCollection TrustAnchors
	{
		 get { } //Length: 150
	}

	public X509Chain() { }

	public bool Build(X509Certificate leaf) { }

	private X509Certificate FindCertificateParent(X509Certificate child) { }

	private X509Certificate FindCertificateRoot(X509Certificate potentialRoot) { }

	public X509CertificateCollection get_TrustAnchors() { }

	private bool IsParent(X509Certificate child, X509Certificate parent) { }

	private bool IsTrusted(X509Certificate potentialTrusted) { }

	private bool IsValid(X509Certificate cert) { }

	public void LoadCertificates(X509CertificateCollection collection) { }

	public void Reset() { }

}

