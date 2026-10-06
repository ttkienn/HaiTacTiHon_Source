namespace UnityEngine;

[NativeHeader("Modules/IMGUI/GUISkin.bindings.h")]
[NativeHeader("Modules/IMGUI/GUI.bindings.h")]
public class GUI
{
	internal sealed class WindowFunction : MulticastDelegate
	{

		public WindowFunction(object object, IntPtr method) { }

		public override void Invoke(int id) { }

	}

	private static int s_ScrollControlId; //Field offset: 0x0
	private static int s_HotTextField; //Field offset: 0x4
	private static readonly int s_BoxHash; //Field offset: 0x8
	private static readonly int s_ButonHash; //Field offset: 0xC
	private static readonly int s_RepeatButtonHash; //Field offset: 0x10
	private static readonly int s_ToggleHash; //Field offset: 0x14
	private static readonly int s_ButtonGridHash; //Field offset: 0x18
	private static readonly int s_SliderHash; //Field offset: 0x1C
	private static readonly int s_BeginGroupHash; //Field offset: 0x20
	private static readonly int s_ScrollviewHash; //Field offset: 0x24
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static int <scrollTroughSide>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static DateTime <nextScrollStepTime>k__BackingField; //Field offset: 0x30
	private static GUISkin s_Skin; //Field offset: 0x38
	internal static Rect s_ToolTipRect; //Field offset: 0x40
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static GenericStack <scrollViewStates>k__BackingField; //Field offset: 0x50

	public static Color backgroundColor
	{
		 get { } //Length: 109
		 set { } //Length: 100
	}

	internal static Material blendMaterial
	{
		[FreeFunction("GetGUIBlendMaterial")]
		internal get { } //Length: 42
	}

	internal static Material blitMaterial
	{
		[FreeFunction("GetGUIBlitMaterial")]
		internal get { } //Length: 42
	}

	public static bool changed
	{
		 get { } //Length: 42
		 set { } //Length: 51
	}

	public static Color color
	{
		 get { } //Length: 109
		 set { } //Length: 100
	}

	public static Color contentColor
	{
		 get { } //Length: 109
		 set { } //Length: 100
	}

	public static bool enabled
	{
		 get { } //Length: 42
		 set { } //Length: 51
	}

	public static Matrix4x4 matrix
	{
		 get { } //Length: 129
		 set { } //Length: 82
	}

	internal static DateTime nextScrollStepTime
	{
		[CompilerGenerated]
		internal get { } //Length: 79
		[CompilerGenerated]
		internal set { } //Length: 85
	}

	internal static Material roundedRectMaterial
	{
		[FreeFunction("GetGUIRoundedRectMaterial")]
		internal get { } //Length: 42
	}

	internal static Material roundedRectWithColorPerBorderMaterial
	{
		[FreeFunction("GetGUIRoundedRectWithColorPerBorderMaterial")]
		internal get { } //Length: 42
	}

	internal static int scrollTroughSide
	{
		[CompilerGenerated]
		internal get { } //Length: 78
		[CompilerGenerated]
		internal set { } //Length: 83
	}

	internal static GenericStack scrollViewStates
	{
		[CompilerGenerated]
		internal get { } //Length: 79
	}

	public static GUISkin skin
	{
		 get { } //Length: 119
		 set { } //Length: 113
	}

	internal static bool usePageScrollbars
	{
		internal get { } //Length: 42
	}

	private static GUI() { }

	public static void BeginGroup(Rect position) { }

	internal static void BeginGroup(Rect position, GUIContent content, GUIStyle style, Vector2 scrollOffset) { }

	public static void BeginGroup(Rect position, GUIContent content, GUIStyle style) { }

	internal static Vector2 BeginScrollView(Rect position, Vector2 scrollPosition, Rect viewRect, bool alwaysShowHorizontal, bool alwaysShowVertical, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar, GUIStyle background) { }

	public static void Box(Rect position, string text) { }

	public static void Box(Rect position, GUIContent content, GUIStyle style) { }

	public static bool Button(Rect position, GUIContent content, GUIStyle style) { }

	internal static bool Button(Rect position, int id, GUIContent content, GUIStyle style) { }

	internal static bool CalculateScaledTextureRects(Rect position, ScaleMode scaleMode, float imageAspect, ref Rect outScreenRect, ref Rect outSourceRect) { }

	[RequiredByNativeCode]
	internal static void CallWindowDelegate(WindowFunction func, int id, int instanceID, GUISkin _skin, int forceRect, float width, float height, GUIStyle style) { }

	internal static bool DoButton(Rect position, int id, GUIContent content, GUIStyle style) { }

	internal static bool DoControl(Rect position, int id, bool on, bool hover, GUIContent content, GUIStyle style) { }

	private static void DoLabel(Rect position, GUIContent content, GUIStyle style) { }

	private static bool DoRepeatButton(Rect position, GUIContent content, GUIStyle style, FocusType focusType) { }

	internal static void DoSetSkin(GUISkin newSkin) { }

	private static Rect DoWindow(int id, Rect clientRect, WindowFunction func, GUIContent title, GUIStyle style, GUISkin skin, bool forceRectOnLayout) { }

	public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect, Color color, Vector4 borderWidths, Vector4 borderRadiuses) { }

	public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect, Color color, Vector4 borderWidths, float borderRadius) { }

	public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect, Color color, float borderWidth, float borderRadius) { }

	public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend) { }

	internal static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect, Color leftColor, Color topColor, Color rightColor, Color bottomColor, Vector4 borderWidths, Vector4 borderRadiuses, bool drawSmoothCorners) { }

	internal static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect, Color color, Vector4 borderWidths, Vector4 borderRadiuses, bool drawSmoothCorners) { }

	public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect) { }

	public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode) { }

	public static void DrawTexture(Rect position, Texture image) { }

	public static void EndGroup() { }

	public static void EndScrollView(bool handleScrollWheel) { }

	public static Color get_backgroundColor() { }

	private static void get_backgroundColor_Injected(out Color ret) { }

	[FreeFunction("GetGUIBlendMaterial")]
	internal static Material get_blendMaterial() { }

	[FreeFunction("GetGUIBlitMaterial")]
	internal static Material get_blitMaterial() { }

	public static bool get_changed() { }

	public static Color get_color() { }

	private static void get_color_Injected(out Color ret) { }

	public static Color get_contentColor() { }

	private static void get_contentColor_Injected(out Color ret) { }

	public static bool get_enabled() { }

	public static Matrix4x4 get_matrix() { }

	[CompilerGenerated]
	internal static DateTime get_nextScrollStepTime() { }

	[FreeFunction("GetGUIRoundedRectMaterial")]
	internal static Material get_roundedRectMaterial() { }

	[FreeFunction("GetGUIRoundedRectWithColorPerBorderMaterial")]
	internal static Material get_roundedRectWithColorPerBorderMaterial() { }

	[CompilerGenerated]
	internal static int get_scrollTroughSide() { }

	[CompilerGenerated]
	internal static GenericStack get_scrollViewStates() { }

	public static GUISkin get_skin() { }

	internal static bool get_usePageScrollbars() { }

	internal static void GrabMouseControl(int id) { }

	internal static bool HasMouseControl(int id) { }

	public static float HorizontalScrollbar(Rect position, float value, float size, float leftValue, float rightValue, GUIStyle style) { }

	private static Rect Internal_DoWindow(int id, int instanceID, Rect clientRect, WindowFunction func, GUIContent title, GUIStyle style, object skin, bool forceRectOnLayout) { }

	private static void Internal_DoWindow_Injected(int id, int instanceID, ref Rect clientRect, WindowFunction func, GUIContent title, GUIStyle style, object skin, bool forceRectOnLayout, out Rect ret) { }

	internal static void InternalRepaintEditorWindow() { }

	public static void Label(Rect position, GUIContent content, GUIStyle style) { }

	public static void Label(Rect position, string text, GUIStyle style) { }

	public static void Label(Rect position, string text) { }

	internal static void ReleaseMouseControl() { }

	internal static float Scroller(Rect position, float value, float size, float leftValue, float rightValue, GUIStyle slider, GUIStyle thumb, GUIStyle leftButton, GUIStyle rightButton, bool horiz) { }

	internal static bool ScrollerRepeatButton(int scrollerID, Rect rect, GUIStyle style) { }

	public static void set_backgroundColor(Color value) { }

	private static void set_backgroundColor_Injected(ref Color value) { }

	public static void set_changed(bool value) { }

	public static void set_color(Color value) { }

	private static void set_color_Injected(ref Color value) { }

	public static void set_contentColor(Color value) { }

	private static void set_contentColor_Injected(ref Color value) { }

	public static void set_enabled(bool value) { }

	public static void set_matrix(Matrix4x4 value) { }

	[CompilerGenerated]
	internal static void set_nextScrollStepTime(DateTime value) { }

	[CompilerGenerated]
	internal static void set_scrollTroughSide(int value) { }

	public static void set_skin(GUISkin value) { }

	public static float Slider(Rect position, float value, float size, float start, float end, GUIStyle slider, GUIStyle thumb, bool horiz, int id, GUIStyle thumbExtent = null) { }

	public static float VerticalScrollbar(Rect position, float value, float size, float topValue, float bottomValue, GUIStyle style) { }

	public static Rect Window(int id, Rect clientRect, WindowFunction func, string text) { }

}

