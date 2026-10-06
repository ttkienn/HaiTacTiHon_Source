namespace UnityEngine.UIElements.StyleSheets;

internal static class ShorthandApplicator
{
	private static List<TimeValue> s_TransitionDelayList; //Field offset: 0x0
	private static List<TimeValue> s_TransitionDurationList; //Field offset: 0x8
	private static List<StylePropertyName> s_TransitionPropertyList; //Field offset: 0x10
	private static List<EasingFunction> s_TransitionTimingFunctionList; //Field offset: 0x18

	private static ShorthandApplicator() { }

	[CompilerGenerated]
	internal static void <CompileBackgroundPosition>g__SwapKeyword|16_0(ref BackgroundPositionKeyword a, ref BackgroundPositionKeyword b) { }

	public static void ApplyBackgroundPosition(StylePropertyReader reader, ref ComputedStyle computedStyle) { }

	public static void ApplyBorderColor(StylePropertyReader reader, ref ComputedStyle computedStyle) { }

	public static void ApplyBorderRadius(StylePropertyReader reader, ref ComputedStyle computedStyle) { }

	public static void ApplyBorderWidth(StylePropertyReader reader, ref ComputedStyle computedStyle) { }

	public static void ApplyFlex(StylePropertyReader reader, ref ComputedStyle computedStyle) { }

	public static void ApplyMargin(StylePropertyReader reader, ref ComputedStyle computedStyle) { }

	public static void ApplyPadding(StylePropertyReader reader, ref ComputedStyle computedStyle) { }

	public static void ApplyTransition(StylePropertyReader reader, ref ComputedStyle computedStyle) { }

	public static void ApplyUnityBackgroundScaleMode(StylePropertyReader reader, ref ComputedStyle computedStyle) { }

	public static void ApplyUnityTextOutline(StylePropertyReader reader, ref ComputedStyle computedStyle) { }

	private static void CompileBackgroundPosition(StylePropertyReader reader, out BackgroundPosition backgroundPositionX, out BackgroundPosition backgroundPositionY) { }

	private static void CompileBorderRadius(StylePropertyReader reader, out Length top, out Length right, out Length bottom, out Length left) { }

	private static void CompileBoxArea(StylePropertyReader reader, out Length top, out Length right, out Length bottom, out Length left) { }

	private static void CompileBoxArea(StylePropertyReader reader, out float top, out float right, out float bottom, out float left) { }

	private static void CompileBoxArea(StylePropertyReader reader, out Color top, out Color right, out Color bottom, out Color left) { }

	private static bool CompileFlexShorthand(StylePropertyReader reader, out float grow, out float shrink, out Length basis) { }

	private static void CompileTextOutline(StylePropertyReader reader, out Color outlineColor, out float outlineWidth) { }

	private static void CompileTransition(StylePropertyReader reader, out List<TimeValue>& outDelay, out List<TimeValue>& outDuration, out List<StylePropertyName>& outProperty, out List<EasingFunction>& outTimingFunction) { }

	public static void CompileUnityBackgroundScaleMode(StylePropertyReader reader, out BackgroundPosition backgroundPositionX, out BackgroundPosition backgroundPositionY, out BackgroundRepeat backgroundRepeat, out BackgroundSize backgroundSize) { }

}

