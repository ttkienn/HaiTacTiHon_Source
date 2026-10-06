namespace System.ComponentModel;

internal sealed class ReflectEventDescriptor : EventDescriptor
{
	private Type _type; //Field offset: 0x60
	private readonly Type _componentClass; //Field offset: 0x68
	private MethodInfo _addMethod; //Field offset: 0x70
	private MethodInfo _removeMethod; //Field offset: 0x78
	private EventInfo _realEvent; //Field offset: 0x80
	private bool _filledMethods; //Field offset: 0x88

	public ReflectEventDescriptor(Type componentClass, EventInfo eventInfo) { }

	protected virtual void FillAttributes(IList attributes) { }

	private void FillEventInfoAttribute(EventInfo realEventInfo, IList attributes) { }

	private void FillMethods() { }

	private void FillSingleMethodAttribute(MethodInfo realMethodInfo, IList attributes) { }

}

