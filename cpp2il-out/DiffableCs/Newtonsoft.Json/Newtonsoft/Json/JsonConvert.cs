namespace Newtonsoft.Json;

[Nullable(0)]
[NullableContext(1)]
public static class JsonConvert
{
	[CompilerGenerated]
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1}])]
	private static Func<JsonSerializerSettings> <DefaultSettings>k__BackingField; //Field offset: 0x0
	public static readonly string True; //Field offset: 0x8
	public static readonly string False; //Field offset: 0x10
	public static readonly string Null; //Field offset: 0x18
	public static readonly string Undefined; //Field offset: 0x20
	public static readonly string PositiveInfinity; //Field offset: 0x28
	public static readonly string NegativeInfinity; //Field offset: 0x30
	public static readonly string NaN; //Field offset: 0x38

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1}])]
	public static Func<JsonSerializerSettings> DefaultSettings
	{
		[CompilerGenerated]
		 get { } //Length: 78
		[CompilerGenerated]
		 set { } //Length: 105
	}

	private static JsonConvert() { }

	[DebuggerStepThrough]
	public static T DeserializeAnonymousType(string value, T anonymousTypeObject) { }

	[DebuggerStepThrough]
	public static T DeserializeAnonymousType(string value, T anonymousTypeObject, JsonSerializerSettings settings) { }

	[DebuggerStepThrough]
	public static object DeserializeObject(string value) { }

	[DebuggerStepThrough]
	public static object DeserializeObject(string value, JsonSerializerSettings settings) { }

	[DebuggerStepThrough]
	public static object DeserializeObject(string value, Type type) { }

	[DebuggerStepThrough]
	[NullableContext(2)]
	public static T DeserializeObject(string value) { }

	[DebuggerStepThrough]
	public static T DeserializeObject(string value, JsonConverter[] converters) { }

	[DebuggerStepThrough]
	public static object DeserializeObject(string value, Type type, JsonConverter[] converters) { }

	[DebuggerStepThrough]
	[NullableContext(2)]
	public static T DeserializeObject(string value, JsonSerializerSettings settings) { }

	[NullableContext(2)]
	public static object DeserializeObject(string value, Type type, JsonSerializerSettings settings) { }

	public static XmlDocument DeserializeXmlNode(string value) { }

	[NullableContext(2)]
	public static XmlDocument DeserializeXmlNode(string value, string deserializeRootElementName) { }

	[NullableContext(2)]
	public static XmlDocument DeserializeXmlNode(string value, string deserializeRootElementName, bool writeArrayAttribute) { }

	[NullableContext(2)]
	public static XmlDocument DeserializeXmlNode(string value, string deserializeRootElementName, bool writeArrayAttribute, bool encodeSpecialCharacters) { }

	public static XDocument DeserializeXNode(string value) { }

	[NullableContext(2)]
	public static XDocument DeserializeXNode(string value, string deserializeRootElementName) { }

	[NullableContext(2)]
	public static XDocument DeserializeXNode(string value, string deserializeRootElementName, bool writeArrayAttribute) { }

	[NullableContext(2)]
	public static XDocument DeserializeXNode(string value, string deserializeRootElementName, bool writeArrayAttribute, bool encodeSpecialCharacters) { }

	private static string EnsureDecimalPlace(string text) { }

	private static string EnsureDecimalPlace(double value, string text) { }

	private static string EnsureFloatFormat(double value, string text, FloatFormatHandling floatFormatHandling, char quoteChar, bool nullable) { }

	[CompilerGenerated]
	public static Func<JsonSerializerSettings> get_DefaultSettings() { }

	[DebuggerStepThrough]
	public static void PopulateObject(string value, object target) { }

	public static void PopulateObject(string value, object target, JsonSerializerSettings settings) { }

	[DebuggerStepThrough]
	public static string SerializeObject(object value) { }

	[DebuggerStepThrough]
	public static string SerializeObject(object value, Formatting formatting, JsonConverter[] converters) { }

	[DebuggerStepThrough]
	public static string SerializeObject(object value, JsonConverter[] converters) { }

	[DebuggerStepThrough]
	public static string SerializeObject(object value, Formatting formatting) { }

	[DebuggerStepThrough]
	[NullableContext(2)]
	public static string SerializeObject(object value, Formatting formatting, JsonSerializerSettings settings) { }

	[DebuggerStepThrough]
	[NullableContext(2)]
	public static string SerializeObject(object value, Type type, Formatting formatting, JsonSerializerSettings settings) { }

	[DebuggerStepThrough]
	[NullableContext(2)]
	public static string SerializeObject(object value, JsonSerializerSettings settings) { }

	[DebuggerStepThrough]
	[NullableContext(2)]
	public static string SerializeObject(object value, Type type, JsonSerializerSettings settings) { }

	private static string SerializeObjectInternal(object value, Type type, JsonSerializer jsonSerializer) { }

	public static string SerializeXmlNode(XmlNode node, Formatting formatting, bool omitRootObject) { }

	public static string SerializeXmlNode(XmlNode node, Formatting formatting) { }

	public static string SerializeXmlNode(XmlNode node) { }

	public static string SerializeXNode(XObject node) { }

	public static string SerializeXNode(XObject node, Formatting formatting) { }

	public static string SerializeXNode(XObject node, Formatting formatting, bool omitRootObject) { }

	[CompilerGenerated]
	public static void set_DefaultSettings(Func<JsonSerializerSettings> value) { }

	public static string ToString(Enum value) { }

	public static string ToString(byte value) { }

	public static string ToString(char value) { }

	public static string ToString(bool value) { }

	public static string ToString(DateTimeOffset value, DateFormatHandling format) { }

	public static string ToString(DateTimeOffset value) { }

	public static string ToString(DateTime value, DateFormatHandling format, DateTimeZoneHandling timeZoneHandling) { }

	public static string ToString(DateTime value) { }

	public static string ToString(int value) { }

	public static string ToString(short value) { }

	[CLSCompliant(False)]
	public static string ToString(ulong value) { }

	[CLSCompliant(False)]
	public static string ToString(uint value) { }

	[CLSCompliant(False)]
	public static string ToString(sbyte value) { }

	public static string ToString(decimal value) { }

	public static string ToString(Guid value) { }

	internal static string ToString(Guid value, char quoteChar) { }

	public static string ToString(TimeSpan value) { }

	internal static string ToString(TimeSpan value, char quoteChar) { }

	public static string ToString(Uri value) { }

	internal static string ToString(Uri value, char quoteChar) { }

	public static string ToString(string value) { }

	public static string ToString(string value, char delimiter) { }

	public static string ToString(string value, char delimiter, StringEscapeHandling stringEscapeHandling) { }

	public static string ToString(double value) { }

	internal static string ToString(float value, FloatFormatHandling floatFormatHandling, char quoteChar, bool nullable) { }

	public static string ToString(float value) { }

	internal static string ToString(double value, FloatFormatHandling floatFormatHandling, char quoteChar, bool nullable) { }

	public static string ToString(long value) { }

	[CLSCompliant(False)]
	public static string ToString(ushort value) { }

	public static string ToString(object value) { }

	private static string ToStringInternal(BigInteger value) { }

}

