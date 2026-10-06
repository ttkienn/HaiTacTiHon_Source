namespace System.Runtime.Serialization.Formatters.Binary;

internal sealed class MemberReference
{
	internal int idRef; //Field offset: 0x10

	internal MemberReference() { }

	public void Dump() { }

	public override void Read(__BinaryParser input) { }

	internal void Set(int idRef) { }

	public override void Write(__BinaryWriter sout) { }

}

