namespace System.ComponentModel;

public abstract class TypeDescriptionProvider
{
	private sealed class EmptyCustomTypeDescriptor : CustomTypeDescriptor
	{

		public EmptyCustomTypeDescriptor() { }

	}

	private readonly TypeDescriptionProvider _parent; //Field offset: 0x10
	private EmptyCustomTypeDescriptor _emptyDescriptor; //Field offset: 0x18

	protected TypeDescriptionProvider() { }

	public override object CreateInstance(IServiceProvider provider, Type objectType, Type[] argTypes, Object[] args) { }

	public override IDictionary GetCache(object instance) { }

	public override ICustomTypeDescriptor GetExtendedTypeDescriptor(object instance) { }

	protected private override IExtenderProvider[] GetExtenderProviders(object instance) { }

	public Type GetReflectionType(Type objectType) { }

	public override Type GetReflectionType(Type objectType, object instance) { }

	public ICustomTypeDescriptor GetTypeDescriptor(Type objectType) { }

	public ICustomTypeDescriptor GetTypeDescriptor(object instance) { }

	public override ICustomTypeDescriptor GetTypeDescriptor(Type objectType, object instance) { }

}

