namespace UnityEngine.Purchasing;

[NullableContext(1)]
public interface IStoreWrapper
{

	public Store instance
	{
		 get { } //Length: 0
	}

	public string name
	{
		 get { } //Length: 0
	}

	public Store get_instance() { }

	public string get_name() { }

	public ConnectionState GetStoreConnectionState() { }

}

