namespace System.Security.Cryptography;

[ComVisible(True)]
public class CryptographicException : SystemException
{

	public CryptographicException() { }

	public CryptographicException(string message) { }

	public CryptographicException(string format, string insert) { }

	public CryptographicException(string message, Exception inner) { }

	public CryptographicException(int hr) { }

	protected CryptographicException(SerializationInfo info, StreamingContext context) { }

}

