namespace UnityEngine.UI;

[AddComponentMenu("Layout/Vertical Layout Group", 151)]
public class VerticalLayoutGroup : HorizontalOrVerticalLayoutGroup
{

	protected VerticalLayoutGroup() { }

	public virtual void CalculateLayoutInputHorizontal() { }

	public virtual void CalculateLayoutInputVertical() { }

	public virtual void SetLayoutHorizontal() { }

	public virtual void SetLayoutVertical() { }

}

