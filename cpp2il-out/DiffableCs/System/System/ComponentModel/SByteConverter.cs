namespace System.ComponentModel;

public class SByteConverter : BaseNumberConverter
{

	internal virtual Type TargetType
	{
		internal get { } //Length: 89
	}

	public SByteConverter() { }

	internal virtual object FromString(string value, int radix) { }

	internal virtual object FromString(string value, NumberFormatInfo formatInfo) { }

	internal virtual Type get_TargetType() { }

	internal virtual string ToString(object value, NumberFormatInfo formatInfo) { }

}

