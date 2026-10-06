namespace UnityEngine.UIElements;

internal abstract class DragAndDropData
{

	public abstract object source
	{
		 get { } //Length: 0
	}

	protected DragAndDropData() { }

	public abstract object get_source() { }

	public abstract object GetGenericData(string key) { }

}

