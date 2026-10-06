namespace UnityEngineInternal.Input;

[NativeHeader("Modules/Input/Private/InputInternal.h")]
[NativeHeader("Modules/Input/Private/InputModuleBindings.h")]
internal class NativeInputSystem
{
	public static NativeUpdateCallback onUpdate; //Field offset: 0x0
	public static Action<NativeInputUpdateType> onBeforeUpdate; //Field offset: 0x8
	public static Func<NativeInputUpdateType, Boolean> onShouldRunUpdate; //Field offset: 0x10
	private static Action<Int32, String> s_OnDeviceDiscoveredCallback; //Field offset: 0x18

	internal static bool hasDeviceDiscoveredCallback
	{
		internal set { } //Length: 51
	}

	private static NativeInputSystem() { }

	[RequiredByNativeCode]
	internal static void NotifyBeforeUpdate(NativeInputUpdateType updateType) { }

	[RequiredByNativeCode]
	internal static void NotifyDeviceDiscovered(int deviceId, string deviceDescriptor) { }

	[RequiredByNativeCode]
	internal static void NotifyUpdate(NativeInputUpdateType updateType, IntPtr eventBuffer) { }

	internal static void set_hasDeviceDiscoveredCallback(bool value) { }

	[RequiredByNativeCode]
	internal static void ShouldRunUpdate(NativeInputUpdateType updateType, out bool retval) { }

}

