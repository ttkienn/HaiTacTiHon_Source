namespace UnityEngine.EventSystems;

public class BaseEventData : AbstractEventData
{
	private readonly EventSystem m_EventSystem; //Field offset: 0x18

	public BaseInputModule currentInputModule
	{
		 get { } //Length: 27
	}

	public GameObject selectedObject
	{
		 get { } //Length: 27
		 set { } //Length: 36
	}

	public BaseEventData(EventSystem eventSystem) { }

	public BaseInputModule get_currentInputModule() { }

	public GameObject get_selectedObject() { }

	public void set_selectedObject(GameObject value) { }

}

