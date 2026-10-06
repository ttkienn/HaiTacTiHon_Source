namespace UnityEngine.UIElements;

[EventCategory(EventCategory::Default (0))]
public abstract class EventBase : EventBase
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c<T> <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal T <.cctor>b__15_0() { }

	}

	private static readonly long s_TypeId; //Field offset: 0x0
	private static readonly ObjectPool<T> s_Pool; //Field offset: 0x0
	internal static readonly EventCategory EventCategory; //Field offset: 0x0
	private int m_RefCount; //Field offset: 0x0

	public virtual long eventTypeId
	{
		 get { } //Length: 119
	}

	private static EventBase`1() { }

	protected EventBase`1() { }

	internal virtual void Acquire() { }

	public virtual void Dispose() { }

	public virtual long get_eventTypeId() { }

	public static T GetPooled() { }

	internal static T GetPooled(EventBase e) { }

	protected virtual void Init() { }

	private static void ReleasePooled(T evt) { }

	internal static void SetCreateFunction(Func<T> createMethod) { }

	public static long TypeId() { }

}

