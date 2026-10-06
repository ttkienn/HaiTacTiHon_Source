namespace Newtonsoft.Json;

[Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
public class JsonValidatingReader : JsonReader, IJsonLineInfo
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<JsonSchemaModel, Boolean> <>9__50_0; //Field offset: 0x8
		public static Func<JsonSchemaModel, Boolean> <>9__50_1; //Field offset: 0x10
		public static Func<JsonSchemaModel, Boolean> <>9__50_2; //Field offset: 0x18
		public static Func<Boolean, Boolean> <>9__51_0; //Field offset: 0x20
		public static Func<KeyValuePair`2<String, Boolean>, Boolean> <>9__51_1; //Field offset: 0x28
		public static Func<KeyValuePair`2<String, Boolean>, String> <>9__51_2; //Field offset: 0x30

		private static <>c() { }

		public <>c() { }

		internal bool <ValidateEndObject>b__51_0(bool v) { }

		internal bool <ValidateEndObject>b__51_1(KeyValuePair<String, Boolean> kv) { }

		internal string <ValidateEndObject>b__51_2(KeyValuePair<String, Boolean> kv) { }

		internal bool <WriteToken>b__50_0(JsonSchemaModel s) { }

		internal bool <WriteToken>b__50_1(JsonSchemaModel s) { }

		internal bool <WriteToken>b__50_2(JsonSchemaModel s) { }

	}

	private class SchemaScope
	{
		[CompilerGenerated]
		private sealed class <>c
		{
			public static readonly <>c <>9; //Field offset: 0x0
			public static Func<String, String> <>9__27_0; //Field offset: 0x8
			public static Func<String, Boolean> <>9__27_1; //Field offset: 0x10
			public static Func<JsonSchemaModel, Boolean> <>9__27_2; //Field offset: 0x18
			public static Func<KeyValuePair`2<String, JsonSchemaModel>, Boolean> <>9__28_0; //Field offset: 0x20
			public static Func<KeyValuePair`2<String, JsonSchemaModel>, String> <>9__28_1; //Field offset: 0x28

			private static <>c() { }

			public <>c() { }

			internal string <.ctor>b__27_0(string p) { }

			internal bool <.ctor>b__27_1(string p) { }

			internal bool <.ctor>b__27_2(JsonSchemaModel s) { }

			internal bool <GetRequiredProperties>b__28_0(KeyValuePair<String, JsonSchemaModel> p) { }

			internal string <GetRequiredProperties>b__28_1(KeyValuePair<String, JsonSchemaModel> p) { }

		}

		private readonly JTokenType _tokenType; //Field offset: 0x10
		private readonly IList<JsonSchemaModel> _schemas; //Field offset: 0x18
		private readonly Dictionary<String, Boolean> _requiredProperties; //Field offset: 0x20
		[CompilerGenerated]
		private string <CurrentPropertyName>k__BackingField; //Field offset: 0x28
		[CompilerGenerated]
		private int <ArrayItemCount>k__BackingField; //Field offset: 0x30
		[CompilerGenerated]
		private readonly bool <IsUniqueArray>k__BackingField; //Field offset: 0x34
		[CompilerGenerated]
		private readonly IList<JToken> <UniqueArrayItems>k__BackingField; //Field offset: 0x38
		[CompilerGenerated]
		private JTokenWriter <CurrentItemWriter>k__BackingField; //Field offset: 0x40

		public int ArrayItemCount
		{
			[CompilerGenerated]
			 get { } //Length: 4
			[CompilerGenerated]
			 set { } //Length: 4
		}

		public JTokenWriter CurrentItemWriter
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			 set { } //Length: 13
		}

		public string CurrentPropertyName
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			 set { } //Length: 13
		}

		public bool IsUniqueArray
		{
			[CompilerGenerated]
			 get { } //Length: 5
		}

		public Dictionary<String, Boolean> RequiredProperties
		{
			 get { } //Length: 5
		}

		public IList<JsonSchemaModel> Schemas
		{
			 get { } //Length: 5
		}

		public JTokenType TokenType
		{
			 get { } //Length: 191
		}

		public IList<JToken> UniqueArrayItems
		{
			[CompilerGenerated]
			 get { } //Length: 5
		}

		public SchemaScope(JTokenType tokenType, IList<JsonSchemaModel> schemas) { }

		[CompilerGenerated]
		public int get_ArrayItemCount() { }

		[CompilerGenerated]
		public JTokenWriter get_CurrentItemWriter() { }

		[CompilerGenerated]
		public string get_CurrentPropertyName() { }

		[CompilerGenerated]
		public bool get_IsUniqueArray() { }

		public Dictionary<String, Boolean> get_RequiredProperties() { }

		public IList<JsonSchemaModel> get_Schemas() { }

		public JTokenType get_TokenType() { }

		[CompilerGenerated]
		public IList<JToken> get_UniqueArrayItems() { }

		private IEnumerable<String> GetRequiredProperties(JsonSchemaModel schema) { }

		[CompilerGenerated]
		public void set_ArrayItemCount(int value) { }

		[CompilerGenerated]
		public void set_CurrentItemWriter(JTokenWriter value) { }

		[CompilerGenerated]
		public void set_CurrentPropertyName(string value) { }

	}

	private static readonly IList<JsonSchemaModel> EmptySchemaList; //Field offset: 0x0
	private readonly JsonReader _reader; //Field offset: 0x78
	private readonly Stack<SchemaScope> _stack; //Field offset: 0x80
	private JsonSchema _schema; //Field offset: 0x88
	private JsonSchemaModel _model; //Field offset: 0x90
	private SchemaScope _currentScope; //Field offset: 0x98
	[CompilerGenerated]
	private ValidationEventHandler ValidationEventHandler; //Field offset: 0xA0

	public event ValidationEventHandler ValidationEventHandler
	{
		[CompilerGenerated]
		 add { } //Length: 162
		[CompilerGenerated]
		 remove { } //Length: 162
	}

	private IList<JsonSchemaModel> CurrentMemberSchemas
	{
		private get { } //Length: 2500
	}

	private IList<JsonSchemaModel> CurrentSchemas
	{
		private get { } //Length: 30
	}

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
		private set { } //Length: 3
	}

	public JsonReader Reader
	{
		 get { } //Length: 5
	}

	public JsonSchema Schema
	{
		 get { } //Length: 8
		 set { } //Length: 168
	}

	public virtual JsonToken TokenType
	{
		 get { } //Length: 42
	}

	public virtual object Value
	{
		 get { } //Length: 42
	}

	public virtual Type ValueType
	{
		 get { } //Length: 42
	}

	private static JsonValidatingReader() { }

	public JsonValidatingReader(JsonReader reader) { }

	[CompilerGenerated]
	public void add_ValidationEventHandler(ValidationEventHandler value) { }

	public virtual void Close() { }

	private static double FloatingPointRemainder(double dividend, double divisor) { }

	private IList<JsonSchemaModel> get_CurrentMemberSchemas() { }

	private IList<JsonSchemaModel> get_CurrentSchemas() { }

	public virtual int get_Depth() { }

	public virtual string get_Path() { }

	public virtual char get_QuoteChar() { }

	public JsonReader get_Reader() { }

	public JsonSchema get_Schema() { }

	public virtual JsonToken get_TokenType() { }

	public virtual object get_Value() { }

	public virtual Type get_ValueType() { }

	private Nullable<JsonSchemaType> GetCurrentNodeSchemaType() { }

	private bool IsPropertyDefinied(JsonSchemaModel schema, string propertyName) { }

	private static bool IsZero(double value) { }

	private override int Newtonsoft.Json.IJsonLineInfo.get_LineNumber() { }

	private override int Newtonsoft.Json.IJsonLineInfo.get_LinePosition() { }

	private override bool Newtonsoft.Json.IJsonLineInfo.HasLineInfo() { }

	private void OnValidationEvent(JsonSchemaException exception) { }

	private SchemaScope Pop() { }

	private void ProcessValue() { }

	private void Push(SchemaScope scope) { }

	private void RaiseError(string message, JsonSchemaModel schema) { }

	public virtual bool Read() { }

	public virtual Nullable<Boolean> ReadAsBoolean() { }

	public virtual Byte[] ReadAsBytes() { }

	public virtual Nullable<DateTime> ReadAsDateTime() { }

	public virtual Nullable<DateTimeOffset> ReadAsDateTimeOffset() { }

	public virtual Nullable<Decimal> ReadAsDecimal() { }

	public virtual Nullable<Double> ReadAsDouble() { }

	public virtual Nullable<Int32> ReadAsInt32() { }

	public virtual string ReadAsString() { }

	[CompilerGenerated]
	public void remove_ValidationEventHandler(ValidationEventHandler value) { }

	protected private virtual void set_QuoteChar(char value) { }

	public void set_Schema(JsonSchema value) { }

	private bool TestType(JsonSchemaModel currentSchema, JsonSchemaType currentType) { }

	private bool ValidateArray(JsonSchemaModel schema) { }

	private void ValidateBoolean(JsonSchemaModel schema) { }

	private void ValidateCurrentToken() { }

	private void ValidateEndArray(JsonSchemaModel schema) { }

	private void ValidateEndObject(JsonSchemaModel schema) { }

	private void ValidateFloat(JsonSchemaModel schema) { }

	private void ValidateInteger(JsonSchemaModel schema) { }

	private void ValidateNotDisallowed(JsonSchemaModel schema) { }

	private void ValidateNull(JsonSchemaModel schema) { }

	private bool ValidateObject(JsonSchemaModel schema) { }

	private void ValidatePropertyName(JsonSchemaModel schema) { }

	private void ValidateString(JsonSchemaModel schema) { }

	private void WriteToken(IList<JsonSchemaModel> schemas) { }

}

