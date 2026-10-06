namespace System.Data;

public class DuplicateNameException : DataException
{

	protected DuplicateNameException(SerializationInfo info, StreamingContext context) { }

	public DuplicateNameException() { }

	public DuplicateNameException(string s) { }

}

