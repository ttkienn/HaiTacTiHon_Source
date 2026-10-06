namespace System.Net;

internal class CookieTokenizer
{
	private struct RecognizedAttribute
	{
		private string m_name; //Field offset: 0x0
		private CookieToken m_token; //Field offset: 0x8

		internal CookieToken Token
		{
			internal get { } //Length: 4
		}

		internal RecognizedAttribute(string name, CookieToken token) { }

		internal CookieToken get_Token() { }

		internal bool IsEqualTo(string value) { }

	}

	private static RecognizedAttribute[] RecognizedAttributes; //Field offset: 0x0
	private static RecognizedAttribute[] RecognizedServerAttributes; //Field offset: 0x8
	private bool m_eofCookie; //Field offset: 0x10
	private int m_index; //Field offset: 0x14
	private int m_length; //Field offset: 0x18
	private string m_name; //Field offset: 0x20
	private bool m_quoted; //Field offset: 0x28
	private int m_start; //Field offset: 0x2C
	private CookieToken m_token; //Field offset: 0x30
	private int m_tokenLength; //Field offset: 0x34
	private string m_tokenStream; //Field offset: 0x38
	private string m_value; //Field offset: 0x40

	internal bool EndOfCookie
	{
		internal get { } //Length: 5
		internal set { } //Length: 4
	}

	internal bool Eof
	{
		internal get { } //Length: 10
	}

	internal string Name
	{
		internal get { } //Length: 5
		internal set { } //Length: 13
	}

	internal bool Quoted
	{
		internal get { } //Length: 5
		internal set { } //Length: 4
	}

	internal CookieToken Token
	{
		internal get { } //Length: 4
		internal set { } //Length: 4
	}

	internal string Value
	{
		internal get { } //Length: 5
		internal set { } //Length: 13
	}

	private static CookieTokenizer() { }

	internal CookieTokenizer(string tokenStream) { }

	internal string Extract() { }

	internal CookieToken FindNext(bool ignoreComma, bool ignoreEquals) { }

	internal bool get_EndOfCookie() { }

	internal bool get_Eof() { }

	internal string get_Name() { }

	internal bool get_Quoted() { }

	internal CookieToken get_Token() { }

	internal string get_Value() { }

	internal CookieToken Next(bool first, bool parseResponseCookies) { }

	internal void Reset() { }

	internal void set_EndOfCookie(bool value) { }

	internal void set_Name(string value) { }

	internal void set_Quoted(bool value) { }

	internal void set_Token(CookieToken value) { }

	internal void set_Value(string value) { }

	internal CookieToken TokenFromName(bool parseResponseCookies) { }

}

