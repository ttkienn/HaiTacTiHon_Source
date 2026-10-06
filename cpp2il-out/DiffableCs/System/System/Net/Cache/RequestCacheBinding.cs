namespace System.Net.Cache;

internal class RequestCacheBinding
{
	private RequestCache m_RequestCache; //Field offset: 0x10
	private RequestCacheValidator m_CacheValidator; //Field offset: 0x18

	internal RequestCache Cache
	{
		internal get { } //Length: 5
	}

	internal RequestCacheValidator Validator
	{
		internal get { } //Length: 5
	}

	internal RequestCache get_Cache() { }

	internal RequestCacheValidator get_Validator() { }

}

