namespace UnityEngine.Purchasing.UseCases.Interfaces;

[NullableContext(1)]
internal interface ISetPromotionalPurchaseInterceptorCallbackUseCase
{

	public event Action<Product> OnPromotionalPurchaseIntercepted
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	[CompilerGenerated]
	public void add_OnPromotionalPurchaseIntercepted(Action<Product> value) { }

	[CompilerGenerated]
	public void remove_OnPromotionalPurchaseIntercepted(Action<Product> value) { }

}

