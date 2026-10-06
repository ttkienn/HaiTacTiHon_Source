namespace System.Net;

public interface IAuthenticationModule
{

	public string AuthenticationType
	{
		 get { } //Length: 0
	}

	public Authorization Authenticate(string challenge, WebRequest request, ICredentials credentials) { }

	public string get_AuthenticationType() { }

	public Authorization PreAuthenticate(WebRequest request, ICredentials credentials) { }

}

