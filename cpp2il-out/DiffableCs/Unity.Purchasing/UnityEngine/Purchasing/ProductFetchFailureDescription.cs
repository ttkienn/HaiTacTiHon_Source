namespace UnityEngine.Purchasing;

[Nullable(0)]
[NullableContext(1)]
public class ProductFetchFailureDescription : IRetryableRequestFailureDescription
{
	public ProductFetchFailureReason reason; //Field offset: 0x10
	public string message; //Field offset: 0x18
	public bool isRetryable; //Field offset: 0x20

	public override bool IsRetryable
	{
		 get { } //Length: 5
	}

	public string Message
	{
		 get { } //Length: 5
	}

	public ProductFetchFailureReason Reason
	{
		 get { } //Length: 191
	}

	public ProductFetchFailureDescription(ProductFetchFailureReason reason, string message, bool isRetryable = false) { }

	public override bool get_IsRetryable() { }

	public string get_Message() { }

	public ProductFetchFailureReason get_Reason() { }

}

