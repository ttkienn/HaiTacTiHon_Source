namespace UnityEngine.UI;

public static class LayoutUtility
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<ILayoutElement, Single> <>9__3_0; //Field offset: 0x8
		public static Func<ILayoutElement, Single> <>9__4_0; //Field offset: 0x10
		public static Func<ILayoutElement, Single> <>9__4_1; //Field offset: 0x18
		public static Func<ILayoutElement, Single> <>9__5_0; //Field offset: 0x20
		public static Func<ILayoutElement, Single> <>9__6_0; //Field offset: 0x28
		public static Func<ILayoutElement, Single> <>9__7_0; //Field offset: 0x30
		public static Func<ILayoutElement, Single> <>9__7_1; //Field offset: 0x38
		public static Func<ILayoutElement, Single> <>9__8_0; //Field offset: 0x40

		private static <>c() { }

		public <>c() { }

		internal float <GetFlexibleHeight>b__8_0(ILayoutElement e) { }

		internal float <GetFlexibleWidth>b__5_0(ILayoutElement e) { }

		internal float <GetMinHeight>b__6_0(ILayoutElement e) { }

		internal float <GetMinWidth>b__3_0(ILayoutElement e) { }

		internal float <GetPreferredHeight>b__7_0(ILayoutElement e) { }

		internal float <GetPreferredHeight>b__7_1(ILayoutElement e) { }

		internal float <GetPreferredWidth>b__4_0(ILayoutElement e) { }

		internal float <GetPreferredWidth>b__4_1(ILayoutElement e) { }

	}


	public static float GetFlexibleHeight(RectTransform rect) { }

	public static float GetFlexibleSize(RectTransform rect, int axis) { }

	public static float GetFlexibleWidth(RectTransform rect) { }

	public static float GetLayoutProperty(RectTransform rect, Func<ILayoutElement, Single> property, float defaultValue) { }

	public static float GetLayoutProperty(RectTransform rect, Func<ILayoutElement, Single> property, float defaultValue, out ILayoutElement source) { }

	public static float GetMinHeight(RectTransform rect) { }

	public static float GetMinSize(RectTransform rect, int axis) { }

	public static float GetMinWidth(RectTransform rect) { }

	public static float GetPreferredHeight(RectTransform rect) { }

	public static float GetPreferredSize(RectTransform rect, int axis) { }

	public static float GetPreferredWidth(RectTransform rect) { }

}

