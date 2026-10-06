namespace UnityEngine.Android;

[NativeConditional("PLATFORM_ANDROID")]
[NativeHeader("Modules/AndroidJNI/Public/AndroidApp.bindings.h")]
[StaticAccessor("AndroidApp", StaticAccessorType::DoubleColon (2))]
internal static class AndroidApp
{

	public static IntPtr UnityPlayerRaw
	{
		[ThreadSafe]
		 get { } //Length: 42
	}

	[ThreadSafe]
	public static IntPtr get_UnityPlayerRaw() { }

}

