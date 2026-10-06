namespace System;

[AttributeUsage(6140, Inherited = False)]
public sealed class ObsoleteAttribute : Attribute
{
	private string _message; //Field offset: 0x10
	private bool _error; //Field offset: 0x18

	public bool IsError
	{
		 get { } //Length: 5
	}

	public string Message
	{
		 get { } //Length: 5
	}

	public ObsoleteAttribute() { }

	public ObsoleteAttribute(string message) { }

	public ObsoleteAttribute(string message, bool error) { }

	public bool get_IsError() { }

	public string get_Message() { }

}

