namespace Unity.Services.Analytics.Internal;

internal interface ISessionManager
{

	public string SessionId
	{
		 get { } //Length: 0
	}

	public string get_SessionId() { }

	public void StartNewSession() { }

}

