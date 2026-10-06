namespace Newtonsoft.Json;

[Nullable(0)]
[NullableContext(1)]
public class JsonTextReader : JsonReader, IJsonLineInfo
{
	[CompilerGenerated]
	private struct <DoReadAsBooleanAsync>d__40 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		[Nullable(0)]
		public AsyncTaskMethodBuilder<Nullable`1<Boolean>> <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public JsonTextReader <>4__this; //Field offset: 0x20
		public CancellationToken cancellationToken; //Field offset: 0x28
		[Nullable(0)]
		private ConfiguredTaskAwaiter<Boolean> <>u__1; //Field offset: 0x30
		private BigInteger <i>5__2; //Field offset: 0x40
		private bool <isTrue>5__3; //Field offset: 0x50
		private ConfiguredTaskAwaiter <>u__2; //Field offset: 0x58

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <DoReadAsBytesAsync>d__42 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		[Nullable(0)]
		public AsyncTaskMethodBuilder<Byte[]> <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public JsonTextReader <>4__this; //Field offset: 0x20
		public CancellationToken cancellationToken; //Field offset: 0x28
		private bool <isWrapped>5__2; //Field offset: 0x30
		[Nullable(0)]
		private ConfiguredTaskAwaiter<Boolean> <>u__1; //Field offset: 0x38
		[Nullable(0)]
		private Byte[] <data>5__3; //Field offset: 0x48
		private ConfiguredTaskAwaiter <>u__2; //Field offset: 0x50
		[Nullable(new IL2CPP_TYPE_U1[] {0, 2}])]
		private ConfiguredTaskAwaiter<Byte[]> <>u__3; //Field offset: 0x60

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <DoReadAsDateTimeAsync>d__45 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		[Nullable(0)]
		public AsyncTaskMethodBuilder<Nullable`1<DateTime>> <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public JsonTextReader <>4__this; //Field offset: 0x20
		public CancellationToken cancellationToken; //Field offset: 0x28
		[Nullable(new IL2CPP_TYPE_U1[] {0, 2}])]
		private ConfiguredTaskAwaiter<Object> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <DoReadAsDateTimeOffsetAsync>d__47 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		[Nullable(0)]
		public AsyncTaskMethodBuilder<Nullable`1<DateTimeOffset>> <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public JsonTextReader <>4__this; //Field offset: 0x20
		public CancellationToken cancellationToken; //Field offset: 0x28
		[Nullable(new IL2CPP_TYPE_U1[] {0, 2}])]
		private ConfiguredTaskAwaiter<Object> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <DoReadAsDecimalAsync>d__49 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		[Nullable(0)]
		public AsyncTaskMethodBuilder<Nullable`1<Decimal>> <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public JsonTextReader <>4__this; //Field offset: 0x20
		public CancellationToken cancellationToken; //Field offset: 0x28
		[Nullable(new IL2CPP_TYPE_U1[] {0, 2}])]
		private ConfiguredTaskAwaiter<Object> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <DoReadAsDoubleAsync>d__51 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		[Nullable(0)]
		public AsyncTaskMethodBuilder<Nullable`1<Double>> <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public JsonTextReader <>4__this; //Field offset: 0x20
		public CancellationToken cancellationToken; //Field offset: 0x28
		[Nullable(new IL2CPP_TYPE_U1[] {0, 2}])]
		private ConfiguredTaskAwaiter<Object> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <DoReadAsInt32Async>d__53 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		[Nullable(0)]
		public AsyncTaskMethodBuilder<Nullable`1<Int32>> <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public JsonTextReader <>4__this; //Field offset: 0x20
		public CancellationToken cancellationToken; //Field offset: 0x28
		[Nullable(new IL2CPP_TYPE_U1[] {0, 2}])]
		private ConfiguredTaskAwaiter<Object> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <DoReadAsStringAsync>d__55 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		[Nullable(0)]
		public AsyncTaskMethodBuilder<String> <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public JsonTextReader <>4__this; //Field offset: 0x20
		public CancellationToken cancellationToken; //Field offset: 0x28
		[Nullable(new IL2CPP_TYPE_U1[] {0, 2}])]
		private ConfiguredTaskAwaiter<Object> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <DoReadAsync>d__3 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		[Nullable(0)]
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public Task<Boolean> task; //Field offset: 0x20
		[Nullable(0)]
		public JsonTextReader <>4__this; //Field offset: 0x28
		public CancellationToken cancellationToken; //Field offset: 0x30
		[Nullable(0)]
		private ConfiguredTaskAwaiter<Boolean> <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <EatWhitespaceAsync>d__17 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public JsonTextReader <>4__this; //Field offset: 0x20
		public CancellationToken cancellationToken; //Field offset: 0x28
		[Nullable(0)]
		private ConfiguredTaskAwaiter<Int32> <>u__1; //Field offset: 0x30
		private ConfiguredTaskAwaiter <>u__2; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <HandleNullAsync>d__35 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public JsonTextReader <>4__this; //Field offset: 0x20
		public CancellationToken cancellationToken; //Field offset: 0x28
		[Nullable(0)]
		private ConfiguredTaskAwaiter<Boolean> <>u__1; //Field offset: 0x30
		private ConfiguredTaskAwaiter <>u__2; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <MatchAndSetAsync>d__21 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public JsonTextReader <>4__this; //Field offset: 0x20
		[Nullable(0)]
		public string value; //Field offset: 0x28
		public CancellationToken cancellationToken; //Field offset: 0x30
		public JsonToken newToken; //Field offset: 0x38
		[Nullable(0)]
		public object tokenValue; //Field offset: 0x40
		[Nullable(0)]
		private ConfiguredTaskAwaiter<Boolean> <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <MatchValueAsync>d__19 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		[Nullable(0)]
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public JsonTextReader <>4__this; //Field offset: 0x20
		[Nullable(0)]
		public string value; //Field offset: 0x28
		public CancellationToken cancellationToken; //Field offset: 0x30
		[Nullable(0)]
		private ConfiguredTaskAwaiter<Boolean> <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <MatchValueWithTrailingSeparatorAsync>d__20 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		[Nullable(0)]
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public JsonTextReader <>4__this; //Field offset: 0x20
		[Nullable(0)]
		public string value; //Field offset: 0x28
		public CancellationToken cancellationToken; //Field offset: 0x30
		[Nullable(0)]
		private ConfiguredTaskAwaiter<Boolean> <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ParseCommentAsync>d__16 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public JsonTextReader <>4__this; //Field offset: 0x20
		public CancellationToken cancellationToken; //Field offset: 0x28
		public bool setToken; //Field offset: 0x30
		private bool <singlelineComment>5__2; //Field offset: 0x31
		private int <initialPosition>5__3; //Field offset: 0x34
		[Nullable(0)]
		private ConfiguredTaskAwaiter<Boolean> <>u__1; //Field offset: 0x38
		[Nullable(0)]
		private ConfiguredTaskAwaiter<Int32> <>u__2; //Field offset: 0x48
		private ConfiguredTaskAwaiter <>u__3; //Field offset: 0x58

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ParseConstructorAsync>d__25 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public JsonTextReader <>4__this; //Field offset: 0x20
		public CancellationToken cancellationToken; //Field offset: 0x28
		[Nullable(0)]
		private ConfiguredTaskAwaiter<Boolean> <>u__1; //Field offset: 0x30
		private int <initialPosition>5__2; //Field offset: 0x40
		private int <endPosition>5__3; //Field offset: 0x44
		[Nullable(0)]
		private string <constructorName>5__4; //Field offset: 0x48
		private ConfiguredTaskAwaiter <>u__2; //Field offset: 0x50
		[Nullable(0)]
		private ConfiguredTaskAwaiter<Int32> <>u__3; //Field offset: 0x60

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ParseNumberAsync>d__29 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public JsonTextReader <>4__this; //Field offset: 0x20
		public CancellationToken cancellationToken; //Field offset: 0x28
		public ReadType readType; //Field offset: 0x30
		private char <firstChar>5__2; //Field offset: 0x34
		private int <initialPosition>5__3; //Field offset: 0x38
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ParseNumberNaNAsync>d__26 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		[Nullable(0)]
		public AsyncTaskMethodBuilder<Object> <>t__builder; //Field offset: 0x8
		public ReadType readType; //Field offset: 0x20
		[Nullable(0)]
		public JsonTextReader <>4__this; //Field offset: 0x28
		public CancellationToken cancellationToken; //Field offset: 0x30
		private ReadType <>7__wrap1; //Field offset: 0x38
		[Nullable(0)]
		private ConfiguredTaskAwaiter<Boolean> <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ParseNumberNegativeInfinityAsync>d__28 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		[Nullable(0)]
		public AsyncTaskMethodBuilder<Object> <>t__builder; //Field offset: 0x8
		public ReadType readType; //Field offset: 0x20
		[Nullable(0)]
		public JsonTextReader <>4__this; //Field offset: 0x28
		public CancellationToken cancellationToken; //Field offset: 0x30
		private ReadType <>7__wrap1; //Field offset: 0x38
		[Nullable(0)]
		private ConfiguredTaskAwaiter<Boolean> <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ParseNumberPositiveInfinityAsync>d__27 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		[Nullable(0)]
		public AsyncTaskMethodBuilder<Object> <>t__builder; //Field offset: 0x8
		public ReadType readType; //Field offset: 0x20
		[Nullable(0)]
		public JsonTextReader <>4__this; //Field offset: 0x28
		public CancellationToken cancellationToken; //Field offset: 0x30
		private ReadType <>7__wrap1; //Field offset: 0x38
		[Nullable(0)]
		private ConfiguredTaskAwaiter<Boolean> <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ParseObjectAsync>d__15 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		[Nullable(0)]
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public JsonTextReader <>4__this; //Field offset: 0x20
		public CancellationToken cancellationToken; //Field offset: 0x28
		[Nullable(0)]
		private ConfiguredTaskAwaiter<Int32> <>u__1; //Field offset: 0x30
		private ConfiguredTaskAwaiter <>u__2; //Field offset: 0x40
		[Nullable(0)]
		private ConfiguredTaskAwaiter<Boolean> <>u__3; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ParsePostValueAsync>d__4 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		[Nullable(0)]
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public JsonTextReader <>4__this; //Field offset: 0x20
		public CancellationToken cancellationToken; //Field offset: 0x28
		public bool ignoreComments; //Field offset: 0x30
		[Nullable(0)]
		private ConfiguredTaskAwaiter<Int32> <>u__1; //Field offset: 0x38
		private ConfiguredTaskAwaiter <>u__2; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ParsePropertyAsync>d__31 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		[Nullable(0)]
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public JsonTextReader <>4__this; //Field offset: 0x20
		public CancellationToken cancellationToken; //Field offset: 0x28
		private char <quoteChar>5__2; //Field offset: 0x30
		[Nullable(0)]
		private string <propertyName>5__3; //Field offset: 0x38
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ParseStringAsync>d__18 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public CancellationToken cancellationToken; //Field offset: 0x20
		[Nullable(0)]
		public JsonTextReader <>4__this; //Field offset: 0x28
		public char quote; //Field offset: 0x30
		public ReadType readType; //Field offset: 0x34
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ParseUnicodeAsync>d__12 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		[Nullable(0)]
		public AsyncTaskMethodBuilder<Char> <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public JsonTextReader <>4__this; //Field offset: 0x20
		public CancellationToken cancellationToken; //Field offset: 0x28
		[Nullable(0)]
		private ConfiguredTaskAwaiter<Boolean> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ParseUnquotedPropertyAsync>d__33 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public JsonTextReader <>4__this; //Field offset: 0x20
		public CancellationToken cancellationToken; //Field offset: 0x28
		private int <initialPosition>5__2; //Field offset: 0x30
		[Nullable(0)]
		private ConfiguredTaskAwaiter<Int32> <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ParseValueAsync>d__8 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		[Nullable(0)]
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public JsonTextReader <>4__this; //Field offset: 0x20
		public CancellationToken cancellationToken; //Field offset: 0x28
		[Nullable(0)]
		private ConfiguredTaskAwaiter<Int32> <>u__1; //Field offset: 0x30
		private ConfiguredTaskAwaiter <>u__2; //Field offset: 0x40
		[Nullable(0)]
		private ConfiguredTaskAwaiter<Boolean> <>u__3; //Field offset: 0x50
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1}])]
		private ConfiguredTaskAwaiter<Object> <>u__4; //Field offset: 0x60

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ProcessCarriageReturnAsync>d__11 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public Task<Boolean> task; //Field offset: 0x20
		[Nullable(0)]
		public JsonTextReader <>4__this; //Field offset: 0x28
		[Nullable(0)]
		private ConfiguredTaskAwaiter<Boolean> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ReadCharsAsync>d__14 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		[Nullable(0)]
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public JsonTextReader <>4__this; //Field offset: 0x20
		public int relativePosition; //Field offset: 0x28
		public bool append; //Field offset: 0x2C
		public CancellationToken cancellationToken; //Field offset: 0x30
		private int <charsRequired>5__2; //Field offset: 0x38
		[Nullable(0)]
		private ConfiguredTaskAwaiter<Int32> <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ReadDataAsync>d__7 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		[Nullable(0)]
		public AsyncTaskMethodBuilder<Int32> <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public JsonTextReader <>4__this; //Field offset: 0x20
		public bool append; //Field offset: 0x28
		public int charsRequired; //Field offset: 0x2C
		public CancellationToken cancellationToken; //Field offset: 0x30
		[Nullable(0)]
		private ConfiguredTaskAwaiter<Int32> <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ReadFinishedAsync>d__36 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public JsonTextReader <>4__this; //Field offset: 0x20
		public CancellationToken cancellationToken; //Field offset: 0x28
		[Nullable(0)]
		private ConfiguredTaskAwaiter<Boolean> <>u__1; //Field offset: 0x30
		private ConfiguredTaskAwaiter <>u__2; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ReadFromFinishedAsync>d__5 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		[Nullable(0)]
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public JsonTextReader <>4__this; //Field offset: 0x20
		public CancellationToken cancellationToken; //Field offset: 0x28
		[Nullable(0)]
		private ConfiguredTaskAwaiter<Boolean> <>u__1; //Field offset: 0x30
		private ConfiguredTaskAwaiter <>u__2; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ReadIntoWrappedTypeObjectAsync>d__43 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public JsonTextReader <>4__this; //Field offset: 0x20
		public CancellationToken cancellationToken; //Field offset: 0x28
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ReadNullCharAsync>d__34 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		[Nullable(0)]
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public JsonTextReader <>4__this; //Field offset: 0x20
		public CancellationToken cancellationToken; //Field offset: 0x28
		[Nullable(0)]
		private ConfiguredTaskAwaiter<Int32> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ReadNumberIntoBufferAsync>d__32 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public JsonTextReader <>4__this; //Field offset: 0x20
		public CancellationToken cancellationToken; //Field offset: 0x28
		private int <charPos>5__2; //Field offset: 0x30
		[Nullable(0)]
		private ConfiguredTaskAwaiter<Int32> <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ReadNumberValueAsync>d__38 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		[Nullable(0)]
		public AsyncTaskMethodBuilder<Object> <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public JsonTextReader <>4__this; //Field offset: 0x20
		public CancellationToken cancellationToken; //Field offset: 0x28
		public ReadType readType; //Field offset: 0x30
		[Nullable(0)]
		private ConfiguredTaskAwaiter<Boolean> <>u__1; //Field offset: 0x38
		private ConfiguredTaskAwaiter <>u__2; //Field offset: 0x48
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1}])]
		private ConfiguredTaskAwaiter<Object> <>u__3; //Field offset: 0x58

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ReadStringIntoBufferAsync>d__9 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public JsonTextReader <>4__this; //Field offset: 0x20
		public CancellationToken cancellationToken; //Field offset: 0x28
		public char quote; //Field offset: 0x30
		private int <charPos>5__2; //Field offset: 0x34
		private int <initialPosition>5__3; //Field offset: 0x38
		private int <lastWritePosition>5__4; //Field offset: 0x3C
		private int <escapeStartPos>5__5; //Field offset: 0x40
		private char <writeChar>5__6; //Field offset: 0x44
		[Nullable(0)]
		private ConfiguredTaskAwaiter<Int32> <>u__1; //Field offset: 0x48
		[Nullable(0)]
		private ConfiguredTaskAwaiter<Boolean> <>u__2; //Field offset: 0x58
		[Nullable(0)]
		private ConfiguredTaskAwaiter<Char> <>u__3; //Field offset: 0x68
		private bool <anotherHighSurrogate>5__7; //Field offset: 0x78
		private char <highSurrogate>5__8; //Field offset: 0x7A
		private ConfiguredTaskAwaiter <>u__4; //Field offset: 0x80

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ReadStringValueAsync>d__37 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		[Nullable(0)]
		public AsyncTaskMethodBuilder<Object> <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public JsonTextReader <>4__this; //Field offset: 0x20
		public CancellationToken cancellationToken; //Field offset: 0x28
		public ReadType readType; //Field offset: 0x30
		[Nullable(0)]
		private ConfiguredTaskAwaiter<Boolean> <>u__1; //Field offset: 0x38
		[Nullable(0)]
		private string <expected>5__2; //Field offset: 0x48
		private ConfiguredTaskAwaiter <>u__2; //Field offset: 0x50
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1}])]
		private ConfiguredTaskAwaiter<Object> <>u__3; //Field offset: 0x60

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private const char UnicodeReplacementChar = '\uFFFD'; //Field offset: 0x0
	private const int MaximumJavascriptIntegerCharacterLength = 380; //Field offset: 0x0
	private const int LargeBufferLength = 1073741823; //Field offset: 0x0
	private readonly bool _safeAsync; //Field offset: 0x78
	private readonly TextReader _reader; //Field offset: 0x80
	[Nullable(2)]
	private Char[] _chars; //Field offset: 0x88
	private int _charsUsed; //Field offset: 0x90
	private int _charPos; //Field offset: 0x94
	private int _lineStartPos; //Field offset: 0x98
	private int _lineNumber; //Field offset: 0x9C
	private bool _isEndOfFile; //Field offset: 0xA0
	private StringBuffer _stringBuffer; //Field offset: 0xA8
	private StringReference _stringReference; //Field offset: 0xB8
	[Nullable(2)]
	private IArrayPool<Char> _arrayPool; //Field offset: 0xC8
	[CompilerGenerated]
	[Nullable(2)]
	private JsonNameTable <PropertyNameTable>k__BackingField; //Field offset: 0xD0

	[Nullable(2)]
	public IArrayPool<Char> ArrayPool
	{
		[NullableContext(2)]
		 get { } //Length: 8
		[NullableContext(2)]
		 set { } //Length: 114
	}

	public override int LineNumber
	{
		 get { } //Length: 73
	}

	public override int LinePosition
	{
		 get { } //Length: 13
	}

	[Nullable(2)]
	public JsonNameTable PropertyNameTable
	{
		[CompilerGenerated]
		[NullableContext(2)]
		 get { } //Length: 8
		[CompilerGenerated]
		[NullableContext(2)]
		 set { } //Length: 19
	}

	public JsonTextReader(TextReader reader) { }

	private static object BigIntegerParse(string number, CultureInfo culture) { }

	private static void BlockCopyChars(Char[] src, int srcOffset, Char[] dst, int dstOffset, int count) { }

	private void ClearRecentString() { }

	public virtual void Close() { }

	private char ConvertUnicode(bool enoughChars) { }

	private JsonReaderException CreateUnexpectedCharacterException(char c) { }

	[AsyncStateMachine(typeof(<DoReadAsBooleanAsync>d__40))]
	internal Task<Nullable`1<Boolean>> DoReadAsBooleanAsync(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(<DoReadAsBytesAsync>d__42))]
	internal Task<Byte[]> DoReadAsBytesAsync(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(<DoReadAsDateTimeAsync>d__45))]
	internal Task<Nullable`1<DateTime>> DoReadAsDateTimeAsync(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(<DoReadAsDateTimeOffsetAsync>d__47))]
	internal Task<Nullable`1<DateTimeOffset>> DoReadAsDateTimeOffsetAsync(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(<DoReadAsDecimalAsync>d__49))]
	internal Task<Nullable`1<Decimal>> DoReadAsDecimalAsync(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(<DoReadAsDoubleAsync>d__51))]
	internal Task<Nullable`1<Double>> DoReadAsDoubleAsync(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(<DoReadAsInt32Async>d__53))]
	internal Task<Nullable`1<Int32>> DoReadAsInt32Async(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(<DoReadAsStringAsync>d__55))]
	internal Task<String> DoReadAsStringAsync(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(<DoReadAsync>d__3))]
	private Task<Boolean> DoReadAsync(Task<Boolean> task, CancellationToken cancellationToken) { }

	internal Task<Boolean> DoReadAsync(CancellationToken cancellationToken) { }

	private void EatWhitespace() { }

	[AsyncStateMachine(typeof(<EatWhitespaceAsync>d__17))]
	private Task EatWhitespaceAsync(CancellationToken cancellationToken) { }

	private void EndComment(bool setToken, int initialPosition, int endPosition) { }

	private void EnsureBuffer() { }

	private void EnsureBufferNotEmpty() { }

	private bool EnsureChars(int relativePosition, bool append) { }

	private Task<Boolean> EnsureCharsAsync(int relativePosition, bool append, CancellationToken cancellationToken) { }

	[NullableContext(2)]
	private object FinishReadQuotedNumber(ReadType readType) { }

	[NullableContext(2)]
	private object FinishReadQuotedStringValue(ReadType readType) { }

	private void FinishReadStringIntoBuffer(int charPos, int initialPosition, int lastWritePosition) { }

	[NullableContext(2)]
	public IArrayPool<Char> get_ArrayPool() { }

	public override int get_LineNumber() { }

	public override int get_LinePosition() { }

	[CompilerGenerated]
	[NullableContext(2)]
	public JsonNameTable get_PropertyNameTable() { }

	private void HandleNull() { }

	[AsyncStateMachine(typeof(<HandleNullAsync>d__35))]
	private Task HandleNullAsync(CancellationToken cancellationToken) { }

	public override bool HasLineInfo() { }

	private bool IsSeparator(char c) { }

	[AsyncStateMachine(typeof(<MatchAndSetAsync>d__21))]
	private Task MatchAndSetAsync(string value, JsonToken newToken, object tokenValue, CancellationToken cancellationToken) { }

	private bool MatchValue(bool enoughChars, string value) { }

	private bool MatchValue(string value) { }

	[AsyncStateMachine(typeof(<MatchValueAsync>d__19))]
	private Task<Boolean> MatchValueAsync(string value, CancellationToken cancellationToken) { }

	private bool MatchValueWithTrailingSeparator(string value) { }

	[AsyncStateMachine(typeof(<MatchValueWithTrailingSeparatorAsync>d__20))]
	private Task<Boolean> MatchValueWithTrailingSeparatorAsync(string value, CancellationToken cancellationToken) { }

	private void OnNewLine(int pos) { }

	private void ParseComment(bool setToken) { }

	[AsyncStateMachine(typeof(<ParseCommentAsync>d__16))]
	private Task ParseCommentAsync(bool setToken, CancellationToken cancellationToken) { }

	private void ParseConstructor() { }

	[AsyncStateMachine(typeof(<ParseConstructorAsync>d__25))]
	private Task ParseConstructorAsync(CancellationToken cancellationToken) { }

	private void ParseFalse() { }

	private Task ParseFalseAsync(CancellationToken cancellationToken) { }

	private void ParseNull() { }

	private Task ParseNullAsync(CancellationToken cancellationToken) { }

	private void ParseNumber(ReadType readType) { }

	[AsyncStateMachine(typeof(<ParseNumberAsync>d__29))]
	private Task ParseNumberAsync(ReadType readType, CancellationToken cancellationToken) { }

	private object ParseNumberNaN(ReadType readType) { }

	private object ParseNumberNaN(ReadType readType, bool matched) { }

	[AsyncStateMachine(typeof(<ParseNumberNaNAsync>d__26))]
	private Task<Object> ParseNumberNaNAsync(ReadType readType, CancellationToken cancellationToken) { }

	private object ParseNumberNegativeInfinity(ReadType readType, bool matched) { }

	private object ParseNumberNegativeInfinity(ReadType readType) { }

	[AsyncStateMachine(typeof(<ParseNumberNegativeInfinityAsync>d__28))]
	private Task<Object> ParseNumberNegativeInfinityAsync(ReadType readType, CancellationToken cancellationToken) { }

	private object ParseNumberPositiveInfinity(ReadType readType) { }

	private object ParseNumberPositiveInfinity(ReadType readType, bool matched) { }

	[AsyncStateMachine(typeof(<ParseNumberPositiveInfinityAsync>d__27))]
	private Task<Object> ParseNumberPositiveInfinityAsync(ReadType readType, CancellationToken cancellationToken) { }

	private bool ParseObject() { }

	[AsyncStateMachine(typeof(<ParseObjectAsync>d__15))]
	private Task<Boolean> ParseObjectAsync(CancellationToken cancellationToken) { }

	private bool ParsePostValue(bool ignoreComments) { }

	[AsyncStateMachine(typeof(<ParsePostValueAsync>d__4))]
	private Task<Boolean> ParsePostValueAsync(bool ignoreComments, CancellationToken cancellationToken) { }

	private bool ParseProperty() { }

	[AsyncStateMachine(typeof(<ParsePropertyAsync>d__31))]
	private Task<Boolean> ParsePropertyAsync(CancellationToken cancellationToken) { }

	private void ParseReadNumber(ReadType readType, char firstChar, int initialPosition) { }

	private void ParseReadString(char quote, ReadType readType) { }

	private void ParseString(char quote, ReadType readType) { }

	[AsyncStateMachine(typeof(<ParseStringAsync>d__18))]
	private Task ParseStringAsync(char quote, ReadType readType, CancellationToken cancellationToken) { }

	private void ParseTrue() { }

	private Task ParseTrueAsync(CancellationToken cancellationToken) { }

	private void ParseUndefined() { }

	private Task ParseUndefinedAsync(CancellationToken cancellationToken) { }

	private char ParseUnicode() { }

	[AsyncStateMachine(typeof(<ParseUnicodeAsync>d__12))]
	private Task<Char> ParseUnicodeAsync(CancellationToken cancellationToken) { }

	private void ParseUnquotedProperty() { }

	[AsyncStateMachine(typeof(<ParseUnquotedPropertyAsync>d__33))]
	private Task ParseUnquotedPropertyAsync(CancellationToken cancellationToken) { }

	private bool ParseValue() { }

	[AsyncStateMachine(typeof(<ParseValueAsync>d__8))]
	private Task<Boolean> ParseValueAsync(CancellationToken cancellationToken) { }

	private void PrepareBufferForReadData(bool append, int charsRequired) { }

	private void ProcessCarriageReturn(bool append) { }

	[AsyncStateMachine(typeof(<ProcessCarriageReturnAsync>d__11))]
	private Task ProcessCarriageReturnAsync(Task<Boolean> task) { }

	private Task ProcessCarriageReturnAsync(bool append, CancellationToken cancellationToken) { }

	private void ProcessLineFeed() { }

	private void ProcessValueComma() { }

	public virtual bool Read() { }

	public virtual Nullable<Boolean> ReadAsBoolean() { }

	public virtual Task<Nullable`1<Boolean>> ReadAsBooleanAsync(CancellationToken cancellationToken = null) { }

	[NullableContext(2)]
	public virtual Byte[] ReadAsBytes() { }

	public virtual Task<Byte[]> ReadAsBytesAsync(CancellationToken cancellationToken = null) { }

	public virtual Nullable<DateTime> ReadAsDateTime() { }

	public virtual Task<Nullable`1<DateTime>> ReadAsDateTimeAsync(CancellationToken cancellationToken = null) { }

	public virtual Nullable<DateTimeOffset> ReadAsDateTimeOffset() { }

	public virtual Task<Nullable`1<DateTimeOffset>> ReadAsDateTimeOffsetAsync(CancellationToken cancellationToken = null) { }

	public virtual Nullable<Decimal> ReadAsDecimal() { }

	public virtual Task<Nullable`1<Decimal>> ReadAsDecimalAsync(CancellationToken cancellationToken = null) { }

	public virtual Nullable<Double> ReadAsDouble() { }

	public virtual Task<Nullable`1<Double>> ReadAsDoubleAsync(CancellationToken cancellationToken = null) { }

	public virtual Nullable<Int32> ReadAsInt32() { }

	public virtual Task<Nullable`1<Int32>> ReadAsInt32Async(CancellationToken cancellationToken = null) { }

	[NullableContext(2)]
	public virtual string ReadAsString() { }

	public virtual Task<String> ReadAsStringAsync(CancellationToken cancellationToken = null) { }

	public virtual Task<Boolean> ReadAsync(CancellationToken cancellationToken = null) { }

	private bool ReadChars(int relativePosition, bool append) { }

	[AsyncStateMachine(typeof(<ReadCharsAsync>d__14))]
	private Task<Boolean> ReadCharsAsync(int relativePosition, bool append, CancellationToken cancellationToken) { }

	private int ReadData(bool append) { }

	private int ReadData(bool append, int charsRequired) { }

	private Task<Int32> ReadDataAsync(bool append, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(<ReadDataAsync>d__7))]
	private Task<Int32> ReadDataAsync(bool append, int charsRequired, CancellationToken cancellationToken) { }

	private void ReadFinished() { }

	[AsyncStateMachine(typeof(<ReadFinishedAsync>d__36))]
	private Task ReadFinishedAsync(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(<ReadFromFinishedAsync>d__5))]
	private Task<Boolean> ReadFromFinishedAsync(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(<ReadIntoWrappedTypeObjectAsync>d__43))]
	private Task ReadIntoWrappedTypeObjectAsync(CancellationToken cancellationToken) { }

	private bool ReadNullChar() { }

	[AsyncStateMachine(typeof(<ReadNullCharAsync>d__34))]
	private Task<Boolean> ReadNullCharAsync(CancellationToken cancellationToken) { }

	private bool ReadNumberCharIntoBuffer(char currentChar, int charPos) { }

	private void ReadNumberIntoBuffer() { }

	[AsyncStateMachine(typeof(<ReadNumberIntoBufferAsync>d__32))]
	private Task ReadNumberIntoBufferAsync(CancellationToken cancellationToken) { }

	[NullableContext(2)]
	private object ReadNumberValue(ReadType readType) { }

	[AsyncStateMachine(typeof(<ReadNumberValueAsync>d__38))]
	private Task<Object> ReadNumberValueAsync(ReadType readType, CancellationToken cancellationToken) { }

	private void ReadStringIntoBuffer(char quote) { }

	[AsyncStateMachine(typeof(<ReadStringIntoBufferAsync>d__9))]
	private Task ReadStringIntoBufferAsync(char quote, CancellationToken cancellationToken) { }

	[NullableContext(2)]
	private object ReadStringValue(ReadType readType) { }

	[AsyncStateMachine(typeof(<ReadStringValueAsync>d__37))]
	private Task<Object> ReadStringValueAsync(ReadType readType, CancellationToken cancellationToken) { }

	private bool ReadUnquotedPropertyReportIfDone(char currentChar, int initialPosition) { }

	[NullableContext(2)]
	public void set_ArrayPool(IArrayPool<Char> value) { }

	[CompilerGenerated]
	[NullableContext(2)]
	public void set_PropertyNameTable(JsonNameTable value) { }

	private void SetNewLine(bool hasNextChar) { }

	private void ShiftBufferIfNeeded() { }

	private JsonReaderException ThrowReaderError(string message, Exception ex = null) { }

	private bool ValidIdentifierChar(char value) { }

	private void WriteCharToBuffer(char writeChar, int lastWritePosition, int writeToPosition) { }

}

