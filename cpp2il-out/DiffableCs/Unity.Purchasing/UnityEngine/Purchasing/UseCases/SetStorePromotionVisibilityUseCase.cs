namespace UnityEngine.Purchasing.UseCases;

[Nullable(0)]
[NullableContext(1)]
internal class SetStorePromotionVisibilityUseCase : ISetStorePromotionVisibilityUseCase
{
	private readonly INativeAppleStore m_NativeAppleStore; //Field offset: 0x10
	private readonly ITelemetryDiagnostics m_TelemetryDiagnostics; //Field offset: 0x18

	[Preserve]
	internal SetStorePromotionVisibilityUseCase(INativeAppleStore nativeStore, ITelemetryDiagnostics telemetryDiagnostics) { }

	public override void SetStorePromotionVisibility(Product product, AppleStorePromotionVisibility visibility) { }

}

