namespace UnityEngine.UIElements.StyleSheets;

internal static class StyleSheetCache
{
	private struct SheetHandleKey
	{
		public readonly int sheetInstanceID; //Field offset: 0x0
		public readonly int index; //Field offset: 0x4

		public SheetHandleKey(StyleSheet sheet, int index) { }

	}

	private class SheetHandleKeyComparer : IEqualityComparer<SheetHandleKey>
	{

		public SheetHandleKeyComparer() { }

		public override bool Equals(SheetHandleKey x, SheetHandleKey y) { }

		public override int GetHashCode(SheetHandleKey key) { }

	}

	private static SheetHandleKeyComparer s_Comparer; //Field offset: 0x0
	private static Dictionary<SheetHandleKey, StylePropertyId[]> s_RulePropertyIdsCache; //Field offset: 0x8

	private static StyleSheetCache() { }

	private static StylePropertyId GetPropertyId(StyleRule rule, int index) { }

	internal static StylePropertyId[] GetPropertyIds(StyleSheet sheet, int ruleIndex) { }

	internal static StylePropertyId[] GetPropertyIds(StyleRule rule) { }

}

