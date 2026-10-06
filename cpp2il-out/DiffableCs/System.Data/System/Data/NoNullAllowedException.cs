namespace System.Data;

public class NoNullAllowedException : DataException
{

	protected NoNullAllowedException(SerializationInfo info, StreamingContext context) { }

	public NoNullAllowedException() { }

	public NoNullAllowedException(string s) { }

}

