namespace System;

public sealed class InvalidProgramException : SystemException
{

	public InvalidProgramException() { }

	public InvalidProgramException(string message) { }

	internal InvalidProgramException(SerializationInfo info, StreamingContext context) { }

}

