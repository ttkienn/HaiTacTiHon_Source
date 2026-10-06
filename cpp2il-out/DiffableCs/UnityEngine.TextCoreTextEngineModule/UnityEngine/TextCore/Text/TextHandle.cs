namespace UnityEngine.TextCore.Text;

internal class TextHandle
{
	private static TextInfo m_LayoutTextInfo; //Field offset: 0x0
	protected static TextGenerationSettings s_LayoutSettings; //Field offset: 0x8
	private Vector2 m_PreferredSize; //Field offset: 0x10
	private TextInfo m_TextInfo; //Field offset: 0x18
	private int m_PreviousGenerationSettingsHash; //Field offset: 0x20
	protected TextGenerationSettings textGenerationSettings; //Field offset: 0x28
	private bool isDirty; //Field offset: 0x30

	internal static TextInfo layoutTextInfo
	{
		internal get { } //Length: 238
	}

	internal TextInfo textInfo
	{
		internal get { } //Length: 105
	}

	private static TextHandle() { }

	public TextHandle() { }

	protected float ComputeTextHeight(TextGenerationSettings tgs) { }

	protected float ComputeTextWidth(TextGenerationSettings tgs) { }

	private static float DistanceToLine(Vector3 a, Vector3 b, Vector3 point) { }

	public int FindIntersectingLink(Vector3 position, bool inverseYAxis = true) { }

	public int FindNearestCharacterOnLine(Vector2 position, int line, bool visibleOnly) { }

	public int FindNearestLine(Vector2 position) { }

	internal static TextInfo get_layoutTextInfo() { }

	internal TextInfo get_textInfo() { }

	public float GetCharacterHeightFromIndex(int index) { }

	public int GetCursorIndexFromPosition(Vector2 position, bool inverseYAxis = true) { }

	public Vector2 GetCursorPositionFromStringIndexUsingCharacterHeight(int index, bool inverseYAxis = true) { }

	public Vector2 GetCursorPositionFromStringIndexUsingLineHeight(int index, bool useXAdvance = false, bool inverseYAxis = true) { }

	public float GetLineHeight(int lineNumber) { }

	public float GetLineHeightFromCharacterIndex(int index) { }

	public int GetLineNumber(int index) { }

	public int IndexOf(char value, int startIndex) { }

	public bool IsDirty() { }

	public bool IsElided() { }

	public int LastIndexOf(char value, int startIndex) { }

	public int LineDownCharacterPosition(int originalPos) { }

	public int LineUpCharacterPosition(int originalPos) { }

	private static bool PointIntersectRectangle(Vector3 m, Vector3 a, Vector3 b, Vector3 c, Vector3 d) { }

	public string Substring(int startIndex, int length) { }

	protected TextInfo Update(TextGenerationSettings tgs) { }

	protected void UpdatePreferredValues(TextGenerationSettings tgs) { }

}

