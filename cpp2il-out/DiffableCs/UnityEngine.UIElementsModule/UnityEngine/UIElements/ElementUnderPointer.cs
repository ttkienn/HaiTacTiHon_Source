namespace UnityEngine.UIElements;

internal class ElementUnderPointer
{
	private VisualElement[] m_PendingTopElementUnderPointer; //Field offset: 0x10
	private VisualElement[] m_TopElementUnderPointer; //Field offset: 0x18
	private IPointerEvent[] m_TriggerPointerEvent; //Field offset: 0x20
	private IMouseEvent[] m_TriggerMouseEvent; //Field offset: 0x28
	private Vector2[] m_PickingPointerPositions; //Field offset: 0x30
	private Boolean[] m_IsPickingPointerTemporaries; //Field offset: 0x38

	public ElementUnderPointer() { }

	internal void CommitElementUnderPointers(EventDispatcher dispatcher, ContextType contextType) { }

	private Vector2 GetEventPointerPosition(EventBase triggerEvent) { }

	internal VisualElement GetTopElementUnderPointer(int pointerId, out Vector2 pickPosition, out bool isTemporary) { }

	internal VisualElement GetTopElementUnderPointer(int pointerId) { }

	internal void SetElementUnderPointer(VisualElement newElementUnderPointer, int pointerId, Vector2 pointerPos) { }

	internal void SetElementUnderPointer(VisualElement newElementUnderPointer, int pointerId, EventBase triggerEvent) { }

	private void SetElementUnderPointer(VisualElement newElementUnderPointer, int pointerId, EventBase triggerEvent, bool temporary) { }

	internal void SetTemporaryElementUnderPointer(VisualElement newElementUnderPointer, int pointerId, EventBase triggerEvent) { }

}

