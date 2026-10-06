namespace System.ComponentModel;

public class ComponentConverter : ReferenceConverter
{

	public ComponentConverter(Type type) { }

	public virtual PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes) { }

	public virtual bool GetPropertiesSupported(ITypeDescriptorContext context) { }

}

