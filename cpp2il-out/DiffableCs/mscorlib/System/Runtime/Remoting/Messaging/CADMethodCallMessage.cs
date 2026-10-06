namespace System.Runtime.Remoting.Messaging;

internal class CADMethodCallMessage : CADMessageBase
{
	private string _uri; //Field offset: 0x38

	internal int PropertiesCount
	{
		internal get { } //Length: 4
	}

	internal string Uri
	{
		internal get { } //Length: 5
	}

	internal CADMethodCallMessage(IMethodCallMessage callMsg) { }

	internal static CADMethodCallMessage Create(IMessage callMsg) { }

	internal int get_PropertiesCount() { }

	internal string get_Uri() { }

	internal Object[] GetArgs(ArrayList args) { }

	internal ArrayList GetArguments() { }

}

