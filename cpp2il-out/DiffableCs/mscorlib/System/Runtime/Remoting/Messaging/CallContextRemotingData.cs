namespace System.Runtime.Remoting.Messaging;

internal class CallContextRemotingData : ICloneable
{
	private string _logicalCallID; //Field offset: 0x10

	internal bool HasInfo
	{
		internal get { } //Length: 9
	}

	internal string LogicalCallID
	{
		internal get { } //Length: 5
		internal set { } //Length: 13
	}

	public CallContextRemotingData() { }

	public override object Clone() { }

	internal bool get_HasInfo() { }

	internal string get_LogicalCallID() { }

	internal void set_LogicalCallID(string value) { }

}

