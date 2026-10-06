namespace UnityEngine;

[NativeHeader("Runtime/Graphics/WindowLayout.h")]
[NativeHeader("Runtime/Graphics/ScreenManager.h")]
[NativeHeader("Runtime/Graphics/GraphicsScriptBindings.h")]
[StaticAccessor("GetScreenManager()", StaticAccessorType::Dot (0))]
public sealed class Screen
{

	public static float dpi
	{
		[NativeName("GetDPI")]
		 get { } //Length: 42
	}

	public static bool fullScreen
	{
		[NativeName("IsFullscreen")]
		 get { } //Length: 42
		[NativeName("RequestSetFullscreenFromScript")]
		 set { } //Length: 51
	}

	public static int height
	{
		[NativeMethod(Name = "GetHeight", IsThreadSafe = True)]
		 get { } //Length: 42
	}

	public static ScreenOrientation orientation
	{
		 get { } //Length: 42
		 set { } //Length: 292
	}

	public static int width
	{
		[NativeMethod(Name = "GetWidth", IsThreadSafe = True)]
		 get { } //Length: 42
	}

	[NativeName("GetDPI")]
	public static float get_dpi() { }

	[NativeName("IsFullscreen")]
	public static bool get_fullScreen() { }

	[NativeMethod(Name = "GetHeight", IsThreadSafe = True)]
	public static int get_height() { }

	public static ScreenOrientation get_orientation() { }

	[NativeMethod(Name = "GetWidth", IsThreadSafe = True)]
	public static int get_width() { }

	private static ScreenOrientation GetScreenOrientation() { }

	private static void RequestOrientation(ScreenOrientation orient) { }

	[NativeName("RequestSetFullscreenFromScript")]
	public static void set_fullScreen(bool value) { }

	public static void set_orientation(ScreenOrientation value) { }

	[NativeName("RequestResolution")]
	public static void SetResolution(int width, int height, FullScreenMode fullscreenMode, RefreshRate preferredRefreshRate) { }

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("SetResolution(int, int, bool, int) is obsolete. Use SetResolution(int, int, FullScreenMode, RefreshRate) instead.")]
	public static void SetResolution(int width, int height, bool fullscreen, int preferredRefreshRate) { }

	public static void SetResolution(int width, int height, bool fullscreen) { }

	private static void SetResolution_Injected(int width, int height, FullScreenMode fullscreenMode, ref RefreshRate preferredRefreshRate) { }

}

