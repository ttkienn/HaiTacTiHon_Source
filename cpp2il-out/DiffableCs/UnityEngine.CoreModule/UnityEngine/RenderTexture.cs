namespace UnityEngine;

[NativeHeader("Runtime/Camera/Camera.h")]
[NativeHeader("Runtime/Graphics/RenderTexture.h")]
[NativeHeader("Runtime/Graphics/RenderBufferManager.h")]
[NativeHeader("Runtime/Graphics/GraphicsScriptBindings.h")]
[UsedByNativeCode]
public class RenderTexture : Texture
{

	public static RenderTexture active
	{
		 get { } //Length: 42
		 set { } //Length: 51
	}

	public RenderBuffer colorBuffer
	{
		 get { } //Length: 90
	}

	public RenderBuffer depthBuffer
	{
		 get { } //Length: 90
	}

	public GraphicsFormat depthStencilFormat
	{
		 set { } //Length: 64
	}

	public RenderTextureDescriptor descriptor
	{
		 get { } //Length: 142
	}

	public GraphicsFormat graphicsFormat
	{
		 set { } //Length: 64
	}

	public virtual int height
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	public virtual int width
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	[ExcludeFromDocs]
	public RenderTexture(int width, int height, GraphicsFormat colorFormat, GraphicsFormat depthStencilFormat, int mipCount) { }

	public RenderTexture(RenderTextureDescriptor desc) { }

	public RenderTexture(RenderTexture textureToCopy) { }

	[ExcludeFromDocs]
	public RenderTexture(int width, int height, int depth, DefaultFormat format) { }

	[ExcludeFromDocs]
	public RenderTexture(int width, int height, int depth, GraphicsFormat format) { }

	[ExcludeFromDocs]
	public RenderTexture(int width, int height, GraphicsFormat colorFormat, GraphicsFormat depthStencilFormat) { }

	[ExcludeFromDocs]
	public RenderTexture(int width, int height, int depth, GraphicsFormat format, int mipCount) { }

	[ExcludeFromDocs]
	public RenderTexture(int width, int height, int depth, RenderTextureFormat format) { }

	[ExcludeFromDocs]
	public RenderTexture(int width, int height, int depth) { }

	[ExcludeFromDocs]
	public RenderTexture(int width, int height, int depth, RenderTextureFormat format, int mipCount) { }

	public RenderTexture(int width, int height, int depth, RenderTextureFormat format, RenderTextureReadWrite readWrite) { }

	[RequiredByNativeCode]
	protected private RenderTexture() { }

	public static RenderTexture get_active() { }

	public RenderBuffer get_colorBuffer() { }

	public RenderBuffer get_depthBuffer() { }

	public RenderTextureDescriptor get_descriptor() { }

	public virtual int get_height() { }

	public virtual int get_width() { }

	[FreeFunction("RenderTexture::GetActive")]
	private static RenderTexture GetActive() { }

	[FreeFunction(Name = "RenderTextureScripting::GetColorBuffer", HasExplicitThis = True)]
	private RenderBuffer GetColorBuffer() { }

	private void GetColorBuffer_Injected(out RenderBuffer ret) { }

	internal static GraphicsFormat GetCompatibleFormat(RenderTextureFormat renderTextureFormat, RenderTextureReadWrite readWrite) { }

	internal static GraphicsFormat GetDefaultColorFormat(DefaultFormat format) { }

	internal static GraphicsFormat GetDefaultDepthStencilFormat(DefaultFormat format, int depth) { }

	[FreeFunction(Name = "RenderTextureScripting::GetDepthBuffer", HasExplicitThis = True)]
	private RenderBuffer GetDepthBuffer() { }

	private void GetDepthBuffer_Injected(out RenderBuffer ret) { }

	internal static GraphicsFormat GetDepthStencilFormatLegacy(int depthBits, RenderTextureFormat format) { }

	internal static GraphicsFormat GetDepthStencilFormatLegacy(int depthBits, GraphicsFormat colorFormat) { }

	internal static GraphicsFormat GetDepthStencilFormatLegacy(int depthBits, DefaultFormat format) { }

	internal static GraphicsFormat GetDepthStencilFormatLegacy(int depthBits, bool requestedShadowMap) { }

	[NativeName("GetRenderTextureDesc")]
	private RenderTextureDescriptor GetDescriptor() { }

	private void GetDescriptor_Injected(out RenderTextureDescriptor ret) { }

	[ExcludeFromDocs]
	public static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing) { }

	[ExcludeFromDocs]
	public static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing, RenderTextureMemoryless memorylessMode) { }

	[ExcludeFromDocs]
	public static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing, RenderTextureMemoryless memorylessMode, VRTextureUsage vrUsage) { }

	public static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing, RenderTextureMemoryless memorylessMode, VRTextureUsage vrUsage, bool useDynamicScale) { }

	public static RenderTexture GetTemporary(RenderTextureDescriptor desc) { }

	[ExcludeFromDocs]
	public static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format, RenderTextureReadWrite readWrite) { }

	[ExcludeFromDocs]
	public static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format) { }

	[FreeFunction("GetRenderBufferManager().GetTextures().GetTempBuffer")]
	private static RenderTexture GetTemporary_Internal(RenderTextureDescriptor desc) { }

	private static RenderTexture GetTemporary_Internal_Injected(ref RenderTextureDescriptor desc) { }

	private static RenderTexture GetTemporaryImpl(int width, int height, GraphicsFormat depthStencilFormat, GraphicsFormat colorFormat, int antiAliasing = 1, RenderTextureMemoryless memorylessMode = 0, VRTextureUsage vrUsage = 0, bool useDynamicScale = false) { }

	private void Initialize(int width, int height, int depth, RenderTextureFormat format, RenderTextureReadWrite readWrite, int mipCount) { }

	[FreeFunction("RenderTextureScripting::Create")]
	private static void Internal_Create(RenderTexture rt) { }

	[FreeFunction("GetRenderBufferManager().GetTextures().ReleaseTempBuffer")]
	public static void ReleaseTemporary(RenderTexture temp) { }

	public static void set_active(RenderTexture value) { }

	public void set_depthStencilFormat(GraphicsFormat value) { }

	public void set_graphicsFormat(GraphicsFormat value) { }

	public virtual void set_height(int value) { }

	public virtual void set_width(int value) { }

	[FreeFunction("RenderTextureScripting::SetActive")]
	private static void SetActive(RenderTexture rt) { }

	[NativeName("SetColorFormat")]
	private void SetColorFormat(GraphicsFormat format) { }

	private void SetMipMapCount(int count) { }

	[NativeName("SetRenderTextureDescFromScript")]
	private void SetRenderTextureDescriptor(RenderTextureDescriptor desc) { }

	private void SetRenderTextureDescriptor_Injected(ref RenderTextureDescriptor desc) { }

	internal void SetSRGBReadWrite(bool srgb) { }

	private static void ValidateRenderTextureDesc(RenderTextureDescriptor desc) { }

}

