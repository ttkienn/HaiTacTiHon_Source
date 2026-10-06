namespace Newtonsoft.Json.Serialization;

[Nullable(0)]
[NullableContext(1)]
internal class TraceJsonReader : JsonReader, IJsonLineInfo
{
	private readonly JsonReader _innerReader; //Field offset: 0x78
	private readonly JsonTextWriter _textWriter; //Field offset: 0x80
	private readonly StringWriter _sw; //Field offset: 0x88

	public virtual int Depth
	{
		 get { } //Length: 42
	}

	private override int Newtonsoft.Json.IJsonLineInfo.LineNumber
	{
		private get { } //Length: 89
	}

	private override int Newtonsoft.Json.IJsonLineInfo.LinePosition
	{
		private get { } //Length: 89
	}

	public virtual string Path
	{
		 get { } //Length: 42
	}

	public private virtual char QuoteChar
	{
		 get { } //Length: 42
		private set { } //Length: 42
	}

	public virtual JsonToken TokenType
	{
		 get { } //Length: 42
	}

	[Nullable(2)]
	public virtual object Value
	{
		[NullableContext(2)]
		 get { } //Length: 42
	}

	[Nullable(2)]
	public virtual Type ValueType
	{
		[NullableContext(2)]
		 get { } //Length: 42
	}

	public TraceJsonReader(JsonReader innerReader) { }

	public virtual void Close() { }

	public virtual int get_Depth() { }

	public virtual string get_Path() { }

	public virtual char get_QuoteChar() { }

	public virtual JsonToken get_TokenType() { }

	[NullableContext(2)]
	public virtual object get_Value() { }

	[NullableContext(2)]
	public virtual Type get_ValueType() { }

	public string GetDeserializedJsonMessage() { }

	private override int Newtonsoft.Json.IJsonLineInfo.get_LineNumber() { }

	private override int Newtonsoft.Json.IJsonLineInfo.get_LinePosition() { }

	private override bool Newtonsoft.Json.IJsonLineInfo.HasLineInfo() { }

	public virtual bool Read() { }

	public virtual Nullable<Boolean> ReadAsBoolean() { }

	[NullableContext(2)]
	public virtual Byte[] ReadAsBytes() { }

	public virtual Nullable<DateTime> ReadAsDateTime() { }

	public virtual Nullable<DateTimeOffset> ReadAsDateTimeOffset() { }

	public virtual Nullable<Decimal> ReadAsDecimal() { }

	public virtual Nullable<Double> ReadAsDouble() { }

	public virtual Nullable<Int32> ReadAsInt32() { }

	[NullableContext(2)]
	public virtual string ReadAsString() { }

	protected private virtual void set_QuoteChar(char value) { }

	public void WriteCurrentToken() { }

}

