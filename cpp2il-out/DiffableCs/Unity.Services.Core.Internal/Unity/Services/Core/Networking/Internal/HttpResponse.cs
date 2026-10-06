namespace Unity.Services.Core.Networking.Internal;

internal class HttpResponse
{
	public ReadOnlyHttpRequest Request; //Field offset: 0x10
	public Dictionary<String, String> Headers; //Field offset: 0x18
	public Byte[] Data; //Field offset: 0x20
	public long StatusCode; //Field offset: 0x28
	public string ErrorMessage; //Field offset: 0x30
	public bool IsHttpError; //Field offset: 0x38
	public bool IsNetworkError; //Field offset: 0x39

	public HttpResponse() { }

	public HttpResponse SetData(Byte[] data) { }

	public HttpResponse SetErrorMessage(string errorMessage) { }

	public HttpResponse SetHeader(string key, string value) { }

	public HttpResponse SetHeaders(Dictionary<String, String> headers) { }

	public HttpResponse SetIsHttpError(bool isHttpError) { }

	public HttpResponse SetIsNetworkError(bool isNetworkError) { }

	public HttpResponse SetRequest(HttpRequest request) { }

	public HttpResponse SetRequest(ReadOnlyHttpRequest request) { }

	public HttpResponse SetStatusCode(long statusCode) { }

}

