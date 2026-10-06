namespace UnityEngine.Purchasing;

internal class CheckEntitlementRequest
{
	[CompilerGenerated]
	private readonly Product <ProductToCheck>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly Action<Entitlement> <OnChecked>k__BackingField; //Field offset: 0x18

	internal Action<Entitlement> OnChecked
	{
		[CompilerGenerated]
		internal get { } //Length: 5
	}

	internal Product ProductToCheck
	{
		[CompilerGenerated]
		internal get { } //Length: 5
	}

	internal CheckEntitlementRequest(Product product, Action<Entitlement> onChecked) { }

	[CompilerGenerated]
	internal Action<Entitlement> get_OnChecked() { }

	[CompilerGenerated]
	internal Product get_ProductToCheck() { }

}

