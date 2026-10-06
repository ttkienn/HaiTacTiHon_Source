namespace UnityEngine.UIElements;

internal class StyleRule
{
	[SerializeField]
	private StyleProperty[] m_Properties; //Field offset: 0x10
	[SerializeField]
	internal int line; //Field offset: 0x18
	internal int customPropertiesCount; //Field offset: 0x1C

	public StyleProperty[] properties
	{
		 get { } //Length: 7
	}

	public StyleRule() { }

	public StyleProperty[] get_properties() { }

}

