namespace System;

public class MissingFieldException : MissingMemberException, ISerializable
{

	public virtual string Message
	{
		 get { } //Length: 525
	}

	public MissingFieldException() { }

	public MissingFieldException(string message) { }

	public MissingFieldException(string className, string fieldName) { }

	protected MissingFieldException(SerializationInfo info, StreamingContext context) { }

	public virtual string get_Message() { }

}

