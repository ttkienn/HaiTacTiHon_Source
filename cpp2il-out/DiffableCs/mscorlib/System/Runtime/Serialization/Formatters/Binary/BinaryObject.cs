namespace System.Runtime.Serialization.Formatters.Binary;

internal sealed class BinaryObject
{
	internal int objectId; //Field offset: 0x10
	internal int mapId; //Field offset: 0x14

	internal BinaryObject() { }

	public void Dump() { }

	public override void Read(__BinaryParser input) { }

	internal void Set(int objectId, int mapId) { }

	public override void Write(__BinaryWriter sout) { }

}

