namespace UnityEngine.UIElements;

[NativeHeader("ModuleOverrides/com.unity.ui/Core/Native/Renderer/UIRMeshBuilder.bindings.h")]
internal static class MeshBuilderNative
{
	internal struct NativeBorderParams
	{
		public Rect rect; //Field offset: 0x0
		public Color leftColor; //Field offset: 0x10
		public Color topColor; //Field offset: 0x20
		public Color rightColor; //Field offset: 0x30
		public Color bottomColor; //Field offset: 0x40
		public float leftWidth; //Field offset: 0x50
		public float topWidth; //Field offset: 0x54
		public float rightWidth; //Field offset: 0x58
		public float bottomWidth; //Field offset: 0x5C
		public Vector2 topLeftRadius; //Field offset: 0x60
		public Vector2 topRightRadius; //Field offset: 0x68
		public Vector2 bottomRightRadius; //Field offset: 0x70
		public Vector2 bottomLeftRadius; //Field offset: 0x78
		internal NativeColorPage leftColorPage; //Field offset: 0x80
		internal NativeColorPage topColorPage; //Field offset: 0x88
		internal NativeColorPage rightColorPage; //Field offset: 0x90
		internal NativeColorPage bottomColorPage; //Field offset: 0x98

	}

	internal struct NativeColorPage
	{
		public int isValid; //Field offset: 0x0
		public Color32 pageAndID; //Field offset: 0x4

	}

	internal struct NativeRectParams
	{
		public Rect rect; //Field offset: 0x0
		public Rect subRect; //Field offset: 0x10
		public Rect uv; //Field offset: 0x20
		public Rect uvRegion; //Field offset: 0x30
		public Color color; //Field offset: 0x40
		public ScaleMode scaleMode; //Field offset: 0x50
		public Vector2 topLeftRadius; //Field offset: 0x54
		public Vector2 topRightRadius; //Field offset: 0x5C
		public Vector2 bottomRightRadius; //Field offset: 0x64
		public Vector2 bottomLeftRadius; //Field offset: 0x6C
		public Rect backgroundRepeatRect; //Field offset: 0x74
		public Vector2 contentSize; //Field offset: 0x84
		public Vector2 textureSize; //Field offset: 0x8C
		public float texturePixelsPerPoint; //Field offset: 0x94
		public int leftSlice; //Field offset: 0x98
		public int topSlice; //Field offset: 0x9C
		public int rightSlice; //Field offset: 0xA0
		public int bottomSlice; //Field offset: 0xA4
		public float sliceScale; //Field offset: 0xA8
		public Vector4 rectInset; //Field offset: 0xAC
		public NativeColorPage colorPage; //Field offset: 0xBC

	}


	public static MeshWriteDataInterface MakeBorder(NativeBorderParams borderParams, float posZ) { }

	private static void MakeBorder_Injected(ref NativeBorderParams borderParams, float posZ, out MeshWriteDataInterface ret) { }

	public static MeshWriteDataInterface MakeSolidRect(NativeRectParams rectParams, float posZ) { }

	private static void MakeSolidRect_Injected(ref NativeRectParams rectParams, float posZ, out MeshWriteDataInterface ret) { }

	public static MeshWriteDataInterface MakeTexturedRect(NativeRectParams rectParams, float posZ) { }

	private static void MakeTexturedRect_Injected(ref NativeRectParams rectParams, float posZ, out MeshWriteDataInterface ret) { }

	public static MeshWriteDataInterface MakeVectorGraphics9SliceBackground(Vertex[] svgVertices, UInt16[] svgIndices, float svgWidth, float svgHeight, Rect targetRect, Vector4 sliceLTRB, Color tint, NativeColorPage colorPage, int settingIndexOffset) { }

	private static void MakeVectorGraphics9SliceBackground_Injected(Vertex[] svgVertices, UInt16[] svgIndices, float svgWidth, float svgHeight, ref Rect targetRect, ref Vector4 sliceLTRB, ref Color tint, ref NativeColorPage colorPage, int settingIndexOffset, out MeshWriteDataInterface ret) { }

	public static MeshWriteDataInterface MakeVectorGraphicsStretchBackground(Vertex[] svgVertices, UInt16[] svgIndices, float svgWidth, float svgHeight, Rect targetRect, Rect sourceUV, ScaleMode scaleMode, Color tint, NativeColorPage colorPage, int settingIndexOffset, ref int finalVertexCount, ref int finalIndexCount) { }

	private static void MakeVectorGraphicsStretchBackground_Injected(Vertex[] svgVertices, UInt16[] svgIndices, float svgWidth, float svgHeight, ref Rect targetRect, ref Rect sourceUV, ScaleMode scaleMode, ref Color tint, ref NativeColorPage colorPage, int settingIndexOffset, ref int finalVertexCount, ref int finalIndexCount, out MeshWriteDataInterface ret) { }

}

