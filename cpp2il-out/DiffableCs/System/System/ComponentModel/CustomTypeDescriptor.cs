namespace System.ComponentModel;

public abstract class CustomTypeDescriptor : ICustomTypeDescriptor
{
	private readonly ICustomTypeDescriptor _parent; //Field offset: 0x10

	protected CustomTypeDescriptor() { }

	public override AttributeCollection GetAttributes() { }

	public override string GetClassName() { }

	public override string GetComponentName() { }

	public override TypeConverter GetConverter() { }

	public override EventDescriptor GetDefaultEvent() { }

	public override PropertyDescriptor GetDefaultProperty() { }

	public override object GetEditor(Type editorBaseType) { }

	public override EventDescriptorCollection GetEvents() { }

	public override EventDescriptorCollection GetEvents(Attribute[] attributes) { }

	public override PropertyDescriptorCollection GetProperties() { }

	public override PropertyDescriptorCollection GetProperties(Attribute[] attributes) { }

	public override object GetPropertyOwner(PropertyDescriptor pd) { }

}

