namespace UnityEngine;

[ExcludeFromPreset]
[NativeHeader("Runtime/Graphics/CubemapArrayTexture.h")]
public sealed class CubemapArray : Texture
{

	public virtual bool isReadable
	{
		 get { } //Length: 51
	}

	[ExcludeFromDocs]
	public CubemapArray(int width, int cubemapCount, DefaultFormat format, TextureCreationFlags flags) { }

	[ExcludeFromDocs]
	public CubemapArray(int width, int cubemapCount, DefaultFormat format, TextureCreationFlags flags, int mipCount) { }

	[RequiredByNativeCode]
	public CubemapArray(int width, int cubemapCount, GraphicsFormat format, TextureCreationFlags flags) { }

	[ExcludeFromDocs]
	public CubemapArray(int width, int cubemapCount, GraphicsFormat format, TextureCreationFlags flags, int mipCount) { }

	public CubemapArray(int width, int cubemapCount, TextureFormat textureFormat, int mipCount, bool linear, bool createUninitialized) { }

	public CubemapArray(int width, int cubemapCount, TextureFormat textureFormat, int mipCount, bool linear) { }

	public CubemapArray(int width, int cubemapCount, TextureFormat textureFormat, bool mipChain, bool linear, bool createUninitialized) { }

	[ExcludeFromDocs]
	public CubemapArray(int width, int cubemapCount, TextureFormat textureFormat, bool mipChain, bool linear) { }

	public CubemapArray(int width, int cubemapCount, TextureFormat textureFormat, bool mipChain) { }

	public virtual bool get_isReadable() { }

	private static void Internal_Create(CubemapArray mono, int ext, int count, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags) { }

	[FreeFunction("CubemapArrayScripting::Create")]
	private static bool Internal_CreateImpl(CubemapArray mono, int ext, int count, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags) { }

	private static void ValidateIsNotCrunched(TextureCreationFlags flags) { }

}

