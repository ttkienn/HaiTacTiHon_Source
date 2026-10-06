namespace Unity.Services.Core.Internal;

[Extension]
internal static class DictionaryExtensions
{

	[Extension]
	public static TDictionary MergeAllowOverride(TDictionary self, IDictionary<TKey, TValue> dictionary) { }

	[Extension]
	public static TDictionary MergeNoOverride(TDictionary self, IDictionary<TKey, TValue> dictionary) { }

	[Extension]
	public static bool ValueEquals(IDictionary<TKey, TValue> x, IDictionary<TKey, TValue> y) { }

	[Extension]
	public static bool ValueEquals(IDictionary<TKey, TValue> x, IDictionary<TKey, TValue> y, TComparer valueComparer) { }

}

