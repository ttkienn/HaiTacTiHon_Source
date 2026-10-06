namespace Newtonsoft.Json.Serialization;

[Nullable(0)]
[NullableContext(1)]
internal class TraceJsonWriter : JsonWriter
{
	private readonly JsonWriter _innerWriter; //Field offset: 0x60
	private readonly JsonTextWriter _textWriter; //Field offset: 0x68
	private readonly StringWriter _sw; //Field offset: 0x70

	public TraceJsonWriter(JsonWriter innerWriter) { }

	public virtual void Close() { }

	public virtual void Flush() { }

	public string GetSerializedJsonMessage() { }

	[NullableContext(2)]
	public virtual void WriteComment(string text) { }

	public virtual void WriteEndArray() { }

	public virtual void WriteEndConstructor() { }

	public virtual void WriteEndObject() { }

	public virtual void WriteNull() { }

	public virtual void WritePropertyName(string name, bool escape) { }

	public virtual void WritePropertyName(string name) { }

	[NullableContext(2)]
	public virtual void WriteRaw(string json) { }

	[NullableContext(2)]
	public virtual void WriteRawValue(string json) { }

	public virtual void WriteStartArray() { }

	public virtual void WriteStartConstructor(string name) { }

	public virtual void WriteStartObject() { }

	public virtual void WriteUndefined() { }

	public virtual void WriteValue(TimeSpan value) { }

	public virtual void WriteValue(Nullable<Decimal> value) { }

	public virtual void WriteValue(Nullable<TimeSpan> value) { }

	[NullableContext(2)]
	public virtual void WriteValue(string value) { }

	public virtual void WriteValue(uint value) { }

	public virtual void WriteValue(ushort value) { }

	public virtual void WriteValue(ulong value) { }

	public virtual void WriteValue(Nullable<UInt64> value) { }

	[NullableContext(2)]
	public virtual void WriteValue(Uri value) { }

	public virtual void WriteValue(Nullable<Int16> value) { }

	public virtual void WriteValue(Nullable<UInt16> value) { }

	public virtual void WriteValue(Nullable<UInt32> value) { }

	public virtual void WriteValue(short value) { }

	public virtual void WriteValue(Nullable<SByte> value) { }

	public virtual void WriteValue(sbyte value) { }

	public virtual void WriteValue(bool value) { }

	public virtual void WriteValue(Nullable<Boolean> value) { }

	public virtual void WriteValue(byte value) { }

	public virtual void WriteValue(Nullable<Byte> value) { }

	public virtual void WriteValue(char value) { }

	public virtual void WriteValue(Nullable<Char> value) { }

	[NullableContext(2)]
	public virtual void WriteValue(Byte[] value) { }

	public virtual void WriteValue(DateTime value) { }

	public virtual void WriteValue(Nullable<DateTime> value) { }

	public virtual void WriteValue(DateTimeOffset value) { }

	public virtual void WriteValue(decimal value) { }

	public virtual void WriteValue(Nullable<DateTimeOffset> value) { }

	public virtual void WriteValue(double value) { }

	public virtual void WriteValue(Nullable<Double> value) { }

	public virtual void WriteValue(float value) { }

	public virtual void WriteValue(Nullable<Single> value) { }

	public virtual void WriteValue(Guid value) { }

	public virtual void WriteValue(Nullable<Guid> value) { }

	public virtual void WriteValue(int value) { }

	public virtual void WriteValue(Nullable<Int32> value) { }

	public virtual void WriteValue(long value) { }

	public virtual void WriteValue(Nullable<Int64> value) { }

	[NullableContext(2)]
	public virtual void WriteValue(object value) { }

	public virtual void WriteWhitespace(string ws) { }

}

