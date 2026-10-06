namespace System.Net;

public class NetworkCredential : ICredentials
{
	private string m_domain; //Field offset: 0x10
	private string m_userName; //Field offset: 0x18
	private SecureString m_password; //Field offset: 0x20

	public string Domain
	{
		 get { } //Length: 5
		 set { } //Length: 95
	}

	public string Password
	{
		 get { } //Length: 11
		 set { } //Length: 43
	}

	public string UserName
	{
		 get { } //Length: 5
		 set { } //Length: 95
	}

	public NetworkCredential(string userName, string password) { }

	public NetworkCredential(string userName, string password, string domain) { }

	public string get_Domain() { }

	public string get_Password() { }

	public string get_UserName() { }

	public override NetworkCredential GetCredential(Uri uri, string authType) { }

	internal string InternalGetDomain() { }

	internal string InternalGetPassword() { }

	internal string InternalGetUserName() { }

	public void set_Domain(string value) { }

	public void set_Password(string value) { }

	public void set_UserName(string value) { }

}

