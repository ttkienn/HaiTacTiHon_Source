namespace System;

public class BadImageFormatException : SystemException
{
	private string _fileName; //Field offset: 0x90
	private string _fusionLog; //Field offset: 0x98

	public virtual string Message
	{
		 get { } //Length: 144
	}

	public BadImageFormatException() { }

	public BadImageFormatException(string message) { }

	public BadImageFormatException(string message, Exception inner) { }

	public BadImageFormatException(string message, string fileName) { }

	protected BadImageFormatException(SerializationInfo info, StreamingContext context) { }

	public virtual string get_Message() { }

	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	private void SetMessageField() { }

	public virtual string ToString() { }

}

