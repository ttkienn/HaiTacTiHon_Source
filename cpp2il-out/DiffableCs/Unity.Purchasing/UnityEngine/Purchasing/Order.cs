namespace UnityEngine.Purchasing;

[Nullable(0)]
[NullableContext(1)]
public abstract class Order
{
	[CompilerGenerated]
	private ICart <CartOrdered>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly IOrderInfo <Info>k__BackingField; //Field offset: 0x18

	public internal ICart CartOrdered
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		internal set { } //Length: 13
	}

	public IOrderInfo Info
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	protected Order(ICart cart, IOrderInfo info) { }

	[CompilerGenerated]
	public ICart get_CartOrdered() { }

	[CompilerGenerated]
	public IOrderInfo get_Info() { }

	[CompilerGenerated]
	internal void set_CartOrdered(ICart value) { }

}

