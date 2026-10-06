namespace UnityEngine.Purchasing;

public class StoreSpecificIds : IEnumerable, ISerializationCallbackReceiver
{
	private Dictionary<String, String> m_productIdDictionary; //Field offset: 0x10
	[FormerlySerializedAs("m_keys")]
	[SerializeField]
	private List<String> m_storeNames; //Field offset: 0x18
	[FormerlySerializedAs("m_values")]
	[SerializeField]
	private List<String> m_productIds; //Field offset: 0x20

	public StoreSpecificIds() { }

	public void Add(string id, String[] stores) { }

	public void Add(string id, Object[] stores) { }

	public IEnumerator<KeyValuePair`2<String, String>> GetEnumerator() { }

	public override void OnAfterDeserialize() { }

	public override void OnBeforeSerialize() { }

	internal string SpecificIDForStore(string store, string defaultValue) { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

