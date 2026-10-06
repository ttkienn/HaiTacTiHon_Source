namespace System.Runtime;

public sealed class AmbiguousImplementationException : Exception
{

	public AmbiguousImplementationException() { }

	public AmbiguousImplementationException(string message) { }

	private AmbiguousImplementationException(SerializationInfo info, StreamingContext context) { }

}

