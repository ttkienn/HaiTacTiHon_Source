namespace UnityEngine.UI;

[ExecuteAlways]
public abstract class HorizontalOrVerticalLayoutGroup : LayoutGroup
{
	[SerializeField]
	protected float m_Spacing; //Field offset: 0x60
	[SerializeField]
	protected bool m_ChildForceExpandWidth; //Field offset: 0x64
	[SerializeField]
	protected bool m_ChildForceExpandHeight; //Field offset: 0x65
	[SerializeField]
	protected bool m_ChildControlWidth; //Field offset: 0x66
	[SerializeField]
	protected bool m_ChildControlHeight; //Field offset: 0x67
	[SerializeField]
	protected bool m_ChildScaleWidth; //Field offset: 0x68
	[SerializeField]
	protected bool m_ChildScaleHeight; //Field offset: 0x69
	[SerializeField]
	protected bool m_ReverseArrangement; //Field offset: 0x6A

	public bool childControlHeight
	{
		 get { } //Length: 5
		 set { } //Length: 77
	}

	public bool childControlWidth
	{
		 get { } //Length: 5
		 set { } //Length: 77
	}

	public bool childForceExpandHeight
	{
		 get { } //Length: 5
		 set { } //Length: 77
	}

	public bool childForceExpandWidth
	{
		 get { } //Length: 5
		 set { } //Length: 77
	}

	public bool childScaleHeight
	{
		 get { } //Length: 5
		 set { } //Length: 77
	}

	public bool childScaleWidth
	{
		 get { } //Length: 5
		 set { } //Length: 77
	}

	public bool reverseArrangement
	{
		 get { } //Length: 5
		 set { } //Length: 77
	}

	public float spacing
	{
		 get { } //Length: 6
		 set { } //Length: 77
	}

	protected HorizontalOrVerticalLayoutGroup() { }

	protected void CalcAlongAxis(int axis, bool isVertical) { }

	public bool get_childControlHeight() { }

	public bool get_childControlWidth() { }

	public bool get_childForceExpandHeight() { }

	public bool get_childForceExpandWidth() { }

	public bool get_childScaleHeight() { }

	public bool get_childScaleWidth() { }

	public bool get_reverseArrangement() { }

	public float get_spacing() { }

	private void GetChildSizes(RectTransform child, int axis, bool controlSize, bool childForceExpand, out float min, out float preferred, out float flexible) { }

	public void set_childControlHeight(bool value) { }

	public void set_childControlWidth(bool value) { }

	public void set_childForceExpandHeight(bool value) { }

	public void set_childForceExpandWidth(bool value) { }

	public void set_childScaleHeight(bool value) { }

	public void set_childScaleWidth(bool value) { }

	public void set_reverseArrangement(bool value) { }

	public void set_spacing(float value) { }

	protected void SetChildrenAlongAxis(int axis, bool isVertical) { }

}

