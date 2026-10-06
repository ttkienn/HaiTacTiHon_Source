namespace UnityEngine;

public sealed class AddComponentMenu : Attribute
{
	private string m_AddComponentMenu; //Field offset: 0x10
	private int m_Ordering; //Field offset: 0x18

	public AddComponentMenu(string menuName) { }

	public AddComponentMenu(string menuName, int order) { }

}

