namespace System.Threading;

[ComVisible(True)]
public class EventWaitHandle : WaitHandle
{

	public EventWaitHandle(bool initialState, EventResetMode mode) { }

	public EventWaitHandle(bool initialState, EventResetMode mode, string name) { }

	public bool Reset() { }

	public bool Set() { }

}

