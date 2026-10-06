namespace UnityEngine.VFX;

[NativeType(Header = "Modules/VFX/Public/VFXEventAttribute.h")]
[RequiredByNativeCode]
public sealed class VFXEventAttribute : IDisposable
{
	private IntPtr m_Ptr; //Field offset: 0x10
	private bool m_Owner; //Field offset: 0x18
	private VisualEffectAsset m_VfxAsset; //Field offset: 0x20

	private VFXEventAttribute(IntPtr ptr, bool owner, VisualEffectAsset vfxAsset) { }

	internal static VFXEventAttribute CreateEventAttributeWrapper() { }

	public override void Dispose() { }

	protected virtual void Finalize() { }

	internal static IntPtr Internal_Create() { }

	[NativeMethod(IsThreadSafe = True)]
	internal static void Internal_Destroy(IntPtr ptr) { }

	internal void Internal_InitFromAsset(VisualEffectAsset vfxAsset) { }

	internal static VFXEventAttribute Internal_InstanciateVFXEventAttribute(VisualEffectAsset vfxAsset) { }

	private void Release() { }

	internal void SetWrapValue(IntPtr ptrToEventAttribute) { }

}

