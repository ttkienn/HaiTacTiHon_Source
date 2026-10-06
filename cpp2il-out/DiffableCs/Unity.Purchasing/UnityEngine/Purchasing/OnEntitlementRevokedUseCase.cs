namespace UnityEngine.Purchasing;

internal class OnEntitlementRevokedUseCase : IOnEntitlementRevokedUseCase, IOnEntitlementRevokedCallback
{
	[CompilerGenerated]
	private Action<String> OnEntitlementRevoked; //Field offset: 0x10

	public override event Action<String> OnEntitlementRevoked
	{
		[CompilerGenerated]
		 add { } //Length: 172
		[CompilerGenerated]
		 remove { } //Length: 172
	}

	[Preserve]
	internal OnEntitlementRevokedUseCase(IStore storeResponsible) { }

	[CompilerGenerated]
	public override void add_OnEntitlementRevoked(Action<String> value) { }

	public override void onEntitlementRevoked(string productId) { }

	[CompilerGenerated]
	public override void remove_OnEntitlementRevoked(Action<String> value) { }

}

