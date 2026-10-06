namespace System.ComponentModel;

public abstract class TypeListConverter : TypeConverter
{
	private readonly Type[] _types; //Field offset: 0x10
	private StandardValuesCollection _values; //Field offset: 0x18

	protected TypeListConverter(Type[] types) { }

	public virtual bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	public virtual bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	public virtual object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	public virtual object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	public virtual StandardValuesCollection GetStandardValues(ITypeDescriptorContext context) { }

	public virtual bool GetStandardValuesExclusive(ITypeDescriptorContext context) { }

	public virtual bool GetStandardValuesSupported(ITypeDescriptorContext context) { }

}

