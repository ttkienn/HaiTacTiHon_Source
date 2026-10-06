namespace System;

public class ArgumentException : SystemException
{
	private string _paramName; //Field offset: 0x90

	public virtual string Message
	{
		 get { } //Length: 145
	}

	public ArgumentException() { }

	public ArgumentException(string message) { }

	public ArgumentException(string message, Exception innerException) { }

	public ArgumentException(string message, string paramName, Exception innerException) { }

	public ArgumentException(string message, string paramName) { }

	protected ArgumentException(SerializationInfo info, StreamingContext context) { }

	public virtual string get_Message() { }

	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

}

