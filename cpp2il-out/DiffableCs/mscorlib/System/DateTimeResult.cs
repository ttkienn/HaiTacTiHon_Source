namespace System;

[IsByRefLike]
[Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
internal struct DateTimeResult
{
	internal int Year; //Field offset: 0x0
	internal int Month; //Field offset: 0x4
	internal int Day; //Field offset: 0x8
	internal int Hour; //Field offset: 0xC
	internal int Minute; //Field offset: 0x10
	internal int Second; //Field offset: 0x14
	internal double fraction; //Field offset: 0x18
	internal int era; //Field offset: 0x20
	internal ParseFlags flags; //Field offset: 0x24
	internal TimeSpan timeZoneOffset; //Field offset: 0x28
	internal Calendar calendar; //Field offset: 0x30
	internal DateTime parsedDate; //Field offset: 0x38
	internal ParseFailureKind failure; //Field offset: 0x40
	internal string failureMessageID; //Field offset: 0x48
	internal object failureMessageFormatArgument; //Field offset: 0x50
	internal string failureArgumentName; //Field offset: 0x58
	internal ReadOnlySpan<Char> originalDateTimeString; //Field offset: 0x60
	internal ReadOnlySpan<Char> failedFormatSpecifier; //Field offset: 0x70

	internal void Init(ReadOnlySpan<Char> originalDateTimeString) { }

	internal void SetBadDateTimeFailure() { }

	internal void SetBadFormatSpecifierFailure() { }

	internal void SetBadFormatSpecifierFailure(ReadOnlySpan<Char> failedFormatSpecifier) { }

	internal void SetDate(int year, int month, int day) { }

	internal void SetFailure(ParseFailureKind failure, string failureMessageID) { }

	internal void SetFailure(ParseFailureKind failure, string failureMessageID, object failureMessageFormatArgument) { }

	internal void SetFailure(ParseFailureKind failure, string failureMessageID, object failureMessageFormatArgument, string failureArgumentName) { }

}

