namespace UnityEngine.Purchasing;

[Nullable(0)]
[NullableContext(1)]
internal class StoreConnectUseCaseFactory
{

	public StoreConnectUseCaseFactory() { }

	private static IRetryPolicy CreateRetryPolicy(string storeName) { }

	public IStoreConnectUseCase CreateUseCase(IStoreWrapper storeWrapper, IRetryService retryService) { }

}

