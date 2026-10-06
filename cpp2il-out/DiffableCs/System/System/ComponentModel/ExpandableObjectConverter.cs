namespace System.ComponentModel;

public class ExpandableObjectConverter : TypeConverter
{

	public ExpandableObjectConverter() { }

	public virtual PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes) { }

	public virtual bool GetPropertiesSupported(ITypeDescriptorContext context) { }

}

