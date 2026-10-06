namespace UnityEngine.UIElements;

public interface IStyle
{

	public StyleColor backgroundColor
	{
		 set { } //Length: 0
	}

	public StyleBackgroundSize backgroundSize
	{
		 get { } //Length: 0
	}

	public StyleColor borderBottomColor
	{
		 set { } //Length: 0
	}

	public StyleLength borderBottomLeftRadius
	{
		 set { } //Length: 0
	}

	public StyleLength borderBottomRightRadius
	{
		 set { } //Length: 0
	}

	public StyleFloat borderBottomWidth
	{
		 set { } //Length: 0
	}

	public StyleColor borderLeftColor
	{
		 set { } //Length: 0
	}

	public StyleFloat borderLeftWidth
	{
		 set { } //Length: 0
	}

	public StyleColor borderRightColor
	{
		 set { } //Length: 0
	}

	public StyleFloat borderRightWidth
	{
		 set { } //Length: 0
	}

	public StyleColor borderTopColor
	{
		 set { } //Length: 0
	}

	public StyleLength borderTopLeftRadius
	{
		 set { } //Length: 0
	}

	public StyleLength borderTopRightRadius
	{
		 set { } //Length: 0
	}

	public StyleFloat borderTopWidth
	{
		 set { } //Length: 0
	}

	public StyleLength bottom
	{
		 set { } //Length: 0
	}

	public StyleColor color
	{
		 set { } //Length: 0
	}

	public StyleCursor cursor
	{
		 get { } //Length: 0
	}

	public StyleEnum<DisplayStyle> display
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public StyleLength flexBasis
	{
		 set { } //Length: 0
	}

	public StyleEnum<FlexDirection> flexDirection
	{
		 set { } //Length: 0
	}

	public StyleFloat flexGrow
	{
		 set { } //Length: 0
	}

	public StyleFloat flexShrink
	{
		 set { } //Length: 0
	}

	public StyleLength fontSize
	{
		 set { } //Length: 0
	}

	public StyleLength height
	{
		 set { } //Length: 0
	}

	public StyleLength left
	{
		 set { } //Length: 0
	}

	public StyleLength marginBottom
	{
		 set { } //Length: 0
	}

	public StyleLength marginLeft
	{
		 set { } //Length: 0
	}

	public StyleLength marginRight
	{
		 set { } //Length: 0
	}

	public StyleLength marginTop
	{
		 set { } //Length: 0
	}

	public StyleLength maxHeight
	{
		 set { } //Length: 0
	}

	public StyleLength maxWidth
	{
		 set { } //Length: 0
	}

	public StyleLength minWidth
	{
		 set { } //Length: 0
	}

	public StyleFloat opacity
	{
		 set { } //Length: 0
	}

	public StyleEnum<Overflow> overflow
	{
		 set { } //Length: 0
	}

	public StyleLength paddingBottom
	{
		 set { } //Length: 0
	}

	public StyleLength paddingLeft
	{
		 set { } //Length: 0
	}

	public StyleLength paddingRight
	{
		 set { } //Length: 0
	}

	public StyleLength paddingTop
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public StyleEnum<Position> position
	{
		 set { } //Length: 0
	}

	public StyleLength right
	{
		 set { } //Length: 0
	}

	public StyleRotate rotate
	{
		 get { } //Length: 0
	}

	public StyleScale scale
	{
		 get { } //Length: 0
	}

	public StyleTextShadow textShadow
	{
		 get { } //Length: 0
	}

	public StyleLength top
	{
		 set { } //Length: 0
	}

	public StyleTransformOrigin transformOrigin
	{
		 get { } //Length: 0
	}

	public StyleTranslate translate
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public StyleColor unityBackgroundImageTintColor
	{
		 set { } //Length: 0
	}

	public StyleFont unityFont
	{
		 set { } //Length: 0
	}

	public StyleFontDefinition unityFontDefinition
	{
		 set { } //Length: 0
	}

	public StyleEnum<Visibility> visibility
	{
		 set { } //Length: 0
	}

	public StyleLength width
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public StyleBackgroundSize get_backgroundSize() { }

	public StyleCursor get_cursor() { }

	public StyleEnum<DisplayStyle> get_display() { }

	public StyleLength get_paddingTop() { }

	public StyleRotate get_rotate() { }

	public StyleScale get_scale() { }

	public StyleTextShadow get_textShadow() { }

	public StyleTransformOrigin get_transformOrigin() { }

	public StyleTranslate get_translate() { }

	public StyleLength get_width() { }

	public void set_backgroundColor(StyleColor value) { }

	public void set_borderBottomColor(StyleColor value) { }

	public void set_borderBottomLeftRadius(StyleLength value) { }

	public void set_borderBottomRightRadius(StyleLength value) { }

	public void set_borderBottomWidth(StyleFloat value) { }

	public void set_borderLeftColor(StyleColor value) { }

	public void set_borderLeftWidth(StyleFloat value) { }

	public void set_borderRightColor(StyleColor value) { }

	public void set_borderRightWidth(StyleFloat value) { }

	public void set_borderTopColor(StyleColor value) { }

	public void set_borderTopLeftRadius(StyleLength value) { }

	public void set_borderTopRightRadius(StyleLength value) { }

	public void set_borderTopWidth(StyleFloat value) { }

	public void set_bottom(StyleLength value) { }

	public void set_color(StyleColor value) { }

	public void set_display(StyleEnum<DisplayStyle> value) { }

	public void set_flexBasis(StyleLength value) { }

	public void set_flexDirection(StyleEnum<FlexDirection> value) { }

	public void set_flexGrow(StyleFloat value) { }

	public void set_flexShrink(StyleFloat value) { }

	public void set_fontSize(StyleLength value) { }

	public void set_height(StyleLength value) { }

	public void set_left(StyleLength value) { }

	public void set_marginBottom(StyleLength value) { }

	public void set_marginLeft(StyleLength value) { }

	public void set_marginRight(StyleLength value) { }

	public void set_marginTop(StyleLength value) { }

	public void set_maxHeight(StyleLength value) { }

	public void set_maxWidth(StyleLength value) { }

	public void set_minWidth(StyleLength value) { }

	public void set_opacity(StyleFloat value) { }

	public void set_overflow(StyleEnum<Overflow> value) { }

	public void set_paddingBottom(StyleLength value) { }

	public void set_paddingLeft(StyleLength value) { }

	public void set_paddingRight(StyleLength value) { }

	public void set_paddingTop(StyleLength value) { }

	public void set_position(StyleEnum<Position> value) { }

	public void set_right(StyleLength value) { }

	public void set_top(StyleLength value) { }

	public void set_translate(StyleTranslate value) { }

	public void set_unityBackgroundImageTintColor(StyleColor value) { }

	public void set_unityFont(StyleFont value) { }

	public void set_unityFontDefinition(StyleFontDefinition value) { }

	public void set_visibility(StyleEnum<Visibility> value) { }

	public void set_width(StyleLength value) { }

}

