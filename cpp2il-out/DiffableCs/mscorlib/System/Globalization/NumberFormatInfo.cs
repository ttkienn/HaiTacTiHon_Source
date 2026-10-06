namespace System.Globalization;

[ComVisible(True)]
public sealed class NumberFormatInfo : ICloneable, IFormatProvider
{
	private static NumberFormatInfo invariantInfo; //Field offset: 0x0
	private const NumberStyles InvalidNumberStyles = -1024; //Field offset: 0x0
	internal Int32[] numberGroupSizes; //Field offset: 0x10
	internal Int32[] currencyGroupSizes; //Field offset: 0x18
	internal Int32[] percentGroupSizes; //Field offset: 0x20
	internal string positiveSign; //Field offset: 0x28
	internal string negativeSign; //Field offset: 0x30
	internal string numberDecimalSeparator; //Field offset: 0x38
	internal string numberGroupSeparator; //Field offset: 0x40
	internal string currencyGroupSeparator; //Field offset: 0x48
	internal string currencyDecimalSeparator; //Field offset: 0x50
	internal string currencySymbol; //Field offset: 0x58
	internal string ansiCurrencySymbol; //Field offset: 0x60
	internal string nanSymbol; //Field offset: 0x68
	internal string positiveInfinitySymbol; //Field offset: 0x70
	internal string negativeInfinitySymbol; //Field offset: 0x78
	internal string percentDecimalSeparator; //Field offset: 0x80
	internal string percentGroupSeparator; //Field offset: 0x88
	internal string percentSymbol; //Field offset: 0x90
	internal string perMilleSymbol; //Field offset: 0x98
	[OptionalField(VersionAdded = 2)]
	internal String[] nativeDigits; //Field offset: 0xA0
	[OptionalField(VersionAdded = 1)]
	internal int m_dataItem; //Field offset: 0xA8
	internal int numberDecimalDigits; //Field offset: 0xAC
	internal int currencyDecimalDigits; //Field offset: 0xB0
	internal int currencyPositivePattern; //Field offset: 0xB4
	internal int currencyNegativePattern; //Field offset: 0xB8
	internal int numberNegativePattern; //Field offset: 0xBC
	internal int percentPositivePattern; //Field offset: 0xC0
	internal int percentNegativePattern; //Field offset: 0xC4
	internal int percentDecimalDigits; //Field offset: 0xC8
	[OptionalField(VersionAdded = 2)]
	internal int digitSubstitution; //Field offset: 0xCC
	internal bool isReadOnly; //Field offset: 0xD0
	[OptionalField(VersionAdded = 1)]
	internal bool m_useUserOverride; //Field offset: 0xD1
	[OptionalField(VersionAdded = 2)]
	internal bool m_isInvariant; //Field offset: 0xD2
	[OptionalField(VersionAdded = 1)]
	internal bool validForParseAsNumber; //Field offset: 0xD3
	[OptionalField(VersionAdded = 1)]
	internal bool validForParseAsCurrency; //Field offset: 0xD4

	public int CurrencyDecimalDigits
	{
		 get { } //Length: 7
	}

	public string CurrencyDecimalSeparator
	{
		 get { } //Length: 5
	}

	public string CurrencyGroupSeparator
	{
		 get { } //Length: 5
	}

	public Int32[] CurrencyGroupSizes
	{
		 get { } //Length: 119
	}

	public int CurrencyNegativePattern
	{
		 get { } //Length: 7
	}

	public int CurrencyPositivePattern
	{
		 get { } //Length: 7
	}

	public string CurrencySymbol
	{
		 get { } //Length: 5
	}

	public static NumberFormatInfo CurrentInfo
	{
		 get { } //Length: 266
	}

	public static NumberFormatInfo InvariantInfo
	{
		 get { } //Length: 278
	}

	public bool IsReadOnly
	{
		 get { } //Length: 8
	}

	public string NaNSymbol
	{
		 get { } //Length: 5
		 set { } //Length: 233
	}

	public string NegativeInfinitySymbol
	{
		 get { } //Length: 5
	}

	public string NegativeSign
	{
		 get { } //Length: 5
	}

	public int NumberDecimalDigits
	{
		 get { } //Length: 7
	}

	public string NumberDecimalSeparator
	{
		 get { } //Length: 5
	}

	public string NumberGroupSeparator
	{
		 get { } //Length: 5
	}

	public Int32[] NumberGroupSizes
	{
		 get { } //Length: 119
	}

	public int NumberNegativePattern
	{
		 get { } //Length: 7
	}

	public int PercentDecimalDigits
	{
		 get { } //Length: 7
	}

	public string PercentDecimalSeparator
	{
		 get { } //Length: 8
	}

	public string PercentGroupSeparator
	{
		 get { } //Length: 8
	}

	public Int32[] PercentGroupSizes
	{
		 get { } //Length: 119
	}

	public int PercentNegativePattern
	{
		 get { } //Length: 7
	}

	public int PercentPositivePattern
	{
		 get { } //Length: 7
	}

	public string PercentSymbol
	{
		 get { } //Length: 8
	}

	public string PerMilleSymbol
	{
		 get { } //Length: 8
	}

	public string PositiveInfinitySymbol
	{
		 get { } //Length: 5
	}

	public string PositiveSign
	{
		 get { } //Length: 5
	}

	public NumberFormatInfo() { }

	internal NumberFormatInfo(CultureData cultureData) { }

	public override object Clone() { }

	public int get_CurrencyDecimalDigits() { }

	public string get_CurrencyDecimalSeparator() { }

	public string get_CurrencyGroupSeparator() { }

	public Int32[] get_CurrencyGroupSizes() { }

	public int get_CurrencyNegativePattern() { }

	public int get_CurrencyPositivePattern() { }

	public string get_CurrencySymbol() { }

	public static NumberFormatInfo get_CurrentInfo() { }

	public static NumberFormatInfo get_InvariantInfo() { }

	public bool get_IsReadOnly() { }

	public string get_NaNSymbol() { }

	public string get_NegativeInfinitySymbol() { }

	public string get_NegativeSign() { }

	public int get_NumberDecimalDigits() { }

	public string get_NumberDecimalSeparator() { }

	public string get_NumberGroupSeparator() { }

	public Int32[] get_NumberGroupSizes() { }

	public int get_NumberNegativePattern() { }

	public int get_PercentDecimalDigits() { }

	public string get_PercentDecimalSeparator() { }

	public string get_PercentGroupSeparator() { }

	public Int32[] get_PercentGroupSizes() { }

	public int get_PercentNegativePattern() { }

	public int get_PercentPositivePattern() { }

	public string get_PercentSymbol() { }

	public string get_PerMilleSymbol() { }

	public string get_PositiveInfinitySymbol() { }

	public string get_PositiveSign() { }

	public override object GetFormat(Type formatType) { }

	public static NumberFormatInfo GetInstance(IFormatProvider formatProvider) { }

	[OnDeserialized]
	private void OnDeserialized(StreamingContext ctx) { }

	[OnDeserializing]
	private void OnDeserializing(StreamingContext ctx) { }

	[OnSerializing]
	private void OnSerializing(StreamingContext ctx) { }

	public static NumberFormatInfo ReadOnly(NumberFormatInfo nfi) { }

	public void set_NaNSymbol(string value) { }

	internal static void ValidateParseStyleFloatingPoint(NumberStyles style) { }

	internal static void ValidateParseStyleInteger(NumberStyles style) { }

	private void VerifyWritable() { }

}

