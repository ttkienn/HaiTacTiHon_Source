namespace UnityEngine;

internal sealed class GUIScrollGroup : GUILayoutGroup
{
	public float calcMinWidth; //Field offset: 0x90
	public float calcMaxWidth; //Field offset: 0x94
	public float calcMinHeight; //Field offset: 0x98
	public float calcMaxHeight; //Field offset: 0x9C
	public float clientWidth; //Field offset: 0xA0
	public float clientHeight; //Field offset: 0xA4
	public bool allowHorizontalScroll; //Field offset: 0xA8
	public bool allowVerticalScroll; //Field offset: 0xA9
	public bool needsHorizontalScrollbar; //Field offset: 0xAA
	public bool needsVerticalScrollbar; //Field offset: 0xAB
	public GUIStyle horizontalScrollbar; //Field offset: 0xB0
	public GUIStyle verticalScrollbar; //Field offset: 0xB8

	[RequiredByNativeCode]
	public GUIScrollGroup() { }

	public virtual void CalcHeight() { }

	public virtual void CalcWidth() { }

	public virtual void SetHorizontal(float x, float width) { }

	public virtual void SetVertical(float y, float height) { }

}

