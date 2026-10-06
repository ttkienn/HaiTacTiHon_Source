namespace UnityEngine.Purchasing;

[Obsolete("This API is deprecated. Please upgrade to the new APIs introduced in IAP v5. For more information, visit the IAP manual: https://docs.unity.com/ugs/en-us/manual/iap/manual/upgrade-to-iap-v5", False)]
public class IDs : IEnumerable<KeyValuePair`2<String, String>>, IEnumerable
{
	private readonly Dictionary<String, String> m_Dic; //Field offset: 0x10

	public IDs() { }

	public void Add(string id, String[] stores) { }

	public void Add(string id, Object[] stores) { }

	public override IEnumerator<KeyValuePair`2<String, String>> GetEnumerator() { }

	internal string SpecificIDForStore(string store, string defaultValue) { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

