namespace UnityEngine.Purchasing;

public class SimpleCatalogProvider : IBaseCatalogProvider
{
	private readonly Action<Action`1<List`1<ProductDefinition>>> m_Func; //Field offset: 0x10

	public SimpleCatalogProvider(Action<Action`1<List`1<ProductDefinition>>> func) { }

	public override void FetchProducts(Action<List`1<ProductDefinition>> callback) { }

}

