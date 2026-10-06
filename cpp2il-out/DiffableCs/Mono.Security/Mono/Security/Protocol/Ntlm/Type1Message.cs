namespace Mono.Security.Protocol.Ntlm;

public class Type1Message : MessageBase
{
	private string _host; //Field offset: 0x18
	private string _domain; //Field offset: 0x20

	public string Domain
	{
		 set { } //Length: 121
	}

	public string Host
	{
		 set { } //Length: 121
	}

	public Type1Message() { }

	protected virtual void Decode(Byte[] message) { }

	public virtual Byte[] GetBytes() { }

	public void set_Domain(string value) { }

	public void set_Host(string value) { }

}

