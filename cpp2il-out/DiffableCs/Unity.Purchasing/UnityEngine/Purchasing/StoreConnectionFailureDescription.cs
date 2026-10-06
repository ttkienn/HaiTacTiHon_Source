namespace UnityEngine.Purchasing;

[Nullable(0)]
[NullableContext(1)]
public class StoreConnectionFailureDescription : IRetryableRequestFailureDescription
{
	public string message; //Field offset: 0x10
	public bool isRetryable; //Field offset: 0x18

	public override bool IsRetryable
	{
		 get { } //Length: 5
	}

	public string Message
	{
		 get { } //Length: 5
	}

	public StoreConnectionFailureDescription(string message, bool isRetryable = false) { }

	public override bool get_IsRetryable() { }

	public string get_Message() { }

}

