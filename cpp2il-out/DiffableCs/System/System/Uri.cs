namespace System;

[TypeConverter(typeof(UriTypeConverter))]
public class Uri : ISerializable
{
	[Flags]
	private enum Check
	{
		None = 0,
		EscapedCanonical = 1,
		DisplayCanonical = 2,
		DotSlashAttn = 4,
		DotSlashEscaped = 128,
		BackslashInPath = 16,
		ReservedFound = 32,
		NotIriCanonical = 64,
		FoundNonAscii = 8,
	}

	[Flags]
	private enum Flags
	{
		Zero = 0,
		SchemeNotCanonical = 1,
		UserNotCanonical = 2,
		HostNotCanonical = 4,
		PortNotCanonical = 8,
		PathNotCanonical = 16,
		QueryNotCanonical = 32,
		FragmentNotCanonical = 64,
		CannotDisplayCanonical = 127,
		E_UserNotCanonical = 128,
		E_HostNotCanonical = 256,
		E_PortNotCanonical = 512,
		E_PathNotCanonical = 1024,
		E_QueryNotCanonical = 2048,
		E_FragmentNotCanonical = 4096,
		E_CannotDisplayCanonical = 8064,
		ShouldBeCompressed = 8192,
		FirstSlashAbsent = 16384,
		BackslashInPath = 32768,
		IndexMask = 65535,
		HostTypeMask = 458752,
		HostNotParsed = 0,
		IPv6HostType = 65536,
		IPv4HostType = 131072,
		DnsHostType = 196608,
		UncHostType = 262144,
		BasicHostType = 327680,
		UnusedHostType = 393216,
		UnknownHostType = 458752,
		UserEscaped = 524288,
		AuthorityFound = 1048576,
		HasUserInfo = 2097152,
		LoopbackHost = 4194304,
		NotDefaultPort = 8388608,
		UserDrivenParsing = 16777216,
		CanonicalDnsHost = 33554432,
		ErrorOrParsingRecursion = 67108864,
		DosPath = 134217728,
		UncPath = 268435456,
		ImplicitFile = 536870912,
		MinimalUriInfoSet = 1073741824,
		AllUriInfoSet = 2147483648,
		IdnHost = 4294967296,
		HasUnicode = 8589934592,
		HostUnicodeNormalized = 17179869184,
		RestUnicodeNormalized = 34359738368,
		UnicodeHost = 68719476736,
		IntranetUri = 137438953472,
		UseOrigUncdStrOffset = 274877906944,
		UserIriCanonical = 549755813888,
		PathIriCanonical = 1099511627776,
		QueryIriCanonical = 2199023255552,
		FragmentIriCanonical = 4398046511104,
		IriCanonical = 8246337208320,
		CompressedSlashes = 17592186044416,
	}

	private class MoreInfo
	{
		public string Path; //Field offset: 0x10
		public string Query; //Field offset: 0x18
		public string Fragment; //Field offset: 0x20
		public string AbsoluteUri; //Field offset: 0x28
		public int Hash; //Field offset: 0x30
		public string RemoteUrl; //Field offset: 0x38

		public MoreInfo() { }

	}

	private struct Offset
	{
		public ushort Scheme; //Field offset: 0x0
		public ushort User; //Field offset: 0x2
		public ushort Host; //Field offset: 0x4
		public ushort PortValue; //Field offset: 0x6
		public ushort Path; //Field offset: 0x8
		public ushort Query; //Field offset: 0xA
		public ushort Fragment; //Field offset: 0xC
		public ushort End; //Field offset: 0xE

	}

	private class UriInfo
	{
		public string Host; //Field offset: 0x10
		public string ScopeId; //Field offset: 0x18
		public string String; //Field offset: 0x20
		public Offset Offset; //Field offset: 0x28
		public string DnsSafeHost; //Field offset: 0x38
		public MoreInfo MoreInfo; //Field offset: 0x40

		public UriInfo() { }

	}

	public static readonly string UriSchemeFile; //Field offset: 0x0
	public static readonly string UriSchemeFtp; //Field offset: 0x8
	public static readonly string UriSchemeGopher; //Field offset: 0x10
	public static readonly string UriSchemeHttp; //Field offset: 0x18
	public static readonly string UriSchemeHttps; //Field offset: 0x20
	internal static readonly string UriSchemeWs; //Field offset: 0x28
	internal static readonly string UriSchemeWss; //Field offset: 0x30
	public static readonly string UriSchemeMailto; //Field offset: 0x38
	public static readonly string UriSchemeNews; //Field offset: 0x40
	public static readonly string UriSchemeNntp; //Field offset: 0x48
	public static readonly string UriSchemeNetTcp; //Field offset: 0x50
	public static readonly string UriSchemeNetPipe; //Field offset: 0x58
	public static readonly string SchemeDelimiter; //Field offset: 0x60
	private static bool s_ConfigInitialized; //Field offset: 0x68
	private static bool s_ConfigInitializing; //Field offset: 0x69
	private static UriIdnScope s_IdnScope; //Field offset: 0x6C
	private static bool s_IriParsing; //Field offset: 0x70
	private static bool useDotNetRelativeOrAbsolute; //Field offset: 0x71
	internal static readonly bool IsWindowsFileSystem; //Field offset: 0x72
	private static object s_initLock; //Field offset: 0x78
	internal static readonly Char[] HexLowerChars; //Field offset: 0x80
	private static readonly Char[] _WSchars; //Field offset: 0x88
	private string m_String; //Field offset: 0x10
	private string m_originalUnicodeString; //Field offset: 0x18
	private UriParser m_Syntax; //Field offset: 0x20
	private string m_DnsSafeHost; //Field offset: 0x28
	private Flags m_Flags; //Field offset: 0x30
	private UriInfo m_Info; //Field offset: 0x38
	private bool m_iriParsing; //Field offset: 0x40

	public string AbsolutePath
	{
		 get { } //Length: 194
	}

	public string AbsoluteUri
	{
		 get { } //Length: 326
	}

	private bool AllowIdn
	{
		private get { } //Length: 229
	}

	public string Authority
	{
		 get { } //Length: 139
	}

	public string DnsSafeHost
	{
		 get { } //Length: 795
	}

	public string Fragment
	{
		 get { } //Length: 326
	}

	internal bool HasAuthority
	{
		internal get { } //Length: 13
	}

	public string Host
	{
		 get { } //Length: 139
	}

	public UriHostNameType HostNameType
	{
		 get { } //Length: 335
	}

	private Flags HostType
	{
		private get { } //Length: 9
	}

	private static object InitializeLock
	{
		private get { } //Length: 234
	}

	public bool IsAbsoluteUri
	{
		 get { } //Length: 9
	}

	public bool IsDefaultPort
	{
		 get { } //Length: 248
	}

	private bool IsDosPath
	{
		private get { } //Length: 13
	}

	public bool IsFile
	{
		 get { } //Length: 197
	}

	private bool IsImplicitFile
	{
		private get { } //Length: 13
	}

	public bool IsLoopback
	{
		 get { } //Length: 186
	}

	private bool IsNotAbsoluteUri
	{
		private get { } //Length: 9
	}

	public bool IsUnc
	{
		 get { } //Length: 133
	}

	private bool IsUncOrDosPath
	{
		private get { } //Length: 13
	}

	private bool IsUncPath
	{
		private get { } //Length: 13
	}

	public string LocalPath
	{
		 get { } //Length: 127
	}

	public string OriginalString
	{
		 get { } //Length: 94
	}

	private bool OriginalStringSwitched
	{
		private get { } //Length: 95
	}

	public string PathAndQuery
	{
		 get { } //Length: 206
	}

	public int Port
	{
		 get { } //Length: 264
	}

	private string PrivateAbsolutePath
	{
		private get { } //Length: 224
	}

	public string Query
	{
		 get { } //Length: 326
	}

	public string Scheme
	{
		 get { } //Length: 129
	}

	private ushort SecuredPathIndex
	{
		private get { } //Length: 84
	}

	public String[] Segments
	{
		 get { } //Length: 528
	}

	private UriParser Syntax
	{
		private get { } //Length: 5
	}

	internal bool UserDrivenParsing
	{
		internal get { } //Length: 13
	}

	public bool UserEscaped
	{
		 get { } //Length: 13
	}

	public string UserInfo
	{
		 get { } //Length: 139
	}

	private static Uri() { }

	protected Uri(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	public Uri(Uri baseUri, string relativeUri) { }

	public Uri(string uriString, UriKind uriKind) { }

	public Uri(string uriString) { }

	public Uri(Uri baseUri, Uri relativeUri) { }

	private Uri(Flags flags, UriParser uriParser, string uri) { }

	private bool AllowIdnStatic(UriParser syntax, Flags flags) { }

	internal static int CalculateCaseInsensitiveHashCode(string text) { }

	private ushort CheckAuthorityHelper(Char* pString, ushort idx, ushort length, ref ParsingError err, ref Flags flags, UriParser syntax, ref string newHost) { }

	private void CheckAuthorityHelperHandleAnyHostIri(Char* pString, int startInput, int end, bool iriParsing, bool hasUnicode, UriParser syntax, ref Flags flags, ref string newHost, ref ParsingError err) { }

	private void CheckAuthorityHelperHandleDnsIri(Char* pString, ushort start, int end, int startInput, bool iriParsing, bool hasUnicode, UriParser syntax, string userInfoString, ref Flags flags, ref bool justNormalized, ref string newHost, ref ParsingError err) { }

	private Check CheckCanonical(Char* str, ref ushort idx, ushort end, char delim) { }

	private static bool CheckForColonInFirstPathSegment(string uriString) { }

	private bool CheckForConfigLoad(string data) { }

	private bool CheckForEscapedUnreserved(string data) { }

	private bool CheckForUnicode(string data) { }

	private static bool CheckKnownSchemes(Int64* lptr, ushort nChars, ref UriParser syntax) { }

	private static ParsingError CheckSchemeSyntax(Char* ptr, ushort length, ref UriParser syntax) { }

	private static string CombineUri(Uri basePart, string relativePart, UriFormat uriFormat) { }

	private static Char[] Compress(Char[] dest, ushort start, ref int destLength, UriParser syntax) { }

	internal static Uri CreateHelper(string uriString, bool dontEscape, UriKind uriKind, ref UriFormatException e) { }

	private void CreateHostString() { }

	private static string CreateHostStringHelper(string str, ushort idx, ushort end, ref Flags flags, ref string scopeId) { }

	private void CreateThis(string uri, bool dontEscape, UriKind uriKind) { }

	private void CreateThisFromUri(Uri otherUri) { }

	private void CreateUri(Uri baseUri, string relativeUri, bool dontEscape) { }

	private void CreateUriInfo(Flags cF) { }

	private void EnsureHostString(bool allowDnsOptimization) { }

	private void EnsureParseRemaining() { }

	private UriInfo EnsureUriInfo() { }

	public virtual bool Equals(object comparand) { }

	internal string EscapeUnescapeIri(string input, int start, int end, UriComponents component) { }

	private void FindEndOfComponent(Char* str, ref ushort idx, ushort end, char delim) { }

	private void FindEndOfComponent(string input, ref ushort idx, ushort end, char delim) { }

	public static int FromHex(char digit) { }

	public string get_AbsolutePath() { }

	public string get_AbsoluteUri() { }

	private bool get_AllowIdn() { }

	public string get_Authority() { }

	public string get_DnsSafeHost() { }

	public string get_Fragment() { }

	internal bool get_HasAuthority() { }

	public string get_Host() { }

	public UriHostNameType get_HostNameType() { }

	private Flags get_HostType() { }

	private static object get_InitializeLock() { }

	public bool get_IsAbsoluteUri() { }

	public bool get_IsDefaultPort() { }

	private bool get_IsDosPath() { }

	public bool get_IsFile() { }

	private bool get_IsImplicitFile() { }

	public bool get_IsLoopback() { }

	private bool get_IsNotAbsoluteUri() { }

	public bool get_IsUnc() { }

	private bool get_IsUncOrDosPath() { }

	private bool get_IsUncPath() { }

	public string get_LocalPath() { }

	public string get_OriginalString() { }

	private bool get_OriginalStringSwitched() { }

	public string get_PathAndQuery() { }

	public int get_Port() { }

	private string get_PrivateAbsolutePath() { }

	public string get_Query() { }

	public string get_Scheme() { }

	private ushort get_SecuredPathIndex() { }

	public String[] get_Segments() { }

	private UriParser get_Syntax() { }

	internal bool get_UserDrivenParsing() { }

	public bool get_UserEscaped() { }

	public string get_UserInfo() { }

	private Char[] GetCanonicalPath(Char[] dest, ref int pos, UriFormat formatAs) { }

	private static ParsingError GetCombinedString(Uri baseUri, string relativeStr, bool dontEscape, ref string result) { }

	public string GetComponents(UriComponents components, UriFormat format) { }

	internal string GetComponentsHelper(UriComponents uriComponents, UriFormat uriFormat) { }

	private string GetEscapedParts(UriComponents uriParts) { }

	private static UriFormatException GetException(ParsingError err) { }

	public virtual int GetHashCode() { }

	private void GetHostViaCustomSyntax() { }

	private string GetLocalPath() { }

	protected void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	internal string GetParts(UriComponents uriParts, UriFormat formatAs) { }

	private string GetRelativeSerializationString(UriFormat format) { }

	private string GetUnescapedParts(UriComponents uriParts, UriFormat formatAs) { }

	private string GetUriPartsFromUserString(UriComponents uriParts) { }

	private bool InFact(Flags flags) { }

	private void InitializeUri(ParsingError err, UriKind uriKind, out UriFormatException e) { }

	private static void InitializeUriConfig() { }

	internal static string InternalEscapeString(string rawString) { }

	internal bool InternalIsWellFormedOriginalString() { }

	internal static bool IriParsingStatic(UriParser syntax) { }

	private static bool IsAsciiLetter(char character) { }

	internal static bool IsAsciiLetterOrDigit(char character) { }

	public bool IsBaseOf(Uri uri) { }

	internal bool IsBaseOfHelper(Uri uriLink) { }

	internal static bool IsBidiControlCharacter(char ch) { }

	internal static bool IsGenDelim(char ch) { }

	public static bool IsHexDigit(char character) { }

	private bool IsIntranet(string schemeHost) { }

	private static bool IsLWS(char ch) { }

	public bool IsWellFormedOriginalString() { }

	public static bool IsWellFormedUriString(string uriString, UriKind uriKind) { }

	private bool NotAny(Flags flags) { }

	public static bool op_Equality(Uri uri1, Uri uri2) { }

	public static bool op_Inequality(Uri uri1, Uri uri2) { }

	internal UriFormatException ParseMinimal() { }

	private void ParseRemaining() { }

	private static ParsingError ParseScheme(string uriString, ref Flags flags, ref UriParser syntax) { }

	private static ushort ParseSchemeCheckImplicitFile(Char* uriString, ushort length, ref ParsingError err, ref Flags flags, ref UriParser syntax) { }

	private ParsingError PrivateParseMinimal() { }

	private void PrivateParseMinimalIri(string newHost, ushort idx) { }

	private string ReCreateParts(UriComponents parts, ushort nonCanonical, UriFormat formatAs) { }

	internal static Uri ResolveHelper(Uri baseUri, Uri relativeUri, ref string newUriString, ref bool userEscaped, out UriFormatException e) { }

	private void SetUserDrivenParsing() { }

	private static bool StaticInFact(Flags allFlags, Flags checkFlags) { }

	private static bool StaticIsFile(UriParser syntax) { }

	private static bool StaticNotAny(Flags allFlags, Flags checkFlags) { }

	internal static string StripBidiControlCharacter(Char* strToClean, int start, int length) { }

	private override void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	public virtual string ToString() { }

	public static bool TryCreate(Uri baseUri, string relativeUri, out Uri result) { }

	public static bool TryCreate(string uriString, UriKind uriKind, out Uri result) { }

	public static bool TryCreate(Uri baseUri, Uri relativeUri, out Uri result) { }

	public static string UnescapeDataString(string stringToUnescape) { }

	private static void UnescapeOnly(Char* pch, int start, ref int end, char ch1, char ch2, char ch3) { }

}

