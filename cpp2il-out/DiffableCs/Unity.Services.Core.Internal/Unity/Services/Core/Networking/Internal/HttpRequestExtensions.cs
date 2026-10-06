namespace Unity.Services.Core.Networking.Internal;

[Extension]
internal static class HttpRequestExtensions
{

	[Extension]
	public static HttpRequest AsConnect(HttpRequest self) { }

	[Extension]
	public static HttpRequest AsDelete(HttpRequest self) { }

	[Extension]
	public static HttpRequest AsGet(HttpRequest self) { }

	[Extension]
	public static HttpRequest AsHead(HttpRequest self) { }

	[Extension]
	public static HttpRequest AsOptions(HttpRequest self) { }

	[Extension]
	public static HttpRequest AsPatch(HttpRequest self) { }

	[Extension]
	public static HttpRequest AsPost(HttpRequest self) { }

	[Extension]
	public static HttpRequest AsPut(HttpRequest self) { }

	[Extension]
	public static HttpRequest AsTrace(HttpRequest self) { }

}

