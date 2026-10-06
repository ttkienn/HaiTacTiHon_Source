namespace System;

[Obsolete("This type previously indicated an unspecified fatal error in the runtime. The runtime no longer raises this exception so this type is obsolete.")]
public sealed class ExecutionEngineException : SystemException
{

	public ExecutionEngineException() { }

	public ExecutionEngineException(string message) { }

	internal ExecutionEngineException(SerializationInfo info, StreamingContext context) { }

}

