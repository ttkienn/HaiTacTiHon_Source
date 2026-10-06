namespace UnityEngine;

internal class GUILayoutEntry
{
	internal static Rect kDummyRect; //Field offset: 0x0
	protected static int indent; //Field offset: 0x10
	public float minWidth; //Field offset: 0x10
	public float maxWidth; //Field offset: 0x14
	public float minHeight; //Field offset: 0x18
	public float maxHeight; //Field offset: 0x1C
	public Rect rect; //Field offset: 0x20
	public int stretchWidth; //Field offset: 0x30
	public int stretchHeight; //Field offset: 0x34
	public bool consideredForMargin; //Field offset: 0x38
	private GUIStyle m_Style; //Field offset: 0x40

	public override int marginBottom
	{
		 get { } //Length: 44
	}

	public int marginHorizontal
	{
		 get { } //Length: 70
	}

	public override int marginLeft
	{
		 get { } //Length: 44
	}

	public override int marginRight
	{
		 get { } //Length: 44
	}

	public override int marginTop
	{
		 get { } //Length: 44
	}

	public int marginVertical
	{
		 get { } //Length: 70
	}

	public GUIStyle style
	{
		 get { } //Length: 7
		 set { } //Length: 65
	}

	private static GUILayoutEntry() { }

	public GUILayoutEntry(float _minWidth, float _maxWidth, float _minHeight, float _maxHeight, GUIStyle _style, GUILayoutOption[] options) { }

	public GUILayoutEntry(float _minWidth, float _maxWidth, float _minHeight, float _maxHeight, GUIStyle _style) { }

	public override void ApplyOptions(GUILayoutOption[] options) { }

	protected override void ApplyStyleSettings(GUIStyle style) { }

	public override void CalcHeight() { }

	public override void CalcWidth() { }

	public override int get_marginBottom() { }

	public int get_marginHorizontal() { }

	public override int get_marginLeft() { }

	public override int get_marginRight() { }

	public override int get_marginTop() { }

	public int get_marginVertical() { }

	public GUIStyle get_style() { }

	public void set_style(GUIStyle value) { }

	public override void SetHorizontal(float x, float width) { }

	public override void SetVertical(float y, float height) { }

	public virtual string ToString() { }

}

