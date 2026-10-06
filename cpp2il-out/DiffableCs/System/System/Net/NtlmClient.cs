namespace System.Net;

internal class NtlmClient : IAuthenticationModule
{
	private IAuthenticationModule authObject; //Field offset: 0x10

	public override string AuthenticationType
	{
		 get { } //Length: 44
	}

	public NtlmClient() { }

	public override Authorization Authenticate(string challenge, WebRequest webRequest, ICredentials credentials) { }

	public override string get_AuthenticationType() { }

	public override Authorization PreAuthenticate(WebRequest webRequest, ICredentials credentials) { }

}

