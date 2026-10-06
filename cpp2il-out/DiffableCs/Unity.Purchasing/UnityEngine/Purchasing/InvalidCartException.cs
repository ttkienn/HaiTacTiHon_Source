namespace UnityEngine.Purchasing;

[Nullable(0)]
[NullableContext(1)]
public class InvalidCartException : IapException
{

	public InvalidCartException() { }

	public InvalidCartException(string message) { }

	protected InvalidCartException(SerializationInfo info, StreamingContext context) { }

}

