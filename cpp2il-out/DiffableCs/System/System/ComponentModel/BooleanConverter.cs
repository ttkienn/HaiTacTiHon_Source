namespace System.ComponentModel;

public class BooleanConverter : TypeConverter
{
	private static StandardValuesCollection s_values; //Field offset: 0x0

	public BooleanConverter() { }

	public virtual bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	public virtual object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	public virtual StandardValuesCollection GetStandardValues(ITypeDescriptorContext context) { }

	public virtual bool GetStandardValuesExclusive(ITypeDescriptorContext context) { }

	public virtual bool GetStandardValuesSupported(ITypeDescriptorContext context) { }

}

