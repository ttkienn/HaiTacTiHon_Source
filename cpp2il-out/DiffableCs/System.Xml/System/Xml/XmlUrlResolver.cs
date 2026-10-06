namespace System.Xml;

public class XmlUrlResolver : XmlResolver
{
	[CompilerGenerated]
	private struct <GetEntityAsync>d__15 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Object> <>t__builder; //Field offset: 0x8
		public Type ofObjectToReturn; //Field offset: 0x20
		public Uri absoluteUri; //Field offset: 0x28
		public XmlUrlResolver <>4__this; //Field offset: 0x30
		private ConfiguredTaskAwaiter<Stream> <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private static object s_DownloadManager; //Field offset: 0x0
	private ICredentials _credentials; //Field offset: 0x10
	private IWebProxy _proxy; //Field offset: 0x18
	private RequestCachePolicy _cachePolicy; //Field offset: 0x20

	private static XmlDownloadManager DownloadManager
	{
		private get { } //Length: 216
	}

	public XmlUrlResolver() { }

	private static XmlDownloadManager get_DownloadManager() { }

	public virtual object GetEntity(Uri absoluteUri, string role, Type ofObjectToReturn) { }

	[AsyncStateMachine(typeof(<GetEntityAsync>d__15))]
	public virtual Task<Object> GetEntityAsync(Uri absoluteUri, string role, Type ofObjectToReturn) { }

	public virtual Uri ResolveUri(Uri baseUri, string relativeUri) { }

}

