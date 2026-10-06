namespace UnityEngine.UIElements;

[MovedFrom(True, "UnityEditor.UIElements", "UnityEditor.UIElementsModule", null)]
public class RectIntField : BaseCompositeField<RectInt, IntegerField, Int32>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<RectInt, Int32> <>9__0_0; //Field offset: 0x8
		public static WriteDelegate<RectInt, IntegerField, Int32> <>9__0_1; //Field offset: 0x10
		public static Func<RectInt, Int32> <>9__0_2; //Field offset: 0x18
		public static WriteDelegate<RectInt, IntegerField, Int32> <>9__0_3; //Field offset: 0x20
		public static Func<RectInt, Int32> <>9__0_4; //Field offset: 0x28
		public static WriteDelegate<RectInt, IntegerField, Int32> <>9__0_5; //Field offset: 0x30
		public static Func<RectInt, Int32> <>9__0_6; //Field offset: 0x38
		public static WriteDelegate<RectInt, IntegerField, Int32> <>9__0_7; //Field offset: 0x40

		private static <>c() { }

		public <>c() { }

		internal int <DescribeFields>b__0_0(RectInt r) { }

		internal void <DescribeFields>b__0_1(ref RectInt r, int v) { }

		internal int <DescribeFields>b__0_2(RectInt r) { }

		internal void <DescribeFields>b__0_3(ref RectInt r, int v) { }

		internal int <DescribeFields>b__0_4(RectInt r) { }

		internal void <DescribeFields>b__0_5(ref RectInt r, int v) { }

		internal int <DescribeFields>b__0_6(RectInt r) { }

		internal void <DescribeFields>b__0_7(ref RectInt r, int v) { }

	}

	internal class UxmlFactory : UxmlFactory<RectIntField, UxmlTraits>
	{

		public UxmlFactory() { }

	}

	internal class UxmlTraits : UxmlTraits<RectInt>
	{
		private UxmlIntAttributeDescription m_XValue; //Field offset: 0x80
		private UxmlIntAttributeDescription m_YValue; //Field offset: 0x88
		private UxmlIntAttributeDescription m_WValue; //Field offset: 0x90
		private UxmlIntAttributeDescription m_HValue; //Field offset: 0x98

		public UxmlTraits() { }

		public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	}

	public static readonly string ussClassName; //Field offset: 0x0
	public static readonly string labelUssClassName; //Field offset: 0x8
	public static readonly string inputUssClassName; //Field offset: 0x10

	private static RectIntField() { }

	public RectIntField() { }

	public RectIntField(string label) { }

	internal virtual FieldDescription<RectInt, IntegerField, Int32>[] DescribeFields() { }

}

