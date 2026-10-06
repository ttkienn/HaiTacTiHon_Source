namespace System.Net;

public class AuthenticationManager
{
	private static ArrayList modules; //Field offset: 0x0
	private static object locker; //Field offset: 0x8
	private static ICredentialPolicy credential_policy; //Field offset: 0x10

	private static AuthenticationManager() { }

	public static Authorization Authenticate(string challenge, WebRequest request, ICredentials credentials) { }

	private static Authorization DoAuthenticate(string challenge, WebRequest request, ICredentials credentials) { }

	private static void EnsureModules() { }

	public static Authorization PreAuthenticate(WebRequest request, ICredentials credentials) { }

}

