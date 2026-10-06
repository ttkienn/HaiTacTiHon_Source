namespace Newtonsoft.Json.Linq;

[Nullable(0)]
[NullableContext(1)]
public class JRaw : JValue
{
	[CompilerGenerated]
	private struct <CreateAsync>d__0 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		[Nullable(0)]
		public AsyncTaskMethodBuilder<JRaw> <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public JsonReader reader; //Field offset: 0x20
		public CancellationToken cancellationToken; //Field offset: 0x28
		[Nullable(0)]
		private StringWriter <sw>5__2; //Field offset: 0x30
		[Nullable(0)]
		private JsonTextWriter <jsonWriter>5__3; //Field offset: 0x38
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}


	public JRaw(JRaw other) { }

	internal JRaw(JRaw other, JsonCloneSettings settings) { }

	[NullableContext(2)]
	public JRaw(object rawJson) { }

	internal virtual JToken CloneToken(JsonCloneSettings settings) { }

	public static JRaw Create(JsonReader reader) { }

	[AsyncStateMachine(typeof(<CreateAsync>d__0))]
	public static Task<JRaw> CreateAsync(JsonReader reader, CancellationToken cancellationToken = null) { }

}

