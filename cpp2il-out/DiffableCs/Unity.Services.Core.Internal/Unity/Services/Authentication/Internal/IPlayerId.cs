namespace Unity.Services.Authentication.Internal;

[RequireImplementors]
public interface IPlayerId : IServiceComponent
{

	public event Action<String> PlayerIdChanged
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public string PlayerId
	{
		 get { } //Length: 0
	}

	[CompilerGenerated]
	public void add_PlayerIdChanged(Action<String> value) { }

	public string get_PlayerId() { }

	[CompilerGenerated]
	public void remove_PlayerIdChanged(Action<String> value) { }

}

