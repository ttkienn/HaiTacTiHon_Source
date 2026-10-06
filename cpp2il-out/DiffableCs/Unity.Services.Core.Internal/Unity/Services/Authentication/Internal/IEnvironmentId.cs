namespace Unity.Services.Authentication.Internal;

[RequireImplementors]
public interface IEnvironmentId : IServiceComponent
{

	public string EnvironmentId
	{
		 get { } //Length: 0
	}

	public string get_EnvironmentId() { }

}

