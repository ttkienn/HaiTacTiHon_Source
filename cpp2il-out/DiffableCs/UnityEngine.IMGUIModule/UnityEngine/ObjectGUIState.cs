namespace UnityEngine;

[NativeHeader("Modules/IMGUI/GUIState.h")]
internal class ObjectGUIState : IDisposable
{
	internal IntPtr m_Ptr; //Field offset: 0x10

	public ObjectGUIState() { }

	private void Destroy() { }

	public override void Dispose() { }

	protected virtual void Finalize() { }

	private static IntPtr Internal_Create() { }

	[NativeMethod(IsThreadSafe = True)]
	private static void Internal_Destroy(IntPtr ptr) { }

}

