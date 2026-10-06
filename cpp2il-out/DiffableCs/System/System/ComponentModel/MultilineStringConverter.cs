namespace System.ComponentModel;

public class MultilineStringConverter : TypeConverter
{

	public MultilineStringConverter() { }

	public virtual object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	public virtual PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes) { }

	public virtual bool GetPropertiesSupported(ITypeDescriptorContext context) { }

}

