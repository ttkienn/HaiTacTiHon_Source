namespace Mono.Btls;

internal class MonoBtlsException : Exception
{

	public MonoBtlsException() { }

	public MonoBtlsException(MonoBtlsSslError error) { }

	public MonoBtlsException(string message) { }

	public MonoBtlsException(string format, Object[] args) { }

}

