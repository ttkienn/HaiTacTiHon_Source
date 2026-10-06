namespace UnityEngine.EventSystems;

public abstract class AbstractEventData
{
	protected bool m_Used; //Field offset: 0x10

	public override bool used
	{
		 get { } //Length: 5
	}

	protected AbstractEventData() { }

	public override bool get_used() { }

	public override void Reset() { }

	public override void Use() { }

}

