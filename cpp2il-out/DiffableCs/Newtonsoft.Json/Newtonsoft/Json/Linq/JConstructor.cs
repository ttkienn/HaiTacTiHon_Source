namespace Newtonsoft.Json.Linq;

[DefaultMember("Item")]
[Nullable(0)]
[NullableContext(1)]
public class JConstructor : JContainer
{
	[CompilerGenerated]
	private struct <LoadAsync>d__2 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		[Nullable(0)]
		public AsyncTaskMethodBuilder<JConstructor> <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public JsonReader reader; //Field offset: 0x20
		public CancellationToken cancellationToken; //Field offset: 0x28
		[Nullable(0)]
		public JsonLoadSettings settings; //Field offset: 0x30
		[Nullable(0)]
		private JConstructor <c>5__2; //Field offset: 0x38
		[Nullable(0)]
		private ConfiguredTaskAwaiter<Boolean> <>u__1; //Field offset: 0x40
		private ConfiguredTaskAwaiter <>u__2; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <WriteToAsync>d__0 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public JsonWriter writer; //Field offset: 0x20
		[Nullable(0)]
		public JConstructor <>4__this; //Field offset: 0x28
		public CancellationToken cancellationToken; //Field offset: 0x30
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1}])]
		public JsonConverter[] converters; //Field offset: 0x38
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x40
		private int <i>5__2; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[Nullable(2)]
	private string _name; //Field offset: 0x58
	private readonly List<JToken> _values; //Field offset: 0x60

	protected virtual IList<JToken> ChildrenTokens
	{
		 get { } //Length: 5
	}

	[Nullable(2)]
	public virtual JToken Item
	{
		 get { } //Length: 301
		 set { } //Length: 317
	}

	[Nullable(2)]
	public string Name
	{
		[NullableContext(2)]
		 get { } //Length: 5
		[NullableContext(2)]
		 set { } //Length: 13
	}

	public virtual JTokenType Type
	{
		 get { } //Length: 6
	}

	internal JConstructor(JConstructor other, JsonCloneSettings settings) { }

	public JConstructor() { }

	public JConstructor(JConstructor other) { }

	public JConstructor(string name) { }

	public JConstructor(string name, Object[] content) { }

	public JConstructor(string name, object content) { }

	internal virtual JToken CloneToken(JsonCloneSettings settings = null) { }

	internal virtual bool DeepEquals(JToken node) { }

	protected virtual IList<JToken> get_ChildrenTokens() { }

	public virtual JToken get_Item(object key) { }

	[NullableContext(2)]
	public string get_Name() { }

	public virtual JTokenType get_Type() { }

	internal virtual int GetDeepHashCode() { }

	[NullableContext(2)]
	internal virtual int IndexOfItem(JToken item) { }

	public static JConstructor Load(JsonReader reader, JsonLoadSettings settings) { }

	public static JConstructor Load(JsonReader reader) { }

	[AsyncStateMachine(typeof(<LoadAsync>d__2))]
	public static Task<JConstructor> LoadAsync(JsonReader reader, JsonLoadSettings settings, CancellationToken cancellationToken = null) { }

	public static Task<JConstructor> LoadAsync(JsonReader reader, CancellationToken cancellationToken = null) { }

	internal virtual void MergeItem(object content, JsonMergeSettings settings) { }

	public virtual void set_Item(object key, JToken value) { }

	[NullableContext(2)]
	public void set_Name(string value) { }

	public virtual void WriteTo(JsonWriter writer, JsonConverter[] converters) { }

	[AsyncStateMachine(typeof(<WriteToAsync>d__0))]
	public virtual Task WriteToAsync(JsonWriter writer, CancellationToken cancellationToken, JsonConverter[] converters) { }

}

