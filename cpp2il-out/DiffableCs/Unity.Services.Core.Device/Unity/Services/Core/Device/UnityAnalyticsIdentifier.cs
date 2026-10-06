namespace Unity.Services.Core.Device;

internal class UnityAnalyticsIdentifier : IUserIdentifierProvider
{

	public override string UserId
	{
		 get { } //Length: 50
		 set { } //Length: 71
	}

	public UnityAnalyticsIdentifier() { }

	public override string get_UserId() { }

	public override void set_UserId(string value) { }

}

