namespace System.Globalization;

[ComVisible(True)]
public class RegionInfo
{
	private static RegionInfo currentRegion; //Field offset: 0x0
	private int regionId; //Field offset: 0x10
	private string iso2Name; //Field offset: 0x18
	private string iso3Name; //Field offset: 0x20
	private string win3Name; //Field offset: 0x28
	private string englishName; //Field offset: 0x30
	private string nativeName; //Field offset: 0x38
	private string currencySymbol; //Field offset: 0x40
	private string isoCurrencySymbol; //Field offset: 0x48
	private string currencyEnglishName; //Field offset: 0x50
	private string currencyNativeName; //Field offset: 0x58

	[ComVisible(False)]
	public override string CurrencyEnglishName
	{
		 get { } //Length: 5
	}

	[ComVisible(False)]
	public override string CurrencyNativeName
	{
		 get { } //Length: 5
	}

	public override string CurrencySymbol
	{
		 get { } //Length: 5
	}

	public static RegionInfo CurrentRegion
	{
		 get { } //Length: 204
	}

	[MonoTODO("DisplayName currently only returns the EnglishName")]
	public override string DisplayName
	{
		 get { } //Length: 5
	}

	public override string EnglishName
	{
		 get { } //Length: 5
	}

	[ComVisible(False)]
	public override int GeoId
	{
		 get { } //Length: 191
	}

	public override bool IsMetric
	{
		 get { } //Length: 112
	}

	public override string ISOCurrencySymbol
	{
		 get { } //Length: 5
	}

	public override string Name
	{
		 get { } //Length: 5
	}

	[ComVisible(False)]
	public override string NativeName
	{
		 get { } //Length: 5
	}

	public override string ThreeLetterISORegionName
	{
		 get { } //Length: 5
	}

	public override string ThreeLetterWindowsRegionName
	{
		 get { } //Length: 5
	}

	public override string TwoLetterISORegionName
	{
		 get { } //Length: 5
	}

	public RegionInfo(int culture) { }

	public RegionInfo(string name) { }

	private RegionInfo(CultureInfo ci) { }

	internal static void ClearCachedData() { }

	private bool construct_internal_region_from_name(string name) { }

	public virtual bool Equals(object value) { }

	public override string get_CurrencyEnglishName() { }

	public override string get_CurrencyNativeName() { }

	public override string get_CurrencySymbol() { }

	public static RegionInfo get_CurrentRegion() { }

	public override string get_DisplayName() { }

	public override string get_EnglishName() { }

	public override int get_GeoId() { }

	public override bool get_IsMetric() { }

	public override string get_ISOCurrencySymbol() { }

	public override string get_Name() { }

	public override string get_NativeName() { }

	public override string get_ThreeLetterISORegionName() { }

	public override string get_ThreeLetterWindowsRegionName() { }

	public override string get_TwoLetterISORegionName() { }

	private bool GetByTerritory(CultureInfo ci) { }

	public virtual int GetHashCode() { }

	public virtual string ToString() { }

}

