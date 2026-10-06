namespace UnityEngine;

[NativeHeader("Runtime/Shaders/GraphicsCapsScriptBindings.h")]
[NativeHeader("Runtime/Graphics/Mesh/MeshScriptBindings.h")]
[NativeHeader("Runtime/Misc/SystemInfo.h")]
[NativeHeader("Runtime/Input/GetInput.h")]
[NativeHeader("Runtime/Graphics/GraphicsFormatUtility.bindings.h")]
[NativeHeader("Runtime/Camera/RenderLoops/MotionVectorRenderLoop.h")]
public sealed class SystemInfo
{

	[NativeProperty]
	public static float batteryLevel
	{
		 get { } //Length: 42
	}

	public static string deviceModel
	{
		 get { } //Length: 42
	}

	public static string deviceName
	{
		 get { } //Length: 42
	}

	public static DeviceType deviceType
	{
		 get { } //Length: 42
	}

	public static string deviceUniqueIdentifier
	{
		 get { } //Length: 42
	}

	public static string graphicsDeviceName
	{
		 get { } //Length: 42
	}

	internal static int maxRenderTextureSize
	{
		internal get { } //Length: 42
	}

	public static int maxTextureSize
	{
		 get { } //Length: 42
	}

	public static string operatingSystem
	{
		 get { } //Length: 42
	}

	public static OperatingSystemFamily operatingSystemFamily
	{
		 get { } //Length: 42
	}

	public static int processorCount
	{
		 get { } //Length: 42
	}

	public static string processorType
	{
		 get { } //Length: 42
	}

	public static int systemMemorySize
	{
		 get { } //Length: 42
	}

	public static float get_batteryLevel() { }

	public static string get_deviceModel() { }

	public static string get_deviceName() { }

	public static DeviceType get_deviceType() { }

	public static string get_deviceUniqueIdentifier() { }

	public static string get_graphicsDeviceName() { }

	internal static int get_maxRenderTextureSize() { }

	public static int get_maxTextureSize() { }

	public static string get_operatingSystem() { }

	public static OperatingSystemFamily get_operatingSystemFamily() { }

	public static int get_processorCount() { }

	public static string get_processorType() { }

	public static int get_systemMemorySize() { }

	[FreeFunction("systeminfo::GetBatteryLevel")]
	private static float GetBatteryLevel() { }

	[FreeFunction("ScriptingGraphicsCaps::GetCompatibleFormat")]
	public static GraphicsFormat GetCompatibleFormat(GraphicsFormat format, FormatUsage usage) { }

	[FreeFunction("systeminfo::GetDeviceModel")]
	private static string GetDeviceModel() { }

	[FreeFunction("systeminfo::GetDeviceName")]
	private static string GetDeviceName() { }

	[FreeFunction("systeminfo::GetDeviceType")]
	private static DeviceType GetDeviceType() { }

	[FreeFunction("systeminfo::GetDeviceUniqueIdentifier")]
	private static string GetDeviceUniqueIdentifier() { }

	[FreeFunction("ScriptingGraphicsCaps::GetGraphicsDeviceName")]
	private static string GetGraphicsDeviceName() { }

	[FreeFunction("ScriptingGraphicsCaps::GetGraphicsFormat")]
	public static GraphicsFormat GetGraphicsFormat(DefaultFormat format) { }

	[FreeFunction("ScriptingGraphicsCaps::GetMaxRenderTextureSize")]
	private static int GetMaxRenderTextureSize() { }

	[FreeFunction("ScriptingGraphicsCaps::GetMaxTextureSize")]
	private static int GetMaxTextureSize() { }

	[FreeFunction("systeminfo::GetOperatingSystem")]
	private static string GetOperatingSystem() { }

	[FreeFunction("systeminfo::GetOperatingSystemFamily")]
	private static OperatingSystemFamily GetOperatingSystemFamily() { }

	[FreeFunction("systeminfo::GetPhysicalMemoryMB")]
	private static int GetPhysicalMemoryMB() { }

	[FreeFunction("systeminfo::GetProcessorCount")]
	private static int GetProcessorCount() { }

	[FreeFunction("systeminfo::GetProcessorType")]
	private static string GetProcessorType() { }

	[FreeFunction("ScriptingGraphicsCaps::IsFormatSupported")]
	public static bool IsFormatSupported(GraphicsFormat format, FormatUsage usage) { }

	private static bool IsValidEnumValue(Enum value) { }

	public static bool SupportsTextureFormat(TextureFormat format) { }

	[FreeFunction("ScriptingGraphicsCaps::SupportsTextureFormat")]
	private static bool SupportsTextureFormatNative(TextureFormat format) { }

}

