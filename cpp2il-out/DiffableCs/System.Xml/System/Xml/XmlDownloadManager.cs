namespace System.Xml;

internal class XmlDownloadManager
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass4_0
	{
		public Uri uri; //Field offset: 0x10

		public <>c__DisplayClass4_0() { }

		internal Stream <GetStreamAsync>b__0() { }

	}

	[CompilerGenerated]
	private struct <GetNonFileStreamAsync>d__5 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Stream> <>t__builder; //Field offset: 0x8
		public Uri uri; //Field offset: 0x20
		public ICredentials credentials; //Field offset: 0x28
		public IWebProxy proxy; //Field offset: 0x30
		public RequestCachePolicy cachePolicy; //Field offset: 0x38
		public XmlDownloadManager <>4__this; //Field offset: 0x40
		private WebRequest <req>5__2; //Field offset: 0x48
		private ConfiguredTaskAwaiter<WebResponse> <>u__1; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private Hashtable connections; //Field offset: 0x10

	public XmlDownloadManager() { }

	private Stream GetNonFileStream(Uri uri, ICredentials credentials, IWebProxy proxy, RequestCachePolicy cachePolicy) { }

	[AsyncStateMachine(typeof(<GetNonFileStreamAsync>d__5))]
	private Task<Stream> GetNonFileStreamAsync(Uri uri, ICredentials credentials, IWebProxy proxy, RequestCachePolicy cachePolicy) { }

	internal Stream GetStream(Uri uri, ICredentials credentials, IWebProxy proxy, RequestCachePolicy cachePolicy) { }

	internal Task<Stream> GetStreamAsync(Uri uri, ICredentials credentials, IWebProxy proxy, RequestCachePolicy cachePolicy) { }

	internal void Remove(string host) { }

}

