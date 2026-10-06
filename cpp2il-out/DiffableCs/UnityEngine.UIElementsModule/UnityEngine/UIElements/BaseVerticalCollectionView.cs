namespace UnityEngine.UIElements;

public abstract class BaseVerticalCollectionView : BindableElement, ISerializationCallbackReceiver
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass162_0
	{
		public int id; //Field offset: 0x10

		public <>c__DisplayClass162_0() { }

		internal bool <GetRootElementForId>b__0(ReusableCollectionItem t) { }

	}

	[CompilerGenerated]
	private struct <>c__DisplayClass172_0
	{
		public bool selectedIndicesChanged; //Field offset: 0x0
		public BaseVerticalCollectionView <>4__this; //Field offset: 0x8
		public int previousSelectionCount; //Field offset: 0x10

	}

	[CompilerGenerated]
	private struct <>c__DisplayClass183_0
	{
		public BaseVerticalCollectionView <>4__this; //Field offset: 0x0
		public bool shiftKey; //Field offset: 0x8

	}

	[CompilerGenerated]
	private sealed class <get_selectedItems>d__72 : IEnumerable<Object>, IEnumerable, IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		public BaseVerticalCollectionView <>4__this; //Field offset: 0x28
		private Enumerator<Int32> <>s__1; //Field offset: 0x30
		private int <index>5__2; //Field offset: 0x48
		private object <item>5__3; //Field offset: 0x50

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
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
		public <get_selectedItems>d__72(int <>1__state) { }

		private void <>m__Finally1() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator<Object> System.Collections.Generic.IEnumerable<System.Object>.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	private class Selection
	{
		private readonly HashSet<Int32> m_IndexLookup; //Field offset: 0x10
		private readonly HashSet<Int32> m_IdLookup; //Field offset: 0x18
		private int m_MinIndex; //Field offset: 0x20
		private int m_MaxIndex; //Field offset: 0x24
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		private List<Int32> <selectedIds>k__BackingField; //Field offset: 0x28
		public readonly List<Int32> indices; //Field offset: 0x30
		public readonly Dictionary<Int32, Object> items; //Field offset: 0x38

		public int capacity
		{
			 get { } //Length: 68
			 set { } //Length: 142
		}

		public int idCount
		{
			 get { } //Length: 60
		}

		public int indexCount
		{
			 get { } //Length: 60
		}

		public int maxIndex
		{
			 get { } //Length: 44
		}

		public int minIndex
		{
			 get { } //Length: 44
		}

		public List<Int32> selectedIds
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			 set { } //Length: 13
		}

		public Selection() { }

		public void AddId(int id) { }

		public void AddIndex(int index, object obj) { }

		public void Clear() { }

		public void ClearIds() { }

		public void ClearIndices() { }

		public void ClearItems() { }

		public bool ContainsId(int id) { }

		public bool ContainsIndex(int index) { }

		public int FirstIndex() { }

		public int get_capacity() { }

		public int get_idCount() { }

		public int get_indexCount() { }

		public int get_maxIndex() { }

		public int get_minIndex() { }

		[CompilerGenerated]
		public List<Int32> get_selectedIds() { }

		public void RemoveId(int id) { }

		public void set_capacity(int value) { }

		[CompilerGenerated]
		public void set_selectedIds(List<Int32> value) { }

		public bool TryRemove(int index) { }

	}

	internal class UxmlTraits : UxmlTraits
	{
		private readonly UxmlIntAttributeDescription m_FixedItemHeight; //Field offset: 0x78
		private readonly UxmlEnumAttributeDescription<CollectionVirtualizationMethod> m_VirtualizationMethod; //Field offset: 0x80
		private readonly UxmlBoolAttributeDescription m_ShowBorder; //Field offset: 0x88
		private readonly UxmlEnumAttributeDescription<SelectionType> m_SelectionType; //Field offset: 0x90
		private readonly UxmlEnumAttributeDescription<AlternatingRowBackground> m_ShowAlternatingRowBackgrounds; //Field offset: 0x98
		private readonly UxmlBoolAttributeDescription m_Reorderable; //Field offset: 0xA0
		private readonly UxmlBoolAttributeDescription m_HorizontalScrollingEnabled; //Field offset: 0xA8

		public UxmlTraits() { }

		public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	}

	private static readonly ProfilerMarker k_RefreshMarker; //Field offset: 0x0
	private static readonly ProfilerMarker k_RebuildMarker; //Field offset: 0x8
	private static readonly List<ReusableCollectionItem> k_EmptyItems; //Field offset: 0x10
	internal static readonly int s_DefaultItemHeight; //Field offset: 0x18
	internal static CustomStyleProperty<Int32> s_ItemHeightProperty; //Field offset: 0x20
	public static readonly string ussClassName; //Field offset: 0x28
	public static readonly string borderUssClassName; //Field offset: 0x30
	public static readonly string itemUssClassName; //Field offset: 0x38
	public static readonly string dragHoverBarUssClassName; //Field offset: 0x40
	public static readonly string dragHoverMarkerUssClassName; //Field offset: 0x48
	public static readonly string itemDragHoverUssClassName; //Field offset: 0x50
	public static readonly string itemSelectedVariantUssClassName; //Field offset: 0x58
	public static readonly string itemAlternativeBackgroundUssClassName; //Field offset: 0x60
	public static readonly string listScrollViewUssClassName; //Field offset: 0x68
	internal static readonly string backgroundFillUssClassName; //Field offset: 0x70
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action<IEnumerable`1<Object>> itemsChosen; //Field offset: 0x3D8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action<IEnumerable`1<Object>> selectionChanged; //Field offset: 0x3E0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action<IEnumerable`1<Int32>> selectedIndicesChanged; //Field offset: 0x3E8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action<Int32, Int32> itemIndexChanged; //Field offset: 0x3F0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action itemsSourceChanged; //Field offset: 0x3F8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action selectionNotChanged; //Field offset: 0x400
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Func<CanStartDragArgs, Boolean> canStartDrag; //Field offset: 0x408
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Func<SetupDragAndDropArgs, StartDragArgs> setupDragAndDrop; //Field offset: 0x410
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Func<HandleDragAndDropArgs, DragVisualMode> dragAndDropUpdate; //Field offset: 0x418
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Func<HandleDragAndDropArgs, DragVisualMode> handleDrop; //Field offset: 0x420
	private SelectionType m_SelectionType; //Field offset: 0x428
	private bool m_HorizontalScrollingEnabled; //Field offset: 0x42C
	[SerializeField]
	private AlternatingRowBackground m_ShowAlternatingRowBackgrounds; //Field offset: 0x430
	internal float m_FixedItemHeight; //Field offset: 0x434
	internal bool m_ItemHeightIsInline; //Field offset: 0x438
	private CollectionVirtualizationMethod m_VirtualizationMethod; //Field offset: 0x43C
	private readonly ScrollView m_ScrollView; //Field offset: 0x440
	private CollectionViewController m_ViewController; //Field offset: 0x448
	private CollectionVirtualizationController m_VirtualizationController; //Field offset: 0x450
	private KeyboardNavigationManipulator m_NavigationManipulator; //Field offset: 0x458
	[SerializeField]
	internal SerializedVirtualizationData serializedVirtualizationData; //Field offset: 0x460
	[SerializeField]
	private readonly List<Int32> m_SelectedIds; //Field offset: 0x468
	private readonly Selection m_Selection; //Field offset: 0x470
	private float m_LastHeight; //Field offset: 0x478
	private bool m_IsRangeSelectionDirectionUp; //Field offset: 0x47C
	private ListViewDragger m_Dragger; //Field offset: 0x480
	private Action<Int32, Int32> m_ItemIndexChangedCallback; //Field offset: 0x488
	private Action m_ItemsSourceChangedCallback; //Field offset: 0x490
	internal IVisualElementScheduledItem m_RebuildScheduled; //Field offset: 0x498
	private Vector3 m_TouchDownPosition; //Field offset: 0x4A0
	private long m_LastPointerDownTimeStamp; //Field offset: 0x4B0
	private int m_PointerDownCount; //Field offset: 0x4B8

	internal IEnumerable<ReusableCollectionItem> activeItems
	{
		internal get { } //Length: 121
	}

	public virtual VisualElement contentContainer
	{
		 get { } //Length: 3
	}

	internal ListViewDragger dragger
	{
		internal get { } //Length: 8
	}

	public float fixedItemHeight
	{
		 get { } //Length: 9
		 set { } //Length: 248
	}

	public bool horizontalScrollingEnabled
	{
		 set { } //Length: 99
	}

	public IList itemsSource
	{
		 get { } //Length: 35
		 set { } //Length: 121
	}

	internal float lastHeight
	{
		internal get { } //Length: 9
	}

	public bool reorderable
	{
		 get { } //Length: 141
		 set { } //Length: 147
	}

	internal ScrollView scrollView
	{
		internal get { } //Length: 8
	}

	public IEnumerable<Int32> selectedIds
	{
		 get { } //Length: 30
	}

	public int selectedIndex
	{
		 get { } //Length: 187
		 set { } //Length: 8
	}

	public IEnumerable<Int32> selectedIndices
	{
		 get { } //Length: 30
	}

	public IEnumerable<Object> selectedItems
	{
		[IteratorStateMachine(typeof(<get_selectedItems>d__72))]
		 get { } //Length: 113
	}

	public SelectionType selectionType
	{
		 get { } //Length: 9
		 set { } //Length: 144
	}

	public AlternatingRowBackground showAlternatingRowBackgrounds
	{
		 get { } //Length: 9
		 set { } //Length: 22
	}

	public bool showBorder
	{
		 set { } //Length: 128
	}

	public CollectionViewController viewController
	{
		 get { } //Length: 8
	}

	internal CollectionVirtualizationController virtualizationController
	{
		internal get { } //Length: 64
	}

	public CollectionVirtualizationMethod virtualizationMethod
	{
		 get { } //Length: 84
		 set { } //Length: 65
	}

	private static BaseVerticalCollectionView() { }

	public BaseVerticalCollectionView() { }

	public BaseVerticalCollectionView(IList itemsSource, float itemHeight = -1) { }

	[CompilerGenerated]
	private void <.ctor>b__159_0(float v) { }

	[CompilerGenerated]
	private void <Apply>g__HandleSelectionAndScroll|183_0(int index, ref <>c__DisplayClass183_0 unnamed_param_1) { }

	[CompilerGenerated]
	private void <RefreshSelection>g__NotifyIfChanged|172_0(ref <>c__DisplayClass172_0 unnamed_param_0) { }

	public void AddToSelection(int index) { }

	internal void AddToSelection(IList<Int32> indexes) { }

	private void AddToSelectionWithoutValidation(int index) { }

	private bool Apply(KeyboardNavigationOperation op, bool shiftKey, bool altKey) { }

	private void Apply(KeyboardNavigationOperation op, EventBase sourceEvent) { }

	public void ClearSelection() { }

	private void ClearSelectionWithoutValidation() { }

	internal abstract ICollectionDragAndDropController CreateDragAndDropController() { }

	internal override ListViewDragger CreateDragger() { }

	protected abstract CollectionViewController CreateViewController() { }

	internal void CreateVirtualizationController() { }

	override void CreateVirtualizationController() { }

	internal void DoRangeSelection(int rangeSelectionFinalIndex) { }

	private void DoSelect(Vector2 localPosition, int clickCount, bool actionKey, bool shiftKey) { }

	[EventInterest(new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(PointerUpEvent), typeof(FocusEvent), typeof(NavigationSubmitEvent), typeof(BlurEvent)}])]
	protected virtual void ExecuteDefaultAction(EventBase evt) { }

	internal IEnumerable<ReusableCollectionItem> get_activeItems() { }

	public virtual VisualElement get_contentContainer() { }

	internal ListViewDragger get_dragger() { }

	public float get_fixedItemHeight() { }

	public IList get_itemsSource() { }

	internal float get_lastHeight() { }

	public bool get_reorderable() { }

	internal ScrollView get_scrollView() { }

	public IEnumerable<Int32> get_selectedIds() { }

	public int get_selectedIndex() { }

	public IEnumerable<Int32> get_selectedIndices() { }

	[IteratorStateMachine(typeof(<get_selectedItems>d__72))]
	public IEnumerable<Object> get_selectedItems() { }

	public SelectionType get_selectionType() { }

	public AlternatingRowBackground get_showAlternatingRowBackgrounds() { }

	public CollectionViewController get_viewController() { }

	internal CollectionVirtualizationController get_virtualizationController() { }

	public CollectionVirtualizationMethod get_virtualizationMethod() { }

	internal CollectionViewController GetOrCreateViewController() { }

	internal CollectionVirtualizationController GetOrCreateVirtualizationController() { }

	public VisualElement GetRootElementForId(int id) { }

	override bool HandleItemNavigation(bool moveIn, bool altKey) { }

	internal bool HasCanStartDrag() { }

	internal override bool HasValidDataAndBindings() { }

	internal void InitializeDragAndDropController(bool enableReordering) { }

	private bool MatchesExistingSelection(IEnumerable<Int32> indices) { }

	private void NotifyOfSelectionChange() { }

	private void OnAttachToPanel(AttachToPanelEvent evt) { }

	private void OnCustomStyleResolved(CustomStyleResolvedEvent e) { }

	private void OnDetachFromPanel(DetachFromPanelEvent evt) { }

	private void OnItemIndexChanged(int srcIndex, int dstIndex) { }

	private void OnItemsSourceChanged() { }

	private void OnPointerCancel(PointerCancelEvent evt) { }

	private void OnPointerDown(PointerDownEvent evt) { }

	private void OnPointerMove(PointerMoveEvent evt) { }

	private void OnPointerUp(PointerUpEvent evt) { }

	private void OnScroll(Vector2 offset) { }

	private void OnSizeChanged(GeometryChangedEvent evt) { }

	internal virtual void OnViewDataReady() { }

	override void PostRefresh() { }

	private void ProcessPointerDown(IPointerEvent evt) { }

	private void ProcessPointerUp(IPointerEvent evt) { }

	private void ProcessSingleClick(int clickedIndex) { }

	internal bool RaiseCanStartDrag(ReusableCollectionItem item, IEnumerable<Int32> ids) { }

	internal DragVisualMode RaiseDrop(Vector2 pointerPosition, DragAndDropArgs dragAndDropArgs) { }

	internal DragVisualMode RaiseHandleDragAndDrop(Vector2 pointerPosition, DragAndDropArgs dragAndDropArgs) { }

	internal StartDragArgs RaiseSetupDragAndDrop(ReusableCollectionItem item, IEnumerable<Int32> ids, StartDragArgs args) { }

	public void Rebuild() { }

	public void RefreshItems() { }

	private void RefreshSelection() { }

	public void RemoveFromSelection(int index) { }

	private void RemoveFromSelectionWithoutValidation(int index) { }

	private void Resize(Vector2 size) { }

	internal float ResolveItemHeight(float height = -1) { }

	internal void ScheduleRebuild() { }

	public void ScrollToItem(int index) { }

	public void ScrollToItemById(int id) { }

	internal void SelectAll() { }

	public void set_fixedItemHeight(float value) { }

	public void set_horizontalScrollingEnabled(bool value) { }

	public void set_itemsSource(IList value) { }

	public void set_reorderable(bool value) { }

	public void set_selectedIndex(int value) { }

	public void set_selectionType(SelectionType value) { }

	public void set_showAlternatingRowBackgrounds(AlternatingRowBackground value) { }

	public void set_showBorder(bool value) { }

	public void set_virtualizationMethod(CollectionVirtualizationMethod value) { }

	public void SetSelection(IEnumerable<Int32> indices) { }

	public void SetSelection(int index) { }

	internal void SetSelectionInternal(IEnumerable<Int32> indices, bool sendNotification) { }

	public void SetSelectionWithoutNotify(IEnumerable<Int32> indices) { }

	public override void SetViewController(CollectionViewController controller) { }

	private override void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

	private override void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

}

