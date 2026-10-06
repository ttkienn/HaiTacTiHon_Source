namespace Unity.Services.Analytics.Internal;

internal interface IWebRequest : IDisposable
{

	public bool IsNetworkError
	{
		 get { } //Length: 0
	}

	public UploadHandler uploadHandler
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public bool get_IsNetworkError() { }

	public UploadHandler get_uploadHandler() { }

	public UnityWebRequestAsyncOperation SendWebRequest() { }

	public void set_uploadHandler(UploadHandler value) { }

	public void SetRequestHeader(string key, string value) { }

}

