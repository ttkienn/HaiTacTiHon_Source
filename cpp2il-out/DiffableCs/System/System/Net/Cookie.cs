namespace System.Net;

public sealed class Cookie
{
	internal static readonly Char[] PortSplitDelimiters; //Field offset: 0x0
	internal static readonly Char[] Reserved2Name; //Field offset: 0x8
	internal static readonly Char[] Reserved2Value; //Field offset: 0x10
	private static Comparer staticComparer; //Field offset: 0x18
	private string m_comment; //Field offset: 0x10
	private Uri m_commentUri; //Field offset: 0x18
	private CookieVariant m_cookieVariant; //Field offset: 0x20
	private bool m_discard; //Field offset: 0x24
	private string m_domain; //Field offset: 0x28
	private bool m_domain_implicit; //Field offset: 0x30
	private DateTime m_expires; //Field offset: 0x38
	private string m_name; //Field offset: 0x40
	private string m_path; //Field offset: 0x48
	private bool m_path_implicit; //Field offset: 0x50
	private string m_port; //Field offset: 0x58
	private bool m_port_implicit; //Field offset: 0x60
	private Int32[] m_port_list; //Field offset: 0x68
	private bool m_secure; //Field offset: 0x70
	[OptionalField]
	private bool m_httpOnly; //Field offset: 0x71
	private DateTime m_timeStamp; //Field offset: 0x78
	private string m_value; //Field offset: 0x80
	private int m_version; //Field offset: 0x88
	private string m_domainKey; //Field offset: 0x90
	internal bool IsQuotedVersion; //Field offset: 0x98
	internal bool IsQuotedDomain; //Field offset: 0x99

	private string _Domain
	{
		private get { } //Length: 188
	}

	private string _Path
	{
		private get { } //Length: 127
	}

	private string _Port
	{
		private get { } //Length: 183
	}

	private string _Version
	{
		private get { } //Length: 247
	}

	public string Comment
	{
		 get { } //Length: 5
		 set { } //Length: 92
	}

	public Uri CommentUri
	{
		 set { } //Length: 13
	}

	public bool Discard
	{
		 set { } //Length: 4
	}

	public string Domain
	{
		 get { } //Length: 5
		 set { } //Length: 142
	}

	internal string DomainKey
	{
		internal get { } //Length: 19
	}

	public bool Expired
	{
		 get { } //Length: 179
	}

	public DateTime Expires
	{
		 set { } //Length: 5
	}

	public bool HttpOnly
	{
		 set { } //Length: 4
	}

	public string Name
	{
		 get { } //Length: 5
	}

	public string Path
	{
		 get { } //Length: 5
		 set { } //Length: 107
	}

	internal bool Plain
	{
		internal get { } //Length: 8
	}

	public string Port
	{
		 set { } //Length: 1199
	}

	internal Int32[] PortList
	{
		internal get { } //Length: 5
	}

	public bool Secure
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public string Value
	{
		 get { } //Length: 8
		 set { } //Length: 108
	}

	internal CookieVariant Variant
	{
		internal get { } //Length: 4
	}

	public int Version
	{
		 get { } //Length: 7
		 set { } //Length: 116
	}

	private static Cookie() { }

	public Cookie() { }

	private static bool DomainCharsTest(string name) { }

	public virtual bool Equals(object comparand) { }

	private string get__Domain() { }

	private string get__Path() { }

	private string get__Port() { }

	private string get__Version() { }

	public string get_Comment() { }

	public string get_Domain() { }

	internal string get_DomainKey() { }

	public bool get_Expired() { }

	public string get_Name() { }

	public string get_Path() { }

	internal bool get_Plain() { }

	internal Int32[] get_PortList() { }

	public bool get_Secure() { }

	public string get_Value() { }

	internal CookieVariant get_Variant() { }

	public int get_Version() { }

	internal static IComparer GetComparer() { }

	public virtual int GetHashCode() { }

	internal bool InternalSetName(string value) { }

	private static bool IsDomainEqualToHost(string domain, string host) { }

	public void set_Comment(string value) { }

	public void set_CommentUri(Uri value) { }

	public void set_Discard(bool value) { }

	public void set_Domain(string value) { }

	public void set_Expires(DateTime value) { }

	public void set_HttpOnly(bool value) { }

	public void set_Path(string value) { }

	public void set_Port(string value) { }

	public void set_Secure(bool value) { }

	public void set_Value(string value) { }

	public void set_Version(int value) { }

	public virtual string ToString() { }

	internal bool VerifySetDefaults(CookieVariant variant, Uri uri, bool isLocalDomain, string localDomain, bool set_default, bool isThrow) { }

}

