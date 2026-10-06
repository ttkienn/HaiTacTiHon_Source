namespace UnityEngine.UIElements;

internal class SerializedVirtualizationData
{
	public Vector2 scrollOffset; //Field offset: 0x10
	public int firstVisibleIndex; //Field offset: 0x18
	public float contentPadding; //Field offset: 0x1C
	public float contentHeight; //Field offset: 0x20
	public int anchoredItemIndex; //Field offset: 0x24
	public float anchorOffset; //Field offset: 0x28

	public SerializedVirtualizationData() { }

}

