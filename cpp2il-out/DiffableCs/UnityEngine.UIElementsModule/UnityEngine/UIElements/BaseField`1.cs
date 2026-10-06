namespace UnityEngine.UIElements;

public abstract class BaseField : BindableElement, INotifyValueChanged<TValueType>, IEditableElement
{
	internal class UxmlTraits : UxmlTraits
	{
		private UxmlStringAttributeDescription m_Label; //Field offset: 0x0

		public UxmlTraits() { }

		public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

		internal static List<String> ParseChoiceList(string choicesFromBag) { }

	}

	public static readonly string ussClassName; //Field offset: 0x0
	private static CustomStyleProperty<Single> s_LabelExtraContextWidthProperty; //Field offset: 0x0
	private static CustomStyleProperty<Single> s_LabelBaseMinWidthProperty; //Field offset: 0x0
	private static CustomStyleProperty<Single> s_LabelExtraPaddingProperty; //Field offset: 0x0
	protected private static readonly PropertyName serializedPropertyCopyName; //Field offset: 0x0
	protected private static readonly string mixedValueString; //Field offset: 0x0
	private static readonly string inspectorFieldUssClassName; //Field offset: 0x0
	private static CustomStyleProperty<Single> s_LabelWidthRatioProperty; //Field offset: 0x0
	public static readonly string mixedValueLabelUssClassName; //Field offset: 0x0
	public static readonly string labelDraggerVariantUssClassName; //Field offset: 0x0
	public static readonly string noLabelVariantUssClassName; //Field offset: 0x0
	public static readonly string inputUssClassName; //Field offset: 0x0
	public static readonly string labelUssClassName; //Field offset: 0x0
	public static readonly string alignedFieldUssClassName; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Label <labelElement>k__BackingField; //Field offset: 0x0
	private VisualElement m_CachedInspectorElement; //Field offset: 0x0
	private VisualElement m_CachedContextWidthElement; //Field offset: 0x0
	private bool m_SkipValidation; //Field offset: 0x0
	private Label m_MixedValueLabel; //Field offset: 0x0
	private bool m_ShowMixedValue; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Func<TValueType, TValueType> onValidateValue; //Field offset: 0x0
	private float m_LabelWidthRatio; //Field offset: 0x0
	internal Action<Expression> expressionEvaluated; //Field offset: 0x0
	private VisualElement m_VisualInput; //Field offset: 0x0
	private float m_LabelExtraContextWidth; //Field offset: 0x0
	private float m_LabelBaseMinWidth; //Field offset: 0x0
	private float m_LabelExtraPadding; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action <UnityEngine.UIElements.IEditableElement.editingStarted>k__BackingField; //Field offset: 0x0
	[SerializeField]
	private TValueType m_Value; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action <UnityEngine.UIElements.IEditableElement.editingEnded>k__BackingField; //Field offset: 0x0

	internal event Func<TValueType, TValueType> onValidateValue
	{
		[CompilerGenerated]
		internal add { } //Length: 194
		[CompilerGenerated]
		internal remove { } //Length: 194
	}

	override bool canSwitchToMixedValue
	{
		 get { } //Length: 3
	}

	public override string label
	{
		 get { } //Length: 45
		 set { } //Length: 494
	}

	public private override Label labelElement
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 19
	}

	protected Label mixedValueLabel
	{
		 get { } //Length: 396
	}

	protected TValueType rawValue
	{
		 get { } //Length: 10
		 set { } //Length: 7
	}

	public override bool showMixedValue
	{
		 get { } //Length: 8
		 set { } //Length: 91
	}

	private override Action UnityEngine.UIElements.IEditableElement.editingEnded
	{
		[CompilerGenerated]
		private get { } //Length: 8
	}

	private override Action UnityEngine.UIElements.IEditableElement.editingStarted
	{
		[CompilerGenerated]
		private get { } //Length: 8
	}

	public override TValueType value
	{
		 get { } //Length: 10
		 set { } //Length: 442
	}

	internal VisualElement visualInput
	{
		internal get { } //Length: 10
		internal set { } //Length: 634
	}

	private static BaseField`1() { }

	protected BaseField`1(string label, VisualElement visualInput) { }

	internal BaseField`1(string label) { }

	[CompilerGenerated]
	internal void add_onValidateValue(Func<TValueType, TValueType> value) { }

	private void AlignLabel() { }

	internal void EndEditing(EventBase e) { }

	internal override bool EqualsCurrentValue(TValueType value) { }

	override bool get_canSwitchToMixedValue() { }

	public override string get_label() { }

	[CompilerGenerated]
	public override Label get_labelElement() { }

	protected Label get_mixedValueLabel() { }

	protected TValueType get_rawValue() { }

	public override bool get_showMixedValue() { }

	public override TValueType get_value() { }

	internal VisualElement get_visualInput() { }

	internal virtual Rect GetTooltipRect() { }

	private void OnAttachToPanel(AttachToPanelEvent e) { }

	private void OnCustomStyleResolved(CustomStyleResolvedEvent evt) { }

	private void OnDetachFromPanel(DetachFromPanelEvent e) { }

	private void OnInspectorFieldGeometryChanged(GeometryChangedEvent e) { }

	internal virtual void OnViewDataReady() { }

	internal override void RegisterEditingCallbacks() { }

	[CompilerGenerated]
	internal void remove_onValidateValue(Func<TValueType, TValueType> value) { }

	public void set_label(string value) { }

	[CompilerGenerated]
	private void set_labelElement(Label value) { }

	protected void set_rawValue(TValueType value) { }

	public override void set_showMixedValue(bool value) { }

	public override void set_value(TValueType value) { }

	internal void set_visualInput(VisualElement value) { }

	public override void SetValueWithoutNotify(TValueType newValue) { }

	internal void StartEditing(EventBase e) { }

	[CompilerGenerated]
	private override Action UnityEngine.UIElements.IEditableElement.get_editingEnded() { }

	[CompilerGenerated]
	private override Action UnityEngine.UIElements.IEditableElement.get_editingStarted() { }

	internal override void UnregisterEditingCallbacks() { }

	protected override void UpdateMixedValueContent() { }

	internal TValueType ValidatedValue(TValueType value) { }

}

