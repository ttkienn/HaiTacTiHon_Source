namespace Unity.Services.Analytics.Internal;

internal class AnalyticsWebRequest : UnityWebRequest, IWebRequest, IDisposable
{

	public override bool IsNetworkError
	{
		 get { } //Length: 22
	}

	internal AnalyticsWebRequest(string url, string method) { }

	public override bool get_IsNetworkError() { }

	private override UploadHandler Unity.Services.Analytics.Internal.IWebRequest.get_uploadHandler() { }

	private override UnityWebRequestAsyncOperation Unity.Services.Analytics.Internal.IWebRequest.SendWebRequest() { }

	private override void Unity.Services.Analytics.Internal.IWebRequest.set_uploadHandler(UploadHandler value) { }

	private override void Unity.Services.Analytics.Internal.IWebRequest.SetRequestHeader(string key, string value) { }

}

