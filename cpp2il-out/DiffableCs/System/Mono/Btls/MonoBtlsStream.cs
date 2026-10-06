namespace Mono.Btls;

internal class MonoBtlsStream : MobileAuthenticatedStream
{

	public MonoBtlsStream(Stream innerStream, bool leaveInnerStreamOpen, SslStream owner, MonoTlsSettings settings, MobileTlsProvider provider) { }

	protected virtual MobileTlsContext CreateContext(MonoSslAuthenticationOptions options) { }

}

