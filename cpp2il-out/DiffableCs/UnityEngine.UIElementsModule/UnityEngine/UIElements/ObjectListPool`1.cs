namespace UnityEngine.UIElements;

internal class ObjectListPool
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c<T> <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal List<T> <.cctor>b__4_0() { }

	}

	private static ObjectPool<List`1<T>> pool; //Field offset: 0x0

	private static ObjectListPool`1() { }

	public static List<T> Get() { }

	public static void Release(List<T> elements) { }

}

