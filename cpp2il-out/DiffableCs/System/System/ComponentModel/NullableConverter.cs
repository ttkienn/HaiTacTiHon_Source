namespace System.ComponentModel;

public class NullableConverter : TypeConverter
{
	[CompilerGenerated]
	private readonly Type <NullableType>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly Type <UnderlyingType>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private readonly TypeConverter <UnderlyingTypeConverter>k__BackingField; //Field offset: 0x20

	public Type NullableType
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public Type UnderlyingType
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public TypeConverter UnderlyingTypeConverter
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public NullableConverter(Type type) { }

	public virtual bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	public virtual bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	public virtual object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	public virtual object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	public virtual object CreateInstance(ITypeDescriptorContext context, IDictionary propertyValues) { }

	[CompilerGenerated]
	public Type get_NullableType() { }

	[CompilerGenerated]
	public Type get_UnderlyingType() { }

	[CompilerGenerated]
	public TypeConverter get_UnderlyingTypeConverter() { }

	public virtual bool GetCreateInstanceSupported(ITypeDescriptorContext context) { }

	public virtual PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes) { }

	public virtual bool GetPropertiesSupported(ITypeDescriptorContext context) { }

	public virtual StandardValuesCollection GetStandardValues(ITypeDescriptorContext context) { }

	public virtual bool GetStandardValuesExclusive(ITypeDescriptorContext context) { }

	public virtual bool GetStandardValuesSupported(ITypeDescriptorContext context) { }

	public virtual bool IsValid(ITypeDescriptorContext context, object value) { }

}

