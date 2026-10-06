namespace System.Runtime.CompilerServices;

public interface ICriticalNotifyCompletion : INotifyCompletion
{

	public void UnsafeOnCompleted(Action continuation) { }

}

