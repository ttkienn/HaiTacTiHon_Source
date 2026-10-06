namespace System.Threading.Tasks.Sources;

public interface IValueTaskSource
{

	public TResult GetResult(short token) { }

	public ValueTaskSourceStatus GetStatus(short token) { }

	public void OnCompleted(Action<Object> continuation, object state, short token, ValueTaskSourceOnCompletedFlags flags) { }

}

