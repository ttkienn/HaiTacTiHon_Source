namespace Unity.Services.Authentication.Internal;

[RequireImplementors]
public interface IAccessToken : IServiceComponent
{

	public string AccessToken
	{
		 get { } //Length: 0
	}

	public string get_AccessToken() { }

}

