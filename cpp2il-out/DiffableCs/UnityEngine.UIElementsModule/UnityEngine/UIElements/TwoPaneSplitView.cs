namespace UnityEngine.UIElements;

public class TwoPaneSplitView : VisualElement
{
	internal class UxmlFactory : UxmlFactory<TwoPaneSplitView, UxmlTraits>
	{

		public UxmlFactory() { }

	}

	internal class UxmlTraits : UxmlTraits
	{
		private UxmlIntAttributeDescription m_FixedPaneIndex; //Field offset: 0x70
		private UxmlIntAttributeDescription m_FixedPaneInitialDimension; //Field offset: 0x78
		private UxmlEnumAttributeDescription<TwoPaneSplitViewOrientation> m_Orientation; //Field offset: 0x80

		public UxmlTraits() { }

		public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	}

	private static readonly string s_UssClassName; //Field offset: 0x0
	private static readonly string s_ContentContainerClassName; //Field offset: 0x8
	private static readonly string s_HandleDragLineClassName; //Field offset: 0x10
	private static readonly string s_HandleDragLineVerticalClassName; //Field offset: 0x18
	private static readonly string s_HandleDragLineHorizontalClassName; //Field offset: 0x20
	private static readonly string s_HandleDragLineAnchorClassName; //Field offset: 0x28
	private static readonly string s_HandleDragLineAnchorVerticalClassName; //Field offset: 0x30
	private static readonly string s_HandleDragLineAnchorHorizontalClassName; //Field offset: 0x38
	private static readonly string s_VerticalClassName; //Field offset: 0x40
	private static readonly string s_HorizontalClassName; //Field offset: 0x48
	private VisualElement m_LeftPane; //Field offset: 0x3C8
	private VisualElement m_RightPane; //Field offset: 0x3D0
	private VisualElement m_FixedPane; //Field offset: 0x3D8
	private VisualElement m_FlexedPane; //Field offset: 0x3E0
	[SerializeField]
	private float m_FixedPaneDimension; //Field offset: 0x3E8
	private VisualElement m_DragLine; //Field offset: 0x3F0
	private VisualElement m_DragLineAnchor; //Field offset: 0x3F8
	private bool m_CollapseMode; //Field offset: 0x400
	private bool m_CollapseChildCalledBeforeSetupComplete; //Field offset: 0x401
	private int m_CollapsedChildIndex; //Field offset: 0x404
	private VisualElement m_Content; //Field offset: 0x408
	private TwoPaneSplitViewOrientation m_Orientation; //Field offset: 0x410
	private int m_FixedPaneIndex; //Field offset: 0x414
	private float m_FixedPaneInitialDimension; //Field offset: 0x418
	internal TwoPaneSplitViewResizer m_Resizer; //Field offset: 0x420

	public virtual VisualElement contentContainer
	{
		 get { } //Length: 10
	}

	internal VisualElement dragLine
	{
		internal get { } //Length: 8
	}

	public VisualElement fixedPane
	{
		 get { } //Length: 8
	}

	internal float fixedPaneDimension
	{
		internal get { } //Length: 52
		internal set { } //Length: 27
	}

	public int fixedPaneIndex
	{
		 get { } //Length: 7
	}

	public VisualElement flexedPane
	{
		 get { } //Length: 8
	}

	public TwoPaneSplitViewOrientation orientation
	{
		 get { } //Length: 7
	}

	private static TwoPaneSplitView() { }

	public TwoPaneSplitView() { }

	public void CollapseChild(int index) { }

	public virtual VisualElement get_contentContainer() { }

	internal VisualElement get_dragLine() { }

	public VisualElement get_fixedPane() { }

	internal float get_fixedPaneDimension() { }

	public int get_fixedPaneIndex() { }

	public VisualElement get_flexedPane() { }

	public TwoPaneSplitViewOrientation get_orientation() { }

	private void IdentifyLeftAndRightPane() { }

	internal void Init(int fixedPaneIndex, float fixedPaneInitialDimension, TwoPaneSplitViewOrientation orientation) { }

	private void OnAnchorPostDisplaySetup(GeometryChangedEvent evt) { }

	private void OnPostDisplaySetup(GeometryChangedEvent evt) { }

	private void OnSizeChange(GeometryChangedEvent evt) { }

	internal virtual void OnViewDataReady() { }

	private void PostDisplaySetup() { }

	private void ReplacePanesBasedOnAnchor() { }

	internal void set_fixedPaneDimension(float value) { }

	private void SetDragLineOffset(float offset) { }

	private void SetFixedPaneDimension(float dimension) { }

	private void UpdateLayout(bool updateFixedPane, bool updateDragLine) { }

}

