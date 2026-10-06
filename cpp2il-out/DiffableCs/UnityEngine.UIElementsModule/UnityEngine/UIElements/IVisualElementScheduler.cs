namespace UnityEngine.UIElements;

public interface IVisualElementScheduler
{

	public IVisualElementScheduledItem Execute(Action<TimerState> timerUpdateEvent) { }

	public IVisualElementScheduledItem Execute(Action updateEvent) { }

}

