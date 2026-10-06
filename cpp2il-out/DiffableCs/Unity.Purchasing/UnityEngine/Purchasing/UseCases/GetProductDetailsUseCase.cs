namespace UnityEngine.Purchasing.UseCases;

[Nullable(0)]
[NullableContext(1)]
internal class GetProductDetailsUseCase : IGetProductDetailsUseCase
{
	private readonly IAppleFetchProductsService m_FetchProductsService; //Field offset: 0x10

	[Preserve]
	internal GetProductDetailsUseCase(IAppleFetchProductsService fetchProductsService) { }

	public override Dictionary<String, String> GetProductDetails() { }

}

