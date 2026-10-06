namespace UnityEngine.UIElements;

internal class TwoPaneSplitViewResizer : PointerManipulator
{
	private Vector3 m_Start; //Field offset: 0x38
	protected bool m_Active; //Field offset: 0x44
	private TwoPaneSplitView m_SplitView; //Field offset: 0x48
	private int m_Direction; //Field offset: 0x50

	private VisualElement fixedPane
	{
		private get { } //Length: 30
	}

	private float fixedPaneMargins
	{
		private get { } //Length: 276
	}

	private float fixedPaneMinDimension
	{
		private get { } //Length: 151
	}

	private VisualElement flexedPane
	{
		private get { } //Length: 30
	}

	private float flexedPaneMargin
	{
		private get { } //Length: 276
	}

	private float flexedPaneMinDimension
	{
		private get { } //Length: 151
	}

	private TwoPaneSplitViewOrientation orientation
	{
		private get { } //Length: 29
	}

	public TwoPaneSplitViewResizer(TwoPaneSplitView splitView, int dir) { }

	public void ApplyDelta(float delta) { }

	private VisualElement get_fixedPane() { }

	private float get_fixedPaneMargins() { }

	private float get_fixedPaneMinDimension() { }

	private VisualElement get_flexedPane() { }

	private float get_flexedPaneMargin() { }

	private float get_flexedPaneMinDimension() { }

	private TwoPaneSplitViewOrientation get_orientation() { }

	protected void InterruptPointerMove(PointerMoveEvent e) { }

	protected void OnPointerDown(PointerDownEvent e) { }

	protected void OnPointerMove(PointerMoveEvent e) { }

	protected void OnPointerUp(PointerUpEvent e) { }

	protected virtual void RegisterCallbacksOnTarget() { }

	protected virtual void UnregisterCallbacksFromTarget() { }

}

