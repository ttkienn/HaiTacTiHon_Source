namespace System.Data;

public class DataException : SystemException
{

	protected DataException(SerializationInfo info, StreamingContext context) { }

	public DataException() { }

	public DataException(string s) { }

	public DataException(string s, Exception innerException) { }

}

