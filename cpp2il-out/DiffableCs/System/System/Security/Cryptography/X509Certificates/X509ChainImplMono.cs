namespace System.Security.Cryptography.X509Certificates;

internal class X509ChainImplMono : X509ChainImpl
{
	private static X509ChainStatus[] Empty; //Field offset: 0x0
	private StoreLocation location; //Field offset: 0x10
	private X509ChainElementCollection elements; //Field offset: 0x18
	private X509ChainPolicy policy; //Field offset: 0x20
	private X509ChainStatus[] status; //Field offset: 0x28
	private int max_path_length; //Field offset: 0x30
	private X500DistinguishedName working_issuer_name; //Field offset: 0x38
	private AsymmetricAlgorithm working_public_key; //Field offset: 0x40
	private X509ChainElement bce_restriction; //Field offset: 0x48
	private X509Certificate2Collection roots; //Field offset: 0x50
	private X509Certificate2Collection cas; //Field offset: 0x58
	private X509Store root_store; //Field offset: 0x60
	private X509Store ca_store; //Field offset: 0x68
	private X509Store user_root_store; //Field offset: 0x70
	private X509Store user_ca_store; //Field offset: 0x78
	private X509Certificate2Collection collection; //Field offset: 0x80

	private X509Certificate2Collection CertificateAuthorities
	{
		private get { } //Length: 427
	}

	private X509Certificate2Collection CertificateCollection
	{
		private get { } //Length: 563
	}

	public virtual X509ChainElementCollection ChainElements
	{
		 get { } //Length: 5
	}

	public virtual X509ChainPolicy ChainPolicy
	{
		 get { } //Length: 5
	}

	public virtual bool IsValid
	{
		 get { } //Length: 3
	}

	private X509Store LMCAStore
	{
		private get { } //Length: 158
	}

	private X509Store LMRootStore
	{
		private get { } //Length: 158
	}

	private X509Certificate2Collection Roots
	{
		private get { } //Length: 427
	}

	private X509Store UserCAStore
	{
		private get { } //Length: 158
	}

	private X509Store UserRootStore
	{
		private get { } //Length: 158
	}

	private static X509ChainImplMono() { }

	public X509ChainImplMono(bool useMachineContext) { }

	public virtual void AddStatus(X509ChainStatusFlags error) { }

	[MonoTODO("Not totally RFC3280 compliant, but neither is MS implementation...")]
	public virtual bool Build(X509Certificate2 certificate) { }

	private X509ChainStatusFlags BuildChainFrom(X509Certificate2 certificate) { }

	private static X509Crl CheckCrls(string subject, string ski, X509Store store) { }

	private X509ChainStatusFlags CheckRevocation(X509Certificate2 certificate, int ca, bool online) { }

	private X509ChainStatusFlags CheckRevocation(X509Certificate2 certificate, X509Certificate2 ca_cert, bool online) { }

	private void CheckRevocationOnChain(X509ChainStatusFlags flag) { }

	private X509Crl FindCrl(X509Certificate2 caCertificate) { }

	private X509Certificate2 FindParent(X509Certificate2 certificate) { }

	private X509Certificate2Collection get_CertificateAuthorities() { }

	private X509Certificate2Collection get_CertificateCollection() { }

	public virtual X509ChainElementCollection get_ChainElements() { }

	public virtual X509ChainPolicy get_ChainPolicy() { }

	public virtual bool get_IsValid() { }

	private X509Store get_LMCAStore() { }

	private X509Store get_LMRootStore() { }

	private X509Certificate2Collection get_Roots() { }

	private X509Store get_UserCAStore() { }

	private X509Store get_UserRootStore() { }

	private static string GetAuthorityKeyIdentifier(X509Extension ext) { }

	private static string GetAuthorityKeyIdentifier(X509Crl crl) { }

	private static string GetAuthorityKeyIdentifier(X509Certificate2 certificate) { }

	private string GetSubjectKeyIdentifier(X509Certificate2 certificate) { }

	private bool IsChainComplete(X509Certificate2 certificate) { }

	private bool IsSelfIssued(X509Certificate2 certificate) { }

	private bool IsSignedWith(X509Certificate2 signed, AsymmetricAlgorithm pubkey) { }

	private void PrepareForNextCertificate(int n) { }

	private void Process(int n) { }

	private void ProcessCertificateExtensions(X509ChainElement element) { }

	private bool ProcessCrlEntryExtensions(X509CrlEntry entry) { }

	private bool ProcessCrlExtensions(X509Crl crl) { }

	public virtual void Reset() { }

	private X509Certificate2 SelectBestFromCollection(X509Certificate2 child, X509Certificate2Collection c) { }

	private void ValidateChain(X509ChainStatusFlags flag) { }

	private void WrapUp() { }

}

