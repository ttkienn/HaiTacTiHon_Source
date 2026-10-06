namespace System;

[DefaultMember("Chars")]
public sealed class string : IComparable, IEnumerable, IEnumerable<Char>, IComparable<String>, IEquatable<String>, IConvertible, ICloneable
{
	private struct ProbabilisticMap
	{

	}

	private enum TrimType
	{
		Head = 0,
		Tail = 1,
		Both = 2,
	}

	private const int StackallocIntBufferSizeLimit = 128; //Field offset: 0x0
	private const int PROBABILISTICMAP_BLOCK_INDEX_MASK = 7; //Field offset: 0x0
	private const int PROBABILISTICMAP_BLOCK_INDEX_SHIFT = 3; //Field offset: 0x0
	private const int PROBABILISTICMAP_SIZE = 8; //Field offset: 0x0
	public static readonly string Empty; //Field offset: 0x0
	private int _stringLength; //Field offset: 0x10
	private char _firstChar; //Field offset: 0x14

	public char Chars
	{
		[Intrinsic]
		 get { } //Length: 66
	}

	public int Length
	{
		 get { } //Length: 191
	}

	[CLSCompliant(False)]
	public String(Char* value, int startIndex, int length) { }

	[CLSCompliant(False)]
	public String(SByte* value, int startIndex, int length) { }

	public String(Char[] value) { }

	public String(Char[] value, int startIndex, int length) { }

	[CLSCompliant(False)]
	public String(Char* value) { }

	public String(ReadOnlySpan<Char> value) { }

	public String(char c, int count) { }

	[CLSCompliant(False)]
	public String(SByte* value, int startIndex, int length, Encoding enc) { }

	private static bool ArrayContains(char searchChar, Char[] anyOf) { }

	internal static void bzero(Byte* dest, int len) { }

	internal static void bzero_aligned_1(Byte* dest, int len) { }

	internal static void bzero_aligned_2(Byte* dest, int len) { }

	internal static void bzero_aligned_4(Byte* dest, int len) { }

	internal static void bzero_aligned_8(Byte* dest, int len) { }

	internal static void CheckStringComparison(StringComparison comparisonType) { }

	public override object Clone() { }

	public static int Compare(string strA, string strB, bool ignoreCase) { }

	public static int Compare(string strA, string strB, StringComparison comparisonType) { }

	public static int Compare(string strA, string strB, bool ignoreCase, CultureInfo culture) { }

	public static int Compare(string strA, string strB, CultureInfo culture, CompareOptions options) { }

	public static int Compare(string strA, int indexA, string strB, int indexB, int length, StringComparison comparisonType) { }

	public static int CompareOrdinal(string strA, string strB) { }

	public static int CompareOrdinal(string strA, int indexA, string strB, int indexB, int length) { }

	internal static int CompareOrdinal(ReadOnlySpan<Char> strA, ReadOnlySpan<Char> strB) { }

	private static int CompareOrdinalHelper(string strA, string strB) { }

	private static int CompareOrdinalHelper(string strA, int indexA, int countA, string strB, int indexB, int countB) { }

	public override int CompareTo(string strB) { }

	public override int CompareTo(object value) { }

	public static string Concat(string str0, string str1, string str2, string str3) { }

	public static string Concat(string str0, string str1, string str2) { }

	public static string Concat(String[] values) { }

	public static string Concat(object arg0, object arg1, object arg2) { }

	public static string Concat(string str0, string str1) { }

	public bool Contains(char value) { }

	public bool Contains(string value) { }

	public static string Copy(string str) { }

	public void CopyTo(int sourceIndex, Char[] destination, int destinationIndex, int count) { }

	public static string Create(int length, TState state, SpanAction<Char, TState> action) { }

	internal static string CreateFromChar(char c) { }

	private string CreateString(SByte* value, int startIndex, int length, Encoding enc) { }

	private string CreateString(SByte* value, int startIndex, int length) { }

	private string CreateString(Char* value, int startIndex, int length) { }

	private string CreateString(Char[] val) { }

	private string CreateString(Char[] val, int startIndex, int length) { }

	private string CreateString(Char* value) { }

	private string CreateString(ReadOnlySpan<Char> value) { }

	private string CreateString(char c, int count) { }

	private static string CreateStringForSByteConstructor(Byte* pb, int numBytes) { }

	internal static string CreateStringFromEncoding(Byte* bytes, int byteLength, Encoding encoding) { }

	private string CreateTrimmedString(int start, int end) { }

	private static string Ctor(Char[] value, int startIndex, int length) { }

	private static string Ctor(Char[] value) { }

	private static string Ctor(ReadOnlySpan<Char> value) { }

	private static string Ctor(char c, int count) { }

	private static string Ctor(SByte* value, int startIndex, int length, Encoding enc) { }

	private static string Ctor(SByte* value, int startIndex, int length) { }

	private static string Ctor(Char* ptr) { }

	private static string Ctor(Char* ptr, int startIndex, int length) { }

	public bool EndsWith(string value, StringComparison comparisonType) { }

	public bool EndsWith(string value) { }

	public static bool Equals(string a, string b, StringComparison comparisonType) { }

	public static bool Equals(string a, string b) { }

	public bool Equals(string value, StringComparison comparisonType) { }

	public override bool Equals(string value) { }

	public virtual bool Equals(object obj) { }

	private static bool EqualsHelper(string strA, string strB) { }

	internal static string FastAllocateString(int length) { }

	private static void FillStringChecked(string dest, int destPos, string src) { }

	public static string Format(IFormatProvider provider, string format, Object[] args) { }

	public static string Format(IFormatProvider provider, string format, object arg0, object arg1, object arg2) { }

	public static string Format(IFormatProvider provider, string format, object arg0) { }

	public static string Format(string format, Object[] args) { }

	public static string Format(string format, object arg0, object arg1, object arg2) { }

	public static string Format(string format, object arg0, object arg1) { }

	public static string Format(string format, object arg0) { }

	public static string Format(IFormatProvider provider, string format, object arg0, object arg1) { }

	private static string FormatHelper(IFormatProvider provider, string format, ParamsArray args) { }

	[Intrinsic]
	public char get_Chars(int index) { }

	public int get_Length() { }

	public virtual int GetHashCode() { }

	internal int GetLegacyNonRandomizedHashCode() { }

	internal char GetRawStringData() { }

	public override TypeCode GetTypeCode() { }

	public int IndexOf(char value, int startIndex, int count) { }

	public int IndexOf(string value, StringComparison comparisonType) { }

	public int IndexOf(string value, int startIndex, StringComparison comparisonType) { }

	public int IndexOf(string value, int startIndex, int count, StringComparison comparisonType) { }

	public int IndexOf(string value) { }

	public int IndexOf(char value, int startIndex) { }

	public int IndexOf(string value, int startIndex) { }

	public int IndexOf(char value) { }

	public int IndexOfAny(Char[] anyOf) { }

	public int IndexOfAny(Char[] anyOf, int startIndex) { }

	public int IndexOfAny(Char[] anyOf, int startIndex, int count) { }

	private int IndexOfAny(char value1, char value2, int startIndex, int count) { }

	private int IndexOfAny(char value1, char value2, char value3, int startIndex, int count) { }

	private int IndexOfCharArray(Char[] anyOf, int startIndex, int count) { }

	internal int IndexOfUnchecked(string value, int startIndex, int count) { }

	internal int IndexOfUncheckedIgnoreCase(string value, int startIndex, int count) { }

	private static void InitializeProbabilisticMap(UInt32* charMap, ReadOnlySpan<Char> anyOf) { }

	public string Insert(int startIndex, string value) { }

	private string InternalSubString(int startIndex, int length) { }

	private static bool IsCharBitSet(UInt32* charMap, byte value) { }

	[NonVersionable]
	public static bool IsNullOrEmpty(string value) { }

	public static bool IsNullOrWhiteSpace(string value) { }

	public static string Join(string separator, IEnumerable<String> values) { }

	public static string Join(string separator, String[] value) { }

	public static string Join(string separator, String[] value, int startIndex, int count) { }

	private static string JoinCore(Char* separator, int separatorLength, String[] value, int startIndex, int count) { }

	public int LastIndexOf(string value, int startIndex, int count, StringComparison comparisonType) { }

	public int LastIndexOf(string value, StringComparison comparisonType) { }

	public int LastIndexOf(string value) { }

	public int LastIndexOf(char value, int startIndex, int count) { }

	public int LastIndexOf(char value, int startIndex) { }

	public int LastIndexOf(char value) { }

	public int LastIndexOfAny(Char[] anyOf, int startIndex, int count) { }

	public int LastIndexOfAny(Char[] anyOf, int startIndex) { }

	public int LastIndexOfAny(Char[] anyOf) { }

	private int LastIndexOfCharArray(Char[] anyOf, int startIndex, int count) { }

	internal int LastIndexOfUnchecked(string value, int startIndex, int count) { }

	internal int LastIndexOfUncheckedIgnoreCase(string value, int startIndex, int count) { }

	private void MakeSeparatorList(String[] separators, ref ValueListBuilder<Int32>& sepListBuilder, ref ValueListBuilder<Int32>& lengthListBuilder) { }

	private void MakeSeparatorList(string separator, ref ValueListBuilder<Int32>& sepListBuilder) { }

	private void MakeSeparatorList(ReadOnlySpan<Char> separators, ref ValueListBuilder<Int32>& sepListBuilder) { }

	private static void memcpy(Byte* dest, Byte* src, int size) { }

	internal static void memcpy_aligned_1(Byte* dest, Byte* src, int size) { }

	internal static void memcpy_aligned_2(Byte* dest, Byte* src, int size) { }

	internal static void memcpy_aligned_4(Byte* dest, Byte* src, int size) { }

	internal static void memcpy_aligned_8(Byte* dest, Byte* src, int size) { }

	private static void memset(Byte* dest, int val, int len) { }

	public string Normalize(NormalizationForm normalizationForm) { }

	public static bool op_Equality(string a, string b) { }

	public static ReadOnlySpan<Char> op_Implicit(string value) { }

	public static bool op_Inequality(string a, string b) { }

	public string PadLeft(int totalWidth, char paddingChar) { }

	public string PadRight(int totalWidth, char paddingChar) { }

	public string Remove(int startIndex, int count) { }

	public string Remove(int startIndex) { }

	public string Replace(string oldValue, string newValue) { }

	public string Replace(char oldChar, char newChar) { }

	private string ReplaceHelper(int oldValueLength, string newValue, ReadOnlySpan<Int32> indices) { }

	private static void SetCharBit(UInt32* charMap, byte value) { }

	public String[] Split(String[] separator, StringSplitOptions options) { }

	public String[] Split(char separator, StringSplitOptions options = 0) { }

	public String[] Split(Char[] separator) { }

	public String[] Split(Char[] separator, StringSplitOptions options) { }

	private String[] SplitInternal(string separator, int count, StringSplitOptions options) { }

	private String[] SplitInternal(ReadOnlySpan<Char> separators, int count, StringSplitOptions options) { }

	private String[] SplitInternal(string separator, String[] separators, int count, StringSplitOptions options) { }

	private String[] SplitKeepEmptyEntries(ReadOnlySpan<Int32> sepList, ReadOnlySpan<Int32> lengthList, int defaultLength, int count) { }

	private String[] SplitOmitEmptyEntries(ReadOnlySpan<Int32> sepList, ReadOnlySpan<Int32> lengthList, int defaultLength, int count) { }

	public bool StartsWith(string value, StringComparison comparisonType) { }

	public bool StartsWith(string value) { }

	internal bool StartsWithOrdinalUnchecked(string value) { }

	public string Substring(int startIndex, int length) { }

	public string Substring(int startIndex) { }

	private override IEnumerator<Char> System.Collections.Generic.IEnumerable<System.Char>.GetEnumerator() { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	private override bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	private override byte System.IConvertible.ToByte(IFormatProvider provider) { }

	private override char System.IConvertible.ToChar(IFormatProvider provider) { }

	private override DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	private override decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	private override double System.IConvertible.ToDouble(IFormatProvider provider) { }

	private override short System.IConvertible.ToInt16(IFormatProvider provider) { }

	private override int System.IConvertible.ToInt32(IFormatProvider provider) { }

	private override long System.IConvertible.ToInt64(IFormatProvider provider) { }

	private override sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	private override float System.IConvertible.ToSingle(IFormatProvider provider) { }

	private override object System.IConvertible.ToType(Type type, IFormatProvider provider) { }

	private override ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	private override uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	private override ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	public Char[] ToCharArray() { }

	public string ToLower() { }

	public string ToLower(CultureInfo culture) { }

	public string ToLowerInvariant() { }

	public override string ToString(IFormatProvider provider) { }

	public virtual string ToString() { }

	public string ToUpper() { }

	public string ToUpper(CultureInfo culture) { }

	public string ToUpperInvariant() { }

	public string Trim(char trimChar) { }

	public string Trim(Char[] trimChars) { }

	public string Trim() { }

	public string TrimEnd(Char[] trimChars) { }

	public string TrimEnd(char trimChar) { }

	public string TrimEnd() { }

	private string TrimHelper(Char* trimChars, int trimCharsLength, TrimType trimType) { }

	public string TrimStart(Char[] trimChars) { }

	public string TrimStart(char trimChar) { }

	private string TrimWhiteSpaceHelper(TrimType trimType) { }

	internal static int wcslen(Char* ptr) { }

	internal static void wstrcpy(Char* dmem, Char* smem, int charCount) { }

}

