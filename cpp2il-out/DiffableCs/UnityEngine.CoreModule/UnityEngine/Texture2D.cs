namespace UnityEngine;

[ExcludeFromPreset]
[HelpURL("texture-type-default")]
[NativeHeader("Runtime/Graphics/Texture2D.h")]
[NativeHeader("Runtime/Graphics/GeneratedTextures.h")]
[UsedByNativeCode]
public sealed class Texture2D : Texture
{
	internal const int streamingMipmapsPriorityMin = -128; //Field offset: 0x0
	internal const int streamingMipmapsPriorityMax = 127; //Field offset: 0x0

	public TextureFormat format
	{
		[NativeName("GetTextureFormat")]
		 get { } //Length: 51
	}

	public virtual bool isReadable
	{
		 get { } //Length: 51
	}

	[StaticAccessor("builtintex", StaticAccessorType::DoubleColon (2))]
	public static Texture2D whiteTexture
	{
		 get { } //Length: 42
	}

	public Texture2D(int width, int height, TextureFormat textureFormat, int mipCount, bool linear) { }

	[ExcludeFromDocs]
	public Texture2D(int width, int height) { }

	[ExcludeFromDocs]
	public Texture2D(int width, int height, TextureFormat textureFormat, bool mipChain) { }

	internal Texture2D(int width, int height, TextureFormat textureFormat, int mipCount, bool linear, IntPtr nativeTex, bool createUninitialized, bool ignoreMipmapLimit, string mipmapLimitGroupName) { }

	[ExcludeFromDocs]
	public void Apply() { }

	public void Apply(bool updateMipmaps, bool makeNoLongerReadable) { }

	[NativeName("Apply")]
	private void ApplyImpl(bool updateMipmaps, bool makeNoLongerReadable) { }

	[NativeName("GetTextureFormat")]
	public TextureFormat get_format() { }

	public virtual bool get_isReadable() { }

	public static Texture2D get_whiteTexture() { }

	[ExcludeFromDocs]
	public Color GetPixel(int x, int y) { }

	[ExcludeFromDocs]
	public Color GetPixelBilinear(float u, float v) { }

	[NativeName("GetPixelBilinear")]
	private Color GetPixelBilinearImpl(int image, int mip, float u, float v) { }

	private void GetPixelBilinearImpl_Injected(int image, int mip, float u, float v, out Color ret) { }

	[NativeName("GetPixel")]
	private Color GetPixelImpl(int image, int mip, int x, int y) { }

	private void GetPixelImpl_Injected(int image, int mip, int x, int y, out Color ret) { }

	[FreeFunction("Texture2DScripting::GetPixels", HasExplicitThis = True, ThrowsException = True)]
	public Color[] GetPixels(int x, int y, int blockWidth, int blockHeight, int miplevel) { }

	[ExcludeFromDocs]
	public Color[] GetPixels(int x, int y, int blockWidth, int blockHeight) { }

	public Color[] GetPixels(int miplevel) { }

	[ExcludeFromDocs]
	public Color[] GetPixels() { }

	private ulong GetRawImageDataSize() { }

	public NativeArray<T> GetRawTextureData() { }

	private IntPtr GetWritableImageData(int frame) { }

	private static void Internal_Create(Texture2D mono, int w, int h, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags, IntPtr nativeTex, string mipmapLimitGroupName) { }

	[FreeFunction("Texture2DScripting::Create")]
	private static bool Internal_CreateImpl(Texture2D mono, int w, int h, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags, IntPtr nativeTex, string mipmapLimitGroupName) { }

	public bool Reinitialize(int width, int height, TextureFormat format, bool hasMipMap) { }

	public bool Reinitialize(int width, int height) { }

	[NativeName("Reinitialize")]
	private bool ReinitializeImpl(int width, int height) { }

	[FreeFunction(Name = "Texture2DScripting::ReinitializeWithTextureFormat", HasExplicitThis = True)]
	private bool ReinitializeWithTextureFormatImpl(int width, int height, TextureFormat textureFormat, bool hasMipMap) { }

	[FreeFunction("Texture2DScripting::SetAllPixels32", HasExplicitThis = True, ThrowsException = True)]
	private void SetAllPixels32(Color32[] colors, int miplevel) { }

	[ExcludeFromDocs]
	public void SetPixel(int x, int y, Color color) { }

	[NativeName("SetPixel")]
	private void SetPixelImpl(int image, int mip, int x, int y, Color color) { }

	private void SetPixelImpl_Injected(int image, int mip, int x, int y, ref Color color) { }

	public void SetPixels(int x, int y, int blockWidth, int blockHeight, Color[] colors, int miplevel) { }

	[ExcludeFromDocs]
	public void SetPixels(Color[] colors) { }

	[ExcludeFromDocs]
	public void SetPixels(int x, int y, int blockWidth, int blockHeight, Color[] colors) { }

	[ExcludeFromDocs]
	public void SetPixels32(Color32[] colors) { }

	public void SetPixels32(Color32[] colors, int miplevel) { }

	[FreeFunction(Name = "Texture2DScripting::SetPixels", HasExplicitThis = True, ThrowsException = True)]
	private void SetPixelsImpl(int x, int y, int w, int h, Color[] pixel, int miplevel, int frame) { }

	internal bool ValidateFormat(TextureFormat format, int width, int height) { }

}

