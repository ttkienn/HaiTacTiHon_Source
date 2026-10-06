namespace UnityEngine.Purchasing.UseCases;

[Nullable(0)]
[NullableContext(1)]
internal class SetStorePromotionOrderUseCase : ISetStorePromotionOrderUseCase
{
	private readonly INativeAppleStore m_NativeAppleStore; //Field offset: 0x10

	[Preserve]
	internal SetStorePromotionOrderUseCase(INativeAppleStore nativeStore) { }

	public override void SetStorePromotionOrder(List<Product> products) { }

}

