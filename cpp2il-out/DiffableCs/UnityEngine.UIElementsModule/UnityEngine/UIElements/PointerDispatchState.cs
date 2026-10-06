namespace UnityEngine.UIElements;

internal class PointerDispatchState
{
	private IEventHandler[] m_PendingPointerCapture; //Field offset: 0x10
	private IEventHandler[] m_PointerCapture; //Field offset: 0x18
	private Boolean[] m_ShouldSendCompatibilityMouseEvents; //Field offset: 0x20

	public PointerDispatchState() { }

	public void ActivateCompatibilityMouseEvents(int pointerId) { }

	public void CapturePointer(IEventHandler handler, int pointerId) { }

	public IEventHandler GetCapturingElement(int pointerId) { }

	public bool HasPointerCapture(IEventHandler handler, int pointerId) { }

	public void PreventCompatibilityMouseEvents(int pointerId) { }

	public void ProcessPointerCapture(int pointerId) { }

	public void ReleasePointer(int pointerId) { }

	public void ReleasePointer(IEventHandler handler, int pointerId) { }

	internal void Reset() { }

	public bool ShouldSendCompatibilityMouseEvents(IPointerEvent evt) { }

}

