namespace Unity.Properties;

public class KeyValuePairPropertyBag : PropertyBag<KeyValuePair`2<TKey, TValue>>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c<TKey, TValue> <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal TKey <.cctor>b__7_0(ref KeyValuePair<TKey, TValue>& container) { }

		internal TValue <.cctor>b__7_1(ref KeyValuePair<TKey, TValue>& container) { }

	}

	private static readonly DelegateProperty<KeyValuePair`2<TKey, TValue>, TKey> s_KeyProperty; //Field offset: 0x0
	private static readonly DelegateProperty<KeyValuePair`2<TKey, TValue>, TValue> s_ValueProperty; //Field offset: 0x0

	private static KeyValuePairPropertyBag`2() { }

	public KeyValuePairPropertyBag`2() { }

}

