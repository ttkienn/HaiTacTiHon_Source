namespace System.ComponentModel;

public class CultureInfoConverter : TypeConverter
{
	private class CultureComparer : IComparer
	{
		private CultureInfoConverter _converter; //Field offset: 0x10

		public CultureComparer(CultureInfoConverter cultureConverter) { }

		public override int Compare(object item1, object item2) { }

	}

	private static class CultureInfoMapper
	{
		private static readonly Dictionary<String, String> s_cultureInfoNameMap; //Field offset: 0x0

		private static CultureInfoMapper() { }

		private static Dictionary<String, String> CreateMap() { }

		public static string GetCultureInfoName(string cultureInfoDisplayName) { }

	}

	private const string DefaultInvariantCultureString = "(Default)"; //Field offset: 0x0
	private StandardValuesCollection _values; //Field offset: 0x10

	private string DefaultCultureString
	{
		private get { } //Length: 44
	}

	public CultureInfoConverter() { }

	public virtual bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	public virtual bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	public virtual object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	public virtual object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	private string get_DefaultCultureString() { }

	protected override string GetCultureName(CultureInfo culture) { }

	public virtual StandardValuesCollection GetStandardValues(ITypeDescriptorContext context) { }

	public virtual bool GetStandardValuesExclusive(ITypeDescriptorContext context) { }

	public virtual bool GetStandardValuesSupported(ITypeDescriptorContext context) { }

}

