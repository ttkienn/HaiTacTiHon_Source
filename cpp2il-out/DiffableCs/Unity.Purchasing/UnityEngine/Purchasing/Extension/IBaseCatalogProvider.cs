namespace UnityEngine.Purchasing.Extension;

public interface IBaseCatalogProvider
{

	public void FetchProducts(Action<List`1<ProductDefinition>> callback) { }

}

