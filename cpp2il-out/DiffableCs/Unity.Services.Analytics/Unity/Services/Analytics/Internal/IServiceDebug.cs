namespace Unity.Services.Analytics.Internal;

internal interface IServiceDebug
{

	public bool IsActive
	{
		 get { } //Length: 0
	}

	public IIdentityManager UserIdentity
	{
		 get { } //Length: 0
	}

	public bool get_IsActive() { }

	public IIdentityManager get_UserIdentity() { }

}

