namespace System.ComponentModel;

public class ReferenceConverter : TypeConverter
{
	private class ReferenceComparer : IComparer
	{
		private ReferenceConverter _converter; //Field offset: 0x10

		public ReferenceComparer(ReferenceConverter converter) { }

		public override int Compare(object item1, object item2) { }

	}

	private static readonly string s_none; //Field offset: 0x0
	private Type _type; //Field offset: 0x10

	private static ReferenceConverter() { }

	public ReferenceConverter(Type type) { }

	public virtual bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	public virtual object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	public virtual object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	public virtual StandardValuesCollection GetStandardValues(ITypeDescriptorContext context) { }

	public virtual bool GetStandardValuesExclusive(ITypeDescriptorContext context) { }

	public virtual bool GetStandardValuesSupported(ITypeDescriptorContext context) { }

	protected override bool IsValueAllowed(ITypeDescriptorContext context, object value) { }

}

