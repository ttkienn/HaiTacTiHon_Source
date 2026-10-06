namespace UnityEngine;

[ExcludeFromPreset]
[NativeHeader("Runtime/Graphics/Texture3D.h")]
public sealed class Texture3D : Texture
{

	public virtual bool isReadable
	{
		 get { } //Length: 51
	}

	[ExcludeFromDocs]
	public Texture3D(int width, int height, int depth, DefaultFormat format, TextureCreationFlags flags) { }

	[ExcludeFromDocs]
	public Texture3D(int width, int height, int depth, DefaultFormat format, TextureCreationFlags flags, int mipCount) { }

	[ExcludeFromDocs]
	[RequiredByNativeCode]
	public Texture3D(int width, int height, int depth, GraphicsFormat format, TextureCreationFlags flags) { }

	[ExcludeFromDocs]
	public Texture3D(int width, int height, int depth, GraphicsFormat format, TextureCreationFlags flags, int mipCount) { }

	[ExcludeFromDocs]
	public Texture3D(int width, int height, int depth, TextureFormat textureFormat, int mipCount) { }

	public Texture3D(int width, int height, int depth, TextureFormat textureFormat, int mipCount, IntPtr nativeTex) { }

	public Texture3D(int width, int height, int depth, TextureFormat textureFormat, int mipCount, IntPtr nativeTex, bool createUninitialized) { }

	[ExcludeFromDocs]
	public Texture3D(int width, int height, int depth, TextureFormat textureFormat, bool mipChain) { }

	public Texture3D(int width, int height, int depth, TextureFormat textureFormat, bool mipChain, bool createUninitialized) { }

	public Texture3D(int width, int height, int depth, TextureFormat textureFormat, bool mipChain, IntPtr nativeTex) { }

	public virtual bool get_isReadable() { }

	private static void Internal_Create(Texture3D mono, int w, int h, int d, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags, IntPtr nativeTex) { }

	[FreeFunction("Texture3DScripting::Create")]
	private static bool Internal_CreateImpl(Texture3D mono, int w, int h, int d, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags, IntPtr nativeTex) { }

	private static void ValidateIsNotCrunched(TextureCreationFlags flags) { }

}

