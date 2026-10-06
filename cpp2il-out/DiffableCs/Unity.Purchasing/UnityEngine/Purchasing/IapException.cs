namespace UnityEngine.Purchasing;

[Nullable(0)]
[NullableContext(1)]
public abstract class IapException : Exception
{

	internal IapException() { }

	internal IapException(string message) { }

	protected IapException(SerializationInfo info, StreamingContext context) { }

}

