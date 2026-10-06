namespace Mono.Btls;

internal class X509ChainImplBtls : X509ChainImpl
{
	private MonoBtlsX509StoreCtx storeCtx; //Field offset: 0x10
	private MonoBtlsX509Chain chain; //Field offset: 0x18
	private MonoBtlsX509Chain untrustedChain; //Field offset: 0x20
	private X509ChainElementCollection elements; //Field offset: 0x28
	private X509Certificate2Collection untrusted; //Field offset: 0x30
	private X509Certificate2[] certificates; //Field offset: 0x38
	private X509ChainPolicy policy; //Field offset: 0x40
	private List<X509ChainStatus> chainStatusList; //Field offset: 0x48

	public virtual X509ChainElementCollection ChainElements
	{
		 get { } //Length: 686
	}

	public virtual X509ChainPolicy ChainPolicy
	{
		 get { } //Length: 5
	}

	public virtual bool IsValid
	{
		 get { } //Length: 21
	}

	internal MonoBtlsX509StoreCtx StoreCtx
	{
		internal get { } //Length: 26
	}

	internal X509ChainImplBtls(MonoBtlsX509Chain chain) { }

	internal X509ChainImplBtls(MonoBtlsX509StoreCtx storeCtx) { }

	public virtual void AddStatus(X509ChainStatusFlags errorCode) { }

	public virtual bool Build(X509Certificate2 certificate) { }

	protected virtual void Dispose(bool disposing) { }

	public virtual X509ChainElementCollection get_ChainElements() { }

	public virtual X509ChainPolicy get_ChainPolicy() { }

	public virtual bool get_IsValid() { }

	internal MonoBtlsX509StoreCtx get_StoreCtx() { }

	public virtual void Reset() { }

}

