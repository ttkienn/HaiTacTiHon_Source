namespace System.ComponentModel;

public interface ITypedList
{

	public PropertyDescriptorCollection GetItemProperties(PropertyDescriptor[] listAccessors) { }

	public string GetListName(PropertyDescriptor[] listAccessors) { }

}

