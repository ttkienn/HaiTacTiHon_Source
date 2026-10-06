namespace UnityEngine.Purchasing;

[Nullable(0)]
[NullableContext(1)]
internal class ProductFetchRequest
{
	[CompilerGenerated]
	private readonly ReadOnlyCollection<ProductDefinition> <RequestedProducts>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly Action<List`1<Product>> <SuccessAction>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private readonly Action<List`1<ProductDefinition>, String> <FailureAction>k__BackingField; //Field offset: 0x20

	internal Action<List`1<ProductDefinition>, String> FailureAction
	{
		[CompilerGenerated]
		internal get { } //Length: 5
	}

	internal ReadOnlyCollection<ProductDefinition> RequestedProducts
	{
		[CompilerGenerated]
		internal get { } //Length: 5
	}

	internal Action<List`1<Product>> SuccessAction
	{
		[CompilerGenerated]
		internal get { } //Length: 5
	}

	internal ProductFetchRequest(ReadOnlyCollection<ProductDefinition> products, Action<List`1<Product>> fetchSuccessAction, Action<List`1<ProductDefinition>, String> fetchFailureAction) { }

	[CompilerGenerated]
	internal Action<List`1<ProductDefinition>, String> get_FailureAction() { }

	[CompilerGenerated]
	internal ReadOnlyCollection<ProductDefinition> get_RequestedProducts() { }

	[CompilerGenerated]
	internal Action<List`1<Product>> get_SuccessAction() { }

}

