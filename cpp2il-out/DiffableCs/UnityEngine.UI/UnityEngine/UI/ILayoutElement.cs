namespace UnityEngine.UI;

public interface ILayoutElement
{

	public float flexibleHeight
	{
		 get { } //Length: 0
	}

	public float flexibleWidth
	{
		 get { } //Length: 0
	}

	public int layoutPriority
	{
		 get { } //Length: 0
	}

	public float minHeight
	{
		 get { } //Length: 0
	}

	public float minWidth
	{
		 get { } //Length: 0
	}

	public float preferredHeight
	{
		 get { } //Length: 0
	}

	public float preferredWidth
	{
		 get { } //Length: 0
	}

	public void CalculateLayoutInputHorizontal() { }

	public void CalculateLayoutInputVertical() { }

	public float get_flexibleHeight() { }

	public float get_flexibleWidth() { }

	public int get_layoutPriority() { }

	public float get_minHeight() { }

	public float get_minWidth() { }

	public float get_preferredHeight() { }

	public float get_preferredWidth() { }

}

