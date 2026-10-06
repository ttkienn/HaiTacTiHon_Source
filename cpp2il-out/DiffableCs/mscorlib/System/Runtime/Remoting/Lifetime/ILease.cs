namespace System.Runtime.Remoting.Lifetime;

[ComVisible(True)]
public interface ILease
{

	public TimeSpan CurrentLeaseTime
	{
		 get { } //Length: 0
	}

	public LeaseState CurrentState
	{
		 get { } //Length: 0
	}

	public TimeSpan RenewOnCallTime
	{
		 get { } //Length: 0
	}

	public TimeSpan get_CurrentLeaseTime() { }

	public LeaseState get_CurrentState() { }

	public TimeSpan get_RenewOnCallTime() { }

	public TimeSpan Renew(TimeSpan renewalTime) { }

}

