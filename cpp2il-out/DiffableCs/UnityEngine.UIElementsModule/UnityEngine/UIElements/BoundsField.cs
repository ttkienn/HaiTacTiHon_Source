namespace UnityEngine.UIElements;

[MovedFrom(True, "UnityEditor.UIElements", "UnityEditor.UIElementsModule", null)]
public class BoundsField : BaseField<Bounds>
{
	internal class UxmlFactory : UxmlFactory<BoundsField, UxmlTraits>
	{

		public UxmlFactory() { }

	}

	internal class UxmlTraits : UxmlTraits<Bounds>
	{
		private UxmlFloatAttributeDescription m_CenterXValue; //Field offset: 0x80
		private UxmlFloatAttributeDescription m_CenterYValue; //Field offset: 0x88
		private UxmlFloatAttributeDescription m_CenterZValue; //Field offset: 0x90
		private UxmlFloatAttributeDescription m_ExtentsXValue; //Field offset: 0x98
		private UxmlFloatAttributeDescription m_ExtentsYValue; //Field offset: 0xA0
		private UxmlFloatAttributeDescription m_ExtentsZValue; //Field offset: 0xA8

		public UxmlTraits() { }

		public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	}

	public static readonly string ussClassName; //Field offset: 0x0
	public static readonly string labelUssClassName; //Field offset: 0x8
	public static readonly string inputUssClassName; //Field offset: 0x10
	public static readonly string centerFieldUssClassName; //Field offset: 0x18
	public static readonly string extentsFieldUssClassName; //Field offset: 0x20
	private Vector3Field m_CenterField; //Field offset: 0x458
	private Vector3Field m_ExtentsField; //Field offset: 0x460

	private static BoundsField() { }

	public BoundsField() { }

	public BoundsField(string label) { }

	[CompilerGenerated]
	private void <.ctor>b__10_0(ChangeEvent<Vector3> e) { }

	[CompilerGenerated]
	private void <.ctor>b__10_1(ChangeEvent<Vector3> e) { }

	public virtual void SetValueWithoutNotify(Bounds newValue) { }

	protected virtual void UpdateMixedValueContent() { }

}

