namespace UnityEngine.Purchasing;

public class Orders
{
	[CompilerGenerated]
	private readonly IReadOnlyList<ConfirmedOrder> <ConfirmedOrders>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly IReadOnlyList<PendingOrder> <PendingOrders>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private readonly IReadOnlyList<DeferredOrder> <DeferredOrders>k__BackingField; //Field offset: 0x20

	public IReadOnlyList<ConfirmedOrder> ConfirmedOrders
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public IReadOnlyList<DeferredOrder> DeferredOrders
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public IReadOnlyList<PendingOrder> PendingOrders
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public Orders(IReadOnlyList<ConfirmedOrder> confirmedOrders, IReadOnlyList<PendingOrder> pendingOrders, IReadOnlyList<DeferredOrder> deferredOrders) { }

	[CompilerGenerated]
	public IReadOnlyList<ConfirmedOrder> get_ConfirmedOrders() { }

	[CompilerGenerated]
	public IReadOnlyList<DeferredOrder> get_DeferredOrders() { }

	[CompilerGenerated]
	public IReadOnlyList<PendingOrder> get_PendingOrders() { }

}

