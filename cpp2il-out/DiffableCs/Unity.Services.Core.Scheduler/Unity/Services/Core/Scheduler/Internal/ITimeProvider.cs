namespace Unity.Services.Core.Scheduler.Internal;

internal interface ITimeProvider
{

	public DateTime Now
	{
		 get { } //Length: 0
	}

	public DateTime get_Now() { }

}

