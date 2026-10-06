namespace System.Security.Cryptography;

[ComVisible(True)]
public class CryptographicUnexpectedOperationException : CryptographicException
{

	public CryptographicUnexpectedOperationException() { }

	public CryptographicUnexpectedOperationException(string message) { }

	protected CryptographicUnexpectedOperationException(SerializationInfo info, StreamingContext context) { }

}

