namespace System;

public class UriTypeConverter : TypeConverter
{

	public UriTypeConverter() { }

	private bool CanConvert(Type type) { }

	public virtual bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	public virtual bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	public virtual object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	public virtual object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

}

