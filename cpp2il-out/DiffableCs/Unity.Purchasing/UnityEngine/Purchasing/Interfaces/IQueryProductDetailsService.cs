namespace UnityEngine.Purchasing.Interfaces;

[NullableContext(1)]
internal interface IQueryProductDetailsService
{

	public Task<List`1<ProductDescription>> QueryProductDescriptions(IReadOnlyCollection<ProductDefinition> products) { }

	public Task<List`1<AndroidJavaObject>> QueryProductDetails(ProductDefinition product) { }

	public Task<List`1<AndroidJavaObject>> QueryProductDetails(IReadOnlyCollection<ProductDefinition> products) { }

}

