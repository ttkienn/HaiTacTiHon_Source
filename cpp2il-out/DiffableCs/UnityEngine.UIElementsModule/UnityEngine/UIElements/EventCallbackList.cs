namespace UnityEngine.UIElements;

[DefaultMember("Item")]
internal class EventCallbackList
{
	private List<EventCallbackFunctorBase> m_List; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private int <trickleDownCallbackCount>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private int <bubbleUpCallbackCount>k__BackingField; //Field offset: 0x1C

	public private int bubbleUpCallbackCount
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public int Count
	{
		 get { } //Length: 60
	}

	public EventCallbackFunctorBase Item
	{
		 get { } //Length: 81
	}

	public private int trickleDownCallbackCount
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public EventCallbackList() { }

	public EventCallbackList(EventCallbackList source) { }

	public void Add(EventCallbackFunctorBase item) { }

	public void AddRange(EventCallbackList list) { }

	public void Clear() { }

	public bool Contains(long eventTypeId, Delegate callback, CallbackPhase phase) { }

	public EventCallbackFunctorBase Find(long eventTypeId, Delegate callback, CallbackPhase phase) { }

	[CompilerGenerated]
	public int get_bubbleUpCallbackCount() { }

	public int get_Count() { }

	public EventCallbackFunctorBase get_Item(int i) { }

	[CompilerGenerated]
	public int get_trickleDownCallbackCount() { }

	public bool Remove(long eventTypeId, Delegate callback, CallbackPhase phase) { }

	[CompilerGenerated]
	private void set_bubbleUpCallbackCount(int value) { }

	[CompilerGenerated]
	private void set_trickleDownCallbackCount(int value) { }

}

