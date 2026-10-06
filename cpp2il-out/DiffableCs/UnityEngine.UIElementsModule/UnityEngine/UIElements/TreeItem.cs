namespace UnityEngine.UIElements;

[IsReadOnly]
internal struct TreeItem
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private readonly int <id>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private readonly int <parentId>k__BackingField; //Field offset: 0x4
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private readonly IEnumerable<Int32> <childrenIds>k__BackingField; //Field offset: 0x8

	public IEnumerable<Int32> childrenIds
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public bool hasChildren
	{
		 get { } //Length: 74
	}

	public int id
	{
		[CompilerGenerated]
		 get { } //Length: 3
	}

	public int parentId
	{
		[CompilerGenerated]
		 get { } //Length: 4
	}

	public TreeItem(int id, int parentId = -1, IEnumerable<Int32> childrenIds = null) { }

	[CompilerGenerated]
	public IEnumerable<Int32> get_childrenIds() { }

	public bool get_hasChildren() { }

	[CompilerGenerated]
	public int get_id() { }

	[CompilerGenerated]
	public int get_parentId() { }

}

