namespace System.Xml.Serialization;

internal abstract class SerializationSource
{
	private Type[] includedTypes; //Field offset: 0x10
	private string namspace; //Field offset: 0x18
	private bool canBeGenerated; //Field offset: 0x20

	public SerializationSource(string namspace, Type[] includedTypes) { }

	protected bool BaseEquals(SerializationSource other) { }

}

