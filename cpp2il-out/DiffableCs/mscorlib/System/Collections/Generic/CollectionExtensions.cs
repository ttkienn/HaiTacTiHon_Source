namespace System.Collections.Generic;

[Extension]
public static class CollectionExtensions
{

	[Extension]
	public static TValue GetValueOrDefault(IReadOnlyDictionary<TKey, TValue> dictionary, TKey key) { }

	[Extension]
	public static TValue GetValueOrDefault(IReadOnlyDictionary<TKey, TValue> dictionary, TKey key, TValue defaultValue) { }

}

