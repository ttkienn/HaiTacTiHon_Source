namespace UnityEngine;

[MovedFrom("UnityEngine.Experimental.TerrainAPI")]
public static class TerrainCallbacks
{
	internal sealed class HeightmapChangedCallback : MulticastDelegate
	{

		public HeightmapChangedCallback(object object, IntPtr method) { }

		public override void Invoke(Terrain terrain, RectInt heightRegion, bool synched) { }

	}

	internal sealed class TextureChangedCallback : MulticastDelegate
	{

		public TextureChangedCallback(object object, IntPtr method) { }

		public override void Invoke(Terrain terrain, string textureName, RectInt texelRegion, bool synched) { }

	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static HeightmapChangedCallback heightmapChanged; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static TextureChangedCallback textureChanged; //Field offset: 0x8

	[RequiredByNativeCode]
	internal static void InvokeHeightmapChangedCallback(TerrainData terrainData, RectInt heightRegion, bool synched) { }

	[RequiredByNativeCode]
	internal static void InvokeTextureChangedCallback(TerrainData terrainData, string textureName, RectInt texelRegion, bool synched) { }

}

