namespace Mono.Security.Protocol.Ntlm;

[Obsolete("Use of this API is highly discouraged, it selects legacy-mode LM/NTLM authentication, which sends your password in very weak encryption over the wire even if the server supports the more secure NTLMv2 / NTLMv2 Session. You need to use the new `Type3Message (Type2Message)' constructor to use the more secure NTLMv2 / NTLMv2 Session authentication modes. These require the Type 2 message from the server to compute the response.")]
public class ChallengeResponse : IDisposable
{
	private static Byte[] magic; //Field offset: 0x0
	private static Byte[] nullEncMagic; //Field offset: 0x8
	private bool _disposed; //Field offset: 0x10
	private Byte[] _challenge; //Field offset: 0x18
	private Byte[] _lmpwd; //Field offset: 0x20
	private Byte[] _ntpwd; //Field offset: 0x28

	public Byte[] Challenge
	{
		 set { } //Length: 335
	}

	public Byte[] LM
	{
		 get { } //Length: 108
	}

	public Byte[] NT
	{
		 get { } //Length: 108
	}

	public string Password
	{
		 set { } //Length: 1001
	}

	private static ChallengeResponse() { }

	public ChallengeResponse() { }

	public ChallengeResponse(string password, Byte[] challenge) { }

	public override void Dispose() { }

	private void Dispose(bool disposing) { }

	protected virtual void Finalize() { }

	public Byte[] get_LM() { }

	public Byte[] get_NT() { }

	private Byte[] GetResponse(Byte[] pwd) { }

	private Byte[] PasswordToKey(string password, int position) { }

	private Byte[] PrepareDESKey(Byte[] key56bits, int position) { }

	public void set_Challenge(Byte[] value) { }

	public void set_Password(string value) { }

}

