namespace UnityEngine.Assertions;

public class AssertionException : Exception
{
	private string m_UserMessage; //Field offset: 0x90

	public virtual string Message
	{
		 get { } //Length: 88
	}

	public AssertionException(string message, string userMessage) { }

	public virtual string get_Message() { }

}

