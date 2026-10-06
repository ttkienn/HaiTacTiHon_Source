namespace UnityEngine.Purchasing;

[Nullable(0)]
[NullableContext(1)]
public class InvalidCartItemException : IapException
{

	public InvalidCartItemException() { }

	public InvalidCartItemException(string message) { }

	protected InvalidCartItemException(SerializationInfo info, StreamingContext context) { }

}

