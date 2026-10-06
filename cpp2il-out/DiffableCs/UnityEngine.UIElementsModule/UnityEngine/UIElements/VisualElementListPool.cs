namespace UnityEngine.UIElements;

internal static class VisualElementListPool
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal List<VisualElement> <.cctor>b__4_0() { }

	}

	private static ObjectPool<List`1<VisualElement>> pool; //Field offset: 0x0

	private static VisualElementListPool() { }

	public static List<VisualElement> Copy(List<VisualElement> elements) { }

	public static List<VisualElement> Get(int initialCapacity = 0) { }

	public static void Release(List<VisualElement> elements) { }

}

