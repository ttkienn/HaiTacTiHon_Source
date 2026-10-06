namespace UnityEngine;

[NativeHeader("Runtime/Shaders/ComputeShader.h")]
[NativeHeader("Runtime/Graphics/ShaderScriptBindings.h")]
[NativeHeader("Runtime/Shaders/ShaderPropertySheet.h")]
[NativeHeader("Runtime/Math/SphericalHarmonicsL2.h")]
public sealed class MaterialPropertyBlock
{
	internal IntPtr m_Ptr; //Field offset: 0x10

	public MaterialPropertyBlock() { }

	[ThreadSafe]
	private void Clear(bool keepMemory) { }

	public void Clear() { }

	[NativeMethod(Name = "MaterialPropertyBlockScripting::Create", IsFreeFunction = True)]
	private static IntPtr CreateImpl() { }

	[NativeMethod(Name = "MaterialPropertyBlockScripting::Destroy", IsFreeFunction = True, IsThreadSafe = True)]
	private static void DestroyImpl(IntPtr mpb) { }

	private void Dispose() { }

	protected virtual void Finalize() { }

	public void SetTexture(int nameID, Texture value) { }

	[NativeName("SetTextureFromScript")]
	[ThreadSafe]
	private void SetTextureImpl(int name, Texture value) { }

	private void SetVectorArray(int name, Vector4[] values, int count) { }

	public void SetVectorArray(int nameID, Vector4[] values) { }

	[NativeName("SetVectorArrayFromScript")]
	[ThreadSafe]
	private void SetVectorArrayImpl(int name, Vector4[] values, int count) { }

}

