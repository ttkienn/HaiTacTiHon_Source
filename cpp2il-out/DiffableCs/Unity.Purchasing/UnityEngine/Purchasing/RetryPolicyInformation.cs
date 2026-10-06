namespace UnityEngine.Purchasing;

public struct RetryPolicyInformation : IRetryPolicyInformation
{
	[CompilerGenerated]
	private readonly int <NumberOfAttempts>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private readonly float <TimeSinceFirstAttempt>k__BackingField; //Field offset: 0x4

	public override int NumberOfAttempts
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 3
	}

	public override float TimeSinceFirstAttempt
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 6
	}

	internal RetryPolicyInformation(int numberOfAttempts, float timeSinceFirstAttempt) { }

	[CompilerGenerated]
	[IsReadOnly]
	public override int get_NumberOfAttempts() { }

	[CompilerGenerated]
	[IsReadOnly]
	public override float get_TimeSinceFirstAttempt() { }

}

