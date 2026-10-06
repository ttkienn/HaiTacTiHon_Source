namespace UnityEngine.UIElements.StyleSheets;

internal static class StyleSelectorHelper
{

	private static void FastLookup(IDictionary<String, StyleComplexSelector> table, List<SelectorMatchRecord> matchedSelectors, StyleMatchingContext context, string input, ref SelectorMatchRecord record) { }

	public static void FindMatches(StyleMatchingContext context, List<SelectorMatchRecord> matchedSelectors, int parentSheetIndex) { }

	public static MatchResultInfo MatchesSelector(VisualElement element, StyleSelector selector) { }

	public static bool MatchRightToLeft(VisualElement element, StyleComplexSelector complexSelector, Action<VisualElement, MatchResultInfo> processResult) { }

}

