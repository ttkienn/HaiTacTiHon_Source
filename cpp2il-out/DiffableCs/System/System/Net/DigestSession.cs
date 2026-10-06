namespace System.Net;

internal class DigestSession
{
	private static RandomNumberGenerator rng; //Field offset: 0x0
	private DateTime lastUse; //Field offset: 0x10
	private int _nc; //Field offset: 0x18
	private HashAlgorithm hash; //Field offset: 0x20
	private DigestHeaderParser parser; //Field offset: 0x28
	private string _cnonce; //Field offset: 0x30

	public string Algorithm
	{
		 get { } //Length: 48
	}

	public string CNonce
	{
		 get { } //Length: 251
	}

	public DateTime LastUse
	{
		 get { } //Length: 5
	}

	public string Nonce
	{
		 get { } //Length: 48
	}

	public string Opaque
	{
		 get { } //Length: 48
	}

	public string QOP
	{
		 get { } //Length: 48
	}

	public string Realm
	{
		 get { } //Length: 48
	}

	private static DigestSession() { }

	public DigestSession() { }

	public Authorization Authenticate(WebRequest webRequest, ICredentials credentials) { }

	public string get_Algorithm() { }

	public string get_CNonce() { }

	public DateTime get_LastUse() { }

	public string get_Nonce() { }

	public string get_Opaque() { }

	public string get_QOP() { }

	public string get_Realm() { }

	private string HA1(string username, string password) { }

	private string HA2(HttpWebRequest webRequest) { }

	private string HashToHexString(string toBeHashed) { }

	public bool Parse(string challenge) { }

	private string Response(string username, string password, HttpWebRequest webRequest) { }

}

