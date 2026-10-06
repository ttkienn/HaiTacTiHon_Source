namespace UnityEngine.UIElements;

internal class UITKTextHandle : TextHandle
{
	internal static readonly float k_MinPadding; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Vector2 <MeasuredSizes>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Vector2 <RoundedSizes>k__BackingField; //Field offset: 0x40
	private TextElement m_TextElement; //Field offset: 0x48
	internal bool isOverridingCursor; //Field offset: 0x50
	internal int currentLinkIDHash; //Field offset: 0x54
	internal bool hasLinkTag; //Field offset: 0x58
	internal bool hasATag; //Field offset: 0x59

	public Vector2 MeasuredSizes
	{
		[CompilerGenerated]
		 get { } //Length: 19
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public Vector2 RoundedSizes
	{
		[CompilerGenerated]
		 get { } //Length: 19
		[CompilerGenerated]
		 set { } //Length: 5
	}

	private static UITKTextHandle() { }

	public UITKTextHandle(TextElement te) { }

	private void ATagOnPointerMove(PointerMoveEvent pme) { }

	private void ATagOnPointerOut(PointerOutEvent _) { }

	private void ATagOnPointerOver(PointerOverEvent _) { }

	private void ATagOnPointerUp(PointerUpEvent pue) { }

	public float ComputeTextHeight(string textToMeasure, float width, float height) { }

	public float ComputeTextWidth(string textToMeasure, bool wordWrap, float width, float height) { }

	internal void ConvertUssToTextGenerationSettings(TextGenerationSettings tgs) { }

	[CompilerGenerated]
	public Vector2 get_MeasuredSizes() { }

	[CompilerGenerated]
	public Vector2 get_RoundedSizes() { }

	internal float GetTextEffectPadding(FontAsset fontAsset) { }

	private TextOverflowMode GetTextOverflowMode() { }

	private void HandleATag() { }

	private void HandleLinkTag() { }

	internal void LinkTagOnPointerDown(PointerDownEvent pde) { }

	internal void LinkTagOnPointerMove(PointerMoveEvent pme) { }

	private void LinkTagOnPointerOut(PointerOutEvent poe) { }

	internal void LinkTagOnPointerUp(PointerUpEvent pue) { }

	[CompilerGenerated]
	public void set_MeasuredSizes(Vector2 value) { }

	[CompilerGenerated]
	public void set_RoundedSizes(Vector2 value) { }

	internal bool TextLibraryCanElide() { }

	public TextInfo Update() { }

}

