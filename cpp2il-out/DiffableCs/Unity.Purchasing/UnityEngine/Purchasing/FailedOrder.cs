namespace UnityEngine.Purchasing;

[Nullable(0)]
[NullableContext(1)]
public class FailedOrder : Order
{
	private PurchaseFailureReason m_FailureReason; //Field offset: 0x20
	private string m_Details; //Field offset: 0x28

	public string Details
	{
		 get { } //Length: 5
	}

	public PurchaseFailureReason FailureReason
	{
		 get { } //Length: 4
	}

	public FailedOrder(ICart cart, PurchaseFailureReason reason, string details) { }

	public FailedOrder(Order order, PurchaseFailureReason reason, string details) { }

	public string get_Details() { }

	public PurchaseFailureReason get_FailureReason() { }

}

