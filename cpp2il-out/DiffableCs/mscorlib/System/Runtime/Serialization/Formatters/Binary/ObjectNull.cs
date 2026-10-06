namespace System.Runtime.Serialization.Formatters.Binary;

internal sealed class ObjectNull
{
	internal int nullCount; //Field offset: 0x10

	internal ObjectNull() { }

	public void Dump() { }

	public void Read(__BinaryParser input, BinaryHeaderEnum binaryHeaderEnum) { }

	internal void SetNullCount(int nullCount) { }

	public override void Write(__BinaryWriter sout) { }

}

