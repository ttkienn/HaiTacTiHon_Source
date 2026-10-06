namespace UnityEngine;

[NativeHeader("Runtime/Misc/PlayerSettings.h")]
[NativeHeader("Runtime/Graphics/QualitySettings.h")]
[StaticAccessor("GetQualitySettings()", StaticAccessorType::Dot (0))]
public sealed class QualitySettings : object
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action<Int32, Int32> activeQualityLevelChanged; //Field offset: 0x0

	public static ColorSpace activeColorSpace
	{
		[NativeName("GetColorSpace")]
		[StaticAccessor("GetPlayerSettings()", StaticAccessorType::Dot (0))]
		 get { } //Length: 42
	}

	[NativeName("GetColorSpace")]
	[StaticAccessor("GetPlayerSettings()", StaticAccessorType::Dot (0))]
	public static ColorSpace get_activeColorSpace() { }

	[RequiredByNativeCode]
	internal static void OnActiveQualityLevelChanged(int previousQualityLevel, int currentQualityLevel) { }

}

