namespace Mono.Security.Interface;

public sealed class TlsException : Exception
{
	private Alert alert; //Field offset: 0x90

	public TlsException(Alert alert) { }

	public TlsException(Alert alert, string message) { }

	public TlsException(AlertDescription description) { }

	public TlsException(AlertDescription description, string message) { }

}

