namespace Newtonsoft.Json.Serialization;

[Nullable(0)]
[NullableContext(1)]
internal class JsonFormatterConverter : IFormatterConverter
{
	private readonly JsonSerializerInternalReader _reader; //Field offset: 0x10
	private readonly JsonISerializableContract _contract; //Field offset: 0x18
	[Nullable(2)]
	private readonly JsonProperty _member; //Field offset: 0x20

	public JsonFormatterConverter(JsonSerializerInternalReader reader, JsonISerializableContract contract, JsonProperty member) { }

	public override object Convert(object value, Type type) { }

	public override object Convert(object value, TypeCode typeCode) { }

	private T GetTokenValue(object value) { }

	public override bool ToBoolean(object value) { }

	public override byte ToByte(object value) { }

	public override char ToChar(object value) { }

	public override DateTime ToDateTime(object value) { }

	public override decimal ToDecimal(object value) { }

	public override double ToDouble(object value) { }

	public override short ToInt16(object value) { }

	public override int ToInt32(object value) { }

	public override long ToInt64(object value) { }

	public override sbyte ToSByte(object value) { }

	public override float ToSingle(object value) { }

	public override string ToString(object value) { }

	public override ushort ToUInt16(object value) { }

	public override uint ToUInt32(object value) { }

	public override ulong ToUInt64(object value) { }

}

