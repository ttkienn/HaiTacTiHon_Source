namespace UnityEngine.Purchasing.UseCases;

internal class CanMakePaymentsUseCase : ICanMakePaymentsUseCase
{
	[Nullable(1)]
	private readonly INativeAppleStore m_NativeAppleStore; //Field offset: 0x10

	[NullableContext(1)]
	[Preserve]
	internal CanMakePaymentsUseCase(INativeAppleStore nativeStore) { }

	public override bool CanMakePayments() { }

}

