namespace System.Runtime.Serialization.Formatters.Binary;

internal sealed class SerObjectInfoInit
{
	internal Hashtable seenBeforeTable; //Field offset: 0x10
	internal int objectInfoIdCount; //Field offset: 0x18
	internal SerStack oiPool; //Field offset: 0x20

	public SerObjectInfoInit() { }

}

