namespace UnityEngine.UIElements;

internal interface IMouseEventInternal
{

	public bool recomputeTopElementUnderMouse
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public IPointerEvent sourcePointerEvent
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public bool triggeredByOS
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public bool get_recomputeTopElementUnderMouse() { }

	public IPointerEvent get_sourcePointerEvent() { }

	public bool get_triggeredByOS() { }

	public void set_recomputeTopElementUnderMouse(bool value) { }

	public void set_sourcePointerEvent(IPointerEvent value) { }

	public void set_triggeredByOS(bool value) { }

}

