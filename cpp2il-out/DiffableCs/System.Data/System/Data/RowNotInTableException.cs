namespace System.Data;

public class RowNotInTableException : DataException
{

	protected RowNotInTableException(SerializationInfo info, StreamingContext context) { }

	public RowNotInTableException() { }

	public RowNotInTableException(string s) { }

}

