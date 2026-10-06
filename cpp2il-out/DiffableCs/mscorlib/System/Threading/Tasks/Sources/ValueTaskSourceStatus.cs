namespace System.Threading.Tasks.Sources;

public enum ValueTaskSourceStatus
{
	Pending = 0,
	Succeeded = 1,
	Faulted = 2,
	Canceled = 3,
}

