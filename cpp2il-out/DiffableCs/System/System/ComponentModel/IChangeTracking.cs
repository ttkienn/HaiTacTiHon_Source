namespace System.ComponentModel;

public interface IChangeTracking
{

	public bool IsChanged
	{
		 get { } //Length: 0
	}

	public void AcceptChanges() { }

	public bool get_IsChanged() { }

}

