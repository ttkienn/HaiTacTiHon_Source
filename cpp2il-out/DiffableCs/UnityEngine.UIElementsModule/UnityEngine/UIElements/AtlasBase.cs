namespace UnityEngine.UIElements;

internal abstract class AtlasBase
{
	internal TextureRegistry textureRegistry; //Field offset: 0x10

	protected AtlasBase() { }

	internal void InvokeAssignedToPanel(IPanel panel) { }

	internal void InvokeRemovedFromPanel(IPanel panel) { }

	internal void InvokeUpdateDynamicTextures(IPanel panel) { }

	protected override void OnAssignedToPanel(IPanel panel) { }

	protected override void OnRemovedFromPanel(IPanel panel) { }

	protected override void OnUpdateDynamicTextures(IPanel panel) { }

	protected static void RepaintTexturedElements(IPanel panel) { }

	public override void Reset() { }

	public override void ReturnAtlas(VisualElement ctx, Texture2D src, TextureId atlas) { }

	protected void SetDynamicTexture(TextureId id, Texture texture) { }

	public override bool TryGetAtlas(VisualElement ctx, Texture2D src, out TextureId atlas, out RectInt atlasRect) { }

}

