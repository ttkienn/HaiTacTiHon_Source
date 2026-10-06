namespace UnityEngine.UIElements;

internal struct ComputedStyle
{
	public StyleDataRef<InheritedData> inheritedData; //Field offset: 0x0
	public StyleDataRef<LayoutData> layoutData; //Field offset: 0x8
	public StyleDataRef<RareData> rareData; //Field offset: 0x10
	public StyleDataRef<TransformData> transformData; //Field offset: 0x18
	public StyleDataRef<TransitionData> transitionData; //Field offset: 0x20
	public StyleDataRef<VisualData> visualData; //Field offset: 0x28
	public YogaNode yogaNode; //Field offset: 0x30
	public Dictionary<String, StylePropertyValue> customProperties; //Field offset: 0x38
	public long matchingRulesHash; //Field offset: 0x40
	public float dpiScaling; //Field offset: 0x48
	public ComputedTransitionProperty[] computedTransitions; //Field offset: 0x50

	public Align alignContent
	{
		 get { } //Length: 61
	}

	public Align alignItems
	{
		 get { } //Length: 62
	}

	public Align alignSelf
	{
		 get { } //Length: 62
	}

	public Color backgroundColor
	{
		 get { } //Length: 80
	}

	public Background backgroundImage
	{
		 get { } //Length: 89
	}

	public BackgroundPosition backgroundPositionX
	{
		 get { } //Length: 89
	}

	public BackgroundPosition backgroundPositionY
	{
		 get { } //Length: 89
	}

	public BackgroundRepeat backgroundRepeat
	{
		 get { } //Length: 63
	}

	public BackgroundSize backgroundSize
	{
		 get { } //Length: 87
	}

	public Color borderBottomColor
	{
		 get { } //Length: 81
	}

	public Length borderBottomLeftRadius
	{
		 get { } //Length: 63
	}

	public Length borderBottomRightRadius
	{
		 get { } //Length: 63
	}

	public float borderBottomWidth
	{
		 get { } //Length: 64
	}

	public Color borderLeftColor
	{
		 get { } //Length: 84
	}

	public float borderLeftWidth
	{
		 get { } //Length: 64
	}

	public Color borderRightColor
	{
		 get { } //Length: 84
	}

	public float borderRightWidth
	{
		 get { } //Length: 64
	}

	public Color borderTopColor
	{
		 get { } //Length: 84
	}

	public Length borderTopLeftRadius
	{
		 get { } //Length: 66
	}

	public Length borderTopRightRadius
	{
		 get { } //Length: 66
	}

	public float borderTopWidth
	{
		 get { } //Length: 64
	}

	public Length bottom
	{
		 get { } //Length: 63
	}

	public Color color
	{
		 get { } //Length: 79
	}

	public Cursor cursor
	{
		 get { } //Length: 90
	}

	public int customPropertiesCount
	{
		 get { } //Length: 71
	}

	public DisplayStyle display
	{
		 get { } //Length: 62
	}

	public Length flexBasis
	{
		 get { } //Length: 63
	}

	public FlexDirection flexDirection
	{
		 get { } //Length: 62
	}

	public float flexGrow
	{
		 get { } //Length: 64
	}

	public float flexShrink
	{
		 get { } //Length: 64
	}

	public Wrap flexWrap
	{
		 get { } //Length: 62
	}

	public Length fontSize
	{
		 get { } //Length: 62
	}

	public bool hasTransition
	{
		 get { } //Length: 18
	}

	public Length height
	{
		 get { } //Length: 63
	}

	public Justify justifyContent
	{
		 get { } //Length: 62
	}

	public Length left
	{
		 get { } //Length: 63
	}

	public Length letterSpacing
	{
		 get { } //Length: 62
	}

	public Length marginBottom
	{
		 get { } //Length: 63
	}

	public Length marginLeft
	{
		 get { } //Length: 63
	}

	public Length marginRight
	{
		 get { } //Length: 63
	}

	public Length marginTop
	{
		 get { } //Length: 63
	}

	public Length maxHeight
	{
		 get { } //Length: 63
	}

	public Length maxWidth
	{
		 get { } //Length: 63
	}

	public Length minHeight
	{
		 get { } //Length: 66
	}

	public Length minWidth
	{
		 get { } //Length: 66
	}

	public float opacity
	{
		 get { } //Length: 67
	}

	public OverflowInternal overflow
	{
		 get { } //Length: 65
	}

	public Length paddingBottom
	{
		 get { } //Length: 66
	}

	public Length paddingLeft
	{
		 get { } //Length: 66
	}

	public Length paddingRight
	{
		 get { } //Length: 66
	}

	public Length paddingTop
	{
		 get { } //Length: 66
	}

	public Position position
	{
		 get { } //Length: 65
	}

	public Length right
	{
		 get { } //Length: 66
	}

	public Rotate rotate
	{
		 get { } //Length: 90
	}

	public Scale scale
	{
		 get { } //Length: 81
	}

	public TextOverflow textOverflow
	{
		 get { } //Length: 62
	}

	public TextShadow textShadow
	{
		 get { } //Length: 96
	}

	public Length top
	{
		 get { } //Length: 66
	}

	public TransformOrigin transformOrigin
	{
		 get { } //Length: 87
	}

	public List<TimeValue> transitionDelay
	{
		 get { } //Length: 62
	}

	public List<TimeValue> transitionDuration
	{
		 get { } //Length: 63
	}

	public List<StylePropertyName> transitionProperty
	{
		 get { } //Length: 63
	}

	public List<EasingFunction> transitionTimingFunction
	{
		 get { } //Length: 63
	}

	public Translate translate
	{
		 get { } //Length: 91
	}

	public Color unityBackgroundImageTintColor
	{
		 get { } //Length: 81
	}

	public Font unityFont
	{
		 get { } //Length: 62
	}

	public FontDefinition unityFontDefinition
	{
		 get { } //Length: 80
	}

	public FontStyle unityFontStyleAndWeight
	{
		 get { } //Length: 61
	}

	public OverflowClipBox unityOverflowClipBox
	{
		 get { } //Length: 62
	}

	public Length unityParagraphSpacing
	{
		 get { } //Length: 62
	}

	public int unitySliceBottom
	{
		 get { } //Length: 62
	}

	public int unitySliceLeft
	{
		 get { } //Length: 62
	}

	public int unitySliceRight
	{
		 get { } //Length: 62
	}

	public float unitySliceScale
	{
		 get { } //Length: 64
	}

	public int unitySliceTop
	{
		 get { } //Length: 62
	}

	public TextAnchor unityTextAlign
	{
		 get { } //Length: 61
	}

	public Color unityTextOutlineColor
	{
		 get { } //Length: 80
	}

	public float unityTextOutlineWidth
	{
		 get { } //Length: 63
	}

	public TextOverflowPosition unityTextOverflowPosition
	{
		 get { } //Length: 62
	}

	public Visibility visibility
	{
		 get { } //Length: 61
	}

	public WhiteSpace whiteSpace
	{
		 get { } //Length: 64
	}

	public Length width
	{
		 get { } //Length: 66
	}

	public Length wordSpacing
	{
		 get { } //Length: 1475
	}

	public ComputedStyle Acquire() { }

	private void ApplyAllPropertyInitial() { }

	private void ApplyCustomStyleProperty(StylePropertyReader reader) { }

	public void ApplyFromComputedStyle(StylePropertyId id, ref ComputedStyle other) { }

	private bool ApplyGlobalKeyword(StylePropertyReader reader, ref ComputedStyle parentStyle) { }

	private bool ApplyGlobalKeyword(StylePropertyId id, StyleKeyword keyword, ref ComputedStyle parentStyle) { }

	public void ApplyInitialValue(StylePropertyReader reader) { }

	public void ApplyInitialValue(StylePropertyId id) { }

	public void ApplyProperties(StylePropertyReader reader, ref ComputedStyle parentStyle) { }

	public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, Color newValue) { }

	public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, FontDefinition newValue) { }

	public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, BackgroundSize newValue) { }

	public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, BackgroundRepeat newValue) { }

	public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, BackgroundPosition newValue) { }

	public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, int newValue) { }

	public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, float newValue) { }

	public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, Length newValue) { }

	public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, TransformOrigin newValue) { }

	public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, Translate newValue) { }

	public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, Background newValue) { }

	public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, Rotate newValue) { }

	public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, Scale newValue) { }

	public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, TextShadow newValue) { }

	public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, Font newValue) { }

	public void ApplyStyleBackgroundSize(BackgroundSize backgroundSizeValue) { }

	public void ApplyStyleCursor(Cursor cursor) { }

	public void ApplyStyleRotate(Rotate rotateValue) { }

	public void ApplyStyleScale(Scale scaleValue) { }

	public void ApplyStyleTextShadow(TextShadow st) { }

	public void ApplyStyleTransformOrigin(TransformOrigin st) { }

	public void ApplyStyleTranslate(Translate translateValue) { }

	public void ApplyStyleValue(StyleValue sv, ref ComputedStyle parentStyle) { }

	public void ApplyStyleValueManaged(StyleValueManaged sv, ref ComputedStyle parentStyle) { }

	public void ApplyUnsetValue(StylePropertyReader reader, ref ComputedStyle parentStyle) { }

	public void ApplyUnsetValue(StylePropertyId id, ref ComputedStyle parentStyle) { }

	public static VersionChangeType CompareChanges(ref ComputedStyle x, ref ComputedStyle y) { }

	public void CopyFrom(ref ComputedStyle other) { }

	public static ComputedStyle Create(ref ComputedStyle parentStyle) { }

	public static ComputedStyle CreateInitial() { }

	public void FinalizeApply(ref ComputedStyle parentStyle) { }

	public Align get_alignContent() { }

	public Align get_alignItems() { }

	public Align get_alignSelf() { }

	public Color get_backgroundColor() { }

	public Background get_backgroundImage() { }

	public BackgroundPosition get_backgroundPositionX() { }

	public BackgroundPosition get_backgroundPositionY() { }

	public BackgroundRepeat get_backgroundRepeat() { }

	public BackgroundSize get_backgroundSize() { }

	public Color get_borderBottomColor() { }

	public Length get_borderBottomLeftRadius() { }

	public Length get_borderBottomRightRadius() { }

	public float get_borderBottomWidth() { }

	public Color get_borderLeftColor() { }

	public float get_borderLeftWidth() { }

	public Color get_borderRightColor() { }

	public float get_borderRightWidth() { }

	public Color get_borderTopColor() { }

	public Length get_borderTopLeftRadius() { }

	public Length get_borderTopRightRadius() { }

	public float get_borderTopWidth() { }

	public Length get_bottom() { }

	public Color get_color() { }

	public Cursor get_cursor() { }

	public int get_customPropertiesCount() { }

	public DisplayStyle get_display() { }

	public Length get_flexBasis() { }

	public FlexDirection get_flexDirection() { }

	public float get_flexGrow() { }

	public float get_flexShrink() { }

	public Wrap get_flexWrap() { }

	public Length get_fontSize() { }

	public bool get_hasTransition() { }

	public Length get_height() { }

	public Justify get_justifyContent() { }

	public Length get_left() { }

	public Length get_letterSpacing() { }

	public Length get_marginBottom() { }

	public Length get_marginLeft() { }

	public Length get_marginRight() { }

	public Length get_marginTop() { }

	public Length get_maxHeight() { }

	public Length get_maxWidth() { }

	public Length get_minHeight() { }

	public Length get_minWidth() { }

	public float get_opacity() { }

	public OverflowInternal get_overflow() { }

	public Length get_paddingBottom() { }

	public Length get_paddingLeft() { }

	public Length get_paddingRight() { }

	public Length get_paddingTop() { }

	public Position get_position() { }

	public Length get_right() { }

	public Rotate get_rotate() { }

	public Scale get_scale() { }

	public TextOverflow get_textOverflow() { }

	public TextShadow get_textShadow() { }

	public Length get_top() { }

	public TransformOrigin get_transformOrigin() { }

	public List<TimeValue> get_transitionDelay() { }

	public List<TimeValue> get_transitionDuration() { }

	public List<StylePropertyName> get_transitionProperty() { }

	public List<EasingFunction> get_transitionTimingFunction() { }

	public Translate get_translate() { }

	public Color get_unityBackgroundImageTintColor() { }

	public Font get_unityFont() { }

	public FontDefinition get_unityFontDefinition() { }

	public FontStyle get_unityFontStyleAndWeight() { }

	public OverflowClipBox get_unityOverflowClipBox() { }

	public Length get_unityParagraphSpacing() { }

	public int get_unitySliceBottom() { }

	public int get_unitySliceLeft() { }

	public int get_unitySliceRight() { }

	public float get_unitySliceScale() { }

	public int get_unitySliceTop() { }

	public TextAnchor get_unityTextAlign() { }

	public Color get_unityTextOutlineColor() { }

	public float get_unityTextOutlineWidth() { }

	public TextOverflowPosition get_unityTextOverflowPosition() { }

	public Visibility get_visibility() { }

	public WhiteSpace get_whiteSpace() { }

	public Length get_width() { }

	public Length get_wordSpacing() { }

	public void Release() { }

	private void RemoveCustomStyleProperty(StylePropertyReader reader) { }

	private void ResetComputedTransitions() { }

	public static bool StartAnimation(VisualElement element, StylePropertyId id, ref ComputedStyle oldStyle, ref ComputedStyle newStyle, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	public static bool StartAnimationAllProperty(VisualElement element, ref ComputedStyle oldStyle, ref ComputedStyle newStyle, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	public static bool StartAnimationInline(VisualElement element, StylePropertyId id, ref ComputedStyle computedStyle, StyleValue sv, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	public static bool StartAnimationInlineTranslate(VisualElement element, ref ComputedStyle computedStyle, StyleTranslate translate, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	public void SyncWithLayout(YogaNode targetNode) { }

}

