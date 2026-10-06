namespace UnityEngine;

[NativeHeader("Runtime/Shaders/ComputeShader.h")]
[NativeHeader("Runtime/Graphics/ShaderScriptBindings.h")]
[UsedByNativeCode]
public sealed class ComputeShader : object
{

	[NativeMethod(Name = "ComputeShaderScripting::FindKernel", HasExplicitThis = True, IsFreeFunction = True, ThrowsException = True)]
	[RequiredByNativeCode]
	public int FindKernel(string name) { }

}

