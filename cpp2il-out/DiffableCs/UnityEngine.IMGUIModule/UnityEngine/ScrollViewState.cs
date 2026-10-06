namespace UnityEngine;

internal class ScrollViewState
{
	public Rect position; //Field offset: 0x10
	public Rect visibleRect; //Field offset: 0x20
	public Rect viewRect; //Field offset: 0x30
	public Vector2 scrollPosition; //Field offset: 0x40
	public bool apply; //Field offset: 0x48
	public bool isDuringTouchScroll; //Field offset: 0x49
	public Vector2 touchScrollStartMousePosition; //Field offset: 0x4C
	public Vector2 touchScrollStartPosition; //Field offset: 0x54
	public Vector2 velocity; //Field offset: 0x5C
	public float previousTimeSinceStartup; //Field offset: 0x64

	[RequiredByNativeCode]
	public ScrollViewState() { }

}

