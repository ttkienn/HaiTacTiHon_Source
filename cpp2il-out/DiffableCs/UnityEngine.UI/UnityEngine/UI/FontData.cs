namespace UnityEngine.UI;

public class FontData : ISerializationCallbackReceiver
{
	[FormerlySerializedAs("font")]
	[SerializeField]
	private Font m_Font; //Field offset: 0x10
	[FormerlySerializedAs("fontSize")]
	[SerializeField]
	private int m_FontSize; //Field offset: 0x18
	[FormerlySerializedAs("fontStyle")]
	[SerializeField]
	private FontStyle m_FontStyle; //Field offset: 0x1C
	[SerializeField]
	private bool m_BestFit; //Field offset: 0x20
	[SerializeField]
	private int m_MinSize; //Field offset: 0x24
	[SerializeField]
	private int m_MaxSize; //Field offset: 0x28
	[FormerlySerializedAs("alignment")]
	[SerializeField]
	private TextAnchor m_Alignment; //Field offset: 0x2C
	[SerializeField]
	private bool m_AlignByGeometry; //Field offset: 0x30
	[FormerlySerializedAs("richText")]
	[SerializeField]
	private bool m_RichText; //Field offset: 0x31
	[SerializeField]
	private HorizontalWrapMode m_HorizontalOverflow; //Field offset: 0x34
	[SerializeField]
	private VerticalWrapMode m_VerticalOverflow; //Field offset: 0x38
	[SerializeField]
	private float m_LineSpacing; //Field offset: 0x3C

	public bool alignByGeometry
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public TextAnchor alignment
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public bool bestFit
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public static FontData defaultFontData
	{
		 get { } //Length: 123
	}

	public Font font
	{
		 get { } //Length: 5
		 set { } //Length: 13
	}

	public int fontSize
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public FontStyle fontStyle
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public HorizontalWrapMode horizontalOverflow
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public float lineSpacing
	{
		 get { } //Length: 6
		 set { } //Length: 6
	}

	public int maxSize
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public int minSize
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public bool richText
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public VerticalWrapMode verticalOverflow
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public FontData() { }

	public bool get_alignByGeometry() { }

	public TextAnchor get_alignment() { }

	public bool get_bestFit() { }

	public static FontData get_defaultFontData() { }

	public Font get_font() { }

	public int get_fontSize() { }

	public FontStyle get_fontStyle() { }

	public HorizontalWrapMode get_horizontalOverflow() { }

	public float get_lineSpacing() { }

	public int get_maxSize() { }

	public int get_minSize() { }

	public bool get_richText() { }

	public VerticalWrapMode get_verticalOverflow() { }

	public void set_alignByGeometry(bool value) { }

	public void set_alignment(TextAnchor value) { }

	public void set_bestFit(bool value) { }

	public void set_font(Font value) { }

	public void set_fontSize(int value) { }

	public void set_fontStyle(FontStyle value) { }

	public void set_horizontalOverflow(HorizontalWrapMode value) { }

	public void set_lineSpacing(float value) { }

	public void set_maxSize(int value) { }

	public void set_minSize(int value) { }

	public void set_richText(bool value) { }

	public void set_verticalOverflow(VerticalWrapMode value) { }

	private override void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

	private override void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

}

