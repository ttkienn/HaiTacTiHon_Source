namespace UnityEngine.Purchasing;

[Nullable(0)]
[NullableContext(1)]
public class PurchasesFetchFailureDescription
{
	public PurchasesFetchFailureReason failureReason; //Field offset: 0x10
	public string message; //Field offset: 0x18

	public PurchasesFetchFailureReason FailureReason
	{
		 get { } //Length: 191
	}

	public string Message
	{
		 get { } //Length: 5
	}

	public PurchasesFetchFailureDescription(PurchasesFetchFailureReason reason, string message) { }

	public PurchasesFetchFailureReason get_FailureReason() { }

	public string get_Message() { }

}

