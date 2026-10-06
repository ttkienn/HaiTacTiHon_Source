namespace UnityEngine.Purchasing.UseCases;

internal class SetPromotionalPurchaseInterceptorCallbackUseCase : ISetPromotionalPurchaseInterceptorCallbackUseCase
{
	[Nullable(1)]
	private readonly IAppleStoreCallbacks m_AppleStoreCallbacks; //Field offset: 0x10

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1}])]
	public override event Action<Product> OnPromotionalPurchaseIntercepted
	{
		 add { } //Length: 88
		 remove { } //Length: 88
	}

	[NullableContext(1)]
	[Preserve]
	internal SetPromotionalPurchaseInterceptorCallbackUseCase(IAppleStoreCallbacks appleStoreCallbacks) { }

	public override void add_OnPromotionalPurchaseIntercepted(Action<Product> value) { }

	public override void remove_OnPromotionalPurchaseIntercepted(Action<Product> value) { }

}

