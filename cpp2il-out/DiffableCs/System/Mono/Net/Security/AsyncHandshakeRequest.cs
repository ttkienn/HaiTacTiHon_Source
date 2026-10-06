namespace Mono.Net.Security;

internal class AsyncHandshakeRequest : AsyncProtocolRequest
{

	public AsyncHandshakeRequest(MobileAuthenticatedStream parent, bool sync) { }

	protected virtual AsyncOperationStatus Run(AsyncOperationStatus status) { }

}

