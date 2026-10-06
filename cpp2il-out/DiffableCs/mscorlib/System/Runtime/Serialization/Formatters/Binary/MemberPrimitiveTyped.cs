namespace System.Runtime.Serialization.Formatters.Binary;

internal sealed class MemberPrimitiveTyped
{
	internal InternalPrimitiveTypeE primitiveTypeEnum; //Field offset: 0x10
	internal object value; //Field offset: 0x18

	internal MemberPrimitiveTyped() { }

	public void Dump() { }

	public override void Read(__BinaryParser input) { }

	internal void Set(InternalPrimitiveTypeE primitiveTypeEnum, object value) { }

	public override void Write(__BinaryWriter sout) { }

}

