namespace UnityEngine.Purchasing;

internal interface IOnEntitlementRevokedUseCase
{

	public event Action<String> OnEntitlementRevoked
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	[CompilerGenerated]
	public void add_OnEntitlementRevoked(Action<String> value) { }

	[CompilerGenerated]
	public void remove_OnEntitlementRevoked(Action<String> value) { }

}

