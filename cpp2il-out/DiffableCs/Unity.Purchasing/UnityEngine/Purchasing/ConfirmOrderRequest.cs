namespace UnityEngine.Purchasing;

internal class ConfirmOrderRequest
{
	[CompilerGenerated]
	private readonly PendingOrder <OrderToConfirm>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly Action<PendingOrder, Order> <Action>k__BackingField; //Field offset: 0x18

	internal Action<PendingOrder, Order> Action
	{
		[CompilerGenerated]
		internal get { } //Length: 5
	}

	internal PendingOrder OrderToConfirm
	{
		[CompilerGenerated]
		internal get { } //Length: 5
	}

	internal ConfirmOrderRequest(PendingOrder order, Action<PendingOrder, Order> purchaseSuccessAction) { }

	[CompilerGenerated]
	internal Action<PendingOrder, Order> get_Action() { }

	[CompilerGenerated]
	internal PendingOrder get_OrderToConfirm() { }

}

