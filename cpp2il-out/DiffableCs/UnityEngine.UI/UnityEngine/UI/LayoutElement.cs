namespace UnityEngine.UI;

[AddComponentMenu("Layout/Layout Element", 140)]
[ExecuteAlways]
[RequireComponent(typeof(RectTransform))]
public class LayoutElement : UIBehaviour, ILayoutElement, ILayoutIgnorer
{
	[SerializeField]
	private bool m_IgnoreLayout; //Field offset: 0x20
	[SerializeField]
	private float m_MinWidth; //Field offset: 0x24
	[SerializeField]
	private float m_MinHeight; //Field offset: 0x28
	[SerializeField]
	private float m_PreferredWidth; //Field offset: 0x2C
	[SerializeField]
	private float m_PreferredHeight; //Field offset: 0x30
	[SerializeField]
	private float m_FlexibleWidth; //Field offset: 0x34
	[SerializeField]
	private float m_FlexibleHeight; //Field offset: 0x38
	[SerializeField]
	private int m_LayoutPriority; //Field offset: 0x3C

	public override float flexibleHeight
	{
		 get { } //Length: 6
		 set { } //Length: 89
	}

	public override float flexibleWidth
	{
		 get { } //Length: 6
		 set { } //Length: 89
	}

	public override bool ignoreLayout
	{
		 get { } //Length: 5
		 set { } //Length: 89
	}

	public override int layoutPriority
	{
		 get { } //Length: 4
		 set { } //Length: 86
	}

	public override float minHeight
	{
		 get { } //Length: 6
		 set { } //Length: 89
	}

	public override float minWidth
	{
		 get { } //Length: 6
		 set { } //Length: 89
	}

	public override float preferredHeight
	{
		 get { } //Length: 6
		 set { } //Length: 89
	}

	public override float preferredWidth
	{
		 get { } //Length: 6
		 set { } //Length: 89
	}

	protected LayoutElement() { }

	public override void CalculateLayoutInputHorizontal() { }

	public override void CalculateLayoutInputVertical() { }

	public override float get_flexibleHeight() { }

	public override float get_flexibleWidth() { }

	public override bool get_ignoreLayout() { }

	public override int get_layoutPriority() { }

	public override float get_minHeight() { }

	public override float get_minWidth() { }

	public override float get_preferredHeight() { }

	public override float get_preferredWidth() { }

	protected virtual void OnBeforeTransformParentChanged() { }

	protected virtual void OnDidApplyAnimationProperties() { }

	protected virtual void OnDisable() { }

	protected virtual void OnEnable() { }

	protected virtual void OnTransformParentChanged() { }

	public override void set_flexibleHeight(float value) { }

	public override void set_flexibleWidth(float value) { }

	public override void set_ignoreLayout(bool value) { }

	public override void set_layoutPriority(int value) { }

	public override void set_minHeight(float value) { }

	public override void set_minWidth(float value) { }

	public override void set_preferredHeight(float value) { }

	public override void set_preferredWidth(float value) { }

	protected void SetDirty() { }

}

