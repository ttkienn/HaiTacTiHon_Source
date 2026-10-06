namespace System.Net;

internal class BasicClient : IAuthenticationModule
{

	public override string AuthenticationType
	{
		 get { } //Length: 44
	}

	public BasicClient() { }

	public override Authorization Authenticate(string challenge, WebRequest webRequest, ICredentials credentials) { }

	public override string get_AuthenticationType() { }

	private static Byte[] GetBytes(string str) { }

	private static Authorization InternalAuthenticate(WebRequest webRequest, ICredentials credentials) { }

	public override Authorization PreAuthenticate(WebRequest webRequest, ICredentials credentials) { }

}

