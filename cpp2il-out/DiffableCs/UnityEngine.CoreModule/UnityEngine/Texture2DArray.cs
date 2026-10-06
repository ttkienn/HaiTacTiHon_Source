namespace UnityEngine;

[ExcludeFromPreset]
[NativeHeader("Runtime/Graphics/Texture2DArray.h")]
public sealed class Texture2DArray : Texture
{

	public virtual bool isReadable
	{
		 get { } //Length: 51
	}

	[ExcludeFromDocs]
	public Texture2DArray(int width, int height, int depth, DefaultFormat format, TextureCreationFlags flags) { }

	[ExcludeFromDocs]
	public Texture2DArray(int width, int height, int depth, DefaultFormat format, TextureCreationFlags flags, int mipCount) { }

	[RequiredByNativeCode]
	public Texture2DArray(int width, int height, int depth, GraphicsFormat format, TextureCreationFlags flags) { }

	[ExcludeFromDocs]
	public Texture2DArray(int width, int height, int depth, GraphicsFormat format, TextureCreationFlags flags, int mipCount) { }

	public Texture2DArray(int width, int height, int depth, TextureFormat textureFormat, int mipCount, bool linear, bool createUninitialized) { }

	public Texture2DArray(int width, int height, int depth, TextureFormat textureFormat, int mipCount, bool linear) { }

	public Texture2DArray(int width, int height, int depth, TextureFormat textureFormat, bool mipChain, bool linear, bool createUninitialized) { }

	public Texture2DArray(int width, int height, int depth, TextureFormat textureFormat, bool mipChain, bool linear) { }

	[ExcludeFromDocs]
	public Texture2DArray(int width, int height, int depth, TextureFormat textureFormat, bool mipChain) { }

	public virtual bool get_isReadable() { }

	private static void Internal_Create(Texture2DArray mono, int w, int h, int d, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags) { }

	[FreeFunction("Texture2DArrayScripting::Create")]
	private static bool Internal_CreateImpl(Texture2DArray mono, int w, int h, int d, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags) { }

	internal bool ValidateFormat(TextureFormat format, int width, int height) { }

	internal bool ValidateFormat(GraphicsFormat format, int width, int height) { }

	private static void ValidateIsNotCrunched(TextureCreationFlags flags) { }

}

