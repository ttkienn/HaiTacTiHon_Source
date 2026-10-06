namespace System.Buffers;

internal sealed class TlsOverPerCoreLockedStacksArrayPool : ArrayPool<T>
{
	private sealed class LockedStack
	{
		private readonly T[][] _arrays; //Field offset: 0x0
		private int _count; //Field offset: 0x0
		private uint _firstStackItemMS; //Field offset: 0x0

		public LockedStack() { }

		public void Trim(uint tickCount, int id, MemoryPressure<T> pressure, int bucketSize) { }

		public T[] TryPop() { }

		public bool TryPush(T[] array) { }

	}

	private enum MemoryPressure
	{
		Low = 0,
		Medium = 1,
		High = 2,
	}

	private sealed class PerCoreLockedStacks
	{
		private readonly LockedStack<T>[] _perCoreStacks; //Field offset: 0x0

		public PerCoreLockedStacks() { }

		public bool Trim(uint tickCount, int id, MemoryPressure<T> pressure, Int32[] bucketSizes) { }

		public T[] TryPop() { }

		public void TryPush(T[] array) { }

	}

	[ThreadStatic]
	private static T[][] t_tlsBuckets; //Field offset: 0xFFFFFFFF
	private static readonly bool s_trimBuffers; //Field offset: 0x0
	private static readonly ConditionalWeakTable<T[][], Object> s_allTlsBuckets; //Field offset: 0x0
	private readonly Int32[] _bucketArraySizes; //Field offset: 0x0
	private readonly PerCoreLockedStacks<T>[] _buckets; //Field offset: 0x0
	private int _callbackCreated; //Field offset: 0x0

	private int Id
	{
		private get { } //Length: 38
	}

	private static TlsOverPerCoreLockedStacksArrayPool`1() { }

	public TlsOverPerCoreLockedStacksArrayPool`1() { }

	private PerCoreLockedStacks<T> CreatePerCoreLockedStacks(int bucketIndex) { }

	private static bool Gen2GcCallbackFunc(object target) { }

	private int get_Id() { }

	private static MemoryPressure<T> GetMemoryPressure() { }

	private static bool GetTrimBuffers() { }

	public virtual T[] Rent(int minimumLength) { }

	public virtual void Return(T[] array, bool clearArray = false) { }

	public bool Trim() { }

}

