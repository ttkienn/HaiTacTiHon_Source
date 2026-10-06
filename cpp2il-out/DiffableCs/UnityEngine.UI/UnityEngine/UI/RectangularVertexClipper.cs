namespace UnityEngine.UI;

internal class RectangularVertexClipper
{
	private readonly Vector3[] m_WorldCorners; //Field offset: 0x10
	private readonly Vector3[] m_CanvasCorners; //Field offset: 0x18

	public RectangularVertexClipper() { }

	public Rect GetCanvasRect(RectTransform t, Canvas c) { }

}

