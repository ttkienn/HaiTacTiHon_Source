namespace Unity.Services.Analytics.Internal;

internal interface IWebRequestHelper
{

	public IWebRequest CreateWebRequest(string url, string method, Byte[] postBytes) { }

	public void SendWebRequest(IWebRequest request, Action<Int64> onCompleted) { }

}

