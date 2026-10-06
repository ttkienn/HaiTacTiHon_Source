namespace System;

public class ArgumentOutOfRangeException : ArgumentException
{
	private object _actualValue; //Field offset: 0x98

	public virtual string Message
	{
		 get { } //Length: 278
	}

	public ArgumentOutOfRangeException() { }

	public ArgumentOutOfRangeException(string paramName) { }

	public ArgumentOutOfRangeException(string paramName, string message) { }

	public ArgumentOutOfRangeException(string paramName, object actualValue, string message) { }

	protected ArgumentOutOfRangeException(SerializationInfo info, StreamingContext context) { }

	public virtual string get_Message() { }

	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

}

