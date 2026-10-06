namespace System.Runtime.Serialization.Formatters.Binary;

internal sealed class BinaryObjectString
{
	internal int objectId; //Field offset: 0x10
	internal string value; //Field offset: 0x18

	internal BinaryObjectString() { }

	public void Dump() { }

	public override void Read(__BinaryParser input) { }

	internal void Set(int objectId, string value) { }

	public override void Write(__BinaryWriter sout) { }

}

