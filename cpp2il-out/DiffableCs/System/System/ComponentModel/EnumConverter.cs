namespace System.ComponentModel;

public class EnumConverter : TypeConverter
{
	private StandardValuesCollection values; //Field offset: 0x10
	private Type type; //Field offset: 0x18

	protected override IComparer Comparer
	{
		 get { } //Length: 78
	}

	protected Type EnumType
	{
		 get { } //Length: 5
	}

	protected StandardValuesCollection Values
	{
		 get { } //Length: 5
		 set { } //Length: 13
	}

	public EnumConverter(Type type) { }

	public virtual bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	public virtual bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	public virtual object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	public virtual object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	protected override IComparer get_Comparer() { }

	protected Type get_EnumType() { }

	protected StandardValuesCollection get_Values() { }

	public virtual StandardValuesCollection GetStandardValues(ITypeDescriptorContext context) { }

	public virtual bool GetStandardValuesExclusive(ITypeDescriptorContext context) { }

	public virtual bool GetStandardValuesSupported(ITypeDescriptorContext context) { }

	public virtual bool IsValid(ITypeDescriptorContext context, object value) { }

	protected void set_Values(StandardValuesCollection value) { }

}

