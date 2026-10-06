namespace System.Runtime.Remoting.Messaging;

internal interface IInternalMessage
{

	public Identity TargetIdentity
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public string Uri
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public Identity get_TargetIdentity() { }

	public string get_Uri() { }

	public void set_TargetIdentity(Identity value) { }

	public void set_Uri(string value) { }

}

