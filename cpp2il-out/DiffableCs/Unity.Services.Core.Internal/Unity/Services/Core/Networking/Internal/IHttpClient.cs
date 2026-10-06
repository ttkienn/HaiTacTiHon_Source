namespace Unity.Services.Core.Networking.Internal;

internal interface IHttpClient : IServiceComponent
{

	public HttpRequest CreateRequestForService(string serviceId, string resourcePath) { }

	public string GetBaseUrlFor(string serviceId) { }

	public HttpOptions GetDefaultOptionsFor(string serviceId) { }

	public IAsyncOperation<ReadOnlyHttpResponse> Send(HttpRequest request) { }

}

