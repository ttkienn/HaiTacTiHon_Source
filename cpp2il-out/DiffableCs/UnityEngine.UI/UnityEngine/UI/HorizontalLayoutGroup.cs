namespace UnityEngine.UI;

[AddComponentMenu("Layout/Horizontal Layout Group", 150)]
public class HorizontalLayoutGroup : HorizontalOrVerticalLayoutGroup
{

	protected HorizontalLayoutGroup() { }

	public virtual void CalculateLayoutInputHorizontal() { }

	public virtual void CalculateLayoutInputVertical() { }

	public virtual void SetLayoutHorizontal() { }

	public virtual void SetLayoutVertical() { }

}

