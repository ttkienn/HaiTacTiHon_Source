namespace Unity.Services.Analytics;

public class TransactionFailedEvent : TransactionEvent
{

	public string FailureReason
	{
		 set { } //Length: 131
	}

	public TransactionFailedEvent() { }

	public void set_FailureReason(string value) { }

	public virtual void Validate() { }

}

