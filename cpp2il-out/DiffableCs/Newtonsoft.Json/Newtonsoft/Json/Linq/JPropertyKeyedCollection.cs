namespace Newtonsoft.Json.Linq;

[DefaultMember("Item")]
[Nullable(new IL2CPP_TYPE_U1[] {0, 1}])]
[NullableContext(1)]
internal class JPropertyKeyedCollection : Collection<JToken>
{
	private static readonly IEqualityComparer<String> Comparer; //Field offset: 0x0
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1, 1}])]
	private Dictionary<String, JToken> _dictionary; //Field offset: 0x18

	public JToken Item
	{
		 get { } //Length: 229
	}

	public ICollection<String> Keys
	{
		 get { } //Length: 78
	}

	public ICollection<JToken> Values
	{
		 get { } //Length: 78
	}

	private static JPropertyKeyedCollection() { }

	public JPropertyKeyedCollection() { }

	private void AddKey(string key, JToken item) { }

	protected void ChangeItemKey(JToken item, string newKey) { }

	protected virtual void ClearItems() { }

	public bool Compare(JPropertyKeyedCollection other) { }

	public bool Contains(string key) { }

	private bool ContainsItem(JToken item) { }

	private void EnsureDictionary() { }

	public JToken get_Item(string key) { }

	public ICollection<String> get_Keys() { }

	public ICollection<JToken> get_Values() { }

	private string GetKeyForItem(JToken item) { }

	public int IndexOfReference(JToken t) { }

	protected virtual void InsertItem(int index, JToken item) { }

	public bool Remove(string key) { }

	protected virtual void RemoveItem(int index) { }

	private void RemoveKey(string key) { }

	protected virtual void SetItem(int index, JToken item) { }

	public bool TryGetValue(string key, out JToken value) { }

}

