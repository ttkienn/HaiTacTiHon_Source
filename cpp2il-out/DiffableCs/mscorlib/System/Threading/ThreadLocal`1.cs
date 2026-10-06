namespace System.Threading;

[DebuggerDisplay("IsValueCreated={IsValueCreated}, Value={ValueForDebugDisplay}, Count={ValuesCountForDebugDisplay}")]
[DebuggerTypeProxy(typeof(SystemThreading_ThreadLocalDebugView`1))]
public class ThreadLocal : IDisposable
{
	private class FinalizationHelper
	{
		internal LinkedSlotVolatile<T>[] SlotArray; //Field offset: 0x0
		private bool m_trackAllValues; //Field offset: 0x0

		internal FinalizationHelper(LinkedSlotVolatile<T>[] slotArray, bool trackAllValues) { }

		protected virtual void Finalize() { }

	}

	private class IdManager
	{
		private int m_nextIdToTry; //Field offset: 0x0
		private List<Boolean> m_freeIds; //Field offset: 0x0

		public IdManager() { }

		internal int GetId() { }

		internal void ReturnId(int id) { }

	}

	private sealed class LinkedSlot
	{
		internal LinkedSlot<T> Next; //Field offset: 0x0
		internal LinkedSlot<T> Previous; //Field offset: 0x0
		internal LinkedSlotVolatile<T>[] SlotArray; //Field offset: 0x0
		internal T Value; //Field offset: 0x0

		internal LinkedSlot(LinkedSlotVolatile<T>[] slotArray) { }

	}

	private struct LinkedSlotVolatile
	{
		internal LinkedSlot<T> Value; //Field offset: 0x0

	}

	[ThreadStatic]
	private static LinkedSlotVolatile<T>[] ts_slotArray; //Field offset: 0xFFFFFFFF
	[ThreadStatic]
	private static FinalizationHelper<T> ts_finalizationHelper; //Field offset: 0xFFFFFFFF
	private static IdManager<T> s_idManager; //Field offset: 0x0
	private Func<T> m_valueFactory; //Field offset: 0x0
	private int m_idComplement; //Field offset: 0x0
	private bool m_initialized; //Field offset: 0x0
	private LinkedSlot<T> m_linkedSlot; //Field offset: 0x0
	private bool m_trackAllValues; //Field offset: 0x0

	public bool IsValueCreated
	{
		 get { } //Length: 261
	}

	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	public T Value
	{
		 get { } //Length: 240
		 set { } //Length: 258
	}

	private static ThreadLocal`1() { }

	public ThreadLocal`1() { }

	private void CreateLinkedSlot(LinkedSlotVolatile<T>[] slotArray, int id, T value) { }

	public override void Dispose() { }

	protected override void Dispose(bool disposing) { }

	protected virtual void Finalize() { }

	public bool get_IsValueCreated() { }

	public T get_Value() { }

	private static int GetNewTableSize(int minSize) { }

	private T GetValueSlow() { }

	private void GrowTable(ref LinkedSlotVolatile<T>[] table, int minLength) { }

	private void Initialize(Func<T> valueFactory, bool trackAllValues) { }

	public void set_Value(T value) { }

	private void SetValueSlow(T value, LinkedSlotVolatile<T>[] slotArray) { }

	public virtual string ToString() { }

}

