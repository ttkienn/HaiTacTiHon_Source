namespace System.Runtime.Serialization.Formatters.Binary;

internal sealed class NameCache
{
	private static ConcurrentDictionary<String, Object> ht; //Field offset: 0x0
	private string name; //Field offset: 0x10

	private static NameCache() { }

	public NameCache() { }

	internal object GetCachedValue(string name) { }

	internal void SetCachedValue(object value) { }

}

