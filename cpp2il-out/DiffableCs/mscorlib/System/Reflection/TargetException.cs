namespace System.Reflection;

public class TargetException : ApplicationException
{

	public TargetException() { }

	public TargetException(string message) { }

	public TargetException(string message, Exception inner) { }

	protected TargetException(SerializationInfo info, StreamingContext context) { }

}

