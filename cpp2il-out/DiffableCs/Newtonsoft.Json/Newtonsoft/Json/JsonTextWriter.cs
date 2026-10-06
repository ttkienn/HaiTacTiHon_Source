namespace Newtonsoft.Json;

[Nullable(0)]
[NullableContext(1)]
public class JsonTextWriter : JsonWriter
{
	[CompilerGenerated]
	private struct <CloseBufferAndWriterAsync>d__9 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public JsonTextWriter <>4__this; //Field offset: 0x20
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <DoCloseAsync>d__8 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public JsonTextWriter <>4__this; //Field offset: 0x20
		public CancellationToken cancellationToken; //Field offset: 0x28
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <DoWriteCommentAsync>d__115 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public JsonTextWriter <>4__this; //Field offset: 0x20
		public CancellationToken cancellationToken; //Field offset: 0x28
		[Nullable(0)]
		public string text; //Field offset: 0x30
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <DoWritePropertyNameAsync>d__30 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public Task task; //Field offset: 0x20
		[Nullable(0)]
		public JsonTextWriter <>4__this; //Field offset: 0x28
		[Nullable(0)]
		public string name; //Field offset: 0x30
		public CancellationToken cancellationToken; //Field offset: 0x38
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <DoWritePropertyNameAsync>d__32 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public JsonTextWriter <>4__this; //Field offset: 0x20
		[Nullable(0)]
		public string name; //Field offset: 0x28
		public CancellationToken cancellationToken; //Field offset: 0x30
		public bool escape; //Field offset: 0x38
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <DoWriteRawValueAsync>d__121 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public Task task; //Field offset: 0x20
		[Nullable(0)]
		public JsonTextWriter <>4__this; //Field offset: 0x28
		[Nullable(0)]
		public string json; //Field offset: 0x30
		public CancellationToken cancellationToken; //Field offset: 0x38
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <DoWriteStartArrayAsync>d__35 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public Task task; //Field offset: 0x20
		[Nullable(0)]
		public JsonTextWriter <>4__this; //Field offset: 0x28
		public CancellationToken cancellationToken; //Field offset: 0x30
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <DoWriteStartConstructorAsync>d__40 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public JsonTextWriter <>4__this; //Field offset: 0x20
		public CancellationToken cancellationToken; //Field offset: 0x28
		[Nullable(0)]
		public string name; //Field offset: 0x30
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <DoWriteStartObjectAsync>d__38 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public Task task; //Field offset: 0x20
		[Nullable(0)]
		public JsonTextWriter <>4__this; //Field offset: 0x28
		public CancellationToken cancellationToken; //Field offset: 0x30
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <DoWriteUndefinedAsync>d__43 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public Task task; //Field offset: 0x20
		[Nullable(0)]
		public JsonTextWriter <>4__this; //Field offset: 0x28
		public CancellationToken cancellationToken; //Field offset: 0x30
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <DoWriteValueAsync>d__60 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public JsonTextWriter <>4__this; //Field offset: 0x20
		public CancellationToken cancellationToken; //Field offset: 0x28
		public DateTime value; //Field offset: 0x30
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <DoWriteValueAsync>d__64 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public JsonTextWriter <>4__this; //Field offset: 0x20
		public CancellationToken cancellationToken; //Field offset: 0x28
		public DateTimeOffset value; //Field offset: 0x30
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <DoWriteValueAsync>d__78 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public JsonTextWriter <>4__this; //Field offset: 0x20
		public CancellationToken cancellationToken; //Field offset: 0x28
		public Guid value; //Field offset: 0x30
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <DoWriteValueAsync>d__97 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public Task task; //Field offset: 0x20
		[Nullable(0)]
		public string value; //Field offset: 0x28
		[Nullable(0)]
		public JsonTextWriter <>4__this; //Field offset: 0x30
		public CancellationToken cancellationToken; //Field offset: 0x38
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <DoWriteValueAsync>d__99 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public JsonTextWriter <>4__this; //Field offset: 0x20
		public CancellationToken cancellationToken; //Field offset: 0x28
		public TimeSpan value; //Field offset: 0x30
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <WriteIndentAsync>d__13 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public JsonTextWriter <>4__this; //Field offset: 0x20
		public int newLineLen; //Field offset: 0x28
		public int currentIndentCount; //Field offset: 0x2C
		public CancellationToken cancellationToken; //Field offset: 0x30
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <WriteIntegerValueAsync>d__24 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public Task task; //Field offset: 0x20
		[Nullable(0)]
		public JsonTextWriter <>4__this; //Field offset: 0x28
		public ulong uvalue; //Field offset: 0x30
		public bool negative; //Field offset: 0x38
		public CancellationToken cancellationToken; //Field offset: 0x40
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <WriteValueInternalAsync>d__15 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public Task task; //Field offset: 0x20
		[Nullable(0)]
		public JsonTextWriter <>4__this; //Field offset: 0x28
		[Nullable(0)]
		public string value; //Field offset: 0x30
		public CancellationToken cancellationToken; //Field offset: 0x38
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <WriteValueNonNullAsync>d__54 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public JsonTextWriter <>4__this; //Field offset: 0x20
		public CancellationToken cancellationToken; //Field offset: 0x28
		[Nullable(0)]
		public Byte[] value; //Field offset: 0x30
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <WriteValueNotNullAsync>d__110 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public Task task; //Field offset: 0x20
		[Nullable(0)]
		public JsonTextWriter <>4__this; //Field offset: 0x28
		[Nullable(0)]
		public Uri value; //Field offset: 0x30
		public CancellationToken cancellationToken; //Field offset: 0x38
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private const int IndentCharBufferSize = 12; //Field offset: 0x0
	private readonly bool _safeAsync; //Field offset: 0x60
	private readonly TextWriter _writer; //Field offset: 0x68
	[Nullable(2)]
	private Base64Encoder _base64Encoder; //Field offset: 0x70
	private char _indentChar; //Field offset: 0x78
	private int _indentation; //Field offset: 0x7C
	private char _quoteChar; //Field offset: 0x80
	private bool _quoteName; //Field offset: 0x82
	[Nullable(2)]
	private Boolean[] _charEscapeFlags; //Field offset: 0x88
	[Nullable(2)]
	private Char[] _writeBuffer; //Field offset: 0x90
	[Nullable(2)]
	private IArrayPool<Char> _arrayPool; //Field offset: 0x98
	[Nullable(2)]
	private Char[] _indentChars; //Field offset: 0xA0

	[Nullable(2)]
	public IArrayPool<Char> ArrayPool
	{
		[NullableContext(2)]
		 get { } //Length: 8
		[NullableContext(2)]
		 set { } //Length: 114
	}

	private Base64Encoder Base64Encoder
	{
		private get { } //Length: 123
	}

	public int Indentation
	{
		 get { } //Length: 4
		 set { } //Length: 98
	}

	public char IndentChar
	{
		 get { } //Length: 5
		 set { } //Length: 36
	}

	public char QuoteChar
	{
		 get { } //Length: 8
		 set { } //Length: 116
	}

	public bool QuoteName
	{
		 get { } //Length: 8
		 set { } //Length: 7
	}

	public JsonTextWriter(TextWriter textWriter) { }

	public virtual void Close() { }

	public virtual Task CloseAsync(CancellationToken cancellationToken = null) { }

	private void CloseBufferAndWriter() { }

	[AsyncStateMachine(typeof(<CloseBufferAndWriterAsync>d__9))]
	private Task CloseBufferAndWriterAsync() { }

	[AsyncStateMachine(typeof(<DoCloseAsync>d__8))]
	internal Task DoCloseAsync(CancellationToken cancellationToken) { }

	internal Task DoFlushAsync(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(<DoWriteCommentAsync>d__115))]
	internal Task DoWriteCommentAsync(string text, CancellationToken cancellationToken) { }

	internal Task DoWriteEndAsync(JsonToken token, CancellationToken cancellationToken) { }

	internal Task DoWriteIndentAsync(CancellationToken cancellationToken) { }

	internal Task DoWriteIndentSpaceAsync(CancellationToken cancellationToken) { }

	internal Task DoWriteNullAsync(CancellationToken cancellationToken) { }

	internal Task DoWritePropertyNameAsync(string name, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(<DoWritePropertyNameAsync>d__32))]
	internal Task DoWritePropertyNameAsync(string name, bool escape, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(<DoWritePropertyNameAsync>d__30))]
	private Task DoWritePropertyNameAsync(Task task, string name, CancellationToken cancellationToken) { }

	internal Task DoWriteRawAsync(string json, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(<DoWriteRawValueAsync>d__121))]
	private Task DoWriteRawValueAsync(Task task, string json, CancellationToken cancellationToken) { }

	internal Task DoWriteRawValueAsync(string json, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(<DoWriteStartArrayAsync>d__35))]
	internal Task DoWriteStartArrayAsync(Task task, CancellationToken cancellationToken) { }

	internal Task DoWriteStartArrayAsync(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(<DoWriteStartConstructorAsync>d__40))]
	internal Task DoWriteStartConstructorAsync(string name, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(<DoWriteStartObjectAsync>d__38))]
	internal Task DoWriteStartObjectAsync(Task task, CancellationToken cancellationToken) { }

	internal Task DoWriteStartObjectAsync(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(<DoWriteUndefinedAsync>d__43))]
	private Task DoWriteUndefinedAsync(Task task, CancellationToken cancellationToken) { }

	internal Task DoWriteUndefinedAsync(CancellationToken cancellationToken) { }

	internal Task DoWriteValueAsync(decimal value, CancellationToken cancellationToken) { }

	internal Task DoWriteValueAsync(Nullable<Decimal> value, CancellationToken cancellationToken) { }

	internal Task DoWriteValueAsync(bool value, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(<DoWriteValueAsync>d__64))]
	internal Task DoWriteValueAsync(DateTimeOffset value, CancellationToken cancellationToken) { }

	internal Task DoWriteValueAsync(Nullable<Boolean> value, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(<DoWriteValueAsync>d__78))]
	internal Task DoWriteValueAsync(Guid value, CancellationToken cancellationToken) { }

	internal Task DoWriteValueAsync(Nullable<DateTime> value, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(<DoWriteValueAsync>d__60))]
	internal Task DoWriteValueAsync(DateTime value, CancellationToken cancellationToken) { }

	internal Task DoWriteValueAsync(Nullable<Byte> value, CancellationToken cancellationToken) { }

	internal Task DoWriteValueAsync(Nullable<DateTimeOffset> value, CancellationToken cancellationToken) { }

	internal Task DoWriteValueAsync(Nullable<Int16> value, CancellationToken cancellationToken) { }

	internal Task DoWriteValueAsync(string value, CancellationToken cancellationToken) { }

	internal Task DoWriteValueAsync(Nullable<Int32> value, CancellationToken cancellationToken) { }

	internal Task DoWriteValueAsync(Nullable<UInt16> value, CancellationToken cancellationToken) { }

	internal Task DoWriteValueAsync(Nullable<UInt64> value, CancellationToken cancellationToken) { }

	internal Task DoWriteValueAsync(Nullable<Guid> value, CancellationToken cancellationToken) { }

	internal Task DoWriteValueAsync(Nullable<TimeSpan> value, CancellationToken cancellationToken) { }

	internal Task DoWriteValueAsync(Nullable<UInt32> value, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(<DoWriteValueAsync>d__97))]
	private Task DoWriteValueAsync(Task task, string value, CancellationToken cancellationToken) { }

	internal Task DoWriteValueAsync(Nullable<Char> value, CancellationToken cancellationToken) { }

	internal Task DoWriteValueAsync(Nullable<SByte> value, CancellationToken cancellationToken) { }

	internal Task DoWriteValueAsync(Nullable<Int64> value, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(<DoWriteValueAsync>d__99))]
	internal Task DoWriteValueAsync(TimeSpan value, CancellationToken cancellationToken) { }

	internal Task DoWriteValueAsync(char value, CancellationToken cancellationToken) { }

	internal Task DoWriteValueDelimiterAsync(CancellationToken cancellationToken) { }

	internal Task DoWriteWhitespaceAsync(string ws, CancellationToken cancellationToken) { }

	internal Char[] EnsureWriteBuffer(int length, int copyTo) { }

	private void EnsureWriteBuffer() { }

	public virtual void Flush() { }

	public virtual Task FlushAsync(CancellationToken cancellationToken = null) { }

	[NullableContext(2)]
	public IArrayPool<Char> get_ArrayPool() { }

	private Base64Encoder get_Base64Encoder() { }

	public int get_Indentation() { }

	public char get_IndentChar() { }

	public char get_QuoteChar() { }

	public bool get_QuoteName() { }

	internal virtual void OnStringEscapeHandlingChanged() { }

	[NullableContext(2)]
	public void set_ArrayPool(IArrayPool<Char> value) { }

	public void set_Indentation(int value) { }

	public void set_IndentChar(char value) { }

	public void set_QuoteChar(char value) { }

	public void set_QuoteName(bool value) { }

	private int SetIndentChars() { }

	private void UpdateCharEscapeFlags() { }

	[NullableContext(2)]
	public virtual void WriteComment(string text) { }

	public virtual Task WriteCommentAsync(string text, CancellationToken cancellationToken = null) { }

	private Task WriteDigitsAsync(ulong uvalue, bool negative, CancellationToken cancellationToken) { }

	protected virtual void WriteEnd(JsonToken token) { }

	public virtual Task WriteEndArrayAsync(CancellationToken cancellationToken = null) { }

	public virtual Task WriteEndAsync(CancellationToken cancellationToken = null) { }

	protected virtual Task WriteEndAsync(JsonToken token, CancellationToken cancellationToken) { }

	public virtual Task WriteEndConstructorAsync(CancellationToken cancellationToken = null) { }

	public virtual Task WriteEndObjectAsync(CancellationToken cancellationToken = null) { }

	private void WriteEscapedString(string value, bool quote) { }

	private Task WriteEscapedStringAsync(string value, bool quote, CancellationToken cancellationToken) { }

	protected virtual void WriteIndent() { }

	[AsyncStateMachine(typeof(<WriteIndentAsync>d__13))]
	private Task WriteIndentAsync(int currentIndentCount, int newLineLen, CancellationToken cancellationToken) { }

	protected virtual Task WriteIndentAsync(CancellationToken cancellationToken) { }

	protected virtual void WriteIndentSpace() { }

	protected virtual Task WriteIndentSpaceAsync(CancellationToken cancellationToken) { }

	private void WriteIntegerValue(int value) { }

	private void WriteIntegerValue(ulong value, bool negative) { }

	private void WriteIntegerValue(uint value, bool negative) { }

	private void WriteIntegerValue(long value) { }

	internal Task WriteIntegerValueAsync(ulong uvalue, CancellationToken cancellationToken) { }

	private Task WriteIntegerValueAsync(ulong uvalue, bool negative, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(<WriteIntegerValueAsync>d__24))]
	private Task WriteIntegerValueAsync(Task task, ulong uvalue, bool negative, CancellationToken cancellationToken) { }

	internal Task WriteIntegerValueAsync(long value, CancellationToken cancellationToken) { }

	public virtual void WriteNull() { }

	public virtual Task WriteNullAsync(CancellationToken cancellationToken = null) { }

	private int WriteNumberToBuffer(ulong value, bool negative) { }

	private int WriteNumberToBuffer(uint value, bool negative) { }

	public virtual void WritePropertyName(string name) { }

	public virtual void WritePropertyName(string name, bool escape) { }

	public virtual Task WritePropertyNameAsync(string name, CancellationToken cancellationToken = null) { }

	public virtual Task WritePropertyNameAsync(string name, bool escape, CancellationToken cancellationToken = null) { }

	[NullableContext(2)]
	public virtual void WriteRaw(string json) { }

	public virtual Task WriteRawAsync(string json, CancellationToken cancellationToken = null) { }

	public virtual Task WriteRawValueAsync(string json, CancellationToken cancellationToken = null) { }

	public virtual void WriteStartArray() { }

	public virtual Task WriteStartArrayAsync(CancellationToken cancellationToken = null) { }

	public virtual void WriteStartConstructor(string name) { }

	public virtual Task WriteStartConstructorAsync(string name, CancellationToken cancellationToken = null) { }

	public virtual void WriteStartObject() { }

	public virtual Task WriteStartObjectAsync(CancellationToken cancellationToken = null) { }

	public virtual void WriteUndefined() { }

	public virtual Task WriteUndefinedAsync(CancellationToken cancellationToken = null) { }

	public virtual void WriteValue(Guid value) { }

	public virtual void WriteValue(DateTimeOffset value) { }

	[NullableContext(2)]
	public virtual void WriteValue(Byte[] value) { }

	[NullableContext(2)]
	public virtual void WriteValue(object value) { }

	public virtual void WriteValue(DateTime value) { }

	public virtual void WriteValue(decimal value) { }

	[NullableContext(2)]
	public virtual void WriteValue(string value) { }

	public virtual void WriteValue(int value) { }

	[CLSCompliant(False)]
	public virtual void WriteValue(uint value) { }

	[CLSCompliant(False)]
	public virtual void WriteValue(sbyte value) { }

	public virtual void WriteValue(byte value) { }

	public virtual void WriteValue(long value) { }

	[CLSCompliant(False)]
	public virtual void WriteValue(ulong value) { }

	public virtual void WriteValue(float value) { }

	public virtual void WriteValue(char value) { }

	[CLSCompliant(False)]
	public virtual void WriteValue(ushort value) { }

	public virtual void WriteValue(Nullable<Single> value) { }

	public virtual void WriteValue(double value) { }

	public virtual void WriteValue(Nullable<Double> value) { }

	public virtual void WriteValue(short value) { }

	public virtual void WriteValue(bool value) { }

	[NullableContext(2)]
	public virtual void WriteValue(Uri value) { }

	public virtual void WriteValue(TimeSpan value) { }

	public virtual Task WriteValueAsync(Nullable<Decimal> value, CancellationToken cancellationToken = null) { }

	public virtual Task WriteValueAsync(long value, CancellationToken cancellationToken = null) { }

	public virtual Task WriteValueAsync(Nullable<Int64> value, CancellationToken cancellationToken = null) { }

	internal Task WriteValueAsync(BigInteger value, CancellationToken cancellationToken) { }

	[CLSCompliant(False)]
	public virtual Task WriteValueAsync(Nullable<UInt16> value, CancellationToken cancellationToken = null) { }

	[CLSCompliant(False)]
	public virtual Task WriteValueAsync(ushort value, CancellationToken cancellationToken = null) { }

	public virtual Task WriteValueAsync(object value, CancellationToken cancellationToken = null) { }

	[CLSCompliant(False)]
	public virtual Task WriteValueAsync(sbyte value, CancellationToken cancellationToken = null) { }

	public virtual Task WriteValueAsync(Nullable<Int32> value, CancellationToken cancellationToken = null) { }

	public virtual Task WriteValueAsync(Uri value, CancellationToken cancellationToken = null) { }

	[CLSCompliant(False)]
	public virtual Task WriteValueAsync(Nullable<UInt64> value, CancellationToken cancellationToken = null) { }

	[CLSCompliant(False)]
	public virtual Task WriteValueAsync(ulong value, CancellationToken cancellationToken = null) { }

	[CLSCompliant(False)]
	public virtual Task WriteValueAsync(Nullable<UInt32> value, CancellationToken cancellationToken = null) { }

	[CLSCompliant(False)]
	public virtual Task WriteValueAsync(uint value, CancellationToken cancellationToken = null) { }

	public virtual Task WriteValueAsync(short value, CancellationToken cancellationToken = null) { }

	public virtual Task WriteValueAsync(Nullable<TimeSpan> value, CancellationToken cancellationToken = null) { }

	public virtual Task WriteValueAsync(Nullable<Char> value, CancellationToken cancellationToken = null) { }

	public virtual Task WriteValueAsync(Nullable<Int16> value, CancellationToken cancellationToken = null) { }

	[CLSCompliant(False)]
	public virtual Task WriteValueAsync(Nullable<SByte> value, CancellationToken cancellationToken = null) { }

	public virtual Task WriteValueAsync(double value, CancellationToken cancellationToken = null) { }

	public virtual Task WriteValueAsync(char value, CancellationToken cancellationToken = null) { }

	public virtual Task WriteValueAsync(int value, CancellationToken cancellationToken = null) { }

	public virtual Task WriteValueAsync(decimal value, CancellationToken cancellationToken = null) { }

	public virtual Task WriteValueAsync(bool value, CancellationToken cancellationToken = null) { }

	public virtual Task WriteValueAsync(string value, CancellationToken cancellationToken = null) { }

	internal Task WriteValueAsync(double value, bool nullable, CancellationToken cancellationToken) { }

	public virtual Task WriteValueAsync(Nullable<Double> value, CancellationToken cancellationToken = null) { }

	public virtual Task WriteValueAsync(Nullable<DateTimeOffset> value, CancellationToken cancellationToken = null) { }

	public virtual Task WriteValueAsync(float value, CancellationToken cancellationToken = null) { }

	internal Task WriteValueAsync(float value, bool nullable, CancellationToken cancellationToken) { }

	public virtual Task WriteValueAsync(Byte[] value, CancellationToken cancellationToken = null) { }

	public virtual Task WriteValueAsync(Nullable<Boolean> value, CancellationToken cancellationToken = null) { }

	public virtual Task WriteValueAsync(byte value, CancellationToken cancellationToken = null) { }

	public virtual Task WriteValueAsync(Nullable<DateTime> value, CancellationToken cancellationToken = null) { }

	public virtual Task WriteValueAsync(Nullable<Byte> value, CancellationToken cancellationToken = null) { }

	public virtual Task WriteValueAsync(Nullable<Single> value, CancellationToken cancellationToken = null) { }

	public virtual Task WriteValueAsync(DateTime value, CancellationToken cancellationToken = null) { }

	public virtual Task WriteValueAsync(Guid value, CancellationToken cancellationToken = null) { }

	public virtual Task WriteValueAsync(Nullable<Guid> value, CancellationToken cancellationToken = null) { }

	public virtual Task WriteValueAsync(DateTimeOffset value, CancellationToken cancellationToken = null) { }

	public virtual Task WriteValueAsync(TimeSpan value, CancellationToken cancellationToken = null) { }

	protected virtual void WriteValueDelimiter() { }

	protected virtual Task WriteValueDelimiterAsync(CancellationToken cancellationToken) { }

	private void WriteValueInternal(string value, JsonToken token) { }

	private Task WriteValueInternalAsync(JsonToken token, string value, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(<WriteValueInternalAsync>d__15))]
	private Task WriteValueInternalAsync(Task task, string value, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(<WriteValueNonNullAsync>d__54))]
	internal Task WriteValueNonNullAsync(Byte[] value, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(<WriteValueNotNullAsync>d__110))]
	internal Task WriteValueNotNullAsync(Task task, Uri value, CancellationToken cancellationToken) { }

	internal Task WriteValueNotNullAsync(Uri value, CancellationToken cancellationToken) { }

	private int WriteValueToBuffer(DateTime value) { }

	private int WriteValueToBuffer(DateTimeOffset value) { }

	public virtual void WriteWhitespace(string ws) { }

	public virtual Task WriteWhitespaceAsync(string ws, CancellationToken cancellationToken = null) { }

}

