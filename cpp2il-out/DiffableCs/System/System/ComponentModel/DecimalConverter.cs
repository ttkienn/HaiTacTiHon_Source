namespace System.ComponentModel;

public class DecimalConverter : BaseNumberConverter
{

	internal virtual bool AllowHex
	{
		internal get { } //Length: 3
	}

	internal virtual Type TargetType
	{
		internal get { } //Length: 89
	}

	public DecimalConverter() { }

	public virtual bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	public virtual object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	internal virtual object FromString(string value, int radix) { }

	internal virtual object FromString(string value, NumberFormatInfo formatInfo) { }

	internal virtual bool get_AllowHex() { }

	internal virtual Type get_TargetType() { }

	internal virtual string ToString(object value, NumberFormatInfo formatInfo) { }

}

