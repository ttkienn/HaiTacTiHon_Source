namespace UnityEngine.Purchasing.Exceptions;

[Nullable(0)]
[NullableContext(1)]
internal class FetchProductsException : IapException
{
	[CompilerGenerated]
	private readonly ProductFetchFailureDescription <FailureDescription>k__BackingField; //Field offset: 0x90

	internal ProductFetchFailureDescription FailureDescription
	{
		[CompilerGenerated]
		internal get { } //Length: 8
	}

	public FetchProductsException(ProductFetchFailureDescription failureDescription) { }

	[CompilerGenerated]
	internal ProductFetchFailureDescription get_FailureDescription() { }

}

