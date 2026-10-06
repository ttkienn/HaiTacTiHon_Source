namespace UnityEngine;

[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule", "Unity.UIElements"}])]
internal class GUILayoutGroup : GUILayoutEntry
{
	private static readonly GUILayoutEntry none; //Field offset: 0x0
	public List<GUILayoutEntry> entries; //Field offset: 0x48
	public bool isVertical; //Field offset: 0x50
	public bool resetCoords; //Field offset: 0x51
	public float spacing; //Field offset: 0x54
	public bool sameSize; //Field offset: 0x58
	public bool isWindow; //Field offset: 0x59
	public int windowID; //Field offset: 0x5C
	private int m_Cursor; //Field offset: 0x60
	protected int m_StretchableCountX; //Field offset: 0x64
	protected int m_StretchableCountY; //Field offset: 0x68
	protected bool m_UserSpecifiedWidth; //Field offset: 0x6C
	protected bool m_UserSpecifiedHeight; //Field offset: 0x6D
	protected float m_ChildMinWidth; //Field offset: 0x70
	protected float m_ChildMaxWidth; //Field offset: 0x74
	protected float m_ChildMinHeight; //Field offset: 0x78
	protected float m_ChildMaxHeight; //Field offset: 0x7C
	protected int m_MarginLeft; //Field offset: 0x80
	protected int m_MarginRight; //Field offset: 0x84
	protected int m_MarginTop; //Field offset: 0x88
	protected int m_MarginBottom; //Field offset: 0x8C

	public virtual int marginBottom
	{
		 get { } //Length: 7
	}

	public virtual int marginLeft
	{
		 get { } //Length: 7
	}

	public virtual int marginRight
	{
		 get { } //Length: 7
	}

	public virtual int marginTop
	{
		 get { } //Length: 7
	}

	private static GUILayoutGroup() { }

	public GUILayoutGroup() { }

	public void Add(GUILayoutEntry e) { }

	public virtual void ApplyOptions(GUILayoutOption[] options) { }

	protected virtual void ApplyStyleSettings(GUIStyle style) { }

	public virtual void CalcHeight() { }

	public virtual void CalcWidth() { }

	public virtual int get_marginBottom() { }

	public virtual int get_marginLeft() { }

	public virtual int get_marginRight() { }

	public virtual int get_marginTop() { }

	public GUILayoutEntry GetNext() { }

	public void ResetCursor() { }

	public virtual void SetHorizontal(float x, float width) { }

	public virtual void SetVertical(float y, float height) { }

	public virtual string ToString() { }

}

