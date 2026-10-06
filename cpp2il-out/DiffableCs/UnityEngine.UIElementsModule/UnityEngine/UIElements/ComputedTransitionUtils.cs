namespace UnityEngine.UIElements;

[Extension]
internal static class ComputedTransitionUtils
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Single, Single> <>9__12_0; //Field offset: 0x8
		public static Func<Single, Single> <>9__12_1; //Field offset: 0x10
		public static Func<Single, Single> <>9__12_2; //Field offset: 0x18
		public static Func<Single, Single> <>9__12_3; //Field offset: 0x20
		public static Func<Single, Single> <>9__12_4; //Field offset: 0x28
		public static Func<Single, Single> <>9__12_5; //Field offset: 0x30
		public static Func<Single, Single> <>9__12_6; //Field offset: 0x38
		public static Func<Single, Single> <>9__12_7; //Field offset: 0x40
		public static Func<Single, Single> <>9__12_8; //Field offset: 0x48
		public static Func<Single, Single> <>9__12_9; //Field offset: 0x50
		public static Func<Single, Single> <>9__12_10; //Field offset: 0x58
		public static Func<Single, Single> <>9__12_11; //Field offset: 0x60
		public static Func<Single, Single> <>9__12_12; //Field offset: 0x68
		public static Func<Single, Single> <>9__12_13; //Field offset: 0x70
		public static Func<Single, Single> <>9__12_14; //Field offset: 0x78
		public static Func<Single, Single> <>9__12_15; //Field offset: 0x80
		public static Func<Single, Single> <>9__12_16; //Field offset: 0x88
		public static Func<Single, Single> <>9__12_17; //Field offset: 0x90
		public static Func<Single, Single> <>9__12_18; //Field offset: 0x98
		public static Func<Single, Single> <>9__12_19; //Field offset: 0xA0
		public static Func<Single, Single> <>9__12_20; //Field offset: 0xA8
		public static Func<Single, Single> <>9__12_21; //Field offset: 0xB0
		public static Func<Single, Single> <>9__12_22; //Field offset: 0xB8

		private static <>c() { }

		public <>c() { }

		internal float <ConvertTransitionFunction>b__12_0(float t) { }

		internal float <ConvertTransitionFunction>b__12_1(float t) { }

		internal float <ConvertTransitionFunction>b__12_10(float t) { }

		internal float <ConvertTransitionFunction>b__12_11(float t) { }

		internal float <ConvertTransitionFunction>b__12_12(float t) { }

		internal float <ConvertTransitionFunction>b__12_13(float t) { }

		internal float <ConvertTransitionFunction>b__12_14(float t) { }

		internal float <ConvertTransitionFunction>b__12_15(float t) { }

		internal float <ConvertTransitionFunction>b__12_16(float t) { }

		internal float <ConvertTransitionFunction>b__12_17(float t) { }

		internal float <ConvertTransitionFunction>b__12_18(float t) { }

		internal float <ConvertTransitionFunction>b__12_19(float t) { }

		internal float <ConvertTransitionFunction>b__12_2(float t) { }

		internal float <ConvertTransitionFunction>b__12_20(float t) { }

		internal float <ConvertTransitionFunction>b__12_21(float t) { }

		internal float <ConvertTransitionFunction>b__12_22(float t) { }

		internal float <ConvertTransitionFunction>b__12_3(float t) { }

		internal float <ConvertTransitionFunction>b__12_4(float t) { }

		internal float <ConvertTransitionFunction>b__12_5(float t) { }

		internal float <ConvertTransitionFunction>b__12_6(float t) { }

		internal float <ConvertTransitionFunction>b__12_7(float t) { }

		internal float <ConvertTransitionFunction>b__12_8(float t) { }

		internal float <ConvertTransitionFunction>b__12_9(float t) { }

	}

	private static List<ComputedTransitionProperty> s_ComputedTransitionsBuffer; //Field offset: 0x0

	private static ComputedTransitionUtils() { }

	private static void ComputeTransitionPropertyData(ref ComputedStyle computedStyle, List<ComputedTransitionProperty> outData) { }

	private static Func<Single, Single> ConvertTransitionFunction(EasingMode mode) { }

	private static int ConvertTransitionTime(TimeValue time) { }

	private static ComputedTransitionProperty[] GetOrComputeTransitionPropertyData(ref ComputedStyle computedStyle) { }

	private static int GetTransitionHashCode(ref ComputedStyle cs) { }

	[Extension]
	internal static bool GetTransitionProperty(ref ComputedStyle computedStyle, StylePropertyId id, out ComputedTransitionProperty result) { }

	private static T GetWrappingTransitionData(List<T> list, int i, T defaultValue) { }

	[Extension]
	internal static bool HasTransitionProperty(ref ComputedStyle computedStyle, StylePropertyId id) { }

	internal static bool SameTransitionProperty(ref ComputedStyle x, ref ComputedStyle y) { }

	private static bool SameTransitionProperty(List<StylePropertyName> a, List<StylePropertyName> b) { }

	private static bool SameTransitionProperty(List<TimeValue> a, List<TimeValue> b) { }

	internal static void UpdateComputedTransitions(ref ComputedStyle computedStyle) { }

}

