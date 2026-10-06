namespace UnityEngine.UI;

public interface ICanvasElement
{

	public Transform transform
	{
		 get { } //Length: 0
	}

	public Transform get_transform() { }

	public void GraphicUpdateComplete() { }

	public bool IsDestroyed() { }

	public void LayoutComplete() { }

	public void Rebuild(CanvasUpdate executing) { }

}

