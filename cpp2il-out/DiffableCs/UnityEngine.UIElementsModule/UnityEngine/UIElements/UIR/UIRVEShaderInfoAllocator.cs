namespace UnityEngine.UIElements.UIR;

internal struct UIRVEShaderInfoAllocator
{
	internal static readonly Vector2Int identityTransformTexel; //Field offset: 0x0
	internal static readonly Vector2Int infiniteClipRectTexel; //Field offset: 0x8
	internal static readonly Vector2Int fullOpacityTexel; //Field offset: 0x10
	internal static readonly Vector2Int clearColorTexel; //Field offset: 0x18
	internal static readonly Vector2Int defaultTextCoreSettingsTexel; //Field offset: 0x20
	internal static readonly Matrix4x4 identityTransformValue; //Field offset: 0x28
	internal static readonly Vector4 identityTransformRow0Value; //Field offset: 0x68
	internal static readonly Vector4 identityTransformRow1Value; //Field offset: 0x78
	internal static readonly Vector4 identityTransformRow2Value; //Field offset: 0x88
	internal static readonly Vector4 infiniteClipRectValue; //Field offset: 0x98
	internal static readonly Vector4 fullOpacityValue; //Field offset: 0xA8
	internal static readonly Vector4 clearColorValue; //Field offset: 0xB8
	internal static readonly TextCoreSettings defaultTextCoreSettingsValue; //Field offset: 0xC8
	public static readonly BMPAlloc identityTransform; //Field offset: 0x108
	public static readonly BMPAlloc infiniteClipRect; //Field offset: 0x110
	public static readonly BMPAlloc fullOpacity; //Field offset: 0x118
	public static readonly BMPAlloc clearColor; //Field offset: 0x120
	public static readonly BMPAlloc defaultTextCoreSettings; //Field offset: 0x128
	private BaseShaderInfoStorage m_Storage; //Field offset: 0x0
	private BitmapAllocator32 m_TransformAllocator; //Field offset: 0x8
	private BitmapAllocator32 m_ClipRectAllocator; //Field offset: 0x28
	private BitmapAllocator32 m_OpacityAllocator; //Field offset: 0x48
	private BitmapAllocator32 m_ColorAllocator; //Field offset: 0x68
	private BitmapAllocator32 m_TextSettingsAllocator; //Field offset: 0x88
	private bool m_StorageReallyCreated; //Field offset: 0xA8
	private bool m_VertexTexturingEnabled; //Field offset: 0xA9
	private NativeArray<Transform3x4> m_Transforms; //Field offset: 0xB0
	private NativeArray<Vector4> m_ClipRects; //Field offset: 0xC0

	public Texture atlas
	{
		 get { } //Length: 153
	}

	public NativeSlice<Vector4> clipRectConstants
	{
		 get { } //Length: 106
	}

	private static int pageHeight
	{
		private get { } //Length: 8
	}

	private static int pageWidth
	{
		private get { } //Length: 8
	}

	public NativeSlice<Transform3x4> transformConstants
	{
		 get { } //Length: 106
	}

	private static UIRVEShaderInfoAllocator() { }

	public BMPAlloc AllocClipRect() { }

	public BMPAlloc AllocColor() { }

	public BMPAlloc AllocOpacity() { }

	public BMPAlloc AllocTextCoreSettings(TextCoreSettings settings) { }

	private static int AllocToConstantBufferIndex(BMPAlloc alloc) { }

	private static Vector2Int AllocToTexelCoord(ref BitmapAllocator32 allocator, BMPAlloc alloc) { }

	public BMPAlloc AllocTransform() { }

	private static bool AtlasRectMatchesPage(ref BitmapAllocator32 allocator, BMPAlloc defAlloc, RectInt atlasRect) { }

	public Color32 ClipRectAllocToVertexData(BMPAlloc alloc) { }

	public Color32 ColorAllocToVertexData(BMPAlloc alloc) { }

	public void Construct() { }

	public void Dispose() { }

	public void FreeClipRect(BMPAlloc alloc) { }

	public void FreeColor(BMPAlloc alloc) { }

	public void FreeOpacity(BMPAlloc alloc) { }

	public void FreeTextCoreSettings(BMPAlloc alloc) { }

	public void FreeTransform(BMPAlloc alloc) { }

	public Texture get_atlas() { }

	public NativeSlice<Vector4> get_clipRectConstants() { }

	private static int get_pageHeight() { }

	private static int get_pageWidth() { }

	public NativeSlice<Transform3x4> get_transformConstants() { }

	public void IssuePendingStorageChanges() { }

	public Color32 OpacityAllocToVertexData(BMPAlloc alloc) { }

	private void ReallyCreateStorage() { }

	public void SetClipRectValue(BMPAlloc alloc, Vector4 clipRect) { }

	public void SetColorValue(BMPAlloc alloc, Color color, bool isEditorContext) { }

	public void SetOpacityValue(BMPAlloc alloc, float opacity) { }

	public void SetTextCoreSettingValue(BMPAlloc alloc, TextCoreSettings settings, bool isEditorContext) { }

	public void SetTransformValue(BMPAlloc alloc, Matrix4x4 xform) { }

	public Color32 TextCoreSettingsToVertexData(BMPAlloc alloc) { }

	public Color32 TransformAllocToVertexData(BMPAlloc alloc) { }

}

