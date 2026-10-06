namespace UnityEngine.UIElements;

public class Scroller : VisualElement
{
	private class ScrollerSlider : Slider
	{

		public ScrollerSlider(float start, float end, SliderDirection direction, float pageSize) { }

		internal virtual float SliderNormalizeValue(float currentValue, float lowerValue, float higherValue) { }

	}

	internal class UxmlFactory : UxmlFactory<Scroller, UxmlTraits>
	{

		public UxmlFactory() { }

	}

	internal class UxmlTraits : UxmlTraits
	{
		private UxmlFloatAttributeDescription m_LowValue; //Field offset: 0x70
		private UxmlFloatAttributeDescription m_HighValue; //Field offset: 0x78
		private UxmlEnumAttributeDescription<SliderDirection> m_Direction; //Field offset: 0x80
		private UxmlFloatAttributeDescription m_Value; //Field offset: 0x88

		public UxmlTraits() { }

		public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	}

	public static readonly string ussClassName; //Field offset: 0x0
	public static readonly string horizontalVariantUssClassName; //Field offset: 0x8
	public static readonly string verticalVariantUssClassName; //Field offset: 0x10
	public static readonly string sliderUssClassName; //Field offset: 0x18
	public static readonly string lowButtonUssClassName; //Field offset: 0x20
	public static readonly string highButtonUssClassName; //Field offset: 0x28
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action<Single> valueChanged; //Field offset: 0x3C8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Slider <slider>k__BackingField; //Field offset: 0x3D0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private RepeatButton <lowButton>k__BackingField; //Field offset: 0x3D8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private RepeatButton <highButton>k__BackingField; //Field offset: 0x3E0

	public event Action<Single> valueChanged
	{
		[CompilerGenerated]
		 add { } //Length: 186
		[CompilerGenerated]
		 remove { } //Length: 186
	}

	public SliderDirection direction
	{
		 set { } //Length: 451
	}

	public private RepeatButton highButton
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 19
	}

	public float highValue
	{
		 get { } //Length: 71
		 set { } //Length: 87
	}

	public private RepeatButton lowButton
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 19
	}

	public float lowValue
	{
		 get { } //Length: 71
		 set { } //Length: 87
	}

	public private Slider slider
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 19
	}

	public float value
	{
		 get { } //Length: 45
		 set { } //Length: 45
	}

	private static Scroller() { }

	public Scroller(float lowValue, float highValue, Action<Single> valueChanged, SliderDirection direction = 1) { }

	public Scroller() { }

	[CompilerGenerated]
	public void add_valueChanged(Action<Single> value) { }

	public void Adjust(float factor) { }

	[CompilerGenerated]
	public RepeatButton get_highButton() { }

	public float get_highValue() { }

	[CompilerGenerated]
	public RepeatButton get_lowButton() { }

	public float get_lowValue() { }

	[CompilerGenerated]
	public Slider get_slider() { }

	public float get_value() { }

	private void OnSliderValueChange(ChangeEvent<Single> evt) { }

	[CompilerGenerated]
	public void remove_valueChanged(Action<Single> value) { }

	public void ScrollPageDown() { }

	public void ScrollPageDown(float factor) { }

	public void ScrollPageUp(float factor) { }

	public void ScrollPageUp() { }

	public void set_direction(SliderDirection value) { }

	[CompilerGenerated]
	private void set_highButton(RepeatButton value) { }

	public void set_highValue(float value) { }

	[CompilerGenerated]
	private void set_lowButton(RepeatButton value) { }

	public void set_lowValue(float value) { }

	[CompilerGenerated]
	private void set_slider(Slider value) { }

	public void set_value(float value) { }

}

