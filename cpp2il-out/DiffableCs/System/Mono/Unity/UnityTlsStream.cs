namespace Mono.Unity;

internal class UnityTlsStream : MobileAuthenticatedStream
{

	public UnityTlsStream(Stream innerStream, bool leaveInnerStreamOpen, SslStream owner, MonoTlsSettings settings, MobileTlsProvider provider) { }

	protected virtual MobileTlsContext CreateContext(MonoSslAuthenticationOptions options) { }

}

