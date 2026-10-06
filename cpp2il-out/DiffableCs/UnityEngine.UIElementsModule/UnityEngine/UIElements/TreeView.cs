namespace UnityEngine.UIElements;

public class TreeView : BaseTreeView
{
	internal class UxmlFactory : UxmlFactory<TreeView, UxmlTraits>
	{

		public UxmlFactory() { }

	}

	internal class UxmlTraits : UxmlTraits
	{

		public UxmlTraits() { }

	}

	private Func<VisualElement> m_MakeItem; //Field offset: 0x4D0
	private Action<VisualElement, Int32> m_BindItem; //Field offset: 0x4D8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action<VisualElement, Int32> <unbindItem>k__BackingField; //Field offset: 0x4E0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action<VisualElement> <destroyItem>k__BackingField; //Field offset: 0x4E8

	public Action<VisualElement, Int32> bindItem
	{
		 get { } //Length: 8
		 set { } //Length: 81
	}

	public Action<VisualElement> destroyItem
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public Func<VisualElement> makeItem
	{
		 get { } //Length: 8
		 set { } //Length: 81
	}

	public Action<VisualElement, Int32> unbindItem
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public TreeView() { }

	public TreeView(Func<VisualElement> makeItem, Action<VisualElement, Int32> bindItem) { }

	protected virtual CollectionViewController CreateViewController() { }

	public Action<VisualElement, Int32> get_bindItem() { }

	[CompilerGenerated]
	public Action<VisualElement> get_destroyItem() { }

	public Func<VisualElement> get_makeItem() { }

	[CompilerGenerated]
	public Action<VisualElement, Int32> get_unbindItem() { }

	internal virtual bool HasValidDataAndBindings() { }

	public void set_bindItem(Action<VisualElement, Int32> value) { }

	public void set_makeItem(Func<VisualElement> value) { }

}

