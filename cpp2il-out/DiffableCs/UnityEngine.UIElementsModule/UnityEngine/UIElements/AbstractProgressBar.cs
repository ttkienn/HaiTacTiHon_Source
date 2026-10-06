namespace UnityEngine.UIElements;

public abstract class AbstractProgressBar : BindableElement, INotifyValueChanged<Single>
{
	internal class UxmlTraits : UxmlTraits
	{
		private UxmlFloatAttributeDescription m_LowValue; //Field offset: 0x78
		private UxmlFloatAttributeDescription m_HighValue; //Field offset: 0x80
		private UxmlFloatAttributeDescription m_Value; //Field offset: 0x88
		private UxmlStringAttributeDescription m_Title; //Field offset: 0x90

		public UxmlTraits() { }

		public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	}

	public static readonly string ussClassName; //Field offset: 0x0
	public static readonly string containerUssClassName; //Field offset: 0x8
	public static readonly string titleUssClassName; //Field offset: 0x10
	public static readonly string titleContainerUssClassName; //Field offset: 0x18
	public static readonly string progressUssClassName; //Field offset: 0x20
	public static readonly string backgroundUssClassName; //Field offset: 0x28
	private readonly VisualElement m_Background; //Field offset: 0x3D8
	private readonly VisualElement m_Progress; //Field offset: 0x3E0
	private readonly Label m_Title; //Field offset: 0x3E8
	private float m_LowValue; //Field offset: 0x3F0
	private float m_HighValue; //Field offset: 0x3F4
	private float m_Value; //Field offset: 0x3F8

	public float highValue
	{
		 get { } //Length: 9
		 set { } //Length: 24
	}

	public float lowValue
	{
		 get { } //Length: 9
		 set { } //Length: 24
	}

	public string title
	{
		 set { } //Length: 45
	}

	public override float value
	{
		 get { } //Length: 11
		 set { } //Length: 730
	}

	private static AbstractProgressBar() { }

	public AbstractProgressBar() { }

	private float CalculateProgressWidth(float width) { }

	public float get_highValue() { }

	public float get_lowValue() { }

	public override float get_value() { }

	private void OnGeometryChanged(GeometryChangedEvent e) { }

	public void set_highValue(float value) { }

	public void set_lowValue(float value) { }

	public void set_title(string value) { }

	public override void set_value(float value) { }

	private void SetProgress(float p) { }

	public override void SetValueWithoutNotify(float newValue) { }

}

