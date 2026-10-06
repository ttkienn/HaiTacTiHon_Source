namespace UnityEngine.UIElements;

internal struct StartDragArgs
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private readonly string <title>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private readonly DragVisualMode <visualMode>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Hashtable <genericData>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private IEnumerable<Object> <unityObjectReferences>k__BackingField; //Field offset: 0x18

	internal Hashtable genericData
	{
		[CompilerGenerated]
		[IsReadOnly]
		internal get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 13
	}

	public string title
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 4
	}

	internal IEnumerable<Object> unityObjectReferences
	{
		[CompilerGenerated]
		[IsReadOnly]
		internal get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 13
	}

	public DragVisualMode visualMode
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 4
	}

	public StartDragArgs(string title, DragVisualMode visualMode) { }

	[CompilerGenerated]
	[IsReadOnly]
	internal Hashtable get_genericData() { }

	[CompilerGenerated]
	[IsReadOnly]
	public string get_title() { }

	[CompilerGenerated]
	[IsReadOnly]
	internal IEnumerable<Object> get_unityObjectReferences() { }

	[CompilerGenerated]
	[IsReadOnly]
	public DragVisualMode get_visualMode() { }

	[CompilerGenerated]
	private void set_genericData(Hashtable value) { }

	[CompilerGenerated]
	private void set_unityObjectReferences(IEnumerable<Object> value) { }

	public void SetGenericData(string key, object data) { }

}

