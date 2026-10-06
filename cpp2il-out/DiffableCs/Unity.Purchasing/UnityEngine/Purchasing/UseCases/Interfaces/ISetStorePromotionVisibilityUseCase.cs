namespace UnityEngine.Purchasing.UseCases.Interfaces;

[NullableContext(1)]
internal interface ISetStorePromotionVisibilityUseCase
{

	public void SetStorePromotionVisibility(Product product, AppleStorePromotionVisibility visibility) { }

}

