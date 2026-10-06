namespace UnityEngine.UIElements;

internal class UxmlObjectFactoryRegistry
{
	private static Dictionary<String, List`1<IBaseUxmlObjectFactory>> s_Factories; //Field offset: 0x0

	internal static Dictionary<String, List`1<IBaseUxmlObjectFactory>> factories
	{
		internal get { } //Length: 191
	}

	internal static Dictionary<String, List`1<IBaseUxmlObjectFactory>> get_factories() { }

	private static void RegisterEngineFactories() { }

	protected static void RegisterFactory(IBaseUxmlObjectFactory factory) { }

	private static void RegisterUserFactories() { }

	internal static bool TryGetFactories(string fullTypeName, out List<IBaseUxmlObjectFactory>& factoryList) { }

}

