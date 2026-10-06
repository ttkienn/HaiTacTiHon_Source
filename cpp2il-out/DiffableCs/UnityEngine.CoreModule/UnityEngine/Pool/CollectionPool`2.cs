namespace UnityEngine.Pool;

public class CollectionPool
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c<TCollection, TItem> <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal TCollection <.cctor>b__5_0() { }

		internal void <.cctor>b__5_1(TCollection l) { }

	}

	internal static readonly ObjectPool<TCollection> s_Pool; //Field offset: 0x0

	private static CollectionPool`2() { }

	public static TCollection Get() { }

	public static PooledObject<TCollection> Get(out TCollection value) { }

	public static void Release(TCollection toRelease) { }

}

