namespace UnityEngine.TextCore.Text;

internal static class MaterialManager
{
	private static Dictionary<Int64, Material> s_FallbackMaterials; //Field offset: 0x0

	private static MaterialManager() { }

	private static void CopyMaterialPresetProperties(Material source, Material destination) { }

	public static Material GetFallbackMaterial(Material sourceMaterial, Material targetMaterial) { }

	public static Material GetFallbackMaterial(FontAsset fontAsset, Material sourceMaterial, int atlasIndex) { }

}

