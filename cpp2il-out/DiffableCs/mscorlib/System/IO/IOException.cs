namespace System.IO;

public class IOException : SystemException
{

	public IOException() { }

	public IOException(string message) { }

	public IOException(string message, int hresult) { }

	public IOException(string message, Exception innerException) { }

	protected IOException(SerializationInfo info, StreamingContext context) { }

}

