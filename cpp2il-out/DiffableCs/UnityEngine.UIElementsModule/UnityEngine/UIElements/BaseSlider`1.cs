namespace UnityEngine.UIElements;

public abstract class BaseSlider : BaseField<TValueType>, IValueField<TValueType>
{
	public enum SliderKey
	{
		None = 0,
		Lowest = 1,
		LowerPage = 2,
		Lower = 3,
		Higher = 4,
		HigherPage = 5,
		Highest = 6,
	}

	internal class UxmlTraits : UxmlTraits<TValueType>
	{

		public UxmlTraits() { }

	}

	public static readonly string textFieldClassName; //Field offset: 0x0
	public static readonly string draggerUssClassName; //Field offset: 0x0
	public static readonly string trackerUssClassName; //Field offset: 0x0
	public static readonly string dragContainerUssClassName; //Field offset: 0x0
	public static readonly string verticalVariantUssClassName; //Field offset: 0x0
	public static readonly string horizontalVariantUssClassName; //Field offset: 0x0
	public static readonly string inputUssClassName; //Field offset: 0x0
	public static readonly string labelUssClassName; //Field offset: 0x0
	public static readonly string ussClassName; //Field offset: 0x0
	public static readonly string draggerBorderUssClassName; //Field offset: 0x0
	private bool m_Inverted; //Field offset: 0x0
	private SliderDirection m_Direction; //Field offset: 0x0
	private Rect m_DragElementStartPos; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private ClampedDragger<TValueType> <clampedDragger>k__BackingField; //Field offset: 0x0
	private bool m_ShowInputField; //Field offset: 0x0
	private float m_PageSize; //Field offset: 0x0
	[SerializeField]
	private TValueType m_HighValue; //Field offset: 0x0
	[SerializeField]
	private TValueType m_LowValue; //Field offset: 0x0
	private bool m_IsEditingTextField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private TextField <inputTextField>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private VisualElement <dragBorderElement>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private VisualElement <trackElement>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private VisualElement <dragElement>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private VisualElement <dragContainer>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <clamped>k__BackingField; //Field offset: 0x0
	private float m_AdjustedPageSizeFromClick; //Field offset: 0x0

	virtual bool canSwitchToMixedValue
	{
		 get { } //Length: 258
	}

	internal bool clamped
	{
		[CompilerGenerated]
		internal get { } //Length: 8
		[CompilerGenerated]
		internal set { } //Length: 7
	}

	internal ClampedDragger<TValueType> clampedDragger
	{
		[CompilerGenerated]
		internal get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 19
	}

	public SliderDirection direction
	{
		 get { } //Length: 9
		 set { } //Length: 348
	}

	internal VisualElement dragBorderElement
	{
		[CompilerGenerated]
		internal get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 19
	}

	internal VisualElement dragContainer
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

	public TValueType highValue
	{
		 get { } //Length: 9
		 set { } //Length: 214
	}

	internal TextField inputTextField
	{
		[CompilerGenerated]
		internal get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 19
	}

	public bool inverted
	{
		 get { } //Length: 10
		 set { } //Length: 35
	}

	public TValueType lowValue
	{
		 get { } //Length: 9
		 set { } //Length: 214
	}

	public override float pageSize
	{
		 get { } //Length: 11
		 set { } //Length: 9
	}

	public override bool showInputField
	{
		 get { } //Length: 10
		 set { } //Length: 35
	}

	internal VisualElement trackElement
	{
		[CompilerGenerated]
		internal get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 19
	}

	public virtual TValueType value
	{
		 get { } //Length: 38
		 set { } //Length: 93
	}

	private static BaseSlider`1() { }

	internal BaseSlider`1(string label, TValueType start, TValueType end, SliderDirection direction = 0, float pageSize = 0) { }

	public void AdjustDragElement(float factor) { }

	public override void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, TValueType startValue) { }

	private TValueType Clamp(TValueType value, TValueType lowBound, TValueType highBound) { }

	private void ClampValue() { }

	internal override void ComputeValueAndDirectionFromClick(float sliderLength, float dragElementLength, float dragElementPos, float dragElementLastPos) { }

	private void ComputeValueAndDirectionFromDrag(float sliderLength, float dragElementLength, float dragElementPos) { }

	internal abstract void ComputeValueFromKey(SliderKey<TValueType> sliderKey, bool isShift) { }

	[EventInterest(new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(GeometryChangedEvent)}])]
	protected virtual void ExecuteDefaultAction(EventBase evt) { }

	virtual bool get_canSwitchToMixedValue() { }

	[CompilerGenerated]
	internal bool get_clamped() { }

	[CompilerGenerated]
	internal ClampedDragger<TValueType> get_clampedDragger() { }

	public SliderDirection get_direction() { }

	[CompilerGenerated]
	internal VisualElement get_dragBorderElement() { }

	[CompilerGenerated]
	internal VisualElement get_dragContainer() { }

	[CompilerGenerated]
	internal VisualElement get_dragElement() { }

	public TValueType get_highValue() { }

	[CompilerGenerated]
	internal TextField get_inputTextField() { }

	public bool get_inverted() { }

	public TValueType get_lowValue() { }

	public override float get_pageSize() { }

	public override bool get_showInputField() { }

	[CompilerGenerated]
	internal VisualElement get_trackElement() { }

	public virtual TValueType get_value() { }

	private TValueType GetClampedValue(TValueType newValue) { }

	protected static float GetClosestPowerOfTen(float positiveNumber) { }

	private void OnInputNavigationMoveEvent(NavigationMoveEvent evt) { }

	private void OnKeyDown(KeyDownEvent evt) { }

	private void OnNavigationMove(NavigationMoveEvent evt) { }

	private void OnTextFieldFocusIn(FocusInEvent evt) { }

	private void OnTextFieldFocusOut(FocusOutEvent evt) { }

	private void OnTextFieldValueChange(ChangeEvent<String> evt) { }

	internal virtual void OnViewDataReady() { }

	internal abstract TValueType ParseStringToValue(string previousValue, string newValue) { }

	internal virtual void RegisterEditingCallbacks() { }

	protected static float RoundToMultipleOf(float value, float roundingValue) { }

	private bool SameValues(float a, float b, float epsilon) { }

	[CompilerGenerated]
	internal void set_clamped(bool value) { }

	[CompilerGenerated]
	private void set_clampedDragger(ClampedDragger<TValueType> value) { }

	public void set_direction(SliderDirection value) { }

	[CompilerGenerated]
	private void set_dragBorderElement(VisualElement value) { }

	[CompilerGenerated]
	private void set_dragContainer(VisualElement value) { }

	[CompilerGenerated]
	private void set_dragElement(VisualElement value) { }

	public void set_highValue(TValueType value) { }

	[CompilerGenerated]
	private void set_inputTextField(TextField value) { }

	public void set_inverted(bool value) { }

	public void set_lowValue(TValueType value) { }

	public override void set_pageSize(float value) { }

	public override void set_showInputField(bool value) { }

	[CompilerGenerated]
	private void set_trackElement(VisualElement value) { }

	public virtual void set_value(TValueType value) { }

	internal void SetHighValueWithoutNotify(TValueType newHighValue) { }

	private void SetSliderValueFromClick() { }

	private void SetSliderValueFromDrag() { }

	public virtual void SetValueWithoutNotify(TValueType newValue) { }

	private TValueType SliderLerpDirectionalUnclamped(TValueType a, TValueType b, float positionInterpolant) { }

	internal abstract TValueType SliderLerpUnclamped(TValueType a, TValueType b, float interpolant) { }

	internal abstract float SliderNormalizeValue(TValueType currentValue, TValueType lowerValue, TValueType higherValue) { }

	private override void UnityEngine.UIElements.IValueField<TValueType>.StartDragging() { }

	private override void UnityEngine.UIElements.IValueField<TValueType>.StopDragging() { }

	internal virtual void UnregisterEditingCallbacks() { }

	private void UpdateDragElementPosition() { }

	private void UpdateDragElementPosition(GeometryChangedEvent evt) { }

	protected virtual void UpdateMixedValueContent() { }

	private void UpdateTextFieldValue() { }

	private void UpdateTextFieldVisibility() { }

}

