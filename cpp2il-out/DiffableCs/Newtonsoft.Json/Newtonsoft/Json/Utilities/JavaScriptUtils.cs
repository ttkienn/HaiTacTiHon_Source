namespace Newtonsoft.Json.Utilities;

[Nullable(0)]
[NullableContext(1)]
internal static class JavaScriptUtils
{
	[CompilerGenerated]
	private struct <WriteCharAsync>d__14 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public Task task; //Field offset: 0x20
		[Nullable(0)]
		public TextWriter writer; //Field offset: 0x28
		public char c; //Field offset: 0x30
		public CancellationToken cancellationToken; //Field offset: 0x38
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <WriteDefinitelyEscapedJavaScriptStringWithoutDelimitersAsync>d__16 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public Char[] writeBuffer; //Field offset: 0x20
		public int lastWritePosition; //Field offset: 0x28
		[Nullable(0)]
		public JsonTextWriter client; //Field offset: 0x30
		[Nullable(0)]
		public string s; //Field offset: 0x38
		[Nullable(0)]
		public TextWriter writer; //Field offset: 0x40
		public CancellationToken cancellationToken; //Field offset: 0x48
		[Nullable(0)]
		public Boolean[] charEscapeFlags; //Field offset: 0x50
		public StringEscapeHandling stringEscapeHandling; //Field offset: 0x58
		private bool <isEscapedUnicodeText>5__2; //Field offset: 0x5C
		[Nullable(0)]
		private string <escapedValue>5__3; //Field offset: 0x60
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x68
		private int <i>5__4; //Field offset: 0x78

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <WriteEscapedJavaScriptStringWithDelimitersAsync>d__13 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public Task task; //Field offset: 0x20
		[Nullable(0)]
		public string s; //Field offset: 0x28
		[Nullable(0)]
		public TextWriter writer; //Field offset: 0x30
		[Nullable(0)]
		public Boolean[] charEscapeFlags; //Field offset: 0x38
		public StringEscapeHandling stringEscapeHandling; //Field offset: 0x40
		[Nullable(0)]
		public JsonTextWriter client; //Field offset: 0x48
		[Nullable(0)]
		public Char[] writeBuffer; //Field offset: 0x50
		public CancellationToken cancellationToken; //Field offset: 0x58
		public char delimiter; //Field offset: 0x60
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x68

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal static readonly Boolean[] SingleQuoteCharEscapeFlags; //Field offset: 0x0
	private const int UnicodeTextLength = 6; //Field offset: 0x0
	private const string EscapedUnicodeText = "!"; //Field offset: 0x0
	internal static readonly Boolean[] DoubleQuoteCharEscapeFlags; //Field offset: 0x8
	internal static readonly Boolean[] HtmlCharEscapeFlags; //Field offset: 0x10

	private static JavaScriptUtils() { }

	private static int FirstCharToEscape(string s, Boolean[] charEscapeFlags, StringEscapeHandling stringEscapeHandling) { }

	public static Boolean[] GetCharEscapeFlags(StringEscapeHandling stringEscapeHandling, char quoteChar) { }

	public static bool ShouldEscapeJavaScriptString(string s, Boolean[] charEscapeFlags) { }

	public static string ToEscapedJavaScriptString(string value, char delimiter, bool appendDelimiters, StringEscapeHandling stringEscapeHandling) { }

	private static bool TryGetDateConstructorValue(JsonReader reader, out Nullable<Int64>& integer, out string errorMessage) { }

	public static bool TryGetDateFromConstructorJson(JsonReader reader, out DateTime dateTime, out string errorMessage) { }

	[AsyncStateMachine(typeof(<WriteCharAsync>d__14))]
	public static Task WriteCharAsync(Task task, TextWriter writer, char c, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(<WriteDefinitelyEscapedJavaScriptStringWithoutDelimitersAsync>d__16))]
	private static Task WriteDefinitelyEscapedJavaScriptStringWithoutDelimitersAsync(TextWriter writer, string s, int lastWritePosition, Boolean[] charEscapeFlags, StringEscapeHandling stringEscapeHandling, JsonTextWriter client, Char[] writeBuffer, CancellationToken cancellationToken) { }

	[NullableContext(2)]
	public static void WriteEscapedJavaScriptString(TextWriter writer, string s, char delimiter, bool appendDelimiters, Boolean[] charEscapeFlags, StringEscapeHandling stringEscapeHandling, IArrayPool<Char> bufferPool, ref Char[] writeBuffer) { }

	public static Task WriteEscapedJavaScriptStringAsync(TextWriter writer, string s, char delimiter, bool appendDelimiters, Boolean[] charEscapeFlags, StringEscapeHandling stringEscapeHandling, JsonTextWriter client, Char[] writeBuffer, CancellationToken cancellationToken = null) { }

	private static Task WriteEscapedJavaScriptStringWithDelimitersAsync(TextWriter writer, string s, char delimiter, Boolean[] charEscapeFlags, StringEscapeHandling stringEscapeHandling, JsonTextWriter client, Char[] writeBuffer, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(<WriteEscapedJavaScriptStringWithDelimitersAsync>d__13))]
	private static Task WriteEscapedJavaScriptStringWithDelimitersAsync(Task task, TextWriter writer, string s, char delimiter, Boolean[] charEscapeFlags, StringEscapeHandling stringEscapeHandling, JsonTextWriter client, Char[] writeBuffer, CancellationToken cancellationToken) { }

	private static Task WriteEscapedJavaScriptStringWithoutDelimitersAsync(TextWriter writer, string s, Boolean[] charEscapeFlags, StringEscapeHandling stringEscapeHandling, JsonTextWriter client, Char[] writeBuffer, CancellationToken cancellationToken) { }

}

