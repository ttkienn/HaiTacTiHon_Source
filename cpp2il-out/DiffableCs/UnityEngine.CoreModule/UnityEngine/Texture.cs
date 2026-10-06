namespace UnityEngine;

[NativeHeader("Runtime/Streaming/TextureStreamingManager.h")]
[NativeHeader("Runtime/Graphics/Texture.h")]
[UsedByNativeCode]
public class Texture : object
{
	public static readonly int GenerateAllMips; //Field offset: 0x0

	internal ColorSpace activeTextureColorSpace
	{
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule", "Unity.UIElements"}])]
		internal get { } //Length: 60
	}

	public int anisoLevel
	{
		 set { } //Length: 64
	}

	public FilterMode filterMode
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	public override int height
	{
		 get { } //Length: 51
		 set { } //Length: 62
	}

	public override bool isReadable
	{
		 get { } //Length: 51
	}

	public float mipMapBias
	{
		 set { } //Length: 67
	}

	public Vector2 texelSize
	{
		[NativeName("GetTexelSize")]
		 get { } //Length: 68
	}

	public override int width
	{
		 get { } //Length: 51
		 set { } //Length: 62
	}

	public TextureWrapMode wrapMode
	{
		[NativeName("GetWrapModeU")]
		 get { } //Length: 51
		 set { } //Length: 64
	}

	private static Texture() { }

	protected Texture() { }

	internal UnityException CreateNativeArrayLengthOverflowException() { }

	internal UnityException CreateNonReadableException(Texture t) { }

	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule", "Unity.UIElements"}])]
	internal ColorSpace get_activeTextureColorSpace() { }

	public FilterMode get_filterMode() { }

	public override int get_height() { }

	public override bool get_isReadable() { }

	[NativeName("GetTexelSize")]
	public Vector2 get_texelSize() { }

	private void get_texelSize_Injected(out Vector2 ret) { }

	public override int get_width() { }

	[NativeName("GetWrapModeU")]
	public TextureWrapMode get_wrapMode() { }

	private int GetDataHeight() { }

	private int GetDataWidth() { }

	internal TextureColorSpace GetTextureColorSpace(bool linear) { }

	internal TextureColorSpace GetTextureColorSpace(GraphicsFormat format) { }

	[NativeMethod("GetActiveTextureColorSpace")]
	private int Internal_GetActiveTextureColorSpace() { }

	public void set_anisoLevel(int value) { }

	public void set_filterMode(FilterMode value) { }

	public override void set_height(int value) { }

	public void set_mipMapBias(float value) { }

	public override void set_width(int value) { }

	public void set_wrapMode(TextureWrapMode value) { }

	internal bool ValidateFormat(TextureFormat format) { }

	internal bool ValidateFormat(GraphicsFormat format, FormatUsage usage) { }

}

