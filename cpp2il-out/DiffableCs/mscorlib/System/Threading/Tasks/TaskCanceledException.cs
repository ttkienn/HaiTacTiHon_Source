namespace System.Threading.Tasks;

public class TaskCanceledException : OperationCanceledException
{
	private readonly Task _canceledTask; //Field offset: 0x98

	public TaskCanceledException() { }

	public TaskCanceledException(Task task) { }

	protected TaskCanceledException(SerializationInfo info, StreamingContext context) { }

}

