namespace UnityEngine.UIElements;

public class PanelTextSettings : TextSettings
{
	private static PanelTextSettings s_DefaultPanelTextSettings; //Field offset: 0x0
	internal static Func<String, Object> EditorGUIUtilityLoad; //Field offset: 0x8
	internal static Func<SystemLanguage> GetCurrentLanguage; //Field offset: 0x10
	internal static readonly string s_DefaultEditorPanelTextSettingPath; //Field offset: 0x18

	internal static PanelTextSettings defaultPanelTextSettings
	{
		internal get { } //Length: 342
	}

	private static PanelTextSettings() { }

	public PanelTextSettings() { }

	internal static PanelTextSettings get_defaultPanelTextSettings() { }

	internal FontAsset GetCachedFontAsset(Font font) { }

	internal static void UpdateLocalizationFontAsset() { }

}

