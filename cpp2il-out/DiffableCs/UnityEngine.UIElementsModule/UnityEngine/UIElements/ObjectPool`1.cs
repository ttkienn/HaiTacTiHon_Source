namespace UnityEngine.UIElements;

internal class ObjectPool
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c<T> <>9; //Field offset: 0x0
		public static Func<T> <>9__6_0; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal T <.ctor>b__6_0() { }

	}

	private readonly Stack<T> m_Stack; //Field offset: 0x0
	private int m_MaxSize; //Field offset: 0x0
	internal Func<T> CreateFunc; //Field offset: 0x0

	public int maxSize
	{
		 get { } //Length: 6
		 set { } //Length: 219
	}

	public ObjectPool`1(Func<T> CreateFunc, int maxSize = 100) { }

	public T Get() { }

	public int get_maxSize() { }

	public void Release(T element) { }

	public void set_maxSize(int value) { }

	public int Size() { }

}

