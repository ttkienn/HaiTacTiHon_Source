namespace UnityEngine.Purchasing;

[NullableContext(1)]
internal interface IAppleFetchProductsService
{

	[Nullable(2)]
	public string LastRequestProductsJson
	{
		[NullableContext(2)]
		 get { } //Length: 0
	}

	public Task<List`1<ProductDescription>> FetchProducts(IReadOnlyCollection<ProductDefinition> products) { }

	[NullableContext(2)]
	public string get_LastRequestProductsJson() { }

	public void OnProductDetailsRetrieveFailed(string errorMessage) { }

	public void OnProductsFetched(string json) { }

	public void SetNativeStore(INativeAppleStore nativeStore) { }

}

