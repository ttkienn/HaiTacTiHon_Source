namespace UnityEngine.Purchasing;

[NullableContext(1)]
internal interface IFetchProductsUseCase
{

	public void FetchProducts(List<ProductDefinition> productDefinitions, Action<List`1<Product>> fetchSuccessAction, Action<List`1<ProductDefinition>, String> fetchFailureAction, IRetryPolicy retryPolicy) { }

}

