namespace UnityEngine;

[NativeHeader("Modules/IMGUI/GUISkin.bindings.h")]
public sealed class GUISettings
{
	[SerializeField]
	private bool m_DoubleClickSelectsWord; //Field offset: 0x10
	[SerializeField]
	private bool m_TripleClickSelectsLine; //Field offset: 0x11
	[SerializeField]
	private Color m_CursorColor; //Field offset: 0x14
	[SerializeField]
	private float m_CursorFlashSpeed; //Field offset: 0x24
	[SerializeField]
	private Color m_SelectionColor; //Field offset: 0x28

	public GUISettings() { }

}

