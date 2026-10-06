namespace UnityEngine.Purchasing.UseCases;

internal class ContinuePromotionalPurchasesUseCase : IContinuePromotionalPurchasesUseCase
{
	[Nullable(1)]
	private readonly INativeAppleStore m_NativeAppleStore; //Field offset: 0x10

	[NullableContext(1)]
	[Preserve]
	internal ContinuePromotionalPurchasesUseCase(INativeAppleStore nativeStore) { }

	public override void ContinuePromotionalPurchases() { }

}

