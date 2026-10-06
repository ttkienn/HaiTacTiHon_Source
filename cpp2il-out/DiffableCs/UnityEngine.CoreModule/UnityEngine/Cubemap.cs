namespace UnityEngine;

[ExcludeFromPreset]
[NativeHeader("Runtime/Graphics/CubemapTexture.h")]
public sealed class Cubemap : Texture
{

	public virtual bool isReadable
	{
		 get { } //Length: 51
	}

	[ExcludeFromDocs]
	public Cubemap(int width, DefaultFormat format, TextureCreationFlags flags) { }

	[ExcludeFromDocs]
	public Cubemap(int width, DefaultFormat format, TextureCreationFlags flags, int mipCount) { }

	[ExcludeFromDocs]
	[RequiredByNativeCode]
	public Cubemap(int width, GraphicsFormat format, TextureCreationFlags flags) { }

	[ExcludeFromDocs]
	public Cubemap(int width, GraphicsFormat format, TextureCreationFlags flags, int mipCount) { }

	internal Cubemap(int width, TextureFormat textureFormat, int mipCount, IntPtr nativeTex, bool createUninitialized) { }

	public Cubemap(int width, TextureFormat textureFormat, bool mipChain) { }

	public Cubemap(int width, TextureFormat textureFormat, bool mipChain, bool createUninitialized) { }

	public Cubemap(int width, TextureFormat format, int mipCount) { }

	public Cubemap(int width, TextureFormat format, int mipCount, bool createUninitialized) { }

	public virtual bool get_isReadable() { }

	private static void Internal_Create(Cubemap mono, int ext, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags, IntPtr nativeTex) { }

	[FreeFunction("CubemapScripting::Create")]
	private static bool Internal_CreateImpl(Cubemap mono, int ext, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags, IntPtr nativeTex) { }

	internal bool ValidateFormat(TextureFormat format, int width) { }

	internal bool ValidateFormat(GraphicsFormat format, int width) { }

	private static void ValidateIsNotCrunched(TextureCreationFlags flags) { }

}

