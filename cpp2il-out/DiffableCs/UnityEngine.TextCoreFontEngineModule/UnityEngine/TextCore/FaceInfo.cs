namespace UnityEngine.TextCore;

[UsedByNativeCode]
public struct FaceInfo
{
	[NativeName("faceIndex")]
	[SerializeField]
	private int m_FaceIndex; //Field offset: 0x0
	[NativeName("familyName")]
	[SerializeField]
	private string m_FamilyName; //Field offset: 0x8
	[NativeName("styleName")]
	[SerializeField]
	private string m_StyleName; //Field offset: 0x10
	[NativeName("pointSize")]
	[SerializeField]
	private int m_PointSize; //Field offset: 0x18
	[NativeName("scale")]
	[SerializeField]
	private float m_Scale; //Field offset: 0x1C
	[NativeName("unitsPerEM")]
	[SerializeField]
	private int m_UnitsPerEM; //Field offset: 0x20
	[NativeName("lineHeight")]
	[SerializeField]
	private float m_LineHeight; //Field offset: 0x24
	[NativeName("ascentLine")]
	[SerializeField]
	private float m_AscentLine; //Field offset: 0x28
	[NativeName("capLine")]
	[SerializeField]
	private float m_CapLine; //Field offset: 0x2C
	[NativeName("meanLine")]
	[SerializeField]
	private float m_MeanLine; //Field offset: 0x30
	[NativeName("baseline")]
	[SerializeField]
	private float m_Baseline; //Field offset: 0x34
	[NativeName("descentLine")]
	[SerializeField]
	private float m_DescentLine; //Field offset: 0x38
	[NativeName("superscriptOffset")]
	[SerializeField]
	private float m_SuperscriptOffset; //Field offset: 0x3C
	[NativeName("superscriptSize")]
	[SerializeField]
	private float m_SuperscriptSize; //Field offset: 0x40
	[NativeName("subscriptOffset")]
	[SerializeField]
	private float m_SubscriptOffset; //Field offset: 0x44
	[NativeName("subscriptSize")]
	[SerializeField]
	private float m_SubscriptSize; //Field offset: 0x48
	[NativeName("underlineOffset")]
	[SerializeField]
	private float m_UnderlineOffset; //Field offset: 0x4C
	[NativeName("underlineThickness")]
	[SerializeField]
	private float m_UnderlineThickness; //Field offset: 0x50
	[NativeName("strikethroughOffset")]
	[SerializeField]
	private float m_StrikethroughOffset; //Field offset: 0x54
	[NativeName("strikethroughThickness")]
	[SerializeField]
	private float m_StrikethroughThickness; //Field offset: 0x58
	[NativeName("tabWidth")]
	[SerializeField]
	private float m_TabWidth; //Field offset: 0x5C

	public float ascentLine
	{
		 get { } //Length: 8
	}

	public float baseline
	{
		 get { } //Length: 8
	}

	public float capLine
	{
		 get { } //Length: 8
		 set { } //Length: 6
	}

	public float descentLine
	{
		 get { } //Length: 8
	}

	internal int faceIndex
	{
		internal get { } //Length: 5
	}

	public string familyName
	{
		 get { } //Length: 7
	}

	public float lineHeight
	{
		 get { } //Length: 8
	}

	public float meanLine
	{
		 get { } //Length: 8
		 set { } //Length: 6
	}

	public int pointSize
	{
		 get { } //Length: 6
	}

	public float scale
	{
		 get { } //Length: 8
		 set { } //Length: 6
	}

	public float strikethroughOffset
	{
		 get { } //Length: 8
		 set { } //Length: 6
	}

	public string styleName
	{
		 get { } //Length: 7
	}

	public float subscriptOffset
	{
		 get { } //Length: 8
	}

	public float subscriptSize
	{
		 get { } //Length: 8
	}

	public float superscriptOffset
	{
		 get { } //Length: 8
	}

	public float superscriptSize
	{
		 get { } //Length: 8
	}

	public float tabWidth
	{
		 get { } //Length: 8
	}

	public float underlineOffset
	{
		 get { } //Length: 8
	}

	public float underlineThickness
	{
		 get { } //Length: 8
	}

	public float get_ascentLine() { }

	public float get_baseline() { }

	public float get_capLine() { }

	public float get_descentLine() { }

	internal int get_faceIndex() { }

	public string get_familyName() { }

	public float get_lineHeight() { }

	public float get_meanLine() { }

	public int get_pointSize() { }

	public float get_scale() { }

	public float get_strikethroughOffset() { }

	public string get_styleName() { }

	public float get_subscriptOffset() { }

	public float get_subscriptSize() { }

	public float get_superscriptOffset() { }

	public float get_superscriptSize() { }

	public float get_tabWidth() { }

	public float get_underlineOffset() { }

	public float get_underlineThickness() { }

	public void set_capLine(float value) { }

	public void set_meanLine(float value) { }

	public void set_scale(float value) { }

	public void set_strikethroughOffset(float value) { }

}

