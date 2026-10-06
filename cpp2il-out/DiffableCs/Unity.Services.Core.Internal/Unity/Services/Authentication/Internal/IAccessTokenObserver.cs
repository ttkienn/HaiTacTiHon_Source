namespace Unity.Services.Authentication.Internal;

[RequireImplementors]
public interface IAccessTokenObserver : IServiceComponent
{

	public event Action<String> AccessTokenChanged
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	[CompilerGenerated]
	public void add_AccessTokenChanged(Action<String> value) { }

	[CompilerGenerated]
	public void remove_AccessTokenChanged(Action<String> value) { }

}

