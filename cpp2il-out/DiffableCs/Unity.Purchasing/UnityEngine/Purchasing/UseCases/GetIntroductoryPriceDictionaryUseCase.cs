namespace UnityEngine.Purchasing.UseCases;

[Nullable(0)]
[NullableContext(1)]
internal class GetIntroductoryPriceDictionaryUseCase : IGetIntroductoryPriceDictionaryUseCase
{
	private readonly IAppleFetchProductsService m_FetchProductsService; //Field offset: 0x10

	[Preserve]
	internal GetIntroductoryPriceDictionaryUseCase(IAppleFetchProductsService fetchProductsService) { }

	public override Dictionary<String, String> GetIntroductoryPriceDictionary() { }

}

