namespace Mono.Unity;

internal class X509ChainImplUnityTls : X509ChainImpl
{
	private X509ChainElementCollection elements; //Field offset: 0x10
	private unitytls_x509list* ownedList; //Field offset: 0x18
	private unitytls_x509list_ref nativeCertificateChain; //Field offset: 0x20
	private X509ChainPolicy policy; //Field offset: 0x28
	private List<X509ChainStatus> chainStatusList; //Field offset: 0x30
	private bool reverseOrder; //Field offset: 0x38

	public virtual X509ChainElementCollection ChainElements
	{
		 get { } //Length: 865
	}

	public virtual X509ChainPolicy ChainPolicy
	{
		 get { } //Length: 5
	}

	public virtual bool IsValid
	{
		 get { } //Length: 40
	}

	internal unitytls_x509list_ref NativeCertificateChain
	{
		internal get { } //Length: 5
	}

	internal X509ChainImplUnityTls(unitytls_x509list_ref nativeCertificateChain, bool reverseOrder = false) { }

	internal X509ChainImplUnityTls(unitytls_x509list* ownedList, unitytls_errorstate* errorState, bool reverseOrder = false) { }

	public virtual void AddStatus(X509ChainStatusFlags error) { }

	public virtual bool Build(X509Certificate2 certificate) { }

	protected virtual void Dispose(bool disposing) { }

	public virtual X509ChainElementCollection get_ChainElements() { }

	public virtual X509ChainPolicy get_ChainPolicy() { }

	public virtual bool get_IsValid() { }

	internal unitytls_x509list_ref get_NativeCertificateChain() { }

	public virtual void Reset() { }

}

