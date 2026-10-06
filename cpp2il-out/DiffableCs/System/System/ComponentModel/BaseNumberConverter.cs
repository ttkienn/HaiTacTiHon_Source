namespace System.ComponentModel;

public abstract class BaseNumberConverter : TypeConverter
{

	internal override bool AllowHex
	{
		internal get { } //Length: 3
	}

	internal abstract Type TargetType
	{
		internal get { } //Length: 0
	}

	internal BaseNumberConverter() { }

	public virtual bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	public virtual bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	public virtual object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	public virtual object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	internal abstract object FromString(string value, int radix) { }

	internal abstract object FromString(string value, NumberFormatInfo formatInfo) { }

	internal override bool get_AllowHex() { }

	internal abstract Type get_TargetType() { }

	internal abstract string ToString(object value, NumberFormatInfo formatInfo) { }

}

