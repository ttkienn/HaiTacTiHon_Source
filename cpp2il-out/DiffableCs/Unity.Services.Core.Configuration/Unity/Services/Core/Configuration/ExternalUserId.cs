namespace Unity.Services.Core.Configuration;

internal class ExternalUserId : IExternalUserId, IServiceComponent
{

	public override event Action<String> UserIdChanged
	{
		 add { } //Length: 105
		 remove { } //Length: 105
	}

	public override string UserId
	{
		 get { } //Length: 93
	}

	public ExternalUserId() { }

	public override void add_UserIdChanged(Action<String> value) { }

	public override string get_UserId() { }

	public override void remove_UserIdChanged(Action<String> value) { }

}

