namespace System.Runtime.Remoting.Messaging;

internal class CallContextSecurityData : ICloneable
{
	private IPrincipal _principal; //Field offset: 0x10

	internal bool HasInfo
	{
		internal get { } //Length: 9
	}

	public CallContextSecurityData() { }

	public override object Clone() { }

	internal bool get_HasInfo() { }

}

