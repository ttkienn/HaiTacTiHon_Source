namespace UnityEngine.Yoga;

[DefaultMember("Item")]
internal class YogaNode : IEnumerable<YogaNode>, IEnumerable
{
	internal IntPtr _ygNode; //Field offset: 0x10
	private YogaConfig _config; //Field offset: 0x18
	private WeakReference _parent; //Field offset: 0x20
	private List<YogaNode> _children; //Field offset: 0x28
	private MeasureFunction _measureFunction; //Field offset: 0x30
	private BaselineFunction _baselineFunction; //Field offset: 0x38
	private object _data; //Field offset: 0x40

	public YogaAlign AlignContent
	{
		 set { } //Length: 65
	}

	public YogaAlign AlignItems
	{
		 set { } //Length: 65
	}

	public YogaAlign AlignSelf
	{
		 set { } //Length: 65
	}

	public float BorderBottomWidth
	{
		 set { } //Length: 73
	}

	public float BorderLeftWidth
	{
		 set { } //Length: 70
	}

	public float BorderRightWidth
	{
		 set { } //Length: 73
	}

	public float BorderTopWidth
	{
		 set { } //Length: 73
	}

	public YogaValue Bottom
	{
		 set { } //Length: 110
	}

	internal YogaConfig Config
	{
		internal set { } //Length: 182
	}

	public int Count
	{
		 get { } //Length: 65
	}

	public YogaDisplay Display
	{
		 set { } //Length: 65
	}

	public float Flex
	{
		 set { } //Length: 68
	}

	public YogaValue FlexBasis
	{
		 set { } //Length: 173
	}

	public YogaFlexDirection FlexDirection
	{
		 set { } //Length: 65
	}

	public float FlexGrow
	{
		 set { } //Length: 68
	}

	public float FlexShrink
	{
		 set { } //Length: 68
	}

	public bool HasNewLayout
	{
		 get { } //Length: 52
	}

	public YogaValue Height
	{
		 set { } //Length: 173
	}

	public bool IsBaselineDefined
	{
		 get { } //Length: 11
	}

	public bool IsDirty
	{
		 get { } //Length: 52
	}

	public bool IsMeasureDefined
	{
		 get { } //Length: 11
	}

	public YogaJustify JustifyContent
	{
		 set { } //Length: 65
	}

	public float LayoutBorderBottom
	{
		 get { } //Length: 57
	}

	public float LayoutBorderLeft
	{
		 get { } //Length: 54
	}

	public float LayoutBorderRight
	{
		 get { } //Length: 57
	}

	public float LayoutBorderTop
	{
		 get { } //Length: 57
	}

	public float LayoutBottom
	{
		 get { } //Length: 52
	}

	public float LayoutHeight
	{
		 get { } //Length: 52
	}

	public float LayoutMarginBottom
	{
		 get { } //Length: 57
	}

	public float LayoutMarginLeft
	{
		 get { } //Length: 54
	}

	public float LayoutMarginRight
	{
		 get { } //Length: 57
	}

	public float LayoutMarginTop
	{
		 get { } //Length: 57
	}

	public float LayoutPaddingBottom
	{
		 get { } //Length: 57
	}

	public float LayoutPaddingLeft
	{
		 get { } //Length: 54
	}

	public float LayoutPaddingRight
	{
		 get { } //Length: 57
	}

	public float LayoutPaddingTop
	{
		 get { } //Length: 57
	}

	public float LayoutRight
	{
		 get { } //Length: 52
	}

	public float LayoutWidth
	{
		 get { } //Length: 52
	}

	public float LayoutX
	{
		 get { } //Length: 52
	}

	public float LayoutY
	{
		 get { } //Length: 52
	}

	public YogaValue Left
	{
		 set { } //Length: 124
	}

	public YogaValue MarginBottom
	{
		 set { } //Length: 16
	}

	public YogaValue MarginLeft
	{
		 set { } //Length: 13
	}

	public YogaValue MarginRight
	{
		 set { } //Length: 16
	}

	public YogaValue MarginTop
	{
		 set { } //Length: 16
	}

	public YogaValue MaxHeight
	{
		 set { } //Length: 119
	}

	public YogaValue MaxWidth
	{
		 set { } //Length: 119
	}

	public YogaValue MinHeight
	{
		 set { } //Length: 119
	}

	public YogaValue MinWidth
	{
		 set { } //Length: 119
	}

	public YogaOverflow Overflow
	{
		 set { } //Length: 65
	}

	public YogaValue PaddingBottom
	{
		 set { } //Length: 110
	}

	public YogaValue PaddingLeft
	{
		 set { } //Length: 124
	}

	public YogaValue PaddingRight
	{
		 set { } //Length: 110
	}

	public YogaValue PaddingTop
	{
		 set { } //Length: 110
	}

	public YogaPositionType PositionType
	{
		 set { } //Length: 65
	}

	public YogaValue Right
	{
		 set { } //Length: 110
	}

	public YogaValue Top
	{
		 set { } //Length: 110
	}

	public YogaValue Width
	{
		 set { } //Length: 173
	}

	public YogaWrap Wrap
	{
		 set { } //Length: 65
	}

	public YogaNode(YogaConfig config = null) { }

	public static float BaselineInternal(YogaNode node, float width, float height) { }

	public void CalculateLayout(float width = NaN, float height = NaN) { }

	public void Clear() { }

	public void CopyStyle(YogaNode srcNode) { }

	protected virtual void Finalize() { }

	public int get_Count() { }

	public bool get_HasNewLayout() { }

	public bool get_IsBaselineDefined() { }

	public bool get_IsDirty() { }

	public bool get_IsMeasureDefined() { }

	public float get_LayoutBorderBottom() { }

	public float get_LayoutBorderLeft() { }

	public float get_LayoutBorderRight() { }

	public float get_LayoutBorderTop() { }

	public float get_LayoutBottom() { }

	public float get_LayoutHeight() { }

	public float get_LayoutMarginBottom() { }

	public float get_LayoutMarginLeft() { }

	public float get_LayoutMarginRight() { }

	public float get_LayoutMarginTop() { }

	public float get_LayoutPaddingBottom() { }

	public float get_LayoutPaddingLeft() { }

	public float get_LayoutPaddingRight() { }

	public float get_LayoutPaddingTop() { }

	public float get_LayoutRight() { }

	public float get_LayoutWidth() { }

	public float get_LayoutX() { }

	public float get_LayoutY() { }

	public override IEnumerator<YogaNode> GetEnumerator() { }

	public void Insert(int index, YogaNode node) { }

	public override void MarkDirty() { }

	public void MarkLayoutSeen() { }

	public static YogaSize MeasureInternal(YogaNode node, float width, YogaMeasureMode widthMode, float height, YogaMeasureMode heightMode) { }

	public void RemoveAt(int index) { }

	public void set_AlignContent(YogaAlign value) { }

	public void set_AlignItems(YogaAlign value) { }

	public void set_AlignSelf(YogaAlign value) { }

	public void set_BorderBottomWidth(float value) { }

	public void set_BorderLeftWidth(float value) { }

	public void set_BorderRightWidth(float value) { }

	public void set_BorderTopWidth(float value) { }

	public void set_Bottom(YogaValue value) { }

	internal void set_Config(YogaConfig value) { }

	public void set_Display(YogaDisplay value) { }

	public void set_Flex(float value) { }

	public void set_FlexBasis(YogaValue value) { }

	public void set_FlexDirection(YogaFlexDirection value) { }

	public void set_FlexGrow(float value) { }

	public void set_FlexShrink(float value) { }

	public void set_Height(YogaValue value) { }

	public void set_JustifyContent(YogaJustify value) { }

	public void set_Left(YogaValue value) { }

	public void set_MarginBottom(YogaValue value) { }

	public void set_MarginLeft(YogaValue value) { }

	public void set_MarginRight(YogaValue value) { }

	public void set_MarginTop(YogaValue value) { }

	public void set_MaxHeight(YogaValue value) { }

	public void set_MaxWidth(YogaValue value) { }

	public void set_MinHeight(YogaValue value) { }

	public void set_MinWidth(YogaValue value) { }

	public void set_Overflow(YogaOverflow value) { }

	public void set_PaddingBottom(YogaValue value) { }

	public void set_PaddingLeft(YogaValue value) { }

	public void set_PaddingRight(YogaValue value) { }

	public void set_PaddingTop(YogaValue value) { }

	public void set_PositionType(YogaPositionType value) { }

	public void set_Right(YogaValue value) { }

	public void set_Top(YogaValue value) { }

	public void set_Width(YogaValue value) { }

	public void set_Wrap(YogaWrap value) { }

	public void SetMeasureFunction(MeasureFunction measureFunction) { }

	private void SetStyleMargin(YogaEdge edge, YogaValue value) { }

	private void SetStylePadding(YogaEdge edge, YogaValue value) { }

	private void SetStylePosition(YogaEdge edge, YogaValue value) { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

