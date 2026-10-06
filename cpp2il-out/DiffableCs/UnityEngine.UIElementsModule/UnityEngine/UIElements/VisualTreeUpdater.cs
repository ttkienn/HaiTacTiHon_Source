namespace UnityEngine.UIElements;

internal sealed class VisualTreeUpdater : IDisposable
{
	[DefaultMember("Item")]
	private class UpdaterArray
	{
		private IVisualTreeUpdater[] m_VisualTreeUpdaters; //Field offset: 0x10

		public IVisualTreeUpdater Item
		{
			 get { } //Length: 43
			 set { } //Length: 126
		}

		public IVisualTreeUpdater Item
		{
			 get { } //Length: 43
		}

		public UpdaterArray() { }

		public IVisualTreeUpdater get_Item(VisualTreeUpdatePhase phase) { }

		public IVisualTreeUpdater get_Item(int index) { }

		public void set_Item(VisualTreeUpdatePhase phase, IVisualTreeUpdater value) { }

	}

	private BaseVisualElementPanel m_Panel; //Field offset: 0x10
	private UpdaterArray m_UpdaterArray; //Field offset: 0x18

	public VisualTreeUpdater(BaseVisualElementPanel panel) { }

	public override void Dispose() { }

	public IVisualTreeUpdater GetUpdater(VisualTreeUpdatePhase phase) { }

	public void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType) { }

	private void SetDefaultUpdaters() { }

	public void SetUpdater(VisualTreeUpdatePhase phase) { }

	public void UpdateVisualTreePhase(VisualTreeUpdatePhase phase) { }

}

