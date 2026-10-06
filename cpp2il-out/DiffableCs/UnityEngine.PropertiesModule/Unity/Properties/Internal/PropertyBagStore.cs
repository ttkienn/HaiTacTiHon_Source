namespace Unity.Properties.Internal;

internal static class PropertyBagStore
{
	public struct TypedStore
	{
		public static IPropertyBag<TContainer> PropertyBag; //Field offset: 0x0

	}

	private static readonly ConcurrentDictionary<Type, IPropertyBag> s_PropertyBags; //Field offset: 0x0
	private static readonly List<Type> s_RegisteredTypes; //Field offset: 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action<Type, IPropertyBag> NewTypeRegistered; //Field offset: 0x10
	private static ReflectedPropertyBagProvider s_PropertyBagProvider; //Field offset: 0x18

	private static PropertyBagStore() { }

	internal static void AddPropertyBag(IPropertyBag<TContainer> propertyBag) { }

	internal static IPropertyBag<TContainer> GetPropertyBag() { }

	internal static IPropertyBag GetPropertyBag(Type type) { }

}

