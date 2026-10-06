namespace System.Data;

internal sealed class ConstraintConverter : ExpandableObjectConverter
{

	public ConstraintConverter() { }

	public virtual bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	public virtual object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

}

