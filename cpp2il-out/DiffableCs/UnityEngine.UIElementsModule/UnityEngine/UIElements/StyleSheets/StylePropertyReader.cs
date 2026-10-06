namespace UnityEngine.UIElements.StyleSheets;

internal class StylePropertyReader
{
	public sealed class GetCursorIdFunction : MulticastDelegate
	{

		public GetCursorIdFunction(object object, IntPtr method) { }

		public override int Invoke(StyleSheet sheet, StyleValueHandle handle) { }

	}

	internal static GetCursorIdFunction getCursorIdFunc; //Field offset: 0x0
	private List<StylePropertyValue> m_Values; //Field offset: 0x10
	private List<Int32> m_ValueCount; //Field offset: 0x18
	private StyleVariableResolver m_Resolver; //Field offset: 0x20
	private StyleSheet m_Sheet; //Field offset: 0x28
	private StyleProperty[] m_Properties; //Field offset: 0x30
	private StylePropertyId[] m_PropertyIds; //Field offset: 0x38
	private int m_CurrentValueIndex; //Field offset: 0x40
	private int m_CurrentPropertyIndex; //Field offset: 0x44
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private StyleProperty <property>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private StylePropertyId <propertyId>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private int <valueCount>k__BackingField; //Field offset: 0x54
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private float <dpiScaling>k__BackingField; //Field offset: 0x58

	public private float dpiScaling
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		private set { } //Length: 6
	}

	public private StyleProperty property
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 13
	}

	public private StylePropertyId propertyId
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private int valueCount
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public StylePropertyReader() { }

	[CompilerGenerated]
	public float get_dpiScaling() { }

	[CompilerGenerated]
	public StyleProperty get_property() { }

	[CompilerGenerated]
	public StylePropertyId get_propertyId() { }

	[CompilerGenerated]
	public int get_valueCount() { }

	public StylePropertyValue GetValue(int index) { }

	public StyleValueType GetValueType(int index) { }

	public bool IsKeyword(int index, StyleValueKeyword keyword) { }

	public bool IsValueType(int index, StyleValueType type) { }

	private void LoadProperties() { }

	public StylePropertyId MoveNextProperty() { }

	public static Angle ReadAngle(StylePropertyValue value) { }

	public string ReadAsString(int index) { }

	public Background ReadBackground(int index) { }

	public static BackgroundPosition ReadBackgroundPosition(int valCount, StylePropertyValue val1, StylePropertyValue val2, BackgroundPositionKeyword keyword) { }

	private BackgroundPosition ReadBackgroundPosition(int index, BackgroundPositionKeyword keyword) { }

	public BackgroundPosition ReadBackgroundPositionX(int index) { }

	public BackgroundPosition ReadBackgroundPositionY(int index) { }

	public static BackgroundRepeat ReadBackgroundRepeat(int valCount, StylePropertyValue val1, StylePropertyValue val2) { }

	public BackgroundRepeat ReadBackgroundRepeat(int index) { }

	public static BackgroundSize ReadBackgroundSize(int valCount, StylePropertyValue val1, StylePropertyValue val2) { }

	public BackgroundSize ReadBackgroundSize(int index) { }

	public Color ReadColor(int index) { }

	public Cursor ReadCursor(int index) { }

	public int ReadEnum(StyleEnumType enumType, int index) { }

	private static int ReadEnum(StyleEnumType enumType, StylePropertyValue value) { }

	public float ReadFloat(int index) { }

	public Font ReadFont(int index) { }

	public FontDefinition ReadFontDefinition(int index) { }

	public int ReadInt(int index) { }

	public Length ReadLength(int index) { }

	public void ReadListEasingFunction(List<EasingFunction> list, int index) { }

	public void ReadListStylePropertyName(List<StylePropertyName> list, int index) { }

	public void ReadListTimeValue(List<TimeValue> list, int index) { }

	public Rotate ReadRotate(int index) { }

	public static Rotate ReadRotate(int valCount, StylePropertyValue val1, StylePropertyValue val2, StylePropertyValue val3, StylePropertyValue val4) { }

	public Scale ReadScale(int index) { }

	public static Scale ReadScale(int valCount, StylePropertyValue val1, StylePropertyValue val2, StylePropertyValue val3) { }

	public TextShadow ReadTextShadow(int index) { }

	public TimeValue ReadTimeValue(int index) { }

	public static TransformOrigin ReadTransformOrigin(int valCount, StylePropertyValue val1, StylePropertyValue val2, StylePropertyValue zVvalue) { }

	public TransformOrigin ReadTransformOrigin(int index) { }

	private static Length ReadTransformOriginEnum(StylePropertyValue value, out bool isVertical, out bool isHorizontal) { }

	public static Translate ReadTranslate(int valCount, StylePropertyValue val1, StylePropertyValue val2, StylePropertyValue val3) { }

	public Translate ReadTranslate(int index) { }

	[CompilerGenerated]
	private void set_dpiScaling(float value) { }

	[CompilerGenerated]
	private void set_property(StyleProperty value) { }

	[CompilerGenerated]
	private void set_propertyId(StylePropertyId value) { }

	[CompilerGenerated]
	private void set_valueCount(int value) { }

	public void SetContext(StyleSheet sheet, StyleComplexSelector selector, StyleVariableContext varContext, float dpiScaling = 1) { }

	private void SetCurrentProperty() { }

	public void SetInlineContext(StyleSheet sheet, StyleProperty[] properties, StylePropertyId[] propertyIds, float dpiScaling = 1) { }

	internal static bool TryGetImageSourceFromValue(StylePropertyValue propertyValue, float dpiScaling, out ImageSource source) { }

	private static bool TryReadEnum(StyleEnumType enumType, StylePropertyValue value, out int intValue) { }

}

