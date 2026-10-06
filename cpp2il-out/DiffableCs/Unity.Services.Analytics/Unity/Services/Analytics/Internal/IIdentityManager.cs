namespace Unity.Services.Analytics.Internal;

internal interface IIdentityManager
{

	public event Action OnPlayerChanged
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public string ExternalId
	{
		 get { } //Length: 0
	}

	public string InstallId
	{
		 get { } //Length: 0
	}

	public bool IsNewPlayer
	{
		 get { } //Length: 0
	}

	public string PlayerId
	{
		 get { } //Length: 0
	}

	public string UserId
	{
		 get { } //Length: 0
	}

	[CompilerGenerated]
	public void add_OnPlayerChanged(Action value) { }

	public string get_ExternalId() { }

	public string get_InstallId() { }

	public bool get_IsNewPlayer() { }

	public string get_PlayerId() { }

	public string get_UserId() { }

	public void Initialize() { }

	[CompilerGenerated]
	public void remove_OnPlayerChanged(Action value) { }

}

