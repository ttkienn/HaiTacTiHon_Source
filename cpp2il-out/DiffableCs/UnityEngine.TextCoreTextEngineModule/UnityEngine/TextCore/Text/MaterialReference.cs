namespace UnityEngine.TextCore.Text;

internal struct MaterialReference
{
	public int index; //Field offset: 0x0
	public FontAsset fontAsset; //Field offset: 0x8
	public SpriteAsset spriteAsset; //Field offset: 0x10
	public Material material; //Field offset: 0x18
	public bool isDefaultMaterial; //Field offset: 0x20
	public bool isFallbackMaterial; //Field offset: 0x21
	public Material fallbackMaterial; //Field offset: 0x28
	public float padding; //Field offset: 0x30
	public int referenceCount; //Field offset: 0x34

	public MaterialReference(int index, FontAsset fontAsset, SpriteAsset spriteAsset, Material material, float padding) { }

	public static int AddMaterialReference(Material material, FontAsset fontAsset, ref MaterialReference[] materialReferences, Dictionary<Int32, Int32> materialReferenceIndexLookup) { }

	public static int AddMaterialReference(Material material, SpriteAsset spriteAsset, ref MaterialReference[] materialReferences, Dictionary<Int32, Int32> materialReferenceIndexLookup) { }

}

