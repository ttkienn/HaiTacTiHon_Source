namespace UnityEngine.Tilemaps;

[NativeHeader("Modules/Tilemap/Public/TilemapMarshalling.h")]
[NativeHeader("Modules/Grid/Public/GridMarshalling.h")]
[NativeHeader("Modules/Tilemap/TilemapRendererJobs.h")]
[NativeType(Header = "Modules/Tilemap/Public/TilemapRenderer.h")]
[RequireComponent(typeof(Tilemap))]
public sealed class TilemapRenderer : Renderer
{

	internal void OnSpriteAtlasRegistered(SpriteAtlas atlas) { }

	[RequiredByNativeCode]
	internal void RegisterSpriteAtlasRegistered() { }

	[RequiredByNativeCode]
	internal void UnregisterSpriteAtlasRegistered() { }

}

