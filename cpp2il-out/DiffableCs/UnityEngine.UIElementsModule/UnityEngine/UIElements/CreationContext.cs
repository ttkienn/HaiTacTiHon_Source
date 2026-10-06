namespace UnityEngine.UIElements;

public struct CreationContext : IEquatable<CreationContext>
{
	public static readonly CreationContext Default; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private VisualElement <target>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private VisualTreeAsset <visualTreeAsset>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Dictionary<String, VisualElement> <slotInsertionPoints>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private List<AttributeOverride> <attributeOverrides>k__BackingField; //Field offset: 0x18

	internal List<AttributeOverride> attributeOverrides
	{
		[CompilerGenerated]
		[IsReadOnly]
		internal get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 13
	}

	public private Dictionary<String, VisualElement> slotInsertionPoints
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 13
	}

	public private VisualElement target
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private VisualTreeAsset visualTreeAsset
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 13
	}

	private static CreationContext() { }

	internal CreationContext(Dictionary<String, VisualElement> slotInsertionPoints, VisualTreeAsset vta, VisualElement target) { }

	internal CreationContext(Dictionary<String, VisualElement> slotInsertionPoints, List<AttributeOverride> attributeOverrides, VisualTreeAsset vta, VisualElement target) { }

	public virtual bool Equals(object obj) { }

	public override bool Equals(CreationContext other) { }

	[CompilerGenerated]
	[IsReadOnly]
	internal List<AttributeOverride> get_attributeOverrides() { }

	[CompilerGenerated]
	[IsReadOnly]
	public Dictionary<String, VisualElement> get_slotInsertionPoints() { }

	[CompilerGenerated]
	[IsReadOnly]
	public VisualElement get_target() { }

	[CompilerGenerated]
	[IsReadOnly]
	public VisualTreeAsset get_visualTreeAsset() { }

	public virtual int GetHashCode() { }

	[CompilerGenerated]
	private void set_attributeOverrides(List<AttributeOverride> value) { }

	[CompilerGenerated]
	private void set_slotInsertionPoints(Dictionary<String, VisualElement> value) { }

	[CompilerGenerated]
	private void set_target(VisualElement value) { }

	[CompilerGenerated]
	private void set_visualTreeAsset(VisualTreeAsset value) { }

}

