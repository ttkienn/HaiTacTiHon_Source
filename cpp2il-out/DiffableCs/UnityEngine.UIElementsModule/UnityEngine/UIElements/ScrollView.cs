namespace UnityEngine.UIElements;

public class ScrollView : VisualElement
{
	internal enum NestedInteractionKind
	{
		Default = 0,
		StopScrolling = 1,
		ForwardScrolling = 2,
	}

	internal enum TouchScrollBehavior
	{
		Unrestricted = 0,
		Elastic = 1,
		Clamped = 2,
	}

	public enum TouchScrollingResult
	{
		Apply = 0,
		Forward = 1,
		Block = 2,
	}

	internal class UxmlFactory : UxmlFactory<ScrollView, UxmlTraits>
	{

		public UxmlFactory() { }

	}

	internal class UxmlTraits : UxmlTraits
	{
		private UxmlEnumAttributeDescription<ScrollViewMode> m_ScrollViewMode; //Field offset: 0x70
		private UxmlEnumAttributeDescription<NestedInteractionKind> m_NestedInteractionKind; //Field offset: 0x78
		private UxmlBoolAttributeDescription m_ShowHorizontal; //Field offset: 0x80
		private UxmlBoolAttributeDescription m_ShowVertical; //Field offset: 0x88
		private UxmlEnumAttributeDescription<ScrollerVisibility> m_HorizontalScrollerVisibility; //Field offset: 0x90
		private UxmlEnumAttributeDescription<ScrollerVisibility> m_VerticalScrollerVisibility; //Field offset: 0x98
		private UxmlFloatAttributeDescription m_HorizontalPageSize; //Field offset: 0xA0
		private UxmlFloatAttributeDescription m_VerticalPageSize; //Field offset: 0xA8
		private UxmlFloatAttributeDescription m_MouseWheelScrollSize; //Field offset: 0xB0
		private UxmlEnumAttributeDescription<TouchScrollBehavior> m_TouchScrollBehavior; //Field offset: 0xB8
		private UxmlFloatAttributeDescription m_ScrollDecelerationRate; //Field offset: 0xC0
		private UxmlFloatAttributeDescription m_Elasticity; //Field offset: 0xC8
		private UxmlLongAttributeDescription m_ElasticAnimationIntervalMs; //Field offset: 0xD0

		public UxmlTraits() { }

		public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	}

	private static readonly float k_DefaultScrollDecelerationRate; //Field offset: 0x0
	private static readonly float k_DefaultElasticity; //Field offset: 0x4
	private static readonly long k_DefaultElasticAnimationInterval; //Field offset: 0x8
	public static readonly string ussClassName; //Field offset: 0x10
	public static readonly string viewportUssClassName; //Field offset: 0x18
	public static readonly string horizontalVariantViewportUssClassName; //Field offset: 0x20
	public static readonly string verticalVariantViewportUssClassName; //Field offset: 0x28
	public static readonly string verticalHorizontalVariantViewportUssClassName; //Field offset: 0x30
	public static readonly string contentAndVerticalScrollUssClassName; //Field offset: 0x38
	public static readonly string contentUssClassName; //Field offset: 0x40
	public static readonly string horizontalVariantContentUssClassName; //Field offset: 0x48
	public static readonly string verticalVariantContentUssClassName; //Field offset: 0x50
	public static readonly string verticalHorizontalVariantContentUssClassName; //Field offset: 0x58
	public static readonly string hScrollerUssClassName; //Field offset: 0x60
	public static readonly string vScrollerUssClassName; //Field offset: 0x68
	public static readonly string horizontalVariantUssClassName; //Field offset: 0x70
	public static readonly string verticalVariantUssClassName; //Field offset: 0x78
	public static readonly string verticalHorizontalVariantUssClassName; //Field offset: 0x80
	public static readonly string scrollVariantUssClassName; //Field offset: 0x88
	private int m_FirstLayoutPass; //Field offset: 0x3C8
	private ScrollerVisibility m_HorizontalScrollerVisibility; //Field offset: 0x3CC
	private ScrollerVisibility m_VerticalScrollerVisibility; //Field offset: 0x3D0
	private VisualElement m_AttachedRootVisualContainer; //Field offset: 0x3D8
	private float m_SingleLineHeight; //Field offset: 0x3E0
	internal bool m_MouseWheelScrollSizeIsInline; //Field offset: 0x3E4
	private float m_HorizontalPageSize; //Field offset: 0x3E8
	private float m_VerticalPageSize; //Field offset: 0x3EC
	private float m_MouseWheelScrollSize; //Field offset: 0x3F0
	private float m_ScrollDecelerationRate; //Field offset: 0x3F4
	private float k_ScaledPixelsPerPointMultiplier; //Field offset: 0x3F8
	private float k_TouchScrollInertiaBaseTimeInterval; //Field offset: 0x3FC
	private float m_Elasticity; //Field offset: 0x400
	private TouchScrollBehavior m_TouchScrollBehavior; //Field offset: 0x404
	private NestedInteractionKind m_NestedInteractionKind; //Field offset: 0x408
	private long m_ElasticAnimationIntervalMs; //Field offset: 0x410
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private readonly VisualElement <contentViewport>k__BackingField; //Field offset: 0x418
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private readonly Scroller <horizontalScroller>k__BackingField; //Field offset: 0x420
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private readonly Scroller <verticalScroller>k__BackingField; //Field offset: 0x428
	private VisualElement m_ContentContainer; //Field offset: 0x430
	private VisualElement m_ContentAndVerticalScrollContainer; //Field offset: 0x438
	private float previousVerticalTouchScrollTimeStamp; //Field offset: 0x440
	private float previousHorizontalTouchScrollTimeStamp; //Field offset: 0x444
	private float elapsedTimeSinceLastVerticalTouchScroll; //Field offset: 0x448
	private float elapsedTimeSinceLastHorizontalTouchScroll; //Field offset: 0x44C
	private ScrollViewMode m_Mode; //Field offset: 0x450
	private IVisualElementScheduledItem m_ScheduledLayoutPassResetItem; //Field offset: 0x458
	private Vector2 m_StartPosition; //Field offset: 0x460
	private Vector2 m_PointerStartPosition; //Field offset: 0x468
	private Vector2 m_Velocity; //Field offset: 0x470
	private Vector2 m_SpringBackVelocity; //Field offset: 0x478
	private Vector2 m_LowBounds; //Field offset: 0x480
	private Vector2 m_HighBounds; //Field offset: 0x488
	private float m_LastVelocityLerpTime; //Field offset: 0x490
	private bool m_StartedMoving; //Field offset: 0x494
	private bool m_TouchPointerMoveAllowed; //Field offset: 0x495
	private bool m_TouchStoppedVelocity; //Field offset: 0x496
	private VisualElement m_CapturedTarget; //Field offset: 0x498
	private EventCallback<PointerMoveEvent> m_CapturedTargetPointerMoveCallback; //Field offset: 0x4A0
	private EventCallback<PointerUpEvent> m_CapturedTargetPointerUpCallback; //Field offset: 0x4A8
	internal IVisualElementScheduledItem m_PostPointerUpAnimation; //Field offset: 0x4B0

	public virtual VisualElement contentContainer
	{
		 get { } //Length: 10
	}

	public VisualElement contentViewport
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public long elasticAnimationIntervalMs
	{
		 set { } //Length: 260
	}

	public float elasticity
	{
		 get { } //Length: 11
		 set { } //Length: 18
	}

	private bool hasInertia
	{
		private get { } //Length: 20
	}

	public float horizontalPageSize
	{
		 set { } //Length: 15
	}

	public Scroller horizontalScroller
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public ScrollerVisibility horizontalScrollerVisibility
	{
		 get { } //Length: 9
		 set { } //Length: 156
	}

	internal bool isHorizontalScrollDisplayed
	{
		internal get { } //Length: 97
	}

	internal bool isVerticalScrollDisplayed
	{
		internal get { } //Length: 97
	}

	public ScrollViewMode mode
	{
		 get { } //Length: 7
		 set { } //Length: 17
	}

	public float mouseWheelScrollSize
	{
		 get { } //Length: 11
		 set { } //Length: 130
	}

	internal bool needsHorizontal
	{
		internal get { } //Length: 70
	}

	internal bool needsVertical
	{
		internal get { } //Length: 70
	}

	public NestedInteractionKind nestedInteractionKind
	{
		 get { } //Length: 7
		 set { } //Length: 7
	}

	internal float scrollableHeight
	{
		internal get { } //Length: 110
	}

	internal float scrollableWidth
	{
		internal get { } //Length: 110
	}

	public float scrollDecelerationRate
	{
		 get { } //Length: 11
		 set { } //Length: 18
	}

	public Vector2 scrollOffset
	{
		 get { } //Length: 127
		 set { } //Length: 382
	}

	[Obsolete("showHorizontal is obsolete. Use horizontalScrollerVisibility instead")]
	public bool showHorizontal
	{
		 set { } //Length: 28
	}

	[Obsolete("showVertical is obsolete. Use verticalScrollerVisibility instead")]
	public bool showVertical
	{
		 set { } //Length: 28
	}

	public TouchScrollBehavior touchScrollBehavior
	{
		 get { } //Length: 9
		 set { } //Length: 198
	}

	public float verticalPageSize
	{
		 set { } //Length: 15
	}

	public Scroller verticalScroller
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public ScrollerVisibility verticalScrollerVisibility
	{
		 get { } //Length: 9
		 set { } //Length: 165
	}

	private static ScrollView() { }

	public ScrollView(ScrollViewMode scrollViewMode) { }

	public ScrollView() { }

	[CompilerGenerated]
	private void <.ctor>b__126_0(float value) { }

	[CompilerGenerated]
	private void <.ctor>b__126_1(float value) { }

	private void AdjustScrollers() { }

	internal void ApplyScrollInertia() { }

	private bool ApplyTouchScrolling(Vector2 newScrollOffset) { }

	private static float ComputeElasticOffset(float deltaPointer, float initialScrollOffset, float lowLimit, float hardLowLimit, float highLimit, float hardHighLimit) { }

	private void ComputeInitialSpringBackVelocity() { }

	internal TouchScrollingResult ComputeTouchScrolling(Vector2 position) { }

	private void ExecuteElasticSpringAnimation() { }

	public virtual VisualElement get_contentContainer() { }

	[CompilerGenerated]
	public VisualElement get_contentViewport() { }

	public float get_elasticity() { }

	private bool get_hasInertia() { }

	[CompilerGenerated]
	public Scroller get_horizontalScroller() { }

	public ScrollerVisibility get_horizontalScrollerVisibility() { }

	internal bool get_isHorizontalScrollDisplayed() { }

	internal bool get_isVerticalScrollDisplayed() { }

	public ScrollViewMode get_mode() { }

	public float get_mouseWheelScrollSize() { }

	internal bool get_needsHorizontal() { }

	internal bool get_needsVertical() { }

	public NestedInteractionKind get_nestedInteractionKind() { }

	internal float get_scrollableHeight() { }

	internal float get_scrollableWidth() { }

	public float get_scrollDecelerationRate() { }

	public Vector2 get_scrollOffset() { }

	public TouchScrollBehavior get_touchScrollBehavior() { }

	[CompilerGenerated]
	public Scroller get_verticalScroller() { }

	public ScrollerVisibility get_verticalScrollerVisibility() { }

	private float GetDeltaDistance(float viewMin, float viewMax, float childBoundaryMin, float childBoundaryMax) { }

	private float GetXDeltaOffset(VisualElement child) { }

	private float GetYDeltaOffset(VisualElement child) { }

	internal void InitTouchScrolling(Vector2 position) { }

	private void OnAttachToPanel(AttachToPanelEvent evt) { }

	private void OnDetachFromPanel(DetachFromPanelEvent evt) { }

	private void OnGeometryChanged(GeometryChangedEvent evt) { }

	private void OnHorizontalScrollDragElementChanged(GeometryChangedEvent evt) { }

	private void OnPointerCancel(PointerCancelEvent evt) { }

	private void OnPointerCapture(PointerCaptureEvent evt) { }

	private void OnPointerCaptureOut(PointerCaptureOutEvent evt) { }

	private void OnPointerDown(PointerDownEvent evt) { }

	private void OnPointerMove(PointerMoveEvent evt) { }

	private void OnPointerUp(PointerUpEvent evt) { }

	private void OnRootCustomStyleResolved(CustomStyleResolvedEvent evt) { }

	private void OnRootPointerUp(PointerUpEvent evt) { }

	private void OnScrollersGeometryChanged(GeometryChangedEvent evt) { }

	private void OnScrollWheel(WheelEvent evt) { }

	private void OnVerticalScrollDragElementChanged(GeometryChangedEvent evt) { }

	private void PostPointerUpAnimation() { }

	private void ReadSingleLineHeight() { }

	private bool ReleaseScrolling(int pointerId, IEventHandler target) { }

	private void ResetLayoutPass() { }

	private void ScheduleResetLayoutPass() { }

	public void ScrollTo(VisualElement child) { }

	public void set_elasticAnimationIntervalMs(long value) { }

	public void set_elasticity(float value) { }

	public void set_horizontalPageSize(float value) { }

	public void set_horizontalScrollerVisibility(ScrollerVisibility value) { }

	public void set_mode(ScrollViewMode value) { }

	public void set_mouseWheelScrollSize(float value) { }

	public void set_nestedInteractionKind(NestedInteractionKind value) { }

	public void set_scrollDecelerationRate(float value) { }

	public void set_scrollOffset(Vector2 value) { }

	public void set_showHorizontal(bool value) { }

	public void set_showVertical(bool value) { }

	public void set_touchScrollBehavior(TouchScrollBehavior value) { }

	public void set_verticalPageSize(float value) { }

	public void set_verticalScrollerVisibility(ScrollerVisibility value) { }

	private void SetScrollViewMode(ScrollViewMode mode) { }

	private void SpringBack() { }

	internal void UpdateContentViewTransform() { }

	private void UpdateElasticBehaviour() { }

	private void UpdateHorizontalSliderPageSize() { }

	internal void UpdateScrollers(bool displayHorizontal, bool displayVertical) { }

	private void UpdateVerticalSliderPageSize() { }

}

