namespace UnityEngine.UIElements;

internal class EventCallbackRegistry
{
	private static readonly EventCallbackListPool s_ListPool; //Field offset: 0x0
	private EventCallbackList m_Callbacks; //Field offset: 0x10
	private EventCallbackList m_TemporaryCallbacks; //Field offset: 0x18
	private int m_IsInvoking; //Field offset: 0x20

	private static EventCallbackRegistry() { }

	public EventCallbackRegistry() { }

	private static EventCallbackList GetCallbackList(EventCallbackList initializer = null) { }

	private EventCallbackList GetCallbackListForReading() { }

	private EventCallbackList GetCallbackListForWriting() { }

	public bool HasBubbleHandlers() { }

	public bool HasTrickleDownHandlers() { }

	public void InvokeCallbacks(EventBase evt, PropagationPhase propagationPhase) { }

	public void RegisterCallback(EventCallback<TEventType> callback, TrickleDown useTrickleDown = 0, InvokePolicy invokePolicy = 0) { }

	public void RegisterCallback(EventCallback<TEventType, TCallbackArgs> callback, TCallbackArgs userArgs, TrickleDown useTrickleDown = 0, InvokePolicy invokePolicy = 0) { }

	private static void ReleaseCallbackList(EventCallbackList toRelease) { }

	private bool UnregisterCallback(long eventTypeId, Delegate callback, TrickleDown useTrickleDown) { }

	public bool UnregisterCallback(EventCallback<TEventType> callback, TrickleDown useTrickleDown = 0) { }

}

