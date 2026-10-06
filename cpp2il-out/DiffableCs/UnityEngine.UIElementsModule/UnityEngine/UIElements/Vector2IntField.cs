namespace UnityEngine.UIElements;

[MovedFrom(True, "UnityEditor.UIElements", "UnityEditor.UIElementsModule", null)]
public class Vector2IntField : BaseCompositeField<Vector2Int, IntegerField, Int32>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Vector2Int, Int32> <>9__0_0; //Field offset: 0x8
		public static WriteDelegate<Vector2Int, IntegerField, Int32> <>9__0_1; //Field offset: 0x10
		public static Func<Vector2Int, Int32> <>9__0_2; //Field offset: 0x18
		public static WriteDelegate<Vector2Int, IntegerField, Int32> <>9__0_3; //Field offset: 0x20

		private static <>c() { }

		public <>c() { }

		internal int <DescribeFields>b__0_0(Vector2Int r) { }

		internal void <DescribeFields>b__0_1(ref Vector2Int r, int v) { }

		internal int <DescribeFields>b__0_2(Vector2Int r) { }

		internal void <DescribeFields>b__0_3(ref Vector2Int r, int v) { }

	}

	internal class UxmlFactory : UxmlFactory<Vector2IntField, UxmlTraits>
	{

		public UxmlFactory() { }

	}

	internal class UxmlTraits : UxmlTraits<Vector2Int>
	{
		private UxmlIntAttributeDescription m_XValue; //Field offset: 0x80
		private UxmlIntAttributeDescription m_YValue; //Field offset: 0x88

		public UxmlTraits() { }

		public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	}

	public static readonly string ussClassName; //Field offset: 0x0
	public static readonly string labelUssClassName; //Field offset: 0x8
	public static readonly string inputUssClassName; //Field offset: 0x10

	private static Vector2IntField() { }

	public Vector2IntField() { }

	public Vector2IntField(string label) { }

	internal virtual FieldDescription<Vector2Int, IntegerField, Int32>[] DescribeFields() { }

}

