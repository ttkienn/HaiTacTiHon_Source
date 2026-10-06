namespace UnityEngine.UIElements;

public struct EventDispatcherGate : IDisposable, IEquatable<EventDispatcherGate>
{
	private readonly EventDispatcher m_Dispatcher; //Field offset: 0x0

	public EventDispatcherGate(EventDispatcher d) { }

	public override void Dispose() { }

	public override bool Equals(EventDispatcherGate other) { }

	public virtual bool Equals(object obj) { }

	public virtual int GetHashCode() { }

}

