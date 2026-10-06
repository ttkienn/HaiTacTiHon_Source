namespace UnityEngine;

public class TextEditor
{
	internal enum DblClickSnapping
	{
		WORDS = 0,
		PARAGRAPHS = 1,
	}

	public TouchScreenKeyboard keyboardOnScreen; //Field offset: 0x10
	public int controlID; //Field offset: 0x18
	public GUIStyle style; //Field offset: 0x20
	public bool multiline; //Field offset: 0x28
	public bool hasHorizontalCursorPos; //Field offset: 0x29
	public bool isPasswordField; //Field offset: 0x2A
	public Vector2 scrollOffset; //Field offset: 0x2C
	private GUIContent m_Content; //Field offset: 0x38
	private int m_CursorIndex; //Field offset: 0x40
	private int m_SelectIndex; //Field offset: 0x44
	private bool m_RevealCursor; //Field offset: 0x48
	private bool m_MouseDragSelectsWholeWords; //Field offset: 0x49
	private int m_DblClickInitPos; //Field offset: 0x4C
	private DblClickSnapping m_DblClickSnap; //Field offset: 0x50
	private bool m_bJustSelected; //Field offset: 0x51
	private int m_iAltCursorPos; //Field offset: 0x54

	[RequiredByNativeCode]
	public TextEditor() { }

}

