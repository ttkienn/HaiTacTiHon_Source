namespace Mono.Net.Security;

internal class AsyncWriteRequest : AsyncReadOrWriteRequest
{

	public AsyncWriteRequest(MobileAuthenticatedStream parent, bool sync, Byte[] buffer, int offset, int size) { }

	protected virtual AsyncOperationStatus Run(AsyncOperationStatus status) { }

}

