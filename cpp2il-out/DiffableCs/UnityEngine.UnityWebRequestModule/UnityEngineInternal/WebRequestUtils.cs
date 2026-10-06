namespace UnityEngineInternal;

internal static class WebRequestUtils
{
	private static Regex domainRegex; //Field offset: 0x0

	private static WebRequestUtils() { }

	internal static string MakeInitialUrl(string targetUrl, string localUrl) { }

	internal static string MakeUriString(Uri targetUri, string targetUrl, bool prependProtocol) { }

	[RequiredByNativeCode]
	internal static string RedirectTo(string baseUri, string redirectUri) { }

	private static string URLDecode(string encoded) { }

}

