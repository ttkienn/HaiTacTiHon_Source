namespace UnityEngine.UI;

[EditorBrowsable(EditorBrowsableState::Never (1))]
[Obsolete("Not supported anymore.", True)]
public interface IMask
{

	public RectTransform rectTransform
	{
		 get { } //Length: 0
	}

	public bool Enabled() { }

	public RectTransform get_rectTransform() { }

}

