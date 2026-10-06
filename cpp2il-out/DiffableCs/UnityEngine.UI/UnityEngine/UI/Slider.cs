namespace UnityEngine.UI;

[AddComponentMenu("UI/Slider", 34)]
[ExecuteAlways]
[RequireComponent(typeof(RectTransform))]
public class Slider : Selectable, IDragHandler, IEventSystemHandler, IInitializePotentialDragHandler, ICanvasElement
{
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

	internal class SliderEvent : UnityEvent<Single>
	{

		public SliderEvent() { }

	}

	[SerializeField]
	private RectTransform m_FillRect; //Field offset: 0x100
	[SerializeField]
	private RectTransform m_HandleRect; //Field offset: 0x108
	[SerializeField]
	[Space]
	private Direction m_Direction; //Field offset: 0x110
	[SerializeField]
	private float m_MinValue; //Field offset: 0x114
	[SerializeField]
	private float m_MaxValue; //Field offset: 0x118
	[SerializeField]
	private bool m_WholeNumbers; //Field offset: 0x11C
	[SerializeField]
	protected float m_Value; //Field offset: 0x120
	[SerializeField]
	[Space]
	private SliderEvent m_OnValueChanged; //Field offset: 0x128
	private Image m_FillImage; //Field offset: 0x130
	private Transform m_FillTransform; //Field offset: 0x138
	private RectTransform m_FillContainerRect; //Field offset: 0x140
	private Transform m_HandleTransform; //Field offset: 0x148
	private RectTransform m_HandleContainerRect; //Field offset: 0x150
	private Vector2 m_Offset; //Field offset: 0x158
	private DrivenRectTransformTracker m_Tracker; //Field offset: 0x160
	private bool m_DelayedUpdateVisuals; //Field offset: 0x161

	private Axis axis
	{
		private get { } //Length: 21
	}

	public Direction direction
	{
		 get { } //Length: 7
		 set { } //Length: 89
	}

	public RectTransform fillRect
	{
		 get { } //Length: 8
		 set { } //Length: 101
	}

	public RectTransform handleRect
	{
		 get { } //Length: 8
		 set { } //Length: 101
	}

	public float maxValue
	{
		 get { } //Length: 9
		 set { } //Length: 125
	}

	public float minValue
	{
		 get { } //Length: 9
		 set { } //Length: 125
	}

	public float normalizedValue
	{
		 get { } //Length: 172
		 set { } //Length: 80
	}

	public SliderEvent onValueChanged
	{
		 get { } //Length: 8
		 set { } //Length: 19
	}

	private bool reverseValue
	{
		private get { } //Length: 23
	}

	private float stepSize
	{
		private get { } //Length: 43
	}

	public override float value
	{
		 get { } //Length: 22
		 set { } //Length: 23
	}

	public bool wholeNumbers
	{
		 get { } //Length: 8
		 set { } //Length: 125
	}

	protected Slider() { }

	private float ClampValue(float input) { }

	public virtual Selectable FindSelectableOnDown() { }

	public virtual Selectable FindSelectableOnLeft() { }

	public virtual Selectable FindSelectableOnRight() { }

	public virtual Selectable FindSelectableOnUp() { }

	private Axis get_axis() { }

	public Direction get_direction() { }

	public RectTransform get_fillRect() { }

	public RectTransform get_handleRect() { }

	public float get_maxValue() { }

	public float get_minValue() { }

	public float get_normalizedValue() { }

	public SliderEvent get_onValueChanged() { }

	private bool get_reverseValue() { }

	private float get_stepSize() { }

	public override float get_value() { }

	public bool get_wholeNumbers() { }

	public override void GraphicUpdateComplete() { }

	public override void LayoutComplete() { }

	private bool MayDrag(PointerEventData eventData) { }

	protected virtual void OnDidApplyAnimationProperties() { }

	protected virtual void OnDisable() { }

	public override void OnDrag(PointerEventData eventData) { }

	protected virtual void OnEnable() { }

	public override void OnInitializePotentialDrag(PointerEventData eventData) { }

	public virtual void OnMove(AxisEventData eventData) { }

	public virtual void OnPointerDown(PointerEventData eventData) { }

	protected virtual void OnRectTransformDimensionsChange() { }

	public override void Rebuild(CanvasUpdate executing) { }

	protected override void Set(float input, bool sendCallback = true) { }

	public void set_direction(Direction value) { }

	public void set_fillRect(RectTransform value) { }

	public void set_handleRect(RectTransform value) { }

	public void set_maxValue(float value) { }

	public void set_minValue(float value) { }

	public void set_normalizedValue(float value) { }

	public void set_onValueChanged(SliderEvent value) { }

	public override void set_value(float value) { }

	public void set_wholeNumbers(bool value) { }

	public void SetDirection(Direction direction, bool includeRectLayouts) { }

	public override void SetValueWithoutNotify(float input) { }

	private override Transform UnityEngine.UI.ICanvasElement.get_transform() { }

	protected override void Update() { }

	private void UpdateCachedReferences() { }

	private void UpdateDrag(PointerEventData eventData, Camera cam) { }

	private void UpdateVisuals() { }

}

