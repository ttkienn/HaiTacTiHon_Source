namespace System.Net;

public interface ICredentials
{

	public NetworkCredential GetCredential(Uri uri, string authType) { }

}

