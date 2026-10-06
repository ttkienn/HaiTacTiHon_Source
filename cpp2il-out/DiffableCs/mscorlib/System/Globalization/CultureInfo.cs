namespace System.Globalization;

[ComVisible(True)]
public class CultureInfo : ICloneable, IFormatProvider
{
	private struct Data
	{
		public int ansi; //Field offset: 0x0
		public int ebcdic; //Field offset: 0x4
		public int mac; //Field offset: 0x8
		public int oem; //Field offset: 0xC
		public bool right_to_left; //Field offset: 0x10
		public byte list_sep; //Field offset: 0x11

	}

	private sealed class OnCultureInfoChangedDelegate : MulticastDelegate
	{

		public OnCultureInfoChangedDelegate(object object, IntPtr method) { }

		public override void Invoke(string language) { }

	}

	private static CultureInfo invariant_culture_info; //Field offset: 0x0
	private const string MSG_READONLY = "This instance is read only"; //Field offset: 0x0
	internal const int LOCALE_INVARIANT = 127; //Field offset: 0x0
	private const int CalendarTypeBits = 8; //Field offset: 0x0
	internal const int InvariantCultureId = 127; //Field offset: 0x0
	private static object shared_table_lock; //Field offset: 0x8
	private static CultureInfo default_current_culture; //Field offset: 0x10
	private static CultureInfo s_DefaultThreadCurrentUICulture; //Field offset: 0x18
	private static CultureInfo s_DefaultThreadCurrentCulture; //Field offset: 0x20
	private static Dictionary<Int32, CultureInfo> shared_by_number; //Field offset: 0x28
	private static Dictionary<String, CultureInfo> shared_by_name; //Field offset: 0x30
	private static CultureInfo s_UserPreferredCultureInfoInAppX; //Field offset: 0x38
	internal static readonly bool IsTaiwanSku; //Field offset: 0x40
	private bool m_isReadOnly; //Field offset: 0x10
	private int cultureID; //Field offset: 0x14
	private int parent_lcid; //Field offset: 0x18
	private int datetime_index; //Field offset: 0x1C
	private int number_index; //Field offset: 0x20
	private int default_calendar_type; //Field offset: 0x24
	private bool m_useUserOverride; //Field offset: 0x28
	internal NumberFormatInfo numInfo; //Field offset: 0x30
	internal DateTimeFormatInfo dateTimeInfo; //Field offset: 0x38
	private TextInfo textInfo; //Field offset: 0x40
	internal string m_name; //Field offset: 0x48
	private string englishname; //Field offset: 0x50
	private string nativename; //Field offset: 0x58
	private string iso3lang; //Field offset: 0x60
	private string iso2lang; //Field offset: 0x68
	private string win3lang; //Field offset: 0x70
	private string territory; //Field offset: 0x78
	private String[] native_calendar_names; //Field offset: 0x80
	private CompareInfo compareInfo; //Field offset: 0x88
	private readonly Void* textinfo_data; //Field offset: 0x90
	private int m_dataItem; //Field offset: 0x98
	private Calendar calendar; //Field offset: 0xA0
	private CultureInfo parent_culture; //Field offset: 0xA8
	private bool constructed; //Field offset: 0xB0
	internal Byte[] cached_serialized_form; //Field offset: 0xB8
	internal CultureData m_cultureData; //Field offset: 0xC0
	internal bool m_isInherited; //Field offset: 0xC8

	internal CultureData _cultureData
	{
		internal get { } //Length: 8
	}

	internal bool _isInherited
	{
		internal get { } //Length: 8
	}

	internal string _name
	{
		internal get { } //Length: 5
	}

	public override Calendar Calendar
	{
		 get { } //Length: 152
	}

	internal int CalendarType
	{
		internal get { } //Length: 152
	}

	public override CompareInfo CompareInfo
	{
		 get { } //Length: 319
	}

	public static CultureInfo CurrentCulture
	{
		 get { } //Length: 35
	}

	public static CultureInfo CurrentUICulture
	{
		 get { } //Length: 35
	}

	public override DateTimeFormatInfo DateTimeFormat
	{
		 get { } //Length: 391
		 set { } //Length: 227
	}

	public static CultureInfo DefaultThreadCurrentCulture
	{
		 get { } //Length: 90
	}

	public static CultureInfo DefaultThreadCurrentUICulture
	{
		 get { } //Length: 90
	}

	public override string EnglishName
	{
		 get { } //Length: 53
	}

	public static CultureInfo InvariantCulture
	{
		 get { } //Length: 89
	}

	public override bool IsNeutralCulture
	{
		 get { } //Length: 61
	}

	public override int LCID
	{
		 get { } //Length: 4
	}

	public override string Name
	{
		 get { } //Length: 5
	}

	public override NumberFormatInfo NumberFormat
	{
		 get { } //Length: 165
		 set { } //Length: 227
	}

	public override CultureInfo Parent
	{
		 get { } //Length: 714
	}

	internal string SortName
	{
		internal get { } //Length: 5
	}

	internal string Territory
	{
		internal get { } //Length: 5
	}

	public override TextInfo TextInfo
	{
		 get { } //Length: 331
	}

	public override string TwoLetterISOLanguageName
	{
		 get { } //Length: 53
	}

	internal static CultureInfo UserDefaultCulture
	{
		internal get { } //Length: 64
	}

	internal static CultureInfo UserDefaultUICulture
	{
		internal get { } //Length: 113
	}

	private static CultureInfo() { }

	private CultureInfo() { }

	private CultureInfo(string name, bool useUserOverride, bool read_only) { }

	public CultureInfo(string name, bool useUserOverride) { }

	public CultureInfo(string name) { }

	private CultureInfo(int culture, bool useUserOverride, bool read_only) { }

	public CultureInfo(int culture, bool useUserOverride) { }

	public CultureInfo(int culture) { }

	private void CheckNeutral() { }

	public override object Clone() { }

	private void Construct() { }

	private bool construct_internal_locale_from_lcid(int lcid) { }

	private bool construct_internal_locale_from_name(string name) { }

	internal static CultureInfo ConstructCurrentCulture() { }

	internal static CultureInfo ConstructCurrentUICulture() { }

	private void ConstructInvariant(bool read_only) { }

	private bool ConstructLocaleFromName(string name) { }

	private static Calendar CreateCalendar(int calendarType) { }

	internal static CultureInfo CreateCulture(string name, bool reference) { }

	private static Exception CreateNotFoundException(string name) { }

	public static CultureInfo CreateSpecificCulture(string name) { }

	private static CultureInfo CreateSpecificCultureFromNeutral(string name) { }

	private TextInfo CreateTextInfo(bool readOnly) { }

	public virtual bool Equals(object value) { }

	internal CultureData get__cultureData() { }

	internal bool get__isInherited() { }

	internal string get__name() { }

	public override Calendar get_Calendar() { }

	internal int get_CalendarType() { }

	public override CompareInfo get_CompareInfo() { }

	private static string get_current_locale_name() { }

	public static CultureInfo get_CurrentCulture() { }

	public static CultureInfo get_CurrentUICulture() { }

	public override DateTimeFormatInfo get_DateTimeFormat() { }

	public static CultureInfo get_DefaultThreadCurrentCulture() { }

	public static CultureInfo get_DefaultThreadCurrentUICulture() { }

	public override string get_EnglishName() { }

	public static CultureInfo get_InvariantCulture() { }

	public override bool get_IsNeutralCulture() { }

	public override int get_LCID() { }

	public override string get_Name() { }

	public override NumberFormatInfo get_NumberFormat() { }

	public override CultureInfo get_Parent() { }

	internal string get_SortName() { }

	internal string get_Territory() { }

	public override TextInfo get_TextInfo() { }

	public override string get_TwoLetterISOLanguageName() { }

	internal static CultureInfo get_UserDefaultCulture() { }

	internal static CultureInfo get_UserDefaultUICulture() { }

	public static CultureInfo GetCultureInfo(int culture) { }

	public static CultureInfo GetCultureInfo(string name) { }

	internal static CultureInfo GetCultureInfoForUserPreferredLanguageInAppX() { }

	public static CultureInfo[] GetCultures(CultureTypes types) { }

	public override object GetFormat(Type formatType) { }

	public virtual int GetHashCode() { }

	private Data GetTextInfoData() { }

	private static void InitializeUserPreferredCultureInfoInAppX(OnCultureInfoChangedDelegate onCultureInfoChangedInAppX) { }

	private static void insert_into_shared_tables(CultureInfo c) { }

	private static CultureInfo[] internal_get_cultures(bool neutral, bool specific, bool installed) { }

	[MonoPInvokeCallback(typeof(OnCultureInfoChangedDelegate))]
	private static void OnCultureInfoChangedInAppX(string language) { }

	public override void set_DateTimeFormat(DateTimeFormatInfo value) { }

	public override void set_NumberFormat(NumberFormatInfo value) { }

	public virtual string ToString() { }

}

