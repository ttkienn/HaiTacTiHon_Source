namespace UnityEngine.UI;

public interface IClippable
{

	public GameObject gameObject
	{
		 get { } //Length: 0
	}

	public RectTransform rectTransform
	{
		 get { } //Length: 0
	}

	public void Cull(Rect clipRect, bool validRect) { }

	public GameObject get_gameObject() { }

	public RectTransform get_rectTransform() { }

	public void RecalculateClipping() { }

	public void SetClipRect(Rect value, bool validRect) { }

	public void SetClipSoftness(Vector2 clipSoftness) { }

}

