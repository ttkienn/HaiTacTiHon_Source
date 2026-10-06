namespace System.ComponentModel;

public interface ICustomTypeDescriptor
{

	public AttributeCollection GetAttributes() { }

	public string GetClassName() { }

	public string GetComponentName() { }

	public TypeConverter GetConverter() { }

	public EventDescriptor GetDefaultEvent() { }

	public PropertyDescriptor GetDefaultProperty() { }

	public object GetEditor(Type editorBaseType) { }

	public EventDescriptorCollection GetEvents() { }

	public EventDescriptorCollection GetEvents(Attribute[] attributes) { }

	public PropertyDescriptorCollection GetProperties() { }

	public PropertyDescriptorCollection GetProperties(Attribute[] attributes) { }

	public object GetPropertyOwner(PropertyDescriptor pd) { }

}

