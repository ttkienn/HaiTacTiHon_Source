namespace UnityEngine.UIElements;

[MovedFrom(True, "UnityEditor.UIElements", "UnityEditor.UIElementsModule", null)]
public class Vector2Field : BaseCompositeField<Vector2, FloatField, Single>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Vector2, Single> <>9__0_0; //Field offset: 0x8
		public static WriteDelegate<Vector2, FloatField, Single> <>9__0_1; //Field offset: 0x10
		public static Func<Vector2, Single> <>9__0_2; //Field offset: 0x18
		public static WriteDelegate<Vector2, FloatField, Single> <>9__0_3; //Field offset: 0x20

		private static <>c() { }

		public <>c() { }

		internal float <DescribeFields>b__0_0(Vector2 r) { }

		internal void <DescribeFields>b__0_1(ref Vector2 r, float v) { }

		internal float <DescribeFields>b__0_2(Vector2 r) { }

		internal void <DescribeFields>b__0_3(ref Vector2 r, float v) { }

	}

	internal class UxmlFactory : UxmlFactory<Vector2Field, UxmlTraits>
	{

		public UxmlFactory() { }

	}

	internal class UxmlTraits : UxmlTraits<Vector2>
	{
		private UxmlFloatAttributeDescription m_XValue; //Field offset: 0x80
		private UxmlFloatAttributeDescription m_YValue; //Field offset: 0x88

		public UxmlTraits() { }

		public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	}

	public static readonly string ussClassName; //Field offset: 0x0
	public static readonly string labelUssClassName; //Field offset: 0x8
	public static readonly string inputUssClassName; //Field offset: 0x10

	private static Vector2Field() { }

	public Vector2Field() { }

	public Vector2Field(string label) { }

	internal virtual FieldDescription<Vector2, FloatField, Single>[] DescribeFields() { }

}

