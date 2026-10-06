namespace UnityEngine.UIElements;

internal struct StyleValueHandle
{
	[SerializeField]
	private StyleValueType m_ValueType; //Field offset: 0x0
	[SerializeField]
	internal int valueIndex; //Field offset: 0x4

	public internal StyleValueType valueType
	{
		 get { } //Length: 5
		internal set { } //Length: 3
	}

	public StyleValueType get_valueType() { }

	internal void set_valueType(StyleValueType value) { }

}

