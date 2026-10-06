namespace UnityEngine;

internal struct SliderHandler
{
	private readonly Rect position; //Field offset: 0x0
	private readonly float currentValue; //Field offset: 0x10
	private readonly float size; //Field offset: 0x14
	private readonly float start; //Field offset: 0x18
	private readonly float end; //Field offset: 0x1C
	private readonly GUIStyle slider; //Field offset: 0x20
	private readonly GUIStyle thumb; //Field offset: 0x28
	private readonly GUIStyle thumbExtent; //Field offset: 0x30
	private readonly bool horiz; //Field offset: 0x38
	private readonly int id; //Field offset: 0x3C

	public SliderHandler(Rect position, float currentValue, float size, float start, float end, GUIStyle slider, GUIStyle thumb, bool horiz, int id, GUIStyle thumbExtent = null) { }

	private float Clamp(float value) { }

	private float ClampedCurrentValue() { }

	private Event CurrentEvent() { }

	private EventType CurrentEventType() { }

	private int CurrentScrollTroughSide() { }

	public float Handle() { }

	private Rect HorizontalThumbRect() { }

	private bool IsEmptySlider() { }

	private float MaxValue() { }

	private float MinValue() { }

	private float MousePosition() { }

	private float OnMouseDown() { }

	private float OnMouseDrag() { }

	private float OnMouseUp() { }

	private float OnRepaint() { }

	private float PageMovementValue() { }

	private float PageUpMovementBound() { }

	private SliderState SliderState() { }

	private void StartDraggingWithValue(float dragStartValue) { }

	private bool SupportsPageMovements() { }

	private Rect ThumbExtRect() { }

	private Rect ThumbRect() { }

	private Rect ThumbSelectionRect() { }

	private float ThumbSize() { }

	private float ValueForCurrentMousePosition() { }

	private float ValuesPerPixel() { }

	private Rect VerticalThumbRect() { }

}

