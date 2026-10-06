namespace UnityEngine.UI;

public static class FontUpdateTracker
{
	private static Dictionary<Font, HashSet`1<Text>> m_Tracked; //Field offset: 0x0

	private static FontUpdateTracker() { }

	private static void RebuildForFont(Font f) { }

	public static void TrackText(Text t) { }

	public static void UntrackText(Text t) { }

}

