namespace UnityEngine.EventSystems;

public static class ExecuteEvents
{
	internal sealed class EventFunction : MulticastDelegate
	{

		public EventFunction`1(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(T1 handler, BaseEventData eventData, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(T1 handler, BaseEventData eventData) { }

	}

	private static readonly EventFunction<IPointerMoveHandler> s_PointerMoveHandler; //Field offset: 0x0
	private static readonly EventFunction<IPointerEnterHandler> s_PointerEnterHandler; //Field offset: 0x8
	private static readonly EventFunction<IPointerExitHandler> s_PointerExitHandler; //Field offset: 0x10
	private static readonly EventFunction<IPointerDownHandler> s_PointerDownHandler; //Field offset: 0x18
	private static readonly EventFunction<IPointerUpHandler> s_PointerUpHandler; //Field offset: 0x20
	private static readonly EventFunction<IPointerClickHandler> s_PointerClickHandler; //Field offset: 0x28
	private static readonly EventFunction<IInitializePotentialDragHandler> s_InitializePotentialDragHandler; //Field offset: 0x30
	private static readonly EventFunction<IBeginDragHandler> s_BeginDragHandler; //Field offset: 0x38
	private static readonly EventFunction<IDragHandler> s_DragHandler; //Field offset: 0x40
	private static readonly EventFunction<IEndDragHandler> s_EndDragHandler; //Field offset: 0x48
	private static readonly EventFunction<IDropHandler> s_DropHandler; //Field offset: 0x50
	private static readonly EventFunction<IScrollHandler> s_ScrollHandler; //Field offset: 0x58
	private static readonly EventFunction<IUpdateSelectedHandler> s_UpdateSelectedHandler; //Field offset: 0x60
	private static readonly EventFunction<ISelectHandler> s_SelectHandler; //Field offset: 0x68
	private static readonly EventFunction<IDeselectHandler> s_DeselectHandler; //Field offset: 0x70
	private static readonly EventFunction<IMoveHandler> s_MoveHandler; //Field offset: 0x78
	private static readonly EventFunction<ISubmitHandler> s_SubmitHandler; //Field offset: 0x80
	private static readonly EventFunction<ICancelHandler> s_CancelHandler; //Field offset: 0x88
	private static readonly List<Transform> s_InternalTransformList; //Field offset: 0x90

	public static EventFunction<IBeginDragHandler> beginDragHandler
	{
		 get { } //Length: 79
	}

	public static EventFunction<ICancelHandler> cancelHandler
	{
		 get { } //Length: 82
	}

	public static EventFunction<IDeselectHandler> deselectHandler
	{
		 get { } //Length: 79
	}

	public static EventFunction<IDragHandler> dragHandler
	{
		 get { } //Length: 79
	}

	public static EventFunction<IDropHandler> dropHandler
	{
		 get { } //Length: 79
	}

	public static EventFunction<IEndDragHandler> endDragHandler
	{
		 get { } //Length: 79
	}

	public static EventFunction<IInitializePotentialDragHandler> initializePotentialDrag
	{
		 get { } //Length: 79
	}

	public static EventFunction<IMoveHandler> moveHandler
	{
		 get { } //Length: 79
	}

	public static EventFunction<IPointerClickHandler> pointerClickHandler
	{
		 get { } //Length: 79
	}

	public static EventFunction<IPointerDownHandler> pointerDownHandler
	{
		 get { } //Length: 79
	}

	public static EventFunction<IPointerEnterHandler> pointerEnterHandler
	{
		 get { } //Length: 79
	}

	public static EventFunction<IPointerExitHandler> pointerExitHandler
	{
		 get { } //Length: 79
	}

	public static EventFunction<IPointerMoveHandler> pointerMoveHandler
	{
		 get { } //Length: 78
	}

	public static EventFunction<IPointerUpHandler> pointerUpHandler
	{
		 get { } //Length: 79
	}

	public static EventFunction<IScrollHandler> scrollHandler
	{
		 get { } //Length: 79
	}

	public static EventFunction<ISelectHandler> selectHandler
	{
		 get { } //Length: 79
	}

	public static EventFunction<ISubmitHandler> submitHandler
	{
		 get { } //Length: 82
	}

	public static EventFunction<IUpdateSelectedHandler> updateSelectedHandler
	{
		 get { } //Length: 79
	}

	private static ExecuteEvents() { }

	public static bool CanHandleEvent(GameObject go) { }

	public static bool Execute(GameObject target, BaseEventData eventData, EventFunction<T> functor) { }

	private static void Execute(ICancelHandler handler, BaseEventData eventData) { }

	private static void Execute(ISubmitHandler handler, BaseEventData eventData) { }

	private static void Execute(IMoveHandler handler, BaseEventData eventData) { }

	private static void Execute(ISelectHandler handler, BaseEventData eventData) { }

	private static void Execute(IUpdateSelectedHandler handler, BaseEventData eventData) { }

	private static void Execute(IScrollHandler handler, BaseEventData eventData) { }

	private static void Execute(IDropHandler handler, BaseEventData eventData) { }

	private static void Execute(IDeselectHandler handler, BaseEventData eventData) { }

	private static void Execute(IDragHandler handler, BaseEventData eventData) { }

	private static void Execute(IBeginDragHandler handler, BaseEventData eventData) { }

	private static void Execute(IInitializePotentialDragHandler handler, BaseEventData eventData) { }

	private static void Execute(IPointerClickHandler handler, BaseEventData eventData) { }

	private static void Execute(IPointerMoveHandler handler, BaseEventData eventData) { }

	private static void Execute(IPointerUpHandler handler, BaseEventData eventData) { }

	private static void Execute(IPointerDownHandler handler, BaseEventData eventData) { }

	private static void Execute(IPointerExitHandler handler, BaseEventData eventData) { }

	private static void Execute(IPointerEnterHandler handler, BaseEventData eventData) { }

	private static void Execute(IEndDragHandler handler, BaseEventData eventData) { }

	public static GameObject ExecuteHierarchy(GameObject root, BaseEventData eventData, EventFunction<T> callbackFunction) { }

	public static EventFunction<IBeginDragHandler> get_beginDragHandler() { }

	public static EventFunction<ICancelHandler> get_cancelHandler() { }

	public static EventFunction<IDeselectHandler> get_deselectHandler() { }

	public static EventFunction<IDragHandler> get_dragHandler() { }

	public static EventFunction<IDropHandler> get_dropHandler() { }

	public static EventFunction<IEndDragHandler> get_endDragHandler() { }

	public static EventFunction<IInitializePotentialDragHandler> get_initializePotentialDrag() { }

	public static EventFunction<IMoveHandler> get_moveHandler() { }

	public static EventFunction<IPointerClickHandler> get_pointerClickHandler() { }

	public static EventFunction<IPointerDownHandler> get_pointerDownHandler() { }

	public static EventFunction<IPointerEnterHandler> get_pointerEnterHandler() { }

	public static EventFunction<IPointerExitHandler> get_pointerExitHandler() { }

	public static EventFunction<IPointerMoveHandler> get_pointerMoveHandler() { }

	public static EventFunction<IPointerUpHandler> get_pointerUpHandler() { }

	public static EventFunction<IScrollHandler> get_scrollHandler() { }

	public static EventFunction<ISelectHandler> get_selectHandler() { }

	public static EventFunction<ISubmitHandler> get_submitHandler() { }

	public static EventFunction<IUpdateSelectedHandler> get_updateSelectedHandler() { }

	private static void GetEventChain(GameObject root, IList<Transform> eventChain) { }

	public static GameObject GetEventHandler(GameObject root) { }

	private static void GetEventList(GameObject go, IList<IEventSystemHandler> results) { }

	private static bool ShouldSendToComponent(Component component) { }

	public static T ValidateEventData(BaseEventData data) { }

}

