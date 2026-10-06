namespace UnityEngine;

internal sealed class GUIWordWrapSizer : GUILayoutEntry
{
	private readonly GUIContent m_Content; //Field offset: 0x48
	private readonly float m_ForcedMinHeight; //Field offset: 0x50
	private readonly float m_ForcedMaxHeight; //Field offset: 0x54

	public GUIWordWrapSizer(GUIStyle style, GUIContent content, GUILayoutOption[] options) { }

	public virtual void CalcHeight() { }

	public virtual void CalcWidth() { }

}

