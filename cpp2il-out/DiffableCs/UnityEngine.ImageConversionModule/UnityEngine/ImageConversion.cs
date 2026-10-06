namespace UnityEngine;

[Extension]
[NativeHeader("Modules/ImageConversion/ScriptBindings/ImageConversion.bindings.h")]
public static class ImageConversion
{

	[Extension]
	[NativeMethod(Name = "ImageConversionBindings::LoadImage", IsFreeFunction = True)]
	public static bool LoadImage(Texture2D tex, Byte[] data, bool markNonReadable) { }

	[Extension]
	public static bool LoadImage(Texture2D tex, Byte[] data) { }

}

