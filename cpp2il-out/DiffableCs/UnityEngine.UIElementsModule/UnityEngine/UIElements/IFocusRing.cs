namespace UnityEngine.UIElements;

public interface IFocusRing
{

	public FocusChangeDirection GetFocusChangeDirection(Focusable currentFocusable, EventBase e) { }

	public Focusable GetNextFocusable(Focusable currentFocusable, FocusChangeDirection direction) { }

}

