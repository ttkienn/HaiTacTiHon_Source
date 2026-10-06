namespace UnityEngine.UIElements;

[MovedFrom(True, "UnityEditor.UIElements", "UnityEditor.UIElementsModule", null)]
public class Vector3Field : BaseCompositeField<Vector3, FloatField, Single>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Vector3, Single> <>9__0_0; //Field offset: 0x8
		public static WriteDelegate<Vector3, FloatField, Single> <>9__0_1; //Field offset: 0x10
		public static Func<Vector3, Single> <>9__0_2; //Field offset: 0x18
		public static WriteDelegate<Vector3, FloatField, Single> <>9__0_3; //Field offset: 0x20
		public static Func<Vector3, Single> <>9__0_4; //Field offset: 0x28
		public static WriteDelegate<Vector3, FloatField, Single> <>9__0_5; //Field offset: 0x30

		private static <>c() { }

		public <>c() { }

		internal float <DescribeFields>b__0_0(Vector3 r) { }

		internal void <DescribeFields>b__0_1(ref Vector3 r, float v) { }

		internal float <DescribeFields>b__0_2(Vector3 r) { }

		internal void <DescribeFields>b__0_3(ref Vector3 r, float v) { }

		internal float <DescribeFields>b__0_4(Vector3 r) { }

		internal void <DescribeFields>b__0_5(ref Vector3 r, float v) { }

	}

	internal class UxmlFactory : UxmlFactory<Vector3Field, UxmlTraits>
	{

		public UxmlFactory() { }

	}

	internal class UxmlTraits : UxmlTraits<Vector3>
	{
		private UxmlFloatAttributeDescription m_XValue; //Field offset: 0x80
		private UxmlFloatAttributeDescription m_YValue; //Field offset: 0x88
		private UxmlFloatAttributeDescription m_ZValue; //Field offset: 0x90

		public UxmlTraits() { }

		public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	}

	public static readonly string ussClassName; //Field offset: 0x0
	public static readonly string labelUssClassName; //Field offset: 0x8
	public static readonly string inputUssClassName; //Field offset: 0x10

	private static Vector3Field() { }

	public Vector3Field() { }

	public Vector3Field(string label) { }

	internal virtual FieldDescription<Vector3, FloatField, Single>[] DescribeFields() { }

}

