namespace UnityEngine.UIElements;

internal interface IVisualTreeUpdater : IDisposable
{

	public BaseVisualElementPanel panel
	{
		 set { } //Length: 0
	}

	public ProfilerMarker profilerMarker
	{
		 get { } //Length: 0
	}

	public ProfilerMarker get_profilerMarker() { }

	public void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType) { }

	public void set_panel(BaseVisualElementPanel value) { }

	public void Update() { }

}

