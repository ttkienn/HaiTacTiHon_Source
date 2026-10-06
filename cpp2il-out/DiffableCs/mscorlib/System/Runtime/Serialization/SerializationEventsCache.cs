namespace System.Runtime.Serialization;

internal static class SerializationEventsCache
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Type, SerializationEvents> <>9__1_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal SerializationEvents <GetSerializationEventsForType>b__1_0(Type type) { }

	}

	private static readonly ConcurrentDictionary<Type, SerializationEvents> s_cache; //Field offset: 0x0

	private static SerializationEventsCache() { }

	internal static SerializationEvents GetSerializationEventsForType(Type t) { }

}

