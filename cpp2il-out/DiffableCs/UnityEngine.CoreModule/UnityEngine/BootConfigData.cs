namespace UnityEngine;

[NativeHeader("Runtime/Export/Bootstrap/BootConfig.bindings.h")]
internal class BootConfigData
{
	private IntPtr m_Ptr; //Field offset: 0x10

	private BootConfigData(IntPtr nativeHandle) { }

	[RequiredByNativeCode]
	private static BootConfigData WrapBootConfigData(IntPtr nativeHandle) { }

}

