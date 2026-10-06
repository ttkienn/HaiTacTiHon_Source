namespace Unity.Services.Analytics.Internal;

internal class WebRequestHelper : IWebRequestHelper
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass2_0
	{
		public Action<Int64> onCompleted; //Field offset: 0x10
		public UnityWebRequestAsyncOperation requestOp; //Field offset: 0x18

		public <>c__DisplayClass2_0() { }

		internal void <SendWebRequest>b__0(AsyncOperation <p0>) { }

	}

	private readonly string k_ClientIdHeaderValue; //Field offset: 0x10

	public WebRequestHelper() { }

	public override IWebRequest CreateWebRequest(string url, string method, Byte[] postBytes) { }

	public override void SendWebRequest(IWebRequest request, Action<Int64> onCompleted) { }

}

