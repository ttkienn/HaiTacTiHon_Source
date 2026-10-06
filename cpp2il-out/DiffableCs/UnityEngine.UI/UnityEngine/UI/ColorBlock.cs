namespace UnityEngine.UI;

public struct ColorBlock : IEquatable<ColorBlock>
{
	public static ColorBlock defaultColorBlock; //Field offset: 0x0
	[FormerlySerializedAs("normalColor")]
	[SerializeField]
	private Color m_NormalColor; //Field offset: 0x0
	[FormerlySerializedAs("highlightedColor")]
	[SerializeField]
	private Color m_HighlightedColor; //Field offset: 0x10
	[FormerlySerializedAs("pressedColor")]
	[SerializeField]
	private Color m_PressedColor; //Field offset: 0x20
	[FormerlySerializedAs("m_HighlightedColor")]
	[SerializeField]
	private Color m_SelectedColor; //Field offset: 0x30
	[FormerlySerializedAs("disabledColor")]
	[SerializeField]
	private Color m_DisabledColor; //Field offset: 0x40
	[Range(1, 5)]
	[SerializeField]
	private float m_ColorMultiplier; //Field offset: 0x50
	[FormerlySerializedAs("fadeDuration")]
	[SerializeField]
	private float m_FadeDuration; //Field offset: 0x54

	public float colorMultiplier
	{
		 get { } //Length: 6
		 set { } //Length: 6
	}

	public Color disabledColor
	{
		 get { } //Length: 11
		 set { } //Length: 8
	}

	public float fadeDuration
	{
		 get { } //Length: 6
		 set { } //Length: 6
	}

	public Color highlightedColor
	{
		 get { } //Length: 11
		 set { } //Length: 8
	}

	public Color normalColor
	{
		 get { } //Length: 10
		 set { } //Length: 7
	}

	public Color pressedColor
	{
		 get { } //Length: 11
		 set { } //Length: 8
	}

	public Color selectedColor
	{
		 get { } //Length: 11
		 set { } //Length: 8
	}

	private static ColorBlock() { }

	public override bool Equals(ColorBlock other) { }

	public virtual bool Equals(object obj) { }

	public float get_colorMultiplier() { }

	public Color get_disabledColor() { }

	public float get_fadeDuration() { }

	public Color get_highlightedColor() { }

	public Color get_normalColor() { }

	public Color get_pressedColor() { }

	public Color get_selectedColor() { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(ColorBlock point1, ColorBlock point2) { }

	public static bool op_Inequality(ColorBlock point1, ColorBlock point2) { }

	public void set_colorMultiplier(float value) { }

	public void set_disabledColor(Color value) { }

	public void set_fadeDuration(float value) { }

	public void set_highlightedColor(Color value) { }

	public void set_normalColor(Color value) { }

	public void set_pressedColor(Color value) { }

	public void set_selectedColor(Color value) { }

}

