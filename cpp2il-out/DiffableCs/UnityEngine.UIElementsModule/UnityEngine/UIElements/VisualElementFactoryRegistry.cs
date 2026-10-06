namespace UnityEngine.UIElements;

internal class VisualElementFactoryRegistry
{
	private static Dictionary<String, List`1<IUxmlFactory>> s_Factories; //Field offset: 0x0
	private static Dictionary<String, List`1<IUxmlFactory>> s_MovedTypesFactories; //Field offset: 0x8

	internal static Dictionary<String, List`1<IUxmlFactory>> factories
	{
		internal get { } //Length: 286
	}

	internal static Dictionary<String, List`1<IUxmlFactory>> get_factories() { }

	private static string GetMovedUIControlTypeName(Type type, MovedFromAttribute attr) { }

	private static void RegisterEngineFactories() { }

	protected static void RegisterFactory(IUxmlFactory factory) { }

	internal static void RegisterUserFactories() { }

	internal static bool TryGetValue(string fullTypeName, out List<IUxmlFactory>& factoryList) { }

}

