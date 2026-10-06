namespace System.ComponentModel;

public class StringConverter : TypeConverter
{

	public StringConverter() { }

	public virtual bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	public virtual object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

}

