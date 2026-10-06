namespace System;

public class ArgumentNullException : ArgumentException
{

	public ArgumentNullException() { }

	public ArgumentNullException(string paramName) { }

	public ArgumentNullException(string paramName, string message) { }

	protected ArgumentNullException(SerializationInfo info, StreamingContext context) { }

}

