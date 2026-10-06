namespace UnityEngine.UI;

[AddComponentMenu("Layout/Aspect Ratio Fitter", 142)]
[DisallowMultipleComponent]
[ExecuteAlways]
[RequireComponent(typeof(RectTransform))]
public class AspectRatioFitter : UIBehaviour, ILayoutSelfController, ILayoutController
{
	internal enum AspectMode
	{
		None = 0,
		WidthControlsHeight = 1,
		HeightControlsWidth = 2,
		FitInParent = 3,
		EnvelopeParent = 4,
	}

	[SerializeField]
	private AspectMode m_AspectMode; //Field offset: 0x20
	[SerializeField]
	private float m_AspectRatio; //Field offset: 0x24
	private RectTransform m_Rect; //Field offset: 0x28
	private bool m_DelayedSetDirty; //Field offset: 0x30
	private bool m_DoesParentExist; //Field offset: 0x31
	private DrivenRectTransformTracker m_Tracker; //Field offset: 0x32

	public AspectMode aspectMode
	{
		 get { } //Length: 4
		 set { } //Length: 86
	}

	public float aspectRatio
	{
		 get { } //Length: 6
		 set { } //Length: 89
	}

	private RectTransform rectTransform
	{
		private get { } //Length: 141
	}

	protected AspectRatioFitter() { }

	private bool DoesParentExists() { }

	public AspectMode get_aspectMode() { }

	public float get_aspectRatio() { }

	private RectTransform get_rectTransform() { }

	private Vector2 GetParentSize() { }

	private float GetSizeDeltaToProduceSize(float size, int axis) { }

	public bool IsAspectModeValid() { }

	public bool IsComponentValidOnObject() { }

	protected virtual void OnDisable() { }

	protected virtual void OnEnable() { }

	protected virtual void OnRectTransformDimensionsChange() { }

	protected virtual void OnTransformParentChanged() { }

	public void set_aspectMode(AspectMode value) { }

	public void set_aspectRatio(float value) { }

	protected void SetDirty() { }

	public override void SetLayoutHorizontal() { }

	public override void SetLayoutVertical() { }

	protected virtual void Start() { }

	protected override void Update() { }

	private void UpdateRect() { }

}

