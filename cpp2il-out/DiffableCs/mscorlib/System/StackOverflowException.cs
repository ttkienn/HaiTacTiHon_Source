namespace System;

public sealed class StackOverflowException : SystemException
{

	public StackOverflowException() { }

	public StackOverflowException(string message) { }

	internal StackOverflowException(SerializationInfo info, StreamingContext context) { }

}

