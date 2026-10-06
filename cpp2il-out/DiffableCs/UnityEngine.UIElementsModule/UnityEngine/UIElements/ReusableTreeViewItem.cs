namespace UnityEngine.UIElements;

internal class ReusableTreeViewItem : ReusableCollectionItem
{
	private Toggle m_Toggle; //Field offset: 0x48
	private VisualElement m_Container; //Field offset: 0x50
	private VisualElement m_IndentElement; //Field offset: 0x58
	private VisualElement m_BindableContainer; //Field offset: 0x60
	private VisualElement m_Checkmark; //Field offset: 0x68
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action<PointerUpEvent> onPointerUp; //Field offset: 0x70
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action<ChangeEvent`1<Boolean>> onToggleValueChanged; //Field offset: 0x78
	private int m_Depth; //Field offset: 0x80
	private float m_IndentWidth; //Field offset: 0x84
	private EventCallback<PointerUpEvent> m_PointerUpCallback; //Field offset: 0x88
	private EventCallback<ChangeEvent`1<Boolean>> m_ToggleValueChangedCallback; //Field offset: 0x90
	private EventCallback<GeometryChangedEvent> m_ToggleGeometryChangedCallback; //Field offset: 0x98

	public event Action<PointerUpEvent> onPointerUp
	{
		[CompilerGenerated]
		 add { } //Length: 172
		[CompilerGenerated]
		 remove { } //Length: 172
	}

	public event Action<ChangeEvent`1<Boolean>> onToggleValueChanged
	{
		[CompilerGenerated]
		 add { } //Length: 172
		[CompilerGenerated]
		 remove { } //Length: 172
	}

	public virtual VisualElement rootElement
	{
		 get { } //Length: 14
	}

	public ReusableTreeViewItem() { }

	[CompilerGenerated]
	public void add_onPointerUp(Action<PointerUpEvent> value) { }

	[CompilerGenerated]
	public void add_onToggleValueChanged(Action<ChangeEvent`1<Boolean>> value) { }

	public virtual void DetachElement() { }

	public virtual VisualElement get_rootElement() { }

	public void Indent(int depth) { }

	public virtual void Init(VisualElement item) { }

	protected void InitExpandHierarchy(VisualElement root, VisualElement item) { }

	private void OnPointerUp(PointerUpEvent evt) { }

	private void OnToggleGeometryChanged(GeometryChangedEvent evt) { }

	private void OnToggleValueChanged(ChangeEvent<Boolean> evt) { }

	public virtual void PreAttachElement() { }

	[CompilerGenerated]
	public void remove_onPointerUp(Action<PointerUpEvent> value) { }

	[CompilerGenerated]
	public void remove_onToggleValueChanged(Action<ChangeEvent`1<Boolean>> value) { }

	public void SetExpandedWithoutNotify(bool expanded) { }

	public void SetToggleVisibility(bool visible) { }

	private void UpdateIndentLayout() { }

}

