namespace Newtonsoft.Json.Linq;

[Nullable(0)]
[NullableContext(1)]
public class JProperty : JContainer
{
	[CompilerGenerated]
	private struct <LoadAsync>d__4 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		[Nullable(0)]
		public AsyncTaskMethodBuilder<JProperty> <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public JsonReader reader; //Field offset: 0x20
		public CancellationToken cancellationToken; //Field offset: 0x28
		[Nullable(0)]
		public JsonLoadSettings settings; //Field offset: 0x30
		[Nullable(0)]
		private JProperty <p>5__2; //Field offset: 0x38
		[Nullable(0)]
		private ConfiguredTaskAwaiter<Boolean> <>u__1; //Field offset: 0x40
		private ConfiguredTaskAwaiter <>u__2; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <WriteToAsync>d__1 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public Task task; //Field offset: 0x20
		[Nullable(0)]
		public JProperty <>4__this; //Field offset: 0x28
		[Nullable(0)]
		public JsonWriter writer; //Field offset: 0x30
		public CancellationToken cancellationToken; //Field offset: 0x38
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1}])]
		public JsonConverter[] converters; //Field offset: 0x40
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[DefaultMember("Item")]
	[Nullable(0)]
	private class JPropertyList : IList<JToken>, ICollection<JToken>, IEnumerable<JToken>, IEnumerable
	{
		[CompilerGenerated]
		private sealed class <GetEnumerator>d__1 : IEnumerator<JToken>, IEnumerator, IDisposable
		{
			private int <>1__state; //Field offset: 0x10
			private JToken <>2__current; //Field offset: 0x18
			[Nullable(0)]
			public JPropertyList <>4__this; //Field offset: 0x20

			private override JToken System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken>.Current
			{
				[DebuggerHidden]
				private get { } //Length: 5
			}

			private override object System.Collections.IEnumerator.Current
			{
				[DebuggerHidden]
				private get { } //Length: 5
			}

			[DebuggerHidden]
			public <GetEnumerator>d__1(int <>1__state) { }

			private override bool MoveNext() { }

			[DebuggerHidden]
			private override JToken System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken>.get_Current() { }

			[DebuggerHidden]
			private override object System.Collections.IEnumerator.get_Current() { }

			[DebuggerHidden]
			private override void System.Collections.IEnumerator.Reset() { }

			[DebuggerHidden]
			private override void System.IDisposable.Dispose() { }

		}

		[Nullable(2)]
		internal JToken _token; //Field offset: 0x10

		public override int Count
		{
			 get { } //Length: 10
		}

		public override bool IsReadOnly
		{
			 get { } //Length: 3
		}

		public override JToken Item
		{
			 get { } //Length: 83
			 set { } //Length: 94
		}

		public JPropertyList() { }

		public override void Add(JToken item) { }

		public override void Clear() { }

		public override bool Contains(JToken item) { }

		public override void CopyTo(JToken[] array, int arrayIndex) { }

		public override int get_Count() { }

		public override bool get_IsReadOnly() { }

		public override JToken get_Item(int index) { }

		[IteratorStateMachine(typeof(<GetEnumerator>d__1))]
		public override IEnumerator<JToken> GetEnumerator() { }

		public override int IndexOf(JToken item) { }

		public override void Insert(int index, JToken item) { }

		public override bool Remove(JToken item) { }

		public override void RemoveAt(int index) { }

		public override void set_Item(int index, JToken value) { }

		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	}

	private readonly JPropertyList _content; //Field offset: 0x58
	private readonly string _name; //Field offset: 0x60

	protected virtual IList<JToken> ChildrenTokens
	{
		 get { } //Length: 5
	}

	public string Name
	{
		[DebuggerStepThrough]
		 get { } //Length: 5
	}

	public virtual JTokenType Type
	{
		[DebuggerStepThrough]
		 get { } //Length: 6
	}

	public JToken Value
	{
		[DebuggerStepThrough]
		 get { } //Length: 27
		 set { } //Length: 137
	}

	public JProperty(string name, object content) { }

	public JProperty(string name, Object[] content) { }

	public JProperty(JProperty other) { }

	internal JProperty(JProperty other, JsonCloneSettings settings) { }

	internal JProperty(string name) { }

	internal virtual void ClearItems() { }

	internal virtual JToken CloneToken(JsonCloneSettings settings) { }

	[NullableContext(2)]
	internal virtual bool ContainsItem(JToken item) { }

	internal virtual bool DeepEquals(JToken node) { }

	protected virtual IList<JToken> get_ChildrenTokens() { }

	[DebuggerStepThrough]
	public string get_Name() { }

	[DebuggerStepThrough]
	public virtual JTokenType get_Type() { }

	[DebuggerStepThrough]
	public JToken get_Value() { }

	internal virtual int GetDeepHashCode() { }

	internal virtual JToken GetItem(int index) { }

	[NullableContext(2)]
	internal virtual int IndexOfItem(JToken item) { }

	[NullableContext(2)]
	internal virtual bool InsertItem(int index, JToken item, bool skipParentCheck, bool copyAnnotations) { }

	public static JProperty Load(JsonReader reader) { }

	public static JProperty Load(JsonReader reader, JsonLoadSettings settings) { }

	[AsyncStateMachine(typeof(<LoadAsync>d__4))]
	public static Task<JProperty> LoadAsync(JsonReader reader, JsonLoadSettings settings, CancellationToken cancellationToken = null) { }

	public static Task<JProperty> LoadAsync(JsonReader reader, CancellationToken cancellationToken = null) { }

	internal virtual void MergeItem(object content, JsonMergeSettings settings) { }

	[NullableContext(2)]
	internal virtual bool RemoveItem(JToken item) { }

	internal virtual void RemoveItemAt(int index) { }

	public void set_Value(JToken value) { }

	[NullableContext(2)]
	internal virtual void SetItem(int index, JToken item) { }

	public virtual void WriteTo(JsonWriter writer, JsonConverter[] converters) { }

	[AsyncStateMachine(typeof(<WriteToAsync>d__1))]
	private Task WriteToAsync(Task task, JsonWriter writer, CancellationToken cancellationToken, JsonConverter[] converters) { }

	public virtual Task WriteToAsync(JsonWriter writer, CancellationToken cancellationToken, JsonConverter[] converters) { }

	private Task WriteValueAsync(JsonWriter writer, CancellationToken cancellationToken, JsonConverter[] converters) { }

}

