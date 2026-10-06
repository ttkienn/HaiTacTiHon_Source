namespace UnityEngine.UIElements;

[MovedFrom(True, "UnityEditor.UIElements", "UnityEditor.UIElementsModule", null)]
public class RectField : BaseCompositeField<Rect, FloatField, Single>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Rect, Single> <>9__0_0; //Field offset: 0x8
		public static WriteDelegate<Rect, FloatField, Single> <>9__0_1; //Field offset: 0x10
		public static Func<Rect, Single> <>9__0_2; //Field offset: 0x18
		public static WriteDelegate<Rect, FloatField, Single> <>9__0_3; //Field offset: 0x20
		public static Func<Rect, Single> <>9__0_4; //Field offset: 0x28
		public static WriteDelegate<Rect, FloatField, Single> <>9__0_5; //Field offset: 0x30
		public static Func<Rect, Single> <>9__0_6; //Field offset: 0x38
		public static WriteDelegate<Rect, FloatField, Single> <>9__0_7; //Field offset: 0x40

		private static <>c() { }

		public <>c() { }

		internal float <DescribeFields>b__0_0(Rect r) { }

		internal void <DescribeFields>b__0_1(ref Rect r, float v) { }

		internal float <DescribeFields>b__0_2(Rect r) { }

		internal void <DescribeFields>b__0_3(ref Rect r, float v) { }

		internal float <DescribeFields>b__0_4(Rect r) { }

		internal void <DescribeFields>b__0_5(ref Rect r, float v) { }

		internal float <DescribeFields>b__0_6(Rect r) { }

		internal void <DescribeFields>b__0_7(ref Rect r, float v) { }

	}

	internal class UxmlFactory : UxmlFactory<RectField, UxmlTraits>
	{

		public UxmlFactory() { }

	}

	internal class UxmlTraits : UxmlTraits<Rect>
	{
		private UxmlFloatAttributeDescription m_XValue; //Field offset: 0x80
		private UxmlFloatAttributeDescription m_YValue; //Field offset: 0x88
		private UxmlFloatAttributeDescription m_WValue; //Field offset: 0x90
		private UxmlFloatAttributeDescription m_HValue; //Field offset: 0x98

		public UxmlTraits() { }

		public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	}

	public static readonly string ussClassName; //Field offset: 0x0
	public static readonly string labelUssClassName; //Field offset: 0x8
	public static readonly string inputUssClassName; //Field offset: 0x10

	private static RectField() { }

	public RectField() { }

	public RectField(string label) { }

	internal virtual FieldDescription<Rect, FloatField, Single>[] DescribeFields() { }

}

