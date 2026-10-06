namespace System.Data;

internal sealed class RelationshipConverter : ExpandableObjectConverter
{

	public RelationshipConverter() { }

	public virtual bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	public virtual object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

}

