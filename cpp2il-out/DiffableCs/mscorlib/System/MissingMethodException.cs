namespace System;

public class MissingMethodException : MissingMemberException
{

	public virtual string Message
	{
		 get { } //Length: 290
	}

	public MissingMethodException() { }

	public MissingMethodException(string message) { }

	public MissingMethodException(string className, string methodName) { }

	protected MissingMethodException(SerializationInfo info, StreamingContext context) { }

	public virtual string get_Message() { }

}

