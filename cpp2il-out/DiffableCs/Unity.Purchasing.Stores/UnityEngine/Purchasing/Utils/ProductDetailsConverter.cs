namespace UnityEngine.Purchasing.Utils;

[Nullable(0)]
[NullableContext(1)]
[Preserve]
internal class ProductDetailsConverter : IProductDetailsConverter
{

	public ProductDetailsConverter() { }

	internal static ProductDescription BuildProductDescription(AndroidJavaObject productDetails, ProductType productType = 3) { }

	public override List<ProductDescription> ConvertOnQueryProductDetailsResponse(IEnumerable<AndroidJavaObject> productDetails, IReadOnlyCollection<ProductDefinition> productDefinitions) { }

	public ProductDescription ConvertToProductDescription(AndroidJavaObject productDetails, ProductType productType) { }

	public string GetProductId(AndroidJavaObject productDetails) { }

}

