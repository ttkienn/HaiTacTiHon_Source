namespace System.Net;

public class CookieContainer
{
	private static readonly HeaderVariantInfo[] HeaderInfo; //Field offset: 0x0
	private Hashtable m_domainTable; //Field offset: 0x10
	private int m_maxCookieSize; //Field offset: 0x18
	private int m_maxCookies; //Field offset: 0x1C
	private int m_maxCookiesPerDomain; //Field offset: 0x20
	private int m_count; //Field offset: 0x24
	private string m_fqdnMyDomain; //Field offset: 0x28

	private static CookieContainer() { }

	public CookieContainer() { }

	internal void Add(Cookie cookie, bool throwOnError) { }

	private void AddRemoveDomain(string key, PathList value) { }

	private bool AgeCookies(string domain) { }

	private void BuildCookieCollectionFromDomainMatches(Uri uri, bool isSecure, int port, CookieCollection cookies, List<String> domainAttribute, bool matchOnlyPlainCookie) { }

	internal CookieCollection CookieCutter(Uri uri, string headerName, string setCookieHeader, bool isThrow) { }

	private int ExpireCollection(CookieCollection cc) { }

	public string GetCookieHeader(Uri uri) { }

	internal string GetCookieHeader(Uri uri, out string optCookie2) { }

	internal CookieCollection InternalGetCookies(Uri uri) { }

	internal bool IsLocalDomain(string host) { }

	private void MergeUpdateCollections(CookieCollection destination, CookieCollection source, int port, bool isSecure, bool isPlainOnly) { }

}

