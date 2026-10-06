namespace UnityEngine.UIElements;

public class MinMaxSlider : BaseField<Vector2>
{
	private enum DragState
	{
		NoThumb = 0,
		MinThumb = 1,
		MiddleThumb = 2,
		MaxThumb = 3,
	}

	internal class UxmlFactory : UxmlFactory<MinMaxSlider, UxmlTraits>
	{

		public UxmlFactory() { }

	}

	internal class UxmlTraits : UxmlTraits<Vector2>
	{
		private UxmlFloatAttributeDescription m_MinValue; //Field offset: 0x80
		private UxmlFloatAttributeDescription m_MaxValue; //Field offset: 0x88
		private UxmlFloatAttributeDescription m_LowLimit; //Field offset: 0x90
		private UxmlFloatAttributeDescription m_HighLimit; //Field offset: 0x98

		public UxmlTraits() { }

		public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	}

	public static readonly string ussClassName; //Field offset: 0x0
	public static readonly string labelUssClassName; //Field offset: 0x8
	public static readonly string inputUssClassName; //Field offset: 0x10
	public static readonly string trackerUssClassName; //Field offset: 0x18
	public static readonly string draggerUssClassName; //Field offset: 0x20
	public static readonly string minThumbUssClassName; //Field offset: 0x28
	public static readonly string maxThumbUssClassName; //Field offset: 0x30
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private VisualElement <dragElement>k__BackingField; //Field offset: 0x448
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private VisualElement <dragMinThumb>k__BackingField; //Field offset: 0x450
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private VisualElement <dragMaxThumb>k__BackingField; //Field offset: 0x458
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private ClampedDragger<Single> <clampedDragger>k__BackingField; //Field offset: 0x460
	private Vector2 m_DragElementStartPos; //Field offset: 0x468
	private Vector2 m_ValueStartPos; //Field offset: 0x470
	private Rect m_DragMinThumbRect; //Field offset: 0x478
	private Rect m_DragMaxThumbRect; //Field offset: 0x488
	private DragState m_DragState; //Field offset: 0x498
	private float m_MinLimit; //Field offset: 0x49C
	private float m_MaxLimit; //Field offset: 0x4A0

	internal ClampedDragger<Single> clampedDragger
	{
		[CompilerGenerated]
		internal get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 19
	}

	internal VisualElement dragElement
	{
		[CompilerGenerated]
		internal get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 19
	}

	internal VisualElement dragMaxThumb
	{
		[CompilerGenerated]
		internal get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 19
	}

	internal VisualElement dragMinThumb
	{
		[CompilerGenerated]
		internal get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 19
	}

	public float highLimit
	{
		 get { } //Length: 11
		 set { } //Length: 254
	}

	public float lowLimit
	{
		 get { } //Length: 11
		 set { } //Length: 250
	}

	public float maxValue
	{
		 get { } //Length: 39
		 set { } //Length: 130
	}

	public float minValue
	{
		 get { } //Length: 39
		 set { } //Length: 130
	}

	public virtual Vector2 value
	{
		 get { } //Length: 58
		 set { } //Length: 91
	}

	private static MinMaxSlider() { }

	public MinMaxSlider(string label, float minValue = 0, float maxValue = 10, float minLimit = -3.4028235E+38, float maxLimit = 3.4028235E+38) { }

	public MinMaxSlider() { }

	private Vector2 ClampValues(Vector2 valueToClamp) { }

	private void ComputeValueFromDraggingThumb(float dragElementStartPos, float dragElementEndPos) { }

	private float ComputeValueFromPosition(float positionToConvert) { }

	[EventInterest(new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(GeometryChangedEvent)}])]
	protected virtual void ExecuteDefaultAction(EventBase evt) { }

	[CompilerGenerated]
	internal ClampedDragger<Single> get_clampedDragger() { }

	[CompilerGenerated]
	internal VisualElement get_dragElement() { }

	[CompilerGenerated]
	internal VisualElement get_dragMaxThumb() { }

	[CompilerGenerated]
	internal VisualElement get_dragMinThumb() { }

	public float get_highLimit() { }

	public float get_lowLimit() { }

	public float get_maxValue() { }

	public float get_minValue() { }

	public virtual Vector2 get_value() { }

	internal virtual void RegisterEditingCallbacks() { }

	[CompilerGenerated]
	private void set_clampedDragger(ClampedDragger<Single> value) { }

	[CompilerGenerated]
	private void set_dragElement(VisualElement value) { }

	[CompilerGenerated]
	private void set_dragMaxThumb(VisualElement value) { }

	[CompilerGenerated]
	private void set_dragMinThumb(VisualElement value) { }

	public void set_highLimit(float value) { }

	public void set_lowLimit(float value) { }

	public void set_maxValue(float value) { }

	public void set_minValue(float value) { }

	public virtual void set_value(Vector2 value) { }

	private void SetSliderValueFromClick() { }

	private void SetSliderValueFromDrag() { }

	public virtual void SetValueWithoutNotify(Vector2 newValue) { }

	internal float SliderLerpUnclamped(float a, float b, float interpolant) { }

	internal float SliderNormalizeValue(float currentValue, float lowerValue, float higherValue) { }

	internal virtual void UnregisterEditingCallbacks() { }

	private void UpdateDragElementPosition() { }

	private void UpdateDragElementPosition(GeometryChangedEvent evt) { }

	private void UpdateDragThumbsRect() { }

	protected virtual void UpdateMixedValueContent() { }

}

