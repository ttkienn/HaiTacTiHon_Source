namespace UnityEngine;

[NativeHeader("IMGUIScriptingClasses.h")]
[NativeHeader("Modules/IMGUI/GUIStyle.bindings.h")]
[RequiredByNativeCode]
public sealed class GUIStyle
{
	internal static bool showKeyboardFocus; //Field offset: 0x0
	private static GUIStyle s_None; //Field offset: 0x8
	internal IntPtr m_Ptr; //Field offset: 0x10
	private GUIStyleState m_Normal; //Field offset: 0x18
	private GUIStyleState m_Hover; //Field offset: 0x20
	private GUIStyleState m_Active; //Field offset: 0x28
	private GUIStyleState m_Focused; //Field offset: 0x30
	private GUIStyleState m_OnNormal; //Field offset: 0x38
	private GUIStyleState m_OnHover; //Field offset: 0x40
	private GUIStyleState m_OnActive; //Field offset: 0x48
	private GUIStyleState m_OnFocused; //Field offset: 0x50
	private RectOffset m_Border; //Field offset: 0x58
	private RectOffset m_Padding; //Field offset: 0x60
	private RectOffset m_Margin; //Field offset: 0x68
	private RectOffset m_Overflow; //Field offset: 0x70
	private string m_Name; //Field offset: 0x78

	[NativeProperty("m_Alignment", False, TargetType::Field (1))]
	public TextAnchor alignment
	{
		 set { } //Length: 64
	}

	[NativeProperty("m_FixedHeight", False, TargetType::Field (1))]
	public float fixedHeight
	{
		 get { } //Length: 51
	}

	[NativeProperty("m_FixedWidth", False, TargetType::Field (1))]
	public float fixedWidth
	{
		 get { } //Length: 51
	}

	[NativeProperty("Font", False, TargetType::Function (0))]
	public Font font
	{
		 set { } //Length: 66
	}

	[NativeProperty("m_FontSize", False, TargetType::Field (1))]
	public int fontSize
	{
		 set { } //Length: 64
	}

	[NativeProperty("m_ImagePosition", False, TargetType::Field (1))]
	public ImagePosition imagePosition
	{
		 get { } //Length: 51
	}

	public bool isHeightDependantOnWidth
	{
		 get { } //Length: 157
	}

	public RectOffset margin
	{
		 get { } //Length: 167
	}

	public string name
	{
		 get { } //Length: 92
		 set { } //Length: 79
	}

	public static GUIStyle none
	{
		 get { } //Length: 177
	}

	public GUIStyleState normal
	{
		 get { } //Length: 181
	}

	public RectOffset padding
	{
		 get { } //Length: 167
	}

	[NativeProperty("Name", False, TargetType::Function (0))]
	internal string rawName
	{
		internal get { } //Length: 51
		internal set { } //Length: 66
	}

	[NativeProperty("m_StretchHeight", False, TargetType::Field (1))]
	public bool stretchHeight
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	[NativeProperty("m_StretchWidth", False, TargetType::Field (1))]
	public bool stretchWidth
	{
		 get { } //Length: 51
	}

	[NativeProperty("m_WordWrap", False, TargetType::Field (1))]
	public bool wordWrap
	{
		 get { } //Length: 51
	}

	private static GUIStyle() { }

	public GUIStyle() { }

	public GUIStyle(GUIStyle other) { }

	public float CalcHeight(GUIContent content, float width) { }

	public void CalcMinMaxWidth(GUIContent content, out float minWidth, out float maxWidth) { }

	public Vector2 CalcSize(GUIContent content) { }

	internal Vector2 CalcSizeWithConstraints(GUIContent content, Vector2 constraints) { }

	public void Draw(Rect position, GUIContent content, int controlID, bool on, bool hover) { }

	public void Draw(Rect position, bool isHover, bool isActive, bool on, bool hasKeyboardFocus) { }

	private void Draw(Rect position, GUIContent content, int controlId, bool isHover, bool isActive, bool on, bool hasKeyboardFocus) { }

	public void Draw(Rect position, GUIContent content, int controlID) { }

	public void Draw(Rect position, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus) { }

	protected virtual void Finalize() { }

	public float get_fixedHeight() { }

	public float get_fixedWidth() { }

	public ImagePosition get_imagePosition() { }

	public bool get_isHeightDependantOnWidth() { }

	public RectOffset get_margin() { }

	public string get_name() { }

	public static GUIStyle get_none() { }

	public GUIStyleState get_normal() { }

	public RectOffset get_padding() { }

	internal string get_rawName() { }

	public bool get_stretchHeight() { }

	public bool get_stretchWidth() { }

	public bool get_wordWrap() { }

	[FreeFunction(Name = "GUIStyle_Bindings::GetRectOffsetPtr", HasExplicitThis = True)]
	private IntPtr GetRectOffsetPtr(int idx) { }

	[FreeFunction(Name = "GUIStyle_Bindings::GetStyleStatePtr", IsThreadSafe = True, HasExplicitThis = True)]
	private IntPtr GetStyleStatePtr(int idx) { }

	[FreeFunction(Name = "GUIStyle_Bindings::Internal_CalcHeight", HasExplicitThis = True)]
	private float Internal_CalcHeight(GUIContent content, float width) { }

	[FreeFunction(Name = "GUIStyle_Bindings::Internal_CalcMinMaxWidth", HasExplicitThis = True)]
	private Vector2 Internal_CalcMinMaxWidth(GUIContent content) { }

	private void Internal_CalcMinMaxWidth_Injected(GUIContent content, out Vector2 ret) { }

	[FreeFunction(Name = "GUIStyle_Bindings::Internal_CalcSize", HasExplicitThis = True)]
	internal Vector2 Internal_CalcSize(GUIContent content) { }

	private void Internal_CalcSize_Injected(GUIContent content, out Vector2 ret) { }

	[FreeFunction(Name = "GUIStyle_Bindings::Internal_CalcSizeWithConstraints", HasExplicitThis = True)]
	internal Vector2 Internal_CalcSizeWithConstraints(GUIContent content, Vector2 maxSize) { }

	private void Internal_CalcSizeWithConstraints_Injected(GUIContent content, ref Vector2 maxSize, out Vector2 ret) { }

	[FreeFunction(Name = "GUIStyle_Bindings::Internal_Copy", IsThreadSafe = True)]
	private static IntPtr Internal_Copy(GUIStyle self, GUIStyle other) { }

	[FreeFunction(Name = "GUIStyle_Bindings::Internal_Create", IsThreadSafe = True)]
	private static IntPtr Internal_Create(GUIStyle self) { }

	[FreeFunction(Name = "GUIStyle_Bindings::Internal_Destroy", IsThreadSafe = True)]
	private static void Internal_Destroy(IntPtr self) { }

	[FreeFunction(Name = "GUIStyle_Bindings::Internal_Draw", HasExplicitThis = True)]
	private void Internal_Draw(Rect screenRect, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus) { }

	private void Internal_Draw_Injected(ref Rect screenRect, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus) { }

	[FreeFunction(Name = "GUIStyle_Bindings::Internal_Draw2", HasExplicitThis = True)]
	private void Internal_Draw2(Rect position, GUIContent content, int controlID, bool on) { }

	private void Internal_Draw2_Injected(ref Rect position, GUIContent content, int controlID, bool on) { }

	[FreeFunction(Name = "GUIStyle_Bindings::IsTooltipActive")]
	internal static bool IsTooltipActive(string tooltip) { }

	public void set_alignment(TextAnchor value) { }

	public void set_font(Font value) { }

	public void set_fontSize(int value) { }

	public void set_name(string value) { }

	internal void set_rawName(string value) { }

	public void set_stretchHeight(bool value) { }

	[FreeFunction(Name = "GUIStyle::SetDefaultFont")]
	internal static void SetDefaultFont(Font font) { }

	[FreeFunction(Name = "GUIStyle_Bindings::SetMouseTooltip")]
	internal static void SetMouseTooltip(string tooltip, Rect screenRect) { }

	private static void SetMouseTooltip_Injected(string tooltip, ref Rect screenRect) { }

	public virtual string ToString() { }

}

