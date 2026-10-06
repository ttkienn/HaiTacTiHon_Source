namespace Unity.Properties;

public class DictionaryPropertyBag : KeyValueCollectionPropertyBag<Dictionary`2<TKey, TValue>, TKey, TValue>
{

	protected virtual InstantiationKind InstantiationKind
	{
		 get { } //Length: 6
	}

	public DictionaryPropertyBag`2() { }

	protected virtual InstantiationKind get_InstantiationKind() { }

	protected virtual Dictionary<TKey, TValue> Instantiate() { }

}

