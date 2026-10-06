namespace System.Data;

internal sealed class DefaultValueTypeConverter : StringConverter
{

	public DefaultValueTypeConverter() { }

	public virtual object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	public virtual object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

}

