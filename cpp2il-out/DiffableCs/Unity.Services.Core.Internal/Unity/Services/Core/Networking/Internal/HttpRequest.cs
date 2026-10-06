namespace Unity.Services.Core.Networking.Internal;

internal class HttpRequest
{
	public string Method; //Field offset: 0x10
	public string Url; //Field offset: 0x18
	public Dictionary<String, String> Headers; //Field offset: 0x20
	public Byte[] Body; //Field offset: 0x28
	public HttpOptions Options; //Field offset: 0x30

	public HttpRequest() { }

	public HttpRequest(string method, string url, Dictionary<String, String> headers, Byte[] body) { }

	public HttpRequest SetBody(Byte[] body) { }

	public HttpRequest SetHeader(string key, string value) { }

	public HttpRequest SetHeaders(Dictionary<String, String> headers) { }

	public HttpRequest SetMethod(string method) { }

	public HttpRequest SetOptions(HttpOptions options) { }

	public HttpRequest SetRedirectLimit(int redirectLimit) { }

	public HttpRequest SetTimeOutInSeconds(int timeout) { }

	public HttpRequest SetUrl(string url) { }

}

