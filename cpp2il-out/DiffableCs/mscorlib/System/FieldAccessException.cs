namespace System;

public class FieldAccessException : MemberAccessException
{

	public FieldAccessException() { }

	public FieldAccessException(string message) { }

	protected FieldAccessException(SerializationInfo info, StreamingContext context) { }

}

