namespace UnityEngine.UIElements;

public class GenericDropdownMenu : IGenericMenu
{
	[CompilerGenerated]
	private struct <>c__DisplayClass39_0
	{
		public GenericDropdownMenu <>4__this; //Field offset: 0x0
		public int selectedIndex; //Field offset: 0x8

	}

	public class MenuItem
	{
		public string name; //Field offset: 0x10
		public VisualElement element; //Field offset: 0x18
		public Action action; //Field offset: 0x20
		public Action<Object> actionUserData; //Field offset: 0x28

		public MenuItem() { }

	}

	public static readonly string ussClassName; //Field offset: 0x0
	public static readonly string itemUssClassName; //Field offset: 0x8
	public static readonly string labelUssClassName; //Field offset: 0x10
	public static readonly string containerInnerUssClassName; //Field offset: 0x18
	public static readonly string containerOuterUssClassName; //Field offset: 0x20
	public static readonly string checkmarkUssClassName; //Field offset: 0x28
	public static readonly string separatorUssClassName; //Field offset: 0x30
	private List<MenuItem> m_Items; //Field offset: 0x10
	private VisualElement m_MenuContainer; //Field offset: 0x18
	private VisualElement m_OuterContainer; //Field offset: 0x20
	private ScrollView m_ScrollView; //Field offset: 0x28
	private VisualElement m_PanelRootVisualContainer; //Field offset: 0x30
	private VisualElement m_TargetElement; //Field offset: 0x38
	private Rect m_DesiredRect; //Field offset: 0x40
	private KeyboardNavigationManipulator m_NavigationManipulator; //Field offset: 0x50
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <isSingleSelectionDropdown>k__BackingField; //Field offset: 0x58
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <closeOnParentResize>k__BackingField; //Field offset: 0x59
	private Vector2 m_MousePosition; //Field offset: 0x5C

	internal bool closeOnParentResize
	{
		[CompilerGenerated]
		internal get { } //Length: 5
		[CompilerGenerated]
		internal set { } //Length: 4
	}

	public VisualElement contentContainer
	{
		 get { } //Length: 42
	}

	internal bool isSingleSelectionDropdown
	{
		[CompilerGenerated]
		internal get { } //Length: 5
		[CompilerGenerated]
		internal set { } //Length: 4
	}

	private static GenericDropdownMenu() { }

	public GenericDropdownMenu() { }

	[CompilerGenerated]
	private void <Apply>g__UpdateSelectionDown|39_0(int newIndex, ref <>c__DisplayClass39_0 unnamed_param_1) { }

	[CompilerGenerated]
	private void <Apply>g__UpdateSelectionUp|39_1(int newIndex, ref <>c__DisplayClass39_0 unnamed_param_1) { }

	private MenuItem AddItem(string itemName, bool isChecked, bool isEnabled, object data = null) { }

	public override void AddItem(string itemName, bool isChecked, Action<Object> action, object data) { }

	public override void AddItem(string itemName, bool isChecked, Action action) { }

	public override void AddSeparator(string path) { }

	private void Apply(KeyboardNavigationOperation op, EventBase sourceEvent) { }

	private bool Apply(KeyboardNavigationOperation op) { }

	private void ChangeSelectedIndex(int newIndex, int previousIndex) { }

	public override void DropDown(Rect position, VisualElement targetElement = null, bool anchored = false) { }

	private void EnsureVisibilityInParent() { }

	[CompilerGenerated]
	internal bool get_closeOnParentResize() { }

	public VisualElement get_contentContainer() { }

	[CompilerGenerated]
	internal bool get_isSingleSelectionDropdown() { }

	private int GetSelectedIndex() { }

	private void Hide(bool giveFocusBack = false) { }

	private void OnAttachToPanel(AttachToPanelEvent evt) { }

	private void OnContainerGeometryChanged(GeometryChangedEvent evt) { }

	private void OnDetachFromPanel(DetachFromPanelEvent evt) { }

	private void OnFocusOut(FocusOutEvent evt) { }

	private void OnParentResized(GeometryChangedEvent evt) { }

	private void OnPointerDown(PointerDownEvent evt) { }

	private void OnPointerMove(PointerMoveEvent evt) { }

	private void OnPointerUp(PointerUpEvent evt) { }

	private void OnTargetElementDetachFromPanel(DetachFromPanelEvent evt) { }

	[CompilerGenerated]
	internal void set_closeOnParentResize(bool value) { }

	[CompilerGenerated]
	internal void set_isSingleSelectionDropdown(bool value) { }

	private void UpdateSelection(VisualElement target) { }

}

