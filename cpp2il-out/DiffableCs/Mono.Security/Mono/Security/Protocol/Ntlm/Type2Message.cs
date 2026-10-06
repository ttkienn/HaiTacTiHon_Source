namespace Mono.Security.Protocol.Ntlm;

public class Type2Message : MessageBase
{
	private Byte[] _nonce; //Field offset: 0x18
	private string _targetName; //Field offset: 0x20
	private Byte[] _targetInfo; //Field offset: 0x28

	public Byte[] Nonce
	{
		 get { } //Length: 119
	}

	public Byte[] TargetInfo
	{
		 get { } //Length: 119
	}

	public string TargetName
	{
		 get { } //Length: 5
	}

	public Type2Message(Byte[] message) { }

	protected virtual void Decode(Byte[] message) { }

	protected virtual void Finalize() { }

	public Byte[] get_Nonce() { }

	public Byte[] get_TargetInfo() { }

	public string get_TargetName() { }

	public virtual Byte[] GetBytes() { }

}

