namespace UnityEngine.Purchasing.UseCases;

internal class PresentCodeRedemptionSheetUseCase : IPresentCodeRedemptionSheetUseCase
{
	[Nullable(1)]
	private readonly INativeAppleStore m_NativeAppleStore; //Field offset: 0x10

	[NullableContext(1)]
	[Preserve]
	internal PresentCodeRedemptionSheetUseCase(INativeAppleStore nativeStore) { }

	public override void PresentCodeRedemptionSheet() { }

}

