namespace UnityEngine.UI;

[AddComponentMenu("UI/Scrollbar", 36)]
[ExecuteAlways]
[RequireComponent(typeof(RectTransform))]
public class Scrollbar : Selectable, IBeginDragHandler, IEventSystemHandler, IDragHandler, IInitializePotentialDragHandler, ICanvasElement
{
	[CompilerGenerated]
	private sealed class <ClickRepeat>d__58 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public Scrollbar <>4__this; //Field offset: 0x20
		public Vector2 screenPosition; //Field offset: 0x28
		public Camera camera; //Field offset: 0x30

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
		public <ClickRepeat>d__58(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	private enum Axis
	{
		Horizontal = 0,
		Vertical = 1,
	}

	internal enum Direction
	{
		LeftToRight = 0,
		RightToLeft = 1,
		BottomToTop = 2,
		TopToBottom = 3,
	}

	internal class ScrollEvent : UnityEvent<Single>
	{

		public ScrollEvent() { }

	}

	[SerializeField]
	private RectTransform m_HandleRect; //Field offset: 0x100
	[SerializeField]
	private Direction m_Direction; //Field offset: 0x108
	[Range(0, 1)]
	[SerializeField]
	private float m_Value; //Field offset: 0x10C
	[Range(0, 1)]
	[SerializeField]
	private float m_Size; //Field offset: 0x110
	[Range(0, 11)]
	[SerializeField]
	private int m_NumberOfSteps; //Field offset: 0x114
	[SerializeField]
	[Space(6)]
	private ScrollEvent m_OnValueChanged; //Field offset: 0x118
	private RectTransform m_ContainerRect; //Field offset: 0x120
	private Vector2 m_Offset; //Field offset: 0x128
	private DrivenRectTransformTracker m_Tracker; //Field offset: 0x130
	private Coroutine m_PointerDownRepeat; //Field offset: 0x138
	private bool isPointerDownAndNotDragging; //Field offset: 0x140
	private bool m_DelayedUpdateVisuals; //Field offset: 0x141

	private Axis axis
	{
		private get { } //Length: 21
	}

	public Direction direction
	{
		 get { } //Length: 7
		 set { } //Length: 89
	}

	public RectTransform handleRect
	{
		 get { } //Length: 8
		 set { } //Length: 101
	}

	public int numberOfSteps
	{
		 get { } //Length: 7
		 set { } //Length: 111
	}

	public ScrollEvent onValueChanged
	{
		 get { } //Length: 8
		 set { } //Length: 19
	}

	private bool reverseValue
	{
		private get { } //Length: 23
	}

	public float size
	{
		 get { } //Length: 9
		 set { } //Length: 121
	}

	private float stepSize
	{
		private get { } //Length: 46
	}

	public float value
	{
		 get { } //Length: 81
		 set { } //Length: 11
	}

	protected Scrollbar() { }

	[IteratorStateMachine(typeof(<ClickRepeat>d__58))]
	protected IEnumerator ClickRepeat(Vector2 screenPosition, Camera camera) { }

	protected IEnumerator ClickRepeat(PointerEventData eventData) { }

	private void DoUpdateDrag(Vector2 handleCorner, float remainingSize) { }

	public virtual Selectable FindSelectableOnDown() { }

	public virtual Selectable FindSelectableOnLeft() { }

	public virtual Selectable FindSelectableOnRight() { }

	public virtual Selectable FindSelectableOnUp() { }

	private Axis get_axis() { }

	public Direction get_direction() { }

	public RectTransform get_handleRect() { }

	public int get_numberOfSteps() { }

	public ScrollEvent get_onValueChanged() { }

	private bool get_reverseValue() { }

	public float get_size() { }

	private float get_stepSize() { }

	public float get_value() { }

	public override void GraphicUpdateComplete() { }

	public override void LayoutComplete() { }

	private bool MayDrag(PointerEventData eventData) { }

	public override void OnBeginDrag(PointerEventData eventData) { }

	protected virtual void OnDisable() { }

	public override void OnDrag(PointerEventData eventData) { }

	protected virtual void OnEnable() { }

	public override void OnInitializePotentialDrag(PointerEventData eventData) { }

	public virtual void OnMove(AxisEventData eventData) { }

	public virtual void OnPointerDown(PointerEventData eventData) { }

	public virtual void OnPointerUp(PointerEventData eventData) { }

	protected virtual void OnRectTransformDimensionsChange() { }

	public override void Rebuild(CanvasUpdate executing) { }

	private void Set(float input, bool sendCallback = true) { }

	public void set_direction(Direction value) { }

	public void set_handleRect(RectTransform value) { }

	public void set_numberOfSteps(int value) { }

	public void set_onValueChanged(ScrollEvent value) { }

	public void set_size(float value) { }

	public void set_value(float value) { }

	public void SetDirection(Direction direction, bool includeRectLayouts) { }

	public override void SetValueWithoutNotify(float input) { }

	private override Transform UnityEngine.UI.ICanvasElement.get_transform() { }

	protected override void Update() { }

	private void UpdateCachedReferences() { }

	private void UpdateDrag(PointerEventData eventData) { }

	private void UpdateVisuals() { }

}

