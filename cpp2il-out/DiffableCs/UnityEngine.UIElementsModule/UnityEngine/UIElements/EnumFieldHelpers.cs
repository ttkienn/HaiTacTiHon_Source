namespace UnityEngine.UIElements;

internal static class EnumFieldHelpers
{
	internal static readonly UxmlTypeAttributeDescription<Enum> type; //Field offset: 0x0
	internal static readonly UxmlStringAttributeDescription value; //Field offset: 0x8
	internal static readonly UxmlBoolAttributeDescription includeObsoleteValues; //Field offset: 0x10

	private static EnumFieldHelpers() { }

	internal static bool ExtractValue(IUxmlAttributes bag, CreationContext cc, out Type resEnumType, out Enum resEnumValue, out bool resIncludeObsoleteValues) { }

}

