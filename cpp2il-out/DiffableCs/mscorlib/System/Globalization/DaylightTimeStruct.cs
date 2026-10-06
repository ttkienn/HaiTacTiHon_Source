namespace System.Globalization;

[IsReadOnly]
internal struct DaylightTimeStruct
{
	public readonly DateTime Start; //Field offset: 0x0
	public readonly DateTime End; //Field offset: 0x8
	public readonly TimeSpan Delta; //Field offset: 0x10

	public DaylightTimeStruct(DateTime start, DateTime end, TimeSpan delta) { }

}

