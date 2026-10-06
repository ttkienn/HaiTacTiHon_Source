namespace System.ComponentModel;

public class CharConverter : TypeConverter
{

	public CharConverter() { }

	public virtual bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	public virtual object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	public virtual object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

}

