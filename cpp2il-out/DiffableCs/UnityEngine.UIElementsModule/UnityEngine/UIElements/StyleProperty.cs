namespace UnityEngine.UIElements;

internal class StyleProperty
{
	[SerializeField]
	private string m_Name; //Field offset: 0x10
	[SerializeField]
	private int m_Line; //Field offset: 0x18
	[SerializeField]
	private StyleValueHandle[] m_Values; //Field offset: 0x20
	internal bool isCustomProperty; //Field offset: 0x28
	internal bool requireVariableResolve; //Field offset: 0x29

	public string name
	{
		 get { } //Length: 7
	}

	public StyleValueHandle[] values
	{
		 get { } //Length: 7
	}

	public StyleProperty() { }

	public string get_name() { }

	public StyleValueHandle[] get_values() { }

}

