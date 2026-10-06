namespace System.Globalization;

internal class HebrewNumber
{
	private enum HebrewToken
	{
		Invalid = -1,
		Digit400 = 0,
		Digit200_300 = 1,
		Digit100 = 2,
		Digit10 = 3,
		Digit1 = 4,
		Digit6_7 = 5,
		Digit7 = 6,
		Digit9 = 7,
		SingleQuote = 8,
		DoubleQuote = 9,
	}

	private struct HebrewValue
	{
		internal HebrewToken token; //Field offset: 0x0
		internal short value; //Field offset: 0x2

		internal HebrewValue(HebrewToken token, short value) { }

	}

	public enum HS
	{
		_err = -1,
		Start = 0,
		S400 = 1,
		S400_400 = 2,
		S400_X00 = 3,
		S400_X0 = 4,
		X00_DQ = 5,
		S400_X00_X0 = 6,
		X0_DQ = 7,
		X = 8,
		X0 = 9,
		X00 = 10,
		S400_DQ = 11,
		S400_400_DQ = 12,
		S400_400_100 = 13,
		S9 = 14,
		X00_S9 = 15,
		S9_DQ = 16,
		END = 100,
	}

	private static readonly HebrewValue[] s_hebrewValues; //Field offset: 0x0
	private static char s_maxHebrewNumberCh; //Field offset: 0x8
	private static readonly HS[] s_numberPasingState; //Field offset: 0x10

	private static HebrewNumber() { }

	internal static bool IsDigit(char ch) { }

	internal static HebrewNumberParsingState ParseByChar(char ch, ref HebrewNumberParsingContext context) { }

	internal static string ToString(int Number) { }

}

