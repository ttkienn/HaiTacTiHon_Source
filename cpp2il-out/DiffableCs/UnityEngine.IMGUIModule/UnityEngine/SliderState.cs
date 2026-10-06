namespace UnityEngine;

internal class SliderState
{
	public float dragStartPos; //Field offset: 0x10
	public float dragStartValue; //Field offset: 0x14
	public bool isDragging; //Field offset: 0x18

	[RequiredByNativeCode]
	public SliderState() { }

}

