namespace System.Globalization;

internal class EraInfo
{
	internal int era; //Field offset: 0x10
	internal long ticks; //Field offset: 0x18
	internal int yearOffset; //Field offset: 0x20
	internal int minEraYear; //Field offset: 0x24
	internal int maxEraYear; //Field offset: 0x28
	[OptionalField(VersionAdded = 4)]
	internal string eraName; //Field offset: 0x30
	[OptionalField(VersionAdded = 4)]
	internal string abbrevEraName; //Field offset: 0x38
	[OptionalField(VersionAdded = 4)]
	internal string englishEraName; //Field offset: 0x40

	internal EraInfo(int era, int startYear, int startMonth, int startDay, int yearOffset, int minEraYear, int maxEraYear) { }

	internal EraInfo(int era, int startYear, int startMonth, int startDay, int yearOffset, int minEraYear, int maxEraYear, string eraName, string abbrevEraName, string englishEraName) { }

}

