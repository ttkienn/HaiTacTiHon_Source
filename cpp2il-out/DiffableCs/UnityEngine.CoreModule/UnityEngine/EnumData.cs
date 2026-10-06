namespace UnityEngine;

internal struct EnumData
{
	public Enum[] values; //Field offset: 0x0
	public Int32[] flagValues; //Field offset: 0x8
	public String[] displayNames; //Field offset: 0x10
	public String[] names; //Field offset: 0x18
	public String[] tooltip; //Field offset: 0x20
	public bool flags; //Field offset: 0x28
	public Type underlyingType; //Field offset: 0x30
	public bool unsigned; //Field offset: 0x38
	public bool serializable; //Field offset: 0x39

}

