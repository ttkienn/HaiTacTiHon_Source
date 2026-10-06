namespace System.Net;

public interface IWebProxy
{

	public ICredentials Credentials
	{
		 get { } //Length: 0
	}

	public ICredentials get_Credentials() { }

	public Uri GetProxy(Uri destination) { }

	public bool IsBypassed(Uri host) { }

}

