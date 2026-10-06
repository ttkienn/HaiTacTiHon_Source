namespace System.Runtime.Serialization.Formatters.Binary;

internal sealed class PrimitiveArray
{
	private InternalPrimitiveTypeE code; //Field offset: 0x10
	private Boolean[] booleanA; //Field offset: 0x18
	private Char[] charA; //Field offset: 0x20
	private Double[] doubleA; //Field offset: 0x28
	private Int16[] int16A; //Field offset: 0x30
	private Int32[] int32A; //Field offset: 0x38
	private Int64[] int64A; //Field offset: 0x40
	private SByte[] sbyteA; //Field offset: 0x48
	private Single[] singleA; //Field offset: 0x50
	private UInt16[] uint16A; //Field offset: 0x58
	private UInt32[] uint32A; //Field offset: 0x60
	private UInt64[] uint64A; //Field offset: 0x68

	internal PrimitiveArray(InternalPrimitiveTypeE code, Array array) { }

	internal void Init(InternalPrimitiveTypeE code, Array array) { }

	internal void SetValue(string value, int index) { }

}

