namespace UnityEngine.Purchasing.Interfaces;

internal interface IProductDetailsConverter
{

	public List<ProductDescription> ConvertOnQueryProductDetailsResponse(IEnumerable<AndroidJavaObject> productDetails, IReadOnlyCollection<ProductDefinition> productDefinitions) { }

}

