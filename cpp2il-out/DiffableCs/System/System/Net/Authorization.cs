namespace System.Net;

public class Authorization
{
	private string m_Message; //Field offset: 0x10
	private bool m_Complete; //Field offset: 0x18
	internal string ModuleAuthenticationType; //Field offset: 0x20

	public bool Complete
	{
		 get { } //Length: 5
	}

	public string Message
	{
		 get { } //Length: 5
	}

	public Authorization(string token) { }

	public Authorization(string token, bool finished) { }

	public bool get_Complete() { }

	public string get_Message() { }

}

