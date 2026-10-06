namespace System;

internal struct DateTimeRawInfo
{
	private Int32* num; //Field offset: 0x0
	internal int numCount; //Field offset: 0x8
	internal int month; //Field offset: 0xC
	internal int year; //Field offset: 0x10
	internal int dayOfWeek; //Field offset: 0x14
	internal int era; //Field offset: 0x18
	internal TM timeMark; //Field offset: 0x1C
	internal double fraction; //Field offset: 0x20
	internal bool hasSameDateAndTimeSeparators; //Field offset: 0x28

	internal void AddNumber(int value) { }

	internal int GetNumber(int index) { }

	internal void Init(Int32* numberBuffer) { }

}

