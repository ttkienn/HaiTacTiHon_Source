namespace UnityEngine.UIElements.UIR;

internal class LinkedPool
{
	private readonly Func<T> m_CreateFunc; //Field offset: 0x0
	private readonly Action<T> m_ResetAction; //Field offset: 0x0
	private readonly int m_Limit; //Field offset: 0x0
	private T m_PoolFirst; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private int <Count>k__BackingField; //Field offset: 0x0

	public private int Count
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public LinkedPool`1(Func<T> createFunc, Action<T> resetAction, int limit = 10000) { }

	public void Clear() { }

	public T Get() { }

	[CompilerGenerated]
	public int get_Count() { }

	public void Return(T item) { }

	[CompilerGenerated]
	private void set_Count(int value) { }

}

