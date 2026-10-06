namespace UnityEngine.Purchasing;

[Nullable(0)]
[NullableContext(1)]
public class ProductFetchFailed
{
	[CompilerGenerated]
	private readonly List<ProductDefinition> <FailedFetchProducts>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly string <FailureReason>k__BackingField; //Field offset: 0x18

	public List<ProductDefinition> FailedFetchProducts
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public string FailureReason
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	internal ProductFetchFailed(List<ProductDefinition> products, string reason) { }

	[CompilerGenerated]
	public List<ProductDefinition> get_FailedFetchProducts() { }

	[CompilerGenerated]
	public string get_FailureReason() { }

}

