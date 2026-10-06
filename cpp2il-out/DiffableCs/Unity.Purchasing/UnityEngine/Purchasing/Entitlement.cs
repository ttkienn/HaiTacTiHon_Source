namespace UnityEngine.Purchasing;

[Nullable(0)]
[NullableContext(2)]
public class Entitlement
{
	[CompilerGenerated]
	private readonly Product <Product>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private Order <Order>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private readonly EntitlementStatus <Status>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private readonly string <ErrorMessage>k__BackingField; //Field offset: 0x28

	public string ErrorMessage
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public internal Order Order
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		internal set { } //Length: 13
	}

	public Product Product
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public EntitlementStatus Status
	{
		[CompilerGenerated]
		 get { } //Length: 4
	}

	internal Entitlement(Product product, Order order, EntitlementStatus status, string message = null) { }

	[CompilerGenerated]
	public string get_ErrorMessage() { }

	[CompilerGenerated]
	public Order get_Order() { }

	[CompilerGenerated]
	public Product get_Product() { }

	[CompilerGenerated]
	public EntitlementStatus get_Status() { }

	[CompilerGenerated]
	internal void set_Order(Order value) { }

}

