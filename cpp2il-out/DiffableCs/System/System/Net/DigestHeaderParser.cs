namespace System.Net;

internal class DigestHeaderParser
{
	private static String[] keywords; //Field offset: 0x0
	private string header; //Field offset: 0x10
	private int length; //Field offset: 0x18
	private int pos; //Field offset: 0x1C
	private String[] values; //Field offset: 0x20

	public string Algorithm
	{
		 get { } //Length: 39
	}

	public string Nonce
	{
		 get { } //Length: 39
	}

	public string Opaque
	{
		 get { } //Length: 39
	}

	public string QOP
	{
		 get { } //Length: 39
	}

	public string Realm
	{
		 get { } //Length: 39
	}

	private static DigestHeaderParser() { }

	public DigestHeaderParser(string header) { }

	public string get_Algorithm() { }

	public string get_Nonce() { }

	public string get_Opaque() { }

	public string get_QOP() { }

	public string get_Realm() { }

	private string GetKey() { }

	private bool GetKeywordAndValue(out string key, out string value) { }

	public bool Parse() { }

	private void SkipWhitespace() { }

}

