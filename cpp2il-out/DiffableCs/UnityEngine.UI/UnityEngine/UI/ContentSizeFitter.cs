namespace UnityEngine.UI;

[AddComponentMenu("Layout/Content Size Fitter", 141)]
[ExecuteAlways]
[RequireComponent(typeof(RectTransform))]
public class ContentSizeFitter : UIBehaviour, ILayoutSelfController, ILayoutController
{
	internal enum FitMode
	{
		Unconstrained = 0,
		MinSize = 1,
		PreferredSize = 2,
	}

	[SerializeField]
	protected FitMode m_HorizontalFit; //Field offset: 0x20
	[SerializeField]
	protected FitMode m_VerticalFit; //Field offset: 0x24
	private RectTransform m_Rect; //Field offset: 0x28
	private DrivenRectTransformTracker m_Tracker; //Field offset: 0x30

	public FitMode horizontalFit
	{
		 get { } //Length: 4
		 set { } //Length: 86
	}

	private RectTransform rectTransform
	{
		private get { } //Length: 141
	}

	public FitMode verticalFit
	{
		 get { } //Length: 4
		 set { } //Length: 86
	}

	protected ContentSizeFitter() { }

	public FitMode get_horizontalFit() { }

	private RectTransform get_rectTransform() { }

	public FitMode get_verticalFit() { }

	private void HandleSelfFittingAlongAxis(int axis) { }

	protected virtual void OnDisable() { }

	protected virtual void OnEnable() { }

	protected virtual void OnRectTransformDimensionsChange() { }

	public void set_horizontalFit(FitMode value) { }

	public void set_verticalFit(FitMode value) { }

	protected void SetDirty() { }

	public override void SetLayoutHorizontal() { }

	public override void SetLayoutVertical() { }

}

