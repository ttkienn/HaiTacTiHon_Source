namespace System;

internal sealed class Gen2GcCallback : CriticalFinalizerObject
{
	private Func<Object, Boolean> _callback; //Field offset: 0x10
	private GCHandle _weakTargetObj; //Field offset: 0x18

	private Gen2GcCallback() { }

	protected virtual void Finalize() { }

	public static void Register(Func<Object, Boolean> callback, object targetObj) { }

	private void Setup(Func<Object, Boolean> callback, object targetObj) { }

}

