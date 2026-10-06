namespace UnityEngine.UIElements;

public interface IVisualElementScheduledItem
{

	public bool isActive
	{
		 get { } //Length: 0
	}

	public IVisualElementScheduledItem Every(long intervalMs) { }

	public void ExecuteLater(long delayMs) { }

	public bool get_isActive() { }

	public void Pause() { }

	public void Resume() { }

	public IVisualElementScheduledItem StartingIn(long delayMs) { }

}

