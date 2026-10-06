namespace System.Data;

public class ReadOnlyException : DataException
{

	protected ReadOnlyException(SerializationInfo info, StreamingContext context) { }

	public ReadOnlyException() { }

	public ReadOnlyException(string s) { }

}

