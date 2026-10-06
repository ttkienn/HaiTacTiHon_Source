namespace UnityEngine.UIElements;

internal interface IStylePainter
{

	public void DrawImmediate(Action callback, bool cullingEnabled) { }

	public void DrawRectangle(RectangleParams rectParams) { }

	public void DrawText(TextElement te) { }

}

