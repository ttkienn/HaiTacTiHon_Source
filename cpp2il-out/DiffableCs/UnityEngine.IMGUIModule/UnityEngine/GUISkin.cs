namespace UnityEngine;

[AssetFileNameExtension("guiskin", new IL2CPP_TYPE_STRING[] {}])]
[ExecuteInEditMode]
[RequiredByNativeCode]
public sealed class GUISkin : ScriptableObject
{
	public sealed class SkinChangedDelegate : MulticastDelegate
	{

		public SkinChangedDelegate(object object, IntPtr method) { }

		public override void Invoke() { }

	}

	internal static GUIStyle ms_Error; //Field offset: 0x0
	internal static SkinChangedDelegate m_SkinChanged; //Field offset: 0x8
	internal static GUISkin current; //Field offset: 0x10
	[SerializeField]
	private Font m_Font; //Field offset: 0x18
	[SerializeField]
	private GUIStyle m_box; //Field offset: 0x20
	[SerializeField]
	private GUIStyle m_button; //Field offset: 0x28
	[SerializeField]
	private GUIStyle m_toggle; //Field offset: 0x30
	[SerializeField]
	private GUIStyle m_label; //Field offset: 0x38
	[SerializeField]
	private GUIStyle m_textField; //Field offset: 0x40
	[SerializeField]
	private GUIStyle m_textArea; //Field offset: 0x48
	[SerializeField]
	private GUIStyle m_window; //Field offset: 0x50
	[SerializeField]
	private GUIStyle m_horizontalSlider; //Field offset: 0x58
	[SerializeField]
	private GUIStyle m_horizontalSliderThumb; //Field offset: 0x60
	private GUIStyle m_horizontalSliderThumbExtent; //Field offset: 0x68
	[SerializeField]
	private GUIStyle m_verticalSlider; //Field offset: 0x70
	[SerializeField]
	private GUIStyle m_verticalSliderThumb; //Field offset: 0x78
	private GUIStyle m_verticalSliderThumbExtent; //Field offset: 0x80
	private GUIStyle m_SliderMixed; //Field offset: 0x88
	[SerializeField]
	private GUIStyle m_horizontalScrollbar; //Field offset: 0x90
	[SerializeField]
	private GUIStyle m_horizontalScrollbarThumb; //Field offset: 0x98
	[SerializeField]
	private GUIStyle m_horizontalScrollbarLeftButton; //Field offset: 0xA0
	[SerializeField]
	private GUIStyle m_horizontalScrollbarRightButton; //Field offset: 0xA8
	[SerializeField]
	private GUIStyle m_verticalScrollbar; //Field offset: 0xB0
	[SerializeField]
	private GUIStyle m_verticalScrollbarThumb; //Field offset: 0xB8
	[SerializeField]
	private GUIStyle m_verticalScrollbarUpButton; //Field offset: 0xC0
	[SerializeField]
	private GUIStyle m_verticalScrollbarDownButton; //Field offset: 0xC8
	[SerializeField]
	private GUIStyle m_ScrollView; //Field offset: 0xD0
	[SerializeField]
	internal GUIStyle[] m_CustomStyles; //Field offset: 0xD8
	[SerializeField]
	private GUISettings m_Settings; //Field offset: 0xE0
	private Dictionary<String, GUIStyle> m_Styles; //Field offset: 0xE8

	public GUIStyle box
	{
		 get { } //Length: 7
		 set { } //Length: 122
	}

	public GUIStyle button
	{
		 get { } //Length: 7
		 set { } //Length: 122
	}

	public GUIStyle[] customStyles
	{
		 get { } //Length: 10
		 set { } //Length: 128
	}

	internal static GUIStyle error
	{
		internal get { } //Length: 275
	}

	public Font font
	{
		 get { } //Length: 7
		 set { } //Length: 307
	}

	public GUIStyle horizontalScrollbar
	{
		 get { } //Length: 10
		 set { } //Length: 128
	}

	public GUIStyle horizontalScrollbarLeftButton
	{
		 get { } //Length: 10
		 set { } //Length: 128
	}

	public GUIStyle horizontalScrollbarRightButton
	{
		 get { } //Length: 10
		 set { } //Length: 128
	}

	public GUIStyle horizontalScrollbarThumb
	{
		 get { } //Length: 10
		 set { } //Length: 128
	}

	public GUIStyle horizontalSlider
	{
		 get { } //Length: 7
		 set { } //Length: 122
	}

	public GUIStyle horizontalSliderThumb
	{
		 get { } //Length: 7
		 set { } //Length: 122
	}

	internal GUIStyle horizontalSliderThumbExtent
	{
		internal get { } //Length: 7
		internal set { } //Length: 122
	}

	public GUIStyle label
	{
		 get { } //Length: 7
		 set { } //Length: 122
	}

	public GUIStyle scrollView
	{
		 get { } //Length: 10
		 set { } //Length: 128
	}

	public GUISettings settings
	{
		 get { } //Length: 10
	}

	internal GUIStyle sliderMixed
	{
		internal get { } //Length: 10
		internal set { } //Length: 128
	}

	public GUIStyle textArea
	{
		 get { } //Length: 7
		 set { } //Length: 122
	}

	public GUIStyle textField
	{
		 get { } //Length: 7
		 set { } //Length: 122
	}

	public GUIStyle toggle
	{
		 get { } //Length: 7
		 set { } //Length: 122
	}

	public GUIStyle verticalScrollbar
	{
		 get { } //Length: 10
		 set { } //Length: 128
	}

	public GUIStyle verticalScrollbarDownButton
	{
		 get { } //Length: 10
		 set { } //Length: 128
	}

	public GUIStyle verticalScrollbarThumb
	{
		 get { } //Length: 10
		 set { } //Length: 128
	}

	public GUIStyle verticalScrollbarUpButton
	{
		 get { } //Length: 10
		 set { } //Length: 128
	}

	public GUIStyle verticalSlider
	{
		 get { } //Length: 7
		 set { } //Length: 122
	}

	public GUIStyle verticalSliderThumb
	{
		 get { } //Length: 7
		 set { } //Length: 122
	}

	internal GUIStyle verticalSliderThumbExtent
	{
		internal get { } //Length: 10
		internal set { } //Length: 125
	}

	public GUIStyle window
	{
		 get { } //Length: 7
		 set { } //Length: 122
	}

	public GUISkin() { }

	internal void Apply() { }

	private void BuildStyleCache() { }

	internal static void CleanupRoots() { }

	public GUIStyle FindStyle(string styleName) { }

	public GUIStyle get_box() { }

	public GUIStyle get_button() { }

	public GUIStyle[] get_customStyles() { }

	internal static GUIStyle get_error() { }

	public Font get_font() { }

	public GUIStyle get_horizontalScrollbar() { }

	public GUIStyle get_horizontalScrollbarLeftButton() { }

	public GUIStyle get_horizontalScrollbarRightButton() { }

	public GUIStyle get_horizontalScrollbarThumb() { }

	public GUIStyle get_horizontalSlider() { }

	public GUIStyle get_horizontalSliderThumb() { }

	internal GUIStyle get_horizontalSliderThumbExtent() { }

	public GUIStyle get_label() { }

	public GUIStyle get_scrollView() { }

	public GUISettings get_settings() { }

	internal GUIStyle get_sliderMixed() { }

	public GUIStyle get_textArea() { }

	public GUIStyle get_textField() { }

	public GUIStyle get_toggle() { }

	public GUIStyle get_verticalScrollbar() { }

	public GUIStyle get_verticalScrollbarDownButton() { }

	public GUIStyle get_verticalScrollbarThumb() { }

	public GUIStyle get_verticalScrollbarUpButton() { }

	public GUIStyle get_verticalSlider() { }

	public GUIStyle get_verticalSliderThumb() { }

	internal GUIStyle get_verticalSliderThumbExtent() { }

	public GUIStyle get_window() { }

	public IEnumerator GetEnumerator() { }

	public GUIStyle GetStyle(string styleName) { }

	internal void MakeCurrent() { }

	internal void OnEnable() { }

	public void set_box(GUIStyle value) { }

	public void set_button(GUIStyle value) { }

	public void set_customStyles(GUIStyle[] value) { }

	public void set_font(Font value) { }

	public void set_horizontalScrollbar(GUIStyle value) { }

	public void set_horizontalScrollbarLeftButton(GUIStyle value) { }

	public void set_horizontalScrollbarRightButton(GUIStyle value) { }

	public void set_horizontalScrollbarThumb(GUIStyle value) { }

	public void set_horizontalSlider(GUIStyle value) { }

	public void set_horizontalSliderThumb(GUIStyle value) { }

	internal void set_horizontalSliderThumbExtent(GUIStyle value) { }

	public void set_label(GUIStyle value) { }

	public void set_scrollView(GUIStyle value) { }

	internal void set_sliderMixed(GUIStyle value) { }

	public void set_textArea(GUIStyle value) { }

	public void set_textField(GUIStyle value) { }

	public void set_toggle(GUIStyle value) { }

	public void set_verticalScrollbar(GUIStyle value) { }

	public void set_verticalScrollbarDownButton(GUIStyle value) { }

	public void set_verticalScrollbarThumb(GUIStyle value) { }

	public void set_verticalScrollbarUpButton(GUIStyle value) { }

	public void set_verticalSlider(GUIStyle value) { }

	public void set_verticalSliderThumb(GUIStyle value) { }

	internal void set_verticalSliderThumbExtent(GUIStyle value) { }

	public void set_window(GUIStyle value) { }

}

