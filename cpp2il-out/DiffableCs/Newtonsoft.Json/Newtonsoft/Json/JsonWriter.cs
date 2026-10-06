namespace Newtonsoft.Json;

[Nullable(0)]
[NullableContext(1)]
public abstract class JsonWriter : IDisposable
{
	[CompilerGenerated]
	private struct <<InternalWriteEndAsync>g__AwaitEnd|11_2>d : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public Task task; //Field offset: 0x20
		[Nullable(0)]
		public JsonWriter <>4__this; //Field offset: 0x28
		public int LevelsToComplete; //Field offset: 0x30
		public CancellationToken CancellationToken; //Field offset: 0x38
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <<InternalWriteEndAsync>g__AwaitIndent|11_1>d : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public Task task; //Field offset: 0x20
		[Nullable(0)]
		public JsonWriter <>4__this; //Field offset: 0x28
		public JsonToken token; //Field offset: 0x30
		public CancellationToken CancellationToken; //Field offset: 0x38
		public int LevelsToComplete; //Field offset: 0x40
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <<InternalWriteEndAsync>g__AwaitProperty|11_0>d : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public Task task; //Field offset: 0x20
		[Nullable(0)]
		public JsonWriter <>4__this; //Field offset: 0x28
		public CancellationToken CancellationToken; //Field offset: 0x30
		public JsonToken token; //Field offset: 0x38
		public int LevelsToComplete; //Field offset: 0x3C
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <<InternalWriteEndAsync>g__AwaitRemaining|11_3>d : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public JsonWriter <>4__this; //Field offset: 0x20
		public CancellationToken CancellationToken; //Field offset: 0x28
		public int LevelsToComplete; //Field offset: 0x30
		private JsonToken <token>5__2; //Field offset: 0x34
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <AutoCompleteAsync>d__1 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public JsonWriter <>4__this; //Field offset: 0x20
		public CancellationToken cancellationToken; //Field offset: 0x28
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <InternalWriteStartAsync>d__20 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public JsonWriter <>4__this; //Field offset: 0x20
		public JsonToken token; //Field offset: 0x28
		public CancellationToken cancellationToken; //Field offset: 0x30
		public JsonContainerType container; //Field offset: 0x38
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <WriteConstructorDateAsync>d__32 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public JsonReader reader; //Field offset: 0x20
		public CancellationToken cancellationToken; //Field offset: 0x28
		[Nullable(0)]
		public JsonWriter <>4__this; //Field offset: 0x30
		private DateTime <date>5__2; //Field offset: 0x38
		[Nullable(0)]
		private ConfiguredTaskAwaiter<Boolean> <>u__1; //Field offset: 0x40
		private ConfiguredTaskAwaiter <>u__2; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <WriteTokenAsync>d__30 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public JsonWriter <>4__this; //Field offset: 0x20
		[Nullable(0)]
		public JsonReader reader; //Field offset: 0x28
		public bool writeDateConstructorAsDate; //Field offset: 0x30
		public CancellationToken cancellationToken; //Field offset: 0x38
		public bool writeComments; //Field offset: 0x40
		public bool writeChildren; //Field offset: 0x41
		private int <initialDepth>5__2; //Field offset: 0x44
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x48
		[Nullable(0)]
		private ConfiguredTaskAwaiter<Boolean> <>u__2; //Field offset: 0x58

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <WriteTokenSyncReadingAsync>d__31 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public JsonWriter <>4__this; //Field offset: 0x20
		[Nullable(0)]
		public JsonReader reader; //Field offset: 0x28
		public CancellationToken cancellationToken; //Field offset: 0x30
		private int <initialDepth>5__2; //Field offset: 0x38
		[Nullable(0)]
		private ConfiguredTaskAwaiter<Boolean> <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[NullableContext(0)]
	public enum State
	{
		Start = 0,
		Property = 1,
		ObjectStart = 2,
		Object = 3,
		ArrayStart = 4,
		Array = 5,
		ConstructorStart = 6,
		Constructor = 7,
		Closed = 8,
		Error = 9,
	}

	private static readonly State[][] StateArray; //Field offset: 0x0
	internal static readonly State[][] StateArrayTemplate; //Field offset: 0x8
	[Nullable(2)]
	private List<JsonPosition> _stack; //Field offset: 0x10
	private JsonPosition _currentPosition; //Field offset: 0x18
	private State _currentState; //Field offset: 0x30
	private Formatting _formatting; //Field offset: 0x34
	[CompilerGenerated]
	private bool <CloseOutput>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private bool <AutoCompleteOnClose>k__BackingField; //Field offset: 0x39
	private DateFormatHandling _dateFormatHandling; //Field offset: 0x3C
	private DateTimeZoneHandling _dateTimeZoneHandling; //Field offset: 0x40
	private StringEscapeHandling _stringEscapeHandling; //Field offset: 0x44
	private FloatFormatHandling _floatFormatHandling; //Field offset: 0x48
	[Nullable(2)]
	private string _dateFormatString; //Field offset: 0x50
	[Nullable(2)]
	private CultureInfo _culture; //Field offset: 0x58

	public bool AutoCompleteOnClose
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public bool CloseOutput
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	internal string ContainerPath
	{
		internal get { } //Length: 148
	}

	public CultureInfo Culture
	{
		 get { } //Length: 84
		 set { } //Length: 13
	}

	public DateFormatHandling DateFormatHandling
	{
		 get { } //Length: 4
		 set { } //Length: 99
	}

	[Nullable(2)]
	public string DateFormatString
	{
		[NullableContext(2)]
		 get { } //Length: 5
		[NullableContext(2)]
		 set { } //Length: 13
	}

	public DateTimeZoneHandling DateTimeZoneHandling
	{
		 get { } //Length: 4
		 set { } //Length: 99
	}

	public FloatFormatHandling FloatFormatHandling
	{
		 get { } //Length: 4
		 set { } //Length: 99
	}

	public Formatting Formatting
	{
		 get { } //Length: 4
		 set { } //Length: 99
	}

	public string Path
	{
		 get { } //Length: 264
	}

	public StringEscapeHandling StringEscapeHandling
	{
		 get { } //Length: 4
		 set { } //Length: 118
	}

	protected private int Top
	{
		private get { } //Length: 81
	}

	public WriteState WriteState
	{
		 get { } //Length: 28
	}

	private static JsonWriter() { }

	protected JsonWriter() { }

	[AsyncStateMachine(typeof(<<InternalWriteEndAsync>g__AwaitEnd|11_2>d))]
	[CompilerGenerated]
	private Task <InternalWriteEndAsync>g__AwaitEnd|11_2(Task task, int LevelsToComplete, CancellationToken CancellationToken) { }

	[AsyncStateMachine(typeof(<<InternalWriteEndAsync>g__AwaitIndent|11_1>d))]
	[CompilerGenerated]
	private Task <InternalWriteEndAsync>g__AwaitIndent|11_1(Task task, int LevelsToComplete, JsonToken token, CancellationToken CancellationToken) { }

	[AsyncStateMachine(typeof(<<InternalWriteEndAsync>g__AwaitProperty|11_0>d))]
	[CompilerGenerated]
	private Task <InternalWriteEndAsync>g__AwaitProperty|11_0(Task task, int LevelsToComplete, JsonToken token, CancellationToken CancellationToken) { }

	[AsyncStateMachine(typeof(<<InternalWriteEndAsync>g__AwaitRemaining|11_3>d))]
	[CompilerGenerated]
	private Task <InternalWriteEndAsync>g__AwaitRemaining|11_3(int LevelsToComplete, CancellationToken CancellationToken) { }

	internal void AutoComplete(JsonToken tokenBeingWritten) { }

	private void AutoCompleteAll() { }

	internal Task AutoCompleteAsync(JsonToken tokenBeingWritten, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(<AutoCompleteAsync>d__1))]
	private Task AutoCompleteAsync(CancellationToken cancellationToken) { }

	private void AutoCompleteClose(JsonContainerType type) { }

	internal static State[][] BuildStateArray() { }

	private int CalculateLevelsToComplete(JsonContainerType type) { }

	private int CalculateWriteTokenFinalDepth(JsonReader reader) { }

	private int CalculateWriteTokenInitialDepth(JsonReader reader) { }

	public override void Close() { }

	public override Task CloseAsync(CancellationToken cancellationToken = null) { }

	private static JsonWriterException CreateUnsupportedTypeException(JsonWriter writer, object value) { }

	protected override void Dispose(bool disposing) { }

	public abstract void Flush() { }

	public override Task FlushAsync(CancellationToken cancellationToken = null) { }

	[CompilerGenerated]
	public bool get_AutoCompleteOnClose() { }

	[CompilerGenerated]
	public bool get_CloseOutput() { }

	internal string get_ContainerPath() { }

	public CultureInfo get_Culture() { }

	public DateFormatHandling get_DateFormatHandling() { }

	[NullableContext(2)]
	public string get_DateFormatString() { }

	public DateTimeZoneHandling get_DateTimeZoneHandling() { }

	public FloatFormatHandling get_FloatFormatHandling() { }

	public Formatting get_Formatting() { }

	public string get_Path() { }

	public StringEscapeHandling get_StringEscapeHandling() { }

	protected private int get_Top() { }

	public WriteState get_WriteState() { }

	private JsonToken GetCloseTokenForType(JsonContainerType type) { }

	internal void InternalWriteComment() { }

	internal Task InternalWriteCommentAsync(CancellationToken cancellationToken) { }

	internal void InternalWriteEnd(JsonContainerType container) { }

	internal Task InternalWriteEndAsync(JsonContainerType type, CancellationToken cancellationToken) { }

	internal void InternalWritePropertyName(string name) { }

	internal Task InternalWritePropertyNameAsync(string name, CancellationToken cancellationToken) { }

	internal void InternalWriteRaw() { }

	internal void InternalWriteStart(JsonToken token, JsonContainerType container) { }

	[AsyncStateMachine(typeof(<InternalWriteStartAsync>d__20))]
	internal Task InternalWriteStartAsync(JsonToken token, JsonContainerType container, CancellationToken cancellationToken) { }

	internal void InternalWriteValue(JsonToken token) { }

	internal Task InternalWriteValueAsync(JsonToken token, CancellationToken cancellationToken) { }

	internal void InternalWriteWhitespace(string ws) { }

	private bool IsWriteTokenIncomplete(JsonReader reader, bool writeChildren, int initialDepth) { }

	internal override void OnStringEscapeHandlingChanged() { }

	private JsonContainerType Peek() { }

	private JsonContainerType Pop() { }

	private void Push(JsonContainerType value) { }

	private static void ResolveConvertibleValue(IConvertible convertible, out PrimitiveTypeCode typeCode, out object value) { }

	[CompilerGenerated]
	public void set_AutoCompleteOnClose(bool value) { }

	[CompilerGenerated]
	public void set_CloseOutput(bool value) { }

	public void set_Culture(CultureInfo value) { }

	public void set_DateFormatHandling(DateFormatHandling value) { }

	[NullableContext(2)]
	public void set_DateFormatString(string value) { }

	public void set_DateTimeZoneHandling(DateTimeZoneHandling value) { }

	public void set_FloatFormatHandling(FloatFormatHandling value) { }

	public void set_Formatting(Formatting value) { }

	public void set_StringEscapeHandling(StringEscapeHandling value) { }

	protected void SetWriteState(JsonToken token, object value) { }

	protected Task SetWriteStateAsync(JsonToken token, object value, CancellationToken cancellationToken) { }

	private override void System.IDisposable.Dispose() { }

	private void UpdateCurrentState() { }

	internal void UpdateScopeWithFinishedValue() { }

	[NullableContext(2)]
	public override void WriteComment(string text) { }

	public override Task WriteCommentAsync(string text, CancellationToken cancellationToken = null) { }

	private void WriteConstructorDate(JsonReader reader) { }

	[AsyncStateMachine(typeof(<WriteConstructorDateAsync>d__32))]
	private Task WriteConstructorDateAsync(JsonReader reader, CancellationToken cancellationToken) { }

	private void WriteEnd(JsonContainerType type) { }

	protected override void WriteEnd(JsonToken token) { }

	public override void WriteEnd() { }

	public override void WriteEndArray() { }

	public override Task WriteEndArrayAsync(CancellationToken cancellationToken = null) { }

	protected override Task WriteEndAsync(JsonToken token, CancellationToken cancellationToken) { }

	public override Task WriteEndAsync(CancellationToken cancellationToken = null) { }

	public override void WriteEndConstructor() { }

	public override Task WriteEndConstructorAsync(CancellationToken cancellationToken = null) { }

	internal Task WriteEndInternalAsync(CancellationToken cancellationToken) { }

	public override void WriteEndObject() { }

	public override Task WriteEndObjectAsync(CancellationToken cancellationToken = null) { }

	protected override void WriteIndent() { }

	protected override Task WriteIndentAsync(CancellationToken cancellationToken) { }

	protected override void WriteIndentSpace() { }

	protected override Task WriteIndentSpaceAsync(CancellationToken cancellationToken) { }

	public override void WriteNull() { }

	public override Task WriteNullAsync(CancellationToken cancellationToken = null) { }

	public override void WritePropertyName(string name) { }

	public override void WritePropertyName(string name, bool escape) { }

	public override Task WritePropertyNameAsync(string name, bool escape, CancellationToken cancellationToken = null) { }

	public override Task WritePropertyNameAsync(string name, CancellationToken cancellationToken = null) { }

	[NullableContext(2)]
	public override void WriteRaw(string json) { }

	public override Task WriteRawAsync(string json, CancellationToken cancellationToken = null) { }

	[NullableContext(2)]
	public override void WriteRawValue(string json) { }

	public override Task WriteRawValueAsync(string json, CancellationToken cancellationToken = null) { }

	public override void WriteStartArray() { }

	public override Task WriteStartArrayAsync(CancellationToken cancellationToken = null) { }

	public override void WriteStartConstructor(string name) { }

	public override Task WriteStartConstructorAsync(string name, CancellationToken cancellationToken = null) { }

	public override void WriteStartObject() { }

	public override Task WriteStartObjectAsync(CancellationToken cancellationToken = null) { }

	[NullableContext(2)]
	public void WriteToken(JsonToken token, object value) { }

	public void WriteToken(JsonToken token) { }

	internal override void WriteToken(JsonReader reader, bool writeChildren, bool writeDateConstructorAsDate, bool writeComments) { }

	public void WriteToken(JsonReader reader) { }

	public void WriteToken(JsonReader reader, bool writeChildren) { }

	public Task WriteTokenAsync(JsonReader reader, bool writeChildren, CancellationToken cancellationToken = null) { }

	public Task WriteTokenAsync(JsonToken token, CancellationToken cancellationToken = null) { }

	public Task WriteTokenAsync(JsonToken token, object value, CancellationToken cancellationToken = null) { }

	[AsyncStateMachine(typeof(<WriteTokenAsync>d__30))]
	internal override Task WriteTokenAsync(JsonReader reader, bool writeChildren, bool writeDateConstructorAsDate, bool writeComments, CancellationToken cancellationToken) { }

	public Task WriteTokenAsync(JsonReader reader, CancellationToken cancellationToken = null) { }

	[AsyncStateMachine(typeof(<WriteTokenSyncReadingAsync>d__31))]
	internal Task WriteTokenSyncReadingAsync(JsonReader reader, CancellationToken cancellationToken) { }

	public override void WriteUndefined() { }

	public override Task WriteUndefinedAsync(CancellationToken cancellationToken = null) { }

	[CLSCompliant(False)]
	public override void WriteValue(Nullable<SByte> value) { }

	[NullableContext(2)]
	public override void WriteValue(string value) { }

	public override void WriteValue(int value) { }

	[CLSCompliant(False)]
	public override void WriteValue(uint value) { }

	public override void WriteValue(long value) { }

	[CLSCompliant(False)]
	public override void WriteValue(ulong value) { }

	public override void WriteValue(float value) { }

	public override void WriteValue(bool value) { }

	public override void WriteValue(short value) { }

	[CLSCompliant(False)]
	public override void WriteValue(ushort value) { }

	public override void WriteValue(char value) { }

	public override void WriteValue(byte value) { }

	[CLSCompliant(False)]
	public override void WriteValue(sbyte value) { }

	public override void WriteValue(decimal value) { }

	public override void WriteValue(DateTime value) { }

	public override void WriteValue(DateTimeOffset value) { }

	public override void WriteValue(Guid value) { }

	public override void WriteValue(double value) { }

	internal static void WriteValue(JsonWriter writer, PrimitiveTypeCode typeCode, object value) { }

	public override void WriteValue(Nullable<Int32> value) { }

	public override void WriteValue(Nullable<Byte> value) { }

	public override void WriteValue(Nullable<Decimal> value) { }

	public override void WriteValue(Nullable<DateTime> value) { }

	public override void WriteValue(Nullable<Char> value) { }

	public override void WriteValue(Nullable<DateTimeOffset> value) { }

	public override void WriteValue(Nullable<Guid> value) { }

	public override void WriteValue(Nullable<TimeSpan> value) { }

	[CLSCompliant(False)]
	public override void WriteValue(Nullable<UInt16> value) { }

	[NullableContext(2)]
	public override void WriteValue(Byte[] value) { }

	public override void WriteValue(TimeSpan value) { }

	[NullableContext(2)]
	public override void WriteValue(Uri value) { }

	[NullableContext(2)]
	public override void WriteValue(object value) { }

	public override void WriteValue(Nullable<Int16> value) { }

	public override void WriteValue(Nullable<Boolean> value) { }

	public override void WriteValue(Nullable<Double> value) { }

	public override void WriteValue(Nullable<Single> value) { }

	[CLSCompliant(False)]
	public override void WriteValue(Nullable<UInt64> value) { }

	public override void WriteValue(Nullable<Int64> value) { }

	[CLSCompliant(False)]
	public override void WriteValue(Nullable<UInt32> value) { }

	public override Task WriteValueAsync(Nullable<TimeSpan> value, CancellationToken cancellationToken = null) { }

	public override Task WriteValueAsync(short value, CancellationToken cancellationToken = null) { }

	public override Task WriteValueAsync(Nullable<Int16> value, CancellationToken cancellationToken = null) { }

	public override Task WriteValueAsync(string value, CancellationToken cancellationToken = null) { }

	public override Task WriteValueAsync(TimeSpan value, CancellationToken cancellationToken = null) { }

	public override Task WriteValueAsync(long value, CancellationToken cancellationToken = null) { }

	[CLSCompliant(False)]
	public override Task WriteValueAsync(uint value, CancellationToken cancellationToken = null) { }

	public override Task WriteValueAsync(DateTimeOffset value, CancellationToken cancellationToken = null) { }

	internal static Task WriteValueAsync(JsonWriter writer, PrimitiveTypeCode typeCode, object value, CancellationToken cancellationToken) { }

	public override Task WriteValueAsync(Nullable<DateTimeOffset> value, CancellationToken cancellationToken = null) { }

	public override Task WriteValueAsync(decimal value, CancellationToken cancellationToken = null) { }

	public override Task WriteValueAsync(Nullable<Decimal> value, CancellationToken cancellationToken = null) { }

	public override Task WriteValueAsync(Nullable<Int64> value, CancellationToken cancellationToken = null) { }

	public override Task WriteValueAsync(object value, CancellationToken cancellationToken = null) { }

	public override Task WriteValueAsync(double value, CancellationToken cancellationToken = null) { }

	public override Task WriteValueAsync(float value, CancellationToken cancellationToken = null) { }

	public override Task WriteValueAsync(Nullable<Single> value, CancellationToken cancellationToken = null) { }

	public override Task WriteValueAsync(Guid value, CancellationToken cancellationToken = null) { }

	public override Task WriteValueAsync(Nullable<Guid> value, CancellationToken cancellationToken = null) { }

	public override Task WriteValueAsync(int value, CancellationToken cancellationToken = null) { }

	public override Task WriteValueAsync(Nullable<Int32> value, CancellationToken cancellationToken = null) { }

	public override Task WriteValueAsync(Nullable<Double> value, CancellationToken cancellationToken = null) { }

	public override Task WriteValueAsync(DateTime value, CancellationToken cancellationToken = null) { }

	public override Task WriteValueAsync(Nullable<DateTime> value, CancellationToken cancellationToken = null) { }

	public override Task WriteValueAsync(bool value, CancellationToken cancellationToken = null) { }

	[CLSCompliant(False)]
	public override Task WriteValueAsync(Nullable<UInt32> value, CancellationToken cancellationToken = null) { }

	[CLSCompliant(False)]
	public override Task WriteValueAsync(sbyte value, CancellationToken cancellationToken = null) { }

	[CLSCompliant(False)]
	public override Task WriteValueAsync(ulong value, CancellationToken cancellationToken = null) { }

	[CLSCompliant(False)]
	public override Task WriteValueAsync(Nullable<UInt64> value, CancellationToken cancellationToken = null) { }

	public override Task WriteValueAsync(Uri value, CancellationToken cancellationToken = null) { }

	[CLSCompliant(False)]
	public override Task WriteValueAsync(ushort value, CancellationToken cancellationToken = null) { }

	[CLSCompliant(False)]
	public override Task WriteValueAsync(Nullable<UInt16> value, CancellationToken cancellationToken = null) { }

	[CLSCompliant(False)]
	public override Task WriteValueAsync(Nullable<SByte> value, CancellationToken cancellationToken = null) { }

	public override Task WriteValueAsync(byte value, CancellationToken cancellationToken = null) { }

	public override Task WriteValueAsync(Nullable<Byte> value, CancellationToken cancellationToken = null) { }

	public override Task WriteValueAsync(Byte[] value, CancellationToken cancellationToken = null) { }

	public override Task WriteValueAsync(char value, CancellationToken cancellationToken = null) { }

	public override Task WriteValueAsync(Nullable<Char> value, CancellationToken cancellationToken = null) { }

	public override Task WriteValueAsync(Nullable<Boolean> value, CancellationToken cancellationToken = null) { }

	protected override void WriteValueDelimiter() { }

	protected override Task WriteValueDelimiterAsync(CancellationToken cancellationToken) { }

	public override void WriteWhitespace(string ws) { }

	public override Task WriteWhitespaceAsync(string ws, CancellationToken cancellationToken = null) { }

}

