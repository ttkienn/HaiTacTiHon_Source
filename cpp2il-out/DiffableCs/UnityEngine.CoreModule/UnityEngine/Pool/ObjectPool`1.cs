namespace UnityEngine.Pool;

public class ObjectPool : IDisposable, IPool, IObjectPool<T>
{
	internal readonly List<T> m_List; //Field offset: 0x0
	private readonly Func<T> m_CreateFunc; //Field offset: 0x0
	private readonly Action<T> m_ActionOnGet; //Field offset: 0x0
	private readonly Action<T> m_ActionOnRelease; //Field offset: 0x0
	private readonly Action<T> m_ActionOnDestroy; //Field offset: 0x0
	private readonly int m_MaxSize; //Field offset: 0x0
	internal bool m_CollectionCheck; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private int <CountAll>k__BackingField; //Field offset: 0x0

	public private int CountAll
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public override int CountInactive
	{
		 get { } //Length: 26
	}

	public ObjectPool`1(Func<T> createFunc, Action<T> actionOnGet = null, Action<T> actionOnRelease = null, Action<T> actionOnDestroy = null, bool collectionCheck = true, int defaultCapacity = 10, int maxSize = 10000) { }

	public override void Clear() { }

	public override void Dispose() { }

	public override T Get() { }

	public override PooledObject<T> Get(out T v) { }

	[CompilerGenerated]
	public int get_CountAll() { }

	public override int get_CountInactive() { }

	public override void Release(T element) { }

	[CompilerGenerated]
	private void set_CountAll(int value) { }

}

