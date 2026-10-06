namespace UnityEngine.Purchasing;

public interface IRetryPolicyInformation
{

	public int NumberOfAttempts
	{
		 get { } //Length: 0
	}

	public float TimeSinceFirstAttempt
	{
		 get { } //Length: 0
	}

	public int get_NumberOfAttempts() { }

	public float get_TimeSinceFirstAttempt() { }

}

