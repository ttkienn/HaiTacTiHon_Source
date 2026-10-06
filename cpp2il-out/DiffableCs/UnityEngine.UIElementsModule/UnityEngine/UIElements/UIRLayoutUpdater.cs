namespace UnityEngine.UIElements;

internal class UIRLayoutUpdater : BaseVisualTreeUpdater
{
	private static readonly string s_Description; //Field offset: 0x0
	private static readonly ProfilerMarker s_ProfilerMarker; //Field offset: 0x8
	private List<KeyValuePair`2<Rect, VisualElement>> changeEventsList; //Field offset: 0x20

	public virtual ProfilerMarker profilerMarker
	{
		 get { } //Length: 79
	}

	private static UIRLayoutUpdater() { }

	public UIRLayoutUpdater() { }

	private void DispatchChangeEvents(List<KeyValuePair`2<Rect, VisualElement>> changeEvents, int currentLayoutPass) { }

	public virtual ProfilerMarker get_profilerMarker() { }

	public virtual void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType) { }

	public virtual void Update() { }

	private void UpdateSubTree(VisualElement ve, bool isDisplayed, List<KeyValuePair`2<Rect, VisualElement>> changeEvents) { }

}

