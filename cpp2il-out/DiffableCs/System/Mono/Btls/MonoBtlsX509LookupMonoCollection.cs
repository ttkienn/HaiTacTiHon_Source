namespace Mono.Btls;

internal class MonoBtlsX509LookupMonoCollection : MonoBtlsX509LookupMono
{
	private Int64[] hashes; //Field offset: 0x48
	private MonoBtlsX509[] certificates; //Field offset: 0x50
	private X509CertificateCollection collection; //Field offset: 0x58
	private MonoBtlsX509TrustKind trust; //Field offset: 0x60

	internal MonoBtlsX509LookupMonoCollection(X509CertificateCollection collection, MonoBtlsX509TrustKind trust) { }

	protected virtual void Close() { }

	private void Initialize() { }

	protected virtual MonoBtlsX509 OnGetBySubject(MonoBtlsX509Name name) { }

}

