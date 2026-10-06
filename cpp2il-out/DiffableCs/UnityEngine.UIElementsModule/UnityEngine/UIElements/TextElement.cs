namespace UnityEngine.UIElements;

public class TextElement : BindableElement, INotifyValueChanged<String>, ITextEdition, IExperimentalFeatures, ITextSelection
{
	internal class UxmlFactory : UxmlFactory<TextElement, UxmlTraits>
	{

		public UxmlFactory() { }

	}

	internal class UxmlTraits : UxmlTraits
	{
		private UxmlStringAttributeDescription m_Text; //Field offset: 0x78
		private UxmlBoolAttributeDescription m_EnableRichText; //Field offset: 0x80
		private UxmlBoolAttributeDescription m_ParseEscapeSequences; //Field offset: 0x88
		private UxmlBoolAttributeDescription m_DisplayTooltipWhenElided; //Field offset: 0x90

		public UxmlTraits() { }

		public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	}

	public static readonly string ussClassName; //Field offset: 0x0
	internal static readonly string k_EllipsisText; //Field offset: 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private UITKTextHandle <uitkTextHandle>k__BackingField; //Field offset: 0x3D8
	private string m_Text; //Field offset: 0x3E0
	private bool m_EnableRichText; //Field offset: 0x3E8
	private bool m_ParseEscapeSequences; //Field offset: 0x3E9
	private bool m_DisplayTooltipWhenElided; //Field offset: 0x3EA
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <isElided>k__BackingField; //Field offset: 0x3EB
	internal string elidedText; //Field offset: 0x3F0
	private bool m_WasElided; //Field offset: 0x3F8
	internal TextEditingManipulator editingManipulator; //Field offset: 0x400
	private bool m_Multiline; //Field offset: 0x408
	internal TouchScreenKeyboard m_TouchScreenKeyboard; //Field offset: 0x410
	internal TouchScreenKeyboardType m_KeyboardType; //Field offset: 0x418
	private bool m_HideMobileInput; //Field offset: 0x41C
	private bool m_IsReadOnly; //Field offset: 0x41D
	private int m_MaxLength; //Field offset: 0x420
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <UnityEngine.UIElements.ITextEdition.isDelayed>k__BackingField; //Field offset: 0x424
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Func<Char, Boolean> <UnityEngine.UIElements.ITextEdition.AcceptCharacter>k__BackingField; //Field offset: 0x428
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action<Boolean> <UnityEngine.UIElements.ITextEdition.UpdateScrollOffset>k__BackingField; //Field offset: 0x430
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action <UnityEngine.UIElements.ITextEdition.UpdateValueFromText>k__BackingField; //Field offset: 0x438
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action <UnityEngine.UIElements.ITextEdition.UpdateTextFromValue>k__BackingField; //Field offset: 0x440
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action <UnityEngine.UIElements.ITextEdition.MoveFocusToCompositeRoot>k__BackingField; //Field offset: 0x448
	private string m_RenderedText; //Field offset: 0x450
	private string m_OriginalText; //Field offset: 0x458
	private char m_MaskChar; //Field offset: 0x460
	private bool m_IsPassword; //Field offset: 0x462
	private bool m_AutoCorrection; //Field offset: 0x463
	private TextSelectingManipulator m_SelectingManipulator; //Field offset: 0x468
	private bool m_IsSelectable; //Field offset: 0x470
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <UnityEngine.UIElements.ITextSelection.doubleClickSelectsWord>k__BackingField; //Field offset: 0x471
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <UnityEngine.UIElements.ITextSelection.tripleClickSelectsLine>k__BackingField; //Field offset: 0x472
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <UnityEngine.UIElements.ITextSelection.selectAllOnFocus>k__BackingField; //Field offset: 0x473
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <UnityEngine.UIElements.ITextSelection.selectAllOnMouseUp>k__BackingField; //Field offset: 0x474
	private Color m_SelectionColor; //Field offset: 0x478
	private Color m_CursorColor; //Field offset: 0x488
	private float m_CursorWidth; //Field offset: 0x498

	public bool displayTooltipWhenElided
	{
		 get { } //Length: 8
		 set { } //Length: 51
	}

	internal ITextEdition edition
	{
		internal get { } //Length: 4
	}

	private char effectiveMaskChar
	{
		private get { } //Length: 92
	}

	public bool enableRichText
	{
		 get { } //Length: 8
		 set { } //Length: 22
	}

	internal bool hasFocus
	{
		internal get { } //Length: 119
	}

	public private bool isElided
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	internal string originalText
	{
		internal get { } //Length: 8
	}

	public bool parseEscapeSequences
	{
		 get { } //Length: 8
		 set { } //Length: 22
	}

	internal string renderedText
	{
		internal get { } //Length: 331
		internal set { } //Length: 94
	}

	internal TextSelectingManipulator selectingManipulator
	{
		internal get { } //Length: 119
	}

	public ITextSelection selection
	{
		 get { } //Length: 4
	}

	public override string text
	{
		 get { } //Length: 59
		 set { } //Length: 77
	}

	internal UITKTextHandle uitkTextHandle
	{
		[CompilerGenerated]
		internal get { } //Length: 8
		[CompilerGenerated]
		internal set { } //Length: 19
	}

	private override string UnityEngine.UIElements.INotifyValueChanged<System.String>.value
	{
		private get { } //Length: 72
		private set { } //Length: 403
	}

	private override Func<Char, Boolean> UnityEngine.UIElements.ITextEdition.AcceptCharacter
	{
		[CompilerGenerated]
		private get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 19
	}

	private override bool UnityEngine.UIElements.ITextEdition.autoCorrection
	{
		private get { } //Length: 8
		private set { } //Length: 7
	}

	private override bool UnityEngine.UIElements.ITextEdition.hideMobileInput
	{
		private get { } //Length: 101
		private set { } //Length: 123
	}

	private override bool UnityEngine.UIElements.ITextEdition.isDelayed
	{
		[CompilerGenerated]
		private get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	private override bool UnityEngine.UIElements.ITextEdition.isPassword
	{
		private get { } //Length: 8
		private set { } //Length: 28
	}

	private override bool UnityEngine.UIElements.ITextEdition.isReadOnly
	{
		private get { } //Length: 34
		private set { } //Length: 141
	}

	private override TouchScreenKeyboardType UnityEngine.UIElements.ITextEdition.keyboardType
	{
		private get { } //Length: 7
		private set { } //Length: 7
	}

	private override char UnityEngine.UIElements.ITextEdition.maskChar
	{
		private set { } //Length: 111
	}

	private override int UnityEngine.UIElements.ITextEdition.maxLength
	{
		private get { } //Length: 7
		private set { } //Length: 130
	}

	private override Action UnityEngine.UIElements.ITextEdition.MoveFocusToCompositeRoot
	{
		[CompilerGenerated]
		private get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 19
	}

	private override bool UnityEngine.UIElements.ITextEdition.multiline
	{
		private get { } //Length: 8
		private set { } //Length: 125
	}

	private override Action<Boolean> UnityEngine.UIElements.ITextEdition.UpdateScrollOffset
	{
		[CompilerGenerated]
		private get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 19
	}

	private override Action UnityEngine.UIElements.ITextEdition.UpdateTextFromValue
	{
		[CompilerGenerated]
		private get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 19
	}

	private override Action UnityEngine.UIElements.ITextEdition.UpdateValueFromText
	{
		[CompilerGenerated]
		private get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 19
	}

	private override Color UnityEngine.UIElements.ITextSelection.cursorColor
	{
		private get { } //Length: 14
		private set { } //Length: 124
	}

	private override int UnityEngine.UIElements.ITextSelection.cursorIndex
	{
		private get { } //Length: 109
		private set { } //Length: 113
	}

	private override Vector2 UnityEngine.UIElements.ITextSelection.cursorPosition
	{
		private get { } //Length: 170
	}

	private override float UnityEngine.UIElements.ITextSelection.cursorWidth
	{
		private get { } //Length: 9
	}

	private override bool UnityEngine.UIElements.ITextSelection.doubleClickSelectsWord
	{
		[CompilerGenerated]
		private get { } //Length: 8
	}

	private override bool UnityEngine.UIElements.ITextSelection.isSelectable
	{
		private get { } //Length: 27
		private set { } //Length: 18
	}

	private override float UnityEngine.UIElements.ITextSelection.lineHeightAtCursorPosition
	{
		private get { } //Length: 101
	}

	private override bool UnityEngine.UIElements.ITextSelection.selectAllOnFocus
	{
		[CompilerGenerated]
		private get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	private override bool UnityEngine.UIElements.ITextSelection.selectAllOnMouseUp
	{
		[CompilerGenerated]
		private get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	private override int UnityEngine.UIElements.ITextSelection.selectIndex
	{
		private get { } //Length: 109
		private set { } //Length: 113
	}

	private override Color UnityEngine.UIElements.ITextSelection.selectionColor
	{
		private get { } //Length: 14
		private set { } //Length: 124
	}

	private override bool UnityEngine.UIElements.ITextSelection.tripleClickSelectsLine
	{
		[CompilerGenerated]
		private get { } //Length: 8
	}

	private static TextElement() { }

	public TextElement() { }

	private void BuildContextualMenu(ContextualMenuPopulateEvent evt) { }

	private void Copy(DropdownMenuAction a) { }

	private Status CopyActionStatus(DropdownMenuAction a) { }

	private void Cut(DropdownMenuAction a) { }

	private Status CutActionStatus(DropdownMenuAction a) { }

	protected private virtual Vector2 DoMeasure(float desiredWidth, MeasureMode widthMode, float desiredHeight, MeasureMode heightMode) { }

	internal void DrawCaret(MeshGenerationContext mgc) { }

	private void DrawHighlighting(MeshGenerationContext mgc) { }

	internal string ElideText(string drawText, string ellipsisText, float width, TextOverflowPosition textOverflowPosition) { }

	[EventInterest(new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(ContextualMenuPopulateEvent), typeof(FocusInEvent), typeof(FocusOutEvent), typeof(KeyDownEvent), typeof(KeyUpEvent), typeof(FocusEvent), typeof(BlurEvent), typeof(ValidateCommandEvent), typeof(ExecuteCommandEvent), typeof(PointerDownEvent), typeof(PointerUpEvent), typeof(PointerMoveEvent), typeof(NavigationMoveEvent), typeof(NavigationSubmitEvent), typeof(NavigationCancelEvent)}])]
	protected virtual void ExecuteDefaultActionAtTarget(EventBase evt) { }

	public bool get_displayTooltipWhenElided() { }

	internal ITextEdition get_edition() { }

	private char get_effectiveMaskChar() { }

	public bool get_enableRichText() { }

	internal bool get_hasFocus() { }

	[CompilerGenerated]
	public bool get_isElided() { }

	internal string get_originalText() { }

	public bool get_parseEscapeSequences() { }

	internal string get_renderedText() { }

	internal TextSelectingManipulator get_selectingManipulator() { }

	public ITextSelection get_selection() { }

	public override string get_text() { }

	[CompilerGenerated]
	internal UITKTextHandle get_uitkTextHandle() { }

	private int GetLastCharacterAt(int lineIndex) { }

	public Vector2 MeasureTextSize(string textToMeasure, float width, MeasureMode widthMode, float height, MeasureMode heightMode) { }

	internal void OnGenerateVisualContent(MeshGenerationContext mgc) { }

	private void OnGeometryChanged(GeometryChangedEvent e) { }

	private void Paste(DropdownMenuAction a) { }

	private Status PasteActionStatus(DropdownMenuAction a) { }

	private void ProcessMenuCommand(string command) { }

	public void set_displayTooltipWhenElided(bool value) { }

	public void set_enableRichText(bool value) { }

	[CompilerGenerated]
	private void set_isElided(bool value) { }

	public void set_parseEscapeSequences(bool value) { }

	internal void set_renderedText(string value) { }

	public override void set_text(string value) { }

	[CompilerGenerated]
	internal void set_uitkTextHandle(UITKTextHandle value) { }

	private bool ShouldElide() { }

	private override string UnityEngine.UIElements.INotifyValueChanged<System.String>.get_value() { }

	private override void UnityEngine.UIElements.INotifyValueChanged<System.String>.set_value(string value) { }

	private override void UnityEngine.UIElements.INotifyValueChanged<System.String>.SetValueWithoutNotify(string newValue) { }

	private override string UnityEngine.UIElements.ITextEdition.CullString(string s) { }

	[CompilerGenerated]
	private override Func<Char, Boolean> UnityEngine.UIElements.ITextEdition.get_AcceptCharacter() { }

	private override bool UnityEngine.UIElements.ITextEdition.get_autoCorrection() { }

	private override bool UnityEngine.UIElements.ITextEdition.get_hideMobileInput() { }

	[CompilerGenerated]
	private override bool UnityEngine.UIElements.ITextEdition.get_isDelayed() { }

	private override bool UnityEngine.UIElements.ITextEdition.get_isPassword() { }

	private override bool UnityEngine.UIElements.ITextEdition.get_isReadOnly() { }

	private override TouchScreenKeyboardType UnityEngine.UIElements.ITextEdition.get_keyboardType() { }

	private override int UnityEngine.UIElements.ITextEdition.get_maxLength() { }

	[CompilerGenerated]
	private override Action UnityEngine.UIElements.ITextEdition.get_MoveFocusToCompositeRoot() { }

	private override bool UnityEngine.UIElements.ITextEdition.get_multiline() { }

	[CompilerGenerated]
	private override Action<Boolean> UnityEngine.UIElements.ITextEdition.get_UpdateScrollOffset() { }

	[CompilerGenerated]
	private override Action UnityEngine.UIElements.ITextEdition.get_UpdateTextFromValue() { }

	[CompilerGenerated]
	private override Action UnityEngine.UIElements.ITextEdition.get_UpdateValueFromText() { }

	private override void UnityEngine.UIElements.ITextEdition.RestoreValueAndText() { }

	private override void UnityEngine.UIElements.ITextEdition.SaveValueAndText() { }

	[CompilerGenerated]
	private override void UnityEngine.UIElements.ITextEdition.set_AcceptCharacter(Func<Char, Boolean> value) { }

	private override void UnityEngine.UIElements.ITextEdition.set_autoCorrection(bool value) { }

	private override void UnityEngine.UIElements.ITextEdition.set_hideMobileInput(bool value) { }

	[CompilerGenerated]
	private override void UnityEngine.UIElements.ITextEdition.set_isDelayed(bool value) { }

	private override void UnityEngine.UIElements.ITextEdition.set_isPassword(bool value) { }

	private override void UnityEngine.UIElements.ITextEdition.set_isReadOnly(bool value) { }

	private override void UnityEngine.UIElements.ITextEdition.set_keyboardType(TouchScreenKeyboardType value) { }

	private override void UnityEngine.UIElements.ITextEdition.set_maskChar(char value) { }

	private override void UnityEngine.UIElements.ITextEdition.set_maxLength(int value) { }

	[CompilerGenerated]
	private override void UnityEngine.UIElements.ITextEdition.set_MoveFocusToCompositeRoot(Action value) { }

	private override void UnityEngine.UIElements.ITextEdition.set_multiline(bool value) { }

	[CompilerGenerated]
	private override void UnityEngine.UIElements.ITextEdition.set_UpdateScrollOffset(Action<Boolean> value) { }

	[CompilerGenerated]
	private override void UnityEngine.UIElements.ITextEdition.set_UpdateTextFromValue(Action value) { }

	[CompilerGenerated]
	private override void UnityEngine.UIElements.ITextEdition.set_UpdateValueFromText(Action value) { }

	private override void UnityEngine.UIElements.ITextEdition.UpdateText(string value) { }

	private override Color UnityEngine.UIElements.ITextSelection.get_cursorColor() { }

	private override int UnityEngine.UIElements.ITextSelection.get_cursorIndex() { }

	private override Vector2 UnityEngine.UIElements.ITextSelection.get_cursorPosition() { }

	private override float UnityEngine.UIElements.ITextSelection.get_cursorWidth() { }

	[CompilerGenerated]
	private override bool UnityEngine.UIElements.ITextSelection.get_doubleClickSelectsWord() { }

	private override bool UnityEngine.UIElements.ITextSelection.get_isSelectable() { }

	private override float UnityEngine.UIElements.ITextSelection.get_lineHeightAtCursorPosition() { }

	[CompilerGenerated]
	private override bool UnityEngine.UIElements.ITextSelection.get_selectAllOnFocus() { }

	[CompilerGenerated]
	private override bool UnityEngine.UIElements.ITextSelection.get_selectAllOnMouseUp() { }

	private override int UnityEngine.UIElements.ITextSelection.get_selectIndex() { }

	private override Color UnityEngine.UIElements.ITextSelection.get_selectionColor() { }

	[CompilerGenerated]
	private override bool UnityEngine.UIElements.ITextSelection.get_tripleClickSelectsLine() { }

	private override bool UnityEngine.UIElements.ITextSelection.HasSelection() { }

	private override void UnityEngine.UIElements.ITextSelection.SelectAll() { }

	private override void UnityEngine.UIElements.ITextSelection.SelectNone() { }

	private override void UnityEngine.UIElements.ITextSelection.set_cursorColor(Color value) { }

	private override void UnityEngine.UIElements.ITextSelection.set_cursorIndex(int value) { }

	private override void UnityEngine.UIElements.ITextSelection.set_isSelectable(bool value) { }

	[CompilerGenerated]
	private override void UnityEngine.UIElements.ITextSelection.set_selectAllOnFocus(bool value) { }

	[CompilerGenerated]
	private override void UnityEngine.UIElements.ITextSelection.set_selectAllOnMouseUp(bool value) { }

	private override void UnityEngine.UIElements.ITextSelection.set_selectIndex(int value) { }

	private override void UnityEngine.UIElements.ITextSelection.set_selectionColor(Color value) { }

	private void UpdateTooltip() { }

	private void UpdateVisibleText() { }

}

