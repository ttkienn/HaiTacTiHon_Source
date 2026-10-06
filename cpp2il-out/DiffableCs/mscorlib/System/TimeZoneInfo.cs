namespace System;

[TypeForwardedFrom("System.Core, Version=2.0.5.0, Culture=Neutral, PublicKeyToken=7cec85d7bea7798e")]
public sealed class TimeZoneInfo : IEquatable<TimeZoneInfo>, ISerializable, IDeserializationCallback
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Comparison<TimeZoneInfo> <>9__49_0; //Field offset: 0x8
		public static Comparison<TimeZoneInfo> <>9__110_0; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal bool <.cctor>b__157_0() { }

		internal int <GetSystemTimeZones>b__110_0(TimeZoneInfo x, TimeZoneInfo y) { }

		internal int <GetSystemTimeZonesWinRTFallback>b__49_0(TimeZoneInfo x, TimeZoneInfo y) { }

	}

	internal sealed class AdjustmentRule : IEquatable<AdjustmentRule>, ISerializable, IDeserializationCallback
	{
		private readonly DateTime _dateStart; //Field offset: 0x10
		private readonly DateTime _dateEnd; //Field offset: 0x18
		private readonly TimeSpan _daylightDelta; //Field offset: 0x20
		private readonly TransitionTime _daylightTransitionStart; //Field offset: 0x28
		private readonly TransitionTime _daylightTransitionEnd; //Field offset: 0x40
		private readonly TimeSpan _baseUtcOffsetDelta; //Field offset: 0x58
		private readonly bool _noDaylightTransitions; //Field offset: 0x60

		internal TimeSpan BaseUtcOffsetDelta
		{
			internal get { } //Length: 5
		}

		public DateTime DateEnd
		{
			 get { } //Length: 5
		}

		public DateTime DateStart
		{
			 get { } //Length: 5
		}

		public TimeSpan DaylightDelta
		{
			 get { } //Length: 5
		}

		public TransitionTime DaylightTransitionEnd
		{
			 get { } //Length: 21
		}

		public TransitionTime DaylightTransitionStart
		{
			 get { } //Length: 21
		}

		internal bool HasDaylightSaving
		{
			internal get { } //Length: 475
		}

		internal bool NoDaylightTransitions
		{
			internal get { } //Length: 5
		}

		internal AdjustmentRule() { }

		private AdjustmentRule(DateTime dateStart, DateTime dateEnd, TimeSpan daylightDelta, TransitionTime daylightTransitionStart, TransitionTime daylightTransitionEnd, TimeSpan baseUtcOffsetDelta, bool noDaylightTransitions) { }

		private AdjustmentRule(SerializationInfo info, StreamingContext context) { }

		internal static AdjustmentRule CreateAdjustmentRule(DateTime dateStart, DateTime dateEnd, TimeSpan daylightDelta, TransitionTime daylightTransitionStart, TransitionTime daylightTransitionEnd, TimeSpan baseUtcOffsetDelta, bool noDaylightTransitions) { }

		public override bool Equals(AdjustmentRule other) { }

		internal TimeSpan get_BaseUtcOffsetDelta() { }

		public DateTime get_DateEnd() { }

		public DateTime get_DateStart() { }

		public TimeSpan get_DaylightDelta() { }

		public TransitionTime get_DaylightTransitionEnd() { }

		public TransitionTime get_DaylightTransitionStart() { }

		internal bool get_HasDaylightSaving() { }

		internal bool get_NoDaylightTransitions() { }

		public virtual int GetHashCode() { }

		internal bool IsEndDateMarkerForEndOfYear() { }

		internal bool IsStartDateMarkerForBeginningOfYear() { }

		private override void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

		private override void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

		private static void ValidateAdjustmentRule(DateTime dateStart, DateTime dateEnd, TimeSpan daylightDelta, TransitionTime daylightTransitionStart, TransitionTime daylightTransitionEnd, bool noDaylightTransitions) { }

	}

	private sealed class CachedData
	{
		private OffsetAndRule _oneYearLocalFromUtc; //Field offset: 0x10
		private TimeZoneInfo _localTimeZone; //Field offset: 0x18
		public Dictionary<String, TimeZoneInfo> _systemTimeZones; //Field offset: 0x20
		public ReadOnlyCollection<TimeZoneInfo> _readOnlySystemTimeZones; //Field offset: 0x28
		public bool _allSystemTimeZonesRead; //Field offset: 0x30

		public TimeZoneInfo Local
		{
			 get { } //Length: 61
		}

		public CachedData() { }

		private TimeZoneInfo CreateLocal() { }

		public TimeZoneInfo get_Local() { }

		public DateTimeKind GetCorrespondingKind(TimeZoneInfo timeZone) { }

		private static TimeZoneInfo GetCurrentOneYearLocal() { }

		public OffsetAndRule GetOneYearLocalFromUtc(int year) { }

	}

	public struct DYNAMIC_TIME_ZONE_INFORMATION
	{
		internal TIME_ZONE_INFORMATION TZI; //Field offset: 0x0
		internal string TimeZoneKeyName; //Field offset: 0xB0
		internal byte DynamicDaylightTimeDisabled; //Field offset: 0xB8

	}

	private sealed class OffsetAndRule
	{
		public readonly int Year; //Field offset: 0x10
		public readonly TimeSpan Offset; //Field offset: 0x18
		public readonly AdjustmentRule Rule; //Field offset: 0x20

		public OffsetAndRule(int year, TimeSpan offset, AdjustmentRule rule) { }

	}

	private enum TimeZoneInfoResult
	{
		Success = 0,
		TimeZoneNotFoundException = 1,
		InvalidTimeZoneException = 2,
		SecurityException = 3,
	}

	[IsReadOnly]
	internal struct TransitionTime : IEquatable<TransitionTime>, ISerializable, IDeserializationCallback
	{
		private readonly DateTime _timeOfDay; //Field offset: 0x0
		private readonly byte _month; //Field offset: 0x8
		private readonly byte _week; //Field offset: 0x9
		private readonly byte _day; //Field offset: 0xA
		private readonly DayOfWeek _dayOfWeek; //Field offset: 0xC
		private readonly bool _isFixedDateRule; //Field offset: 0x10

		public int Day
		{
			 get { } //Length: 5
		}

		public DayOfWeek DayOfWeek
		{
			 get { } //Length: 4
		}

		public bool IsFixedDateRule
		{
			 get { } //Length: 5
		}

		public int Month
		{
			 get { } //Length: 5
		}

		public DateTime TimeOfDay
		{
			 get { } //Length: 4
		}

		public int Week
		{
			 get { } //Length: 5
		}

		private TransitionTime(SerializationInfo info, StreamingContext context) { }

		private TransitionTime(DateTime timeOfDay, int month, int week, int day, DayOfWeek dayOfWeek, bool isFixedDateRule) { }

		public static TransitionTime CreateFixedDateRule(DateTime timeOfDay, int month, int day) { }

		public static TransitionTime CreateFloatingDateRule(DateTime timeOfDay, int month, int week, DayOfWeek dayOfWeek) { }

		public virtual bool Equals(object obj) { }

		public override bool Equals(TransitionTime other) { }

		public int get_Day() { }

		public DayOfWeek get_DayOfWeek() { }

		public bool get_IsFixedDateRule() { }

		public int get_Month() { }

		public DateTime get_TimeOfDay() { }

		public int get_Week() { }

		public virtual int GetHashCode() { }

		public static bool op_Inequality(TransitionTime t1, TransitionTime t2) { }

		private override void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

		private override void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

		private static void ValidateTransitionTime(DateTime timeOfDay, int month, int week, int day, DayOfWeek dayOfWeek) { }

	}

	private static Lazy<Boolean> lazyHaveRegistry; //Field offset: 0x0
	private static readonly TimeZoneInfo s_utcTimeZone; //Field offset: 0x8
	private static CachedData s_cachedData; //Field offset: 0x10
	private static readonly DateTime s_maxDateOnly; //Field offset: 0x18
	private static readonly DateTime s_minDateOnly; //Field offset: 0x20
	private static readonly TimeSpan MaxOffset; //Field offset: 0x28
	private static readonly TimeSpan MinOffset; //Field offset: 0x30
	private readonly string _id; //Field offset: 0x10
	private readonly string _displayName; //Field offset: 0x18
	private readonly string _standardDisplayName; //Field offset: 0x20
	private readonly string _daylightDisplayName; //Field offset: 0x28
	private readonly TimeSpan _baseUtcOffset; //Field offset: 0x30
	private readonly bool _supportsDaylightSavingTime; //Field offset: 0x38
	private readonly AdjustmentRule[] _adjustmentRules; //Field offset: 0x40

	public TimeSpan BaseUtcOffset
	{
		 get { } //Length: 5
	}

	public string DisplayName
	{
		 get { } //Length: 69
	}

	private static bool HaveRegistry
	{
		private get { } //Length: 111
	}

	public string Id
	{
		 get { } //Length: 5
	}

	public static TimeZoneInfo Local
	{
		 get { } //Length: 132
	}

	public static TimeZoneInfo Utc
	{
		 get { } //Length: 79
	}

	private static TimeZoneInfo() { }

	internal TimeZoneInfo() { }

	private TimeZoneInfo(in TIME_ZONE_INFORMATION zone, bool dstDisabled) { }

	private TimeZoneInfo(SerializationInfo info, StreamingContext context) { }

	private TimeZoneInfo(string id, TimeSpan baseUtcOffset, string displayName, string standardDisplayName, string daylightDisplayName, AdjustmentRule[] adjustmentRules, bool disableDaylightSavingTime) { }

	private static bool CheckDaylightSavingTimeNotSupported(in TIME_ZONE_INFORMATION timeZone) { }

	private static bool CheckIsDst(DateTime startTime, DateTime time, DateTime endTime, bool ignoreYearAdjustment, AdjustmentRule rule) { }

	private int CompareAdjustmentRuleToDateTime(AdjustmentRule rule, AdjustmentRule previousRule, DateTime dateTime, DateTime dateOnly, bool dateTimeisUtc) { }

	private DateTime ConvertFromUtc(DateTime dateTime, TimeSpan daylightDelta, TimeSpan baseUtcOffsetDelta) { }

	private static DateTime ConvertTime(DateTime dateTime, TimeZoneInfo sourceTimeZone, TimeZoneInfo destinationTimeZone, TimeZoneInfoOptions flags, CachedData cachedData) { }

	internal static DateTime ConvertTime(DateTime dateTime, TimeZoneInfo sourceTimeZone, TimeZoneInfo destinationTimeZone, TimeZoneInfoOptions flags) { }

	internal static DateTime ConvertTimeToUtc(DateTime dateTime, TimeZoneInfoOptions flags) { }

	private DateTime ConvertToFromUtc(DateTime dateTime, TimeSpan daylightDelta, TimeSpan baseUtcOffsetDelta, bool convertToUtc) { }

	private DateTime ConvertToUtc(DateTime dateTime, TimeSpan daylightDelta, TimeSpan baseUtcOffsetDelta) { }

	private static DateTime ConvertUtcToTimeZone(long ticks, TimeZoneInfo destinationTimeZone, out bool isAmbiguousLocalDst) { }

	private static AdjustmentRule CreateAdjustmentRuleFromTimeZoneInformation(in REG_TZI_FORMAT timeZoneInformation, DateTime startDate, DateTime endDate, int defaultBaseUtcOffset) { }

	internal static AdjustmentRule CreateAdjustmentRuleFromTimeZoneInformation(ref DYNAMIC_TIME_ZONE_INFORMATION timeZoneInformation, DateTime startDate, DateTime endDate, int defaultBaseUtcOffset) { }

	public static TimeZoneInfo CreateCustomTimeZone(string id, TimeSpan baseUtcOffset, string displayName, string standardDisplayName) { }

	internal static uint EnumDynamicTimeZoneInformation(uint dwIndex, out DYNAMIC_TIME_ZONE_INFORMATION lpTimeZoneInformation) { }

	public virtual bool Equals(object obj) { }

	public override bool Equals(TimeZoneInfo other) { }

	private static string FindIdFromTimeZoneInformation(in TIME_ZONE_INFORMATION timeZone, out bool dstDisabled) { }

	internal static TimeZoneInfo FindSystemTimeZoneByIdWinRTFallback(string id) { }

	public TimeSpan get_BaseUtcOffset() { }

	public string get_DisplayName() { }

	private static bool get_HaveRegistry() { }

	public string get_Id() { }

	public static TimeZoneInfo get_Local() { }

	public static TimeZoneInfo get_Utc() { }

	private AdjustmentRule GetAdjustmentRuleForTime(DateTime dateTime, bool dateTimeisUtc, out Nullable<Int32>& ruleIndex) { }

	private AdjustmentRule GetAdjustmentRuleForTime(DateTime dateTime, out Nullable<Int32>& ruleIndex) { }

	internal static TimeSpan GetDateTimeNowUtcOffsetFromUtc(DateTime time, out bool isAmbiguousLocalDst) { }

	private TimeSpan GetDaylightSavingsEndOffsetFromUtc(TimeSpan baseUtcOffset, AdjustmentRule rule) { }

	private TimeSpan GetDaylightSavingsStartOffsetFromUtc(TimeSpan baseUtcOffset, AdjustmentRule rule, Nullable<Int32> ruleIndex) { }

	private DaylightTimeStruct GetDaylightTime(int year, AdjustmentRule rule, Nullable<Int32> ruleIndex) { }

	internal static uint GetDynamicTimeZoneInformation(out DYNAMIC_TIME_ZONE_INFORMATION pTimeZoneInformation) { }

	internal static uint GetDynamicTimeZoneInformationEffectiveYears(ref DYNAMIC_TIME_ZONE_INFORMATION lpTimeZoneInformation, out uint FirstYear, out uint LastYear) { }

	public virtual int GetHashCode() { }

	private static bool GetIsAmbiguousTime(DateTime time, AdjustmentRule rule, DaylightTimeStruct daylightTime) { }

	private static bool GetIsDaylightSavings(DateTime time, AdjustmentRule rule, DaylightTimeStruct daylightTime, TimeZoneInfoOptions flags) { }

	private static bool GetIsDaylightSavingsFromUtc(DateTime time, int year, TimeSpan utc, AdjustmentRule rule, Nullable<Int32> ruleIndex, out bool isAmbiguousLocalDst, TimeZoneInfo zone) { }

	private static bool GetIsInvalidTime(DateTime time, AdjustmentRule rule, DaylightTimeStruct daylightTime) { }

	private static void GetLocalizedNamesByRegistryKey(RegistryKey key, out string displayName, out string standardName, out string daylightName) { }

	private static TimeZoneInfo GetLocalTimeZone(CachedData cachedData) { }

	private static TimeZoneInfo GetLocalTimeZoneFromWin32Data(in TIME_ZONE_INFORMATION timeZoneInformation, bool dstDisabled) { }

	internal static TimeZoneInfo GetLocalTimeZoneInfoWinRTFallback() { }

	internal static TimeSpan GetLocalUtcOffset(DateTime dateTime, TimeZoneInfoOptions flags) { }

	private AdjustmentRule GetPreviousAdjustmentRule(AdjustmentRule rule, Nullable<Int32> ruleIndex) { }

	public static ReadOnlyCollection<TimeZoneInfo> GetSystemTimeZones() { }

	private static void GetSystemTimeZonesWinRTFallback(CachedData cachedData) { }

	internal static bool GetTimeZoneInformationForYear(ushort wYear, ref DYNAMIC_TIME_ZONE_INFORMATION pdtzi, out TIME_ZONE_INFORMATION ptzi) { }

	private TimeSpan GetUtcOffset(DateTime dateTime, TimeZoneInfoOptions flags, CachedData cachedData) { }

	public TimeSpan GetUtcOffset(DateTime dateTime) { }

	private static TimeSpan GetUtcOffset(DateTime time, TimeZoneInfo zone, TimeZoneInfoOptions flags) { }

	private static TimeSpan GetUtcOffset(TimeSpan baseUtcOffset, AdjustmentRule adjustmentRule) { }

	internal TimeSpan GetUtcOffset(DateTime dateTime, TimeZoneInfoOptions flags) { }

	private static TimeSpan GetUtcOffsetFromUtc(DateTime time, TimeZoneInfo zone, out bool isDaylightSavings) { }

	private static TimeSpan GetUtcOffsetFromUtc(DateTime time, TimeZoneInfo zone) { }

	internal static TimeSpan GetUtcOffsetFromUtc(DateTime time, TimeZoneInfo zone, out bool isDaylightSavings, out bool isAmbiguousLocalDst) { }

	public bool HasSameRules(TimeZoneInfo other) { }

	private static bool IsValidAdjustmentRuleOffest(TimeSpan baseUtcOffset, AdjustmentRule adjustmentRule) { }

	private static void PopulateAllSystemTimeZones(CachedData cachedData) { }

	private static void PopulateAllSystemTimeZonesFromRegistry(CachedData cachedData) { }

	private override void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	private override void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	public virtual string ToString() { }

	private static bool TransitionTimeFromTimeZoneInformation(in REG_TZI_FORMAT timeZoneInformation, out TransitionTime transitionTime, bool readStartDate) { }

	private static bool TransitionTimeFromTimeZoneInformation(DYNAMIC_TIME_ZONE_INFORMATION timeZoneInformation, out TransitionTime transitionTime, bool readStartDate) { }

	internal static DateTime TransitionTimeToDateTime(int year, TransitionTime transitionTime) { }

	private static bool TryCompareStandardDate(in TIME_ZONE_INFORMATION timeZone, in REG_TZI_FORMAT registryTimeZoneInfo) { }

	private static bool TryCompareTimeZoneInformationToRegistry(in TIME_ZONE_INFORMATION timeZone, string id, out bool dstDisabled) { }

	private static bool TryCreateAdjustmentRules(string id, in REG_TZI_FORMAT defaultTimeZoneInformation, out AdjustmentRule[] rules, out Exception e, int defaultBaseUtcOffset) { }

	internal static TimeZoneInfo TryCreateTimeZone(DYNAMIC_TIME_ZONE_INFORMATION timeZoneInformation) { }

	private static string TryGetLocalizedNameByMuiNativeResource(string resource) { }

	private static string TryGetLocalizedNameByNativeResource(string filePath, int resource) { }

	private static TimeZoneInfoResult TryGetTimeZone(string id, bool dstDisabled, out TimeZoneInfo value, out Exception e, CachedData cachedData, bool alwaysFallbackToLocalMachine = false) { }

	private static bool TryGetTimeZoneEntryFromRegistry(RegistryKey key, string name, out REG_TZI_FORMAT dtzi) { }

	private static TimeZoneInfoResult TryGetTimeZoneFromLocalMachine(string id, bool dstDisabled, out TimeZoneInfo value, out Exception e, CachedData cachedData) { }

	private static TimeZoneInfoResult TryGetTimeZoneFromLocalMachine(string id, out TimeZoneInfo value, out Exception e) { }

	private static TimeZoneInfoResult TryGetTimeZoneFromLocalRegistry(string id, out TimeZoneInfo value, out Exception e) { }

	internal static bool UtcOffsetOutOfRange(TimeSpan offset) { }

	private static void ValidateTimeZoneInfo(string id, TimeSpan baseUtcOffset, AdjustmentRule[] adjustmentRules, out bool adjustmentRulesSupportDst) { }

}

