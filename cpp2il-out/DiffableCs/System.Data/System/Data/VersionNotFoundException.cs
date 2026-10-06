namespace System.Data;

public class VersionNotFoundException : DataException
{

	protected VersionNotFoundException(SerializationInfo info, StreamingContext context) { }

	public VersionNotFoundException() { }

	public VersionNotFoundException(string s) { }

}

