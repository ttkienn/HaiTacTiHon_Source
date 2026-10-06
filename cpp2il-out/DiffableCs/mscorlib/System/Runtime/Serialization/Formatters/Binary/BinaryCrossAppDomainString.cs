namespace System.Runtime.Serialization.Formatters.Binary;

internal sealed class BinaryCrossAppDomainString
{
	internal int objectId; //Field offset: 0x10
	internal int value; //Field offset: 0x14

	internal BinaryCrossAppDomainString() { }

	public void Dump() { }

	public override void Read(__BinaryParser input) { }

}

