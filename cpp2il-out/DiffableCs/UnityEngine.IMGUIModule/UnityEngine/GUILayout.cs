namespace UnityEngine;

public class GUILayout
{

	public static Vector2 BeginScrollView(Vector2 scrollPosition, bool alwaysShowHorizontal, bool alwaysShowVertical, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar, GUIStyle background, GUILayoutOption[] options) { }

	public static bool Button(string text, GUILayoutOption[] options) { }

	private static bool DoButton(GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	private static void DoLabel(GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	public static void EndScrollView() { }

	internal static void EndScrollView(bool handleScrollWheel) { }

	public static GUILayoutOption Height(float height) { }

	public static void Label(string text, GUILayoutOption[] options) { }

	public static GUILayoutOption Width(float width) { }

}

