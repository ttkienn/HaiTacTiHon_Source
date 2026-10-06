namespace UnityEngineInternal.Input;

internal sealed class NativeUpdateCallback : MulticastDelegate
{

	public NativeUpdateCallback(object object, IntPtr method) { }

	public override void Invoke(NativeInputUpdateType updateType, NativeInputEventBuffer* buffer) { }

}

