namespace UnityEngine.UIElements;

[MovedFrom(True, "UnityEditor.UIElements", "UnityEditor.UIElementsModule", null)]
public class BoundsIntField : BaseField<BoundsInt>
{
	internal class UxmlFactory : UxmlFactory<BoundsIntField, UxmlTraits>
	{

		public UxmlFactory() { }

	}

	internal class UxmlTraits : UxmlTraits<BoundsInt>
	{
		private UxmlIntAttributeDescription m_PositionXValue; //Field offset: 0x80
		private UxmlIntAttributeDescription m_PositionYValue; //Field offset: 0x88
		private UxmlIntAttributeDescription m_PositionZValue; //Field offset: 0x90
		private UxmlIntAttributeDescription m_SizeXValue; //Field offset: 0x98
		private UxmlIntAttributeDescription m_SizeYValue; //Field offset: 0xA0
		private UxmlIntAttributeDescription m_SizeZValue; //Field offset: 0xA8

		public UxmlTraits() { }

		public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	}

	public static readonly string ussClassName; //Field offset: 0x0
	public static readonly string labelUssClassName; //Field offset: 0x8
	public static readonly string inputUssClassName; //Field offset: 0x10
	public static readonly string positionUssClassName; //Field offset: 0x18
	public static readonly string sizeUssClassName; //Field offset: 0x20
	private Vector3IntField m_PositionField; //Field offset: 0x458
	private Vector3IntField m_SizeField; //Field offset: 0x460

	private static BoundsIntField() { }

	public BoundsIntField() { }

	public BoundsIntField(string label) { }

	[CompilerGenerated]
	private void <.ctor>b__10_0(ChangeEvent<Vector3Int> e) { }

	[CompilerGenerated]
	private void <.ctor>b__10_1(ChangeEvent<Vector3Int> e) { }

	public virtual void SetValueWithoutNotify(BoundsInt newValue) { }

	protected virtual void UpdateMixedValueContent() { }

}

