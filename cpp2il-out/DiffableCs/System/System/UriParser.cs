namespace System;

public abstract class UriParser
{
	private class BuiltInUriParser : UriParser
	{

		internal BuiltInUriParser(string lwrCaseScheme, int defaultPort, UriSyntaxFlags syntaxFlags) { }

	}

	private enum UriQuirksVersion
	{
		V2 = 2,
		V3 = 3,
	}

	private static readonly Dictionary<String, UriParser> m_Table; //Field offset: 0x0
	private static Dictionary<String, UriParser> m_TempTable; //Field offset: 0x8
	internal static UriParser HttpUri; //Field offset: 0x10
	internal static UriParser HttpsUri; //Field offset: 0x18
	internal static UriParser WsUri; //Field offset: 0x20
	internal static UriParser WssUri; //Field offset: 0x28
	internal static UriParser FtpUri; //Field offset: 0x30
	internal static UriParser FileUri; //Field offset: 0x38
	internal static UriParser GopherUri; //Field offset: 0x40
	internal static UriParser NntpUri; //Field offset: 0x48
	internal static UriParser NewsUri; //Field offset: 0x50
	internal static UriParser MailToUri; //Field offset: 0x58
	internal static UriParser UuidUri; //Field offset: 0x60
	internal static UriParser TelnetUri; //Field offset: 0x68
	internal static UriParser LdapUri; //Field offset: 0x70
	internal static UriParser NetTcpUri; //Field offset: 0x78
	internal static UriParser NetPipeUri; //Field offset: 0x80
	internal static UriParser VsMacrosUri; //Field offset: 0x88
	private static readonly UriQuirksVersion s_QuirksVersion; //Field offset: 0x90
	private static readonly UriSyntaxFlags HttpSyntaxFlags; //Field offset: 0x94
	private static readonly UriSyntaxFlags FileSyntaxFlags; //Field offset: 0x98
	private UriSyntaxFlags m_Flags; //Field offset: 0x10
	private UriSyntaxFlags m_UpdatableFlags; //Field offset: 0x14
	private bool m_UpdatableFlagsUsed; //Field offset: 0x18
	private int m_Port; //Field offset: 0x1C
	private string m_Scheme; //Field offset: 0x20

	internal int DefaultPort
	{
		internal get { } //Length: 4
	}

	internal UriSyntaxFlags Flags
	{
		internal get { } //Length: 191
	}

	internal bool IsSimple
	{
		internal get { } //Length: 11
	}

	internal string SchemeName
	{
		internal get { } //Length: 5
	}

	internal static bool ShouldUseLegacyV2Quirks
	{
		internal get { } //Length: 85
	}

	private static UriParser() { }

	internal UriParser(UriSyntaxFlags flags) { }

	internal static UriParser FindOrFetchAsUnknownV1Syntax(string lwrCaseScheme) { }

	internal int get_DefaultPort() { }

	internal UriSyntaxFlags get_Flags() { }

	internal bool get_IsSimple() { }

	internal string get_SchemeName() { }

	internal static bool get_ShouldUseLegacyV2Quirks() { }

	protected override string GetComponents(Uri uri, UriComponents components, UriFormat format) { }

	internal static UriParser GetSyntax(string lwrCaseScheme) { }

	internal bool InFact(UriSyntaxFlags flags) { }

	protected override void InitializeAndValidate(Uri uri, out UriFormatException parsingError) { }

	internal string InternalGetComponents(Uri thisUri, UriComponents uriComponents, UriFormat uriFormat) { }

	internal bool InternalIsBaseOf(Uri thisBaseUri, Uri uriLink) { }

	internal bool InternalIsWellFormedOriginalString(Uri thisUri) { }

	internal UriParser InternalOnNewUri() { }

	internal string InternalResolve(Uri thisBaseUri, Uri uriLink, out UriFormatException parsingError) { }

	internal void InternalValidate(Uri thisUri, out UriFormatException parsingError) { }

	internal bool IsAllSet(UriSyntaxFlags flags) { }

	protected override bool IsBaseOf(Uri baseUri, Uri relativeUri) { }

	private bool IsFullMatch(UriSyntaxFlags flags, UriSyntaxFlags expected) { }

	protected override bool IsWellFormedOriginalString(Uri uri) { }

	internal bool NotAny(UriSyntaxFlags flags) { }

	protected override UriParser OnNewUri() { }

	protected override string Resolve(Uri baseUri, Uri relativeUri, out UriFormatException parsingError) { }

}

