namespace System.Runtime.Serialization.Formatters.Binary;

internal sealed class MemberPrimitiveUnTyped
{
	internal InternalPrimitiveTypeE typeInformation; //Field offset: 0x10
	internal object value; //Field offset: 0x18

	internal MemberPrimitiveUnTyped() { }

	public void Dump() { }

	public override void Read(__BinaryParser input) { }

	internal void Set(InternalPrimitiveTypeE typeInformation, object value) { }

	internal void Set(InternalPrimitiveTypeE typeInformation) { }

	public override void Write(__BinaryWriter sout) { }

}

