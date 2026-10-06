namespace System.Threading;

[ComVisible(True)]
public sealed class RegisteredWaitHandle : MarshalByRefObject
{
	private WaitHandle _waitObject; //Field offset: 0x18
	private WaitOrTimerCallback _callback; //Field offset: 0x20
	private object _state; //Field offset: 0x28
	private WaitHandle _finalEvent; //Field offset: 0x30
	private ManualResetEvent _cancelEvent; //Field offset: 0x38
	private TimeSpan _timeout; //Field offset: 0x40
	private int _callsInProcess; //Field offset: 0x48
	private bool _executeOnlyOnce; //Field offset: 0x4C
	private bool _unregistered; //Field offset: 0x4D

	internal RegisteredWaitHandle(WaitHandle waitObject, WaitOrTimerCallback callback, object state, TimeSpan timeout, bool executeOnlyOnce) { }

	private void DoCallBack(object timedOut) { }

	[ComVisible(True)]
	public bool Unregister(WaitHandle waitObject) { }

	internal void Wait(object state) { }

}

