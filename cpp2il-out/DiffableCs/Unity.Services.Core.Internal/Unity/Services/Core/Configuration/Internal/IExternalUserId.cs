namespace Unity.Services.Core.Configuration.Internal;

[RequireImplementors]
public interface IExternalUserId : IServiceComponent
{

	public event Action<String> UserIdChanged
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public string UserId
	{
		 get { } //Length: 0
	}

	[CompilerGenerated]
	public void add_UserIdChanged(Action<String> value) { }

	public string get_UserId() { }

	[CompilerGenerated]
	public void remove_UserIdChanged(Action<String> value) { }

}

