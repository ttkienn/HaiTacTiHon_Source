namespace UnityEngine.Purchasing;

[Nullable(0)]
[NullableContext(1)]
internal class GooglePlayGetGooglePurchaseUseCase : IGooglePlayGetGooglePurchaseUseCase
{
	private readonly IStore m_Store; //Field offset: 0x10

	[Preserve]
	public GooglePlayGetGooglePurchaseUseCase(IStore store) { }

	public override IGooglePurchase GetGooglePurchase(string purchaseToken) { }

	[NullableContext(2)]
	private IGooglePlayStore GooglePlayStore() { }

}

