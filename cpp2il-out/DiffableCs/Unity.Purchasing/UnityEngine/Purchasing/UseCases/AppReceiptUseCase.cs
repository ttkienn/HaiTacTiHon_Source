namespace UnityEngine.Purchasing.UseCases;

internal class AppReceiptUseCase : IAppReceiptUseCase
{
	[Nullable(1)]
	private readonly IAppleAppReceiptViewer m_AppleAppReceiptViewer; //Field offset: 0x10

	[NullableContext(1)]
	[Preserve]
	internal AppReceiptUseCase(IAppleAppReceiptViewer appleAppReceiptViewer) { }

	[NullableContext(2)]
	public override string AppReceipt() { }

}

