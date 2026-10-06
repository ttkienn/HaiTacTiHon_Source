namespace UnityEngine.VFX;

[NativeType(Header = "Modules/VFX/Public/VFXSpawnerState.h")]
[RequiredByNativeCode]
public sealed class VFXSpawnerState : IDisposable
{
	private IntPtr m_Ptr; //Field offset: 0x10
	private bool m_Owner; //Field offset: 0x18
	private VFXEventAttribute m_WrapEventAttribute; //Field offset: 0x20

	internal VFXSpawnerState(IntPtr ptr, bool owner) { }

	[RequiredByNativeCode]
	internal static VFXSpawnerState CreateSpawnerStateWrapper() { }

	public override void Dispose() { }

	protected virtual void Finalize() { }

	[NativeMethod(IsThreadSafe = True)]
	private static void Internal_Destroy(IntPtr ptr) { }

	private void PrepareWrapper() { }

	private void Release() { }

	[RequiredByNativeCode]
	internal void SetWrapValue(IntPtr ptrToSpawnerState, IntPtr ptrToEventAttribute) { }

}

