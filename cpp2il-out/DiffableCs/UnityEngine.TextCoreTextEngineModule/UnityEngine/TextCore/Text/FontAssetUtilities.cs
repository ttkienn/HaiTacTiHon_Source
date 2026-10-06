namespace UnityEngine.TextCore.Text;

internal static class FontAssetUtilities
{
	private static HashSet<Int32> k_SearchedAssets; //Field offset: 0x0

	internal static Character GetCharacterFromFontAsset(uint unicode, FontAsset sourceFontAsset, bool includeFallbacks, FontStyles fontStyle, TextFontWeight fontWeight, out bool isAlternativeTypeface) { }

	private static Character GetCharacterFromFontAsset_Internal(uint unicode, FontAsset sourceFontAsset, bool includeFallbacks, FontStyles fontStyle, TextFontWeight fontWeight, out bool isAlternativeTypeface) { }

	public static Character GetCharacterFromFontAssets(uint unicode, FontAsset sourceFontAsset, List<FontAsset> fontAssets, bool includeFallbacks, FontStyles fontStyle, TextFontWeight fontWeight, out bool isAlternativeTypeface) { }

	public static SpriteCharacter GetSpriteCharacterFromSpriteAsset(uint unicode, SpriteAsset spriteAsset, bool includeFallbacks) { }

	private static SpriteCharacter GetSpriteCharacterFromSpriteAsset_Internal(uint unicode, SpriteAsset spriteAsset, bool includeFallbacks) { }

}

