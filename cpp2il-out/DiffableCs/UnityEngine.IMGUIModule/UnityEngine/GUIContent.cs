namespace UnityEngine;

[NativeHeader("Modules/IMGUI/GUIContent.h")]
[RequiredByNativeCode(Optional = True, GenerateProxy = True)]
public class GUIContent
{
	private static readonly GUIContent s_Text; //Field offset: 0x0
	private static readonly GUIContent s_Image; //Field offset: 0x8
	private static readonly GUIContent s_TextImage; //Field offset: 0x10
	public static GUIContent none; //Field offset: 0x18
	[SerializeField]
	private string m_Text; //Field offset: 0x10
	[SerializeField]
	private Texture m_Image; //Field offset: 0x18
	[SerializeField]
	private string m_Tooltip; //Field offset: 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action OnTextChanged; //Field offset: 0x28

	public Texture image
	{
		 set { } //Length: 13
	}

	public string text
	{
		 get { } //Length: 7
		 set { } //Length: 85
	}

	public string tooltip
	{
		 get { } //Length: 7
		 set { } //Length: 13
	}

	private static GUIContent() { }

	public GUIContent() { }

	public GUIContent(string text) { }

	public GUIContent(string text, Texture image, string tooltip) { }

	public GUIContent(GUIContent src) { }

	internal static void ClearStaticCache() { }

	public string get_text() { }

	public string get_tooltip() { }

	public void set_image(Texture value) { }

	public void set_text(string value) { }

	public void set_tooltip(string value) { }

	internal static GUIContent Temp(string t) { }

	public virtual string ToString() { }

}

