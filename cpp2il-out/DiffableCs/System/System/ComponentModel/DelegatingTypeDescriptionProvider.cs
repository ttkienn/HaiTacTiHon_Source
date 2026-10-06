namespace System.ComponentModel;

internal sealed class DelegatingTypeDescriptionProvider : TypeDescriptionProvider
{
	private readonly Type _type; //Field offset: 0x20

	internal TypeDescriptionProvider Provider
	{
		internal get { } //Length: 77
	}

	internal DelegatingTypeDescriptionProvider(Type type) { }

	public virtual object CreateInstance(IServiceProvider provider, Type objectType, Type[] argTypes, Object[] args) { }

	internal TypeDescriptionProvider get_Provider() { }

	public virtual IDictionary GetCache(object instance) { }

	public virtual ICustomTypeDescriptor GetExtendedTypeDescriptor(object instance) { }

	protected private virtual IExtenderProvider[] GetExtenderProviders(object instance) { }

	public virtual Type GetReflectionType(Type objectType, object instance) { }

	public virtual ICustomTypeDescriptor GetTypeDescriptor(Type objectType, object instance) { }

}

