namespace UnityEngine;

[NativeHeader("Runtime/Graphics/ShaderScriptBindings.h")]
[NativeHeader("Runtime/Misc/ResourceManager.h")]
[NativeHeader("Runtime/Shaders/Shader.h")]
[NativeHeader("Runtime/Graphics/ShaderScriptBindings.h")]
[NativeHeader("Runtime/Shaders/ShaderNameRegistry.h")]
[NativeHeader("Runtime/Shaders/ComputeShader.h")]
[NativeHeader("Runtime/Shaders/GpuPrograms/ShaderVariantCollection.h")]
[NativeHeader("Runtime/Shaders/Keywords/KeywordSpaceScriptBindings.h")]
public sealed class Shader : object
{

	private Shader() { }

	public static Shader Find(string name) { }

	[FreeFunction(Name = "ShaderScripting::PropertyToID", IsThreadSafe = True)]
	public static int PropertyToID(string name) { }

	[FreeFunction("ShaderScripting::TagToID")]
	internal static int TagToID(string name) { }

}

