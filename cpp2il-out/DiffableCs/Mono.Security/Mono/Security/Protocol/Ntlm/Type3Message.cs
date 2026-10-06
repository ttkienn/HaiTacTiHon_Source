namespace Mono.Security.Protocol.Ntlm;

public class Type3Message : MessageBase
{
	private NtlmAuthLevel _level; //Field offset: 0x18
	private Byte[] _challenge; //Field offset: 0x20
	private string _host; //Field offset: 0x28
	private string _domain; //Field offset: 0x30
	private string _username; //Field offset: 0x38
	private string _password; //Field offset: 0x40
	private Type2Message _type2; //Field offset: 0x48
	private Byte[] _lm; //Field offset: 0x50
	private Byte[] _nt; //Field offset: 0x58

	public string Domain
	{
		 set { } //Length: 121
	}

	public string Password
	{
		 set { } //Length: 13
	}

	public string Username
	{
		 set { } //Length: 13
	}

	public Type3Message(Type2Message type2) { }

	protected virtual void Decode(Byte[] message) { }

	private string DecodeString(Byte[] buffer, int offset, int len) { }

	private Byte[] EncodeString(string text) { }

	protected virtual void Finalize() { }

	public virtual Byte[] GetBytes() { }

	public void set_Domain(string value) { }

	public void set_Password(string value) { }

	public void set_Username(string value) { }

}

