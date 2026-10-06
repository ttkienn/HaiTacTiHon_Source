namespace UnityEngine.UIElements;

internal class InlineStyleAccess : StyleValueCollection, IStyle
{
	public struct InlineRule
	{
		public StyleSheet sheet; //Field offset: 0x0
		public StyleRule rule; //Field offset: 0x8
		public StylePropertyId[] propertyIds; //Field offset: 0x10

	}

	private static StylePropertyReader s_StylePropertyReader; //Field offset: 0x0
	private List<StyleValueManaged> m_ValuesManaged; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private VisualElement <ve>k__BackingField; //Field offset: 0x20
	private bool m_HasInlineCursor; //Field offset: 0x28
	private StyleCursor m_InlineCursor; //Field offset: 0x30
	private bool m_HasInlineTextShadow; //Field offset: 0x50
	private StyleTextShadow m_InlineTextShadow; //Field offset: 0x54
	private bool m_HasInlineTransformOrigin; //Field offset: 0x74
	private StyleTransformOrigin m_InlineTransformOrigin; //Field offset: 0x78
	private bool m_HasInlineTranslate; //Field offset: 0x90
	private StyleTranslate m_InlineTranslateOperation; //Field offset: 0x94
	private bool m_HasInlineRotate; //Field offset: 0xB0
	private StyleRotate m_InlineRotateOperation; //Field offset: 0xB4
	private bool m_HasInlineScale; //Field offset: 0xD0
	private StyleScale m_InlineScale; //Field offset: 0xD4
	private bool m_HasInlineBackgroundSize; //Field offset: 0xE8
	public StyleBackgroundSize m_InlineBackgroundSize; //Field offset: 0xEC
	private InlineRule m_InlineRule; //Field offset: 0x108

	private override StyleColor UnityEngine.UIElements.IStyle.backgroundColor
	{
		private set { } //Length: 84
	}

	private override StyleBackgroundSize UnityEngine.UIElements.IStyle.backgroundSize
	{
		private get { } //Length: 104
	}

	private override StyleColor UnityEngine.UIElements.IStyle.borderBottomColor
	{
		private set { } //Length: 84
	}

	private override StyleLength UnityEngine.UIElements.IStyle.borderBottomLeftRadius
	{
		private set { } //Length: 86
	}

	private override StyleLength UnityEngine.UIElements.IStyle.borderBottomRightRadius
	{
		private set { } //Length: 86
	}

	private override StyleFloat UnityEngine.UIElements.IStyle.borderBottomWidth
	{
		private set { } //Length: 127
	}

	private override StyleColor UnityEngine.UIElements.IStyle.borderLeftColor
	{
		private set { } //Length: 84
	}

	private override StyleFloat UnityEngine.UIElements.IStyle.borderLeftWidth
	{
		private set { } //Length: 127
	}

	private override StyleColor UnityEngine.UIElements.IStyle.borderRightColor
	{
		private set { } //Length: 84
	}

	private override StyleFloat UnityEngine.UIElements.IStyle.borderRightWidth
	{
		private set { } //Length: 127
	}

	private override StyleColor UnityEngine.UIElements.IStyle.borderTopColor
	{
		private set { } //Length: 84
	}

	private override StyleLength UnityEngine.UIElements.IStyle.borderTopLeftRadius
	{
		private set { } //Length: 86
	}

	private override StyleLength UnityEngine.UIElements.IStyle.borderTopRightRadius
	{
		private set { } //Length: 86
	}

	private override StyleFloat UnityEngine.UIElements.IStyle.borderTopWidth
	{
		private set { } //Length: 127
	}

	private override StyleLength UnityEngine.UIElements.IStyle.bottom
	{
		private set { } //Length: 156
	}

	private override StyleColor UnityEngine.UIElements.IStyle.color
	{
		private set { } //Length: 84
	}

	private override StyleCursor UnityEngine.UIElements.IStyle.cursor
	{
		private get { } //Length: 132
	}

	private override StyleEnum<DisplayStyle> UnityEngine.UIElements.IStyle.display
	{
		private get { } //Length: 126
		private set { } //Length: 163
	}

	private override StyleLength UnityEngine.UIElements.IStyle.flexBasis
	{
		private set { } //Length: 156
	}

	private override StyleEnum<FlexDirection> UnityEngine.UIElements.IStyle.flexDirection
	{
		private set { } //Length: 163
	}

	private override StyleFloat UnityEngine.UIElements.IStyle.flexGrow
	{
		private set { } //Length: 127
	}

	private override StyleFloat UnityEngine.UIElements.IStyle.flexShrink
	{
		private set { } //Length: 127
	}

	private override StyleLength UnityEngine.UIElements.IStyle.fontSize
	{
		private set { } //Length: 86
	}

	private override StyleLength UnityEngine.UIElements.IStyle.height
	{
		private set { } //Length: 156
	}

	private override StyleLength UnityEngine.UIElements.IStyle.left
	{
		private set { } //Length: 156
	}

	private override StyleLength UnityEngine.UIElements.IStyle.marginBottom
	{
		private set { } //Length: 156
	}

	private override StyleLength UnityEngine.UIElements.IStyle.marginLeft
	{
		private set { } //Length: 156
	}

	private override StyleLength UnityEngine.UIElements.IStyle.marginRight
	{
		private set { } //Length: 156
	}

	private override StyleLength UnityEngine.UIElements.IStyle.marginTop
	{
		private set { } //Length: 156
	}

	private override StyleLength UnityEngine.UIElements.IStyle.maxHeight
	{
		private set { } //Length: 156
	}

	private override StyleLength UnityEngine.UIElements.IStyle.maxWidth
	{
		private set { } //Length: 156
	}

	private override StyleLength UnityEngine.UIElements.IStyle.minWidth
	{
		private set { } //Length: 156
	}

	private override StyleFloat UnityEngine.UIElements.IStyle.opacity
	{
		private set { } //Length: 67
	}

	private override StyleEnum<Overflow> UnityEngine.UIElements.IStyle.overflow
	{
		private set { } //Length: 270
	}

	private override StyleLength UnityEngine.UIElements.IStyle.paddingBottom
	{
		private set { } //Length: 156
	}

	private override StyleLength UnityEngine.UIElements.IStyle.paddingLeft
	{
		private set { } //Length: 156
	}

	private override StyleLength UnityEngine.UIElements.IStyle.paddingRight
	{
		private set { } //Length: 156
	}

	private override StyleLength UnityEngine.UIElements.IStyle.paddingTop
	{
		private get { } //Length: 59
		private set { } //Length: 156
	}

	private override StyleEnum<Position> UnityEngine.UIElements.IStyle.position
	{
		private set { } //Length: 163
	}

	private override StyleLength UnityEngine.UIElements.IStyle.right
	{
		private set { } //Length: 156
	}

	private override StyleRotate UnityEngine.UIElements.IStyle.rotate
	{
		private get { } //Length: 122
	}

	private override StyleScale UnityEngine.UIElements.IStyle.scale
	{
		private get { } //Length: 95
	}

	private override StyleTextShadow UnityEngine.UIElements.IStyle.textShadow
	{
		private get { } //Length: 90
	}

	private override StyleLength UnityEngine.UIElements.IStyle.top
	{
		private set { } //Length: 156
	}

	private override StyleTransformOrigin UnityEngine.UIElements.IStyle.transformOrigin
	{
		private get { } //Length: 98
	}

	private override StyleTranslate UnityEngine.UIElements.IStyle.translate
	{
		private get { } //Length: 122
		private set { } //Length: 423
	}

	private override StyleColor UnityEngine.UIElements.IStyle.unityBackgroundImageTintColor
	{
		private set { } //Length: 84
	}

	private override StyleFont UnityEngine.UIElements.IStyle.unityFont
	{
		private set { } //Length: 77
	}

	private override StyleFontDefinition UnityEngine.UIElements.IStyle.unityFontDefinition
	{
		private set { } //Length: 88
	}

	private override StyleEnum<Visibility> UnityEngine.UIElements.IStyle.visibility
	{
		private set { } //Length: 109
	}

	private override StyleLength UnityEngine.UIElements.IStyle.width
	{
		private get { } //Length: 59
		private set { } //Length: 156
	}

	private VisualElement ve
	{
		[CompilerGenerated]
		private get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 13
	}

	private static InlineStyleAccess() { }

	public InlineStyleAccess(VisualElement ve) { }

	private void ApplyFromComputedStyle(StylePropertyId id, ref ComputedStyle newStyle) { }

	public void ApplyInlineStyles(ref ComputedStyle computedStyle) { }

	private void ApplyStyleTranslate(StyleTranslate translate) { }

	private void ApplyStyleValue(StyleValue value) { }

	protected virtual void Finalize() { }

	[CompilerGenerated]
	private VisualElement get_ve() { }

	public bool IsValueSet(StylePropertyId id) { }

	private bool RemoveInlineStyle(StylePropertyId id) { }

	[CompilerGenerated]
	private void set_ve(VisualElement value) { }

	public void SetInlineRule(StyleSheet sheet, StyleRule rule) { }

	private bool SetInlineTranslate(StyleTranslate inlineValue) { }

	private bool SetStyleValue(StylePropertyId id, StyleLength inlineValue) { }

	private bool SetStyleValue(StylePropertyId id, StyleColor inlineValue) { }

	private bool SetStyleValue(StylePropertyId id, StyleFloat inlineValue) { }

	private bool SetStyleValue(StylePropertyId id, StyleEnum<T> inlineValue) { }

	private bool SetStyleValue(StylePropertyId id, StyleFontDefinition inlineValue) { }

	private bool SetStyleValue(StylePropertyId id, StyleFont inlineValue) { }

	public bool TryGetInlineBackgroundSize(ref StyleBackgroundSize value) { }

	public bool TryGetInlineCursor(ref StyleCursor value) { }

	public bool TryGetInlineRotate(ref StyleRotate value) { }

	public bool TryGetInlineScale(ref StyleScale value) { }

	public bool TryGetInlineTextShadow(ref StyleTextShadow value) { }

	public bool TryGetInlineTransformOrigin(ref StyleTransformOrigin value) { }

	public bool TryGetInlineTranslate(ref StyleTranslate value) { }

	private override StyleBackgroundSize UnityEngine.UIElements.IStyle.get_backgroundSize() { }

	private override StyleCursor UnityEngine.UIElements.IStyle.get_cursor() { }

	private override StyleEnum<DisplayStyle> UnityEngine.UIElements.IStyle.get_display() { }

	private override StyleLength UnityEngine.UIElements.IStyle.get_paddingTop() { }

	private override StyleRotate UnityEngine.UIElements.IStyle.get_rotate() { }

	private override StyleScale UnityEngine.UIElements.IStyle.get_scale() { }

	private override StyleTextShadow UnityEngine.UIElements.IStyle.get_textShadow() { }

	private override StyleTransformOrigin UnityEngine.UIElements.IStyle.get_transformOrigin() { }

	private override StyleTranslate UnityEngine.UIElements.IStyle.get_translate() { }

	private override StyleLength UnityEngine.UIElements.IStyle.get_width() { }

	private override void UnityEngine.UIElements.IStyle.set_backgroundColor(StyleColor value) { }

	private override void UnityEngine.UIElements.IStyle.set_borderBottomColor(StyleColor value) { }

	private override void UnityEngine.UIElements.IStyle.set_borderBottomLeftRadius(StyleLength value) { }

	private override void UnityEngine.UIElements.IStyle.set_borderBottomRightRadius(StyleLength value) { }

	private override void UnityEngine.UIElements.IStyle.set_borderBottomWidth(StyleFloat value) { }

	private override void UnityEngine.UIElements.IStyle.set_borderLeftColor(StyleColor value) { }

	private override void UnityEngine.UIElements.IStyle.set_borderLeftWidth(StyleFloat value) { }

	private override void UnityEngine.UIElements.IStyle.set_borderRightColor(StyleColor value) { }

	private override void UnityEngine.UIElements.IStyle.set_borderRightWidth(StyleFloat value) { }

	private override void UnityEngine.UIElements.IStyle.set_borderTopColor(StyleColor value) { }

	private override void UnityEngine.UIElements.IStyle.set_borderTopLeftRadius(StyleLength value) { }

	private override void UnityEngine.UIElements.IStyle.set_borderTopRightRadius(StyleLength value) { }

	private override void UnityEngine.UIElements.IStyle.set_borderTopWidth(StyleFloat value) { }

	private override void UnityEngine.UIElements.IStyle.set_bottom(StyleLength value) { }

	private override void UnityEngine.UIElements.IStyle.set_color(StyleColor value) { }

	private override void UnityEngine.UIElements.IStyle.set_display(StyleEnum<DisplayStyle> value) { }

	private override void UnityEngine.UIElements.IStyle.set_flexBasis(StyleLength value) { }

	private override void UnityEngine.UIElements.IStyle.set_flexDirection(StyleEnum<FlexDirection> value) { }

	private override void UnityEngine.UIElements.IStyle.set_flexGrow(StyleFloat value) { }

	private override void UnityEngine.UIElements.IStyle.set_flexShrink(StyleFloat value) { }

	private override void UnityEngine.UIElements.IStyle.set_fontSize(StyleLength value) { }

	private override void UnityEngine.UIElements.IStyle.set_height(StyleLength value) { }

	private override void UnityEngine.UIElements.IStyle.set_left(StyleLength value) { }

	private override void UnityEngine.UIElements.IStyle.set_marginBottom(StyleLength value) { }

	private override void UnityEngine.UIElements.IStyle.set_marginLeft(StyleLength value) { }

	private override void UnityEngine.UIElements.IStyle.set_marginRight(StyleLength value) { }

	private override void UnityEngine.UIElements.IStyle.set_marginTop(StyleLength value) { }

	private override void UnityEngine.UIElements.IStyle.set_maxHeight(StyleLength value) { }

	private override void UnityEngine.UIElements.IStyle.set_maxWidth(StyleLength value) { }

	private override void UnityEngine.UIElements.IStyle.set_minWidth(StyleLength value) { }

	private override void UnityEngine.UIElements.IStyle.set_opacity(StyleFloat value) { }

	private override void UnityEngine.UIElements.IStyle.set_overflow(StyleEnum<Overflow> value) { }

	private override void UnityEngine.UIElements.IStyle.set_paddingBottom(StyleLength value) { }

	private override void UnityEngine.UIElements.IStyle.set_paddingLeft(StyleLength value) { }

	private override void UnityEngine.UIElements.IStyle.set_paddingRight(StyleLength value) { }

	private override void UnityEngine.UIElements.IStyle.set_paddingTop(StyleLength value) { }

	private override void UnityEngine.UIElements.IStyle.set_position(StyleEnum<Position> value) { }

	private override void UnityEngine.UIElements.IStyle.set_right(StyleLength value) { }

	private override void UnityEngine.UIElements.IStyle.set_top(StyleLength value) { }

	private override void UnityEngine.UIElements.IStyle.set_translate(StyleTranslate value) { }

	private override void UnityEngine.UIElements.IStyle.set_unityBackgroundImageTintColor(StyleColor value) { }

	private override void UnityEngine.UIElements.IStyle.set_unityFont(StyleFont value) { }

	private override void UnityEngine.UIElements.IStyle.set_unityFontDefinition(StyleFontDefinition value) { }

	private override void UnityEngine.UIElements.IStyle.set_visibility(StyleEnum<Visibility> value) { }

	private override void UnityEngine.UIElements.IStyle.set_width(StyleLength value) { }

}

