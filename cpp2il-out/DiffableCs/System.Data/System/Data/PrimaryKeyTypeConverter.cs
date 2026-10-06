namespace System.Data;

internal sealed class PrimaryKeyTypeConverter : ReferenceConverter
{

	public PrimaryKeyTypeConverter() { }

	public virtual bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	public virtual object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	public virtual bool GetPropertiesSupported(ITypeDescriptorContext context) { }

}

