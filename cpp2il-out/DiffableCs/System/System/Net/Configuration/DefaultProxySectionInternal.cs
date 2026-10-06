namespace System.Net.Configuration;

internal sealed class DefaultProxySectionInternal
{
	private static object classSyncObject; //Field offset: 0x0
	private IWebProxy webProxy; //Field offset: 0x10

	internal static object ClassSyncObject
	{
		internal get { } //Length: 149
	}

	internal IWebProxy WebProxy
	{
		internal get { } //Length: 5
	}

	public DefaultProxySectionInternal() { }

	internal static object get_ClassSyncObject() { }

	internal IWebProxy get_WebProxy() { }

	private static IWebProxy GetDefaultProxy_UsingOldMonoCode() { }

	internal static DefaultProxySectionInternal GetSection() { }

	private static IWebProxy GetSystemWebProxy() { }

}

