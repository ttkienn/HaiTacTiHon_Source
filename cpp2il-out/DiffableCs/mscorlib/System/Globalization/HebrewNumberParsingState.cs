namespace System.Globalization;

internal enum HebrewNumberParsingState
{
	InvalidHebrewNumber = 0,
	NotHebrewDigit = 1,
	FoundEndOfHebrewNumber = 2,
	ContinueParsing = 3,
}

